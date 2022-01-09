using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab20_1
{
    class Program
    {
        delegate double MyDelegat(double r);//объявляем тип делегата
        static void Main(string[] args)
        {
            MyDelegat myDelegat = Circle;//создаем экземпляр делегата
            double r = myDelegat(2.5);//этой строкой вызываем метод Circle
            Console.WriteLine(r);//выводим на экран результат

            MyDelegat myDelegat1 = Area;//создаем экземпляр делегата
            double r1 = myDelegat1(2);//этой строкой вызываем метод Area
            Console.WriteLine(r1);//выводим на экран результат

            MyDelegat myDelegat2 = BaIIVolume;//создаем экземпляр делегата
            double r2 = myDelegat2(3);//этой строкой вызываем метод BallVoiume
            Console.WriteLine(r2);//выводим на экран результат
            Console.Read();

        }

        static double Circle(double r) => 2*Math.PI*r; // метод для нахождения длины окружности
        static double Area(double r) => Math.PI * Math.Pow(r, 2);// метод для нахождения площади круга
        static double BaIIVolume(double r) => ((double) 4 / 3) * Math.PI * Math.Pow(r, 3);// метод для нахождения объема шара
                         
    }
}
