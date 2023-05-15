using System;

class Program{

    static void Main(){
        int opt = 0;
        bool repetir = true;
        double largura, basedoprisma, altura, resultado;
        //Insira as variáveis do seu algoritmo aqui

        do{
            //Apaga o que tem na tela
            Console.Clear();

            Console.WriteLine("\tMENU");
            Console.WriteLine("1- Opção 1");
            Console.WriteLine("2- Opção 2");
            Console.WriteLine("3- Opção 3");
            Console.WriteLine("4- Volume de um prisma retangular");
            Console.WriteLine("5- Opção 5");
            Console.WriteLine("6- Opção 6");
            Console.WriteLine("99- Sair\n");

            opt = int.Parse(Console.ReadLine());

            //Limpa o menu para mostrar somente a opção selecionada
            Console.Clear();
            switch (opt){
                case 1:
                    Console.WriteLine("Opt1");
                    break;
                case 2:
                    Console.WriteLine("Opt3");
                    break;
                case 3:
                    Console.WriteLine("Opt3");
                    break;
                case 4:
                
                    Console.WriteLine("Você escolheu calcular o volume de um prisma retangular");

                    Console.WriteLine("Digite o valor da largura do prisma:");
                    largura = double.Parse(Console.ReadLine());

                    Console.WriteLine("Digite o valor da base:");
                    basedoprisma = double.Parse(Console.ReadLine());
                    
                    Console.WriteLine("Digite o valor da altura:");
                    altura = double.Parse(Console.ReadLine());

                    resultado = Biblioteca.VolumeDoPrisma(largura, basedoprisma, altura);

                    Console.WriteLine("A área do prisma é {0} ", resultado);

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

