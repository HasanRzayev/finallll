
using fruit;

using Newtonsoft.Json;
using System.Collections.Generic;
using System.Text;





Baza kodlar = new();

Queue<Client> clients = new Queue<Client>();


List<string> names = new List<string>();
names.Add("Hasan");
names.Add("Atilla");
names.Add("Teo");
names.Add("Merd");
names.Add("Baris");
names.Add("Savas");
names.Add("Ali");
names.Add("Yusuf");
List<string> jobs = new List<string>();
jobs.Add("Teacher");
jobs.Add("Police");
jobs.Add("Doctor");
jobs.Add("Housewife");






////////////////////////////////////////////////////////


Old everold = new(kodlar.OldEver);


////////////////////////////////////////////////////////

List<string> list = new List<string>();
list.Add("fresh");
list.Add("normal");
list.Add("rotten");
list.Add("toxic");






////////////////////////////////////////////////////////
Stack<Produce> patatos = new();
Stack<Produce> tomatos = new();
Stack<Produce> carrots = new();

Stack<Produce> redpeppers = new();
Produce patato = new(12, kodlar.RandomCombition(list), "Gedebey", 1);
Produce tomato = new(15, kodlar.RandomCombition(list), "Goycay", 1);
Produce carrot = new(15, kodlar.RandomCombition(list), "Russion", 1);
Produce onion = new(15, kodlar.RandomCombition(list), "Masalli", 1);
Produce redpepper = new(15, kodlar.RandomCombition(list), "Siyezen", 1);
Produce corn = new(15, kodlar.RandomCombition(list), "Qebele", 1);
Produce lettuce = new(15, kodlar.RandomCombition(list), "Hacıqabul", 1);
Produce cucumber = new(15, kodlar.RandomCombition(list), "İsmayıllı", 1);

Produce mushroom = new(45, kodlar.RandomCombition(list), "Mushroom", 1);
Produce brocolli = new(35, kodlar.RandomCombition(list), "British", 1);
Produce capcisum = new(65, kodlar.RandomCombition(list), "Yevlax", 1);
Produce pumpkin = new(75, kodlar.RandomCombition(list), "Salyan", 1);
Produce garlic = new(85, kodlar.RandomCombition(list), "Pumpkin", 1);
Produce apple = new(95, kodlar.RandomCombition(list), "Quba", 1);
Produce orange = new(85, kodlar.RandomCombition(list), "Pumpkin", 1);
Produce pear = new(75, kodlar.RandomCombition(list), "Qazax", 1);
Produce peach = new(65, kodlar.RandomCombition(list), "Ismayilli", 1);
Produce apricot = new(55, kodlar.RandomCombition(list), "Xacmaz", 1);
Produce banana = new(45, kodlar.RandomCombition(list), "Goycay", 1);
Produce strawberry = new(35, kodlar.RandomCombition(list), "Qax", 1);
Produce pomegranate = new(45, kodlar.RandomCombition(list), "Kurdemir", 1);
Produce watermelon = new(55, kodlar.RandomCombition(list), "Sabirabad", 1);
Produce lemon = new(25, kodlar.RandomCombition(list), "Lenkeran", 1);
Produce coconut = new(25, kodlar.RandomCombition(list), "Africa", 1);
Produce grape = new(25, kodlar.RandomCombition(list), "Fatmayil", 1);
Produce fig = new(25, kodlar.RandomCombition(list), "Goradil", 1);
Produce mandarin = new(25, kodlar.RandomCombition(list), "Parnik", 1);
Produce pineapple = new(25, kodlar.RandomCombition(list), "America", 1);
////////////////////////////////////////////////////////

for (int i = 0; i < 155; i++)
{
    patatos.Push(patato = new(15, kodlar.RandomCombition(list), "Gedebey", 1));
    tomatos.Push(tomato = new(15, kodlar.RandomCombition(list), "Goycay", 1));
    carrots.Push(carrot = new(15, kodlar.RandomCombition(list), "Russion", 1));

}


////////////////////////////////////////////////////////

for (int i = 0; i < 6; i++)
    {
        patatos.Push(patato = new(2, kodlar.RandomCombition(list), "Gedebey", 1));
        tomatos.Push(tomato = new(5, kodlar.RandomCombition(list), "Goycay", 1));
        carrots.Push(carrot = new(5, kodlar.RandomCombition(list), "Russion", 1));


    }
    ////////////////////////////////////////////////////////

    Dictionary<string, Stack<Produce>> baza = new Dictionary<string, Stack<Produce>>();


    baza.Add("Patato", patatos);
    baza.Add("Tomato", tomatos);
    baza.Add("Carrot", carrots);




    ////////////////////////////////////////////////////////






    ////////////////////////////////////////////////////////



    Dictionary<string, Produce> sellstandobject = new Dictionary<string, Produce>();
    sellstandobject["Patato"] = tomato;
    sellstandobject["Tomato"] = patato;
    sellstandobject["Carrot"] = carrot;
    sellstandobject["Onion"] = onion;
    sellstandobject["Redpepper"] = redpepper;
    sellstandobject["Corn"] = corn;
    sellstandobject["Lettuce"] = lettuce;
    sellstandobject["Cucumber"] = cucumber;
    sellstandobject["Mushroom"] = mushroom;
    sellstandobject["Brocolli"] = brocolli;
    sellstandobject["Capcisum"] = capcisum;
    sellstandobject["Pumpkin"] = pumpkin;
    sellstandobject["Garlic"] = garlic;
    sellstandobject["Apple"] = apple;
    sellstandobject["Orange"] = orange;
    sellstandobject["Pear"] = pear;
    sellstandobject["Peach"] = peach;
    sellstandobject["Apricot"] = apricot;
    sellstandobject["Banana"] = banana;
    sellstandobject["Strawberry"] = strawberry;
    sellstandobject["Pomegranate"] = pomegranate;
    sellstandobject["Watermelon"] = watermelon;
    sellstandobject["Lemon"] = lemon;
    sellstandobject["Coconut"] = coconut;
    sellstandobject["Grape"] = grape;
    sellstandobject["Fig"] = fig;
    sellstandobject["Mandarin"] = mandarin;
    sellstandobject["Pineappale"] = pineapple;

    var timehour = 0;
    var atilanlar = 0;
    var day = 1;
    var clientcount = 0;
    var score = 10;
    var budce = 0;
    var oldtime = -1;
    var iscimaasi = 0;
