using System;
namespace SubstitutionCipher
{
    public class Cipher
    {

        private string Alphabet = "abcdefghijklmnopqrstuvwx";
        private Char[] Substitute;

        public Cipher()
        {
            this.Substitute = GenerateSubstitute();
        }

        public Cipher(string Substitute)
        {
            this.Substitute = Substitute.ToCharArray();
        }

        private Char[] GenerateSubstitute()
        {
            Char[] Temp = Alphabet.ToCharArray();
            Random rng = new Random();
            int i = Temp.Length;
            while(i > 1)
            {
                i--;
                int r = rng.Next(i + 1);
                Char value = Temp[r];
                Temp[r] = Temp[i];
                Temp[i] = value;
            }
            Console.WriteLine(Temp);
            return Temp;
        }

        public string Encrypt(string Message)
        {
            Char[] m = Message.ToCharArray();
            string EncryptedMessage = "";

            foreach(Char c in m)
            {
                EncryptedMessage += Substitute[Array.IndexOf(Alphabet.ToCharArray(), c)];
            }
            return EncryptedMessage;
        }

        public string Decrypt(string Message)
        {
            Char[] m = Message.ToCharArray();
            string DecryptedMessage = "";

            foreach(Char c in m)
            {
                DecryptedMessage += Alphabet[Array.IndexOf(Substitute, c)];
            }
            return DecryptedMessage;
        }

    }
}
