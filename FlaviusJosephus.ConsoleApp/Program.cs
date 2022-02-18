using System;

namespace FlaviusJosephus.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args) {
            int casosDeTestes;
            while (true) {
                Console.WriteLine("Digite a quantidade de casos de testes : ");
                if (int.TryParse(Console.ReadLine(), out casosDeTestes) && casosDeTestes > 0 && casosDeTestes < 31);
                    break;
            }
            int pessoas, tamanhoSalto;
            bool[] pessoasMortas;

            char[] input;

            while (casosDeTestes > 0) {
                Console.WriteLine("Digite a quantidade de pessoas no círculo e o tamanho do salto: ");
                input = Console.ReadLine().ToCharArray();

                pessoasMortas = new bool[pessoas];

                int contador = tamanhoSalto - 1;
                int saltoAtual = 0;
                pessoasMortas[contador] = true;

                while (true) {
                    if (pessoasMortas[contador] == false) {
                        saltoAtual++;
                    }
                    if (saltoAtual == tamanhoSalto) {
                        pessoasMortas[contador] = true;
                        saltoAtual = 0;
                    }
                    if (contador + tamanhoSalto >= pessoasMortas.Length)
                        contador = tamanhoSalto - (pessoasMortas.Length - contador) - 1;
                    else 
                        contador += tamanhoSalto;

                    contador++;
                    if (contador == pessoasMortas.Length)
                        contador = 0;
                }

                casosDeTestes--;
            }
        }
    }
}
