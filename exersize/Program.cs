using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pictures
{
    class Program
    {
        static void Main(string[] args)
        {
            int picturesInTheAlbum = 52;
            Console.WriteLine($"В Вашей галерее всего {picturesInTheAlbum} картинки\n");
            Console.WriteLine($"У Вас будет полностью заполнено {picturesInTheAlbum / 3} рядов с картинками");
            Console.WriteLine($"{picturesInTheAlbum % 3} картинка будет сверх меры");
            Console.ReadKey();
        }
    }
}
