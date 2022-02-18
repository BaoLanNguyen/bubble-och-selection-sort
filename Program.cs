using System;
namespace bubbleselectionsort
{
    class Program
    {
        static void swap(ref int a, ref int b)
        {
            int temp = a;
            a = b;
            b= temp;
        }

        static void bubblesort(ref int[] a){
        for (int i = 0; i < a.Length - 1; i++)
            {
                for (int j = 0; j < a.Length - i - 1; j++)
                {
                    if (a[j] > a[j+1])
                    {
                        swap(ref a[j], ref a[j+1]);
                    }
                }
            }
}
        static void selectionsort(ref int[] a){
            for (int i = 0; i < a.Length - 1; i++)
        {
            int min_idx = i;
            for (int j = i + 1; j < a.Length; j++)
                if (a[j] < a[min_idx])
                    min_idx = j;
            int temp = a[min_idx];
            a[min_idx] = a[i];
            a[i] = temp;
        }
        }
          static void Main(string[] args)
        {

            int[] arr = new int[8000];
            Random slump = new Random();
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = slump.Next();
            }
            long startTime = DateTimeOffset.UtcNow.ToUnixTimeMilliseconds();
            selectionsort(ref arr);
            long stopTime = DateTimeOffset.UtcNow.ToUnixTimeMilliseconds();
            long elapsedTime = stopTime - startTime;
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(arr[i]);
            }
            Console.WriteLine(elapsedTime);
        }
    }
}

