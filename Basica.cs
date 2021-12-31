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

        public class Basica : Materia
        {

            public Basica(int pCodigo, string pDenominacion)
            {
                Codigo = pCodigo;
                Denominacion = pDenominacion;
                Nota = 0;                                         // se carga la materia con cero
                                                                  // esto indica que esta en curso y no                      
            }                                                     // tiene nota todavia

        }



    }
}
