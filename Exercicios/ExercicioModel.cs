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
        private int senha;

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
                return -2;
            }
            else if (GetNum2() == 0)
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
            if (numero >= 100 && numero <= 200)
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
            if (idade >= 16 && idade < 18)
            {
                return "Você pode votar, voto facultativo";
            }
            if (idade >= 18)
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
            if (anterior == num)
            {
                return -1;
            }
            else
            {
                return -2;
            }
        }//fim do método

        // Leia um número inteiro e retornar todos os múltiplos menores que 100

        public string multiplo(int numero)
        {
            //Contador
            int i = 1;//Criando o contador e derfinindo o ponto de partida
            string resultado = "";
            while (i < 100)
            {
                if (numero % i == 0)
                {

                    resultado += i + "\n";
                }
                //Rodar o meu contador
                i++;
            }//fim do while
            return resultado;
        }//fim do mótodo

        public string multiploFor(int numero)
        {
            string resultado = "";
            for (int i = 1; i < 100; i++)
            {
                if (numero % i == 0)
                {
                    resultado += i + "\n";
                }//fim do if
            }//fim do for
            return resultado;
        }//fim do método

        //Leia um número e verifique se ele é palíndromo(em: 121, 1331, 1441, 0660)

        public bool EhPalindromo(string palin)
        {
            int fim = palin.Length - 1;//Meço o tamanho de um conjunto de caracteres
            int inicio = 0;

            while (inicio < fim)
            {
                if (palin.Substring(inicio, 1) != palin.Substring(fim, 1))
                {
                    return false;
                }
                inicio++;
                fim--;
            }//fim do while
            return true;
        }//fim do método

        //Solicite ao usuário 10 números e conte os pares e impares

        public void ContarParImpar()
        {
            int contarPar = 0;
            int contarImpar = 0;

            for (int i = 0; i < 10; i++)
            {
                Console.Write(i + 1 + "° número: ");
                int num = Convert.ToInt32(Console.ReadLine());
                //Comparações
                if (num % 2 == 0)
                {
                    contarPar++;
                }
                else
                {
                    contarImpar++;
                }
            }//fim do for
            Console.WriteLine("A quantidade de pares é: " + contarPar + "\nA quantidade de ímpares é: " + contarImpar);
        }//fim do parImpar

        // Leia um número e verifique quanyos dígitos ele possui
    
        public int Verifique(string num)
        {
            return num.Length;
        }//fim do Verifique

        // Peça uma senha ao usuário e permita até 3 tentativas para acertar.
        public bool VerificarSenha(int senha)
        {
            int senhaLocal = 1234;
            if(senha == senhaLocal)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }//fim da classe
}//fim do projeto
