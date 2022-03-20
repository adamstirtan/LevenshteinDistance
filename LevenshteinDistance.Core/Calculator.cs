namespace LevenshteinDistance.Core
{
    public static class Calculator
    {
        public static int Compute(string s1, string s2)
        {
            int n = s1.Length;
            int m = s1.Length;

            int[,] distances = new int[n + 1, m + 1];

            if (n == 0)
            {
                return m;
            }

            if (m == 0)
            {
                return n;
            }

            // Writes diagonal values
            for (int i = 0; i <= n; distances[i, 0] = i++)
            { }

            // Writes first row values
            for (int j = 0; j <= m; distances[0, j] = j++)
            { }

            for (int i = 1; i <= n; i++)
            {
                for (int j = 1; j <= m; j++)
                {
                    int cost = (s2[j - 1] == s1[i - 1]) ? 0 : 1;

                    distances[i, j] = Math.Min(
                        Math.Min(distances[i - 1, j] + 1, distances[i, j - 1] + 1),
                        distances[i - 1, j - 1] + cost);
                }
            }

            return distances[n, m];
        }
    }
}