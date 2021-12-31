using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Segundo_Parcial
{
    public partial class Form1 : Form
    {
        public class Especializada : Materia
        {

            public Especializada(int pCodigo, string pDenominacion)
            {
                Codigo = pCodigo;
                Denominacion = pDenominacion;
                Nota = 0;
            }

            new public void Cargar_nota(decimal pNot)
            {

                if (pNot <= 9 && pNot >= 6)

                { Nota = pNot + 1; }
            }

        }



    }
}
