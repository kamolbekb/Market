namespace Homework
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Market market = new Market(5234, "Kefir");
            Console.WriteLine();
            Market market1 = new Market();
            Console.WriteLine();
            Market market2 = new Market(7200, "Bread", "b-212", "Bakery");
            Console.WriteLine();

            decimal[] decimals = { market.Price, market1.Price, market2.Price };
            CalculateTotal(decimals);
        }
        static void CalculateTotal(decimal[] sum)
        {
            decimal total=0;
            for (int i = 0; i < sum.Length; i++)
            {
                total += sum[i];
            }
            Console.WriteLine($"Total:{total}");
        }
    }
    class Market
    {
        public decimal Price { get; set;}
        public string Name { get; set;}
        public string Code { get; set;}
        public string Category { get; set;}

        public Market()
        {
            Price = 0;
            Name = "Unfilled";
            Code = "a-000";
            Category = "None";
            DisplayInfo();
        }

        public Market(decimal price, string name)
        {
            Price = price;
            Name = name;
            Code = "A-001";
            Category = "Unfilled";
            DisplayInfo();
        }

        public Market(decimal price, string name, string code, string category)
        {
            Price = price;
            Name = name;
            Code = code;
            Category = category;
            DisplayInfo();
        }

        public void DisplayInfo()
        {
            Console.WriteLine($"Price:{Price}\nName:{Name}\nCode:{Code}\nCategory:{Category}");
        }
    }
}