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
        public class Vista_Materia
        {

            public int Codigo { get; set; }
            public string Denominacion { get; set; }
            public decimal Nota { get; set; }
            protected Alumno Al { get; set; }
            public void Apuntar_alumno(Alumno A) { Al = A; }
            public Alumno Obtener_alumno_apuntado() { return Al; }
            public event EventHandler Promedio_mas_nueve;


            public void f_promedio_mas_nueve(object sender, EventArgs e)
            {
                MessageBox.Show("Promedio de alumno mayor o igual a  nueve," + "Nombre = " + this.Obtener_alumno_apuntado().Nombre + " Apellido = " + this.Obtener_alumno_apuntado().Apellido + " Promedio = " + this.Promedio_aprobadas());

            }

            public List<Vista_Materia> Lista_mat_apro_temp = new List<Vista_Materia>();
            public List<Vista_Materia> Lista_mat_desapro_temp = new List<Vista_Materia>();
            public Vista_Materia(int pCodigo, string pDenominacion, decimal pNota)
            {
                Codigo = pCodigo;
                Denominacion = pDenominacion;
                Nota = pNota;

            }
            public Vista_Materia() { }
            public decimal Promedio_aprobadas()
            {
                decimal prom = 0;
                int contador = 0;
                if (Lista_mat_apro_temp.Count() > 0)
                {
                    foreach (Vista_Materia M in Lista_mat_apro_temp)

                    {
                        contador++;
                        prom += M.Nota;
                    }
                    prom = (prom / contador);

                }
                return prom;
            }

            public decimal Promedio_general()
            {
                decimal prom = 0;
                int contador = 0;
                if (Lista_mat_apro_temp.Count() > 0)
                {
                    foreach (Vista_Materia M in Lista_mat_apro_temp)

                    {
                        contador++;
                        prom += M.Nota;
                    }
                }


                if (Lista_mat_desapro_temp.Count() > 0)
                {
                    foreach (Vista_Materia M in Lista_mat_desapro_temp)

                    {
                        contador++;
                        prom += M.Nota;
                    }
                }

                if (contador > 0)

                { prom = prom / contador; }
                if (prom >= 9)
                { f_promedio_mas_nueve(this, null); }
                return prom;
            }

            public List<Vista_Materia> Mostrar_aprobadas(List<Materia> ListaM)
            {
                Lista_mat_apro_temp.Clear();
                if (ListaM.Count() > 0)
                {

                    foreach (Materia M in ListaM)
                    {
                        if (M.Obtener_nota() >= 4)

                        {
                            Vista_Materia VM = new Vista_Materia(M.Codigo, M.Denominacion, M.Obtener_nota());
                            VM.Apuntar_alumno(M.Leer_alumno_apuntado());
                            this.Lista_mat_apro_temp.Add(VM);

                        }

                    }

                }
                return Lista_mat_apro_temp;
            }

            public List<Vista_Materia> Mostrar_desaprobadas(List<Materia> ListaM)
            {
                this.Lista_mat_desapro_temp.Clear();
                if (ListaM.Count() > 0)
                {

                    foreach (Materia M in ListaM)
                    {
                        if ((M.Obtener_nota() < 4) && (M.Obtener_nota() > 0))

                        {
                            Vista_Materia VM = new Vista_Materia(M.Codigo, M.Denominacion, M.Obtener_nota());
                            VM.Apuntar_alumno(M.Leer_alumno_apuntado());
                            this.Lista_mat_desapro_temp.Add(VM);

                        }
                    }

                }
                return this.Lista_mat_desapro_temp;
            }
        }
    }
}
