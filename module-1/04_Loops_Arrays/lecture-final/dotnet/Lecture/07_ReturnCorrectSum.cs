namespace Lecture
{
    public partial class LectureProblem
    {
        /*
        7. This loop is adding up the array incorrectly.
            What needs to change in the loop for it to count properly?
            TOPIC: Looping Through Arrays
        */
        public int ReturnCorrectSum(int[] arrayToLoopThrough)
        {
            int sum = 0;

            //     Start;       Keep going while         Increment by one;
            for (int i = 1; i < arrayToLoopThrough.Length; i++)
            {
                sum += arrayToLoopThrough[i];
            }

            return sum;
        }

    }
}
