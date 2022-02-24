using System;

namespace FlaviusJosephus.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int casosDeTestes;
            while (true)
            {
                Console.WriteLine("Digite a quantidade de casos de testes : ");
                if (int.TryParse(Console.ReadLine(), out casosDeTestes) && casosDeTestes > 0 && casosDeTestes < 31) ;
                break;
            }
            int pessoas = 0, tamanhoSalto;
            bool[] pessoasMortas;

            char[] input;
            string temp = "";
            int casoAtual = 1;

            while (casoAtual <= casosDeTestes)
            {
                Console.WriteLine("Digite a quantidade de pessoas no círculo e o tamanho do salto: ");
                input = Console.ReadLine().ToCharArray();
                for (int i = 0; i < input.Length; i++)
                {
                    if (input[i] != ' ')
                        temp += input[i];
                    else
                    {
                        pessoas = int.Parse(temp);
                        temp = "";
                    }
                }
                tamanhoSalto = int.Parse(temp);
                pessoasMortas = new bool[pessoas];
                temp = "";
                int contador = tamanhoSalto - 1;
                pessoasMortas[contador] = true;
                int pessoaRestante = pessoas - 1;
                int saltoAtual = 0;
                while (true)
                {
                    if (pessoasMortas[contador] == false)
                    {
                        saltoAtual++;
                        if (saltoAtual == tamanhoSalto)
                        {
                            pessoasMortas[contador] = true;
                            pessoaRestante--;
                            if (pessoaRestante == 1)
                            {
                                Console.WriteLine("Caso " + casoAtual + ": " +
                                (Array.IndexOf(pessoasMortas, false) + 1));
                                break;
                            }
                            saltoAtual = 0;
                        }
                    }
                    contador++;
                    if (contador == pessoasMortas.Length)
                        contador = 0;
                }
                casoAtual++;

            }
            Console.ReadLine();
        }
    }
}
