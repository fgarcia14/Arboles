using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arboles
{
	class Nodo
	{
		private int _dato;
		public int dato { get { return _dato; } }

		public Nodo izq;
		public Nodo der;

		public Nodo(int dato) {
			_dato = dato;
		}

		public override string ToString()
		{
			return _dato + ", ";
		}
	}
}
