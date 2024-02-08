// See https://aka.ms/new-console-template for more information
using Business.Concrete;
using Entities.Concrete;
using System.Diagnostics;

Console.WriteLine("Hello, World!");


Vatandas vatandas1 = new Vatandas(); //instance oluşturuldu.

//işi yapan methodu çağırdım 
SelamVer(isim: "Mihra");
SelamVer(isim: "Engin");
SelamVer(isim: "Yıldız");
SelamVer(); // methodta prametre olarak default bi değer verildi isimsiz denildi onun için bu şekilde de çağrılbilir

int sonuc =  Topla(3,5);  //örneğin bir banka da kredi hesaplaması yapılırken kullanım bu şekildedir.
Topla(); //default parametre değerleri gelir.

static void Degiskenler()
{
    string mesaj = "Merhaba";
    double tutar = 100000;
    int sayi = 100;
    bool girisYapmisMi = false; //kullanicinin sisteme giriş yapıpyapmadığ bilgisini tutuyor.


    Console.WriteLine(mesaj);
    Console.WriteLine(tutar * 1.18);

    //bu şekilde birden fazla vatandaş olacak ve her bir vatandaşında birden fazla bilgisi.bu sebeple class mantığı ile OOP kullanılarak çalışılır.
    //böylece değişkenin kendisi ile değil class ile uğraşılır
    string ad = "Mihra";
    string soyad = "Yıldız";
    int dogumYili = 1996;
    long tcNo = 12345678910;
}


//metotlar
static  void SelamVer(string isim = "isimsiz") //örneğin sisteme giriş yaptı merhaba mihra, merhaba engin gibi isimler yazması içi merhaba hep sabitkn isim değişir arıca default parametre isimsiz olarak verildi.
{
    Console.WriteLine("Merhaba " + isim);
}


static int Topla(int sayi1=5, int sayi2 = 10)
{
    int sonuc =  sayi1 + sayi2;
    Console.WriteLine("Toplam: " + sonuc); //sonuc.ToString() olarakta kullanılabilir
    return sonuc;
}
//metotlarend

//mernis
Person person1= new Person();
person1.FirstName = "ENGİN";
person1.LastName = "DEMİROĞ";
person1.DateOfBirthYear = 1985;
person1.NationalIdentity = 123;

PttManager pttManager = new PttManager(new PersonManager());
pttManager.GiveMask(person1);
//mernisend




// classların defaultu internaldır.
public class Vatandas
{

    //string ad = "Mihra";//public olmadığı için dışarıdan erişilemez.şu an atama yapılmış durmda örneğin müşteri mihra girid ancak biz mihra hanım olarak setlemek istiyoruzbu sebeple set get olarak casslarda tanımlama yapılmlıdır.
    //string soyad = "Yıldız";
    //int dogumYili = 1996;
    //long tcNo = 12345678910;

    //PascalCase yazımı
    public string Ad { get; set; }
    public string Soyad { get; set; }
    public int DogumYili { get; set; }
    public long TcNo { get; set; }
}

/*diziler -arrays

string ogrenci1 = "mihra"; //tek tek atama yapılarak ve te tek ilgii yerlerde cw ile yazılır ancak birdn fazla yerde kullanılabilir. ve hepsi aynı türdür.
string ogrenci2 = "engin";
string ogrenci3 = "yıldız";

//Console.WriteLine(ogrenci1);
//Console.WriteLine(ogrenci2);
//Console.WriteLine(ogrenci3);


string[] ogrenciler = new string[3];
ogrenciler[0] = "mihra";
ogrenciler[1] = "engin";
ogrenciler[2] = "yıldız";

ogrenciler = new string[4];  //burada new i gördüğü için  heapte dört elemnlı yeni bir alan tahsis eder.
ogrenciler[3] = "demirog";


for (int i = 0; i < ogrenciler.Length; i++)
{
    Console.WriteLine("{0}. öğrenci  {1}", (i+1), ogrenciler[i] );
}


string[] sehirler1 = new[] { "Ankara", "İstnbul", "İzmir" };
string[] sehirler2 = new[] { "Bursa", "Antalya", "Diyarbakır" };


sehirler1 = sehirler2; //aslında değer ataması değil referans tipli oldukları için heapteki yerini göstermiş olursun.
sehirler1[0] = "Ordu";
Console.WriteLine(sehirler2[0]);//ordu yu yazar.

foreach (string s in sehirler1) 
{
    Console.WriteLine (s);
}

//generic collection
List<string> yeniSehirler = new List<string> { "Ankara1", "İstnbul1", "İzmir1" };
yeniSehirler.Add(item: "Adana1");

foreach (string s in yeniSehirler)
{
    Console.WriteLine(s);
}

arrayend*/