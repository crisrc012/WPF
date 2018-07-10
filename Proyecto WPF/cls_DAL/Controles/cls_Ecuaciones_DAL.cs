using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cls_DAL.Controles
{
    public class cls_Ecuaciones_DAL
    {
        private float f_NumA, f_NumB, f_NumC, f_Resultado1, f_Discriminante;
        private float f_Resultado2a, f_Resultado2b;

        #region "Definiciones"
        public float fDiscriminante
        {
            get
            {
                return f_Discriminante;
            }

            set
            {
                f_Discriminante = value;
            }
        }

        public float fNumA
        {
            get
            {
                return f_NumA;
            }

            set
            {
                f_NumA = value;
            }
        }

        public float fNumB
        {
            get
            {
                return f_NumB;
            }

            set
            {
                f_NumB = value;
            }
        }

        public float fNumC
        {
            get
            {
                return f_NumC;
            }

            set
            {
                f_NumC = value;
            }
        }

        public float fResultado1
        {
            get
            {
                return f_Resultado1;
            }

            set
            {
                f_Resultado1 = value;
            }
        }

        public float fResultado2a
        {
            get
            {
                return f_Resultado2a;
            }

            set
            {
                f_Resultado2a = value;
            }
        }

        public float fResultado2b
        {
            get
            {
                return f_Resultado2b;
            }

            set
            {
                f_Resultado2b = value;
            }
        }
        #endregion

    }
}
