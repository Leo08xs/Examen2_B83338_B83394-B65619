using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen2_B83338_B83394_B65619
{
    class Producto
    {
		private int productoID { set; get; }
		private String descrepcion { set; get; }
		private String preparacion { set; get; }

		public Producto(int id, string desc, string prepa)
		{
			productoID = id;
			descrepcion = desc;
			preparacion = prepa;
		}

		public Producto()
		{
		}
	}
}
