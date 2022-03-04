 using System;
 using System.Collections.Generic;
 using System.Linq;
 using System.Runtime.CompilerServices;

 namespace CodeChallenge4thMarch
{
    class Program
    {
        static void Main(string[] args)
        {
            //Question3.Answer();
            //Question2();
            Question1();
        }


        public static void Question2()
        {
            string[] words = {"a", "ab", "abc", "d", "cd", "bcd", "abcd"};
            // {"a", "aa", "aaa", "aaaa"}{"abcw", "baz", "foo", "bar", "xtfn", "abcdef"}
            var max = 0;
            for (int i = 0; i < words.Length; i++)
            {
                for (int j = 0; j < words.Length - 1; j++)
                {
                    int count = 0;
                    foreach (var g in words[j])
                    {
                        if (words[i].Contains(g))
                            {
                                count++;
                            }
                    }
                    if (count == 0)
                    {
                        var product = 0;
                        product = words[i].Length * words[j].Length;
                        if (product > max)
                        {
                            max = product;
                        }
                    }
                }
            }
            Console.WriteLine(max);
        }

        public static void Question1()
        {
            int steps = 0;
            string password = "abcde";
            if (password.Length < 6)
            {
                steps = 6 - password.Length;
            }
            if (password.Length > 20)
            { 
                steps = password.Length - 20;
            }

            for (int i = 0; i < password.Length; i++)
            {
                int countsame = 0;
                for (int j = 0; j < password.Length - 1; j++)
                {
                    if (password[i] == password [j])
                    {
                        countsame++;
                       
                    }
                }

                if (countsame >= 3)
                {
                    if (steps == 0)
                    {
                        steps += (countsame / 3);
                    }

                }
            }

            foreach (var leta in password)
            { 
                if (leta !>= '0' || leta !<= '9')
                {
                    if (steps == 0)
                    {
                        steps += 1;
                    }
                }
            }
            var LowerPassword = password.ToLower();
            int count = 0;
            for (int i = 0; i < password.Length; i++)
            {
                
                    if (LowerPassword[i] == password[i])
                    {
                        count++;
                    }
            }

            if (count == password.Length)
            {
                if (steps == 0)
                {
                    steps += 1;
                }
            }

            Console.WriteLine(steps);
        }
        
    }
}