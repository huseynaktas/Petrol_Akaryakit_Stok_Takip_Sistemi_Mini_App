# Petrol Akaryakıt Stok Takip Sistemi

Bu proje, bir petrol akaryakıt istasyonunun stoklarını ve satışlarını takip etmek için geliştirilmiş bir masaüstü uygulamasıdır. Uygulama, çeşitli yakıt türlerinin stok ve fiyat bilgilerini yönetir, satış işlemlerini gerçekleştirir ve kasa miktarını günceller.

## Özellikler

- **Stok Yönetimi:** Kurşunsuz 95, Kurşunsuz 97, Diesel Max, Diesel Pro ve Otogaz yakıt türlerinin stok miktarlarını ve fiyatlarını görüntüleyip güncelleyebilirsiniz.
  
- **Satış Yönetimi:** Yakıt satış işlemlerini gerçekleştirir ve satışlardan elde edilen gelirleri kasa miktarına ekler.
  
- **Kasa Yönetimi:** Kasa miktarını takip eder ve günceller.

## Gereksinimler

- Microsoft Visual Studio
- .NET Framework
- SQL Server (LocalDB veya tam sürüm)

## Kurulum

### Veritabanı Oluşturma:

1. SQL Server'da `PetrolAkaryakitStokTakip` isimli bir veritabanı oluşturun.
2. Aşağıdaki tabloları oluşturun:
   - `TBLYAKIT` tablosu: Yakıt türleri ve stok bilgileri için.
   - `TBLHAREKET` tablosu: Satış işlemleri için.
   - `TBLKASA` tablosu: Kasa miktarı için.

### Bağlantı Dizesi Güncelleme:

`Form1.cs` dosyasındaki bağlantı dizesini (connection string) kendi SQL Server ayarlarınıza göre güncelleyin.

## Kullanım

### Uygulamayı Başlatma:

Uygulamayı Visual Studio'da başlatın.

### Stok ve Fiyat Bilgilerini Görüntüleme:

Ana ekranda yakıt türlerinin stok ve fiyat bilgilerini görüntüleyin.

### Satış Yapma:

1. Satış yapmak için gerekli bilgileri girin.
2. "Depo Doldur" butonuna tıklayın.
3. Satış işlemi tamamlandığında stok ve kasa miktarları güncellenecektir.

## Kod Açıklamaları

### Bağlantı ve Veri Listeleme

#### Bağlantı Nesnesi:

`conn` değişkeni, SQL Server'a bağlanmak için kullanılır. Bağlantı dizesi, SQL Server veritabanı sunucusuna ve `PetrolAkaryakitStokTakip` veritabanına bağlanmak için gereklidir.

#### Veri Listeleme:

`Listele()` metodu, veritabanından yakıt türlerinin stok ve fiyat bilgilerini çeker ve kullanıcı arayüzündeki ilgili etiketler ve progress bar'ları günceller. Ayrıca, kasa miktarını da günceller.

### Form Yüklenmesi

#### Form Yükleme Olayı:

`Form1_Load` olayı, uygulama başlatıldığında `Listele()` metodunu çağırarak veritabanındaki mevcut bilgilerin kullanıcı arayüzüne yüklenmesini sağlar.

### Değer Değişimi ve Hesaplama

#### Değer Değişim Olayları:

`numKur95_ValueChanged`, `numKur97_ValueChanged`, `numDieM_ValueChanged`, `numDieP_ValueChanged`, `numOtogaz_ValueChanged` olayları, ilgili numeric up-down kontrollerindeki değer değiştiğinde tetiklenir. Yeni değere göre toplam tutarı hesaplar ve hesaplanan tutarı ilgili text box'a yazar.

### Satış İşlemleri

#### Satış Butonu Olayı:

`btnDepoDoldur_Click` olayı, kullanıcı "Depo Doldur" butonuna tıkladığında tetiklenir. Aşağıdaki işlemleri gerçekleştirir:
- İlgili yakıt türü için satış bilgilerini `TBLHAREKET` tablosuna ekler.
- Satış tutarını `TBLKASA` tablosuna ekler.
- Satılan yakıt miktarını ilgili yakıt türünün stok miktarından düşer (TBLYAKIT tablosunu günceller).
- Kullanıcıya satışın gerçekleştiğini bildiren bir mesaj gösterir ve stok bilgilerini güncellemek için `Listele()` metodunu tekrar çağırır.

## Veritabanı Yapısı

### TBLYAKIT Tablosu:

Yakıt türleri, fiyatları ve stok miktarlarını içerir. Bu tablo, stok takibini sağlamak için kullanılır.

### TBLHAREKET Tablosu:

Satış işlemlerinin kaydedildiği tablodur. Bu tablo, plaka, yakıt türü, litre ve tutar bilgilerini içerir.

### TBLKASA Tablosu:

Kasa miktarını içerir. Satışlardan elde edilen gelir bu tabloya eklenir.

## Projeye Ait Ekran Görüntüleri ve Veritabanı Görüntüsü
### Proje
![Petrol](https://github.com/huseynaktas/Petrol_Akaryakit_Stok_Takip_Sistemi_Mini_App/assets/114494075/f4bba7cf-8a62-4ab2-ba2d-6e0e816e38e7)

### Veritabanı
![Petrol VT](https://github.com/huseynaktas/Petrol_Akaryakit_Stok_Takip_Sistemi_Mini_App/assets/114494075/c52ffd3a-daed-42da-acb0-3db6b5cc959c)
