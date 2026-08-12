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
        private int opcao;

        public ExercicioControl()
        {
            this.modelo = new ExercicioModel();
            SetOpcao(0);
        }//Construtor Padrão

        public int GetOpcao()
        {
            return this.opcao;
        }//fim do getOpcao

        public void SetOpcao(int opcao)
        {
            this.opcao = opcao; 
        }//fim do set
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

        public void ColetarReal()
        {
            //Pegar dois números
            Console.WriteLine("Informe o primeiro número: ");
            double num1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Informe o segundo número: ");
            double num2 = Convert.ToDouble(Console.ReadLine());
            //Chamar o construtor que recebe reais
            this.modelo = new ExercicioModel(num1, num2);
        }//fim do coletarReal

        //Mostrar as opçôes de operação na tela
        public void Menu()
        {
            Console.WriteLine("Esclha uma das opções abaixo: \n" +
                              "0. Sair\n" +
                              "1. Soma\n" +
                              "2. Subtração\n" +
                              "3. Divisão\n" +
                              "4. Multiplicação\n" +
                              "5. Potênica\n" +
                              "6. Potênica com Parâmetros\n" +
                              "7. Raiz\n" +
                              "8. Raiz com Parâmetros\n" +
                              "9. Exercício 01\n" +
                              "10. Exercício 02\n" +
                              "11. Exercício 03\n" +
                              "12. Exercício 04\n" +
                              "13. Exercício 05\n" +
                              "14. Execício 06\n");
                             
            SetOpcao(Convert.ToInt32(Console.ReadLine()));
            Console.Clear();//Limpa o console
        }//fim do menu

        //Executar o menu

        public void ExecutarMenu()
        {
            do
            {
                Menu();//Mostrar as opções
                switch (GetOpcao())
                {

                    case 0:
                        Console.WriteLine("Obrigado!");
                        break;
                    case 1:
                        Coletar();//Pegar os dois números
                        Console.WriteLine("A soma é: " + this.modelo.Somar());//Fezer a operação de soma
                        break;//Finalizar o case
                    case 2:
                        Coletar();
                        Console.WriteLine("A subtração é: " + this.modelo.Subtrair());
                        break;
                    case 3:
                        Coletar();
                        //Validação
                        if (this.modelo.Dividir() == -2)
                        {
                            Console.WriteLine("Impossível dividir por número negativo!");
                        }
                        else if (this.modelo.Dividir() == -1)
                        {
                            Console.WriteLine("Impossível dividir por zero!");
                        }
                        else
                        {
                            Console.WriteLine("A Divisão é: " + this.modelo.Dividir());
                        }
                        break;
                    case 4:
                        Coletar();
                        Console.WriteLine("A multiplicação é" + this.modelo.Multiplicar());
                        break;
                    case 5:
                        ColetarReal();
                        Console.WriteLine("A Potência é: " + this.modelo.Potencia());
                        break;
                    case 6:
                        Console.WriteLine("Informe a base: ");
                        double bas = Convert.ToDouble(Console.ReadLine());

                        Console.WriteLine("Informe o expoente: ");
                        double expoente = Convert.ToDouble(Console.ReadLine());
                        //Mostrar o resultado da opearção
                        Console.WriteLine("A potência é: " + this.modelo.Potencia(bas, expoente));
                        break;
                    case 7:
                        ColetarReal();
                        Console.WriteLine("A raiz do primeiro número é: " + this.modelo.RaizNum3());
                        Console.WriteLine("A raiz do segundo número é: " + this.modelo.RaizNum4());
                        break;
                    case 8:
                        Console.WriteLine("Informe o primeiro número: ");
                        double num1 = Convert.ToDouble(Console.ReadLine());

                        Console.WriteLine("Informe o segundo número: ");
                        double num2 = Convert.ToDouble(Console.ReadLine());
                        //Chamar o método que calcula a Raiz
                        Console.WriteLine("A raiz do primeiro número: " + this.modelo.Raiz(num1));
                        Console.WriteLine("A raiz do segundo número é: " + this.modelo.Raiz(num2));
                        break;
                    case 9:
                        Console.WriteLine("Informe o ano: ");
                        int ano = Convert.ToInt32(Console.ReadLine());
                        //Mostrar o resultado
                        Console.WriteLine(this.modelo.Exercicio01(ano));
                        break;
                    case 10:
                        Console.WriteLine("Informe o número");
                        int num = Convert.ToInt32(Console.ReadLine());
                        //Mostrar o resultado
                        Console.WriteLine(this.modelo.Exercicio02(num));
                        break;
                    case 11:
                        Console.WriteLine("Informe a sua idade");
                        int idade = Convert.ToInt32(Console.ReadLine());
                        //Verificar a idade
                        Console.WriteLine(this.modelo.Exercicio03(idade));
                        break;
                    case 12:
                        Console.WriteLine("Informe o início do intervalo");
                        int ini = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Informe o fim do intervalo");
                        int fim = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Informe número que deseja buscar");
                        int num5 = Convert.ToInt32(Console.ReadLine());
                        //Buscar o número no intervalo
                        Console.WriteLine(this.modelo.Exercicio04(ini, fim, num5));
                        break;
                    case 13:
                        Console.WriteLine("Informe um número");
                        num = Convert.ToInt32(Console.ReadLine());
                        int anterior = 0;
                        int resultado = 0;
                        int i = 0;
                        do
                        {
                            Console.WriteLine("Informe um outro número: ");
                            anterior = Convert.ToInt32(Console.ReadLine());
                            i++;
                            resultado = this.modelo.Exercicio05(num, anterior);
                            if (resultado == -1)
                            {
                                Console.WriteLine("O número está no intervalo");
                            }
                        } while (resultado != -1 && i < 10);

                        if(resultado == -2)
                        {
                            Console.WriteLine("O número não está no intervalo");
                        }

                        break;
                    case 14:
                        
                        Console.WriteLine("Informe o primeiro lado");
                        double lado1 = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("Informe o segundo lado");
                        double lado2 = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("Informe o terceiro lado");
                        double lado3 = Convert.ToDouble(Console.ReadLine());

                        //Faço as cpmparações

                        Console.WriteLine(this.modelo.Exercício06(lado1, lado2, lado3));

                        if(lado1 = lado2) (lado1 = lado3)(lado2 = lado3)
                        {
                            Console.WriteLine("Triângulo Equilátero");
                        }
                        if(lado1 <> lado2 && lado1 <> lado3 && lado2 <> lado3)
                            { 
                        }

                        break;
                    default:
                        Console.WriteLine("Opção esclhida não é valida!");
                        break;
                }//fim do escolha
            } while (GetOpcao() != 0);//fim do do...while 
        }//fim do método executar menu
    
    }//fim da classe
}//fim do projeto
    

            
           
           
