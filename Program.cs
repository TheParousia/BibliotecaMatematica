using System;

class Program{


    static void Main(){
        //Insira as variáveis do seu algoritmo aqui
      
        int opt = 0;
        double basedoquadrado, altura, resultado;
        double basemaior, basemenor;
        double raio;
        bool repetir = true;
        double num,area;
        
      do{

            //Apaga o que tem na tela
            Console.Clear();
        
            Console.WriteLine("\tMENU");

            Console.WriteLine("1- Formula do trapézio");
            Console.WriteLine("2- Formula do quadrado");
            Console.WriteLine("3- Formula do volume da esfera");
            Console.WriteLine("4- Formula da area do círculo");
            Console.WriteLine("5- Opção 5");
            Console.WriteLine("6- Opção 6");
            Console.WriteLine("7- Sair\n");

            opt = int.Parse(Console.ReadLine());

            //Limpa o menu para mostrar somente a opção selecionada
            Console.Clear();
            switch (opt){
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
                    Console.WriteLine("Opção 1");
                    Console.WriteLine("Digite valor do raio: ");
                    raio = int.Parse(Console.ReadLine());

                    resultado = Biblioteca.CalculaVolumeEsfera(raio);
                    
                    Console.WriteLine("O Resultado do volume da Esfera : {0}",resultado);
                    break;
                case 4:
                
                    Console.WriteLine("Você escolheu a Formula do círculo, Agora vamos calcular !");
                    Console.WriteLine("Digite o valor do raio:   ");

                    num = double.Parse(Console.ReadLine());
                    
                    area = Biblioteca.areaCirculo(num);
                
                    Console.WriteLine("A área do círculo =  {0}",area);

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

            Console.WriteLine("\nPrecione uma tecla para prosseguir...");
            // Pausa a execução do programa até uma tecla ser apertada
            Console.ReadKey();

        }while(repetir);
    }
    
}

