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
        public class Materia : ICloneable
        {
            public int Codigo { get; set; }
            public string Denominacion { get; set; }
            protected decimal Nota { get; set; }
            protected Alumno Al { get; set; }
            public object Clone() { return this.MemberwiseClone(); }
            public void Apuntar_alumno(Alumno A) { Al = A; }
            public Alumno Leer_alumno_apuntado() { return Al; }
            public decimal Obtener_nota() { return Nota; }
            public void Cargar_nota(decimal pNota)
            {


                if (this is Especializada && pNota >= 6 && pNota <= 9)
                { Nota = pNota + 1; }
                else { Nota = pNota; }

            }
        }



    }


}
