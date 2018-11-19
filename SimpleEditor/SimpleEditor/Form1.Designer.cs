namespace SimpleEditor
{
    partial class Form_Editor
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Editor));
			this.btnOpenFile = new System.Windows.Forms.Button();
			this.txtPercorso = new System.Windows.Forms.TextBox();
			this.rTxtBody = new System.Windows.Forms.RichTextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.btnSalva = new System.Windows.Forms.Button();
			this.btnIndenta = new System.Windows.Forms.Button();
			this.btnSalvaConNome = new System.Windows.Forms.Button();
			this.btnChiudiFile = new System.Windows.Forms.Button();
			this.rBttJson = new System.Windows.Forms.RadioButton();
			this.rBttXml = new System.Windows.Forms.RadioButton();
			this.SuspendLayout();
			// 
			// btnOpenFile
			// 
			this.btnOpenFile.Location = new System.Drawing.Point(12, 53);
			this.btnOpenFile.Name = "btnOpenFile";
			this.btnOpenFile.Size = new System.Drawing.Size(75, 23);
			this.btnOpenFile.TabIndex = 0;
			this.btnOpenFile.Text = "Apri file";
			this.btnOpenFile.UseVisualStyleBackColor = true;
			this.btnOpenFile.Click += new System.EventHandler(this.btnOpenFile_Click);
			// 
			// txtPercorso
			// 
			this.txtPercorso.Location = new System.Drawing.Point(70, 11);
			this.txtPercorso.Name = "txtPercorso";
			this.txtPercorso.ReadOnly = true;
			this.txtPercorso.Size = new System.Drawing.Size(540, 20);
			this.txtPercorso.TabIndex = 1;
			// 
			// rTxtBody
			// 
			this.rTxtBody.AcceptsTab = true;
			this.rTxtBody.Location = new System.Drawing.Point(12, 93);
			this.rTxtBody.Name = "rTxtBody";
			this.rTxtBody.Size = new System.Drawing.Size(598, 224);
			this.rTxtBody.TabIndex = 2;
			this.rTxtBody.Text = "";
			this.rTxtBody.TextChanged += new System.EventHandler(this.rTxtBody_TextChanged);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(12, 14);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(52, 13);
			this.label1.TabIndex = 3;
			this.label1.Text = "Percorso:";
			// 
			// btnSalva
			// 
			this.btnSalva.Location = new System.Drawing.Point(208, 54);
			this.btnSalva.Name = "btnSalva";
			this.btnSalva.Size = new System.Drawing.Size(75, 23);
			this.btnSalva.TabIndex = 4;
			this.btnSalva.Text = "Salva";
			this.btnSalva.UseVisualStyleBackColor = true;
			this.btnSalva.Click += new System.EventHandler(this.btnSalva_Click);
			// 
			// btnIndenta
			// 
			this.btnIndenta.Location = new System.Drawing.Point(425, 54);
			this.btnIndenta.Name = "btnIndenta";
			this.btnIndenta.Size = new System.Drawing.Size(75, 23);
			this.btnIndenta.TabIndex = 5;
			this.btnIndenta.Text = "Indenta";
			this.btnIndenta.UseVisualStyleBackColor = true;
			this.btnIndenta.Click += new System.EventHandler(this.btnIndenta_Click);
			// 
			// btnSalvaConNome
			// 
			this.btnSalvaConNome.Location = new System.Drawing.Point(305, 54);
			this.btnSalvaConNome.Margin = new System.Windows.Forms.Padding(2);
			this.btnSalvaConNome.Name = "btnSalvaConNome";
			this.btnSalvaConNome.Size = new System.Drawing.Size(98, 23);
			this.btnSalvaConNome.TabIndex = 6;
			this.btnSalvaConNome.Text = "Salva con nome";
			this.btnSalvaConNome.UseVisualStyleBackColor = true;
			this.btnSalvaConNome.Click += new System.EventHandler(this.btnSalvaConNome_Click);
			// 
			// btnChiudiFile
			// 
			this.btnChiudiFile.Location = new System.Drawing.Point(106, 54);
			this.btnChiudiFile.Margin = new System.Windows.Forms.Padding(2);
			this.btnChiudiFile.Name = "btnChiudiFile";
			this.btnChiudiFile.Size = new System.Drawing.Size(75, 24);
			this.btnChiudiFile.TabIndex = 7;
			this.btnChiudiFile.Text = "Chiudi file";
			this.btnChiudiFile.UseVisualStyleBackColor = true;
			this.btnChiudiFile.Click += new System.EventHandler(this.btnChiudiFile_Click);
			// 
			// rBttJson
			// 
			this.rBttJson.AutoSize = true;
			this.rBttJson.Location = new System.Drawing.Point(514, 58);
			this.rBttJson.Margin = new System.Windows.Forms.Padding(2);
			this.rBttJson.Name = "rBttJson";
			this.rBttJson.Size = new System.Drawing.Size(53, 17);
			this.rBttJson.TabIndex = 8;
			this.rBttJson.Text = "JSON";
			this.rBttJson.UseVisualStyleBackColor = true;
			this.rBttJson.CheckedChanged += new System.EventHandler(this.rBttJson_CheckedChanged);
			// 
			// rBttXml
			// 
			this.rBttXml.AutoSize = true;
			this.rBttXml.Location = new System.Drawing.Point(568, 58);
			this.rBttXml.Margin = new System.Windows.Forms.Padding(2);
			this.rBttXml.Name = "rBttXml";
			this.rBttXml.Size = new System.Drawing.Size(47, 17);
			this.rBttXml.TabIndex = 9;
			this.rBttXml.Text = "XML";
			this.rBttXml.UseVisualStyleBackColor = true;
			// 
			// Form_Editor
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(622, 329);
			this.Controls.Add(this.rBttXml);
			this.Controls.Add(this.rBttJson);
			this.Controls.Add(this.btnChiudiFile);
			this.Controls.Add(this.btnSalvaConNome);
			this.Controls.Add(this.btnIndenta);
			this.Controls.Add(this.btnSalva);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.rTxtBody);
			this.Controls.Add(this.txtPercorso);
			this.Controls.Add(this.btnOpenFile);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MinimumSize = new System.Drawing.Size(638, 368);
			this.Name = "Form_Editor";
			this.Text = "Simple Editor";
			this.SizeChanged += new System.EventHandler(this.Editor_SizeChanged);
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
        private System.Windows.Forms.RadioButton rBttJson;
        private System.Windows.Forms.RadioButton rBttXml;
    }
}

