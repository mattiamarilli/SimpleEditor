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
        TextLeggiScrivi tls;
		bool changed = false;

        string patternStart = @"({)";
        string patternEnd = @"(})";

        public Form_Editor()
        {
            InitializeComponent();
            tls = new TextLeggiScrivi();
        }

        private void btnOpenFile_Click(object sender, EventArgs e)
        {
			if (changed)
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
			else
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

		private void btnChiudiFile_Click(object sender, EventArgs e)
		{
			tls.ChiudiFile();
			if (changed)
			{
				if (MessageBox.Show("Vuoi uscire senza salvare?", "Attenzione:", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
				{
					rTxtBody.Text = "";
					txtPercorso.Text = "";
					changed = false;
				}
			}
			else
			{
				rTxtBody.Text = "";
				txtPercorso.Text = "";
				changed = false;
			}
		}

		private void btnSalva_Click(object sender, EventArgs e)
        {
			var temp = tls.Save(rTxtBody.Text);
			if (temp != "")
			{
				txtPercorso.Text = temp;
			}
			if (changed)
				txtPercorso.Text = txtPercorso.Text.Remove(txtPercorso.Text.Length - 1);
			changed = false;
		}

		private void btnSalvaConNome_Click(object sender, EventArgs e)
		{
			var temp = tls.SaveAs(rTxtBody.Text);
			if (temp != "")
			{
				txtPercorso.Text = temp;
				if (changed)
					txtPercorso.Text = txtPercorso.Text.Remove(txtPercorso.Text.Length - 1);
			}
			changed = false;
		}

		private void Editor_SizeChanged(object sender, EventArgs e)
		{
			var x = rTxtBody.Size;
			x.Width = this.Width - 40;
			x.Height = this.Height - 144;
			rTxtBody.Size = x;
			// 598; 224 RTXTBOX
			// 638; 368 FORM
			// 368 - 223 = 144
			// 528 - 488 = 40

			var y = txtPercorso.Size;
			y.Width = this.Width - 99;
			txtPercorso.Size = y;
		}

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

		private void rTxtBody_TextChanged(object sender, EventArgs e)
		{
			if (!changed) { txtPercorso.Text += "*"; }
			changed = true;
		}

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
    }

    class TextLeggiScrivi
	{
		private OpenFileDialog ofd;

		public TextLeggiScrivi() {
			ofd = new OpenFileDialog();
		}

		public string ApriFile()
		{
			if( ofd.ShowDialog() != DialogResult.OK ) { return ""; }
			return ofd.FileName;
		}

		public void ChiudiFile() {
			ofd = new OpenFileDialog();
		}

		public string ReadFile()
		{
			StreamReader sr = new StreamReader(ofd.FileName);
			var text = sr.ReadToEnd();
			sr.Close();
			return text;
		}

		public string Save(string text)
		{
			try
			{
				StreamWriter sw = new StreamWriter(ofd.FileName);
				sw.Write(text);
				sw.Close();
				return "";
			} catch(Exception ex)
			{
				return SaveAs(text);
			}
		}

		public string SaveAs(string text)
		{
			SaveFileDialog sfd = new SaveFileDialog();
			if (sfd.ShowDialog() != DialogResult.OK) { return ""; }
			var path = File.Create(sfd.FileName);
			StreamWriter sw = new StreamWriter(path);
			sw.WriteLine(text);
			sw.Close();
			ofd.FileName = sfd.FileName;
			return sfd.FileName;
		}
	}
}
