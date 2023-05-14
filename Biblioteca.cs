class Biblioteca{
    
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