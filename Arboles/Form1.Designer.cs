namespace Arboles
{
	partial class Form1
	{
		/// <summary>
		/// Variable del diseñador necesaria.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Limpiar los recursos que se estén usando.
		/// </summary>
		/// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Código generado por el Diseñador de Windows Forms

		/// <summary>
		/// Método necesario para admitir el Diseñador. No se puede modificar
		/// el contenido de este método con el editor de código.
		/// </summary>
		private void InitializeComponent()
		{
			this.btnAgregar = new System.Windows.Forms.Button();
			this.btnIn = new System.Windows.Forms.Button();
			this.btnPost = new System.Windows.Forms.Button();
			this.btnPre = new System.Windows.Forms.Button();
			this.txtConsola = new System.Windows.Forms.TextBox();
			this.SuspendLayout();
			// 
			// btnAgregar
			// 
			this.btnAgregar.Location = new System.Drawing.Point(132, 12);
			this.btnAgregar.Name = "btnAgregar";
			this.btnAgregar.Size = new System.Drawing.Size(114, 32);
			this.btnAgregar.TabIndex = 0;
			this.btnAgregar.Text = "Crear arbol";
			this.btnAgregar.UseVisualStyleBackColor = true;
			this.btnAgregar.Click += new System.EventHandler(this.btnGenerar_Click);
			// 
			// btnIn
			// 
			this.btnIn.Location = new System.Drawing.Point(132, 66);
			this.btnIn.Name = "btnIn";
			this.btnIn.Size = new System.Drawing.Size(114, 30);
			this.btnIn.TabIndex = 1;
			this.btnIn.Text = "In Order";
			this.btnIn.UseVisualStyleBackColor = true;
			this.btnIn.Click += new System.EventHandler(this.btnIn_Click);
			// 
			// btnPost
			// 
			this.btnPost.Location = new System.Drawing.Point(252, 66);
			this.btnPost.Name = "btnPost";
			this.btnPost.Size = new System.Drawing.Size(114, 30);
			this.btnPost.TabIndex = 2;
			this.btnPost.Text = "Post Order";
			this.btnPost.UseVisualStyleBackColor = true;
			this.btnPost.Click += new System.EventHandler(this.btnPost_Click);
			// 
			// btnPre
			// 
			this.btnPre.Location = new System.Drawing.Point(12, 66);
			this.btnPre.Name = "btnPre";
			this.btnPre.Size = new System.Drawing.Size(114, 30);
			this.btnPre.TabIndex = 3;
			this.btnPre.Text = "Pre Order";
			this.btnPre.UseVisualStyleBackColor = true;
			this.btnPre.Click += new System.EventHandler(this.btnPre_Click);
			// 
			// txtConsola
			// 
			this.txtConsola.Location = new System.Drawing.Point(13, 131);
			this.txtConsola.Multiline = true;
			this.txtConsola.Name = "txtConsola";
			this.txtConsola.Size = new System.Drawing.Size(353, 200);
			this.txtConsola.TabIndex = 4;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(375, 343);
			this.Controls.Add(this.txtConsola);
			this.Controls.Add(this.btnPre);
			this.Controls.Add(this.btnPost);
			this.Controls.Add(this.btnIn);
			this.Controls.Add(this.btnAgregar);
			this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
			this.Name = "Form1";
			this.Text = "Arboles";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		public System.Windows.Forms.Button btnAgregar;
		private System.Windows.Forms.Button btnIn;
		private System.Windows.Forms.Button btnPost;
		private System.Windows.Forms.Button btnPre;
		private System.Windows.Forms.TextBox txtConsola;
	}
}

