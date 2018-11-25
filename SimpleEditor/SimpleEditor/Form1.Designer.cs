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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Editor));
            this.btnOpenFile = new System.Windows.Forms.Button();
            this.txtPercorso = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSalva = new System.Windows.Forms.Button();
            this.btnIndenta = new System.Windows.Forms.Button();
            this.btnSalvaConNome = new System.Windows.Forms.Button();
            this.btnChiudiFile = new System.Windows.Forms.Button();
            this.rBttJson = new System.Windows.Forms.RadioButton();
            this.rBttXml = new System.Windows.Forms.RadioButton();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.numberedRTB1 = new AboControls.UserControls.NumberedRTB();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
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
            this.txtPercorso.Location = new System.Drawing.Point(93, 14);
            this.txtPercorso.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtPercorso.Name = "txtPercorso";
            this.txtPercorso.ReadOnly = true;
            this.txtPercorso.Size = new System.Drawing.Size(719, 22);
            this.txtPercorso.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 17);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Percorso:";
            // 
            // btnSalva
            // 
            this.btnSalva.Location = new System.Drawing.Point(277, 66);
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
            this.btnIndenta.Location = new System.Drawing.Point(567, 66);
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
            this.btnSalvaConNome.Location = new System.Drawing.Point(407, 66);
            this.btnSalvaConNome.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSalvaConNome.Name = "btnSalvaConNome";
            this.btnSalvaConNome.Size = new System.Drawing.Size(131, 28);
            this.btnSalvaConNome.TabIndex = 6;
            this.btnSalvaConNome.Text = "Salva con nome";
            this.btnSalvaConNome.UseVisualStyleBackColor = true;
            this.btnSalvaConNome.Click += new System.EventHandler(this.btnSalvaConNome_Click);
            // 
            // btnChiudiFile
            // 
            this.btnChiudiFile.Location = new System.Drawing.Point(141, 66);
            this.btnChiudiFile.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnChiudiFile.Name = "btnChiudiFile";
            this.btnChiudiFile.Size = new System.Drawing.Size(100, 30);
            this.btnChiudiFile.TabIndex = 7;
            this.btnChiudiFile.Text = "Chiudi file";
            this.btnChiudiFile.UseVisualStyleBackColor = true;
            this.btnChiudiFile.Click += new System.EventHandler(this.btnChiudiFile_Click);
            // 
            // rBttJson
            // 
            this.rBttJson.AutoSize = true;
            this.rBttJson.Location = new System.Drawing.Point(685, 71);
            this.rBttJson.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rBttJson.Name = "rBttJson";
            this.rBttJson.Size = new System.Drawing.Size(66, 21);
            this.rBttJson.TabIndex = 8;
            this.rBttJson.Text = "JSON";
            this.rBttJson.UseVisualStyleBackColor = true;
            this.rBttJson.CheckedChanged += new System.EventHandler(this.rBttJson_CheckedChanged);
            // 
            // rBttXml
            // 
            this.rBttXml.AutoSize = true;
            this.rBttXml.Location = new System.Drawing.Point(757, 71);
            this.rBttXml.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rBttXml.Name = "rBttXml";
            this.rBttXml.Size = new System.Drawing.Size(57, 21);
            this.rBttXml.TabIndex = 9;
            this.rBttXml.Text = "XML";
            this.rBttXml.UseVisualStyleBackColor = true;
            // 
            // numberedRTB1
            // 
            this.numberedRTB1.BackColor = System.Drawing.SystemColors.Window;
            this.numberedRTB1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.numberedRTB1.Location = new System.Drawing.Point(19, 118);
            this.numberedRTB1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.numberedRTB1.Name = "numberedRTB1";
            this.numberedRTB1.Size = new System.Drawing.Size(795, 275);
            this.numberedRTB1.TabIndex = 10;
            // 
            // Form_Editor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(828, 406);
            this.Controls.Add(this.numberedRTB1);
            this.Controls.Add(this.rBttXml);
            this.Controls.Add(this.rBttJson);
            this.Controls.Add(this.btnChiudiFile);
            this.Controls.Add(this.btnSalvaConNome);
            this.Controls.Add(this.btnIndenta);
            this.Controls.Add(this.btnSalva);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtPercorso);
            this.Controls.Add(this.btnOpenFile);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MinimumSize = new System.Drawing.Size(845, 442);
            this.Name = "Form_Editor";
            this.Text = "Simple Editor";
            this.SizeChanged += new System.EventHandler(this.Editor_SizeChanged);
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnOpenFile;
        private System.Windows.Forms.TextBox txtPercorso;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSalva;
        private System.Windows.Forms.Button btnIndenta;
        private System.Windows.Forms.Button btnSalvaConNome;
        private System.Windows.Forms.Button btnChiudiFile;
        private System.Windows.Forms.RadioButton rBttJson;
        private System.Windows.Forms.RadioButton rBttXml;
        private System.Windows.Forms.BindingSource bindingSource1;
        private AboControls.UserControls.NumberedRTB numberedRTB1;
    }
}

