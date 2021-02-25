using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;

namespace CapaDatos
{
    public class GestionDatos
    {
        BdFCTsEntities bdFCTsEntities = new BdFCTsEntities();

        public GestionDatos()
        {

        }
        //Devolver lista de ciclos
        public List<Ciclo> DevolverCiclos(out string msj)
        {
            msj = "";
            List<Ciclo> listaCiclos = new List<Ciclo>();
            try
            {
                listaCiclos = bdFCTsEntities.Ciclos.ToList();
            }
            catch (Exception e)
            {
                msj = e.Message;
            }
            return listaCiclos;
        }

        //Devolver lista de nombre de ciclos
        public List<String> DevolverCodigoCiclos(out string msj)
        {
            msj = "";
            List<String> nombreCiclos = new List<string>();
            try
            {
                nombreCiclos = bdFCTsEntities.Ciclos.Select(cic => cic.Id).ToList();
            }
            catch (Exception e)
            {
                msj = e.Message;
            }
            return nombreCiclos;
        }

        //Devuelve ciclo por id
        public Ciclo DevolverCiclo(String id, out string msj)
        {
            msj = "";
            Ciclo ciclo = new Ciclo();
            try
            {
                ciclo = bdFCTsEntities.Ciclos.Find(id);
            }
            catch (Exception e)
            {
                msj = e.Message;
            }
            return ciclo;
        }

        //Devolver lista alumnos por id ciclo
        public List<Alumno> DevolverAlumnos(string id, out string msj)
        {
            msj = "";
            List<Alumno> alumnosPorCiclo = new List<Alumno>();
            try
            {
                alumnosPorCiclo = bdFCTsEntities.Ciclos.Find(id).Alumnos.OrderByDescending(al => al.Aprobado).ThenBy(al => al.Nombre).ToList();
            }
            catch (Exception e)
            {
                msj = e.Message;
            }
            return alumnosPorCiclo;
        }

        //Devolver lista empresas por id ciclo
        public List<Empresa> DevolverEmpresas(string id, out string msj)
        {
            msj = "";
            List<OfertasFCT> ofertasPorCiclo = new List<OfertasFCT>();
            List<Empresa> empresasPorCiclo = new List<Empresa>();
            try
            {
                ofertasPorCiclo = bdFCTsEntities.Ciclos.Find(id).OfertasFCTs.ToList();
                empresasPorCiclo = ofertasPorCiclo.Select(of => of.Empresa).OrderBy(em => em.Nombre).ToList();
            }
            catch (Exception e)
            {
                msj = e.Message;
            }
            return empresasPorCiclo;
        }

        //devuelve una lista de los nombres de los alumnos de un ciclo
        public List<String> DevolverNombreAlumnos(string id, out string msj)
        {
            msj = "";
            List<String> nombreAlumnosPorCiclo = new List<String>();
            try
            {
                nombreAlumnosPorCiclo = bdFCTsEntities.Ciclos.Find(id).Alumnos.OrderByDescending(al => al.Aprobado).ThenBy(al => al.Nombre).Select(al => al.Nombre).ToList();
            }
            catch (Exception e)
            {
                msj = e.Message;
            }
            return nombreAlumnosPorCiclo;
        }

        public List<String> DevolerNombreAlumnosSinAsignar(string idCiclo, out string msj)
        {
            msj = "";
            List<String> nombreAlumnosSinAsignar = new List<string>();
            try
            {
                nombreAlumnosSinAsignar = bdFCTsEntities.Ciclos.Find(idCiclo).Alumnos.Where(al => al.FCT == null).Select(alum => alum.Nombre).ToList();
            }
            catch (Exception e)
            {
                msj = e.Message;
            }
            return nombreAlumnosSinAsignar;
        }

        //deuvuelve una lista de los nombres de las empresas para un ciclo
        public List<String> DevolverNombreEmpresas(string id, out string msj)
        {
            msj = "";
            List<OfertasFCT> ofertasPorCiclo = new List<OfertasFCT>();
            List<String> nombreEmpresasPorCiclo = new List<String>();
            try
            {
                ofertasPorCiclo = bdFCTsEntities.Ciclos.Find(id).OfertasFCTs.ToList();
                nombreEmpresasPorCiclo = ofertasPorCiclo.Select(of => of.Empresa).OrderBy(em => em.Nombre).Select(em => em.Nombre).ToList();
            }
            catch (Exception e)
            {
                msj = e.Message;
            }
            return nombreEmpresasPorCiclo;
        }

