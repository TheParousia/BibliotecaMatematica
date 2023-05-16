using System;

class Program
{
    static void Main(){
        //Insira as variáveis do seu algoritmo aqui

        int opt = 0;
        double basedoquadrado, altura, resultado;
        double basemaior, basemenor, altura, resultado;
        double raio;
        bool repetir = true;
        double raio, resultado;
        double largura, basedoprisma, altura, resultado;  
        do{
            //Apaga o que tem na tela
            Console.Clear();
        
            Console.WriteLine("\tMENU");


            Console.Write("1- Área de um trapézio\t");
            Console.WriteLine("2- Área de um quadrado");
            Console.Write("3 - Calcular o Volume da Esfera\t");
            Console.WriteLine("4- Volume de um prisma retangular");    
            Console.Write("5- Área de um círculo\t");
            Console.WriteLine("6- Opção 6");
            Console.WriteLine("99- Sair\n");

            opt = int.Parse(Console.ReadLine());

            //Limpa o menu para mostrar somente a opção selecionada
            Console.Clear();

            switch (opção){
              case 1:
                   Console.WriteLine("Você escolheu calcular a área de um trapézio");
                    
                   Console.WriteLine("Digite o valor da base maior:");
                   basemaior = double.Parse(Console.ReadLine());

                   Console.WriteLine("Digite o valor da base menor:");
                   basemenor = double.Parse(Console.ReadLine());
                    
                   Console.WriteLine("Digite o valor da altura:");
                   altura = double.Parse(Console.ReadLine());

                   resultado = Biblioteca.areaTrapezio(basemaior, basemenor, altura);

                   Console.WriteLine("A área do trapézio é {0} ", resultado);
                  break;
                case 2:
                    Console.WriteLine("Digite o valor da base do quadrado : ");
                    basedoquadrado = double.Parse(Console.ReadLine());

                    Console.WriteLine("Digite o valor da altura do quadrado : ");
                    altura = double.Parse(Console.ReadLine());

                    resultado = Biblioteca.areaQuadrado(basedoquadrado, altura);

                    Console.WriteLine("A area do quadrado é {0} ", resultado);

                    break;
                case 3:
                    Console.WriteLine("Digite valor do raio: ");
                    raio = int.Parse(Console.ReadLine());

                    resultado = Biblioteca.CalculaVolumeEsfera(raio);
                    
                    Console.WriteLine("O Resultado do volume da Esfera : {0}",resultado);
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
                    Console.WriteLine("Você escolheu calcular a área de um círculo");

                    Console.WriteLine("Digite o valor do raio do círculo:");
                    raio = double.Parse(Console.ReadLine());

                    resultado = Biblioteca.areaDoCirculo(raio);

                    Console.WriteLine("A área do círculo é {0} ", resultado);
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

            Console.WriteLine("\nPrecione uma tecla para prosseguir...");
            // Pausa a execução do programa até uma tecla ser apertada
            Console.ReadKey();

        } while (repetir);
    }

}

