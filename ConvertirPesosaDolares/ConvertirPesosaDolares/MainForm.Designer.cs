﻿/*
 * Creado por SharpDevelop.
 * Usuario: Luly
 * Fecha: 29/10/2013
 * Hora: 03:27 p.m.
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
namespace ConvertirPesosaDolares
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.textBox2 = new System.Windows.Forms.TextBox();
			this.textBox3 = new System.Windows.Forms.TextBox();
			this.button1 = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			this.button3 = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(27, 9);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(100, 23);
			this.label1.TabIndex = 0;
			this.label1.Text = "PESOS\r\n";
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(162, 23);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(97, 36);
			this.label2.TabIndex = 1;
			this.label2.Text = "TIPO DE CAMBIO\r\n\r\n";
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(60, 100);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(100, 23);
			this.label3.TabIndex = 2;
			this.label3.Text = "DOLARES\r\n\r\n";
			// 
			// textBox1
			// 
			this.textBox1.Location = new System.Drawing.Point(7, 34);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(115, 20);
			this.textBox1.TabIndex = 3;
			// 
			// textBox2
			// 
			this.textBox2.Location = new System.Drawing.Point(166, 50);
			this.textBox2.Name = "textBox2";
			this.textBox2.Size = new System.Drawing.Size(113, 20);
			this.textBox2.TabIndex = 4;
			// 
			// textBox3
			// 
			this.textBox3.Enabled = false;
			this.textBox3.Location = new System.Drawing.Point(27, 126);
			this.textBox3.Name = "textBox3";
			this.textBox3.Size = new System.Drawing.Size(133, 20);
			this.textBox3.TabIndex = 5;
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(184, 188);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(94, 26);
			this.button1.TabIndex = 6;
			this.button1.Text = "CONVERTIR\r\n";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.Button1Click);
			// 
			// button2
			// 
			this.button2.Location = new System.Drawing.Point(32, 180);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(115, 33);
			this.button2.TabIndex = 7;
			this.button2.Text = "LIMPIAR";
			this.button2.UseVisualStyleBackColor = true;
			this.button2.Click += new System.EventHandler(this.Button2Click);
			// 
			// button3
			// 
			this.button3.Location = new System.Drawing.Point(119, 220);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(76, 32);
			this.button3.TabIndex = 8;
			this.button3.Text = "CERRAR\r\n";
			this.button3.UseVisualStyleBackColor = true;
			this.button3.Click += new System.EventHandler(this.Button3Click);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(284, 262);
			this.Controls.Add(this.button3);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.textBox3);
			this.Controls.Add(this.textBox2);
			this.Controls.Add(this.textBox1);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Name = "MainForm";
			this.Text = "ConvertirPesosaDolares";
			this.Load += new System.EventHandler(this.MainFormLoad);
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.Button button3;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.TextBox textBox3;
		private System.Windows.Forms.TextBox textBox2;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
	}
}
