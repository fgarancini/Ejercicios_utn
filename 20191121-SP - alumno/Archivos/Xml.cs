using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;

namespace Archivos
{
    public class Xml<T> : IFiles<T>
    {
        public string GetDirectoryPath
        {
            get
            {
                return Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + @"\";
            }
        }

        public bool FileExists(string nombreArchivo)
        {
            bool aux = false;
            string ruta = $"{GetDirectoryPath}{nombreArchivo}";
            if (File.Exists(ruta))
            {
                aux = true;
            }
            return aux;
        }

        public void Guardar(string nombreArchivo, T obj)
        {
            Guardar(nombreArchivo,obj,Encoding.UTF8);
        }

        public void Guardar(string nombreArchivo, T obj, Encoding encoding)
        {
            try
            {
                using (XmlTextWriter writer = new XmlTextWriter($"{GetDirectoryPath}{nombreArchivo}", encoding))
                {
                    writer.Formatting = Formatting.Indented;
                    XmlSerializer serializer = new XmlSerializer(typeof(T));
                    serializer.Serialize(writer, obj);
                }
            }
            catch (Exception ex)
            {

                throw new ErrorArchivosException("Error de Archivos",ex);
            }
        }

        public bool Leer(string nombreArchivo, out T objeto)
        {
            XmlTextReader reader = null;
            try
            {
                if (nombreArchivo.Contains("\\") || !FileExists(nombreArchivo))
                {
                    throw new ErrorArchivosException("Ruta invalida");
                }
                else
                {
                    using (reader = new XmlTextReader(nombreArchivo))
                    {
                        XmlSerializer serializer = new XmlSerializer(typeof(T));
                        objeto = (T)serializer.Deserialize(reader);
                        return true;
                    } 
                }
            }
            finally
            {
                if (reader != null)
                {
                    reader.Close();
                }
            }
        }

        public bool Leer(string nombreArchivo, out T objeto, Encoding encoding)
        {
            XmlTextReader reader = null;
            try
            {
                using (reader = new XmlTextReader(nombreArchivo))
                {
                    XmlSerializer serializer = new XmlSerializer(typeof(T));
                    objeto = (T)serializer.Deserialize(reader,encoding.EncodingName);
                    return true;
                }
            }
            finally
            {
                if (reader != null)
                {
                    reader.Close();
                }
            }
        }
    }
}
