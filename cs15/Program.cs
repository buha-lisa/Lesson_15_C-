namespace cs15
{
    internal class Program
    {
        static void Main()
        {
            while (true)
            {
                Console.Write("Choose number of task(1-3): ");
                int.TryParse(Console.ReadLine(), out int task);
                if (task == 0) break;
                var film = new Film()
                {
                    Name = "Geostorm",
                    StudioName = "Warner Bros.",
                    Genre = "Science Fiction",
                    DurationInMinutes = 109,
                    ReleaseYear = 2017
                };

                var actors = new List<string> { "Actor_1", "Actor_2", "Actor_3", "Actor_4" };
                var performance = new Performance()
                {
                    Name = "Hamlet",
                    TheaterName = "Royal Theater",
                    Genre = "Tragedy",
                    DurationInMinutes = 180,
                    Actors = actors
                };

                switch (task)
                {
                    case 1:
                        film.DisplayInfo();

                        GC.Collect();
                        GC.WaitForPendingFinalizers();
                        break;
                    case 2:
                        performance.DisplayInfo();
                        performance.Dispose();
                        Console.WriteLine($"The film '{performance.Name}' from '{performance.TheaterName}' is being dispose.\n");
                        break;
                    case 3:
                        film.DisplayInfo();
                        film.Dispose();

                        Console.WriteLine($"The film '{film.Name}' from '{film.StudioName}' is being dispose.\n");
                        performance.DisplayInfo();

                        GC.Collect();
                        GC.WaitForPendingFinalizers();
                        break;
                }
            }

            //var stopWatch = Stopwatch.StartNew();

            //for(int i = 0; i < 100000; i++)
            //{
            //    var obj = new MyObject();
            //}

            //stopWatch.Stop();

            //var totalMemory = GC.GetTotalMemory(false);
            //var totalMemoryKB = totalMemory / 1024.0;
            //var totalMemoryMB = totalMemory / (1024.0 * 1024.0);

            //Console.WriteLine($"Elapsed time: {stopWatch.ElapsedMilliseconds} ms");
            //Console.WriteLine($"Total memory: {totalMemory} bytes");
            //Console.WriteLine($"Total memory: {totalMemoryKB} KB");
            //Console.WriteLine($"Total memory: {totalMemoryMB} MB");


            //GC.Collect();
            //GC.WaitForPendingFinalizers();
        }
    }

    //class MyObject
    //{
    //    ~MyObject()
    //    {
    //        //Console.WriteLine("Destructor");
    //    }
    //}

}
