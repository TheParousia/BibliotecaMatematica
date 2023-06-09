using System;

class Program
{
    static void Main(){
        //Insira as variáveis do seu algoritmo aqui
      
        int opt = 0;
        bool repetir = true;  
        double D, d, b, h, a, aresta, area, num, basedoquadrado, areaDabase, altura, resultado, basemaior, basemenor, raio, largura, basedoprisma;
        double volumeCilindro;
        double x1, x2, y1, y2, c1, c2, c3;
      
        do{
            //Apaga o que tem na tela
            Console.Clear();
        
            Console.WriteLine("\tMENU");
            Console.Write("1- Área de um trapézio\t");
            Console.WriteLine("2- Área de um quadrado");
            Console.Write("3 - Calcular o Volume da Esfera\t");
            Console.WriteLine("4- Volume de um prisma retangular");    
            Console.Write("5- Área de um círculo\t");
            Console.WriteLine("6- Distancia entre dois pontos");
            Console.Write("7- Area do Triangulo Retangulo\t");
            Console.WriteLine("8- Formula da Média Aritmética, usando 3 numeros");
            Console.Write("9- Volume de uma pirâmide");
            Console.WriteLine("10- Volume do cilindro");
            Console.Write("11- Calcula área do Losango\t");
            Console.WriteLine("12- Digite o volume do cubo");
            Console.WriteLine("\n99- Sair\n");

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
                    Console.WriteLine("Você escolheu a Formula do círculo, agora vamos calcular!");                
                
                    Console.WriteLine("Digite o valor do raio do círculo:");
                    raio = double.Parse(Console.ReadLine());

                    resultado = Biblioteca.areaDoCirculo(raio);

                    Console.WriteLine("A área do círculo é {0} ", resultado);
                    break;
                case 6:
                    Console.WriteLine("Você escolheu a opção 6 (Distancia entre dois pontos)");

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
                case 7:
                
                    Console.WriteLine("Area do Triangulo Retangulo");
                    
                    Console.WriteLine("digite o valor da base :");
                    b = double.Parse(Console.ReadLine());

                    Console.WriteLine("Digite o valor da altura :");
                    h = double.Parse(Console.ReadLine());

                    area = Biblioteca.areaTriangulo (b ,h);
                    Console.WriteLine("Área do triangulo = {0}", area);
                
                  break;
                case 8:
                    Console.Write("Você escolheu a Fórmula da Média Aritmética, agora vamos cálcular!");

                    Console.WriteLine("Digite o valor da primeira variável: ");
                    c1 = double.Parse(Console.ReadLine());

                    Console.WriteLine("Digite o valor da primeira variável: ");
                    c2 = double.Parse(Console.ReadLine());

                    Console.WriteLine("Digite o valor da primeira variável: ");
                    c3 = double.Parse(Console.ReadLine());

                    resultado = Biblioteca.mediaAritmetica(c1,c2,c3);

                    Console.WriteLine("Média artimética = {0}", resultado);

                    break;
                case 9:
                    Console.WriteLine("Você escolheu a opção 9");
                        
                    Console.WriteLine("Digite a área da base pirâmide:");
                    areaDabase = double.Parse(Console.ReadLine());
                        
                    Console.WriteLine("Digite o valor da altura:");
                    altura = double.Parse(Console.ReadLine());

                    resultado = Biblioteca.volumeDaPiramide(areaDabase, altura);

                    Console.WriteLine("volume da Piramide é {0} ", resultado);
                
                  break;
                
                case 10:
                    Console.WriteLine("Digite a altura do cilindro");
                    
                    altura = double.Parse(Console.ReadLine());

                    Console.WriteLine("Digite o raio da base do cilindro");

                    raio = double.Parse(Console.ReadLine());
                    
                    volumeCilindro = Biblioteca.CalculaVolumeCilindro(raio, altura);

                    Console.WriteLine("{0}", volumeCilindro);
                    break;
                  case 11:
                    Console.WriteLine("Calcula área Losango");
                    
                    Console.WriteLine("insira a diagonal menor");
                    d = double.Parse(Console.ReadLine());
                     
                    Console.WriteLine("insira a diagonal maior");
                    D = double.Parse(Console.ReadLine());

                    resultado = Biblioteca.CalculeAreaLosango(D, d);
                   
                    Console.WriteLine("A área do losango é {0}", resultado);
                    break;
                
                case 12:
                    Console.WriteLine(" você escolheu a formula do volume do cubo ");
                   
                    Console.WriteLine("Digite o volume o cubo: ");

                    a = double.Parse(Console.ReadLine());

                    aresta = Biblioteca.volumeDocubo(a );
                    // Ewerton você tinha colocado um break nessa nesse lugar, seu programa nunca iria imprimir a linha subsequente
                    Console.WriteLine("O Resultado do volume do cubo : (0)", resultado);
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

