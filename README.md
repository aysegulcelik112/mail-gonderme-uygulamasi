# 📧 Mail Gönderme Uygulaması

C# Windows Forms ile geliştirilmiş, Gmail SMTP servisi kullanarak otomatik mail gönderimi yapabilen masaüstü uygulaması.

## 🎯 Proje Hakkında

Bu proje, staj sürecim boyunca geliştirdiğim mail gönderme uygulamasıdır. Kullanıcılar bu uygulama sayesinde hızlı ve kolay bir şekilde mail gönderebilir, dosya ekleyebilir ve mesajlarını özelleştirebilir.

## ✨ Özellikler

- ✅ Gmail SMTP entegrasyonu
- 📎 Dosya ekleme desteği
- 📝 Konu ve mesaj özelleştirme
- 🎨 Modern ve kullanıcı dostu arayüz
- ⚡ Hızlı mail gönderimi
- 🔔 Başarılı gönderim bildirimi

## 🛠️ Kullanılan Teknolojiler

- **C#** - Ana programlama dili
- **Windows Forms** - Kullanıcı arayüzü
- **.NET Framework** - Uygulama çatısı
- **System.Net.Mail** - Mail gönderme kütüphanesi
- **Gmail SMTP** - Mail sunucusu

## 📋 Gereksinimler

- .NET Framework 4.7.2 veya üzeri
- Windows İşletim Sistemi
- Gmail hesabı ve uygulama şifresi

## 🚀 Kurulum

1. Projeyi klonlayın:
```bash
git clone https://github.com/KULLANICI_ADIN/mail-gonderme-uygulamasi.git
```

2. Visual Studio ile `.sln` dosyasını açın

3. `Form1.cs` dosyasında kendi Gmail bilgilerinizi girin:
```csharp
smtp.Credentials = new NetworkCredential("sizin@gmail.com", "uygulama_sifreniz");
```

4. Projeyi derleyin ve çalıştırın (F5)

## 💡 Kullanım

1. Uygulamayı çalıştırın
2. "Gönderilecek Kişi" alanına alıcı mail adresini girin
3. Konu ve mesaj alanlarını doldurun
4. İsterseniz "Dosya Ekle" linkine tıklayarak dosya ekleyin
5. "Gönder" butonuna basın
6. Başarı mesajını bekleyin

## 🔒 Güvenlik Notu

⚠️ **ÖNEMLİ**: Gmail şifrenizi kodda saklamayın! Bunun yerine:
- Gmail'de "Uygulama Şifresi" oluşturun
- Şifreleri config dosyasında veya environment variable'da saklayın
- Kodu GitHub'a yüklerken hassas bilgileri temizleyin

## 📸 Ekran Görüntüleri

<img width="1268" height="640" alt="image" src="https://github.com/user-attachments/assets/93c03880-57d2-41b8-9431-b58e8c5cd94f" />
<img width="1189" height="369" alt="image" src="https://github.com/user-attachments/assets/afaae9dc-7163-452c-9474-fbf5ee7256bb" />



## 👨‍💻 Geliştirici

**[Ayşe Gül Çelik]**
- Staj Projesi -
- Geliştirme Tarihi: [03.07.2025]

## 📝 Lisans

Bu proje eğitim amaçlı geliştirilmiştir.

## 🤝 İletişim

Sorularınız için: [aysegulcelik1128@gmail.com]

---
⭐ Bu projeyi beğendiyseniz yıldız vermeyi unutmayın!
```

