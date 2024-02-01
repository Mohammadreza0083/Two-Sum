
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
                for (int j = 0; j < ints.Length-1; j++)
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
