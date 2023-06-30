namespace Zadanie_1
{
    internal class Program
    {
        static void Main(string[] args)
        {   
            formatowanie();


        }

        static int wpisanie_urzytkownik ()
        {
            int czas=int.Parse(Console.ReadLine());
            return czas;
        }
        static void formatowanie ()
        {
            int uzytkownik = wpisanie_urzytkownik();
            int sekundy = uzytkownik % 60;
            int minuty = (uzytkownik%3600)/60;
            int godziny =uzytkownik/3600;
            string sformatowne = godziny.ToString("D2") + ":" + minuty.ToString("D2")+":"+sekundy.ToString("D2")  ;
                               

            
            Console.WriteLine(sformatowne );
        }
    }
}