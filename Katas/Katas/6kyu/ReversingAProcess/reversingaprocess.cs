using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace Katas.Katas._6kyu.ReversingAProcess
{
    /// <summary>
    /// 1.Create a dictinary generator[Done]
    /// 2.Create a test which checked 1 function[Done]
    /// 
    /// 
    /// </summary>
    public static class reversingaprocess
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="word"></param>
        /// <param name="encodingcipher"></param>
        /// <returns></returns>
        public static string Encode(string word,int encodingcipher)
        {
            string stringout = encodingcipher.ToString();
            Dictionary<char,int> dictionary = DictionaryAlphaBetIndexGenerator();
            Dictionary<int, char> reversedictionary = dictionary.ToDictionary(x => x.Value, x => x.Key);
            int buffer = 0;
            for (int i = 0; i < word.Length; i++)
            {
                buffer = EncodingCharThroughFunction(dictionary[word[i]], encodingcipher);
                if (buffer>25) return "Impossible to decode";
                stringout += reversedictionary[EncodingCharThroughFunction(dictionary[word[i]], encodingcipher)];
            }
            return stringout;
        }

        public static string Decode(string word)
        {

            return " ";
        }
        public static Dictionary<char, int> DictionaryAlphaBetIndexGenerator()
        {
            Dictionary<char,int> dictionary = new Dictionary<char, int>();
            string alphabet = "abcdefghijklmnopqrstuvwxyz";
            for (int i = 0; i < alphabet.Length; i++)
            {
                dictionary.Add(alphabet[i],i);
            }
            return dictionary;
        }

        public static int EncodingCharThroughFunction
            (int enteredcharacternumber, int Cipherednumber)
            => Cipherednumber * enteredcharacternumber % 26;
        
    }
    
}
