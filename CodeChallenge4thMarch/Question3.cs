using System;
using System.Collections.Generic;
using System.Linq;

namespace CodeChallenge4thMarch
{
    public class Question3
    {
        public static void Answer()
        {
            string word = "the day is sunny the the the sunny is is";
            var words = word.Split(' ');
            Dictionary<string, int> myword = new Dictionary<string, int>();
            foreach (var item in words)
            {
                if (myword.ContainsKey(item))
                {
                    myword[item] = (int) myword[item] + 1;
                }
                else
                {
                    myword.Add(item, 1);
                }
            }
            foreach (var item in myword)
            {
                if (item.Key != string.Empty)
                {
                    Console.WriteLine($"{item.Key}\t{item.Value}");   
                }

            }
        }
    }
}