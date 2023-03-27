using System.Collections.Generic;
menu();
static void menu()
{
    int usu = 0;
    Dictionary<char, int> dineroCurso = new Dictionary<char, int>();
    while(usu != 3)
    {
     Console.WriteLine("1- Ingrese los importes de un curso "+ Environment.NewLine+"2- Ver estadísticas"+ Environment.NewLine+ "3- Salir");
     usu = ingresarInt("Ingresa a que menu desea entrar");
     while(usu != 1 & usu != 2 & usu != 3)
     {
        usu = ingresarInt("Numero no valido, ingrese otro");
     }
     if(usu == 1)
     {
        char curso = ingresarChar("Ingrese a que curso pertenece");
        int nEstu = ingresarInt("Ingrese la cantidad de estudiantes");
        int recaudacion = recCurso(curso,nEstu);
        dineroCurso.Add(curso,recaudacion);            
     }
     else if(usu == 2)
     {
        calcustats(dineroCurso);
     }
    }
   
}

static int ingresarInt(string msj)
{
    Console.WriteLine(msj);
    int n = int.Parse(Console.ReadLine());
    return n;
}

static char ingresarChar(string msj)
{
    Console.WriteLine(msj);
    char i = char.Parse(Console.ReadLine());
    return i;
}

static int recCurso(char curso, int nEstu)
{
    int total = 0;
    for(int n = 0;n<nEstu;n++)
    {
        int plataE = ingresarInt("Ingrese el dinero del regalo");
        total = total+plataE;
    }
    return total;
}

static void calcustats(Dictionary<char, int> dineroCurso)
{
    int masP = 0, cantC = 0, total = 0;
    char masC = 'a';
    foreach(char clave in dineroCurso.Keys)
    {
        if(dineroCurso[clave] > masP)
        {
            masP = dineroCurso[clave];
            masC = clave;
        }
        total = total + dineroCurso[clave];
        cantC++;
    }
    stats(masC,masP,total,cantC);
}

static void stats(char masC, int masP, int total, int cantC)
{
    int promedio = total/cantC;
    Console.WriteLine("El curso que mas plata puso fue el " + masC + " con " + masP + '$');
    Console.WriteLine("Promedio de la plata dada por los cursos es de " + promedio);
    Console.WriteLine("El total recaudado fue de " + total + "$");
    Console.WriteLine("Fueron un total de " + cantC + " cursos");   
}