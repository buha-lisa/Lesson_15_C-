
namespace cs15
{
    internal class Performance : IDisposable
    {
        public string Name { get; set; }
        public string TheaterName { get; set; }
        public string Genre { get; set; }
        public int DurationInMinutes { get; set; }
        public List<string> Actors { get; set; }

        public Performance() { }

        public void Dispose() {}

        ~Performance()
        {
            Console.WriteLine($"The performance '{Name}' from '{TheaterName}' is being destroyed.");
            Dispose();
        }

        public void DisplayInfo()
        {
            Console.WriteLine($"Name: {Name}");
            Console.WriteLine($"Film Studio: {TheaterName}");
            Console.WriteLine($"Genre: {Genre}");
            Console.WriteLine($"Duration: {DurationInMinutes} minutes");
            Console.WriteLine($"List of actors:");
            foreach ( var actor in Actors )
            {
                Console.WriteLine($"  -   {actor}");
            }
        }
    }
}
