using System;

namespace Count_Words
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine("test World!");
            int count = 0;
            list<string> lst = new list<string>();
            string l = Console.ReadLine();
            while (l != " "){
                for (int i = 0; i < lst.Count; i++){
                        if (lst[i] == l){
                            break();
                        }
                }
                lst.Add(l);
                l = Console.ReadLine();
            }
        }
    }
}
