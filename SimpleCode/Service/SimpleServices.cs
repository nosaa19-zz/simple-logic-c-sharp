using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Collections.Generic;
using System.Text;

namespace simple_code.Service
{
    public class SimpleServices
    {
        public String ReverseString(string str)
        {
            char[] charArray = str.ToCharArray();
            for (int i = 0, j = str.Length - 1; i < j; i++, j--)
            {
                charArray[i] = str[j];
                charArray[j] = str[i];
            }
            string reversedstring = new string(charArray);
            return reversedstring;
        }

        public String CheckPalindrome(string str)
        {
            bool flag = false;
            for (int i = 0, j = str.Length - 1; i < str.Length / 2; i++, j--)
            {
                if (str[i] != str[j])
                {
                    flag = false;
                    break;
                }
                else
                    flag = true;
            }
            if (flag)
            {
                return "Palindrome";
            }
            else
                return "Not Palindrome";
        }

        public String ReverseWordOrder(string str)
        {
            int i;
            StringBuilder reverseSentence = new StringBuilder();

            int Start = str.Length - 1;
            int End = str.Length - 1;

            while (Start > 0)
            {
                if (str[Start] == ' ')
                {
                    i = Start + 1;
                    while (i <= End)
                    {
                        reverseSentence.Append(str[i]);
                        i++;
                    }
                    reverseSentence.Append(' ');
                    End = Start - 1;
                }
                Start--;
            }

            for (i = 0; i <= End; i++)
            {
                reverseSentence.Append(str[i]);
            }

            return reverseSentence.ToString();
        }

        public String FindSecondLargeInArray(string str)
        {
            int[] nums = Array.ConvertAll(str.Split(' '), int.Parse);

            int max1 = int.MinValue;
            int max2 = int.MinValue;

            foreach (int i in nums)
            {
                if (i > max1)
                {
                    max2 = max1;
                    max1 = i;
                }
                else if (i >= max2 && i != max1)
                {
                    max2 = i;
                }
            }
            return max2.ToString();
        }

        public String ReverseWords(string str)
        {
            StringBuilder output = new StringBuilder();
            List<char> charlist = new List<char>();

            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] == ' ' || i == str.Length - 1)
                {
                    if (i == str.Length - 1)
                        charlist.Add(str[i]);
                    for (int j = charlist.Count - 1; j >= 0; j--)
                        output.Append(charlist[j]);

                    output.Append(' ');
                    charlist = new List<char>();
                }
                else
                    charlist.Add(str[i]);
            }
            return output.ToString();
        }

        public String CountCharacter(string str)
        {
            Dictionary<char, int> characterCount = new Dictionary<char, int>();

            foreach (var character in str)
            {
                if (character != ' ')
                {
                    if (!characterCount.ContainsKey(character))
                    {
                        characterCount.Add(character, 1);
                    }
                    else
                    {
                        characterCount[character]++;
                    }
                }
            }
            Console.WriteLine("----------------------------------------");
            foreach (var character in characterCount)
            {
                Console.WriteLine("{0} - {1}", character.Key, character.Value);
            }
            return "----------------------------------------";
        }

        public String RemoveDuplicate(string str)
        {
            string result = string.Empty;

            for (int i = 0; i < str.Length; i++)
            {
                if (!result.Contains(str[i]))
                {
                    result += str[i];
                }
            }
            return result;
        }

        public String FindAllSubstring(string str)
        {
            String result = String.Empty;

            for (int i = 0; i < str.Length; ++i)
            {
                StringBuilder subString = new StringBuilder(str.Length - i);
                for (int j = i; j < str.Length; ++j)
                {
                    subString.Append(str[j]);
                    result = result+subString + " ";
                }
            }

            return result;
        }

        public String RotateLeft(string str)
        {
            int[] nums = Array.ConvertAll(str.Split(' '), int.Parse);
            String result = String.Empty;

            int size = nums.Length;
            int temp;
            for (int j = size - 1; j > 0; j--)
            {
                temp = nums[size - 1];
                nums[nums.Length - 1] = nums[j - 1];
                nums[j - 1] = temp;
            }

            foreach (int num in nums)
            {
                result = result+num + " ";
            }

            return result;
        }

        public String RotateRight(String str)
        {
            int[] nums = Array.ConvertAll(str.Split(' '), int.Parse);
            String result = String.Empty;

            int size = nums.Length;
            int temp;
            for (int j = 0; j < size - 1; j++)
            {
                temp = nums[0];
                nums[0] = nums[j + 1];
                nums[j + 1] = temp;
            }
            foreach (int num in nums)
            {
                result = result + num + " ";
            }

            return result;
        }

        public String FindPrime(String str)
        {
            int number = ParseInt(str);

            if (number == 1) return "Not Prime";
            if (number == 2) return "Prime";
            if (number % 2 == 0) return "Not Prime";

            var squareRoot = (int)Math.Floor(Math.Sqrt(number));

            for (int i = 3; i <= squareRoot; i += 2)
            {
                if (number % i == 0) return "Not Prime";
            }

            return "Prime";
        }

        /* Private Method Area */

        private int ParseInt(string value, int defaultIntValue = 0)
        {
            int parsedInt;
            if (int.TryParse(value, out parsedInt))
            {
                return parsedInt;
            }
            return defaultIntValue;
        }
    }
}
