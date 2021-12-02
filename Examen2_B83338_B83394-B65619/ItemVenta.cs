using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen2_B83338_B83394_B65619
{
    class ItemVenta
    {
		private int itemventaID { set; get; }
		private int cantidadV { set; get; }
		private float precioU { set; get; }
		private Venta numVenta { set; get; }
		private Producto producto { set; get; }

		public ItemVenta(int id, int cant, float pre, Venta venta, Producto produ)
		{
			itemventaID = id;
			cantidadV = cant;
			precioU = pre;
			numVenta = venta;
			producto = produ;
		}


		public ItemVenta()
		{

		}
	}
}
