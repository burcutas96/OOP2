using OOP2;

//Gerçek Müşteri: Engin Demiroğ 
GercekMusteri musteri1 = new GercekMusteri();
musteri1.Id = 1;
musteri1.MusteriNo = "12345";
musteri1.Adi = "Engin";
musteri1.Soyadi = "Demiroğ";
musteri1.TcNo = "123456789";

//Tüzel Müşteri: Kodlama.io
TuzelMusteri musteri2 = new TuzelMusteri();
musteri2.Id = 2;
musteri2.MusteriNo = "987654";
musteri2.SirketAdi = "Kodlama.io";
musteri2.VergiNo = "123456789";

Musteri musteri3 = new GercekMusteri();  //Musteri classı inheritance'dan dolayı hem GercekMusteri hem de TuzelMusteri classlarının  
Musteri musteri4 = new TuzelMusteri();   //referans numaralarını tuttuğu için gercek ve tuzel classlarını Musteri classına atayabildik.

MusteriManager musteriManager = new MusteriManager();
musteriManager.Ekle(musteri1);  
musteriManager.Ekle(musteri2);
musteriManager.Ekle(musteri3);
musteriManager.Ekle(musteri4);


