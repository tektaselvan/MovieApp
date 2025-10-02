using MovieApp.Data;
using MovieApp.Models;
using MovieApp.Models.Dtos;
using MovieApp.Models.Mappers;
using Newtonsoft.Json;
using System;
using System.Diagnostics;
using System.Globalization;
using System.Net.Http;
using System.Threading.Tasks;

namespace MovieApp.Services
{
    public class TmdbService
    {
        private readonly string _apiKey;
        private readonly HttpClient _http;
        private readonly MovieRepository _movieRepo;

        private string _imageBaseUrl;
        private string _posterSize;

        public TmdbService(string apiKey, MovieRepository movieRepo)
        {
            _apiKey = apiKey ?? throw new ArgumentNullException(nameof(apiKey));
            _movieRepo = movieRepo ?? throw new ArgumentNullException(nameof(movieRepo));
            _http = new HttpClient { BaseAddress = new Uri("https://api.themoviedb.org/3/") };
        }

        private async Task LoadConfigurationAsync()
        {
            if (!string.IsNullOrEmpty(_imageBaseUrl)) return;

            var url = $"configuration?api_key={_apiKey}";
            var json = await _http.GetStringAsync(url).ConfigureAwait(false);
            var cfg = JsonConvert.DeserializeObject<TmdbConfigurationResponse>(json);

            _imageBaseUrl = cfg.images.secure_base_url ?? cfg.images.base_url ?? "https://image.tmdb.org/t/p/";
            _posterSize = Array.Exists(cfg.images.poster_sizes, s => s == "w500") ? "w500" : cfg.images.poster_sizes[1];
        }
        public async Task<int> SeedMoviesAsync(int targetCount = 1000, Action<int> progressCallback = null)
        {
            await LoadConfigurationAsync().ConfigureAwait(false);

            int added = 0;
            int page = 1;

            while (added < targetCount)
            {
                try
                {
                    var url = $"discover/movie?api_key={_apiKey}&sort_by=popularity.desc&page={page}";
                    string json = await _http.GetStringAsync(url).ConfigureAwait(false);

                    var resp = JsonConvert.DeserializeObject<TmdbDiscoverResponse>(json);
                    if (resp?.results == null || resp.results.Count == 0) break;

                    foreach (var dto in resp.results)
                    {
                        if (added >= targetCount) break;

                        var existing = _movieRepo.GetByTmdbId(dto.id);
                        if (existing != null) continue;

                        DateTime? releaseDate = null;
                        if (DateTime.TryParseExact(dto.release_date, "yyyy-MM-dd", CultureInfo.InvariantCulture, DateTimeStyles.None, out var dt))
                            releaseDate = dt;

                        var posterFull = string.IsNullOrWhiteSpace(dto.poster_path)
                            ? null
                            : $"{_imageBaseUrl}{_posterSize}{dto.poster_path}";

                        var movie = new Movie
                        {
                            TMDBId = dto.id,
                            Title = dto.title ?? string.Empty,
                            Overview = dto.overview,
                            ReleaseDate = releaseDate,
                            PosterPath = posterFull,
                            IsManual = false
                        };

                        try
                        {
                            _movieRepo.AddMovie(movie);
                            added++;
                            progressCallback?.Invoke(added); // Progress callback
                        }
                        catch (Exception ex)
                        {
                            // Hata logu, işlem devam eder
                            Debug.WriteLine($"Movie eklenemedi: {movie.Title}, Hata: {ex.Message}");
                        }
                    }

                    if (resp.total_pages <= page) break;
                    page++;
                    await Task.Delay(250).ConfigureAwait(false);
                }
                catch (Exception ex)
                {
                    Debug.WriteLine($"API sayfa {page} alınamadı: {ex.Message}");
                    page++; // hata olsa bile diğer sayfaya geç
                }
            }

            return added;
        }
    }
}
