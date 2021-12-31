using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace Segundo_Parcial
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {


            combo_tipo_materia.SelectedItem = "Basica";


        }
        List<Alumno> Lista_alumnos = new List<Alumno>();
        Vista_Materia VistaM = new Vista_Materia();

        List<Materia> Lista_materias = new List<Materia>();



        public Alumno Buscar_alumno(int pLeg)
        {

            Alumno Alumnotemp = null;
            foreach (Alumno A in Lista_alumnos)
            {

                if (A.Legajo == pLeg)
                {
                    Alumnotemp = A;
                    break;
                }
            }

            return Alumnotemp;
        }







        public void Agregar_Alumno(Alumno Al)
        {
            Lista_alumnos.Add(Al);
        }



        public Materia Busca_materia(int pCod)
        {

            Materia R = null;
            foreach (Materia c in Lista_materias)
                if (c.Codigo == pCod)
                {

                    R = c;
                    break;
                }
            return R;
        }




        public int Consulta(List<Alumno> Al, int pLeg)
        {

            IEnumerable<Alumno> query;
            query =
                 from Alumno in Al
                 where Alumno.Legajo == pLeg
                 select Alumno;


            int cantidad = query.Count();
            return cantidad;

        }



        public void Actualizar_lista_alumnos()
        {
            grilla_alumnos.DataSource = null;
            grilla_alumnos.DataSource = Lista_alumnos;
        }
        public void Borrar_txt_alumno() { legajotxt.Clear(); apellidotxt.Clear(); nombretxt.Clear(); }
        public void Borrar_txt_materia() { codigotxt.Clear(); denominaciontxt.Clear(); }


        private void baja_alumno_btn_Click(object sender, EventArgs e)
        {
            try
            {
                if (Lista_alumnos.Count() != 0)
                {
                    int p = Convert.ToInt32(grilla_alumnos.Rows[grilla_alumnos.CurrentRow.Index].Cells[0].Value);
                    foreach (Alumno A in Lista_alumnos)
                    {
                        if (A.Legajo == p)

                        {
                            Lista_alumnos.Remove(A);
                            break;
                        }

                    }
                    Actualizar_lista_alumnos();

                }
                else
                { MessageBox.Show("Lista de alumnos vacia"); }

            }

            catch { MessageBox.Show("Error al dar de baja alumno"); }

        }




        private void alta_alumno_btn_Click(object sender, EventArgs e)

        {
            try
            {
                if (Consulta(Lista_alumnos, Convert.ToInt32(legajotxt.Text)) == 0)  // si retorna 1 el 
                {                                                              // alumno ya esta ingresado


                    {
                        Alumno A = new Alumno(Convert.ToInt32(legajotxt.Text), nombretxt.Text, apellidotxt.Text);
                        Agregar_Alumno(A);
                        Actualizar_lista_alumnos();
                        Borrar_txt_alumno();


                    }

                }
                else { MessageBox.Show("Alumno con legajo ya ingresado"); }

            }
            catch { MessageBox.Show("Error al cargar alumno"); }
        }

        private void alta_materia_btn_Click(object sender, EventArgs e)
        {
            try
            {
                int p = Convert.ToInt32(grilla_alumnos.Rows[grilla_alumnos.CurrentRow.Index].Cells[0].Value);
                //Busco primero si esta en la lista gral de materias
                if (Busca_materia(Convert.ToInt32(codigotxt.Text)) != null)     // si esta en la lista:

                {
                    if (Convert.ToString(combo_tipo_materia.SelectedItem) == "Basica")   // chequeo  el tipo de materia
                    {
                        if (Busca_materia(Convert.ToInt32(codigotxt.Text)) is Basica)   // si se  cargo ok como basica


                        { Buscar_alumno(p).Busca_materia_de_alumno(Convert.ToInt32(codigotxt.Text), Busca_materia(Convert.ToInt32(codigotxt.Text))); }  // chequeo si el alumno la tiene cargada (cursando o ya aprobada)

                        else { MessageBox.Show("la materia ya fue cargada con otro tipo en el sistema"); }                                                                                                             // si es asi muestra error, sino se carga   

                    }
                    if (Convert.ToString(combo_tipo_materia.SelectedItem) == "Especializada")  // chequeo  el tipo de materia
                    {
                        if (Busca_materia(Convert.ToInt32(codigotxt.Text)) is Especializada)    //si se  cargo ok como especializada

                        { Buscar_alumno(p).Busca_materia_de_alumno(Convert.ToInt32(codigotxt.Text), Busca_materia(Convert.ToInt32(codigotxt.Text))); }  // chequeo si el alumno la tiene cargada (cursando o ya aprobada)

                        else { MessageBox.Show("la materia ya fue cargada con otro tipo en el sistema"); }                                                                                                          // si es asi muestra error, sino se carga   



                    }



                }
                else                      // no esta en la lista general de materias
                {

                    if (Convert.ToString(combo_tipo_materia.SelectedItem) == "Basica")


                    {
                        Basica B = new Basica(Convert.ToInt32(codigotxt.Text), denominaciontxt.Text);
                        Lista_materias.Add(B);
                        Borrar_txt_materia();
                        int Leg = Convert.ToInt32(grilla_alumnos.Rows[grilla_alumnos.CurrentRow.Index].Cells[0].Value);
                        Buscar_alumno(Leg).Agregar_materia_alumno(B);

                    }
                    else
                    {
                        Especializada E = new Especializada(Convert.ToInt32(codigotxt.Text), denominaciontxt.Text);
                        Lista_materias.Add(E);
                        Borrar_txt_materia();
                        int Leg = Convert.ToInt32(grilla_alumnos.Rows[grilla_alumnos.CurrentRow.Index].Cells[0].Value);
                        Buscar_alumno(Leg).Agregar_materia_alumno(E);

                    }

                }



                Borrar_txt_materia();
                grilla_alumnos_CellClick(this, null);
            }

            catch { MessageBox.Show("Error al realizar el alta de materias"); }
        }
        private void ordena_apellido_az_Click(object sender, EventArgs e)
        {
            Lista_alumnos.Sort(new Alumno.ApellidoASC());
            Actualizar_lista_alumnos();
        }

        private void ordena_apellido_za_Click(object sender, EventArgs e)
        {
            Lista_alumnos.Sort(new Alumno.ApellidoDSC());
            Actualizar_lista_alumnos();
        }

        private void Fpromedio_mas_nueve() { MessageBox.Show("promedio mayor a nueve"); }


        private void grilla_alumnos_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            try
            {
                int p = Convert.ToInt32(grilla_alumnos.Rows[grilla_alumnos.CurrentRow.Index].Cells[0].Value);

                grilla_mat_en_curso.DataSource = null;
                grilla_mat_en_curso.DataSource = Buscar_alumno(p).Retorna_materias_en_curso();

                grilla_materias_aprobadas.DataSource = null;
                grilla_materias_aprobadas.DataSource = VistaM.Mostrar_aprobadas(Buscar_alumno(p).Retorna_materias());
                grilla_materias_desaprobadas.DataSource = null;
                grilla_materias_desaprobadas.DataSource = VistaM.Mostrar_desaprobadas(Buscar_alumno(p).Retorna_materias());

                VistaM.Apuntar_alumno(Buscar_alumno(p));
                prom_mat_aprobadastxt.Text = Convert.ToString(VistaM.Promedio_aprobadas());

                prom_mat_generaltxt.Text = Convert.ToString(VistaM.Promedio_general());
                VistaM.Promedio_mas_nueve += VistaM.f_promedio_mas_nueve;
                VistaM.Promedio_mas_nueve -= VistaM.f_promedio_mas_nueve;
            }
            catch { }
        }

        private void agregar_nota_btn_Click(object sender, EventArgs e)
        {

            try
            {
                Regex validar = new Regex("^[0.1]*?[1-9](,5)*?$");
                if ((validar.IsMatch(notatxt.Text)) && Convert.ToDecimal(notatxt.Text) <= 10)
                {
                    int m = Convert.ToInt32(grilla_mat_en_curso.Rows[grilla_mat_en_curso.CurrentRow.Index].Cells[0].Value);
                    int p = Convert.ToInt32(grilla_alumnos.Rows[grilla_alumnos.CurrentRow.Index].Cells[0].Value);

                    if ((Buscar_alumno(p).Comprueba_desaprobadas(Buscar_alumno(p).Retorna_materia_nota(m)) == true))
                    {

                        Buscar_alumno(p).Agregar_materia_alumno(Buscar_alumno(p).Retorna_materia_nota(m));

                    }
                    else { Buscar_alumno(p).Retorna_materia_nota(m).Cargar_nota(Convert.ToDecimal(notatxt.Text)); }
                    grilla_alumnos_CellClick(this, null);
                    notatxt.Clear();
                }
                else { MessageBox.Show("Nota no valida solo se admite del 1 a 10 con opcional decimal 0,5 por ejemplo=8,5"); notatxt.Clear(); }

            }
            catch
            {
                MessageBox.Show("Error al cargar nota a alumno");
                notatxt.Clear();
            }
        }


    }
}
