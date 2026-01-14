//sum of the array

using System ;

 public class program
{
    public static void Main()
    {
        int [] arr={2,4,6,8,10};
       int sum=0;
       for(int i = 0; i < arr.Length; i++)
        {
            sum=sum+arr[i];
        }
        Console.WriteLine(sum);
    }

}