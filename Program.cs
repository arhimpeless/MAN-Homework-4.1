namespace Задание_4._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                int box;
                Random rndBolt = new Random();  //только один раз
                box = rndBolt.Next(5, 21);
                Console.WriteLine(box);
                int[] boxArray = new int[box];
                for (int x = 0; x < boxArray.Length; x++)
                {
                    boxArray[x] = rndBolt.Next(100, 401);
                    Console.WriteLine(boxArray[x]);
                }
                double max;
                double min;
                double middle;
                int index;
                int index2;
                int middleBox;
                max = GetMax2Element(boxArray, out index);
                min = GetMin2Element(boxArray, out index2);
                middleBox = GetMid2Element(boxArray);
                Console.WriteLine("Max элемент: " + max + " в ящике " + (index + 1) + ".");
                Console.WriteLine("Min элемент: " + min + " в ящике " + (index2 + 1) + ".");
                Console.WriteLine("Mid элемент: " + boxArray[middleBox] + " в ящике " + (middleBox + 1) + ".");
                Console.WriteLine("\n");
                Console.ReadKey();
            }
        }
        private static int GetMax2Element(int[] boxArray, out int index)
        {
            double max = double.MinValue;
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
            return index;
        }
        private static int GetMin2Element(int[] boxArray, out int index2)
        {
            double min = int.MaxValue;
            int j = 0;
            index2 = 0;
            foreach (double element in boxArray)
            {
                if (element < min)
                {
                    min = element;
                    index2 = j;
                }
                j++;
            }
            return index2;
        }
        private static int GetMid2Element(int[] boxArray)
        {
            double middle = 0;
            int summBolt = 0;
            foreach (int element in boxArray)
            {
                summBolt += element;
            }
            middle = Convert.ToDouble(summBolt) / boxArray.Length;
            double difference;
            double minDifference = middle;
            int middleBox = 0;
            for (int element = 0; element < boxArray.Length; element++)
            {
                difference = Math.Abs(middle - element);
                if (difference < minDifference)
                {
                    minDifference = difference;
                    middleBox = element; 
                }
            }
            //Console.WriteLine(middleBox);
            return middleBox;
        }
    }
}
