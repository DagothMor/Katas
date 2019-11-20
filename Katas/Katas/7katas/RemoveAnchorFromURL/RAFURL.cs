using System;
using System.Collections.Generic;
using System.Text;

/// <summary>
///Complete the function/method so that it returns the url with anything after
///the anchor (#) removed.
///Examples
///Kata.RemoveUrlAnchor("www.codewars.com#about") => "www.codewars.com"
///Kata.RemoveUrlAnchor("www.codewars.com?page=1") => "www.codewars.com?page=1"
/// </summary>


namespace Katas.Katas._7katas.RemoveAnchorFromURL
{
    public static class RAFURL
    {
        public static void start()
        {
            Console.WriteLine("Введите ссылку");
            string URL = Convert.ToString(Console.ReadLine());
            string NewURL = RemoveUrlAnchor(URL);
            Console.WriteLine(NewURL);
            Console.ReadLine();

        }

        public static string RemoveUrlAnchor(string url)
        {
            char[] charurl = url.ToCharArray();

            string stringout = "";

            for (int i = 0; i < charurl.Length; i++)
            {
                if (charurl[i] != '#')
                {
                    stringout += charurl[i];
                }
                else break;
            }

            return stringout;
        }
    }
}
