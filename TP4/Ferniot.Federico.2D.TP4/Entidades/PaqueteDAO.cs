using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
	public static class PaqueteDAO
	{
		private static SqlCommand comando;
		private static SqlConnection conexion;

		static PaqueteDAO()
		{
			PaqueteDAO.conexion = new SqlConnection("Data Source=DESKTOP-PEVO1MQ\\SQLEXPRESS01;Initial Catalog=correo-sp-2017;Integrated Security=True");
			PaqueteDAO.comando = new SqlCommand();
		}

		public static bool Insertar(Paquete paquete)
		{
			try
			{
				PaqueteDAO.conexion.Open();
				PaqueteDAO.comando.CommandText = String.Format("INSERT INTO Paquetes (direccionEntrega, trackingID, alumno) VALUES('{0}', '{1}', '{2}')",
																paquete.DireccionEntrega, paquete.TrackingID, "Federico Ferniot");
				PaqueteDAO.comando.Connection = PaqueteDAO.conexion;
				PaqueteDAO.comando.ExecuteNonQuery();
			}
			catch (Exception e)
			{
				throw e;
			}
			finally
			{
				if (!(PaqueteDAO.conexion is null))
					PaqueteDAO.conexion.Close();
			}
			return true;
		}
	}
}
