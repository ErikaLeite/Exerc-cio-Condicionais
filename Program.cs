using System;

namespace Exerc_cio_Condicionais
{
    class Program
    {
        static void Main(string[] args)
        {
            //Definição de Variáveis
            float nota1, nota2, nota3;
            string nomeCompleto;
            double media;

            //Entrada
            Console.Write("Nome completo do Aluno: ");
            nomeCompleto = Console.ReadLine();

            Console.Write("Digite a primeira nota: ");
            nota1 = float.Parse (Console.ReadLine());

            Console.Write("Digite a segunda nota: ");
            nota2 = float.Parse (Console.ReadLine());

            Console.Write("Digite a terceira nota: ");
            nota3 = float.Parse (Console.ReadLine());

            // //Processamento de Dados
            media = (nota1 + nota2 + nota3) / 3;
            
            //Exibição
            if(media>5){
                //verdadeiro
                Console.WriteLine("O aluno "+nomeCompleto+" foi Aprovado. Média final: "+media);
            }
            else{
                //valor falso
                Console.WriteLine("O aluno "+nomeCompleto+" foi REPROVADO. Média final: "+media);
            }
            {
                
            }
            

        }
    }
}
