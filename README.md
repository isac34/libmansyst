
# 📚 Kütüphane Yönetim Sistemi

Kütüphane Yönetim Sistemi, kütüphane süreçlerini dijital ortamda yönetmek amacıyla geliştirilmiş bir masaüstü uygulamasıdır.
Bu proje; kitap yönetimi, üye işlemleri, ödünç alma–iade süreçleri ve raporlama işlemlerini tek bir sistem üzerinden güvenli ve düzenli şekilde yürütmeyi hedefler.

Uygulama, katmanlı mimari prensiplerine uygun olarak geliştirilmiş olup sürdürülebilir ve genişletilebilir bir yapı sunar.

## 🚀 Temel Özellikler
### 🔐 Kullanıcı Girişi ve Yetkilendirme

Güvenli giriş (login) sistemi

Rol bazlı yetkilendirme (Yönetici / Personel / Üye)

Kullanıcı rolüne göre menü ve ekran kısıtlamaları

### 📖 Kitap Yönetimi

Kitap ekleme, silme ve güncelleme

Kitap stok takibi

Mevcut kitapların listelenmesi

Geç kalan kitapların görüntülenmesi

### 👤 Üye Yönetimi

Üye ekleme ve düzenleme işlemleri

Üyelerin sistem üzerindeki işlemlerinin takibi

Üyelerin aktiflik takibi

### 🔁 Ödünç Alma ve İade

Kitap ödünç verme ve iade alma

Stok kontrolü 

Gecikme gün sayısının otomatik hesaplanması

### 📨 Kitap Talep Sistemi
 
Üyelerin sistemde olmayan veya istedikleri kitaplar için talep oluşturabilmesi

Taleplerin yönetici tarafından görüntülenebilmesi

### 📊 Raporlama (Yönetici)

Geciken kitapların listelenmesi

Aktif üyelerin listelenemesi

En çok ödünç alınan kitaplar

30 günlük ortalama ödünç grafiği

Toplam stok/ödünçteki stok pasta grafiği

## 🧰 Kullanılan Teknolojiler

C#

Windows Forms (.NET 8)

MySQL

Katmanlı Mimari (UI / BLL / DAL / Entities)

## 🏗️ Proje Mimarisi

Proje, katmanlı mimari yaklaşımıyla geliştirilmiştir:

### UI (User Interface)
Kullanıcı etkileşimlerinin gerçekleştiği Windows Forms arayüzleri

### BLL (Business Logic Layer)
İş kuralları, validasyonlar ve yetkilendirme kontrolleri

### DAL (Data Access Layer)
Veritabanı bağlantıları ve SQL sorguları

### Entities
Veritabanı tablolarının C# nesne karşılıkları

Bu yapı sayesinde kod okunabilirliği ve bakım kolaylığı sağlanmıştır.

## 🎯 Projenin Amacı

Kütüphane işlemlerini dijitalleştirerek manuel süreçleri azaltmak

Kitap ve üye takibini düzenli ve güvenli hale getirmek

Rol bazlı yetkilendirme ile kontrollü bir sistem sunmak

Raporlama ile yöneticilere karar desteği sağlamak

## 📽️ Tanıtım Videosu

Projenin tanıtım videosuna [bu linke](https://youtu.be/jjZLVbDhCAs) tıklayarak ulaşabilirsiniz

⭐ Not
Bu proje, Nesne Yönelimli Programlama ve veritabanı tabanlı masaüstü uygulama geliştirme konularında pratik kazanmak amacıyla geliştirilmiştir.
