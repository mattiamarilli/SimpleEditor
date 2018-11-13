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
			this.btnOpenFile = new System.Windows.Forms.Button();
			this.txtPercorso = new System.Windows.Forms.TextBox();
			this.rTxtBody = new System.Windows.Forms.RichTextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.btnSalva = new System.Windows.Forms.Button();
			this.btnIndenta = new System.Windows.Forms.Button();
			this.label2 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// btnOpenFile
			// 
			this.btnOpenFile.Location = new System.Drawing.Point(511, 45);
			this.btnOpenFile.Name = "btnOpenFile";
			this.btnOpenFile.Size = new System.Drawing.Size(75, 23);
			this.btnOpenFile.TabIndex = 0;
			this.btnOpenFile.Text = "Apri file";
			this.btnOpenFile.UseVisualStyleBackColor = true;
			this.btnOpenFile.Click += new System.EventHandler(this.btnOpenFile_Click);
			// 
			// txtPercorso
			// 
			this.txtPercorso.Location = new System.Drawing.Point(70, 45);
			this.txtPercorso.Name = "txtPercorso";
			this.txtPercorso.Size = new System.Drawing.Size(420, 20);
			this.txtPercorso.TabIndex = 1;
			// 
			// rTxtBody
			// 
			this.rTxtBody.Location = new System.Drawing.Point(12, 93);
			this.rTxtBody.Name = "rTxtBody";
			this.rTxtBody.Size = new System.Drawing.Size(478, 223);
			this.rTxtBody.TabIndex = 2;
			this.rTxtBody.Text = "";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(12, 48);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(52, 13);
			this.label1.TabIndex = 3;
			this.label1.Text = "Percorso:";
			// 
			// btnSalva
			// 
			this.btnSalva.Location = new System.Drawing.Point(511, 93);
			this.btnSalva.Name = "btnSalva";
			this.btnSalva.Size = new System.Drawing.Size(75, 23);
			this.btnSalva.TabIndex = 4;
			this.btnSalva.Text = "Salva";
			this.btnSalva.UseVisualStyleBackColor = true;
			this.btnSalva.Click += new System.EventHandler(this.btnSalva_Click);
			// 
			// btnIndenta
			// 
			this.btnIndenta.Location = new System.Drawing.Point(511, 139);
			this.btnIndenta.Name = "btnIndenta";
			this.btnIndenta.Size = new System.Drawing.Size(75, 23);
			this.btnIndenta.TabIndex = 5;
			this.btnIndenta.Text = "Indenta";
			this.btnIndenta.UseVisualStyleBackColor = true;
			this.btnIndenta.Click += new System.EventHandler(this.btnIndenta_Click);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Calibri", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(235, 9);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(140, 33);
			this.label2.TabIndex = 6;
			this.label2.Text = "Editor Bello";
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(610, 337);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.btnIndenta);
			this.Controls.Add(this.btnSalva);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.rTxtBody);
			this.Controls.Add(this.txtPercorso);
			this.Controls.Add(this.btnOpenFile);
			this.Name = "Form1";
			this.Text = "Editor";
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
        private System.Windows.Forms.Label label2;
    }
}

