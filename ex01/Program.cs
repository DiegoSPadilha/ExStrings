namespace ex01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite uma frase: ");
            string frase = Console.ReadLine();

            string[] palavras = frase.Split(' ');

            for (int i = 0; i < palavras.Length; i++)
            {
                palavras[i] = palavras[i].Substring(0, 1).ToUpper() + palavras[i].Substring(1).ToLower();
            }

            string novaFrase = string.Join(" ", palavras);

            Console.WriteLine("Frase primeiras letras maiusculas: " + novaFrase);

        }
    } 
}