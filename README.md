<h1 align="center"> ResumeProject: Kurumsal Seviyede Portfolyo & Kişisel CMS </h1>

<p align="center"> Profesyonellerin uzmanlıklarını sergilemesi, profesyonel talepleri yönetmesi ve dijital etkileşimleri merkezi bir panel üzerinden takip etmesi için tasarlanmış gelişmiş, full-stack bir kişisel marka yönetim sistemi. </p>

<p align="center">
  <img alt="Build" src="https://img.shields.io/badge/Build-Passing-brightgreen?style=for-the-badge">
  <img alt="Framework" src="https://img.shields.io/badge/Framework-ASP.NET%20Core-512bd4?style=for-the-badge">
  <img alt="Database" src="https://img.shields.io/badge/Database-SQL%20Server-red?style=for-the-badge">
  <img alt="Architecture" src="https://img.shields.io/badge/Architecture-MVC-blue?style=for-the-badge">
</p>

---

## 🌟 Genel Bakış

**ResumeProject**, profesyonellerin dijital varlıklarını hassas ve kontrollü şekilde yönetmesini sağlayan akıllı, içerik odaklı bir web uygulamasıdır. Statik portfolyo şablonlarının aksine, bu sistem profesyonel başarıların, yeteneklerin ve hizmetlerin gerçek zamanlı olarak güncellenmesine imkân tanıyan güçlü bir yönetim altyapısı sunar — üstelik tek bir satır kod yazmadan.

### Problem
> Birçok geliştirici ve yaratıcı profesyonel için güncel bir portfolyo tutmak sürekli bir teknik borç haline gelir. Yeni projeler eklemek, yetenekleri güncellemek veya iletişim formu mesajlarını yönetmek genellikle manuel kod değişiklikleri, veritabanı işlemleri veya farklı servisler arasında geçiş yapmayı gerektirir. Bu da güncel olmayan içeriklere ve kaçırılan fırsatlara yol açar.

### Çözüm
ResumeProject profesyonel kimliği tek bir merkezde toplar. Yüksek performanslı **ASP.NET Core MVC** mimarisi sayesinde, halka açık portfolyo ile yönetim paneli birbirinden ayrılır. Kullanıcılar eğitim geçmişinden referanslara, hizmetlerden gelen mesaj trafiğine kadar tüm profesyonel içeriklerini veri odaklı tek bir arayüzden yönetebilir.

---

## ✨ Temel Özellikler

ResumeProject, profesyonel profilin her alanını yönetilebilir bir varlık olarak ele alan modüler bir yaklaşımla geliştirilmiştir.

### 🛡️ Yönetim Kontrol Merkezi
* **Kapsamlı Dashboard:** Entegre istatistikler ve mesaj trafiği görselleri ile site performansını takip edin.
* **Mesaj Yönetimi:** Potansiyel müşteri veya işverenlerden gelen mesajları görüntüleme ve takip etme merkezi.
* **Proje Dağılımı Analizi:** Portfolyo kategorilerinizin dağılımını görselleştirerek güçlü yönlerinizi analiz edin.

### 📈 Etkileşim & Sosyal Kanıt
* **Referans Motoru:** Güvenilirlik için müşteri geri bildirimlerini yönetin ve sergileyin.
* **Eğitim Geçmişi:** Akademik başarıları ve sertifikaları ekleyin.
* **Hakkımda & Öne Çıkanlar:** Başarıları öne çıkaran kartlarla güçlü bir kişisel hikâye oluşturun.

### 🎨 Gelişmiş UI/UX Bileşenleri
* **ViewComponent Mimarisi:** “Son Mesajlar” veya “Yetenek Listeleri” gibi bileşenlerin tekrar kullanılabilir modüler yapısı.
* **Dinamik Tema Desteği:** Video arka planı, Ken Burns efektleri ve animasyonlu gradient destekleri.
* **Responsive Tasarım:** SCSS tabanlı yapı ile mobil, tablet ve masaüstü için optimize edilmiş arayüz.

---

## 🛠️ Teknoloji Yığını & Mimari

Proje, veri, iş mantığı ve arayüzü birbirinden ayıran temiz bir **MVC (Model-View-Controller)** mimarisi üzerine kurulmuştur.

### Kullanılan Teknolojiler

| Teknoloji | Amacı | Neden Tercih Edildi |
| :--- | :--- | :--- |
| **ASP.NET Core** | Ana Backend Framework | Kurumsal seviye performans, güvenlik ve platform bağımsızlık sağlar. |
| **C#** | Programlama Dili | Güçlü tip sistemi ve modern özellikler ile sürdürülebilir iş mantığı sunar. |
| **Entity Framework Core** | ORM / Veri Erişimi | Migration desteği ile veritabanı işlemlerini kolaylaştırır. |
| **SQL Server** | İlişkisel Veritabanı | Veri tutarlılığı ve gelişmiş sorgulama desteği sağlar. |
| **Razor / ViewComponents** | Şablon Motoru | Modüler ve yeniden kullanılabilir UI geliştirmeyi kolaylaştırır. |
| **Bootstrap & SCSS** | Frontend Tasarım | Responsive tasarım ve gelişmiş Tailwind CSS yönetimi sağlar. |
| **jQuery & Pluginler** | Client-Side Etkileşim | `typed.js` ve `vegas.js` gibi özel UI efektleri için kullanılır. |

