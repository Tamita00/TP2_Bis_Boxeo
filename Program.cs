int seleccion = IngresarIntDesdeHasta("Ingresá la opción que quieras:", 1, 5);
Boxeador boxeador1 = new Boxeador(), boxeador2 = new Boxeador();
string precargadoOno;
bool precargado = true;
while(seleccion!=5){
switch(seleccion){
    case 1:
        precargadoOno = IngresarString("Ingresá S si querés que el boxeador tenga precargados sus atributos físicos o N si no");
        boxeador1 = CargarDatosBoxeador(precargado);
        break;
    case 2:
        precargadoOno = IngresarString("Ingresá S si querés que el boxeador tenga precargados sus atributos físicos o N si no");
        if(precargadoOno == "N") precargado = false;
        boxeador2 = CargarDatosBoxeador(precargado);
        break;
    case 3:
    if(boxeador1 ==null || boxeador2 == null) Console.WriteLine("Falta ingresar los datos de alguno de los dos boxeadores");
    else Pelear(boxeador1, boxeador2);
        break;
    case 4:
    seleccion = IngresarIntDesdeHasta("Ingresá el número del boxeador al que le quieras cambiar la velocidad de las piernas y potencia de los golpes", 1, 3);
    if(seleccion == 1)CambiarVelocidadPiernasPotenciaGolpe(ref boxeador1, boxeador2);
    else if(seleccion == 2)CambiarVelocidadPiernasPotenciaGolpe(ref boxeador2, boxeador1);
    else Console.WriteLine("El boxeador no existe");
        break;

}
seleccion = IngresarIntDesdeHasta("Ingresá la opción que quieras:", 1, 5);
}

Boxeador CargarDatosBoxeador(bool precargado){
    Boxeador boxeador = new Boxeador();
    if(precargado){
    string nombre = IngresarString("Ingresá el nombre del boxeador:");
    string pais = IngresarString("Ingresá el país de origen del boxeador:");
    int peso = IngresarIntPositivo("Ingresá el peso del boxeador:");
    int inteligencia = IngresarIntPositivo("Ingresá la Inteligencia del boxeador");
    boxeador = new Boxeador(nombre, pais, peso, inteligencia);
    }
    else{
    string nombre = IngresarString("Ingresá el nombre del boxeador:");
    string pais = IngresarString("Ingresá el país de origen del boxeador:");
    int peso = IngresarIntPositivo("Ingresá el peso del boxeador:");
    int velocidadPiernas = IngresarIntDesdeHasta("Ingresá la velocidad de las piernas del boxeador: ", 1, 100);
    int potenciaGolpes = IngresarIntDesdeHasta("Ingresá la potencia de los golpes del boxeador: ", 1, 100);
    int inteligencia = IngresarIntPositivo("Ingresá la Inteligencia del boxeador");
    boxeador = new Boxeador(nombre, pais, peso, potenciaGolpes, velocidadPiernas, inteligencia);
    }
    return boxeador;
}

void CambiarVelocidadPiernasPotenciaGolpe(ref Boxeador boxeadorElegido, Boxeador otroBoxeador){
    boxeadorElegido.velocidadPiernas = IngresarIntDesdeHasta("Ingresá la nueva velocidad de las piernas del boxeador: ", 1, 100);
    boxeadorElegido.potenciaGolpes = IngresarIntDesdeHasta("Ingresá la nueva potencia de los golpes del boxeador: ", 1, 100);
    if(boxeador1 ==null || boxeador2 == null) Console.WriteLine("Falta ingresar los datos de alguno de los dos boxeadores");
    else Pelear(boxeadorElegido, otroBoxeador);
}

static int IngresarIntPositivo(string msg)
{
	int num;
	Console.WriteLine(msg);
	num = int.Parse(Console.ReadLine());
	while(num<0)
	{
	Console.WriteLine(msg);
	num = int.Parse(Console.ReadLine());
	}
	return num;
}

static int IngresarIntDesdeHasta(string msg, int desde, int hasta)
{
	int num;
	Console.WriteLine(msg);
	num = int.Parse(Console.ReadLine());
	while(num < desde || num > hasta)
	{
	Console.WriteLine(msg);
	num = int.Parse(Console.ReadLine());
	}
	return num;
}

static string IngresarString(string msg)
{
	Console.WriteLine(msg);
	return Console.ReadLine();
}
void Pelear(Boxeador boxeador1, Boxeador boxeador2){
    double skill1 = boxeador1.ObtenerSkill(), skill2 = boxeador2.ObtenerSkill(), diferencia = 0;
    Boxeador ganador;
    if (skill1 > skill2){
    diferencia = skill1 - skill2;
    ganador = boxeador1;
    }
    else{
    diferencia = skill2 - skill1;
    ganador = boxeador2;
    }
    if(diferencia >= 30) Console.WriteLine("Ganó " + ganador.nombre + " por KO");
    else if(diferencia >= 10) Console.WriteLine("Ganó " + ganador.nombre + " por puntos en fallo unánime");
    else Console.WriteLine("Ganó " + ganador.nombre + " por puntos en fallo dividido");

}