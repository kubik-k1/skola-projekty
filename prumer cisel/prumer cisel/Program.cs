// See https://aka.ms/new-console-template for more information

        Console.Write("Zadejte počet čísel, kolik budeš zadávat: ");
        int pocetCisel = int.Parse(Console.ReadLine());

        List<int> platnaCisla = new List<int>();

        for (int i = 0; i < pocetCisel; i++)
        {
            while (true)
            {
                Console.Write($"Zadejte číslo {i + 1} (nebo zadej konec pro ukončení): ");
                string vstup = Console.ReadLine();

                if (vstup.ToLower() == "konec")
                {
                    i = pocetCisel;
                    break;
                }

                if (int.TryParse(vstup, out int cislo))
                {

                    if (cislo >= 1 && cislo <= 100)
                    {
                        platnaCisla.Add(cislo);
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Číslo musí být v rozsahu (1-100)");
                    }
                }
                else
                {
                    Console.WriteLine("Neplatný vstup. Zadej číslo nebo 'konec'.");
                }
            }
        }

        if (platnaCisla.Count > 0)
        {

            double prumer = (double)platnaCisla.Sum() / platnaCisla.Count;
            Console.WriteLine($"Průměr zadaných čísel je: {prumer}");
            Console.WriteLine($"Počet platných čísel je: {platnaCisla.Count}");
        }
        else
        {
            Console.WriteLine("Nebyla zadána žádná platná čísla.");
        }
    
