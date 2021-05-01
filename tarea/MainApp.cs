using System;

namespace tarea
{
    class MainApp
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
