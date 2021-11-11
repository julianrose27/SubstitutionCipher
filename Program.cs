using System;

namespace SubstitutionCipher
{
    class Program
    {
        static void Main(string[] args)
        {
            Cipher c = new Cipher();
            string Message = "hello";
            string EncryptedMessage = c.Encrypt(Message);
            Console.WriteLine($"Encrypted Message: {EncryptedMessage}");
            Console.WriteLine($"Decryped Message: {c.Decrypt(EncryptedMessage)}");
        }
    }
}
