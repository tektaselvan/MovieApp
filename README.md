# MovieApp

MovieApp, kullanıcıların filmleri görüntüleyebileceği, puanlayabileceği ve arkadaşlarına tavsiye edebileceği basit bir Windows Forms uygulamasıdır.  
Uygulama **.NET Framework 4.6.1**, **C#**, **DevExpress** kullanılarak geliştirilmiştir ve veri erişimi **ADO.NET** ile sağlanmıştır. Veritabanı **MSSQL**’dir.

---

## Özellikler

### 1. Film Verileri
- TheMovieDB API kullanılarak popüler filmler çekilir.
- Maksimum **1000 film** çekilebilir.
- Manuel olarak film ekleme özelliği mevcuttur.
- API’den çekilen ve manuel eklenen filmler **ayrılabilir** (`IsManual` alanı).
- Film silme işlemleri **soft delete** ile yapılır (`IsDeleted` alanı).

### 2. Film Görüntüleme
- Tüm filmler listelenebilir.
- Filmler GridControl ile tablo şeklinde gösterilir.
- Filmlere ait başlık, açıklama, çıkış tarihi, afiş ve eklenme tarihi görüntülenir.

### 3. Puanlama ve Not
- Kullanıcılar filmleri 1–10 arasında puanlayabilir.
- Filmlere not eklenebilir.
- Film detaylarında **ortalama puan**, kullanıcının verdiği puan ve notlar gösterilir.

### 4. Tavsiye Gönderme
- Kullanıcı seçilen bir filmi e-posta ile arkadaşına tavsiye edebilir.
- Örnek SMTP servisi olarak [Ethereal Email](https://ethereal.email/) kullanılmıştır.
- Mail HTML formatında gönderilir; film başlığı, açıklaması, çıkış tarihi ve afişi eklenir.

### 5. Kullanıcı Arayüzü
- DevExpress kontrolleri ile GridControl, TextEdit, RichTextBox ve DateEdit kullanılmıştır.
- ProgressBar, manuel ve API’den çekilen filmlerin eklenme sürecini gösterir.
- Form tasarımları optimize edilmiştir; yeniden boyutlandırma engellenmiştir.
- Grup kutuları ve araçlar sayfa düzenini kaplayacak şekilde hizalanmıştır.

---

## Veritabanı Yapısı

### Movies Tablosu
- Id (PK, Identity)
- TMDBId (API film ID, nullable)
- Title
- Overview
- ReleaseDate
- PosterPath
- IsManual (0 = API, 1 = Manuel)
- IsDeleted (Soft delete)
- CreatedAt, UpdatedAt

### Ratings Tablosu
- Id (PK, Identity)
- MovieId (FK)
- UserIdentifier (opsiyonel)
- Rating (1–10)
- Note
- CreatedAt

**Indexler:**  
- Movies: TMDBId, IsDeleted, Title  
- Ratings: MovieId  

> SQL script projede mevcuttur. Veritabanı oluşturulduktan sonra doğrudan çalıştırılabilir.

---

## Teknik Detaylar
- API çağrıları **HttpClient** ile yapılır.
- JSON verileri **Newtonsoft.Json** kullanılarak deserialize edilir.
- E-posta gönderimi **SmtpClient** ile async yapılır.
- Grid ve form güncellemeleri için **Invoke** ile UI thread kontrolü sağlanır.
- Soft delete ve manuel/otomatik ayrımı veri tabanı ve uygulama mantığıyla yönetilir.

---

## Kurulum
1. Veritabanını oluşturun ve SQL scriptini çalıştırın.
2. `App.config` dosyasına **TMDB API Key** ekleyin.
3. Projeyi Visual Studio’da açın ve derleyin.
4. Uygulamayı çalıştırın, filmleri çekmek için **Import Movies** butonunu kullanın.

---

## Öneriler
- Veritabanı boyutu büyüdükçe GridControl performansı düşebilir. Gerekirse sayfalama veya lazy loading eklenebilir.
- E-posta servisi için gerçek SMTP bilgileri kullanılabilir.

---

## Lisans
Bu proje **mülakat/değerlendirme** amaçlı hazırlanmıştır.
