using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComportamientoStrategy
{
    class Program
    {
        static void Main(string[] args)
        {
            SortedList studentRecords = new SortedList();

            studentRecords.Add("Maria");
            studentRecords.Add("Manolo");
            studentRecords.Add("Joaquin");
            studentRecords.Add("Pedro");
            studentRecords.Add("Ana");

            studentRecords.SetSortStrategy(new QuickSort());
            studentRecords.Sort();

            studentRecords.SetSortStrategy(new ShellSort());
            studentRecords.Sort();

            studentRecords.SetSortStrategy(new MergeSort());
            studentRecords.Sort();

            Console.ReadKey();
        }
    }
}
