using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fruit
{
    class Baza
    {
        public Baza()
        {

        }
        public void SellStand(Dictionary<string, Produce> sellstandobject)
        {
            foreach (var var in sellstandobject.ToArray())
            {

                Console.Write(var.Key + "   ");
                var.Value.Print();

            }
        }
        public void BuyObject(Dictionary<string, Stack<Produce>> baza, Dictionary<string, Produce> sellstandobject, ref int budce, ref int atilanlar)
        {
            int movcud = 0;
            int say = 0;

            foreach (var item in baza.ToArray())
            {

                Produce[] arrayzapas = new Produce[] { };
                arrayzapas = item.Value.ToArray();
                var listzapas = arrayzapas.ToList().FindAll(x => x.condition != "toksin").ToList();
                atilanlar += listzapas.Count();
                for (int g = 0; g < arrayzapas.Length; g++)
                {
                    item.Value.Pop();
                }
                foreach (var items in listzapas)
                {
                    item.Value.Push(items);
                }

                if (item.Value.Count < 15)
                {
                    foreach (var produce in sellstandobject.ToArray())
                    {
                        if (item.Key == produce.Key)
                        {

                            Produce[] arrayproduce = new Produce[] { };
                            arrayproduce = item.Value.ToArray();
                            for (int i = item.Value.Count; i < 55; i++)
                            {

                                produce.Value.condition = RandomCombition(new List<string>() { "fresh", "normal", "rotten", "toksin" });
                                if (budce < 0) break;
                                budce -= produce.Value.sellmoney;

                                if (produce.Value.condition == "toksin") { continue; }


                                for (int g = 0; g < arrayproduce.Length; g++)
                                {
                                    item.Value.Pop();
                                }
                                item.Value.Push(produce.Value);
                                for (int j = 0; j < arrayproduce.Length; j++)
                                {
                                    item.Value.Push(arrayproduce[j]);
                                }

                            }

                        }
                    }
                }

                if (item.Value.Count >= 30) movcud++;
                if (movcud == baza.Count && say <= 0 && baza.Count != sellstandobject.Count)
                {
                    say++;

                    foreach (var var in sellstandobject)
                    {
                        if (baza.ContainsKey(var.Key))
                        {
                            continue;

                        }
                        else
                        {
                            //var keyValuePair = sellstandobject.Single(x => x.Key == var.Key);
                            Stack<Produce> example = new();
                            example.Push(var.Value);
                            baza.Add(var.Key, example);
                            break;

                        }
                    }


                }
            }


        }
        public void OldEver(Dictionary<string, Stack<Produce>> baza)
        {
            foreach (var var in baza.ToArray())
            {


                foreach (var produce in var.Value)
                {
                    Random rnd = new Random();
                    int num = rnd.Next(1, 100);
                    if (num > 10) continue;
                    if (produce.condition == "toksin") continue;
                    else if (produce.condition == "fresh")
                    {
                        produce.condition = "normal";
                    }
                    else if (produce.condition == "normal")
                    {
                        produce.condition = "rotten";
                    }
                    else if (produce.condition == "rotten")
                    {
                        produce.condition = "toksin";
                    }

                }


            }
        }

        public string RandomCombition(List<string> list)
        {
            Random rnd = new Random();
            int num = rnd.Next(1, 100);
            if (num > 1 && num <= 50) return "fresh";
            else if (num < 50 && num <= 75) return "normal";
            else if (num < 75 && num < 100) return "rotten";
            else return "toksin";
        }


        public void StandPrint(Dictionary<string, Stack<Produce>> baza)
        {
            Console.WriteLine(String.Format(" Name         Money      Condition       Whereplant      Count(kq)    "));
            foreach (var kvp in baza.ToArray())
            {

                Console.WriteLine("==========================================================================================");
                if (kvp.Value?.ToList().Count != 0)
                {
                    Console.Write(kvp.Key);
                    kvp.Value.ToList()[0].Print();
                    Console.Write("    " + kvp.Value?.Count);
                    Console.WriteLine();
                }
                else Console.WriteLine(kvp.Key + "  yoxdur");
                Console.WriteLine("=========================================================================================");

            }
        }

        public bool Check(string s, Dictionary<string, Stack<Produce>> baza, int number)
        {
            int count = 0;
            List<Produce> produces = new();
            foreach (var var in baza.ToArray())
            {


                if (var.Key == s && var.Value.Count != 0 && var.Value.Count > number * 2)
                {

                    for (int i = 0; i < number; i++)
                    {

                        produces.Add(var.Value.Peek());
                        var.Value.Pop();

                    }
                    List<Produce> lazimlidi = new();
                    List<Produce> lazimlidi_rotten = new();
                    lazimlidi = produces.FindAll(n => n.condition == "toksin");
                    lazimlidi_rotten = produces.FindAll(n => n.condition == "rotten");
                    if (lazimlidi.Count > 0)
                    {
                        lazimlidi = produces.FindAll(n => n.condition != "toksin");
                        for (int i = 0; i < lazimlidi.ToArray().Length; i++)
                        {
                            var.Value.Push(lazimlidi.ToArray()[i]);
                        }
                        return false;
                    }
                    else if (lazimlidi_rotten.Count > 0)
                    {
                        lazimlidi_rotten = produces.FindAll(n => n.condition != "rotten");
                        for (int i = 0; i < lazimlidi_rotten.ToArray().Length; i++)
                        {
                            var.Value.Push(lazimlidi_rotten.ToArray()[i]);
                        }
                    }
                    else return true;
                    //Stack<Produce> lazimli = new();
                    //foreach (var item in var.Value)
                    //{
                    //    count++;

                    //    if (item.condition == "toksin" )
                    //    {

                    //        for (int i = 0; i < var.Value.ToArray().Length; i++)
                    //        {

                    //            Produce p = new();

                    //            p = var.Value.ToList()[i];

                    //            lazimli.Push(var.Value.ToArray()[i]);



                    //            if (var.Value.ToArray()[i].condition == "toksin")
                    //            {
                    //                for (int j = 0; j < i; j++)
                    //                {
                    //                    var.Value.Pop();
                    //                }
                    //                break;

                    //            }


                    //        }
                    //        for (int i = 0; i < lazimli.ToArray().Length; i++)
                    //        {
                    //            var.Value.Push(lazimli.ToArray()[i]);
                    //        }
                    //        return false;
                    //    }

                    //}


                }





            }

            return false;
        }

        public int GetMoney(string s, Dictionary<string, Stack<Produce>> baza)
        {

            foreach (var kvp in baza.ToArray())
            {

                if (kvp.Key == s) return kvp.Value.ToList()[0].money;




            }
            return -1;
        }
    }
}
