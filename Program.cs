using System;

class Program{


    static void Main(){
    int opt = 0;
        double basedoquadrado, altura, resultado;
        bool repetir = true;
        do{
        //Insira as variáveis do seu algoritmo aqui

            //Apaga o que tem na tela
            Console.Clear();
        
            Console.WriteLine("\tMENU");
            Console.WriteLine("1- Área de um quadrado");
            Console.WriteLine("2- Opção 2");
            Console.WriteLine("3- Opção 3");
            Console.WriteLine("4- Opção 4");
            Console.WriteLine("5- Opção 5");
            Console.WriteLine("6- Opção 6");
            Console.WriteLine("99- Sair\n");

            opt = int.Parse(Console.ReadLine());

            //Limpa o menu para mostrar somente a opção selecionada
            Console.Clear();
            switch (opt){
                case 1:
                    Console.WriteLine("Digite o valor da base do quadrado : ");
                    basedoquadrado = double.Parse(Console.ReadLine());

                    Console.WriteLine("Digite o valor da altura do quadrado : ");
                    altura = double.Parse(Console.ReadLine());

                    resultado = Biblioteca.areaQuadrado(basedoquadrado, altura);

                    Console.WriteLine("A area do quadrado é {0} ", resultado);
                break;
                case 2:
                    Console.WriteLine("Opt3");
                    break;
                case 3:
                    Console.WriteLine("Opt3");
                    break;
                case 4:
                    Console.WriteLine("Opt4");
                    break;
                case 5:
                    Console.WriteLine("Opt5");
                    break;
                case 6:
                    Console.WriteLine("Opt6");
                    break;
                case 99:
                    Console.WriteLine("Opção sair");
                    repetir = false;
                    break;
                default:
                    Console.WriteLine("Opção Invalida");
                    break;
            }

            Console.WriteLine("\n\nPrecione uma tecla para prosseguir...");
            // Pausa a execução do programa até uma tecla ser apertada
            Console.ReadKey();

        }while(repetir);
    }
    
}

