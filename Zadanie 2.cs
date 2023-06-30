namespace Zadanie_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] tab = wprowadzacz();
            Console.WriteLine((float)(obliczanie(tab)));         
        }
       static int[] wprowadzacz()
        {
            int[] Tab = new int[4];

            for(int i = 0; i < 4; i++) 
            {
                Tab[i] = int.Parse(Console.ReadLine());

            }
            return Tab;
        }
        static double obliczanie(int[] Tab)
        {
            int a, b, c, d;
            a= Tab[0];
            b= Tab[1];
            c= Tab[2];
            d= Tab[3];


            return (Math.Sqrt(((a-c)*(a-c))+((b-d)*(b-d)))) ;


        }
    
    
    
    }

}