        //deuvuelve una lista de los nombres de los tutores para un ciclo
        public List<String> DevolverNombreTutores(string id, out string msj)
        {
            msj = "";
            List<Alumno> alumnosPorCiclo = new List<Alumno>();
            List<String> nombreTutores = new List<String>();
            try
            {
                alumnosPorCiclo = bdFCTsEntities.Ciclos.Find(id).Alumnos.ToList();
                //no funciona asi:
                //nombreTutores = alumnosPorCiclo.Select(fce => fce.FCT != null).Select(fc => fc.TutorInsti).ToList();
                nombreTutores = bdFCTsEntities.Profes.Select(p => p.Nombre).ToList();
            }
            catch (Exception e)
            {
                msj = e.Message;
            }
            return nombreTutores;
        }

        public List<Alumno> DevolverAlumnosAsignados(string id, out string msj)
        {
            msj = "";
            List<Alumno> alumnosAsignados = new List<Alumno>();
            try
            {
                alumnosAsignados = bdFCTsEntities.Ciclos.Find(id).Alumnos.Where(al => al.FCT != null).ToList();
            }
            catch (Exception e)
            {
                msj = e.Message;
            }
            return alumnosAsignados;
        }

        //Comprobar que existe ciclo
        public String ExisteCiclo(String id)
        {
            String msj = "";
            if (!bdFCTsEntities.Ciclos.Any(cic => cic.Id.ToUpper() == id.ToUpper())){
                msj = "El ciclo " + id + " no existe.";
            }
            return msj;
        }

        //Comprobar si existe Profesor
        public String ExisteTutor(String nombre)
        {
            String msj = "";
            if (!bdFCTsEntities.Profes.Any(prof => prof.Nombre.ToUpper() == nombre.ToUpper())){
                msj = "El profesor " + nombre + " no existe.";
            }
            return msj;
        }

        public String ExisteAlumnoEnCiclo(String nombreAlumn, String idCiclo)
        {
            String msj = "";
            //Compruebo si alumno existe en el ciclo
            Alumno alumno = bdFCTsEntities.Alumnos.SingleOrDefault(al => al.Nombre.ToUpper() == nombreAlumn.ToUpper());
            if (alumno == null)
            {
                msj = "El alumno " + nombreAlumn + " no existe.";
                return msj;
            }
            else if (alumno.IdCiclo != idCiclo)
            {
                msj = "El alumno " + nombreAlumn + " no está en el ciclo " + idCiclo;
            }
            return msj;
        }

        //COmprobar si la empresa existe
        public String ExisteEmpresa(String nombreEmpresa)
        {
            String msj = "";
            if (!bdFCTsEntities.Empresas.Any(emp => emp.Nombre.ToUpper() == nombreEmpresa.ToUpper())){
                msj = "La empresa " + nombreEmpresa + " no existe.";
            }
            return msj;
        }

        //Comprobar si la empresa tiene ofertas
        public String EmpresaSolicita(String nombreEmpresa, String idCiclo)
        {
            String msj = "";
            Empresa empresa = bdFCTsEntities.Empresas.SingleOrDefault(emp => emp.Nombre.ToUpper() == nombreEmpresa.ToUpper());
            if (empresa == null)
            {
                msj = "La empresa no existe";
                return msj;
            }
            OfertasFCT oferta = bdFCTsEntities.OfertasFCTs.SingleOrDefault(of => of.IdCiclo.ToUpper() == idCiclo.ToUpper() && of.IdEmpresa == empresa.Id);
            if (oferta == null)
            {
                msj = "La empresa " + nombreEmpresa + " no tiene ofertas para el ciclo " + idCiclo;
            }
            return msj;
        }

        //Devolver si alumno ha aprobado
        public String AlumnoAprobado(String nombreAlumno)
        {
            String msj = "";
            Alumno alumno = bdFCTsEntities.Alumnos.SingleOrDefault(al => al.Nombre.ToUpper() == nombreAlumno.ToUpper());
            if (alumno == null)
            {
                msj = "El alumno no existe";
                return msj;
            }
            else if (!alumno.Aprobado)
            {
                msj = "El alumno " + nombreAlumno + " no ha aprobado el ciclo.";
            }
            return msj;
        }
        
