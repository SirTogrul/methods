using Microsoft.Win32.SafeHandles;
using System.Reflection.Metadata.Ecma335;
using System.Threading.Channels;

namespace task1
{
    internal class Program
    {
        public static void same(string[] name1, string[] name2)
        {
         for(int i=0; i<name1.Length; i++)
            {
              for(int j=0; j<name2.Length; j++)
                {
                    if (name1[i] == name2[j])
                    {
                        Console.WriteLine("ortaq elementler:"+name1[i]);
                    }
                }
            }
        }


        static void Main(string[] args)
        {
            string[] name1 = { "salam", "necesen", "falan" ,"filan"};
            string[] name2 = { "yaxsi", "salam", "filan","pis" };
            same(name1, name2);
        }
    }
}