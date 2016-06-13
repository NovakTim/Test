namespace WindowsFormsApplication1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.buttonErstellen = new System.Windows.Forms.Button();
            this.textBoxDatum = new System.Windows.Forms.TextBox();
            this.textBoxKundennummer = new System.Windows.Forms.TextBox();
            this.textBoxMenge = new System.Windows.Forms.TextBox();
            this.textBoxArtikelnummer = new System.Windows.Forms.TextBox();
            this.labelMenge = new System.Windows.Forms.Label();
            this.labelKundennummer = new System.Windows.Forms.Label();
            this.labelDatum = new System.Windows.Forms.Label();
            this.labelArtikelnummer = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonErstellen
            // 
            resources.ApplyResources(this.buttonErstellen, "buttonErstellen");
            this.buttonErstellen.Name = "buttonErstellen";
            this.buttonErstellen.UseVisualStyleBackColor = true;
            // 
            // textBoxDatum
            // 
            resources.ApplyResources(this.textBoxDatum, "textBoxDatum");
            this.textBoxDatum.Name = "textBoxDatum";
            // 
            // textBoxKundennummer
            // 
            resources.ApplyResources(this.textBoxKundennummer, "textBoxKundennummer");
            this.textBoxKundennummer.Name = "textBoxKundennummer";
            // 
            // textBoxMenge
            // 
            resources.ApplyResources(this.textBoxMenge, "textBoxMenge");
            this.textBoxMenge.Name = "textBoxMenge";
            // 
            // textBoxArtikelnummer
            // 
            resources.ApplyResources(this.textBoxArtikelnummer, "textBoxArtikelnummer");
            this.textBoxArtikelnummer.Name = "textBoxArtikelnummer";
            // 
            // labelMenge
            // 
            resources.ApplyResources(this.labelMenge, "labelMenge");
            this.labelMenge.Name = "labelMenge";
            // 
            // labelKundennummer
            // 
            resources.ApplyResources(this.labelKundennummer, "labelKundennummer");
            this.labelKundennummer.Name = "labelKundennummer";
            // 
            // labelDatum
            // 
            resources.ApplyResources(this.labelDatum, "labelDatum");
            this.labelDatum.Name = "labelDatum";
            // 
            // labelArtikelnummer
            // 
            resources.ApplyResources(this.labelArtikelnummer, "labelArtikelnummer");
            this.labelArtikelnummer.Name = "labelArtikelnummer";
            // 
            // Form1
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.buttonErstellen);
            this.Controls.Add(this.textBoxDatum);
            this.Controls.Add(this.textBoxKundennummer);
            this.Controls.Add(this.textBoxMenge);
            this.Controls.Add(this.textBoxArtikelnummer);
            this.Controls.Add(this.labelMenge);
            this.Controls.Add(this.labelKundennummer);
            this.Controls.Add(this.labelDatum);
            this.Controls.Add(this.labelArtikelnummer);
            this.Name = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonErstellen;
        private System.Windows.Forms.TextBox textBoxDatum;
        private System.Windows.Forms.TextBox textBoxKundennummer;
        private System.Windows.Forms.TextBox textBoxMenge;
        private System.Windows.Forms.TextBox textBoxArtikelnummer;
        private System.Windows.Forms.Label labelMenge;
        private System.Windows.Forms.Label labelKundennummer;
        private System.Windows.Forms.Label labelDatum;
        private System.Windows.Forms.Label labelArtikelnummer;
    }
}

