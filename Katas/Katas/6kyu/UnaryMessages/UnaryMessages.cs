using System;
using System.Buffers;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace Katas.Katas._6kyu.UnaryMessages
{
    public static class UnaryMessages
    {
        public static void Start()
        {
            Console.WriteLine("Enter the string");
            string stringin = Console.ReadLine();
            string stringout = Send(stringin);
            Console.WriteLine(stringout);
            Console.WriteLine(Receive(stringout));
            Console.WriteLine("Press eny key to end");
            Console.ReadLine();
        }

        public static string Send(string text)
        {
            byte[] binary = Encoding.ASCII.GetBytes(text);
            string stringout = "";
            string binarystring = "";

            for (int i = 0; i < binary.Length; i++)
            {
                binarystring += ConvertCharToBinaryCode(binary[i]);
            }
            stringout = ConvertBinaryCodeToUnaryCode(binarystring);
            return stringout;
        }

        public static string Receive(string text)
        {
            string stringdec =ConvertUnaryCodeToBinary(text);
            string stringout = BinaryToString(stringdec);
            return stringout;
        }

        public static string ConvertCharToBinaryCode(byte stringin)
        {
            string binaryoutput = Convert.ToString(stringin, 2).PadLeft(7, '0');
            return binaryoutput;
        }

        public static string ConvertBinaryCodeToUnaryCode(string stringin)
        {
            bool discharge = true;
            char buffer = ' ';
            string stringout = "";
            for (int i = 0; i < stringin.Length; i++)
            {
                if (discharge == true)
                {
                    if (stringin[i] == '1')
                    {
                        buffer = '1';
                        stringout += "0 0";
                        discharge = false;
                    }
                    else
                    {
                        buffer = '0';
                        stringout += "00 0";
                        discharge = false;
                    }
                }
                else
                {
                    if (buffer == stringin[i])
                    {
                        stringout += "0";
                    }
                    else
                    {
                        discharge = true;
                        i--;
                        stringout += " ";
                    }
                }
            }
            return stringout;
        }

        public static string ConvertUnaryCodeToBinary(string stringin)
        {
            bool discharge = true;
            char buffer = ' ';
            string stringout = "";
            for (int i = 0; i < stringin.Length-1; i++)
            {
                if (discharge == true)
                {
                    if (stringin[i+1] == ' ')
                    {
                        buffer = '1';
                        discharge = false;
                        i++;
                    }
                    else
                    {
                        buffer = '0';
                        discharge = false;
                        i++;
                        i++;
                    }
                }
                else
                {
                    if (stringin[i+1]==' ')
                    {
                        stringout += buffer;
                        discharge = true;
                        i++;
                        
                    }
                    else
                    {
                        stringout += buffer;
                    }
                }
            }
            stringout += buffer;
            return stringout;
        }

        public static string BinaryToString(string stringin)
        {
            List<byte> listbyte = new List<byte>();
            for (int i = 0; i < stringin.Length; i+=7)
            {
                listbyte.Add(Convert.ToByte(stringin.Substring(i,7),2));
            }

            return Encoding.ASCII.GetString(listbyte.ToArray());
        }
    }
}