---

## 📁 Proje Yapısı
```
berdanaksoy-ResumeProject-85b4b4e/
├── 📄 ResumeProject.slnx # Visual Studio Solution Dosyası
├── 📂 ResumeProject/ # Ana Uygulama Dizini
│ ├── 📄 Program.cs # Uygulama başlangıç noktası
│ ├── 📄 appsettings.json # Global yapılandırma ayarları
│ ├── 📂 Controllers/ # İş mantığı ve request yönetimi
│ ├── 📂 Entities/ # Veri modelleri
│ ├── 📂 Context/ # Veritabanı bağlantısı (EF Core)
│ ├── 📂 ViewComponents/ # Modüler UI bileşenleri
│ ├── 📂 Views/ # Razor arayüz dosyaları
│ ├── 📂 Migrations/ # Veritabanı sürüm kontrolü
│ ├── 📂 Database/ # SQL başlangıç scriptleri
│ └── 📂 wwwroot/ # Statik dosyalar (CSS, JS, Görseller)
└── 📄 README.md # Proje dokümantasyonu
```

## 📸 Ekran Görüntüleri

### 📊 Yönetim Paneli (Admin Dashboard)
Yönetici için stratejik karar alma sürecini destekleyen; Chart.js grafik entegrasyonlu, canlı veritabanı istatistikleri ve anlık bildirim merkezi.

<img width="100%" src="https://github.com/user-attachments/assets/76b762c5-13d3-4b66-81ee-3124e6785c75" />

<details>
<summary><strong>📸 Diğer Admin Paneli Modüllerini İncelemek İçin Tıklayın</strong></summary>
<br>

**Detaylı Sistem Modülleri:**
<img width="100%" src="https://github.com/user-attachments/assets/145d63ea-ba08-4b09-a652-c05a637c90f1" />
<img width="100%" rc="https://github.com/user-attachments/assets/0e2cd651-790e-4f8e-a684-db9cf84d7e10" />
<img width="100%" src="https://github.com/user-attachments/assets/51e7b1d5-e029-44fe-bc80-6f665e4c2368" />
<img width="100%" src="https://github.com/user-attachments/assets/52d2af4f-9797-443b-be1a-3475c7fff48d" />
<img width="100%" src="https://github.com/user-attachments/assets/eb3a217e-fd58-4ce5-a39b-0c6a0e3eb339" />
<img width="100%" src="https://github.com/user-attachments/assets/1601b0ca-4731-43f5-b9d1-1e8f0a57c320" />
<img width="100%" src="https://github.com/user-attachments/assets/c191c017-76d1-4f7a-a77f-6af411968918" />
<img width="100%" src="https://github.com/user-attachments/assets/2158610c-b113-4144-b56a-8382a352b299" />
<img width="100%" src="https://github.com/user-attachments/assets/42652370-7adb-4e91-acb4-8ef6a7c8772b" />


</details>

<br>

### 🌐 Kullanıcı Arayüzü (Vitrin)
Modern UI/UX prensiplerine uygun, tamamen responsive ve veritabanı destekli dinamik ön yüz.

<img width="100%" src="https://github.com/user-attachments/assets/784da1ad-5a67-4cac-9ddd-539eec546148" />


<details>
<summary><strong>🌍 Tüm Sayfa Tasarımını (Full Page) Görmek İçin Tıklayın</strong></summary>
<br>
<img width="100%" src="https://github.com/user-attachments/assets/e1329a1a-01db-4535-8534-3ed3680fd76c" />
</details>

---

## 🚀 Kurulum

### Gereksinimler
* **.NET SDK** (v6.0 veya üstü önerilir)
* **SQL Server** (LocalDB veya Express)
* **Visual Studio 2022** veya **VS Code + C# Dev Kit**

### Kurulum Adımları

1. **Repository’yi Klonlayın**
    ```bash
    git clone https://github.com/berdanaksoy/ResumeProject.git
    cd ResumeProject
    ```

2. **Veritabanı Ayarı**
    `appsettings.json` içerisindeki connection string bilgisini güncelleyin:
    ```json
    "ConnectionStrings": {
      "DefaultConnection": "Server=YOUR_SERVER;Database=ResumeDb;Trusted_Connection=True;"
    }
    ```

3. **Migrationları Uygulayın**
    ```bash
    dotnet ef database update
    ```

4. **Verileri Getirin**
    `Database/script.sql` dosyasını SQL Server Management Studio ile çalıştırın.

5. **Projeyi Çalıştırın**
    ```bash
    dotnet run --project ResumeProject
    ```
---

## 🔧 Kullanım

### Admin Paneli
`/Dashboard/Index` adresine giderek yönetim paneline erişebilirsiniz.

Buradan:
* **Yetenekleri güncelleyebilir**
* **Mesajları yönetebilir**
* **İstatistikleri takip edebilirsiniz**

### Public Sayfayı Özelleştirme
Public görünüm `DefaultController` üzerinden render edilir ve dinamik `ViewComponent` yapısı kullanır.

---

## 🤝 Katkıda Bulunma

ResumeProject’e katkılarınızı memnuniyetle karşılıyoruz!

### Nasıl Katkı Sağlanır

1. Repository’yi fork edin
2. Yeni bir branch oluşturun
   ```bash
   git checkout -b feature/amazing-feature
