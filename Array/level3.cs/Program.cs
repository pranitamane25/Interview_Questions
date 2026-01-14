using System;
class program
{
    public static void Main()
    {
        int []arr={10,12,4,20,78};
        int max=arr[0];
        for(int i = 1; i < arr.Length; i++)
        {
        if  (arr[i] >max)
        {
        max=arr[i];
    }
 }
    Console.WriteLine("Largest element"+max);
    }
}
