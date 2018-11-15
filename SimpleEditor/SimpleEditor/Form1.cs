using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimpleEditor
{
    public partial class Form1 : Form
    {
        TextLeggiScrivi tls;

        public Form1()
        {
            InitializeComponent();
            tls = new TextLeggiScrivi();
        }

        private void btnOpenFile_Click(object sender, EventArgs e)
        {
			var temp = tls.ApriFile();
			if (temp != "")
			{
				txtPercorso.Text = temp;
				rTxtBody.Text = tls.ReadFile();
			}
		}

		private void btnChiudiFile_Click(object sender, EventArgs e)
		{
			tls.ChiudiFile();
			txtPercorso.Text = "";
		}

		private void btnSalva_Click(object sender, EventArgs e)
        {
			var temp = tls.Save(rTxtBody.Text);
			if (temp != "")
			{
				txtPercorso.Text = temp;
			}
		}

		private void btnSalvaConNome_Click(object sender, EventArgs e)
		{
			var temp = tls.SaveAs(rTxtBody.Text);
			if (temp != "")
			{
				txtPercorso.Text = temp;
			}
		}

		private void btnIndenta_Click(object sender, EventArgs e)
        {
			
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
