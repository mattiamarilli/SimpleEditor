namespace SimpleEditor
{
    partial class Form1
    {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Pulire le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btnOpenFile = new System.Windows.Forms.Button();
            this.txtPercorso = new System.Windows.Forms.TextBox();
            this.rTxtBody = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSalva = new System.Windows.Forms.Button();
            this.btnIndenta = new System.Windows.Forms.Button();
            this.btnSalvaConNome = new System.Windows.Forms.Button();
            this.btnChiudiFile = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnOpenFile
            // 
            this.btnOpenFile.Location = new System.Drawing.Point(16, 65);
            this.btnOpenFile.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnOpenFile.Name = "btnOpenFile";
            this.btnOpenFile.Size = new System.Drawing.Size(100, 28);
            this.btnOpenFile.TabIndex = 0;
            this.btnOpenFile.Text = "Apri file";
            this.btnOpenFile.UseVisualStyleBackColor = true;
            this.btnOpenFile.Click += new System.EventHandler(this.btnOpenFile_Click);
            // 
            // txtPercorso
            // 
            this.txtPercorso.Location = new System.Drawing.Point(105, 13);
            this.txtPercorso.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtPercorso.Name = "txtPercorso";
            this.txtPercorso.ReadOnly = true;
            this.txtPercorso.Size = new System.Drawing.Size(676, 22);
            this.txtPercorso.TabIndex = 1;
            // 
            // rTxtBody
            // 
            this.rTxtBody.Location = new System.Drawing.Point(16, 114);
            this.rTxtBody.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rTxtBody.Name = "rTxtBody";
            this.rTxtBody.Size = new System.Drawing.Size(765, 274);
            this.rTxtBody.TabIndex = 2;
            this.rTxtBody.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 13);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Percorso:";
            // 
            // btnSalva
            // 
            this.btnSalva.Location = new System.Drawing.Point(278, 67);
            this.btnSalva.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSalva.Name = "btnSalva";
            this.btnSalva.Size = new System.Drawing.Size(100, 28);
            this.btnSalva.TabIndex = 4;
            this.btnSalva.Text = "Salva";
            this.btnSalva.UseVisualStyleBackColor = true;
            this.btnSalva.Click += new System.EventHandler(this.btnSalva_Click);
            // 
            // btnIndenta
            // 
            this.btnIndenta.Location = new System.Drawing.Point(567, 67);
            this.btnIndenta.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnIndenta.Name = "btnIndenta";
            this.btnIndenta.Size = new System.Drawing.Size(100, 28);
            this.btnIndenta.TabIndex = 5;
            this.btnIndenta.Text = "Indenta";
            this.btnIndenta.UseVisualStyleBackColor = true;
            this.btnIndenta.Click += new System.EventHandler(this.btnIndenta_Click);
            // 
            // btnSalvaConNome
            // 
            this.btnSalvaConNome.Location = new System.Drawing.Point(407, 67);
            this.btnSalvaConNome.Name = "btnSalvaConNome";
            this.btnSalvaConNome.Size = new System.Drawing.Size(130, 28);
            this.btnSalvaConNome.TabIndex = 6;
            this.btnSalvaConNome.Text = "Salva con nome";
            this.btnSalvaConNome.UseVisualStyleBackColor = true;
            // 
            // btnChiudiFile
            // 
            this.btnChiudiFile.Location = new System.Drawing.Point(142, 66);
            this.btnChiudiFile.Name = "btnChiudiFile";
            this.btnChiudiFile.Size = new System.Drawing.Size(100, 29);
            this.btnChiudiFile.TabIndex = 7;
            this.btnChiudiFile.Text = "Chiudi file";
            this.btnChiudiFile.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(813, 415);
            this.Controls.Add(this.btnChiudiFile);
            this.Controls.Add(this.btnSalvaConNome);
            this.Controls.Add(this.btnIndenta);
            this.Controls.Add(this.btnSalva);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.rTxtBody);
            this.Controls.Add(this.txtPercorso);
            this.Controls.Add(this.btnOpenFile);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "EDITOR";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnOpenFile;
        private System.Windows.Forms.TextBox txtPercorso;
        private System.Windows.Forms.RichTextBox rTxtBody;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSalva;
        private System.Windows.Forms.Button btnIndenta;
        private System.Windows.Forms.Button btnSalvaConNome;
        private System.Windows.Forms.Button btnChiudiFile;
    }
}

