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
    public partial class FrmConsultasPorCiclo : Form
    {
        public FrmConsultasPorCiclo()
        {
            InitializeComponent();
        }

        private void cboCiclos_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Obtengo el ciclo seleccionado
            String id = cboCiclos.SelectedItem.ToString();
            Ciclo cicloSeleccionado = Program.gestion.DevolverCiclo(id, out string msj);
            if (msj != "")
            {
                //error
                MessageBox.Show(msj, "Atencion!");
            }
            else
            {
                //poner nombre ciclo
                lblNombreCiclo.Text = cicloSeleccionado.Nombre;

                //numero alumnos del ciclo
                lblAlumnosCiclo.Text = cicloSeleccionado.Alumnos.Count.ToString();

                //numero alumnos asignados
                //no me funciona
                int numAlumnosAsignados = cicloSeleccionado.Alumnos.Count(al => al.FCT != null);
                lblAsignados.Text = numAlumnosAsignados.ToString();

                //Datos alumnos/as del ciclo
                List<Alumno> alumnos = Program.gestion.DevolverAlumnos(id, out string msg);
                if (msg != "")
                {
                    MessageBox.Show(msg, "Atencion!");
                }
                else
                {
                    dgvAlumnosCiclo.DataSource = (from alum in alumnos
                                      select new { alum.Nombre, alum.Telefono, alum.Aprobado }).ToList();
                }

                //Datos empresas del ciclo
                List<Empresa> empresas = Program.gestion.DevolverEmpresas(id, out string mss);
                if (mss != "")
                {
                    MessageBox.Show(mss, "Atencion!");
                }
                else
                {
                    //muestro nombre, telefono, solicitudes y asignadas.
                    dgvOfertas.DataSource = (from emp in empresas
                                             select new { emp.Nombre, emp.TelefonoContacto, Solicitudes = emp.OfertasFCTs.Count, Asignadas = emp.FCTs.Count }).ToList();
                }

                //Datos de los Alumnos del ciclo con empresa ya asignada
                List<Alumno> alumnosAsignados = Program.gestion.DevolverAlumnosAsignados(id, out string message);
                if (message != "")
                {
                    MessageBox.Show(message, "Atencion!");
                }
                else
                {
                    //muestro nombre, telefono, solicitudes y asignadas.
                    dgvAlumnosEmpresa.DataSource = (from alumn in alumnosAsignados
                                             select new { alumn.Nombre, Empresa = alumn.FCT.Empresa.Nombre}).ToList();
                }
            }
        }

        private void FrmConsultasPorCiclo_Load(object sender, EventArgs e)
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

    }
}
