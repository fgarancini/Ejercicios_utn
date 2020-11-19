using System;
using System.Collections.Generic;
using System.Text;

namespace Archivos
{
    public interface IFiles<T>
    {
        void Guardar(string nombreArchivo, T obj);
        void Guardar(string nombreArchivo, T obj,Encoding encoding);
        bool Leer(string nombreArchivo, out T objeto);
        bool Leer(string nombreArchivo, out T objeto,Encoding encoding);
    }
}