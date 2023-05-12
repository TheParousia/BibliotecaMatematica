class Biblioteca{
    //Escdreva a sua função alterando o que for nescessário
    static public double NomeDaFuncao(){
        return 100;
    }
    static public double distanciaEntreDoisPontos(double x2, double x1, double y2, double y1){
        double distancia;
        distancia = Math.Sqrt (Math.Pow( x2 - x1, 2)  + Math.Pow( y2 - y1, 2 ));

        return distancia;
    }
}