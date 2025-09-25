#region If - Else

int Age;

Console.Write("Lütfen Yaşınızı Giriniz: ");
Age = int.Parse(Console.ReadLine());

if (Age < 18)
{
    Console.WriteLine("Reşit Değilsiniz.");
}
else
{
    Console.WriteLine("Reşitsiniz.");
}


int ExamNote;

Console.Write("Lütfen Notunuzu Giriniz: ");

ExamNote = int.Parse(Console.ReadLine());

if (ExamNote < 60)
{
    Console.WriteLine("Kaldınız.");
}
else if (ExamNote >= 60 & ExamNote < 80)
{
    Console.WriteLine("Orta");
}
else if (ExamNote >= 80 & ExamNote < 90)
{
    Console.WriteLine("İyi");
}
else if (ExamNote >= 90)
{
    Console.WriteLine("Pekiyi");
}

Console.Write("Lütfen Yaşınızı Giriniz: ");
Age = int.Parse(Console.ReadLine());

if (Age < 18)
{
    Console.WriteLine($"if-else result => Reşit Değilsiniz.");
}
else
{
    Console.WriteLine("if-else result => Reşitsiniz.");
}

string result = (Age < 18) ? "Reşit değilsiniz" : "Reşitsiniz";

Console.WriteLine($"Ternary Result = {result}");




Console.ReadKey();
#endregion

#region Switch- Case

Console.Write("Lütfen Notunuzu Giriniz: ");
ExamNote = int.Parse(Console.ReadLine());

switch (ExamNote)
{
    case > 60:
        Console.WriteLine("Geçtiniz.");
        break;
    case > 50:
        Console.WriteLine("Bütünlemeye Kaldınız.");
        break;

    default:
        Console.WriteLine("Kaldınız.");
        break;
}

string Today;

Console.Write("Lütfen Bugünün Gününü Giriniz: ");
Today = Console.ReadLine().ToUpper();

switch (Today)
{
    case "PAZARTESİ":
        Console.WriteLine("Bugün haftanın ilk günü");
        break;
    case "SALI":
        Console.WriteLine("Bugün haftanın ikinci günü");
        break;
    case "ÇARŞAMBA":
        Console.WriteLine("Bugün haftanın üçüncü günü");
        break;
    case "PERŞEMBE":
        Console.WriteLine("Bugün haftanın dördüncü günü");
        break;
    case "CUMA":
        Console.WriteLine("Bugün haftanın beşinci günü");
        break;
    case "CUMARTESİ":
        Console.WriteLine("Bugün haftanın altıncı günü");
        break;
    case "PAZAR":
        Console.WriteLine("Bugün haftanın son günü");
        break;
    default:
        Console.WriteLine("Lütfen geçerli bir gün giriniz.");
        break;
}


int sayi1, sayi2, sonuc;

Console.Write("Lütfen Birinci Sayıyı Giriniz: ");
sayi1 = int.Parse(Console.ReadLine());


Console.Write("Lütfen İkinci Sayıyı Giriniz: ");
sayi2 = int.Parse(Console.ReadLine());


sonuc = sayi1 % sayi2;


if (sonuc == 0)
{
    Console.WriteLine($"{sayi1} sayısı {sayi2} sayısına tam bölünür.");
}
else
{
    Console.WriteLine($"{sayi1} sayısı {sayi2} sayısına tam bölünmez.");
}


if (sayi1 % 2 == 0)
{
    Console.WriteLine($"{sayi1} sayısı çifttir.");
}
else
{
    Console.WriteLine($"{sayi1} sayısı tektir.");
}

#endregion