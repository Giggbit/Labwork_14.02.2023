using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labwork_14._02._2023
{
    internal class Arr : IOutput, IMath, ISort
    {
        private int[] mas = new int[5]; 

        public Arr() { }
        public Arr(int[] mas) {
            this.mas = mas;
        }

        public void Enter() {
            Console.WriteLine("Enter value of massive:");
            string n = null; int num = 0;
            for(int i = 0; i < mas.Length; i++) {
                n = Console.ReadLine();
                num = Convert.ToInt32(n);
                mas[i] = num;
            }
        }
        public void Show() {
            Console.WriteLine();
            foreach(int a in mas) {
                Console.Write($"{a} ");
            }
        }
        public void Show(string info) {
             foreach(int a in mas) {
                Console.WriteLine(a);
             }
            Console.WriteLine(info);
        }

        public float Avg() {
            int sum = 0;
            foreach(int a in mas) {
                sum += a;
            }
            return sum;
        }
        public int Max() {
            int max = 0;
            for(int i = 0; i < mas.Length; i++) { 
                if(max < mas[i]) { max = mas[i]; }
            }
            return max;
        }
        public int Min() {
            int min = mas[0];
            for(int i = 0; i < mas.Length; i++) { 
                if(min > mas[i]) { min = mas[i]; }
            }
            return min;
        }
        public bool Search(int valueToSearch) {
            Console.Write("\nEnter element: ");
            string e = Console.ReadLine();
            int element = Convert.ToInt32(e);
            if(element == valueToSearch) { Console.WriteLine("Number has found"); }
            return true;
        }

        public void SortAsc() {
            Array.Sort(mas, (x, y) => x.CompareTo(y));
        }
        public void SortDesc() {
            Array.Sort(mas, (x, y) => y.CompareTo(x));
        }
        public void SortByValue(bool isAsc) { 
            if(isAsc == true) {
                Array.Sort(mas, (x, y) => x.CompareTo(y));
            }
            else if(isAsc == false) {
                Array.Sort(mas, (x, y) => y.CompareTo(x));
            }
        }
    }
}
