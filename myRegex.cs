using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;
namespace SAOD_DZ8
{
    /*
    Кузьмин Дмитрий гр. 2015 Вариант №2 
    */
    class Program
    {
        static void Main(string[] args)
        {
            //myWordCount task = new myWordCount();
            //Console.WriteLine($"the {task.WordCount("the")}");
            //Console.WriteLine(task.UniqueWordCount);
            //task.WordCount();
            //Console.WriteLine(task.Print());
            //Console.ReadLine();

            myRegex mr = new myRegex();
            mr.WordCount();
            Console.WriteLine(mr.Print());
            Console.ReadLine();
        }
    }
    class myWordCount
    {
        private Dictionary<string, int> wordList = new Dictionary<string, int>();
        private string[] checkWordList = File.ReadAllText("check.txt").Split(new char[] { '\r', '\n', ' ' }, StringSplitOptions.RemoveEmptyEntries);
        private string[] text = File.ReadAllText("big.txt").Split(new char[] { '\r', '\n', ' ' }, StringSplitOptions.RemoveEmptyEntries);
        public void WordCount()
        {
            foreach(var item in checkWordList)
            {
                int count = WordCount(item);
                if (wordList.ContainsKey(item)) 
                    wordList.Remove(item);
                wordList.Add(item, count);
                Console.Write(".");
            }
            Console.WriteLine();
        }
        public int WordCount(string word)
        {
            int count = 0;
            foreach (var item in text)
                count += item == word ? 1 : 0;
            return count;
        }
        public int UniqueWordCount => text.Distinct().Count();
        public string Print()
        {
            string buffer = "";
            foreach (var item in wordList)
                buffer += $"{item.Key} {item.Value}\n";
            return buffer;
        }
    }
    class myRegex
    {
        private Dictionary<string, int> wordList = new Dictionary<string, int>();
        private string[] checkWordList = File.ReadAllText("check.txt").Split(new char[] { '\r', '\n', ' ' }, StringSplitOptions.RemoveEmptyEntries);
        private string text = File.ReadAllText("big.txt");
        public void WordCount()
        {
            foreach (var item in checkWordList)
            {
                int count = Regex.Matches(text, item).Count;
                try { wordList.Add(item, count); }
                catch { continue; }
                Console.Write(".");
            }
            Console.WriteLine();
        }
        public int WordCount(string word) => Regex.Matches(text, word).Count;
        public int UniqueWordCount => text.Distinct().Count();
        public string Print()
        {
            string buffer = "";
            foreach (var item in wordList)
                buffer += $"{item.Key} {item.Value}\n";
            return buffer;
        }
    }
}