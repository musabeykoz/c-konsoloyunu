using System.Data;
//kasa maliyetleri


//yardım yazısı
string neyap = "Ne yapmak istersiniz(yardım)";
//yaz ve secenek
string yaz, secenek = "****(yardım/emlak/parakasa/parabak/anamenu/expbak)****";
//emlak altın seviye ve exp değişkenleri
int ev = 0, market = 0, otel = 0;
double para = 2000000, altın, seviye = 1, exp = 0;


//giriş anamenusu
Console.WriteLine("****Buildstate v.1.0****");
Console.WriteLine("seviye= " + seviye);
Console.WriteLine("para= " + para + "TL");
Console.WriteLine("exp= " + exp + "EXP");
Console.WriteLine("ev= " + ev);
Console.WriteLine("market= " + market);
Console.WriteLine("otel = " + otel);

Console.WriteLine("----------------------");
Console.WriteLine(neyap);
yaz = Console.ReadLine();

for (; ; )
{
    //yardım
    if (yaz == "yardım")
    {
        Console.Clear();
        Console.WriteLine(secenek);
        Console.WriteLine("emlak=emlak piyasasını görüntüler");
        Console.WriteLine("expbak= mevcut expinizi görüntüler");
        Console.WriteLine("parabak= mevcut paranızı görüntüler");
        Console.WriteLine("parakasa= kasa açar bu kasa ücretlidir ve içinden para ve EXP çıkar.");
    }

    else if (yaz == "anamenu")
    {

        Console.Clear();
        // anamenu 
        Console.WriteLine("****Buildstate v.1.0****");
        Console.WriteLine("seviye=" + seviye);
        Console.WriteLine("para= " + para + "TL");
        Console.WriteLine("exp= " + exp + "EXP");
        Console.WriteLine("ev= " + ev);
        Console.WriteLine("market= " + market);
        Console.WriteLine("otel = " + otel);
        Console.WriteLine("----------------------");
    }
    //xpbak
    else if (yaz == "expbak")
    {


        Console.Clear();
        Console.WriteLine("**** mevcut EXP iniz=" + exp + "EXP ****");
    }

    //parabak
    else if (yaz == "parabak")
    {
        Console.Clear();
        Console.WriteLine("**** mevcut paranız=" + para + "TL ****");
    }
    //parakasa
    else if (yaz == "parakasa")
    {


        Console.Clear();
        Console.WriteLine("**** PARA KASASI ****");

        int[] numbers = new int[20];


        numbers[0] = 10;
        numbers[1] = 20;
        numbers[2] = 30;
        numbers[3] = 40;
        numbers[4] = 50;
        numbers[5] = 60;
        numbers[6] = 70;
        numbers[7] = 80;
        numbers[8] = 90;
        numbers[9] = 100;
        numbers[10] = 110;
        numbers[11] = 120;
        numbers[12] = 130;
        numbers[13] = 140;
        numbers[14] = 150;
        numbers[15] = 160;
        numbers[16] = 270;
        numbers[17] = 280;
        numbers[18] = 290;
        numbers[19] = 500;


        Random random = new Random();
        int randomIndex = random.Next(0, numbers.Length);


        Console.WriteLine("nakit kazandın=" + numbers[randomIndex] + "TL");
        Console.WriteLine("exp kazandın=" + randomIndex + "EXP");
        para = para + numbers[randomIndex];
        exp = exp + randomIndex;


    }

    else if (yaz == "emlak")
    {
        Console.Clear();
        Console.WriteLine("**** EMLAK DÜNYASI ****");
        Console.WriteLine("ev=100.000 TL");
        Console.WriteLine("market=300.000 TL");
        Console.WriteLine("otel=900.000 TL");
        Console.WriteLine("");
    }
    else if (yaz == "eval")
    {
        if (para >= 100000)
        {
            Console.Clear();
            Console.WriteLine("ev satın alım başarılı");

            ev = ev + 1;
            para = para - 100000;
            Console.WriteLine("mevcut ev sayınız= " + ev);
        }
        else
        {
            Console.Clear();
            Console.WriteLine("ev satın alım başarısız");
            Console.WriteLine("mevcut ev sayınız= " + ev);
        }
    }

    else if (yaz == "marketal")
    {
        if (para >= 300000)
        {
            Console.Clear();
            Console.WriteLine("market satın alım başarılı");

            market = market + 1;
            para = para - 300000;
            Console.WriteLine("mevcut ev sayınız= " + market);
        }
        else
        {
            Console.Clear();
            Console.WriteLine("market satın alım başarısız");
            Console.WriteLine("mevcut market sayınız= " + market);
        }
    }

    else if (yaz == "otelal")
    {
        if (para >= 900000)
        {
            Console.Clear();
            Console.WriteLine("market satın alım başarılı");

            market = market + 1;
            para = para - 300000;
            Console.WriteLine("mevcut ev sayınız= " + market);
        }
        else
        {
            Console.Clear();
            Console.WriteLine("market satın alım başarısız");
            Console.WriteLine("mevcut market sayınız= " + market);
        }
    }


    //oyun seviyen
    else if (0 < exp && exp <= 40)
    {
        seviye = 2;
    }
    else if (41 <= exp && exp <= 80)
    {
        seviye = 3;
    }
    else if (81 <= exp && exp <= 160)
    {
        seviye = 4;
    }

    Console.WriteLine(neyap);
    yaz = Console.ReadLine();
    Console.ReadKey();
}

