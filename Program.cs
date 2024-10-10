 using oef4.Models;
 
 // Test Wine class
            var wine1 = new Wine { Name = "Chardonnay", YearOfOrigin = 2018, Price = 20.0, PricePerGlass = 5.0, Country = "France", Type = WineType.WHITE };
            var wine2 = new Wine { Name = "Cabernet Sauvignon", YearOfOrigin = 2015, Price = 30.0, PricePerGlass = 7.0, Country = "USA", Type = WineType.RED };
            var wine3 = new Wine { Name = "Prosecco", YearOfOrigin = 2020, Price = 15.0, PricePerGlass = 4.0, Country = "Italy", Type = WineType.SPARKLING };

            var wines = new List<Wine> { wine1, wine2, wine3 };
            Console.WriteLine("Wines:");
            foreach (var wine in wines)
            {
                Console.WriteLine(wine);
            }

            // Test PostStamp class
            var stamp1 = new PostStamp { Name = "Penny Black", YearOfOrigin = 1840, Price = 10.0, Image = "penny_black.jpg" };
            var stamp2 = new PostStamp { Name = "Inverted Jenny", YearOfOrigin = 1918, Price = 5000.0, Image = "inverted_jenny.jpg" };
            var stamp3 = new PostStamp { Name = "Blue Mauritius", YearOfOrigin = 1847, Price = 700.0, Image = "blue_mauritius.jpg" };

            var stamps = new List<PostStamp> { stamp1, stamp2, stamp3 };
            Console.WriteLine("\nPost Stamps:");
            foreach (var stamp in stamps)
            {
                Console.WriteLine(stamp);
            }

            // Test ComicBook class
            var comic1 = new ComicBook { Name = "Spider-Man", YearOfOrigin = 1962, Price = 25.0, Publisher = "Marvel", Author = "Stan Lee" };
            var comic2 = new ComicBook { Name = "Batman", YearOfOrigin = 1939, Price = 30.0, Publisher = "DC", Author = "Bob Kane" };
            var comic3 = new ComicBook { Name = "X-Men", YearOfOrigin = 1963, Price = 20.0, Publisher = "Marvel", Author = "Stan Lee" };

            var comics = new List<ComicBook> { comic1, comic2, comic3 };
            Console.WriteLine("\nComic Books:");
            foreach (var comic in comics)
            {
                Console.WriteLine(comic);
            }

            // Create a list of Collectibles
            List<Collectible> collectibles = new List<Collectible>();
            collectibles.AddRange(wines);
            collectibles.AddRange(stamps);
            collectibles.AddRange(comics);

            // Sort and print collectibles
            collectibles.Sort();
            Console.WriteLine("\nSorted Collectibles:");
            foreach (var collectible in collectibles)
            {
                Console.WriteLine($"{collectible} - Start Bid Price: {collectible.StartBidPrice:C}, Type: {collectible.CollectType}");
            }