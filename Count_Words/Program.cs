using System;
using System.IO;
using System.Collections.Generic;
namespace Count_Words
{ 
    class MainClass
    {
        public static void Main(string[] args)
        {
            string line;
            int count = 0;
            List<string> lst = new List<string>();
            StreamReader reader = new StreamReader("/home/user/Загрузки/big.txt");
            while ((line = reader.ReadLine()) != null)
            {
                string elem = "";
                for (int i = 0; i < line.Length; i++)
                {

                    if (line[i] != ' ' && line[i] != '.' && line[i] != ',' && line[i] != '-' && line[i] != '(' && line[i] != ')' && line[i] != '[' && line[i] != ']' && line[i] != ':' && line[i] != ';' && line[i] != '\u0022')
                    {
                        elem += line[i];
                    }
                    else
                    {
                        if (elem != "")
                            lst.Add(elem);
                        elem = "";
                    }
                }
                count += 1;
            }
            //for (int i = 0; i < lst.Count; i++)
            //{
            //Console.WriteLine(lst[i]);
            //}
            Console.WriteLine("Введите строку для поиска");
            string s = Console.ReadLine();
            int size = s.Length;
            int counter = 0;
            foreach (var item in lst)
            {
                if (item[0] == s[0] && item.Length == size)
                {
                    int cnt = 0;
                    for (int i = 0; i < item.Length; i++)
                    {
                        if (item[i] == s[i])
                        {
                            cnt++;
                        }
                    }
                    if (cnt == size)
                    {
                        counter += 1;
                    }
                }
            }

            Console.WriteLine("Количество вхождений слова: " + counter);
        }
    }
}
