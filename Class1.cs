namespace lab_4
{
    public static class StringExtensions
    {
        public static bool StartsWithUpperCase(this string input)
        {
            if (string.IsNullOrWhiteSpace(input)) return false;
            char firstChar = input[0];
            return char.IsUpper(firstChar);
        }
    }

}
