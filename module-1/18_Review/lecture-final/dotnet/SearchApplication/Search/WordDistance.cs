namespace SearchApplication.Search
{
    public class WordDistance
    {
        public int FileId { get; set; }
        public int Distance { get; set; }
        public WordDistance(int fileId, int distance)
        {
            FileId = fileId;
            Distance = distance;
        }
    }
}
