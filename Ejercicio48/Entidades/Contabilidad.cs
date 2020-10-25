using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Contabilidad<T,U>
        where T : Documento
        where U : Documento, new()
    {
        private List<T> egresos;
        private List<U> ingresos;
        
        public List<U> Ingresos
        {
            get
            {
                return this.ingresos;
            }
        }
        public List<T> Egresos
        {
            get
            {
                return this.egresos;
            }
        }
        public Contabilidad()
        {
            this.egresos = new List<T>();
            this.ingresos = new List<U>();
        }

        public static Contabilidad<T,U> operator +(Contabilidad<T,U> contabilidad,T egreso)
        {
            contabilidad.egresos.Add(egreso);

            return contabilidad;
        }
        public static Contabilidad<T, U> operator +(Contabilidad<T, U> contabilidad, U ingreso)
        {
            contabilidad.ingresos.Add(ingreso);
            return contabilidad;

        }
    }
}
