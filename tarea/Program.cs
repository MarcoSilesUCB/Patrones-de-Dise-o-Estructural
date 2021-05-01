using System;

namespace tarea
{
    class Program
    {
        static void Main(string[] args)
        {
            Target Itarget = new AdaptadorEstado();
            NuevoPrograma prueba = new NuevoPrograma(Itarget);
            prueba.MostrasEstados();

            Console.ReadKey();
        }
    }
}
