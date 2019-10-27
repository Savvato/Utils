using System.Text;

namespace Savvato.Utils
{
    public static class StringUtils
    {
        public static string FromSnakeCaseToCamelCase(this string sourceString)
        {
            char[] chars = sourceString.ToCharArray();
            StringBuilder outputStringBuilder = new StringBuilder();

            long index = 0;
            while (chars[index] == '_' && index < chars.Length)
            {
                outputStringBuilder.Append(value: chars[index]);
                index++;
            }

            bool shouldBeUpperCase = false;
            while (index < chars.Length)
            {
                if (chars[index] == '_')
                {
                    shouldBeUpperCase = true;
                    index++;
                    continue;
                }

                if (shouldBeUpperCase)
                {
                    outputStringBuilder.Append(value: char.ToUpper(chars[index]));
                    shouldBeUpperCase = false;
                    index++;
                    continue;
                }
                outputStringBuilder.Append(value: char.ToLower(chars[index]));
                index++;
            }

            return outputStringBuilder.ToString();
        }

        public static string FromCamelCaseToSnakeCase(this string sourceString)
        {
            char[] chars = sourceString.ToCharArray();
            StringBuilder outputStringBuilder = new StringBuilder();

            long index = 0;
            while (chars[index] == '_' && index < chars.Length)
            {
                outputStringBuilder.Append(value: chars[index]);
                index++;
            }

            while (index < chars.Length)
            {
                if (
                    chars[index] == '_'
                    &&
                    index - 1 >= 0
                    &&
                    chars[index - 1] != '_')
                {
                    outputStringBuilder.Append('_');
                    index++;
                    continue;
                }

                if (
                    char.IsUpper(chars[index]) 
                    && 
                    index - 1 >= 0 
                    && 
                    chars[index - 1] != '_')
                {
                    outputStringBuilder.Append('_');
                }
                outputStringBuilder.Append(char.ToLower(chars[index]));
                index++;
            }

            return outputStringBuilder.ToString();
        }
    }
}
