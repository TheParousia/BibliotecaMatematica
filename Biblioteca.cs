
class Biblioteca{
    // Código do Cyranto
    static public double areaDoCirculo(double raio)
    {
        double area;
        area = Math.PI * Math.Pow(raio, 2);

        return area;
    }

    // Código do Pedro
    //Escdreva a sua função alterando o que for nescessário
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
        
}