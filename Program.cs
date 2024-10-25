namespace methods_params
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Sum(7);

            int sumOf = Sum1(5);

            Console.WriteLine(sumOf);

            Print("   Code   Academy     ");

            string name = "  Code  Academy   ";
            string cleanedName = CleanString(name);
            Console.WriteLine(cleanedName);

        }

        static void Sum(int num)
        {
            int sum = 0;
            for (int i = 0; i < num; i++)
            {

                if (i % 2 == 0)
                {

                    sum += i;
                }
            }
            Console.WriteLine(sum);
        }


        static int Sum1(int num1)
        {

            int sum = 0;
            for (int i = 0; i < num1; i++)
            {
                if (i % 2 == 0)
                {

                    sum += i;
                }

            }
            return sum;
        }


        static void Print(string word)
        {
            string word1 = "Code";
            string word2 = "Academy";
            word = string.Concat(word1, word2).Trim();
            Console.WriteLine(word);
        }
        static string CleanString(string input)
        {
            char[] result = new char[input.Length];
            int index = 0;

            foreach (char c in input)
            {
                if (!char.IsWhiteSpace(c))
                {
                    result[index++] = c;
                }
            }

            return new string(result, 0, index);
            // or return string.Join("", input.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries));
        }
    }
}
