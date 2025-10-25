

#region HeapStackRefOutArrayResize
class Program
{
    static void Main()
    {
        int[] numbers = { 1, 2, 3 };
        int[] numbers2 = { 3, 4, 5 };


        CustomArrResize(ref numbers, 4);
        CustomArrResize(ref numbers2, 6);


        Console.WriteLine("numbers array");
        for (int i = 0; i < numbers.Length; i++)
        {
            Console.WriteLine(numbers[i]);
        }


        Console.WriteLine("numbers2 array");
        for (int i = 0; i < numbers2.Length; i++)
        {
            Console.WriteLine(numbers2[i]);
        }
    }

    static void CustomArrResize(ref int[] numbers, int ruf)
    {

        int[] newarr = new int[numbers.Length + 1];


        for (int i = 0; i < numbers.Length; i++)
        {
            newarr[i] = numbers[i];
        }


        newarr[newarr.Length - 1] = ruf;


        numbers = newarr;
    }
} 
#endregion
