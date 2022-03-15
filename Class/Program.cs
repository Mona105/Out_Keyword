using System;

namespace Class
{
    class Program
    {
        public void get(out int i)
        {
           
            var random = new Random();
            i = random.Next();
           
        }
        static void Main(string[] args)
        {
            Program obj = new Program();
            int random1;
            obj.get(out random1);
            Console.WriteLine(random1);

        }
    }
}
