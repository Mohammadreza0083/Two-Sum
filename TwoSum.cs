
namespace Two_Sum
{
    public static class TwoSum
    {
        public static int[]? CalcTwoSum() {
            int[] ints = InputArray.GetInputArray();
            Console.WriteLine("Enter Your Target Num : ");
            int TargetNum = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < ints.Length; i++)
            {
                for(int j = i+1; j < ints.Length; j++)
                {
                    int helper = 0;
                    helper = ints[i] + ints[j];
                    if (helper == TargetNum)
                        return [i, j];
                }
            }
            return null; 
        }
    }
}
