using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;









namespace fruit
{
    class Produce

    {
        public Produce(int money, string condition, string whereplant, int sellmoney)
        {
            this.money = money;

            this.condition = condition;
            this.whereplant = whereplant;
            this.sellmoney = sellmoney;
        }

        public int money { get; set; }
        public int sellmoney { get; set; }

        public string condition { get; set; }
        public string whereplant { get; set; }
        public override string ToString()
        {

            return $"    {money} {condition}  {whereplant}";
        }
        public void Print()
        {

            Console.Write(String.Format("  {0, 10}    ", money));
            Console.Write(String.Format("  {0, 10}    ", condition));
            Console.Write(String.Format("  {0, 10}    ", whereplant));
            //Console.WriteLine("Qiymeti " + money + " AZN");
            //Console.WriteLine("Veziyyeti----" + condition);
            //Console.WriteLine("Yetisdiyi yer" + whereplant);

            
        }
  
        public Produce()
        {

        }

        public Produce(Produce other)
        {
            this.money = other.money;
            this.condition = other.condition;
            this.whereplant = other.whereplant;
            this.sellmoney = other.sellmoney;
        }


        public object Clone()
        {
            return new Produce(this);
        }

    }
}
