using System.Security.Cryptography;

namespace MonteCarlo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Quanti lanci vuoi fare");
            float lanci = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Dimmi la larghezza del rettangolo");
            int larg = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Dimmi la lunghezza del rettangolo");
            int lung = Convert.ToInt32(Console.ReadLine());

            float D = 0;
            float S = 0;

            for (int i = 0; i < lanci; i++)
            {
                Random rand = new Random();
                int X = rand.Next(1, larg);
                int Y = rand.Next(1, lung);

                if (X > larg / 2)
                {
                    D++;
                }
                else
                {
                    S++;
                }
            }

            Console.WriteLine("A destra ci sono " + D + " lanci");
            Console.WriteLine("A sinistra ci sono " + S + " lanci");

            float A1 = D / lanci;
            float A2 = S / lanci;

            float perc1 = D * 100 / lanci;
            float perc2 = S * 100 / lanci;

            Console.WriteLine("L'area a destra è " + A1 + " ci sono il " + perc1 + "% dei lanci");
            Console.WriteLine("L'area a sinistra è " + A2 + " ci sono il " + perc2 + "% dei lanci");

        }
    }
}
