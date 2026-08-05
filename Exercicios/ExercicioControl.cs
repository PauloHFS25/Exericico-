using System;
using System.Collections.Generic;
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

        public void Colotar()
        {    
            //Peguei os dois
            Console.Write("Informe o primeiro número: ");
            int num1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Informe o segundo número: ");
            int num2 = Convert.ToInt32(Console.ReadLine());

            //Vou passar para
        }//fim do coletar = Pega os dois numeros digitados
    }
}
    

            
           
           
