namespace ex02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite uma frase: \n");
            string frase = Console.ReadLine();

            Console.WriteLine();

            int numPalavras = ContarPalavras(frase);
            Console.WriteLine($"A frase ' {frase} ' possui {numPalavras} palavras.");
        }
        static int ContarPalavras(string frase)
        {
            string[] palavras = frase.Split(' ');
            return palavras.Length;
        }
    }
}