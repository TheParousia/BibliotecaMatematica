using System;

class Program{


    static void Main(){
        int opt = 0;
        double num, altura,raio, volumeCilindro;

        bool repetir = true;
        do{
            //Apaga o que tem na tela
            Console.Clear();

            Console.WriteLine("\tMENU");
            Console.WriteLine("1- Volume do cilindro");
            Console.WriteLine("2- Opção 2");
            Console.WriteLine("3- Opção 3");
            Console.WriteLine("4- Opção 4");
            Console.WriteLine("5- Opção 5");
            Console.WriteLine("6- Opção 6");
            Console.WriteLine("4- Sair");

            opt = int.Parse(Console.ReadLine());

            switch (opt){
                case 1:
                    Console.WriteLine("Digite a altura do cilindro");
                    
                    altura = double.Parse(Console.ReadLine());

                    Console.WriteLine("Digite o raio da base do cilindro");

                    raio = double.Parse(Console.ReadLine());
                    
                    volumeCilindro = Biblioteca.CalculaVolumeCilindro(raio, altura);

                    Console.WriteLine("{0}", volumeCilindro);
                    break;
                case 2:
                    Console.WriteLine("Opt2");
                    break;
                case 3:
                    Console.WriteLine("Opt3");
                    break;
                case 4:
                    Console.WriteLine("Opt3");
                    repetir = false;
                    break;
                case 5:
                    Console.WriteLine("Digite o volume da esfera ");
                    
                    
                    break;
                default:
                    Console.WriteLine("Opção Invalida");
                    break;
            }
            // Pausa a execução do programa até uma tecla ser apertada
            Console.ReadKey();

        }while(repetir);
    }
    
}

