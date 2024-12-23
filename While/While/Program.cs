

//1 -> Konsol ekranına 10 kere "Kendime inanıyorum, ben bu yazılım işini hallederim!" yazdırınız.

int a = 1;
while (a <= 10)
{
    Console.WriteLine("Kendime inanıyorum, ben bu yazılım işini hallederim!");
    a++;
}

Console.WriteLine("-----------------------------------------");

//////2 -> 1 ile 20 arasındaki sayıları konsol ekranına yazdırınız.
int sayılar = 0;
while (sayılar <= 20)
{
    Console.WriteLine($"{sayılar}");
    sayılar++;
}
Console.WriteLine("--------------------------------------------");

////3 -> 1 ile 20 arasındaki çift sayıları konsol ekranına yazdırınız.
int ciftsayılar = 2;

while (ciftsayılar <= 20)

{
    Console.WriteLine($"çift sayılar: {ciftsayılar}");
    ciftsayılar += 2;
}

Console.WriteLine("-----------------------------------------");




//4 -> 50 ile 150 arasındaki sayıların toplamını ekrana yazdırınız.
int toplam = 0;
int t = 50;
while (t <= 150)
{
    toplam += t;
    t++;
}
Console.WriteLine($"sayıların toplamı {toplam}");

Console.WriteLine("-----------------------------------------");

//5 -> 1 ile 120 arasındaki tek ve çift sayıların toplamlarını ayrı ayrı ekrana yazdırınız.

int tekToplam = 0;
int ciftToplam = 0;
int i = 1;  


while (i <= 120)
{
    if (i % 2 == 0)  
    {
        ciftToplam += i;
    }
    else  
    {
        tekToplam += i;
    }
    i++;  
}

Console.WriteLine("1 ile 120 arasındaki tek sayıların toplamı: " + tekToplam);
Console.WriteLine("1 ile 120 arasındaki çift sayıların toplamı: " + ciftToplam);