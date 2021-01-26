using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace FilesAssign
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = null;
            string s = null;
            while(str!="@")
            {
                Console.WriteLine("enter the text: ");
                str=Console.ReadLine();

                if(str != "@")
                {
                    s = s + str;
                }
            }

            using (FileStream fs = new FileStream(@"d:\assign.txt", FileMode.Create, FileAccess.ReadWrite)) 
            {
                using(StreamWriter writer=new StreamWriter(fs))
                {
                    writer.WriteLine(s);
                    writer.WriteLine("contents of file in streamwriter: ");
                    writer.WriteLine("Hi");
                }

            }
            using (FileStream fs1 = new FileStream(@"d:\assign.txt", FileMode.Open))
            {
                using(StreamReader reader=new StreamReader(fs1))
                {
                    Console.WriteLine("contents of file assign.txt: " + reader.ReadToEnd());
                }
                

            }
        }
    }
}
