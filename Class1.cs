using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandsOn2FileHandling
{
    internal class Class1
    {
        public void Readfile()
        {
            FileStream fileStreamobj = new FileStream("C:\\Users\\LUCKY\\source\\repos\\HandsOn2FileHandling\\HandsOn2FileHandling.txt", FileMode.Open,FileAccess.Read);
            StreamReader streamReaderobj = new StreamReader(fileStreamobj);
            Console.WriteLine("Id\tSource\t\tDestination\tDate\t\tTime\tStatus\tNetwork");
            while (streamReaderobj.Peek() > 0)
            {
                string line = streamReaderobj.ReadLine();
                if (line != "")
                {
                    if (line.StartsWith("Date"))
                    {
                        string[] nLine1 = line.Split(' ');
                        string[] nLine2 = nLine1[0].Split(':');
                        Console.WriteLine(nLine2[1] + " " + nLine1[1] + "\t");
                        continue;

                    }
                    string[] nLine = line.Split(':');
                    Console.Write(nLine[1] + "\t");
                }
                else
                {
                    Console.WriteLine();
                }
            }
        }
    }
 }
