# Program Açıklaması

Bu proje, bir liste üzerinde çeşitli filtreleme ve işlem uygulamalarını gösteren bir C# konsol uygulamasıdır. Uygulama rastgele üretilmiş sayılardan oluşan bir listeyi işler ve belirli kriterlere göre sayıları listeleyerek çıktılar verir.

## Kodun Genel Yapısı

1. **Rastgele Sayı Üretimi:** 
   - `Random` sınıfı kullanılarak -50 ile 50 arasında rastgele 10 sayı üretilir ve `list` isimli listeye eklenir.

2. **Listeleme İşlemleri:**
   - **Çift Sayılar**: Listedeki çift sayılar `numbers` listesine eklenir ve konsola yazdırılır.
   - **Tek Sayılar**: Listedeki tek sayılar `numbers2` listesine eklenir ve konsola yazdırılır.
   - **Negatif Sayılar**: Listedeki negatif sayılar `numbers3` listesine eklenir ve konsola yazdırılır.
   - **Pozitif Sayılar**: Listedeki pozitif sayılar `numbers4` listesine eklenir ve konsola yazdırılır.
   - **15 ile 22 Arasındaki Sayılar**: 15'ten büyük ve 22'den küçük sayılar `numbers5` listesine eklenir ve konsola yazdırılır.
   - **Sayıların Kareleri**: Listedeki her sayının karesi `numbers6` listesine eklenir ve konsola yazdırılır.

## Kodun Amacı

Bu program, bir sayı listesi üzerinde aşağıdaki işlemleri gerçekleştirmek için `LINQ` sorgularını ve `List` yapısını kullanma örneği sunar:
- Çift ve tek sayıları ayırma
- Negatif ve pozitif sayıları bulma
- Belirli bir aralıkta bulunan sayıları listeleme
- Her sayının karesini hesaplama

## Nasıl Çalıştırılır?

1. **Gereksinimler**:
   - .NET Core veya .NET Framework yüklü olmalıdır.

2. **Adımlar**:
   - Kodu bir C# dosyasına (`Program.cs`) kaydedin.
   - Terminal veya komut satırında `dotnet run` komutu ile çalıştırın.
   - Çıktılar konsolda görüntülenecektir.
