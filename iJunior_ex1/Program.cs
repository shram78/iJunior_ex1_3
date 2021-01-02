using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iJunior_ex1
{
    class Program
    {
        static void Main(string[] args)
        {
            float health;
            int armor;
            int damage;

            Console.Write("Введите количество жизней: ");
            health = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите количество брони: ");
            armor = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите количество урона: ");
            damage = Convert.ToInt32(Console.ReadLine());

            health -= Convert.ToSingle(damage) / 100 * armor;
            Console.WriteLine($"После атаки в {damage} урона," +
                              $" у вас осталось {health} жизней.");
            Console.ReadLine();
        }
    }
}
