using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
	public static class GuardaString
	{
		public static bool Guardar(this string texto, string archivo)
		{
			StreamWriter streamWriter = null;
			string ruta = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\" + archivo;
			try
			{
				streamWriter = new StreamWriter(ruta, true);
				streamWriter.Write(texto);
			}
			catch (Exception e)
			{
				throw e;
			}
			finally
			{
				if (!(streamWriter is null))
					streamWriter.Close();
			}
			return true;
		}

	}
}
