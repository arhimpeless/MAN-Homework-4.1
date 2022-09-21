namespace Задание_4._1

{
    internal class Program
    {
        static void Main(string[] args)
        {
            int box;
            Random rndBolt = new Random();
            Random rndBox = new Random();
            box = rndBox.Next(5, 50);
            //Console.WriteLine(box);
            int [] boxArray = new int[box];
            for (int x = 0; x < boxArray.Length; x++)
            {
                boxArray[x] = rndBolt.Next(100, 400);
                //Console.WriteLine(boxArray[x]);
            }
            int max;
            int min;
            int index;
            int index2;
            int index3;
            max = GetMax2Element(boxArray, out index);
            min = GetMin2Element(boxArray, out index2);
            mid = GetMid2Element(boxArray, out index3);

            Console.WriteLine("Max элемент: " + max + " в ящике " + index + ".");
            Console.WriteLine("Min элемент: " + min + " в ящике " + index2 + ".");
            Console.WriteLine("Mid элемент: " + mid + " в ящике " + index3 + ".");
        }
        private static int GetMax2Element(int[] boxArray, out int index)
        {
            int max = int.MinValue;
            int i = 0;
            index = 0;
            foreach (int element in boxArray)
            {
                if (element > max)
                {
                    max = element;
                    index = i;
                }
                i++;
            }
            return max;
        }
        private static int GetMin2Element(int[] boxArray, out int index2)
        {
            int min = int.MaxValue;
            int j = 0;
            index2 = 0;
            foreach (int element in boxArray)
            {
                if (element < min)
                {
                    min = element;
                    index2 = j;
                }
                j++;
            }
            return min;
        }
        private static int GetMid2Element(int[] boxArray, out int index3)
        {
            int mid = 0;
            int k = 0;
            index3 = 0;
            //for (int i = 0; i < boxArray.Length; i++)
            //{

            //}


            //foreach (int element in boxArray)
            //{
            //    if ()
            //}

            return mid;
        }
    }
}
