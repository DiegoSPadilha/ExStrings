namespace ex05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite uma frase: ");
            string frase = Console.ReadLine();
            Console.WriteLine();

            Console.WriteLine("Frase em maiusculo: " + frase.ToUpper() + "\n");
            Console.WriteLine("Frase em minusculo: " + frase.ToLower() + "\n");
            Console.WriteLine("Numero de caracteres: " + frase.Count() + "\n");
            Console.WriteLine("Primeira palvra: " + frase.Remove(frase.IndexOf(" ")));

            string[] fraseCortada = frase.Split(" ");
            Console.WriteLine("Ultima palvra: " + fraseCortada[fraseCortada.Length - 1]);
        }
    }
}