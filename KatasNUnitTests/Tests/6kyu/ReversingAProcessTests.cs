using System;
using System.Collections.Generic;
using System.Text;
using Katas.Katas._6kyu.ReversingAProcess;
using NUnit.Framework;

namespace Katas.Tests._6kyu
{
    [TestFixture]
    public class ReversingAProcessTests
    {
        public static void testing_decode(string r, string expected)
        {   
            //String actual = reversingaprocess.DictionaryAlphaBetIndexGenerator()[]
            //Assert.AreEqual(expected,actual);
        }

        public static void testing_encode(string enteredstring,int cipher,string expectedstring)
        {
            string actualstring = reversingaprocess.Encode(enteredstring, cipher);
            Assert.AreEqual(expectedstring,actualstring);
        }
        public static void testing_alphabetdictionary(char letter,int expectednumber)
        { 
            int actualletternumber = reversingaprocess.DictionaryAlphaBetIndexGenerator()[letter];
            Assert.AreEqual(expectednumber,actualletternumber);
        }
        [Test]
        public static void decode_test()
        {
            testing_decode("1273409kuqhkoynvvknsdwljantzkpnmfgf", "uogbucwnddunktsjfanzlurnyxmx");
            testing_decode("1544749cdcizljymhdmvvypyjamowl", "mfmwhbpoudfujjozopaugcb");
            testing_decode("105860ymmgegeeiwaigsqkcaeguicc", "Impossible to decode");
        }
        [Test]
        public static void dictionaryfulltest()
        {
            testing_alphabetdictionary('a',0);
            testing_alphabetdictionary('z', 25);
            testing_alphabetdictionary('b', 1);
        }

        [Test]
        public static void encode_test()
        {
            testing_encode("uogbucwnddunktsjfanzlurnyxmx", 1273409, "1273409kuqhkoynvvknsdwljantzkpnmfgf");
            testing_encode("mfmwhbpoudfujjozopaugcb", 1544749, "1544749cdcizljymhdmvvypyjamowl");
            testing_encode("Impossible to decode", 105860, "105860ymmgegeeiwaigsqkcaeguicc");

        }
    }
    
}
