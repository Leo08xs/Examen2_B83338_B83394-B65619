using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen2_B83338_B83394_B65619
{
    class Venta
    {
		private int numeroV { set; get; }
		private DateTime Fecha { set; get; }
	    private Cliente cliente { set; get; }

	public Venta(int num, DateTime fech, Cliente cli)
		{
			numeroV = num;
			Fecha = fech;
			cliente = cli;
		}

		public Venta()
		{
		}
	}
}
