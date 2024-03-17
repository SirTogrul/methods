namespace task3
{
    internal class Program
    { 
        public static void names(string[] name)
        {
            char key ='A';
         for(int i=0;i<name.Length; i++)
            {
                for (int j = 0; j < name[i].Length; j++)
                {
                 if (name[i][j] == key)
                    {
                        Console.WriteLine(name[i]);
                    }
                }
            }
        }
        static void Main(string[] args)
        {
            string[] name = { "Anar", "Ramiz", "Aysel", "Togtul", "Mahsun" };
            names(name);
        }
    }
}