using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Excepciones;

namespace Archivos
{
	public class Texto : IArchivo<string>
	{
		/// <summary>
		/// Guarda en un archivo de texto el dato en la ruta dada
		/// </summary>
		/// <param name="archivo">Ruta del archivo a guardar</param>
		/// <param name="datos">Dato a guardar</param>
		/// <returns></returns>
		public bool Guardar(string archivo, string datos)
		{
			StreamWriter streamWriter = null;
			try
			{
				streamWriter = new StreamWriter(archivo);
				streamWriter.Write(datos);
			}
			catch (Exception e)
			{
				throw new ArchivosException(e);
			}
			finally
			{
				if (!(streamWriter is null))
					streamWriter.Close();
			}
			return true;
		}
		/// <summary>
		/// Lee un archivo de texto y devuelve lo leído
		/// </summary>
		/// <param name="archivo">Ruta del archivo a leer</param>
		/// <param name="datos">Dato que devuelve</param>
		/// <returns></returns>
		public bool Leer(string archivo, out string datos)
		{
			StreamReader streamReader = null;
			datos = "";
			try
			{
				streamReader = new StreamReader(archivo);
				datos = streamReader.ReadToEnd();
			}
			catch (Exception e)
			{
				throw new ArchivosException(e);
			}
			finally
			{
				if (!(streamReader is null))
					streamReader.Close();
			}
			return true;
		}
	}
}
