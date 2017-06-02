using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arboles
{
	class Arbol
	{
		Nodo raiz;

		public Arbol() {
			raiz = null;
		}

		public void agregar(Nodo nuevo) {
			if (raiz == null)
			{
				raiz = nuevo;
			}
			else {
				agregar(nuevo, raiz);
			}
		}

		private void agregar(Nodo n, Nodo p) {
			if (n.dato<p.dato)
			{
				if (p.izq == null)
				{
					p.izq = n;
				}
				else
				{
					agregar(n, p.izq);
				}
			}
			else
			{
				if (p.der==null)
				{
					p.der = n;
				}
				else
				{
					agregar(n, p.der);
				}
			}
		}

		public String preOrder() {
			if (raiz == null)
			{
				return "";
			}
			else
			{
				return preOrder(raiz);
			}
		}

		
		private String preOrder(Nodo r)
		{
			String res = "";
			res += r.ToString();
			if (r.izq!=null)
			{
				res += preOrder(r.izq);
			}
			if (r.der!=null)
			{
				res += preOrder(r.der);
			}
			return res;
		}

		public String inOrder()
		{
			if (raiz == null)
			{
				return "";
			}
			else
			{
				return inOrder(raiz);
			}
		}


		private String inOrder(Nodo r)
		{
			String res = "";
			if (r.izq != null)
			{
				res += inOrder(r.izq);
			}
			res += r.ToString();
			if (r.der != null)
			{
				res += inOrder(r.der);
			}
			return res;
		}


		public String postOrder()
		{
			if (raiz == null)
			{
				return "";
			}
			else
			{
				return postOrder(raiz);
			}
		}


		private String postOrder(Nodo r)
		{
			String res = "";
			if (r.izq != null)
			{
				res += postOrder(r.izq);
			}
			if (r.der != null)
			{
				res += postOrder(r.der);
			}
			res += r.ToString();
			return res;
		}

	}
}
