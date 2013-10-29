/*
 * Creado por SharpDevelop.
 * Usuario: Luly
 * Fecha: 29/10/2013
 * Hora: 03:27 p.m.
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace ConvertirPesosaDolares
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		public MainForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		void Button1Click(object sender, EventArgs e)
		{
			//Variables
            double dolar, peso, cam;
			
			try 
				{
				//Asignacion de valores
				
				cam = System.Double.Parse(textBox2.Text);
				peso = System.Double.Parse(textBox1.Text);

				//Calcular

				dolar = peso * cam;
				
				//Compara si es un 0
				
				if(dolar == 0){
					MessageBox.Show("No se puede convertir: "+ dolar);
				}else{
					MessageBox.Show("La cantidad en Dolares es: "+ dolar);
				}

				// Nos Musrtra  Resultados

				textBox3.Text = dolar.ToString();
				
			// Capta la Exception
			
			}catch(Exception m)
				{
					MessageBox.Show("No Acepto campos vacios,  letras, ni simbolos \n\n"+
				                "Exception: " + m.Message);
				}
		}
		
		void MainFormLoad(object sender, EventArgs e)
		{
			
		}
		
		void Button3Click(object sender, EventArgs e)
		{
			MessageBox.Show("Gracias por tu transacción :)");
            Close();
		}
		
		void Button2Click(object sender, EventArgs e)
		{
			textBox1.Clear();
            textBox2.Clear();
            textBox3.ResetText();
		}
	}
}
