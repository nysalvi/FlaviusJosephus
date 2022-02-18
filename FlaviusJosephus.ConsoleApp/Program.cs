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

            string input;

            while (casosDeTestes > 0) {
                Console.WriteLine("Digite a quantidade de pessoas no círculo e o tamanho do salto: ");
                input = Console.ReadLine();

                if (!int.TryParse(Console.ReadLine(), out pessoas) || pessoas < 1 || pessoas > 10000) {
                    Console.WriteLine("Digite números entre 1 e 10000");
                    continue;
                }
                if (!int.TryParse(Console.ReadLine(), out tamanhoSalto) || tamanhoSalto < 1 || tamanhoSalto > 1000) {
                    Console.WriteLine("Digite números entre 1 e 1000");
                    continue;
                }
                pessoasMortas = new bool[pessoas];

                int contador = tamanhoSalto - 1;
                while (true) {         
                    
                    if (pessoasMortas[0] == false)
                        pessoasMortas[contador] = true;
                    if (contador + tamanhoSalto >= pessoasMortas.Length)
                        contador = tamanhoSalto - (pessoasMortas.Length - contador) - 1;
                    else 
                        contador += tamanhoSalto;                        
                   
                }

                casosDeTestes--;
            }
        }
    }
}
