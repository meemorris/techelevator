namespace Lecture.Farming
{
    /// <summary>
    /// A singable item.
    /// </summary>
    public interface ISingable
    {
        /// <summary>
        /// The singable item's name.
        /// </summary>
        string Name { get; }

        /// <summary>
        /// The singable item's sound.
        /// </summary>
        /// <returns></returns>
        string Sound { get; }
    }
}
