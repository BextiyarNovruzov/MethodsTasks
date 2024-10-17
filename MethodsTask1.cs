namespace methods
{
    internal class Program
    {
        static void Main(string[] args)
        { //1.Min methodu yaradılır. Daxil olunan arrayın ən kiçik elementini tapır.

            int[] array = { 13, 2, 23, 41, 5, 1, 7, 84, };
            Console.WriteLine($"Arrayin en kicik elementi: {min_element(array)}");


        }

        static int min_element(int[] arr)
        {
            if (arr.Length == 0)
                Console.WriteLine("Array boş olmamalıdır.");

            int minValue = arr[0];
            for (int i = 1; i < arr.Length; i++)
            {
                if (arr[i] < minValue)
                {
                    minValue = arr[i];
                }

            }
            return minValue;
        }
    }
}