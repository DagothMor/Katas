using System;
using System.Collections.Generic;
using System.Text;
using Katas.Katas.LoveVSFriendship.Model;

namespace Katas.Katas._6kyu.ConsonantValues
{
    public static class ConsonantValues
    {
        public static void Start()
        {
            Console.WriteLine("Press any key to start");
            Console.ReadLine();
            Dictionary<char, int> dictionary = AlphabetDictionaryInitialization();
            List<char> vowels = new List<char>(){'a','e','i','o','u'};
            List<string> substrings = new List<string>();
            string buffersubstring = "";
            string inputword = "rgoaqoupeeiotaobkasaheuuijxikfksaiuagnaiumeowjuueoiwofudhsrxujauueeibaiyiuuochuukxnziooimaybayafiamoexsnuvzvuiuhaeihzhaaluuuanpmxviazzxyveenuwlwyuxopueiaeknyaimujpqneeuriuyolsaeeeuukeeyeuooriaotiioepubittqwieoxaeuwouiaonuiauleoneujiasuesdooiiiiaasxouthziiqkovuyeoworaraubeoailooeoedonoxiuudpukiyjeioauaehiuaweviabaogaziumuueekeaorqbboeietktsrzoceekaeuvoigoiveuoabunieaakajuiomfxaenwqghojwoinioqxoavgeikeuokuealfqofairouazaleliioootwlhaejoioaeooiugpooumaiuolweiouhoaarilesiuabobteoreuiivouadalkpetafceanverikpqsqiiexhkuqaoleaeeadyuwameogouutaedioimodcoenuuahufofwgnhaanoueluhtyeohoeuigfeldkiuepiaueebeeueiosxiuaiicuyitsainiaiuauaoxuiqiouobwoxiuqzlarfrbaasoumopoorquoeugqitvsioloefriuyltqctuorzaalufefrecwaxufekeeoiavbiaiugkaoaiyiaieknjaiukfexoeceearooiunocieuesiuteuoudeaickasafswiinazuuhijauiitoggzuiaovuoujggvfcuitjhogauxefiiueeamaimwoueuoiceuuizboaaaiheeiiuiwcuaocujluoc";
            for (int i = 0; i < inputword.Length; i++)
            {
                if (!vowels.Contains(inputword[i]))
                {
                    buffersubstring += inputword[i];
                }
                else
                {
                    substrings.Add(buffersubstring);
                    buffersubstring = "";
                }
            }
            substrings.Add(buffersubstring);
            buffersubstring = "";
            int sum=0;
            int buffer=0;
            for (int i = 0; i < substrings.Count; i++)
            {
                for (int j = 0; j < substrings[i].Length;j++)
                {
                    buffer += dictionary[substrings[i][j]];
                }
                if (buffer > sum)
                {
                    sum = buffer;
                    buffer = 0;
                }
            }
            if (buffer > sum) { sum = buffer; }
            Console.WriteLine(sum);
            Console.WriteLine("Press any key to end");
            Console.ReadLine();

        }

        public static int GetASCII(char c)
        {
            return (int)c;
        }
        public static Dictionary<char, int> AlphabetDictionaryInitialization()
        {
            string alphabetstring = "abcdefghijklmnopqrstuvwxyz";
            Dictionary<char, int> dictionary = new Dictionary<char, int>();
            for (int i = 0; i < alphabetstring.Length; i++)
            {
                dictionary.Add(alphabetstring[i], i + 1);
            }

            return dictionary;
        }
    }
}
