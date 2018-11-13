using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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
            tls.ApriFile();
            txtPercorso.Text = tls.getPercorso();
        }

        private void btnSalva_Click(object sender, EventArgs e)
        {

        }

        private void btnIndenta_Click(object sender, EventArgs e)
        {

        }
    }

    class TextLeggiScrivi
    {
        OpenFileDialog ofd;

        public TextLeggiScrivi()
        {
            ofd = new OpenFileDialog();
        }

        public void ApriFile()
        {
            ofd.ShowDialog();
            
        }

        public string getPercorso()
        {
            return ofd.FileName;
        }
    }
}
