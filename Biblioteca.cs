class Biblioteca{
    
    static public double CalculaVolumeEsfera(double r){
        return 4/3 * Math.PI * Math.Pow(r, 3);
    }

    static public double CalculaVolumeCilindro(double raio, double altura){
        return 2*Math.PI*raio*altura;
        }
    }