using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen2_B83338_B83394_B65619
{
    public class Cliente
    {

		private int clienteID { set; get; }
		private String nombre { set; get; }
		private String Apellido { set; get; }

		public Cliente(int id, string nom, string apellido)
		{
			clienteID = id;
			nombre = nom;
			Apellido = apellido;

		}

		public Cliente()
		{

		}

	}
}
