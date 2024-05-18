
namespace cs15
{
    class Film : IDisposable
    {
        public string Name { get; set; }
        public string StudioName { get; set; }
        public string Genre { get; set; }
        public int DurationInMinutes { get; set; }
        public int ReleaseYear { get; set; }

        public Film() {}

        ~Film()
        {
            Console.WriteLine($"The film '{Name}' from '{StudioName}' is being destroyed.");
        }

        public void Dispose() {}


        public void DisplayInfo()
        {
            Console.WriteLine($"Name: {Name}");
            Console.WriteLine($"Film Studio: {StudioName}");
            Console.WriteLine($"Genre: {Genre}");
            Console.WriteLine($"Duration: {DurationInMinutes} minutes");
            Console.WriteLine($"Year of release: {ReleaseYear}");
        }
    }
}
