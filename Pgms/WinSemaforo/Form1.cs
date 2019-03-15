using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using CursoApliNet;

namespace WindowsApplication1
{
	/// <summary>
	/// Descripción breve de Form1.
	/// </summary>
	public class Form1 : System.Windows.Forms.Form
	{
		private System.Windows.Forms.ProgressBar progressBar1;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.PictureBox picg1;
		private System.Windows.Forms.PictureBox picg2;
		private System.Windows.Forms.PictureBox picg3;
		private System.Windows.Forms.PictureBox picRojo;
		private System.Windows.Forms.PictureBox picAmar;
		private System.Windows.Forms.PictureBox picVerde;
		/// <summary>
		/// Variable del diseñador requerida.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public Form1()
		{
			//
			// Necesario para admitir el Diseñador de Windows Forms
			//
			InitializeComponent();

			//
			// TODO: agregar código de constructor después de llamar a InitializeComponent
			//
		}

		/// <summary>
		/// Limpiar los recursos que se estén utilizando.
		/// </summary>
		protected override void Dispose( bool disposing )
		{
			if( disposing )
			{
				if (components != null) 
				{
					components.Dispose();
				}
			}
			base.Dispose( disposing );
		}

		#region Código generado por el Diseñador de Windows Forms
		/// <summary>
		/// Método necesario para admitir el Diseñador. No se puede modificar
		/// el contenido del método con el editor de código.
		/// </summary>
		private void InitializeComponent()
		{
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(Form1));
			this.progressBar1 = new System.Windows.Forms.ProgressBar();
			this.button1 = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.picg1 = new System.Windows.Forms.PictureBox();
			this.picg2 = new System.Windows.Forms.PictureBox();
			this.picg3 = new System.Windows.Forms.PictureBox();
			this.picRojo = new System.Windows.Forms.PictureBox();
			this.picAmar = new System.Windows.Forms.PictureBox();
			this.picVerde = new System.Windows.Forms.PictureBox();
			this.SuspendLayout();
			// 
			// progressBar1
			// 
			this.progressBar1.Location = new System.Drawing.Point(24, 280);
			this.progressBar1.Name = "progressBar1";
			this.progressBar1.Size = new System.Drawing.Size(288, 23);
			this.progressBar1.TabIndex = 0;
			// 
			// button1
			// 
			this.button1.Font = new System.Drawing.Font("Tahoma", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.button1.Location = new System.Drawing.Point(16, 24);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(296, 32);
			this.button1.TabIndex = 1;
			this.button1.Text = "Cerrar";
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label1.Location = new System.Drawing.Point(16, 248);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(300, 17);
			this.label1.TabIndex = 2;
			this.label1.Text = "Cerrando archivos...Gracias por usar esta Aplicacion";
			this.label1.Visible = false;
			// 
			// picg1
			// 
			this.picg1.Image = ((System.Drawing.Image)(resources.GetObject("picg1.Image")));
			this.picg1.Location = new System.Drawing.Point(128, 80);
			this.picg1.Name = "picg1";
			this.picg1.Size = new System.Drawing.Size(56, 48);
			this.picg1.TabIndex = 3;
			this.picg1.TabStop = false;
			// 
			// picg2
			// 
			this.picg2.Image = ((System.Drawing.Image)(resources.GetObject("picg2.Image")));
			this.picg2.Location = new System.Drawing.Point(128, 128);
			this.picg2.Name = "picg2";
			this.picg2.Size = new System.Drawing.Size(56, 48);
			this.picg2.TabIndex = 4;
			this.picg2.TabStop = false;
			// 
			// picg3
			// 
			this.picg3.Image = ((System.Drawing.Image)(resources.GetObject("picg3.Image")));
			this.picg3.Location = new System.Drawing.Point(128, 176);
			this.picg3.Name = "picg3";
			this.picg3.Size = new System.Drawing.Size(56, 48);
			this.picg3.TabIndex = 5;
			this.picg3.TabStop = false;
			// 
			// picRojo
			// 
			this.picRojo.Image = ((System.Drawing.Image)(resources.GetObject("picRojo.Image")));
			this.picRojo.Location = new System.Drawing.Point(128, 80);
			this.picRojo.Name = "picRojo";
			this.picRojo.Size = new System.Drawing.Size(56, 48);
			this.picRojo.TabIndex = 6;
			this.picRojo.TabStop = false;
			this.picRojo.Visible = false;
			// 
			// picAmar
			// 
			this.picAmar.Image = ((System.Drawing.Image)(resources.GetObject("picAmar.Image")));
			this.picAmar.Location = new System.Drawing.Point(128, 128);
			this.picAmar.Name = "picAmar";
			this.picAmar.Size = new System.Drawing.Size(56, 48);
			this.picAmar.TabIndex = 7;
			this.picAmar.TabStop = false;
			this.picAmar.Visible = false;
			// 
			// picVerde
			// 
			this.picVerde.Image = ((System.Drawing.Image)(resources.GetObject("picVerde.Image")));
			this.picVerde.Location = new System.Drawing.Point(128, 176);
			this.picVerde.Name = "picVerde";
			this.picVerde.Size = new System.Drawing.Size(56, 48);
			this.picVerde.TabIndex = 8;
			this.picVerde.TabStop = false;
			this.picVerde.Visible = false;
			// 
			// Form1
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(336, 325);
			this.Controls.Add(this.picVerde);
			this.Controls.Add(this.picAmar);
			this.Controls.Add(this.picRojo);
			this.Controls.Add(this.picg3);
			this.Controls.Add(this.picg2);
			this.Controls.Add(this.picg1);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.progressBar1);
			this.Name = "Form1";
			this.Text = "Prueba Semaforo";
			this.ResumeLayout(false);

		}
		#endregion

