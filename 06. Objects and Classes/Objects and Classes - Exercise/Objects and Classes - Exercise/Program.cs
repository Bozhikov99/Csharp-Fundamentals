using System;

namespace Objects_and_Classes___Exercise
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string[] phrases = 
            { 
                "Excellent product.",
                "Such a great product.",
                "I always use this product.",
                "Best product of its category.",
                "Exceptional product.",
                "I can't live without this product.",
            };
            
            string[] Events = 
            { 
                "Now I feel good.",
                "I have succeeded with this product.",
                "Makes miracles. I am happy of the results!",
                "I cannot believe but now I feel awesome.",
                "Try it yourself, I am very satisfied.",
                "I feel great!",
            };

            string[] authors =
            {
                "Diana",
                "Petya",
                "Stella",
                "Elena",
                "Katya",
                "Iva",
                "Annie",
                "Eva"
            };

            string[] cities =
            {
                "Burgas",
                "Sofia",
                "Plovdiv",
                "Varna",
                "Ruse"
            };
            Random rand = new Random();
            for (int i = 1; i <= n; i++)
            {
                Message newMessage = new Message();
                int phraseInd = rand.Next(0, phrases.Length);
                newMessage.Phrase = phrases[phraseInd];

                int eventInd = rand.Next(0, Events.Length);
                newMessage.Event = Events[eventInd];

                int authorInd = rand.Next(0, authors.Length);
                newMessage.Author = authors[authorInd];

                int cityInd = rand.Next(0, cities.Length);
                newMessage.City = cities[cityInd];

                Console.WriteLine(newMessage.ToString());
            }
        }
    }
    class Message
    {
        public string Phrase { get; set; }
        public string Event { get; set; }
        public string Author { get; set; }
        public string City { get; set; }
        public override string ToString()
  
        {
            return $"{Phrase} {Event} {Author} - {City}.";
        }
    }
}
