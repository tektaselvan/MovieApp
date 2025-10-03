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

## 🚀 Kurulum
1. **Veritabanını oluşturun**  
   - `MovieAppDb` isimli veritabanını oluşturun.  
   - Repository içerisinde bulunan SQL scriptini çalıştırarak tabloları oluşturun.  

2. **App.config ayarları**  
   - `App.config` dosyasındaki `<connectionStrings>` alanında kendi SQL Server bağlantı bilginizi girin.  
   - TMDB API Key’inizi `App.config` içine ekleyin:  
     ```xml
     <appSettings>
         <add key="TmdbApiKey" value="YOUR_API_KEY" />
     </appSettings>
     ```

3. **Projeyi açın ve derleyin**  
   - Projeyi Visual Studio’da açın.  
   - `NuGet` bağımlılıklarını yükleyin (DevExpress, Newtonsoft.Json vb.).  
   - Projeyi derleyin ve çalıştırın.  

---

## 🖥️ Kullanım

### Film İşlem Formu
- **Film ekleme**: Manuel olarak film ekleyebilirsiniz.  
- **API’den film getirme**: “Import Movies” butonu ile TMDB API’den 1000 filme kadar veri çekebilirsiniz.  
- **Film listesine geçiş**: Tüm filmleri listeleyen form ekranına yönlendiren bir buton bulunmaktadır.  
- **Grid üzerinde sağ tık menüsü (ContextMenuStrip)**:
  - **Film Detaylarını Görüntüle**  
  - **Filmi Puanla**  
  - **Filmi Sil**

### Film Puanlama Formu
- Seçilen filmin adı görüntülenir.  
- Kullanıcı 1 ile 10 arasında (10 dahil) puan verebilir.  
- İsteğe bağlı olarak film hakkında not girilebilir.  

### Film Detay Formu
- Filmin **adı, açıklaması, görseli ve çıkış tarihi** görüntülenir.  
- **Kullanıcı puanı** ve **ortalama puan bilgisi** bulunur.  
- Film, e-posta yoluyla başka bir kullanıcıya tavsiye edilebilir:  
  - Email adresi girilip **“Mail Gönder”** butonuna tıklanarak paylaşım yapılır.  

### Tüm Filmler Listesi
- Tüm eklenmiş ve API’den getirilmiş filmler bu formda görüntülenir.  


---

## Öneriler
- Veritabanı boyutu büyüdükçe GridControl performansı düşebilir. Gerekirse sayfalama veya lazy loading eklenebilir.
- E-posta servisi için gerçek SMTP bilgileri kullanılabilir.

---

## Lisans
Bu proje **mülakat/değerlendirme** amaçlı hazırlanmıştır.
