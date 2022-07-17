namespace ModuleTaskFour
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using (var db = new PlayListContext())
            {
                var request1 = db.Songs.Select(x => x);
                foreach (var song in request1)
                {
                    for (int i = 0; i < song.Performers.Count; i++)
                    {
                        Console.WriteLine($"{song.Title} {song.Performers[i].Artist.Name} {song.Genre.Title}");
                    }
                }

                Console.WriteLine("--------------------------");

                var request2 = db.Songs
                    .Where(x => x.ReleasedDate < db.Artists.Select(x => x.DateOfBirth).Min(c => c))
                    .Select(s => s.Title);
                foreach (var title in request2)
                {
                    Console.WriteLine(title);
                }
            }
        }
    }
}