        //Comprobar si un alumno ya esta asignado a una empresa
        public String AlumnoAsignado(String nombreAlumno)
        {
            String msj = "";
            Alumno alumno = bdFCTsEntities.Alumnos.SingleOrDefault(al => al.Nombre.ToUpper() == nombreAlumno.ToUpper());
            if (alumno == null)
            {
                msj = "El alumno no existe";
            }
            else if (alumno.FCT != null)
            {
                String empresa = alumno.FCT.Empresa.Nombre;
                msj = "El alumno " + nombreAlumno + " ya tiene asignada la empresa " + empresa;
            }
            return msj;
        }

        //Comprobar si alumno no tiene asignada una empresa
        public String AlumnoNoAsignado(String nombreAlumno)
        {
            String msj = "";
            Alumno alumno = bdFCTsEntities.Alumnos.SingleOrDefault(al => al.Nombre.ToUpper() == nombreAlumno.ToUpper());
            if (alumno == null)
            {
                msj = "El alumno no existe";
            }
            else if (alumno.FCT == null)
            {
                msj = "El alumno " + nombreAlumno + " no tiene asignada ninguna empresa";
            }
            return msj;
        }

        //Comprobar si una empresa ya tiene todas sus ofertas asignadas
        public String EmpresaAsignada(String nombreEmpresa)
        {
            String msj = "";
            Empresa empresa = bdFCTsEntities.Empresas.SingleOrDefault(emp => emp.Nombre.ToUpper() == nombreEmpresa.ToUpper());
            if (empresa == null)
            {
                msj = "La empresa no existe";
                return msj;
            }
            int numOfertas = empresa.OfertasFCTs.Count;
            int numFCTs = empresa.FCTs.Count;
            if (numFCTs >= numOfertas)
            {
                msj = "La empresa " + nombreEmpresa + " ya tiene asignados el/los " + numOfertas + " alumnos/as pedidos";
            }
            return msj;
        }

        //Devolver objeto alumno
        public Alumno DevolverObjetoAlumno(String nombreAlumno)
        {
            Alumno alumno = bdFCTsEntities.Alumnos.Single(al => al.Nombre.ToUpper() == nombreAlumno.ToUpper());
            return alumno;
        }

        //Devolver objeto empresa
        public Empresa DevolverObjetoEmpresa(String nombreEmpresa)
        {
            Empresa empresa = bdFCTsEntities.Empresas.Single(em => em.Nombre.ToUpper() == nombreEmpresa.ToUpper());
            return empresa;
        }

        //Devolver objeto profesor
        public Profe DevolverObjetoProfesor(String nombreProfesor)
        {
            Profe profesor = bdFCTsEntities.Profes.Single(prof => prof.Nombre.ToUpper() == nombreProfesor.ToUpper());
            return profesor;
        }

        //Metodo para añadir una nueva FCT de un alumno a una empresa
        public String InsertarFCT2()
        {
            String msj = "";
            FCT fct = new FCT(999, 10, "Abilio", "Juan");
            bdFCTsEntities.FCTs.Add(fct);
            bdFCTsEntities.SaveChanges();
            return msj;
        }
        public String InsertarFCT(FCT fctParaAsignar)
        {
            String msj = "";
            //creo la FCT
            FCT fct = new FCT(fctParaAsignar.NMatricula, fctParaAsignar.IdEmpresa, fctParaAsignar.TutorInsti, fctParaAsignar.TutorEmpresa);

            //Añadir FCT
            bdFCTsEntities.FCTs.Add(fct);
            try
            {
                //Error al guardar los cambios en la base de datos
                int nAfectados = bdFCTsEntities.SaveChanges();
            }
            catch (Exception e)
            {
                msj = e.Message;
            }
            return msj;
        }

        public String RetirarFCT(int numMatricula)
        {
            String msj = "";
            //En la Tabla FCT busco la FCT con el numMatricula
            FCT fct = bdFCTsEntities.FCTs.Find(numMatricula);
            if (fct == null)
            {
                msj = "No existe la fct";
                return msj;
            }
            bdFCTsEntities.FCTs.Remove(fct);
            try
            {
                //guardo los cambios en la base de datos
                int nAfectados = bdFCTsEntities.SaveChanges();
                if (nAfectados == 0)
                {
                    msj = "No se ha podido borrar la fct";
                    return msj;
                }
            }
            catch (Exception e)
            {
                msj = e.Message;
                //Solucionar el borrado incorrecto en las colecciones
                //primero quitamos el estado deleted al registro
                bdFCTsEntities.Entry(fct).State = System.Data.Entity.EntityState.Unchanged;
                bdFCTsEntities.FCTs.Add(fct); //lo añadimos de nuevo
            }
            return msj;
        }
    }
}
