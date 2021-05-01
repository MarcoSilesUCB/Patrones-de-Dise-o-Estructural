using System.Collections.Generic;

namespace tarea
{
    public class AdaptadorEstado : Estados, ITarget
    {
        public bool ObtenerEstadosBooleanos()
        {
            int[] estados = ObetenerPuntajes();
            bool[] estadosBools = new bool[estados.Length];
            int cont = 0;
            foreach (int estado in estados)
            {
                if(estado==0)
                {
                    estadosBools[cont]=false;
                }
                else
                {
                    estadosBools[cont]=true;
                }
                cont++;
            }

            return estadosBools;
        }

    }
}