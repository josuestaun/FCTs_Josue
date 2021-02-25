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
    public partial class FrmAsignarEmpresa : Form
    {
        
        public FrmAsignarEmpresa()
        {
            InitializeComponent();
        }
        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmAsignarEmpresa_Load(object sender, EventArgs e)
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
            //limpiar los demas comboBox
            cboAlumnosCiclo.Items.Clear();
            cboEmpresasCiclo.Items.Clear();
            cboAlumnosFcts.Items.Clear();
            cboProfes.Items.Clear();

            //lista nombre alumnos por ciclo
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

            //listar nomobre empresas
            List<String> empresasPorCiclo = Program.gestion.DevolverNombreEmpresas(id, out string mss);
            if (mss != "")
            {
                //error
                MessageBox.Show(mss, "Atencion!");
            }
            else
            {
                //rellenar el cboEmpresa
                foreach (String empresa in empresasPorCiclo)
                {
                    cboEmpresasCiclo.Items.Add(empresa);
                }
            }

            //listar nombre tutores
            List<String> tutoresPorCiclo = Program.gestion.DevolverNombreTutores(id, out string mess);
            if (mess != "")
            {
                //error
                MessageBox.Show(mess, "Atencion!");
            }
            else
            {
                foreach (String tutor in tutoresPorCiclo)
                {
                    cboProfes.Items.Add(tutor);
                }
            }

            //listar nombre alumnos sin asignar
            List<String> alumnosSinAsignar = Program.gestion.DevolerNombreAlumnosSinAsignar(id, out string msjAlumSinAsignar);
            if (msjAlumSinAsignar != "")
            {
                //error
                MessageBox.Show(msjAlumSinAsignar, "Atención");
            }
            else
            {
                foreach (String alum in alumnosSinAsignar)
                {
                    cboAlumnosFcts.Items.Add(alum);
                }
            }
        }

        private void btnAsignar_Click(object sender, EventArgs e)
        {
            //Compruebo que existe ciclo
            String msjCiclo = Program.gestion.ExisteCiclo(cboCiclos.Text);
            if (msjCiclo != "")
            {
                MessageBox.Show(msjCiclo, "Atencion!");
                return;
            }

            //Compruebo que existe tutor/tutora
            String msjTutor = Program.gestion.ExisteTutor(cboProfes.Text);
            if (msjTutor != "")
            {
                MessageBox.Show(msjTutor, "Atencion!");
                return;
            }

            //Compruebo que el alumno existe o está en ese ciclo
            String msjAlumno = Program.gestion.ExisteAlumnoEnCiclo(cboAlumnosCiclo.Text, cboCiclos.Text);
            if (msjAlumno != "")
            {
                MessageBox.Show(msjAlumno, "Atencion!");
                return;
            }

            //Compruebo que existe empresa
            String msjEmpresa = Program.gestion.ExisteEmpresa(cboEmpresasCiclo.Text);
            if (msjEmpresa != "")
            {
                MessageBox.Show(msjEmpresa, "Atencion!");
                return;
            }

            //Compruebo que empresa solicita alumnado para el ciclo
            String msjSolicitud = Program.gestion.EmpresaSolicita(cboEmpresasCiclo.Text, cboCiclos.Text);
            if (msjSolicitud != "")
            {
                MessageBox.Show(msjSolicitud, "Atencion!");
                return;
            }

            //Compruebo que el alumno ha aprobado
            String msjAprobado = Program.gestion.AlumnoAprobado(cboAlumnosCiclo.Text);
            if (msjAprobado != "")
            {
                MessageBox.Show(msjAprobado, "Atencion!");
                return;
            }

            //El alumno ya tiene asignada la empresa
            String msjAlumnoAsignado = Program.gestion.AlumnoAsignado(cboAlumnosCiclo.Text);
            if (msjAlumnoAsignado != "")
            {
                MessageBox.Show(msjAlumnoAsignado, "Atencion!");
                return;
            }

            //La empresa ya tiene asignados la cantidad de alumnos pedidos
            String msjEmpresaAsignada = Program.gestion.EmpresaAsignada(cboEmpresasCiclo.Text);
            if (msjEmpresaAsignada != "")
            {
                MessageBox.Show(msjEmpresaAsignada, "Atencion");
                return;
            }

            //Si no hay ningun mensaje de error, asigna la empresa
            if (msjCiclo == "" && msjTutor == "" && msjAlumno == "" && msjEmpresa == "" && msjSolicitud == "" && msjAprobado == "" && msjAlumnoAsignado == "" && msjEmpresaAsignada == "")
            {
                //Para crear la FCT necesito datos del alumno, de la Empresa y del profesor
                Alumno alumno = Program.gestion.DevolverObjetoAlumno(cboAlumnosCiclo.Text);
                Empresa empresa = Program.gestion.DevolverObjetoEmpresa(cboEmpresasCiclo.Text);
                Profe profesor = Program.gestion.DevolverObjetoProfesor(cboProfes.Text);

                //Creo la FCT
                FCT fct = new FCT(alumno.NMatricula, empresa.Id, profesor.Id, txtTutorEmpresa.Text);
                //La añado
                String msj = Program.gestion.InsertarFCT(fct);
                if (msj != "")
                {
                    MessageBox.Show(msj, "Atencion");
                }
                MessageBox.Show("Se ha asignado el alumno " + cboAlumnosCiclo.Text +  " a la empresa " + cboEmpresasCiclo.Text);
                return;
            }

        }
    }
}
