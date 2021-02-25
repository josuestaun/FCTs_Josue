using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;

namespace CapaPresentacion
{
    public partial class FrmRetirarEmpresa : Form
    {
        public FrmRetirarEmpresa()
        {
            InitializeComponent();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void FrmRetirarEmpresa_Load(object sender, EventArgs e)
        {
            //lista nombre ciclos
            List<String> nombreCiclos = Program.gestion.DevolverCodigoCiclos(out string msj);
            if (msj != "")
            {
                //error
                MessageBox.Show(msj, "Atencion!");
            }
            else
            {
                //rellenar el cboCiclos
                foreach (String ciclo in nombreCiclos)
                {
                    cboCiclos.Items.Add(ciclo);
                }
            }
        }

        private void cboCiclos_SelectedIndexChanged(object sender, EventArgs e)
        {
            //lista nombre alumnos por ciclo
            cboAlumnosCiclo.Items.Clear();
            String id = cboCiclos.Text;
            List<String> alumnosPorCiclo = Program.gestion.DevolverNombreAlumnos(id, out string msg);
            if (msg != "")
            {
                //error
                MessageBox.Show(msg, "Atencion!");
            }
            else
            {
                //rellenar el cboAlumno
                foreach (String alumno in alumnosPorCiclo)
                {
                    cboAlumnosCiclo.Items.Add(alumno);
                }
            }
        }

        private void btnRetirarEmpresa_Click(object sender, EventArgs e)
        {

            //Compruebo que existe ciclo
            String msjCiclo = Program.gestion.ExisteCiclo(cboCiclos.Text);
            if (msjCiclo != "")
            {
                MessageBox.Show(msjCiclo, "Atencion!");
                return;
            }

            //Comprobar si existe alumno
            String msjAlumno = Program.gestion.ExisteAlumnoEnCiclo(cboAlumnosCiclo.Text, cboCiclos.Text);
            if (msjAlumno != "")
            {
                MessageBox.Show(msjAlumno, "Atencion!");
                return;
            }

            //Comprobar si Alumno ha aprobado el curso
            String msjAprobado = Program.gestion.AlumnoAprobado(cboAlumnosCiclo.Text);
            if (msjAprobado != "")
            {
                MessageBox.Show(msjAprobado, "Atencion!");
                return;
            }

            //El alumno no tiene asignada la empresa
            String msjAlumnoNoAsignado = Program.gestion.AlumnoNoAsignado(cboAlumnosCiclo.Text);
            if (msjAlumnoNoAsignado != "")
            {
                MessageBox.Show(msjAlumnoNoAsignado, "Atencion!");
                return;
            }

            //Preguntar si está seguro con un MessajeBox
            if (msjCiclo == "" && msjAlumno == "" && msjAlumno == "" && msjAlumnoNoAsignado == "")
            {
                //Obtengo el alumno para obtener el nombre de su empresa:
                Alumno alumno = Program.gestion.DevolverObjetoAlumno(cboAlumnosCiclo.Text);
                String empresa = alumno.FCT.Empresa.Nombre;

                //Preguntar si está seguro de eliminar la asignación
                DialogResult dialogResult = MessageBox.Show("El alumno " + cboAlumnosCiclo.Text + " tiene asignada la empresa " + empresa + "\n ¿Deseas eliminar la asignación?", "Atención", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    //Eliminar
                    String msj = Program.gestion.RetirarFCT(alumno.NMatricula);
                    if (msj != "")
                    {
                        MessageBox.Show(msj, "Atención");
                    }
                    else
                    {
                        MessageBox.Show("Se ha borrado la asignación del alumno " + cboAlumnosCiclo.Text + " a la empresa " + empresa);
                    }
                }
                else if (dialogResult == DialogResult.No)
                {

                }
                return;
            }
        }
    }
}
