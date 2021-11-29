using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Connect_Four
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> list = new List<string>()
            {
                    "A_Red",
                    "B_Yellow",
                    "A_Red",
                    "B_Yellow",
                    "A_Red",
                    "B_Yellow",
                    "G_Red",
                    "B_Yellow"
            };

            Dictionary<string, int> dick = new Dictionary<string, int>();

            foreach (var item in list)
            {
                string [] itemArgs = item.Split("_").ToArray();
                int redCount = 1;
                int yellowCount = 1;
                if (!dick.ContainsKey(itemArgs[0]))
                {
                    if (itemArgs[1]=="Yellow")
                    {
                        dick.Add(itemArgs[0], yellowCount);
                    }
                    else
                    {
                        dick.Add(itemArgs[0], redCount);
                    }
                }
                else
                {
                    
                     
                    
                }
            }
        }

    }
}

