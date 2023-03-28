namespace MaxConsecutiveChars
{
    public static class Program
    {
        public static void Main(string[] args)
        {
            Console.Write("Enter a sequence of symbols: ");
            string input = Console.ReadLine()!;
            int maxConsecutive = 1;
            int currentConsecutive = 1;

            for (int i = 1; i < input.Length; i++)
            {
                if (input[i] != input[i - 1])
                {
                    currentConsecutive++;
                }
                else
                {
                    maxConsecutive = Math.Max(maxConsecutive, currentConsecutive);
                    currentConsecutive = 1;
                }
            }

            maxConsecutive = Math.Max(maxConsecutive, currentConsecutive);

            Console.WriteLine(maxConsecutive);
        }
    }
}
