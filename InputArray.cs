
namespace Two_Sum
{
    internal class InputArray
    {
        public static int[] GetInputArray() {
            Console.WriteLine("Enter Your Array Lenght : ");
            int ArrayLenght = Convert.ToInt32(Console.ReadLine());
            int[] ints = new int[ArrayLenght];
            for (int i = 0; i < ints.Length; i++)
            {
                int InputNums = Convert.ToInt32(Console.ReadLine());
                ints[i] = InputNums;
            }
            return ints;
        }
    }
}
