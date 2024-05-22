namespace CasinoConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            double odds = .75;
            Guy player = new Guy() { Cash = 100, Name = "Gracz" };

            Console.WriteLine("Witaj w kasynie! Prawdopodobieństwo przegranej wynosi 0.75");

            while(player.Cash > 0)
            {
                player.WriteMyInfo();

                Console.Write("Podaj stawkę: ");
                string howMuch = Console.ReadLine();

                if (int.TryParse(howMuch, out int pot))
                {
                    if (pot > player.Cash)
                    {
                        Console.WriteLine("Niestety, nie masz tylu pieniędzy.");
                        continue;
                    }
                    else
                        pot *= 2;
                }
                else
                {
                    Console.WriteLine("Nie udało się przyjąć zakładu.");
                    continue;
                }

                double bet = random.NextDouble();
                if (bet > odds)
                {
                    player.Cash += pot;
                    Console.WriteLine("Wygrałeś " + pot + " zł.");
                }
                else
                {
                    player.Cash -= pot/2;
                    Console.WriteLine("Niestety, przegrałeś.");
                }
            }
        }
    }
}
