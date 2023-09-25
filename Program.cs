using System.Collections;


namespace Dictionaries_DeBord_Joshua
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Dictionary<int, string> topGames = new()
            {
                { 1, "Fortnite" },
                { 2, "Grand Theft Auto 5" },
                { 3, "Minecraft" },
                { 4, "Division 2" },
                { 5, "Need For Speed Heat" },
                { 6, "Infamous Second Son" },
                { 7, "Detroit Become Human" },
                { 8, "The Last of Us 2" },
                { 9, "South Park The Fractured Buttwhole" },
                { 10, "The Escapists 2" }
            };

            foreach (KeyValuePair<int, string> kvp in topGames)
            {
                Console.WriteLine($"Key: {kvp.Key}, Value: {kvp.Value}");
            }

            if (topGames.ContainsKey(1))
            {
                Console.WriteLine($"My favorite game is: {topGames[1]}!");
            }


            _ = topGames.TryGetValue(11, out string result);

            if (result != "")
            {
                Console.WriteLine(result);
            }
            else
            {
                Console.WriteLine("there is no game in eleventh position.");
            }

            if (topGames.ContainsKey(5))
            {
                topGames[5] = "Life is Strange";
            }

            Console.WriteLine(topGames[5]);

            Hashtable hashTable = new(topGames);

            string favoriteGame = (string)hashTable[1];

            Console.WriteLine($"Favorite Game is {favoriteGame}");

            Hashtable capitals = new()
            {
                {"Oklahoma", "Oklahoma City" },
                {"New York", "Albany" },
                {"Texas", "Austin" },
                {"Ohio", "Colombus" }
            };

            foreach (DictionaryEntry kvp in capitals)
            {
                Console.WriteLine($"Key: {kvp.Key}, Value: {kvp.Value}");
            }
        }
    }
}