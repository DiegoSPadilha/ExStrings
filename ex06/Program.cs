namespace ex06
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const int POSICAO_CIDADE = 2;
            const int POSICAO_ESTADO = 3;

            string arquivo = File.ReadAllText(caminhoDoArquivo);

            string[] linhas = arquivo.Split("\r\n");

            string[] cidadesEhEstados = new string[linhas.Length];

            int j = 0;
            for (int i = 1; i < linhas.Length; i++)
            {
                string[] colunas = linhas[i].Split(",");

                cidadesEhEstados[j] = colunas[POSICAO_CIDADE] + "," + colunas[POSICAO_ESTADO];

                j++;
            }

            return cidadesEhEstados;
        }

        static void MostrarCidadesAgrupadasPelaPrimeiraLetra(string[] cidadesEhEstados)
        {
            Console.Clear();

            char[] alfabeto = new char[]
            {
                'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M',
                   'N', 'O', 'P', 'Q', 'R', 'S', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z'
            };

            for (int i = 0; i < alfabeto.Length; i++)
            {
                //cabeçalho
                Console.WriteLine($"\nCidades com a letra {alfabeto[i]}\n");

                for (int x = 0; x < cidadesEhEstados.Length; x++)
                {
                    char primeiraLetra = alfabeto[i];

                    
                    if (cidadesEhEstados[x] != null && cidadesEhEstados[x].StartsWith(primeiraLetra))
                    {
                        int posicaoInicioEstado = cidadesEhEstados[x].IndexOf(",");
                        string cidadeSemEstado = cidadesEhEstados[x].Remove(posicaoInicioEstado);
                        Console.WriteLine("\t" + cidadeSemEstado);
                    }
                }
            }
        }

        static void MostrarCidadesAgrupadasPorEstado(string[] cidadesEhEstados)
        {
            Console.Clear();
            string[] estados = new string[]
               {
                "Acre", "Alagoas", "Amapá", "Amazonas", "Bahia", "Ceará", "Distrito Federal",
                "Espírito Santo", "Goiás", "Maranhão", "Mato Grosso", "Mato Grosso do Sul",
                "Minas Gerais", "Pará", "Paraíba", "Paraná", "Pernambuco", "Piauí", "Rio de Janeiro",
                "Rio Grande do Norte", "Rio Grande do Sul", "Rondônia", "Roraima", "Santa Catarina",
                "São Paulo", "Sergipe", "Tocantins"
               };

            for (int i = 0; i < estados.Length; i++)
            {
                //cabeçalho abaixo
                string estado = estados[i];

                Console.WriteLine($"\nCidades do estado: {estado}\n");

                for (int x = 0; x < cidadesEhEstados.Length; x++)
                {
                    if (cidadesEhEstados[x] != null && cidadesEhEstados[x].Contains(estado))
                    {
                        int posicaoInicioEstado = cidadesEhEstados[x].IndexOf(",");
                        string cidadeSemEstado = cidadesEhEstados[x].Remove(posicaoInicioEstado);
                        Console.WriteLine("\t" + cidadeSemEstado);
                    }
                }
            }
        }

        static void Main(string[] args)
        {
            string caminhoArquivo = @"D:\Curso Academia 2023\Downloads da Academia";

            string[] cidadesEhEstados = ObterCidadesEhEstados(caminhoArquivo);

            Console.WriteLine("MENU");

            Console.WriteLine("(1) Cidades agrupadas pela primeira letra:");

            Console.WriteLine("(2) Cidades agrupadas por Estado:");

            string opcao = Console.ReadLine();

            if (opcao == "1")
                MostrarCidadesAgrupadasPelaPrimeiraLetra(cidadesEhEstados);

            else if (opcao == "2")
                MostrarCidadesAgrupadasPorEstado(cidadesEhEstados);

            Console.ReadLine();
        }

    }  
}