using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labwork_14._02._2023
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Arr arr = new Arr();
            arr.Enter();
            arr.Show();

            /*arr.Min();
            arr.Max();
            arr.Search(2);*/

            /*arr.SortByValue(true);
            arr.Show();*/

            //arr.Greater(8);

            arr.EqualToValue(1);


        }
    }
}
