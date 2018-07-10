using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using cls_DAL.Controles;
namespace cls_BLL.Controles
{
    public class cls_Ecuaciones_BLL
    {
        public void Discriminante(ref cls_Ecuaciones_DAL Obj_Ecuaciones)
        {
            Obj_Ecuaciones.fDiscriminante = 
                Convert.ToSingle(Math.Round((Math.Pow(Obj_Ecuaciones.fNumB, 2)) - 
                (4 * (Obj_Ecuaciones.fNumA) * (Obj_Ecuaciones.fNumC)), 2));
        }
        public void Solucion1(ref cls_Ecuaciones_DAL Solucion1)
        {
            Solucion1.fResultado1 = -(Solucion1.fNumB) / (2 * Solucion1.fNumA);
        }
        public void Solucion2(ref cls_Ecuaciones_DAL Solucion2)
        {
            Solucion2.fResultado2a = Convert.ToSingle(Math.Round((-(Solucion2.fNumB)
                + Math.Sqrt(Solucion2.fDiscriminante)) / (2 * Solucion2.fNumA), 2));

            Solucion2.fResultado2b = Convert.ToSingle(Math.Round((-(Solucion2.fNumB)
                - Math.Sqrt(Solucion2.fDiscriminante)) / (2 * Solucion2.fNumA), 2));
        }
    }
}
