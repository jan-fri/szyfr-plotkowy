using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace szyfr_plotowy
{
    delegate string Cipher(int rail, string text);
    public static class RailCipher
    {
        public static string Encrypt(int rail, string plainText)
        {
            List<StringBuilder> cipher = new List<StringBuilder>();
            for (int i = 0; i < rail; i++)
                cipher.Add(new StringBuilder());

            int line = 0;
            int increment = 1;
            foreach (char p in plainText)
            {
                cipher[line].Append(p);

                if (line == 0)
                    increment = 1;
                else if (line == rail - 1)
                    increment = -1;

                line += increment;
            }
            StringBuilder cipherText = new StringBuilder();
            
            foreach (var c in cipher)
                cipherText.Append(c);

            return cipherText.ToString();
        }

        public static string Decrypt(int rail, string cipherText)
        {
            int cipherLength = cipherText.Length;
            List<List<int>> railFence = new List<List<int>>();
            for (int i = 0; i < rail; i++)
                railFence.Add(new List<int>());

            int line = 0;
            int increment = 1;
            for (int i = 0; i < cipherLength; i++)
            {
                railFence[line].Add(i);

                if (line == 0)
                    increment = 1;
                else if (line == rail - 1)
                    increment = -1;

                line += increment;
            }

            int counter = 0;
            char[] plainText = new char[cipherLength];
            for (int i = 0; i < rail; i++)
            {
                for (int j = 0; j < railFence[i].Count; j++)
                {
                    plainText[railFence[i][j]] = cipherText[counter];
                    counter++;
                }
            }

            return new string(plainText);
        }
    }
}
