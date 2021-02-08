namespace SearchApplication.Search
{
    public class WordLocation
    {
        public int FileId { get; set; }
        public int Location { get; set; }

        public WordLocation(int fileId, int location)
        {
            FileId = fileId;
            Location = location;
        }

        public int DistanceFrom(WordLocation wl)
        {
            return wl.Location - Location;
        }

        public override string ToString()
        {
            return $"{FileId}-{Location}";
        }
    }
}
