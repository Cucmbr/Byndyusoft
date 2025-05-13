namespace FuncApp;
public static class Utils
{
    public static int SumOfTwoMins(int[] arr)
    {
        int firstMin = int.MaxValue, secondMin = int.MaxValue;
        
        if (arr.Length == 0)
            return 0;
        else if (arr.Length == 1)
            return arr[0];

        foreach (int num in arr)
        {
            if (num <= firstMin)
            {
                secondMin = firstMin;
                firstMin = num;
            }    
            else if (num < secondMin)
            {
                secondMin = num;
            }
        }

        return firstMin + secondMin;
    }
}