		/// <summary>
		/// Punto de entrada principal de la aplicación.
		/// </summary>
		[STAThread]
		static void Main() 
		{
			Application.Run(new Form1());
		}

		private void button1_Click(object sender, System.EventArgs e)
		{
			Semaforo smfp = new Semaforo();
			smfp.Ascendente = true;
			smfp.Circular = false;
			smfp.Estados = 20;
			smfp.SegundosPorEstado = 1;
			smfp.Vueltas = 2;

			smfp.CambioEstado += new CambioEstadoHandler(smf_CambiaSemaforo);
			smfp.Run();

			Semaforo smfs = new Semaforo();
			smfs.Ascendente = true;
			smfs.Circular = false;
			smfs.Estados = 20;
			smfs.SegundosPorEstado = 1;
			smfs.Vueltas = 2;

			smfs.CambioEstado += new CambioEstadoHandler(smf_CambiaProgreso);
			smfs.Run();

			this.label1.Visible = true;
		}

		private void smf_CambiaProgreso(object semaforo, int estado, out bool cancel)
		{
			cancel = false;
			if(estado == 19)
			{
				cancel = true;
				this.Close();
				return;
			}

			int valor = estado * 6;
			this.progressBar1.Value = valor < 100 ? valor : 100;
		}

		private void smf_CambiaSemaforo(object semaforo, int estado, out bool cancel)
		{
			cancel = false;
			if(estado == 19)
			{
				cancel = true;
				return;
			}

			int valor = estado % 3;
			switch(valor)
			{
				case 0:
					this.picRojo.Visible = true;
					this.picAmar.Visible = false;
					this.picVerde.Visible = false;
					this.picRojo.Update();
					this.picAmar.Update();
					this.picVerde.Update();
					break;

				case 1:
					this.picRojo.Visible = false;
					this.picAmar.Visible = true;
					this.picVerde.Visible = false;
					this.picRojo.Update();
					this.picAmar.Update();
					this.picVerde.Update();
					break;

				default:
					this.picRojo.Visible = false;
					this.picAmar.Visible = false;
					this.picVerde.Visible = true;
					this.picRojo.Update();
					this.picAmar.Update();
					this.picVerde.Update();
					break;
			}
		}
	}
}
