//Bu tür bir problemi Switch-Case kullanmak pratik olacaktır çünkü enum kullanırsak enum değerlerini otomatik olarak verecektir.

// Kullanıcıdan hangi meyveyi satın alacak
Console.Write("Hangi meyveyi satın almak istiyorsunuz? ");
string meyve = Console.ReadLine().ToLower(); // burda küçük harfe çeviriyoruz.

//////////////////////////  İF - ELSE KARAR YAPILARI //////////////////////////
if (meyve == "elma")
{
    Console.WriteLine("Elmanın fiyatı: 2 TL");
}
else if (meyve == "armut") 
{
    Console.WriteLine("Armutun fiyatı: 3 TL");
}
else if (meyve == "çilek")
{
    Console.WriteLine("Çileğin fiyatı: 2 TL");
}
else if (meyve == "muz")
{
    Console.WriteLine("Muzun fiyatı: 3 TL");
}
else
{
    Console.WriteLine("Diğer bütün meyvelerin fiyatı: 4 TL");
}

//////////////////////////  SWİTCH KARAR YAPILARI //////////////////////////

// Meyvenin fiyatını belirleme
switch (meyve)
{
    case "elma":
        Console.WriteLine("Elmanın fiyatı: 2 TL");
        break;
    case "armut":
        Console.WriteLine("Armutun fiyatı: 3 TL");
        break;
    case "çilek":
        Console.WriteLine("Çileğin fiyatı: 2 TL");
        break;
    case "muz":
        Console.WriteLine("Muzun fiyatı: 3 TL");
        break;
    default:
        Console.WriteLine("Diğer bütün meyvelerin fiyatı: 4 TL");
        break;
}


