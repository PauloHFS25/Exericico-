using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;

namespace Exercicios
{
    class ExercicioModel
    {
        //Área para declaração de variáveis globais
        private int num;
        private int num1;
        private int num2;
        private double num3;
        private double num4;
        private int resultado;
        private int idade;
        private int ini;
        private int fim;
        private int num5;
        private double lado1, lado2, lado3;

        //Método Contrutor: Instância as variáveis na memória

        public ExercicioModel()
        {
            SetNum1(0);
            SetNum2(0);
            SetResultado(0);
        }//fim do método construtor

        public ExercicioModel(int num1, int num2)
        {
            SetNum1(num1);
            SetNum2(num2);
            SetResultado(0);
        }//fim do construtor

        public ExercicioModel(double num1, double num2)
        {
            SetNum3(num1);
            SetNum4(num2);
        }//fim do construtor

        //Métodos GETS E SETS
        //GET = Pegar, Obter, Consultar
        //SET = Alterar, Modificar, Configurar
        public int GetNum1()
        {
            return this.num1;
        }//fim do getNum1

        public void SetNum1(int num1)
        {
            this.num1 = num1;
        }//fim do setNum1

        public int GetNum2()
        {
            return this.num2;
        }//fim do getNum2

        public int SetNum2(int num2)
        {
            return this.num2 = num2;
        }//fim do setNum2

        public int GetResultado()
        {
            return this.resultado;
        }//fim do método

        public void SetResultado(int resulitado)
        {
            this.resultado = resulitado;
        }//fim do método setResulitado

        public double GetNum3()
        {
            return this.num3;         
        }//fim do GetNum3

        public void SetNum3(double num3)
        {
            this.num3 = num3; 
        }//fim do setNum3

        public double GetNum4()
        {
            return this.num4; 
        }//fim do GetNum4

        public void SetNum4(double num4)
        {
            this.num4 = num4;
        }//fim do SetNum4
        public int Somar()
        {
            return this.num1 + this.num2;
        }//fim do método somar

        public int Subtrair()
        {
            SetResultado(GetNum1() - GetNum2());
            return GetResultado();
        }//fim do método subtrair

        public int Multiplicar()
        {
            SetResultado(GetNum1() * GetNum2());
            return GetResultado();
        }//fim do multiplicar

        public double Dividir()
        {
            if (GetNum2() < 0)
            {
                return - 2;
            }
            else if(GetNum2() == 0)
            {
                return -1;
            }
            else
            {
                SetResultado(GetNum1() / GetNum2());
                return GetResultado();
            }//fim do if
        }//fim do dividir

        public double Potencia(double bas, double expoente)
        {
            return Math.Pow(bas, expoente);  
        }//fim da potencia

        public double Raiz(double num)
        {
            return Math.Sqrt(num);
        }//fim da Raiz

        public double Potencia()
        {
            return Math.Pow(GetNum3(), GetNum4());
        }//fim do potencia sem parâmetros

        public double RaizNum3()
        {
            return Math.Sqrt(GetNum3());
        }//fim do raiz

        public double RaizNum4()
        { 
            return Math.Sqrt(GetNum4());        
        }//fim do reiz num 4

        public string Exercicio01(int ano)
        {
            if (ano % 4 == 0)
            {
                return ano + " é bissexto!";
            }
            else
            {
                return ano + " não é bissexto!";
            }
        }//fim do ano Bissexto
        public string Exercicio02(int numero)
        {
           if(numero >= 100 && numero <= 200)
            {
                return "O número está entre 100 e 200";
            }
            else
            {
                return "O número NÃO está entre 100 e 200";
            }
        }//fim do Número

        public string Exercicio03(int idade)
        {
            if(idade >= 16 && idade < 18)
            {
                return "Você pode votar, voto facultativo";
            }
            if(idade >= 18)
            {
                return "Você deve votar, voto obrigatório";
            }
            else
            {
                return "Você NÃO precisa votar";
            }
        }//fim da idade
        public string Exercicio04(int ini, int fim, int num5)
        {
            if (num5 >= ini && num <= fim)
            {
                return "O num5 está no intervalo";
            }
            else
            {
                return "O num5 NÃO está no intervalo";            
            }
        }//fim do ini, fim, num
        public int Exercicio05(int num, int anterior)
        {
            if(anterior == num)
            {
                return -1;
            }
            else
            {
                return -2;
            }
        }//fim do método

        public string Exercício06(double lado1, double lado2, double lado3)
        {
            if(lado1 <= 0);
            {
                return "Não existe lado negativo";
            }
            if(lado2 <= 0) 
            {
                return "Não existe lado negtivo";
            }
            if(lado3 <= 0);
            {
                return "Não existe lado negtivo";
            }
           
        }//fim do lado 
    }//fim da classe
}//fim do projeto