/////////////////////////////////////////////////////////////

//var json = JsonConvert.SerializeObject(baza, Newtonsoft.Json.Formatting.Indented);

//baza.Clear();


//var jsonStr = File.ReadAllText("stand.json");

//baza = JsonConvert.DeserializeObject<Dictionary<string, Stack<Produce>>>(jsonStr);

//var hesabjson = File.ReadAllText("hesab.json");

//var hesabb = JsonConvert.DeserializeObject<List<int>>(hesabjson);

//day = hesabb[0];
//timehour = hesabb[1];
//budce = hesabb[2];
//score = hesabb[3];
//day = hesabb[4];

/////////////////////////////////////////////////////////////
while (true)
{
    for (int i = 0; i < score; i++)
    {
        Random numbers = new Random();

        Client human = new(names[numbers.Next(1, names.Count)], numbers.Next(30, 50), jobs[numbers.Next(1, jobs.Count)]);
        clients.Enqueue(human);
    }
    Console.Clear();
    if (timehour == oldtime) everold.Start(baza);

    //foreach (var kvp in baza.ToArray())
    //{
    //    Console.WriteLine("=");
    //    Console.Write(kvp.Key);
    //    kvp.Value.ToList().ForEach(x => x.Print());
    //    Console.WriteLine("=");

    //}
    //Console.Clear();
    Random rnd = new Random();
    int num = rnd.Next(1, 10);
    int num2 = rnd.Next(1, 10);

    for (int i = 0; i < clients.Count; i++)
    {
        Console.ForegroundColor = ConsoleColor.White;
        Console.BackgroundColor = ConsoleColor.Red;

        Console.WriteLine("Musteri geldi");
        Console.WriteLine("Adi---" + clients.Peek().name);
        Console.WriteLine("Yasi---" + clients.Peek().age);
        Console.WriteLine("Isi---" + clients.Peek().job);
        int number = rnd.Next(0, baza.Keys.Count());
        Console.WriteLine("Musterinin istediyi " + baza.ToList()[number].Key + " dir");
        Console.WriteLine("Istediyi miqdar " + num2 + " dir");
        Console.ForegroundColor = ConsoleColor.White;
        Console.BackgroundColor = ConsoleColor.Black;
        if (kodlar.Check(baza.ToList()[number].Key, baza, num2) == false)
        {
            score--;
            if (score == 0) score = 1;
        }
        else
        {

            for (int j = 0; j < num2; j++)
            {
                budce += kodlar.GetMoney(baza.ToList()[number].Key, baza);
                baza[baza.ToList()[number].Key].Pop();
            }

            score++;
            if (score > 10) score = 10;
            clientcount++;
        }
        clients.Dequeue();
    }


    if (timehour == 13)
    {
        timehour = 0;
        if (baza.Count > 8)
        {
            Console.WriteLine("Daha yaxsi hesablamaz ucun isci goturulur");
            Console.WriteLine("Isci goturulur");
            iscimaasi += 5;
        }
        day++;
        Random rnd2 = new Random();
        oldtime = rnd2.Next(0, 12);
        Console.ForegroundColor = ConsoleColor.White;
        Console.BackgroundColor = ConsoleColor.Green;
        Console.WriteLine("Stend ucun bazarliq etmek lazimdir");
        Console.ForegroundColor = ConsoleColor.White;
        Console.BackgroundColor = ConsoleColor.Black;
        kodlar.SellStand(sellstandobject);
        kodlar.BuyObject(baza, sellstandobject, ref budce, ref atilanlar);
        //////////////////////////////////////////////////////////////////////////////////////////////
        var bazajson = JsonConvert.SerializeObject(baza, Newtonsoft.Json.Formatting.Indented);
        List<int> hesab = new();
        hesab.Add(day);
        hesab.Add(timehour);
        hesab.Add(budce);
        hesab.Add(score);
        hesab.Add(atilanlar);
        var hesabjsonn = JsonConvert.SerializeObject(hesab, Newtonsoft.Json.Formatting.Indented);


        File.WriteAllText("stand.json", bazajson);
        File.WriteAllText("hesab.json", hesabjsonn);

    }
    Console.WriteLine($"Gun---{day}");
    Console.WriteLine($"{timehour++}:00  ");
    Console.WriteLine("SCORE---" + score);
    Console.WriteLine("Budce---" + budce);
    Console.WriteLine("atilanlar---" + atilanlar);
    Console.WriteLine("Xos gemisiniz");
    Console.WriteLine("Bazada olanlar");
    kodlar.StandPrint(baza);
    Thread.Sleep(500);
}
    

    