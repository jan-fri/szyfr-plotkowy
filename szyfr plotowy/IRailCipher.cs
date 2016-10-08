using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace szyfr_plotowy
{
    public interface IRailCipher
    {
        string Encrypt(int rail, string plainText);
        string Decrypt(int rail, string cipherText);
    }
}
