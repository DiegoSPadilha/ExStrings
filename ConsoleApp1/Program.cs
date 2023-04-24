namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite o texto: ");
            string texto = Console.ReadLine();

            Console.Write("Digite o valor de X (posições a frente) para cifrar o texto: ");
            int x = int.Parse(Console.ReadLine());

            string textoCifrado = CifrarTexto(texto, x);

            Console.WriteLine("Texto cifrado: " + textoCifrado);
            Console.ReadLine();
        }

        static string CifrarTexto(string texto, int x)
        {
            string alfabeto = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            string textoCifrado = "";

            foreach (char letra in texto.ToUpper())
            {
                if (Char.IsLetter(letra))
                {
                    int posicaoAtual = alfabeto.IndexOf(letra);
                    int posicaoCifrada = (posicaoAtual + x) % 26;
                    char letraCifrada = alfabeto[posicaoCifrada];
                    textoCifrado += letraCifrada;
                }
                else
                {
                    textoCifrado += letra;
                }
            }

            return textoCifrado;
        }
    }
}