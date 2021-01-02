using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exersize
{
    class Program
    {
        static void Main(string[] args)
        {
            int counPicture = 52;//всего картин у пользователя
            Console.WriteLine($"В Вашей галерее всего {counPicture} картинки");
            Console.WriteLine();

            int calcGalleryFull; //в переменной будет подсчет возможных полных рядов
            int calcGalletyLeft; //в переменной будет храниться картины, не входящие в полный ряд

            calcGalleryFull = counPicture / 3;
            calcGalletyLeft = counPicture % 3;

            Console.WriteLine($"У Вас будет полностью заполнено {calcGalleryFull} рядов с картинками");
            Console.WriteLine($"{calcGalletyLeft} картинка будет сверх меры");
            Console.ReadKey();
        }
    }
}
