Console.WriteLine("Lütfen aşağıdaki bilgileri giriniz:");

//Burada string kullanmamızın sebebi her T.C. kimlik numarası kişiye özeldir ve üzerinde matematiksel işlem yapmaya gerek yoktur.
Console.Write("T.C. Kimlik numarası: ");
string tc = Console.ReadLine();

//Burada isim ve soyisim metinsel bir değer olacağından dolayı string ile tutulmuştur
Console.Write("Adı: ");
string name = Console.ReadLine();
Console.Write("Soyadı :");
string surname = Console.ReadLine();

//Burada string kullanmamızın sebebi telefon numarası kişiye özeldir ve üzerinde matematiksel işlem yapmaya gerek yoktur.
Console.Write("Telefon Numarası: ");
string phoneNumber = Console.ReadLine();

//yaş herr yıl değişen bir değer olduğundan dolayı üzerinden hesaplama işlemi yapmak gerekebilir diye int verisinde tuttuk
Console.Write("Yaş: ");
int age = Convert.ToInt32(Console.ReadLine());

//fiyatlar üzerinde hesaplama yapacağımızdan dolayı tam sayı değeri olan int değerinde tuttuk.
Console.Write("İlk aldığın ürünün fiyatı: ");
int productOne = Convert.ToInt32(Console.ReadLine());
Console.Write("İkinci aldığın ürünün fiyatı: ");
int productTwo = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("<----------------------------------------------->");

//burada kayıt oluşturulduğuna dair bir bilgi vereceğiz.
Console.WriteLine($"{tc} kimlik numralı {name} {surname} isimli kişi için kayıt oluşturulmuştur.");
Console.WriteLine($"{phoneNumber} numarasına bildirim mesajı gönderilmiştir.");

//burada puan hesaplanıyor ve puan ile alakalı kullanıcıya bilgi veriliyor
int winPoints = ((productOne + productTwo) * 10) / 100;
Console.WriteLine($"{productOne + productTwo} toplam harcama karşılığı kazanılan %10 patika puan miktarı -> {winPoints}'dir.");
