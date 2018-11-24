using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimpleEditor
{
    public partial class Form_Editor : Form
    {
        TextLeggiScrivi tls; // classe con metodi per gestire file.
		bool changed = false; // controllo se l'area di lavoro è stata modificata.
        string patternStart = @"({)"; // default "indenta" setting.
        string patternEnd = @"(})"; // default "indenta" setting.

		// costruttore
		public Form_Editor()
        {
            InitializeComponent();
            tls = new TextLeggiScrivi();
        }

        public void contarighe()
        {
            var count = rTxtBody.Lines.Count();
            richTextBox1.Clear();
            string all = "";
            for (int i = 1; i < count + 1; i++)
            {
                all += i + "\n";
            }
            richTextBox1.Text += all;

            richTextBox1.SelectionStart = count + 1;
            richTextBox1.ScrollToCaret();


            vScrollBar1.Value = count;
        }
		// Aprire file
        private void btnOpenFile_Click(object sender, EventArgs e)
        {
			if (changed) // SE è stata appilacata una modifica alla area di lavoro: chiedi.
			{
				if (MessageBox.Show("Vuoi uscire senza salvare?", "Attenzione:", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
				{
					var temp = tls.ApriFile();
					if (temp != "")
					{
						rTxtBody.Text = tls.ReadFile();
						txtPercorso.Text = temp;
					}
					changed = false;
				}
			}
			else // altrimenti apri.
			{
				var temp = tls.ApriFile();
				if (temp != "")
				{
					rTxtBody.Text = tls.ReadFile();
					txtPercorso.Text = temp;
				}
				changed = false;
			}

            this.contarighe();
		}

		// Chiudere file
		private void btnChiudiFile_Click(object sender, EventArgs e)
		{
			tls.ChiudiFile();
			if (changed)  // SE è stata appilacata una modifica alla area di lavoro: chiedi.
			{
				if (MessageBox.Show("Vuoi uscire senza salvare?", "Attenzione:", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
				{
					rTxtBody.Text = "";
					txtPercorso.Text = "";
					changed = false;
				}
			}
			else // altrimenti chiudi.
			{
				rTxtBody.Text = "";
				txtPercorso.Text = "";
				changed = false;
			}
		}

		// Salva
		private void btnSalva_Click(object sender, EventArgs e)
        {
			var temp = tls.Save(rTxtBody.Text);
			if (temp != "Error")
			{
				txtPercorso.Text = temp;
				changed = false;
			}
		}

		// Salva con nome
		private void btnSalvaConNome_Click(object sender, EventArgs e)
		{
			var temp = tls.SaveAs(rTxtBody.Text);
			if (temp != "Error")
			{
				txtPercorso.Text = temp;
				changed = false;
			}
		}

		// Dynamic rTextBox e Path txtbox re-size
		private void Editor_SizeChanged(object sender, EventArgs e)
		{
			// 598; 224 RTXTBOX
			// 638; 368 FORM
			// 368 - 223 = 144
			// 528 - 488 = 40
			var x = rTxtBody.Size;
			x.Width = this.Width - 40;
			x.Height = this.Height - 144;
			rTxtBody.Size = x;
			var y = txtPercorso.Size;
			y.Width = this.Width - 99;
			txtPercorso.Size = y;
		}

		// Feature indenta w/ regex
		private void btnIndenta_Click(object sender, EventArgs e)
		{
			// start xml:	(<[^/])
			// end xml:		([</])([/>])
			// start json:	({)
			// end json:	(})

			// creating a matrix with all the values
			var y = rTxtBody.Text.Split('\n');
			List<string> table = new List<string>();
			int countTab = 0;
			foreach(string x in y)
			{
				var row = x.Trim();
				//both
				if (Regex.Match(row, patternStart).Success && Regex.Match(row, patternEnd).Success)
				{
					table.Add(string.Concat(Enumerable.Repeat("        ", countTab)) + row);
				}
				//end
				else if (Regex.Match(row, patternEnd).Success) {
					countTab = countTab == 0 ? 0 : (countTab -1);
					table.Add(string.Concat(Enumerable.Repeat("        ", countTab)) + row);
				}
				//start
				else if (Regex.Match(row, patternStart).Success) {
					table.Add(string.Concat(Enumerable.Repeat("        ", countTab)) + row);
					countTab++;
				}
				//normale
				else
				{
					table.Add(string.Concat(Enumerable.Repeat("        ", countTab)) + row);
				}

				table.Add("\n");
			}
			//cleanup
			List<string> tableCleanup = new List<string>();
			foreach(string x in table)
			{
				var word = Regex.Replace(x,"                ", "\t");
				tableCleanup.Add(word);
			}
			var text = string.Join("", tableCleanup.ToArray());
			rTxtBody.Text = text;
		}

		// Se l'area di lavoro ha ricevuto una modifica per una 2-step chiusura del file
		// Si aggiunge un segnetto al percorso per indicare la presenza di un cambiamento (*)
		private void rTxtBody_TextChanged(object sender, EventArgs e)
		{
			if (!changed) { txtPercorso.Text += "*"; }
			changed = true;

            this.contarighe();

        }

		// Scelta opzione formato per indentazione.
        private void rBttJson_CheckedChanged(object sender, EventArgs e)
        {
            if (rBttJson.Checked == true)
            {
                patternStart = @"({)";
                patternEnd = @"(})";
            }
            else if(rBttXml.Checked == true)
            {
                patternStart = @"(<[^/])";
                patternEnd = @"([</])([/>])";
            }
        }

        private void vScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {
            rTxtBody.SelectionStart = vScrollBar1.Value;
            rTxtBody.ScrollToCaret();
            richTextBox1.SelectionStart = vScrollBar1.Value;
            richTextBox1.ScrollToCaret();
        }
    }

    // Classe gestione file
    class TextLeggiScrivi
	{
		private OpenFileDialog ofd; // Contiene informazioni sul file aperto come perscorso e dati.

		// Costruttore
		public TextLeggiScrivi() {
			ofd = new OpenFileDialog();
		}

		// OPEN
		public string ApriFile()
		{
			// aprirà un dialogo che chiede di indicare il file desiderato.
			if ( ofd.ShowDialog() != DialogResult.OK ) { return ""; }
			return ofd.FileName;
		}

		// CLOSE
		public void ChiudiFile() {
			// Deselezione del file scelto in precedenza
			ofd = new OpenFileDialog();
		}

		// READ
		// return: 
		//		i byte del file in una stringa leggibile.
		public string ReadFile()
		{
			StreamReader sr = new StreamReader(ofd.FileName);
			var text = sr.ReadToEnd();
			sr.Close();
			return text;
		}

		// SAVE
		// return:
		//		ritorna o nulla (per indicare che l'operazione è andata a buon fine)
		//		oppure il risultato di saveAs in caso non cera nessun file selezionato in precedenza.
		public string Save(string text)
		{
			try
			{
				StreamWriter sw = new StreamWriter(ofd.FileName);
				sw.Write(text);
				sw.Close();
				return ofd.FileName;
			} catch(Exception ex)
			{
				return SaveAs(text);
			}
		}

		// SAVE AS
		// return:
		//		Il nuovo percorso del file creato.
		public string SaveAs(string text)
		{
			SaveFileDialog sfd = new SaveFileDialog();
			if (sfd.ShowDialog() != DialogResult.OK) { return "Error"; }
			var path = File.Create(sfd.FileName);
			StreamWriter sw = new StreamWriter(path);
			sw.WriteLine(text);
			sw.Close();
			ofd.FileName = sfd.FileName;
			return sfd.FileName;
		}
	}
}
