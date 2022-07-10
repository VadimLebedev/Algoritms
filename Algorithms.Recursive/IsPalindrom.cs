namespace Algorithms.Recursive
{
    internal class IsPalindrom
    {
        public static bool Start(string s)
        {
            if (s.Length == 1)
                return true;
            
            if (Start(s[1..^1]))
                return s[0] == s[^1];

            return false;
        }
    }
}
