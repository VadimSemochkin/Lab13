using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задача_13
{
    class Program
    {
        static void Main(string[] args)
        {
            Building building = new Building("Расула Гамзатова, 11", 32, 24, 42);
            Console.WriteLine("Характеристики здания: ");
            building.Print();

            MultiBuilding multiBuilding = new MultiBuilding("Empire state building", 50, 50, 120, 32);
            Console.WriteLine("Характеристики небоскреба: ");
            multiBuilding.Print();
            Console.ReadKey();
        }
    }

    public class Building
    {
        public string loc;
        public int lengh;
        public int wide;
        public int hight;


        public string Loc
        {
            set
            {
                loc = value;
            }
            get

            {
                return loc;
            }
        }
        public int Lengh
        {
            set
            {
                lengh = value;
            }
            get

            {
                return lengh;
            }
        }
        public int Wide
        {
            set
            {
                wide = value;
            }
            get

            {
                return wide;
            }
        }
        public int Hight
        {
            set
            {
                hight = value;
            }
            get

            {
                return hight;
            }
        }
        public Building(string loc, int lengh, int wide, int hight)
        {
            Loc = loc;
            Lengh = lengh;
            Wide = wide;
            Hight = hight;
        }

        public void Print()
        {
            Console.WriteLine("Адрес здания: {0}", Loc);
            Console.WriteLine("Длина здания: {0} м.", Lengh);
            Console.WriteLine("Ширина здания: {0} м.", Wide);
            Console.WriteLine("Высота здания: {0} м.", Hight);
        }
    }

    sealed public class MultiBuilding : Building
    {
        int layers;
        public int Layers
        {
            set
            {
                layers = value;
            }
            get
            {
                return layers;
            }
        }
        public MultiBuilding (string loc, int lengh, int wide, int hight, int layers):base(loc, lengh, wide, hight)
        {
            base.loc = loc;
            base.lengh = lengh;
            base.wide = wide;
            base.hight = hight;
            Layers = layers;
                
        }

        public new  void Print()
        {
            base.Print();
            Console.WriteLine("Этажность здания {0} этажей", Layers);
        }
    }


}
