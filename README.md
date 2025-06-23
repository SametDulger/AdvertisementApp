# AdvertisementApp

Bu proje, ASP.NET Core kullanılarak geliştirilmiş, N-Katmanlı mimari prensiplerine uygun bir iş ilanı uygulamasıdır. Proje, modern web geliştirme teknikleri ve en iyi pratikler göz önünde bulundurularak tasarlanmıştır.

## Proje Hakkında

AdvertisementApp, kullanıcıların iş ilanları yayınlayabildiği ve bu ilanlara başvurabildiği bir platformdur. Katmanlı mimari kullanılarak geliştirilmiştir, bu sayede kodun yeniden kullanılabilirliği, sürdürülebilirliği ve test edilebilirliği artırılmıştır.

## Kullanılan Teknolojiler ve Mimari

Proje, aşağıdaki teknolojiler ve tasarım desenleri kullanılarak oluşturulmuştur:

* **Backend:** C#, ASP.NET Core
* **Mimari:** N-Katmanlı Mimari (N-Tier Architecture), Onion Architecture prensipleri
* **Veri Erişimi (Data Access):** Entity Framework Core, Repository Pattern, Unit of Work Pattern
* **İş Mantığı (Business Logic):** Servis katmanı yaklaşımı
* **Doğrulama (Validation):** FluentValidation
* **Bağımlılık Yönetimi (Dependency Injection):** ASP.NET Core dahili IoC container
* **Arayüz (Frontend):** ASP.NET Core MVC, Razor Pages, Bootstrap

## Özellikler

Projenin temel özellikleri şunlardır:

* **İlan Yönetimi:** Yeni iş ilanı oluşturma, düzenleme ve silme.
* **Kullanıcı Rolleri:** Admin ve standart kullanıcı rolleri.
* **Başvuru Sistemi:** Kullanıcıların yayınlanan ilanlara başvuru yapabilmesi.
* **Listeleme ve Filtreleme:** İlanların listelenmesi ve çeşitli kriterlere göre filtrelenmesi.
* **Detaylı İlan Görünümü:** Her ilanın detaylarının ve başvuranların görüntülendiği sayfalar.

## Proje Yapısı

Proje, sorumlulukların ayrılması (Separation of Concerns) ilkesine uygun olarak aşağıdaki katmanlara ayrılmıştır:

* **AdvertisementApp.Web:** Kullanıcı arayüzünü (UI) ve sunum katmanını içerir. ASP.NET Core MVC projesidir.
* **AdvertisementApp.Business:** Uygulamanın iş mantığını, servisleri ve validasyon kurallarını barındırır.
* **AdvertisementApp.DataAccess:** Veritabanı işlemlerinden sorumludur. Repository ve Unit of Work desenlerini uygular.
* **AdvertisementApp.Dtos:** Katmanlar arası veri transferi için kullanılan Veri Transfer Nesnelerini (Data Transfer Objects) içerir.
* **AdvertisementApp.Entities:** Veritabanı tablolarına karşılık gelen varlık (entity) sınıflarını içerir.
* **AdvertisementApp.Common:** Bütün katmanlar tarafından kullanılabilecek yardımcı sınıfları ve ortak bileşenleri barındırır.

## Kurulum Adımları

Projeyi yerel makinenizde çalıştırmak için aşağıdaki adımları izleyin:

1.  **Repoyu Klonlayın:**
    ```sh
    git clone [https://github.com/SametDulger/AdvertisementApp.git](https://github.com/SametDulger/AdvertisementApp.git)
    ```

2.  **Proje Dizinine Gidin:**
    ```sh
    cd AdvertisementApp
    ```

3.  **Veritabanı Bağlantısını Yapılandırın:**
    `AdvertisementApp.Web` projesindeki `appsettings.json` dosyasında bulunan veritabanı bağlantı dizesini (Connection String) kendi yerel veritabanınıza göre güncelleyin.

4.  **Veritabanını Oluşturun (Migrations):**
    Package Manager Console üzerinden veya `dotnet cli` kullanarak veritabanı migration'larını çalıştırın.
    ```sh
    # Proje kök dizinindeyken
    dotnet ef database update --project src/AdvertisementApp.DataAccess
    ```

5.  **Uygulamayı Çalıştırın:**
    `AdvertisementApp.Web` projesini Visual Studio üzerinden başlatın veya aşağıdaki komutu kullanın:
    ```sh
    dotnet run --project src/AdvertisementApp.Web
    ```

Uygulama artık `https://localhost:5001` (veya belirlediğiniz başka bir port) adresinde çalışıyor olacaktır.
