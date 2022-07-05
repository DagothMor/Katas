using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using Katas.Katas._3kyu;
using Katas.Katas._5kyu;
using Katas.Katas._6kyu.BallUpwards;
using Katas.Katas._6kyu.ConsonantValues;
using Katas.Katas._6kyu.IsPangram;
using Katas.Katas._6kyu.UnaryMessages;

namespace Katas
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter any key to start");
            //Console.ReadLine();
            BallUpwards.Start(15);
            Console.WriteLine("Enter any key to start");
            Console.ReadLine();
        }
        public static string ReverseWords(string str)
        {
            List<string> list = str.Split(' ').Reverse().ToList();
            string stringout = "";
            foreach (string word in list) { stringout += word + " "; }
            return stringout;
        }
        public static int TwiceAsOld(int dadYears, int sonYears)
        {
            int answer = 0;
            while (sonYears * 2 != dadYears)
            {
                dadYears++;
                sonYears++;
                answer++;
            }
            return answer;
        }
        public static bool IsDigit(string s)
        {
            return !s.Contains("- .1234567890") ? true : false;
        }
        public static int SumMul(int n, int m)
        {
            if (n == 0 && n > m) throw new ArgumentException();
            int answer = n;
            for (int i = n; answer < m; i += n)
            {
                answer += i;
            }
            return answer;
        }
        public static string Greet(string language)
        {
            Dictionary<string, string> dictionary = new Dictionary<string, string>()
            {
                {"english", "Welcome"},
                {"czech", "Vitejte"},
                {"danish", "Velkomst"},
                {"dutch", "Welkom"},
                {"estonian", "Tere tulemast"},
                {"finnish", "Tervetuloa"},
                {"flemish", "Welgekomen"},
                {"french", "Bienvenue"},
                {"german", "Willkommen"},
                {"irish", "Failte"},
                {"italian", "Benvenuto"},
                {"latvian", "Gaidits"},
                {"lithuanian", "Laukiamas"},
                {"polish", "Witamy"},
                {"spanish", "Bienvenido"},
                {"swedish", "Valkommen"},
                {"welsh", "Croeso"},
                {"IP_ADDRESS_INVALID", "Welcome"},
                {"IP_ADDRESS_NOT_FOUND", "Welcome"},
                {"IP_ADDRESS_NOT_FOUND", "Welcome"}
            };
            
            return dictionary.ContainsKey(language)?dictionary[language]:"Welcome";
        }
        public static int[] SortedArray(int[] array)
        {
            int buffer;
            for (int i = 0; i < array.Length-1; i++)
            {
                if (array[i]>array[i+1])
                {
                    buffer = array[i + 1];
                    array[i + 1] = array[i];
                    array[i] = buffer;
                    if (i <= 2)
                    {
                        i = 0;}
                    else { i -= 2; }
                }
            }
            return array;

        }
        public static int[] WaveSort(int[] arr)
        {
            Array.Sort(arr);
            int buffer;
            for (int i = 0; i < arr.Length - 1; i += 2)
            {
                buffer = arr[i + 1];
                arr[i + 1] = arr[i];
                arr[i] = buffer;
            }

            return arr;
        }
        public static void DisplayArray(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write($"|{array[i]}|");
            }
            Console.WriteLine("_");
        }
        public static int[] RandomGeneratedArray(int Count,int EndRange)
        {
            Random random = new Random();
            List<int> list = new List<int>();
            for (int i = 0; i < Count; i++)
            {
                list.Add(random.Next(EndRange));
            }
            return list.ToArray();
        }
        public static IEnumerable<T> UniqueInOrder<T>(IEnumerable<T> iterable)
        {
            List<T> list = new List<T>();
            int i = 0;
            foreach (T VARIABLE in iterable)
            {
                if (list.Count>1)
                {
                    if (list[i-1].Equals(VARIABLE))
                    {
                        list.Add(VARIABLE);
                        i++;
                    }
                }
            }

            return list;
        }

        public string hydrate(string drinkString)
        {
            int Count = 0;
            for (int i = 0; i < drinkString.Length; i++)
            {
                if (char.IsDigit(drinkString[i]))
                {
                    Count += Convert.ToInt32(drinkString[i]);
                }
            }
            return $"{Count} glasses of water";
        }
        public int ToBinary(int DecimalNumber)
        {
            int temp1 = 0;
            List<int> listout = new List<int>();
            while (DecimalNumber > 0)
            {
                temp1 = DecimalNumber % 2;
                DecimalNumber /= 2;
                listout.Add(temp1);
            }
            listout.Reverse();
            string stringout = "";
            for (int i = 0; i < listout.Count; i++)
            {
                stringout += listout[i];
            }
            return Convert.ToInt32(stringout);
        }
        public static IEnumerable<string> GooseFilter(IEnumerable<string> birds)
        {
                List<string> stringsout = new List<string>();
                string[] geese = new string[] { "African", "Roman Tufted", "Toulouse", "Pilgrim", "Steinbacher" };
                foreach (var VARIABLE in geese)
                {
                    if (!geese.Contains(VARIABLE)) { stringsout.Add(VARIABLE); }
                }
                return stringsout;
        }
        public static int[] CountBy(int x, int n)
        {
            int[] z = new int[n];
            for (int i = 0; i < n; i++)
            {
                z[i] = x;
                x += x;
            }
            return z;
        }
        public static (int, int)[] TwosDifference(int[] array)
        {
            List<(int, int)> listout = new List<(int, int)>();
            array = array.OrderBy(x => x).ToArray();
            int end = array.Length - 1;
            for (int i = 0; i < end; i++)
            {
                for (int j = i; j < end; j++)
                {
                    if (array[j + 1] - array[i] == 2)
                    {
                        listout.Add((array[i],array[j+1]));
                    }
                }
            }
            return listout.ToArray();
        }
        public static (int, int)[] TwosDifference2(int[] array)
        {
            List<(int, int)> listout = new List<(int, int)>();
            int end = array.Length - 1;
            for (int i = 0; i < end; i++)
            {
                for (int j = i; j < end; j++)
                {
                    if (array[j + 1] - array[j] == 2)
                    {
                        listout.Add((array[j], array[j + 1]));
                    }
                }
                if (array[^0] - array[i] == 2)
                {
                    listout.Add((array[i], array[^0]));
                }
            }
            if (array[^0] - array[^1] == 2)
            {
                listout.Add((array[^1], array[^0]));
            }
            return listout.ToArray();
        }
        public static int Digits(ulong n)
        {
            string stringofdigits = "";
            string s = n.ToString();
            for (int i = 0; i < s.Length; i++)
            {
                if (char.IsDigit(s[i]))
                {

                    stringofdigits += s[i];
                }
            }
            return stringofdigits.Length;
        }
        public string dnaToRna(string dna)
        {
            string stringout = "";
            foreach (var VARIABLE in dna)
            {
                if (VARIABLE == 'T')
                {
                    stringout += 'U';
                }
                else
                {
                    stringout += VARIABLE;
                }
            }

            return stringout;
        }
        public static int[] InvertValues(int[] input)
        {
            List<int> listout = new List<int>();
            foreach (var VARIABLE in input)
            {
                listout.Add(VARIABLE*-1);
            }
            return input;
        }
        public static class MonkeyCounter
        {
            public static void palevo(int[] monkeys)
            {
                for (int i = 0; i < monkeys.Length; i++)
                {
                    Console.WriteLine($"{i+1} Порядковый номер равен {monkeys[i]}");
                }
            }
            public static int[] korney(int n)
            {
                List<int> list = new List<int>();
                for (int i = 0; i < n; i++)
                {
                    list.Add(i + 1);


                }

                return list.ToArray();
            }

            public static int[] check(int[] massive)
            {
                for (int i = 1; i < massive.Length; i++)
                {
                    if (i % 2 == 0)
                    {
                        massive[i] = massive[i] * 2;
                    }
                }

                return massive;
            }
        }
        public static string Interpret(string code)
        {
            string BottlesOfBeer = "";
            for (int i = 99; i > 1; i--)
            {
                BottlesOfBeer += $"{i} bottles of beer on the wall, {i} bottles of beer.\nTake one down and pass it around, {i - 1} bottles of beer on the wall.";
            }
            BottlesOfBeer += "1 bottle of beer on the wall, 1 bottle of beer.\nTake one down and pass it around, no more bottles of beer on the wall.\nNo more bottles of beer on the wall, no more bottles of beer.\nGo to the store and buy some more, 99 bottles of beer on the wall.";
            switch (code)
            {
                case "H": { return "Hello World!"; }
                case "Q": { return code; }
                case "9": { return BottlesOfBeer; }
                default: return null;
            }
        }
        public static int[] CountPositivesSumNegatives(int[] input)
        {
            if (input == null && input.Length == 0) { return input; }
            int CountOfPositive = 0;
            int SumOfNegative = 0;
            if (input.Length > 0)
            {
                for (int i = 0; i < input.Length; i++)
                {
                    if (input[i] > 0)
                    {
                        CountOfPositive++;
                    }
                    if (input[i] < 0)
                    {
                        SumOfNegative += input[i];
                    }
                }
            }

            return new int[2] { CountOfPositive, SumOfNegative }; //return an array with count of positives and sum of negatives
        }
        public static double GuessBlue(uint blueStart, uint redStart, uint bluePulled, uint redPulled)
        {
            uint blue = blueStart - bluePulled;
            uint red = redStart - redPulled;
            double answer = (double)Math.Round((decimal)((blue + red) / blue), 2);
            return answer;
        }
        public static string Pattern(int n)
        {
            if (n < 1) { return ""; }
            string stringout = "";
            List<int> list = new List<int>();
            for (int i = n; i > 0; i--)
            {
                list.Add(i);
            }

            while (list.Count != 1)
            {
                for (int i = 0; i < list.Count; i++)
                {
                    stringout += list[i].ToString();
                }
                stringout += "\n";
                list.RemoveAt(list.Count - 1);
            }

            stringout += n.ToString();
            return stringout;
        }
        public static double Arithmetic(double a, double b, string op)
        {
            switch (op)
            {
                case "add": return (double)(a + b);
                case "subtract": return (double)(a - b);
                case "multiply": return (double)(a * b);
                default: return (double)(a / b);
            }
        }
        public static bool comp(int[] a, int[] b)
        {
            Dictionary<int, int> dictionary = new Dictionary<int, int>();
            for (int i = 0; i < b.Length; i++)
            {
                dictionary.Add(i, 0);
            }
            bool flag = false;
            //int[] check = new int[]{};
            if (a == null || b == null) { return false; }
            //if(a==check||b==check){return false;}
            for (int i = 0; i < a.Length; i++)
            {
                flag = false;
                var asquare = a[i] * a[i];
                for (int j = 0; j < b.Length; j++)
                {
                    if (asquare == b[j])
                    {
                        dictionary[b[i]]++;
                    }
                }
                if (flag == false) { return false; }
            }

            foreach (KeyValuePair<int, int> kvp in dictionary)
            {
                if (kvp.Value == 0)
                {
                    return false;
                }
            }
            return true;
        }
        public static int Potatoes(int p0, int w0, int p1)
        {
            double weightofpotatoes = w0;
            double percentofwaterbefore = p0;
            double percentofwaterafter = p1;
            double weightwaterbefore = (weightofpotatoes * percentofwaterbefore) / 100;
            double weightdrymatter = (weightofpotatoes - weightwaterbefore);
            double weightwaterafter = (((percentofwaterafter * (weightdrymatter)) / (100 - percentofwaterafter)));

            return (int)(weightwaterafter + weightdrymatter);
        }
        public static int HighestRank(int[] arr)
        {
            Dictionary<int, int> dictionary = new Dictionary<int, int>();
            List<int> list = new List<int>();
            int key = 0;
            int val = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (dictionary.ContainsKey(arr[i]))
                {
                    dictionary[arr[i]]++;
                }
                else { dictionary.Add(arr[i], 1); }
            }

            foreach (KeyValuePair<int, int> kvp in dictionary)
            {
                if (kvp.Value >= val)
                {
                    val = kvp.Value;

                    list.Add(kvp.Key);
                }
            }

            return list.Max();
        }
        public static long SuperSize(long num)
        {
            List<int> list = num.ToString().ToCharArray().Select(x => int.Parse(x.ToString())).ToList().OrderByDescending(x => x).ToList();
            string stringout = "";
            for (int i = 0; i < list.Count; i++)
            {
                stringout += list[i];
            }
            return Int64.Parse(stringout);
        }
        public static bool IsPalindrome(object line)
        {
            List<char> list = line.ToString().ToCharArray().Reverse().ToList();
            List<char> stringin = line.ToString().ToCharArray().ToList();
            for (int i = 0; i < list.Count; i++)
            {
                if (stringin[i] != stringin[i])
                {
                    return false;
                }
            }
            return false;
        }
        public static bool IsUpperCase(string text)
        {
            string lowercases = "abcdefghijklmnopqrstuvwxyz";
            for (int i = 0; i < text.Length; i++)
            {
                if (lowercases.Equals(text[i])) { return false; }
            }
            return true;
        }
        public static int NoBoringZeros1(int n)
        {
            List<int> list = n.ToString().ToCharArray().ToList().Select(x => int.Parse(x.ToString())).ToList();
            bool flag = false;
            while (flag == false)
            {
                if (list.Last() == 0)
                {
                    list.RemoveAt(list.Last());
                }
                else
                {
                    flag = true;
                }
            }
            string stringin = "";
            for (int i = 0; i < list.Count; i++)
            {
                //stringin += char.Parse(list[i]);

            }
            return Convert.ToInt32(stringin);
        }
        public static int NoBoringZeros2(int n)
        {
            int number = n;
            List<char> listc = new List<char>();
            List<int> list = n.ToString().ToCharArray().Reverse().ToList().Select(x => int.Parse(x.ToString())).ToList();
            for (int i = 0; i < list.Count; i++)
            {
                if (list[i] == 0)
                {
                    list.Remove(i);
                    i--;
                }
                else
                {
                    break;
                }
            }

            List<int> listout = list.ToArray().Reverse().ToList();
            string stringout = "";
            for (int i = 0; i < list.Count; i++)
            {
                stringout += listout[i].ToString();
            }
            return Convert.ToInt32(stringout);
        }
        public static int NoBoringZeros(int n)
        {
            while (n % 10 == 0)
            {
                n /= 10;
            }
            return n;
        }
        public static char AddLetters(char[] letters)
        {
            if (letters.Length < 1)
            {
                return 'z';
            }

            string alphabet = "abcdefghijklmnopqrstuvwxyz";
            Dictionary<char, int> dictionary = new Dictionary<char, int>();
            Dictionary<int, char> reverseDictionary = new Dictionary<int, char>();
            int sum = 0;
            for (int i = 0; i < alphabet.Length; i++)
            {
                dictionary.Add(alphabet[i], i + 1);
                reverseDictionary.Add(i + 1, alphabet[i]);
            }
            for (int i = 0; i < letters.Length; i++)
            {
                sum += dictionary[letters[i]];
            }
            while (sum > 26)
            {
                sum -= 26;
            }
            return reverseDictionary[sum];
        }

        public static string ToAlternatingCase(string s)
        {
            string LowerAlphabet = "abcdefghijklmnopqrstuvwxyz";
            string UpAlphabet = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            Dictionary<char, char> DictionaryToUp = new Dictionary<char, char>();
            Dictionary<char, char> DictionaryToLower = new Dictionary<char, char>();
            for (int i = 0; i < 26; i++)
            {
                DictionaryToUp.Add(LowerAlphabet[i], UpAlphabet[i]);
                DictionaryToLower.Add(UpAlphabet[i], LowerAlphabet[i]);
            }
            string stringout = "";
            for (int i = 0; i < s.Length; i++)
            {
                if (LowerAlphabet.Contains(s[i]))
                {
                    stringout += DictionaryToUp[s[i]];
                }
                if (UpAlphabet.Contains(s[i]))
                {
                    stringout += DictionaryToLower[s[i]];
                }
                stringout += s[i];
            }

            return stringout;
        }
        public static bool IsLockNessMonster(string sentence)
        {
            List<string> list = new List<string>();
            foreach (string word in list)
            {
                if (sentence.Contains(word))
                {
                    return true;
                }
            }
            return false;
        }
        public static string Shark(
            int pontoonDistance,
            int sharkDistance,
            int yourSpeed,
            int sharkSpeed,
            bool dolphin)
        {
            if (dolphin) { sharkSpeed /= 2; }
            float MyTime = (float)(pontoonDistance / yourSpeed);
            float SharkTime = (float)((sharkDistance + pontoonDistance) / sharkSpeed);
            if (MyTime <= SharkTime) { return "Alive!"; }
            return "Shark Bait!";
        }

        public static List<int> ShiftSerialNumbers(int[] arr)
        {
            List<int> list = arr.ToList();
            List<int> listout = new List<int>();
            int Count = arr.Length;
            if (Count % 2 == 0)
            {
                for (int i = 0; i < Count - 1; i++)
                {
                    listout.Add(list[i + 1]);
                    listout.Add(list[i]);
                    i++;
                }
            }
            else
            {
                for (int i = 0; i < Count - 2; i++)
                {
                    listout.Add(list[i + 1]);
                    listout.Add(list[i]);
                    i++;
                }
                listout.Add(list[list.Count]);
            }


            return list;
        }
        public static int Factorial(int numb)
        {
            int res = 1;
            for (int i = numb; i > 1; i--)
                res *= i;
            return res;
        }
        public static string Correct(string text)
        {
            string stringout = "";
            for (int i = 0; i < text.Length; i++)
            {
                if (text[i] == '5') { stringout += "S"; }
                else if (text[i] == '0') { stringout += "O"; }
                else if (text[i] == '1') { stringout += "I"; }
                else { stringout += text[i]; }
            }
            return stringout;
        }
        public static int SumOfMinimums(int[,] numbers)
        {
            int rows = numbers.GetUpperBound(0) + 1;
            int columns = numbers.GetUpperBound(1) + 1;
            int sum = 0;
            int buffer = 0;
            for (int i = 0; i < rows; i++)
            {
                buffer = numbers[i, 0];
                for (int j = 1; j < columns; j++)
                {
                    if (numbers[i, j] < buffer)
                    {
                        buffer = numbers[i, j];
                    }
                }
                sum += buffer;
            }
            return sum;
        }
        public static bool Solution(string str, string ending)
        {
            string end = stringreverse(ending);
            string stringin = stringreverse(str);
            int Lengthword = stringin.Length;
            for (int i = 0; i < end.Length; i++)
            {
                if (i < Lengthword)
                {
                    if (end[i] != stringin[i])
                    {
                        return false;
                    }
                }
            }
            return true;
        }
        public static string stringreverse(string stringin)
        {
            List<char> listin = stringin.ToCharArray().Reverse().ToList();
            string stringout = "";
            for (int i = 0; i < listin.Count; i++)
            {
                stringout += listin[i].ToString();
            }

            return stringout;
        }
        public static string SortGiftCode(string code)
        {
            string alphabet = "abcdefghijklmnopqrstuvwxyz";
            List<char> listin = code.ToCharArray().ToList();
            List<char> list = new List<char>();
            while (listin.Count>1)
            {
                for (int i = 0; i < alphabet.Length; i++)
                {
                    if (StringContainsLetter(ref listin, alphabet[i]))
                    {
                        list.Add(alphabet[i]);
                        i--;
                    }
                }
            }
            

            string stringout = "";
            for (int i = 0; i < list.Count; i++)
            {
                stringout += list[i];
            }

            return stringout;
        }
        public static bool StringContainsLetter(ref List<char> word, char letter)
        {
            for (int i = 0; i < word.Count; i++)
            {
                if (word[i] == letter)
                {
                    word.RemoveAt(i);
                    return true;
                }
            }
            return false;

        }
        public static string DuplicateEncode(string word)
        {
            Dictionary<char, int> dictionary = new Dictionary<char, int>();
            foreach (var letter in word)
            {
                if (dictionary.ContainsKey(letter))
                {
                    dictionary[letter]++;
                }
                else
                {
                    dictionary.Add(letter,1);
                }
            }

            string stringout = "";
            foreach (var VARIABLE in word)
            {
                if (dictionary[VARIABLE] >= 2)
                {
                    stringout += ")";
                }
                else
                {
                    stringout += "(";
                }
            }
            return stringout;
        }
        public static long rowSumOddNumbers(long n)
        {
            long Answer = 1;
            int CountNumbersInRow = 1;
            long CurrentNumber = 1;
            for (int i = 1; i <n; i++)
            {
                for (int j = 1; j < n; j++)
                {
                    Answer += 2;
                }
                CountNumbersInRow++;
            }
            for (int i = 0; i < n; i++)
            {
                Answer += Answer+2;
            }
            return Answer;
        }
    }

}
