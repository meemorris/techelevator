namespace Lecture
{
    public partial class LectureProblem
    {
        /*
        8. This loop is also counting incorrectly.
            What needs to change in the loop for it to count properly?
            TOPIC: Looping Through Arrays
        */
        public int ReturnCorrectSumAgain(int[] arrayToLoopThrough)
        {
            int sum = 0;

            //     Start;       Keep going while         Increment by one;
            for (int i = 0; i <= arrayToLoopThrough.Length; i++)
            {
                sum = sum + arrayToLoopThrough[i];
            }

            return sum;
        }
    }
}
