using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicios
{ 
    class ExercicioControl
    {
        ExercicioModel modelo;//Conectando a Class Model e Control


        public ExercicioControl()
        {
            this.modelo = new ExercicioModel();
        }//Construtor

        public void Coletar()
        {    
            //Peguei os dois
            Console.Write("Informe o primeiro número: ");
            int num1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Informe o segundo número: ");
            int num2 = Convert.ToInt32(Console.ReadLine());

            //Vou passar para o construtor com parâmetro
            this.modelo = new ExercicioModel(num1, num2);
        }//fim do coletar = Pega os dois numeros digitados

        public void Menu()
        {
            Console.WriteLine("Esclha uma das opções abaixo: \n" +
                              "0. Sair\n"                        +   
                              "1. Soma\n"                        +
                              "2. Subtração\n"                   +
                              "3. Divisão\n"                     +
                              "4. Multiplicação\n"               +
                              "5. Potênica\n"                    +
                              "6. Potênica com Parâmetros\n"     +
                              "7. Raiz\n"                        +
                              "8. Raiz com Parâmetros\n")        +
            SetOpcao(Convert.ToInt32(Console.ReadLine()));
            Console.Clear();//Limpa o console
        }//fim do menu

        //Executar o menu

        public void ExecutarMenu()
        {
            do
            { 
            
            }
        }//fim do método executar menu
    }
}
    

            
           
           
