

using JZJ.Accounts;

Console.WriteLine("mogesalmebit JZJ-is bankomatshi\n");
User registration = new User();


string UserAction = string.Empty;
string AdminAction = string.Empty;

Console.Write("gtxovt airciot romeli xart 1.momxmarebeli / 2.administratori :");
string UserType = Console.ReadLine() ?? string.Empty;
if (UserType == "1")
{
    Console.WriteLine("\n" +
        "rit segvizlia dagexmarot dges?\n");
    Console.Write("1.daregistrireba/2.sesvla /3.daxmareba :");
    UserAction = Console.ReadLine() ?? string.Empty;
}
else if (UserType == "2")
{
    Console.WriteLine("risi gaketeba gnebavt\n");
    Console.Write("1.momxmareblebis siis naxva/2.sesxebis dadastureba : ");
    AdminAction = Console.ReadLine() ?? string.Empty;
}
else
{
    Console.WriteLine("darwmundit rom romelime airchiet");
}

if (UserAction == "1")
{
    Console.Write("gtoxvt seiyvanot tqveni saxeli : ");
    registration.Name = Console.ReadLine() ?? string.Empty;

    Console.Write("gtoxvt seiyvanot tqveni gvari : ");
    registration.LastName = Console.ReadLine() ?? string.Empty;

    Console.Write("gtoxvt seqmnat tqveni paroli: ");
    registration.Password = Console.ReadLine() ?? string.Empty;

    Console.Write("gtxovt seiyvanot ramdeni fuli semogaqvt : ");
    registration.Balance = decimal.Parse(Console.ReadLine() ?? string.Empty);

    Console.WriteLine();
    registration.ShowInfo();
}else if (UserAction == "2")
{
    Console.WriteLine("jer amis funcqia ar gvaqvs");
}
else if (UserAction == "3")
{
    Console.WriteLine("1.tu balansis semowmeba gindat jer equntshi unda sexvidet\n");
    Console.WriteLine("2. tu sesxis ageba gnebavt sedit eqauntshi da smdegom moitxovet\n");
    Console.WriteLine("3.tu raime tqenikuri xrsvezia sesxis agebastan balsntan and eqantant gtxovt dagvikavshirdet emailze " +
        "jokhadze96@gmail.com / nikaZaqaidze@gmail.com/ nikaJabana@gmail.com" +
        " an dagvikavshirdit sakontakto nomerze +995 577 551 971 \n");
}
else
{
    Console.WriteLine("gtxovt darwumndi rom romelime airchiet");
}

