namespace ExtensionMethods
{
    public static class StringExtensions
    {
        /// <summary>
        /// Reverses a string.
        /// </summary>
        /// <param name="s">A string.</param>
        /// <returns>A reversed copy of the string.</returns>
        public static string Reversed(this string s)
        {
            // from https://stackoverflow.com/a/228060/12976128
            var chars = s.ToCharArray();
            Array.Reverse(chars);
            return new string(chars);
        }

        /// <summary>
        /// Checks whether a string is a palindrome. Case-insensitive, whitespace and punctuation sensitive.
        /// </summary>
        /// <param name="s">A string.</param>
        /// <returns>Whether the string is a palindrome.</returns>
        public static bool IsPalindrome(this string s)
        {
            for (var i = 0; i < s.Length; i++)
            {
                if (char.ToLower(s[i]) != char.ToLower(s[s.Length - 1 - i]))
                {
                    return false;
                }
            }
            
            return true;
        }

        private static readonly Dictionary<char, int> IndividualHebrewValues = new()
        {
            ['א'] = 1, ['ב'] = 2, ['ג'] = 3, ['ד'] = 4, ['ה'] = 5, ['ו'] = 6, ['ז'] = 7, ['ח'] = 8, ['ט'] = 9,
            ['י'] = 10, ['כ'] = 20, ['ל'] = 30, ['מ'] = 40, ['נ'] = 50, ['ס'] = 60, ['ע'] = 70, ['פ'] = 80, ['צ'] = 90,
            ['ך'] = 20, ['ם'] = 40, ['ן'] = 50, ['ף'] = 80, ['ץ'] = 90, 
            ['ק'] = 100, ['ר'] = 200, ['ש'] = 300, ['ת'] = 400
        };

        /// <summary>
        /// An extension method to calculate the gematria of a hebrew string.
        /// </summary>
        /// <param name="s">A string.</param>
        /// <returns>The gematrical value of the hebrew letters (if any) in the string.</returns>
        public static int Gematria(this string s)
        {
            var total = 0;
            foreach (var c in s)
            {
                total += IndividualHebrewValues.GetValueOrDefault(c); // default(int) == 0
            }

            return total;

            // using LINQ
            // return s.Sum(c => IndividualHebrewValues.GetValueOrDefault(c));
        }
    }
}