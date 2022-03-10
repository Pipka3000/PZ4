using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PZ4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Taburet first = new Taburet();
            first.SetHeight(22);
            first.PrintHeight();
            first.SetLeg(2);
            first.PrintLeg();
            first.GetMaterial("Дерево");
            first.PrintMaterial();
            Console.ReadLine();
        }
    }
}
