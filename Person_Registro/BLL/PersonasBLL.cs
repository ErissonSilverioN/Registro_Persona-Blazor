using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Person_Registro.DAL;
using Person_Registro.Models;

namespace Person_Registro.BLL
{
    public class PersonasBLL
    {

       public static bool Guardar(Personas personas)
        {
            if (!Existe(personas.PersonaId))
                return Insertar(personas);
            else
                return Modificar(personas);
        }


        private static bool Insertar(Personas personas)
        {
            bool paso = false;
            Contexto db = new Contexto();

            try
            {
                db.personas.Add(personas);
                paso = db.SaveChanges() > 0;
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                db.Dispose();
            }

            return paso;
        }


        public static bool Modificar(Personas personas)
        {
            bool paso = false;
            Contexto db = new Contexto();

            try
            {
                db.Entry(personas).State = EntityState.Modified;
                paso = db.SaveChanges() > 0;

            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                db.Dispose();
            }

            return paso;
        }

        public static bool Eliminar(int id)
        {
            bool paso = false;
            Contexto db = new Contexto();

            try
            {
                var Eliminar = db.personas.Find(id);
                db.Entry(Eliminar).State = EntityState.Deleted;
                paso = db.SaveChanges() > 0;


            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                db.Dispose();
            }

            return paso;

        }

        public static Personas Buscar(int id)
        {
            Contexto db = new Contexto();
            Personas personas = new Personas();

            try
            {
                personas = db.personas.Find(id);

            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                db.Dispose();
            }

            return personas;
        }


        public static bool Existe(int id)
        {
            bool encontrado = false;
            Contexto db = new Contexto();

            try
            {
                encontrado = db.personas.Any(p => p.PersonaId == id);
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                db.Dispose();
            }

            return encontrado;
        }
        

    }
}
