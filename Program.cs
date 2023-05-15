using System;

class Program{

    static void Main(){
        int opt = 0;
        bool repetir = true;
        double x1, x2, y1, y2, resultado;
        //Insira as variáveis do seu algoritmo aqui

        do{
            //Apaga o que tem na tela
            Console.Clear();

            Console.WriteLine("\tMENU");
            Console.WriteLine("1- Opção 1");
            Console.WriteLine("2- Opção 2");
            Console.WriteLine("3- Opção 3");
            Console.WriteLine("4- Opção 4");
            Console.WriteLine("5- Opção 5");
            Console.WriteLine("6- Opção 6( Distancia entre dois pontos)");
            Console.WriteLine("99- Sair\n");

            opt = int.Parse(Console.ReadLine());

            //Limpa o menu para mostrar somente a opção selecionada
            Console.Clear();
            switch (opt){
                case 1:
                    
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
                    Console.WriteLine("Você escolheu a opção 6(Distancia entre dois pontos)");

                   Console.WriteLine("Digite a Coordenadas X do ponto B: ");
                    x1 = double.Parse(Console.ReadLine());

                   Console.WriteLine("Digite a Coordenadas X do ponto A: ");
                    x2 = double.Parse(Console.ReadLine());
                        
                   Console.WriteLine("Digite a Coordenadas Y do ponto B: ");
                    y1 = double.Parse(Console.ReadLine());

                   Console.WriteLine("Digite a Coordenadas Y do ponto A: ");
                    y2 = double.Parse(Console.ReadLine());

                   resultado = Biblioteca.distanciaEntreDoisPontos(x2, x1, y2, y1);
                   Console.WriteLine("A Distância entre os dois pontos é {0} ", resultado);
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

