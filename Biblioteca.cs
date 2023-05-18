
class Biblioteca{
    // Código do Cyranto
    static public double areaDoCirculo(double raio)
    {
        double area;
        area = Math.PI * Math.Pow(raio, 2);

        return area;
    }


    //Escdreva a sua função alterando o que for nescessário
    // Khetellen
    static public double volumeDaPiramide(double areaDabase , double altura){
        double volume;
        
        volume = (areaDabase * altura)/3; 
       
        return volume;
    }
    
    // Luana
    static public double mediaAritmetica(double c1, double c2, double c3){
        double media;

        media = (c1+c2+c3)/3;

        return media;
    }
    
    // Lucas
    static public double areaTriangulo(double b, double h){
        double area;
        area = b*h/2;
        return area;
    }
  
    // Pedro
    static public double VolumeDoPrisma(double largura, double basedoprisma, double altura){
        double volume;
        volume = largura * basedoprisma * altura;

        return volume;
    }
    
    // Código da Lavigne
    static public double CalculaVolumeEsfera(double r){
        return 4/3 * Math.PI * Math.Pow(r, 3);
    }
  
    // Código do João
    static public double areaQuadrado(double basedoquadrado, double altura){
        double area;
        
        area = basedoquadrado * altura;
                
        return area;
    }
  
    // Código da Samara  
    static public double areaTrapezio(double basemaior, double basemenor, double altura){
        double area;
        area = (basemaior + basemenor)/2 * altura;

        return area;
    }
    
    // Rafael
    static public double distanciaEntreDoisPontos(double x2, double x1, double y2, double y1){
        double distancia;
        distancia = Math.Sqrt (Math.Pow( x2 - x1, 2)  + Math.Pow( y2 - y1, 2 ));

        return distancia;
    }
}