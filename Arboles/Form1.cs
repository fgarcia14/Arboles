using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Arboles
{
	public partial class Form1 : Form
	{
		Arbol arbol;
		public Form1()
		{
			InitializeComponent();
			arbol = new Arbol();
		}

		private void btnGenerar_Click(object sender, EventArgs e)
		{
			arbol = new Arbol();
			Random rand = new Random();
			for (int i = 0; i < 50; i++)
			{
				Nodo nodo = new Nodo(rand.Next(1, 1001));
				arbol.agregar(nodo);
			}
		}

		private void btnPre_Click(object sender, EventArgs e)
		{
			txtConsola.Text=arbol.preOrder();
		}

		private void btnIn_Click(object sender, EventArgs e)
		{
			txtConsola.Text = arbol.inOrder();
		}

		private void btnPost_Click(object sender, EventArgs e)
		{
			txtConsola.Text = arbol.postOrder();
		}
	}
}
