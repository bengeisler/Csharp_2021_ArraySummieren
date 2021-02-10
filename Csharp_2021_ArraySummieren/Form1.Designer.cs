
namespace Csharp_2021_ArraySummieren
{
	partial class Form1
	{
		/// <summary>
		/// Erforderliche Designervariable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Verwendete Ressourcen bereinigen.
		/// </summary>
		/// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Vom Windows Form-Designer generierter Code

		/// <summary>
		/// Erforderliche Methode für die Designerunterstützung.
		/// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
		/// </summary>
		private void InitializeComponent()
		{
			this.btnErgebnis = new System.Windows.Forms.Button();
			this.lblErgebnis = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// btnErgebnis
			// 
			this.btnErgebnis.Location = new System.Drawing.Point(60, 57);
			this.btnErgebnis.Name = "btnErgebnis";
			this.btnErgebnis.Size = new System.Drawing.Size(75, 23);
			this.btnErgebnis.TabIndex = 0;
			this.btnErgebnis.Text = "Ergebnis";
			this.btnErgebnis.UseVisualStyleBackColor = true;
			this.btnErgebnis.Click += new System.EventHandler(this.btnErgebnis_Click);
			// 
			// lblErgebnis
			// 
			this.lblErgebnis.AutoSize = true;
			this.lblErgebnis.Location = new System.Drawing.Point(22, 13);
			this.lblErgebnis.Name = "lblErgebnis";
			this.lblErgebnis.Size = new System.Drawing.Size(35, 13);
			this.lblErgebnis.TabIndex = 1;
			this.lblErgebnis.Text = "label1";
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(217, 98);
			this.Controls.Add(this.lblErgebnis);
			this.Controls.Add(this.btnErgebnis);
			this.Name = "Form1";
			this.Text = "Array summieren";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button btnErgebnis;
		private System.Windows.Forms.Label lblErgebnis;
	}
}

