namespace Lecture.Farming
{
    public class Tractor : ISingable
    {
        public string Name { get; }
        public string Sound { get; }

        public Tractor()
        {
            Name = "Tractor";
            Sound = "vroom";
        }
    }
}
