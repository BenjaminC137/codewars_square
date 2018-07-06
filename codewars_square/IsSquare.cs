using System;

namespace codewars_square
{
    public class Kata
    {
        public static bool IsSquare(int n)
        {
            bool answer = false;
            for (int i = 0; i <= n; i++)
            {
                if (i * i == n)
                {
                    answer = true;
                    break;
                }
            }
            return answer;
        }
    }
}
