using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using Excepciones;

namespace Archivos
{
	public class Xml<T> : IArchivo<T>
	{
		/// <summary>
		/// Guarda en un archivo xml el dato en la ruta dada
		/// </summary>
		/// <param name="archivo">Ruta del archivo a guardar</param>
		/// <param name="datos">Dato a guardar</param>
		/// <returns></returns>
		public bool Guardar(string archivo, T datos)
		{
			XmlSerializer xmlSerializer = new XmlSerializer(typeof(T));
			TextWriter writer = null;
			try
			{
				writer = new StreamWriter(archivo);
				xmlSerializer.Serialize(writer, datos);
			}
			catch (Exception e)
			{
				throw new ArchivosException(e);
			}
			finally
			{
				if (!(writer is null))
					writer.Close();
			}
			return true;
		}
		/// <summary>
		/// Lee un archivo de xml y devuelve lo leído
		/// </summary>
		/// <param name="archivo">Ruta del archivo a leer</param>
		/// <param name="datos">Dato que devuelve</param>
		/// <returns></returns>
		public bool Leer(string archivo, out T datos)
		{
			XmlSerializer serializer = new XmlSerializer(typeof(T));
			TextReader writer = null;
			datos = default(T);
			try
			{
				writer = new StreamReader(archivo);
				datos = (T)serializer.Deserialize(writer);
			}
			catch (Exception e)
			{
				throw new ArchivosException(e);
			}
			finally
			{
				if (!(writer is null))
					writer.Close();
			}
			return true;
		}
	}
}
