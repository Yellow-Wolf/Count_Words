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
            int l = 0;
            for (int i = 0; i < 10; i++){
                for (int j = 0; j < 10; j++){
                    if (j == i/2 - l)
                        Console.Write("/");
                    else if (j == i/2 + l)
                        Console.Write("\");
                    Console.Write(" ");
                 }
                                      l++;
                                      Console.WriteLine();
            }
            
            while(true)
                Console.WriteLine("Hello World!");
        }
    }
}
