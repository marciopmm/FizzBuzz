using System.Text;

namespace FizzBuzz
{
    public class FizzBuzzTool
    {
        private StringBuilder _textBuilder = new StringBuilder();

        public string LoopSolution()
        {
            var result = new StringBuilder();
            for(int i = 100; i >= 1; i--) 
            {
                if (i % 15 == 0)
                    result.AppendLine("FizzBuzz");
                else if (i % 3 == 0)
                    result.AppendLine("Fizz");
                else if (i % 5 == 0)
                    result.AppendLine("Buzz");
                else
                    result.AppendLine(i.ToString());
            }

            return result.ToString();
        }

        public string RecursiveSolution(int n)
        {
            string result = "";

            if (n < 1)
                return _textBuilder.ToString();

            if (n % 15 == 0)
                result = "FizzBuzz";
            else if (n % 3 == 0)
                result = "Fizz";
            else if (n % 5 == 0)
                result = "Buzz";
            else
                result = n.ToString();

            _textBuilder.AppendLine(result);
            return RecursiveSolution(n - 1);
        }
    }
}