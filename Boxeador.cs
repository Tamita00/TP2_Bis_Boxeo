class Boxeador{
    //propiedades
    public string nombre {get;set;}
    public string pais {get;set;}
    public int peso {get;set;}
    public int potenciaGolpes {get;set;}
    public int velocidadPiernas {get;set;}
    public int inteligencia {get;set;}
    //constructores
    public Boxeador(){}
    public Boxeador(string nombreRecibido, string paisRecibido, int pesoRecibido, int inteligenciaRecibida){
        nombre = nombreRecibido;
      pais = paisRecibido;
      peso = pesoRecibido;
      potenciaGolpes = Rndm(1, 100);
      velocidadPiernas = Rndm(1, 100); 
      inteligencia = inteligenciaRecibida;
    }
    public Boxeador (string nombreRecibido, string paisRecibido, int pesoRecibido, int potenciaGolpesRecibida, int velocidadPiernasRecibida, int inteligenciaRecibida){
      nombre = nombreRecibido;
      pais = paisRecibido;
      peso = pesoRecibido;
      potenciaGolpes = potenciaGolpesRecibida;
      velocidadPiernas = velocidadPiernasRecibida; 
      inteligencia = inteligenciaRecibida;
    }
    static int Rndm(int desde, int hasta)
{
	Random num= new Random ();
	return num.Next (desde, hasta + 1);
}
    //metodos
    public double ObtenerSkill (){
        Random num= new Random ();
        return velocidadPiernas * 0.6 + potenciaGolpes * 0.8 + num.Next(1, 11) + inteligencia * 0.25;
}
}