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
            int picturesInTheAlbum = 52;
            int completelyFilledRows;
            int paintingsBeyondMeasure;

            Console.WriteLine($"В Вашей галерее всего {picturesInTheAlbum} картинки");
            Console.WriteLine();
            completelyFilledRows = picturesInTheAlbum / 3;
            paintingsBeyondMeasure = picturesInTheAlbum % 3;
            Console.WriteLine($"У Вас будет полностью заполнено {completelyFilledRows} рядов с картинками");
            Console.WriteLine($"{paintingsBeyondMeasure} картинка будет сверх меры");
            Console.ReadKey();
        }
    }
}
