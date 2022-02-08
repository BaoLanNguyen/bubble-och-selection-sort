using System;
namespace sort
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
        static void selectionsort(ref int[] a, ref int n){

        }
        static void Main(string[] args)
        {

            int[] arr = {2000, 1000, 8000, 4000};
            long startTime = DateTimeOffset.UtcNow.ToUnixTimeMilliseconds();
            bubblesort(ref arr);
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

