# MAFBurger

**MAFBurger**, bir restoran sipariş yönetim sistemi olarak geliştirilmiş bir web API uygulamasıdır. Sistem, menüdeki ürünlerin yönetimi, siparişlerin takibi ve kullanıcı kimlik doğrulama gibi işlevleri desteklemektedir.

## Özellikler

- **Ürün Yönetimi**: Ürün ekleme, güncelleme, silme ve listeleme.
- **Sipariş Yönetimi**: Yeni sipariş oluşturma, güncelleme ve iptal işlemleri.
- **Kullanıcı Kimlik Doğrulama**: JWT tabanlı kullanıcı kimlik doğrulama sistemi.
- **Swagger Desteği**: API uç noktalarının belgelenmesi.

## Teknolojiler

- **.NET 7.0**
- **Entity Framework Core**
- **SQL Server**
- **AutoMapper**
- **JWT Authentication**
- **Swagger**

## Kurulum

### Gereksinimler

- .NET 7.0 SDK
- SQL Server
- Visual Studio veya Visual Studio Code

### Adımlar

1. Depoyu klonlayın:

   ```bash
   git clone https://github.com/Minelka/MAFBurger.git
   ```

2. Proje dizinine gidin:

   ```bash
   cd MAFBurger
   ```

3. Bağımlılıkları yükleyin:

   ```bash
   dotnet restore
   ```

4. **appsettings.json** dosyasını düzenleyerek veritabanı bağlantı bilgilerinizi girin:

   ```json
   "ConnectionStrings": {
     "DefaultConnection": "Server=.;Database=MAFBurgerDB;Trusted_Connection=True;"
   }
   ```

5. Veritabanı migrasyonlarını çalıştırın:

   ```bash
   dotnet ef database update
   ```

6. Uygulamayı başlatın:

   ```bash
   dotnet run
   ```

Uygulama varsayılan olarak `https://localhost:5001` adresinde çalışacaktır.

## API Endpoints

### Kimlik Doğrulama

- **POST** `/api/auth/login` – Kullanıcı girişi yapar ve JWT token döner.

### Ürünler

- **GET** `/api/products` – Tüm ürünleri listeler.
- **POST** `/api/products` – Yeni ürün ekler.
- **PUT** `/api/products/{id}` – Ürünü günceller.
- **DELETE** `/api/products/{id}` – Ürünü siler.

### Siparişler

- **GET** `/api/orders` – Tüm siparişleri listeler.
- **POST** `/api/orders` – Yeni sipariş oluşturur.

## Proje Yapısı

```
MAFBurger
├─ Controllers         # API Kontrolleri
├─ Services           # İş servisleri
├─ Data              # Veritabanı işlemleri
├─ Models            # Veri modelleri
├─ DTOs              # Veri transfer nesneleri
├─ Mapping           # AutoMapper profilleri
└─ Configurations    # JWT ve diğer yapılandırmalar
```

## Lisans

Bu proje açık kaynak değildir ve yalnızca izinli kullanıcılar tarafından kullanılabilir.
