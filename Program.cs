namespace Caesar_Cipher
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char[] alphabet = new char[] { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' };

            Console.WriteLine("Enter your secret message below");
            string message = Console.ReadLine().ToLower();
            string encryptedMessage = "";

            for (int i = 0; i < message.Length; i++)
            {
                if((Array.IndexOf(alphabet, message[i]) + 3) < (alphabet.Length - 1))
                {
                    encryptedMessage += alphabet[Array.IndexOf(alphabet, message[i]) + 3];
                }
                else
                {
                    encryptedMessage += alphabet[(Array.IndexOf(alphabet, message[i]) + 3) - alphabet.Length];
                }
            }

            Console.WriteLine(encryptedMessage);
        }
    }
}
