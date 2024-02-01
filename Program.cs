namespace Two_Sum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string WelcomeMessage = "Welcome to TwoSum App***";
            Console.WriteLine(WelcomeMessage);
            var res = TwoSum.CalcTwoSum();
            Console.WriteLine(res);
        }
    }
}
