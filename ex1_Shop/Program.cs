using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex1_Shop
{
    class Program
    {
        static void Main(string[] args)
        {
            int money;
            int eatCount;
            int eatPrice = 10;
            bool enoughtMoney;

            Console.WriteLine($"Добро пожаловать в пекарню! Сегодня еда по {eatPrice} монет");
            Console.Write("Сколько у вас золота? ");
            money = Convert.ToInt32(Console.ReadLine());
            Console.Write("Сколько еды вам нужно? ");
            eatCount = Convert.ToInt32(Console.ReadLine());

            enoughtMoney = money >= eatPrice * eatCount;
            eatCount *= Convert.ToInt32(enoughtMoney);

            money -= eatCount * eatPrice;
            Console.WriteLine($"У вас в сумке: {eatCount} еды и {money} монет.");
            Console.ReadLine();
        }
    }
}
