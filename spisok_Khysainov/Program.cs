using System;

namespace spisok_Khysainov
{
    class Program
    {
        static void Main(string[] args)
        {
            var list = new Model.List<int>();
            list.Add(1);
            list.Add(2);
            list.Add(3);
            list.Add(4);

            Console.ReadLine();
        }
    }
}
