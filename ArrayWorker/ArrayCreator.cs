namespace ArrayWorker
{
    public class ArrayCreator
    {
        public static int[] CreateArray(int x)
        {
            return new int[x];
        }
        public static int[,] CreateArray(int x, int y)
        {
            return new int[x, y];
        }
    }
}