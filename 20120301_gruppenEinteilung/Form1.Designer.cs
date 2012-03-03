namespace _20120301_gruppenEinteilung {
    partial class Form1 {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent() {
            this.pnlInput = new System.Windows.Forms.Panel();
            this.lblSolo = new System.Windows.Forms.Label();
            this.btnClear = new System.Windows.Forms.Button();
            this.lblAufgabe2 = new System.Windows.Forms.Label();
            this.lblAufgabe1 = new System.Windows.Forms.Label();
            this.lblSchueler = new System.Windows.Forms.Label();
            this.nudGruppen = new System.Windows.Forms.NumericUpDown();
            this.lblGruppen = new System.Windows.Forms.Label();
            this.nudSchueler = new System.Windows.Forms.NumericUpDown();
            this.lblAnzahl = new System.Windows.Forms.Label();
            this.btnEingeben = new System.Windows.Forms.Button();
            this.pnlAuswahl = new System.Windows.Forms.Panel();
            this.btnEinteilen = new System.Windows.Forms.Button();
            this.pnlAufgabe1 = new System.Windows.Forms.Panel();
            this.pnlAufgabe2 = new System.Windows.Forms.Panel();
            this.lblEinteilungAufgabe1 = new System.Windows.Forms.Label();
            this.lblEinteilungAufgabe2 = new System.Windows.Forms.Label();
            this.pnlInput.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudGruppen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSchueler)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlInput
            // 
            this.pnlInput.Controls.Add(this.lblSolo);
            this.pnlInput.Controls.Add(this.btnClear);
            this.pnlInput.Controls.Add(this.lblAufgabe2);
            this.pnlInput.Controls.Add(this.lblAufgabe1);
            this.pnlInput.Controls.Add(this.lblSchueler);
            this.pnlInput.Controls.Add(this.nudGruppen);
            this.pnlInput.Controls.Add(this.lblGruppen);
            this.pnlInput.Controls.Add(this.nudSchueler);
            this.pnlInput.Controls.Add(this.lblAnzahl);
            this.pnlInput.Controls.Add(this.btnEingeben);
            this.pnlInput.Location = new System.Drawing.Point(12, 12);
            this.pnlInput.Name = "pnlInput";
            this.pnlInput.Size = new System.Drawing.Size(428, 117);
            this.pnlInput.TabIndex = 1;
            // 
            // lblSolo
            // 
            this.lblSolo.AutoSize = true;
            this.lblSolo.Location = new System.Drawing.Point(303, 96);
            this.lblSolo.Name = "lblSolo";
            this.lblSolo.Size = new System.Drawing.Size(68, 13);
            this.lblSolo.TabIndex = 22;
            this.lblSolo.Text = "Einzelgruppe";
            this.lblSolo.Visible = false;
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(226, 43);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 21;
            this.btnClear.Text = "Löschen";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // lblAufgabe2
            // 
            this.lblAufgabe2.AutoSize = true;
            this.lblAufgabe2.Location = new System.Drawing.Point(198, 96);
            this.lblAufgabe2.Name = "lblAufgabe2";
            this.lblAufgabe2.Size = new System.Drawing.Size(56, 13);
            this.lblAufgabe2.TabIndex = 20;
            this.lblAufgabe2.Text = "Aufgabe 2";
            this.lblAufgabe2.Visible = false;
            // 
            // lblAufgabe1
            // 
            this.lblAufgabe1.AutoSize = true;
            this.lblAufgabe1.Location = new System.Drawing.Point(89, 96);
            this.lblAufgabe1.Name = "lblAufgabe1";
            this.lblAufgabe1.Size = new System.Drawing.Size(56, 13);
            this.lblAufgabe1.TabIndex = 19;
            this.lblAufgabe1.Text = "Aufgabe 1";
            this.lblAufgabe1.Visible = false;
            // 
            // lblSchueler
            // 
            this.lblSchueler.AutoSize = true;
            this.lblSchueler.Location = new System.Drawing.Point(8, 96);
            this.lblSchueler.Name = "lblSchueler";
            this.lblSchueler.Size = new System.Drawing.Size(43, 13);
            this.lblSchueler.TabIndex = 18;
            this.lblSchueler.Text = "Schüler";
            this.lblSchueler.Visible = false;
            // 
            // nudGruppen
            // 
            this.nudGruppen.Enabled = false;
            this.nudGruppen.Location = new System.Drawing.Point(97, 46);
            this.nudGruppen.Name = "nudGruppen";
            this.nudGruppen.Size = new System.Drawing.Size(104, 20);
            this.nudGruppen.TabIndex = 17;
            this.nudGruppen.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // lblGruppen
            // 
            this.lblGruppen.AutoSize = true;
            this.lblGruppen.Enabled = false;
            this.lblGruppen.Location = new System.Drawing.Point(8, 53);
            this.lblGruppen.Name = "lblGruppen";
            this.lblGruppen.Size = new System.Drawing.Size(75, 13);
            this.lblGruppen.TabIndex = 16;
            this.lblGruppen.Text = "Gruppengröße";
            // 
            // nudSchueler
            // 
            this.nudSchueler.Location = new System.Drawing.Point(97, 20);
            this.nudSchueler.Name = "nudSchueler";
            this.nudSchueler.Size = new System.Drawing.Size(104, 20);
            this.nudSchueler.TabIndex = 15;
            // 
            // lblAnzahl
            // 
            this.lblAnzahl.AutoSize = true;
            this.lblAnzahl.Location = new System.Drawing.Point(8, 25);
            this.lblAnzahl.Name = "lblAnzahl";
            this.lblAnzahl.Size = new System.Drawing.Size(78, 13);
            this.lblAnzahl.TabIndex = 14;
            this.lblAnzahl.Text = "Anzahl Schüler";
            // 
            // btnEingeben
            // 
            this.btnEingeben.Location = new System.Drawing.Point(226, 17);
            this.btnEingeben.Name = "btnEingeben";
            this.btnEingeben.Size = new System.Drawing.Size(75, 23);
            this.btnEingeben.TabIndex = 13;
            this.btnEingeben.Text = "Eingeben";
            this.btnEingeben.UseVisualStyleBackColor = true;
            this.btnEingeben.Click += new System.EventHandler(this.btnEingeben_Click);
            // 
            // pnlAuswahl
            // 
            this.pnlAuswahl.AutoScroll = true;
            this.pnlAuswahl.Location = new System.Drawing.Point(13, 135);
            this.pnlAuswahl.Name = "pnlAuswahl";
            this.pnlAuswahl.Size = new System.Drawing.Size(427, 417);
            this.pnlAuswahl.TabIndex = 2;
            // 
            // btnEinteilen
            // 
            this.btnEinteilen.Location = new System.Drawing.Point(13, 558);
            this.btnEinteilen.Name = "btnEinteilen";
            this.btnEinteilen.Size = new System.Drawing.Size(75, 23);
            this.btnEinteilen.TabIndex = 3;
            this.btnEinteilen.Text = "Einteilen";
            this.btnEinteilen.UseVisualStyleBackColor = true;
            this.btnEinteilen.Visible = false;
            this.btnEinteilen.Click += new System.EventHandler(this.btnEinteilen_Click);
            // 
            // pnlAufgabe1
            // 
            this.pnlAufgabe1.AutoScroll = true;
            this.pnlAufgabe1.Location = new System.Drawing.Point(446, 135);
            this.pnlAufgabe1.Name = "pnlAufgabe1";
            this.pnlAufgabe1.Size = new System.Drawing.Size(244, 417);
            this.pnlAufgabe1.TabIndex = 4;
            // 
            // pnlAufgabe2
            // 
            this.pnlAufgabe2.AutoScroll = true;
            this.pnlAufgabe2.Location = new System.Drawing.Point(696, 135);
            this.pnlAufgabe2.Name = "pnlAufgabe2";
            this.pnlAufgabe2.Size = new System.Drawing.Size(244, 417);
            this.pnlAufgabe2.TabIndex = 5;
            // 
            // lblEinteilungAufgabe1
            // 
            this.lblEinteilungAufgabe1.AutoSize = true;
            this.lblEinteilungAufgabe1.Location = new System.Drawing.Point(446, 108);
            this.lblEinteilungAufgabe1.Name = "lblEinteilungAufgabe1";
            this.lblEinteilungAufgabe1.Size = new System.Drawing.Size(105, 13);
            this.lblEinteilungAufgabe1.TabIndex = 6;
            this.lblEinteilungAufgabe1.Text = "Einteilung Aufgabe 1";
            this.lblEinteilungAufgabe1.Visible = false;
            // 
            // lblEinteilungAufgabe2
            // 
            this.lblEinteilungAufgabe2.AutoSize = true;
            this.lblEinteilungAufgabe2.Location = new System.Drawing.Point(693, 108);
            this.lblEinteilungAufgabe2.Name = "lblEinteilungAufgabe2";
            this.lblEinteilungAufgabe2.Size = new System.Drawing.Size(105, 13);
            this.lblEinteilungAufgabe2.TabIndex = 7;
            this.lblEinteilungAufgabe2.Text = "Einteilung Aufgabe 2";
            this.lblEinteilungAufgabe2.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(953, 590);
            this.Controls.Add(this.lblEinteilungAufgabe2);
            this.Controls.Add(this.lblEinteilungAufgabe1);
            this.Controls.Add(this.pnlAufgabe2);
            this.Controls.Add(this.pnlAufgabe1);
            this.Controls.Add(this.btnEinteilen);
            this.Controls.Add(this.pnlAuswahl);
            this.Controls.Add(this.pnlInput);
            this.Name = "Form1";
            this.Text = "Gruppenauswahl";
            this.pnlInput.ResumeLayout(false);
            this.pnlInput.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudGruppen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSchueler)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlInput;
        private System.Windows.Forms.Label lblAufgabe2;
        private System.Windows.Forms.Label lblAufgabe1;
        private System.Windows.Forms.Label lblSchueler;
        private System.Windows.Forms.NumericUpDown nudGruppen;
        private System.Windows.Forms.Label lblGruppen;
        private System.Windows.Forms.NumericUpDown nudSchueler;
        private System.Windows.Forms.Label lblAnzahl;
        private System.Windows.Forms.Button btnEingeben;
        private System.Windows.Forms.Panel pnlAuswahl;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Label lblSolo;
        private System.Windows.Forms.Button btnEinteilen;
        private System.Windows.Forms.Panel pnlAufgabe1;
        private System.Windows.Forms.Panel pnlAufgabe2;
        private System.Windows.Forms.Label lblEinteilungAufgabe1;
        private System.Windows.Forms.Label lblEinteilungAufgabe2;


    }
}

