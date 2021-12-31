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

        public class Alumno
        {

            public int Legajo { get; set; }
            public string Nombre { get; set; }
            public string Apellido { get; set; }
            protected List<Materia> Materias_alumno = new List<Materia>();  // lista de materias del alumno

            public Alumno(int pLegajo, string pNombre, string pApellido)
            {

                Legajo = pLegajo;
                Nombre = pNombre;
                Apellido = pApellido;

            }

            public class ApellidoASC : IComparer<Alumno>
            {
                public int Compare(Alumno x, Alumno y) { return string.Compare(x.Apellido, y.Apellido); }


            }

            public class ApellidoDSC : IComparer<Alumno>
            {
                public int Compare(Alumno x, Alumno y) { return string.Compare(x.Apellido, y.Apellido) * -1; }
            }

            public void Agregar_materia_alumno(Materia M)
            {
                Materia Ma = (Materia)M.Clone();

                this.Materias_alumno.Add(Ma);

            }

            public List<Materia> Retorna_materias() { return this.Materias_alumno; }
            public bool Comprueba_desaprobadas(Materia M)
            {
                bool cont = false;
                foreach (Materia Ma in Materias_alumno)
                {
                    if (Ma.Obtener_nota() < 4 && Ma.Obtener_nota() > 1 && Ma.Codigo == M.Codigo)


                    {
                        cont = true;
                        break;
                    }


                }
                return cont;
            }
            public Materia Retorna_materia_nota(int pCod)


            {
                Materia Mat_temp = null;
                foreach (Materia M in this.Materias_alumno)
                {
                    if (pCod == M.Codigo)
                    {
                        Mat_temp = M;
                        break;
                    }
                }
                return Mat_temp;
            }


            public List<Materia> Retorna_materias_en_curso()
            {
                List<Materia> Mat_temp = new List<Materia>();
                foreach (Materia Ma in this.Materias_alumno)
                {
                    if (Ma.Obtener_nota() == 0)
                    {
                        Mat_temp.Add(Ma);
                    }

                }
                return Mat_temp;
            }
            public void Busca_materia_de_alumno(int pCod, Materia C)
            {
                bool flag = false;
                foreach (Materia M in this.Materias_alumno)
                {
                    if ((M.Codigo == pCod && M.Obtener_nota() >= 4))
                    {
                        MessageBox.Show("Materia ya cargada y aprobada");
                        flag = true;
                        break;
                    }

                    if (M.Codigo == pCod && M.Obtener_nota() == 0)

                    {
                        MessageBox.Show("Materia ya cargada en curso");
                        flag = true;
                        break;
                    }

                }
                if (flag == false)
                { this.Agregar_materia_alumno(C); }
            }


        }



    }


}
