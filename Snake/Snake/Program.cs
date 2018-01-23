using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class Program
    {
        static void Main(string[] args)
        {
            Point p1 = new Point(2, 6, '*');
            //p1.Draw();

            Point p2 = new Point(3, 6, '#');
            //p2.Draw();

            Point p3 = new Point(5, 7, 'G');


            //создаём числовой список
            List<int> numList = new List<int>();

            //добавляем в список значения
            numList.Add(0);
            numList.Add(1);
            numList.Add(2);
           
       
            //вызываем значения из списка с помощью переменных
            int x = numList[0];
            int y = numList[1];
            int z = numList[2];

            //с помощью цикла foreach поочерёдно выводим каждое начение списка на консоль
            foreach (int i in numList)
            {
                Console.WriteLine(i);
            }

            //удаление элемента из списка
            numList.RemoveAt(0);

            //создаём список объектов
            List<Point> pList = new List<Point>();

            //добавляем в список элементы
            pList.Add(p1);
            pList.Add(p2);
            pList.Add(p3);

            //создаём список символов и добавляем в нео элементы
            List<string> symbList = new List<string>
            {
                "№"
            };

            //выводим символы списка
            foreach (string i in symbList)
            {
                Console.WriteLine(i);
            }



            Console.ReadLine();

        }
    }
}
