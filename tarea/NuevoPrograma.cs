using System;
using System.Collections.Generic;

namespace tarea
{
    public class NuevoPrograma
    {
        private ITarget _recursoEstado;

        public NuevoPrograma(ITarget recursoEstado)
        {
            this._recursoEstado = recursoEstado;
        }

        public void MostrasEstados()
        {
            bool[] estados = _recursoEstado.ObtenerEstadosBooleanos();

            Console.WriteLine("######### Lista de Estados ##########");
            foreach (var item in estados)
            {
                if(item)
                {
                    Console.Write("Esta en buen estado");
                }
                else
                {
                    Console.Write("Esta en mal estado");
                }
                
            }

        }
    }
}