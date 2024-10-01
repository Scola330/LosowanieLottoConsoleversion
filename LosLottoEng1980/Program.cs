using static System.Net.Mime.MediaTypeNames;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.Write("Losowanie: ");
        Console.Beep(500, 500);
        Random los = new Random();
        int aa = los.Next(1, 50);
        Console.Write(". ");
        Console.Beep(500, 500);
        int ba = los.Next(1, 50);
        Console.Write(". ");
        Console.Beep(500, 500);
        int ca = los.Next(1, 50);
        Console.Write(". ");
        Console.Beep(500, 500);
        int da = los.Next(1, 50);
        Console.Write(". ");
        Console.Beep(500, 500);
        int ea = los.Next(1, 50);
        Console.Write(". ");
        Console.Beep(500, 500);
        int fa = los.Next(1, 50);
        Console.Write(". ");
        Console.Beep(500, 500);
        int[] liczbatablica = new int[6];
        Console.Write(". ");
        Console.Beep(500, 500);
        liczbatablica[0] = aa;
        Console.Write(". ");
        Console.Beep(500, 500);
        liczbatablica[1] = ba;
        Console.Write(". ");
        Console.Beep(500, 500);
        liczbatablica[2] = ca;
        Console.Write(". ");
        Console.Beep(500, 500);
        liczbatablica[3] = da;
        Console.Write(". ");
        Console.Beep(500, 500);
        liczbatablica[4] = ea;
        Console.Write(". ");
        Console.Beep(500, 500);
        liczbatablica [5] = fa;
        Console.WriteLine(".");
        Console.Beep(2500, 1000);
        Console.WriteLine("rozpocząć losowanie? t/n");
        string decyzja = Console.ReadLine();
        if (decyzja == "" || decyzja != "t" && decyzja != "n")
        {
            Console.Beep(6000, 1000);
            Console.WriteLine("Błąd - dane nie są prawidłowe");
            Environment.Exit(0);
        }
        else if (decyzja == "n")
        {
            Console.Beep(1000, 1000);
            Console.WriteLine("Zakończono działanie");
            Environment.Exit(0);
        }
        else if (decyzja == "t")
        {
            Console.Write("Losowanie: ");
            Console.Beep(500, 500);
            int ab = los.Next(1, 50);
            Console.Write(". ");
            Console.Beep(500, 500);
            int bb = los.Next(1, 50);
            Console.Write(". ");
            Console.Beep(500, 500);
            int cb = los.Next(1, 50);
            Console.Write(". ");
            Console.Beep(500, 500);
            int db = los.Next(1, 50);
            Console.Write(". ");
            Console.Beep(500, 500);
            int eb = los.Next(1, 50);
            Console.Write(". ");
            Console.Beep(500, 500);
            int fb = los.Next(1, 50);
            Console.Write(". ");
            Console.Beep(500, 500);
            int[] liczbatablicaLos = new int[6];
            Console.Write(". ");
            Console.Beep(500, 500);
            liczbatablicaLos[0] = ab;
            Console.Write(". ");
            Console.Beep(500, 500);
            liczbatablicaLos[1] = bb;
            Console.Write(". ");
            Console.Beep(500, 500);
            liczbatablicaLos[2] = cb;
            Console.Write(". ");
            Console.Beep(500, 500);
            liczbatablicaLos[3] = db;
            Console.Write(". ");
            Console.Beep(500, 500);
            liczbatablicaLos[4] = eb;
            Console.Write(". ");
            Console.Beep(500, 500);
            liczbatablicaLos[5] = fb;
            Console.WriteLine(".");
            Console.Beep(2500, 1000);
            Console.WriteLine("Sprawdzanie liczb: ");

            int pary = 0;
            Console.WriteLine(" ");
            string dane = string.Empty;
            for (int i = 0; i < 6; i++)
            {
                if (liczbatablica[i] == liczbatablicaLos[i])
                {
                    pary++;
                    Console.Beep(500, 500);

                    Console.Write(liczbatablicaLos[i]);
                    Console.Beep(500, 500);
                    Console.Write(" ");
                    Console.Beep(500, 500);

                }
                else
                {
                    Console.Write(liczbatablicaLos[i]);
                    Console.Beep(500, 500);
                    Console.Write(" ");
                    Console.Beep(500, 500);
                }
            }

            Console.WriteLine(" ");
            Console.Beep(500, 500);

            for (int i = 0; i < 6; i++)
            {

                Console.Write(liczbatablica[i]);
                Console.Beep(500, 500);
                Console.Write(" ");
                Console.Beep(500, 500);

            }
            Console.WriteLine(" ");
            Console.Beep(500, 500);
            Console.WriteLine("Sprawdzenie:");
            Console.Beep(500, 500);
            string ac = Convert.ToString(liczbatablica[0]);
            Console.Beep(500, 500);
            Console.Write(" . ");
            string bc = Convert.ToString(liczbatablica[1]);
            Console.Beep(500, 500);
            Console.Write(" . ");
            string cc = Convert.ToString(liczbatablica[2]);
            Console.Beep(500, 500);
            Console.Write(" . ");
            string dc = Convert.ToString(liczbatablica[3]);
            Console.Beep(500, 500);
            Console.Write(" . ");
            string ec = Convert.ToString(liczbatablica[4]);
            Console.Beep(500, 500);
            Console.Write(" . ");
            string fc = Convert.ToString(liczbatablica[5]);
            Console.Beep(500, 500);
            Console.Write(" . ");
            DateTime data = DateTime.UtcNow.Date;
            Console.Beep(500, 500);
            Console.Write(" . ");
            dane = data.ToString("MM/dd/yyyy");
            Console.Beep(500, 500);
            Console.Write(" . ");
            string totalDane = ac + " " + bc + " " + cc + " " + dc + " " + ec + " " + fc + " " + data;
            Console.Beep(500, 500);
            Console.WriteLine(" .");
            File.AppendAllText("abcd.txt", totalDane.ToString());
            Console.Beep(2500, 1000);
            Console.WriteLine("Zapisane w abcd.txt");

            if (pary == 0 || pary == 1 || pary == 2)
            {
                Console.Beep(1500, 1000);
                Console.Beep(1000, 1000);
                Console.Beep(500, 1000);
                Console.WriteLine(" ");
                Console.WriteLine("Przegrana");
            }
            if (pary == 3 || pary == 4) {

                Console.Beep(2500, 1000);
                Console.Beep(3000, 500);
                Console.Beep(2500, 1000);
                Console.WriteLine(" ");
                Console.WriteLine("Neutralny wynik");
            
            }
            if (pary == 5 || pary == 6) {

                Console.Beep(5000, 1000);
                Console.Beep(1, 250);
                Console.Beep(5000, 1000);
                Console.WriteLine(" ");
                Console.WriteLine("Wygrana");
            
            }
        }
    }
}