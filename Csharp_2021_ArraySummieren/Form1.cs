using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Csharp_2021_ArraySummieren
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void btnErgebnis_Click(object sender, EventArgs e)
		{
			int[] zahlenreihe = { 7, 13, 25, 16, 8, 2 };

			// Anzeige wird geleert
			lblErgebnis.Text = "";

			// Tipp aus der Praxis: Jede Funktion, jede Schleife hat genau eine Aufgabe

			// Rechenweg ausgeben
			for (int i = 0; i < zahlenreihe.Length - 1; i++)
			{
				lblErgebnis.Text += zahlenreihe[i] + " + ";
			}

			// Letzte Zahl & Ergebnis anhängen und ausgeben
			lblErgebnis.Text += 
				zahlenreihe[zahlenreihe.Length - 1] + 
				" = " + 
				ArraysummeBilden(zahlenreihe);
		}

		// Funktion addiert zwei Werte ( a und b)
		// gibt das Ergebnis zurück
		private int Addieren(int a, int b)
		{
			int summe = a + b;
			return summe;

			// Kurzform: 
			// return a + b;
		}

		private int ArraysummeBilden(int[] x)
		{
			int summe = 0;

			for (int i = 0; i < x.Length; i++)
			{
				summe += x[i];
			}

			return summe;
		}


	}
}
