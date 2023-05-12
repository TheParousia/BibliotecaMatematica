using System;

class Program{

    static void Main(){
        int opção = 0;
        double raio, resultado;
        bool repetir = true;
        //Insira as variáveis do seu algoritmo aqui

        do{
            //Apaga o que tem na tela
            Console.Clear();

            Console.WriteLine("\tMENU");
            Console.WriteLine("1-Calcular o Volume da Esfera");
        
            opção = int.Parse(Console.ReadLine());

            //Limpa o menu para mostrar somente a opção selecionada
            Console.Clear();
            switch (opção){
                case 1:
                    Console.WriteLine("Opção 1");
                    Console.WriteLine("Digite valor do raio: ");
                    raio = int.Parse(Console.ReadLine());

                    resultado = Biblioteca.CalculaVolumeEsfera(raio);
                    
                    Console.WriteLine("O Resultado do volume da Esfera : {0}",resultado);

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

