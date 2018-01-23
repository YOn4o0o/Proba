using System;

namespace ConsoleApplication5
{
    class Program
    {
        static void Main()
        {
            var broiNoshtuvki = int.Parse(Console.ReadLine());
            var vidDestinaciq = Console.ReadLine();
            var vidtransport = Console.ReadLine().ToLower();

            if (vidDestinaciq == "Miami")
            {
                Console.WriteLine(Miami(broiNoshtuvki, vidtransport));
            }
            else if (vidDestinaciq == "Canary Islands")
            {
                Console.WriteLine();
            }
            else if (vidDestinaciq == "Philippines")
            {
                Console.WriteLine(Philippines(broiNoshtuvki,vidtransport));
            }
           
        }

        static double Miami(int noshtuvki, string transport)
        {
            var result = 0.0;
            var sumNoshtuvki = 0.0;
            var sumTrans = 0.0;

            if (transport == "train")
            {
                var stari = 2 * 22.30;
                var mladi = 3 * 12.50;
                sumTrans = mladi + stari;

            }
            else if (transport == "bus")
            {
                var stari = 2 * 45.00;
                var mladi = 3 * 37.00;
                sumTrans = mladi + stari;
            }
            else if (transport == "airplane")
            {
                var stari = 2 * 90.00;
                var mladi = 3 * 68.50;
                sumTrans = mladi + stari;
            }


            if (noshtuvki >= 1 && noshtuvki <= 10)
            {
                var stari = 2 * 24.99;
                var mladi = 3 * 14.99;
                var prestoi = noshtuvki * (mladi + stari);
                var zaKuche = 0.25 * prestoi;

                var sum = prestoi + zaKuche;
                sumNoshtuvki = sum;

            }
            else if (noshtuvki >= 11 && noshtuvki <= 15)
            {
                var stari = 2 * 24.99;
                var mladi = 3 * 14.99;
                var prestoi = noshtuvki * (mladi + stari);
                var zaKuche = 0.25 * prestoi;

                var sum = prestoi + zaKuche;
                sumNoshtuvki = sum;
            }
            else if (noshtuvki > 15)
            {
                var stari = 2 * 24.99;
                var mladi = 3 * 14.99;
                var prestoi = noshtuvki * (mladi + stari);
                var zaKuche = 0.25 * prestoi;

                var sum = prestoi + zaKuche;
                sumNoshtuvki = sum;
            }

            return result = sumNoshtuvki + sumTrans;
            Console.WriteLine($"{result:f3}");
        }

        static double Philippines(int noshtuvki, string transport)
        {
            var result = 0.0;
            var sumNoshtuvki = 0.0;
            var sumTrans = 0.0;

            if (transport == "train")
            {
                var stari = 2 * 22.30;
                var mladi = 3 * 12.50;
                sumTrans = mladi + stari;

            }
            else if (transport == "bus")
            {
                var stari = 2 * 45.00;
                var mladi = 3 * 37.00;
                sumTrans = mladi + stari;
            }
            else if (transport == "airplane")
            {
                var stari = 2 * 90.00;
                var mladi = 3 * 68.50;
                sumTrans = mladi + stari;
            }


            if (noshtuvki >= 1 && noshtuvki <= 10)
            {
                var stari = 2 * 42.99;
                var mladi = 3 * 39.99;
                var prestoi = noshtuvki * (mladi + stari);
                var zaKuche = 0.25 * prestoi;

                var sum = prestoi + zaKuche;
                sumNoshtuvki = sum;

            }
            else if (noshtuvki >= 11 && noshtuvki <= 15)
            {
                var stari = 2 * 41.00;
                var mladi = 3 * 36.00;
                var prestoi = noshtuvki * (mladi + stari);
                var zaKuche = 0.25 * prestoi;

                var sum = prestoi + zaKuche;
                sumNoshtuvki = sum;
            }
            else if (noshtuvki > 15)
            {
                var stari = 2 * 38.50;
                var mladi = 3 * 32.40;
                var prestoi = noshtuvki * (mladi + stari);
                var zaKuche = 0.25 * prestoi;

                var sum = prestoi + zaKuche;
                sumNoshtuvki = sum;
            }

            return result = sumNoshtuvki + sumTrans;
            Console.WriteLine($"{result:f3}");
        }
    }
}


