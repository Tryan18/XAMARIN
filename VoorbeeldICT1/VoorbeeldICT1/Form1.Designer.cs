namespace VoorbeeldICT1
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.bestandToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.campagneToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.advertentieToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toevoegenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tbKlantNaam = new System.Windows.Forms.TextBox();
            this.tbCampagneNaam = new System.Windows.Forms.TextBox();
            this.tbCampagneBudget = new System.Windows.Forms.TextBox();
            this.tbCampagneStartdatum = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.tbAdvertentieNaam = new System.Windows.Forms.TextBox();
            this.tbAdvertentieMedium = new System.Windows.Forms.TextBox();
            this.tbAdvertentieContent = new System.Windows.Forms.TextBox();
            this.tbAdvertentieOntwerper = new System.Windows.Forms.TextBox();
            this.btOk = new System.Windows.Forms.Button();
            this.btAdvIdOpvragen = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bestandToolStripMenuItem,
            this.campagneToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(398, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // bestandToolStripMenuItem
            // 
            this.bestandToolStripMenuItem.Name = "bestandToolStripMenuItem";
            this.bestandToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.bestandToolStripMenuItem.Text = "Bestand";
            // 
            // campagneToolStripMenuItem
            // 
            this.campagneToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.advertentieToolStripMenuItem});
            this.campagneToolStripMenuItem.Name = "campagneToolStripMenuItem";
            this.campagneToolStripMenuItem.Size = new System.Drawing.Size(77, 20);
            this.campagneToolStripMenuItem.Text = "Campagne";
            // 
            // advertentieToolStripMenuItem
            // 
            this.advertentieToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toevoegenToolStripMenuItem});
            this.advertentieToolStripMenuItem.Name = "advertentieToolStripMenuItem";
            this.advertentieToolStripMenuItem.Size = new System.Drawing.Size(135, 22);
            this.advertentieToolStripMenuItem.Text = "Advertentie";
            // 
            // toevoegenToolStripMenuItem
            // 
            this.toevoegenToolStripMenuItem.Name = "toevoegenToolStripMenuItem";
            this.toevoegenToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
            this.toevoegenToolStripMenuItem.Text = "Toevoegen";
            // 
            // tbKlantNaam
            // 
            this.tbKlantNaam.Location = new System.Drawing.Point(80, 35);
            this.tbKlantNaam.Name = "tbKlantNaam";
            this.tbKlantNaam.Size = new System.Drawing.Size(100, 20);
            this.tbKlantNaam.TabIndex = 1;
            this.tbKlantNaam.Text = "HSZuyd";
            // 
            // tbCampagneNaam
            // 
            this.tbCampagneNaam.Location = new System.Drawing.Point(80, 62);
            this.tbCampagneNaam.Name = "tbCampagneNaam";
            this.tbCampagneNaam.Size = new System.Drawing.Size(100, 20);
            this.tbCampagneNaam.TabIndex = 2;
            this.tbCampagneNaam.Text = "StartAD";
            // 
            // tbCampagneBudget
            // 
            this.tbCampagneBudget.Location = new System.Drawing.Point(80, 89);
            this.tbCampagneBudget.Name = "tbCampagneBudget";
            this.tbCampagneBudget.Size = new System.Drawing.Size(100, 20);
            this.tbCampagneBudget.TabIndex = 3;
            this.tbCampagneBudget.Text = "0";
            // 
            // tbCampagneStartdatum
            // 
            this.tbCampagneStartdatum.Location = new System.Drawing.Point(80, 116);
            this.tbCampagneStartdatum.Name = "tbCampagneStartdatum";
            this.tbCampagneStartdatum.Size = new System.Drawing.Size(100, 20);
            this.tbCampagneStartdatum.TabIndex = 4;
            this.tbCampagneStartdatum.Text = "1-1-2015";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Klantnaam";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Campagne";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 92);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Budget";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 119);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Startdatum";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(71, 164);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(30, 15);
            this.label5.TabIndex = 9;
            this.label5.Text = "Titel";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(71, 196);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Medium";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(73, 226);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(44, 13);
            this.label7.TabIndex = 11;
            this.label7.Text = "Content";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(72, 259);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(56, 13);
            this.label8.TabIndex = 12;
            this.label8.Text = "Ontwerper";
            // 
            // tbAdvertentieNaam
            // 
            this.tbAdvertentieNaam.Location = new System.Drawing.Point(148, 161);
            this.tbAdvertentieNaam.Name = "tbAdvertentieNaam";
            this.tbAdvertentieNaam.Size = new System.Drawing.Size(100, 20);
            this.tbAdvertentieNaam.TabIndex = 13;
            // 
            // tbAdvertentieMedium
            // 
            this.tbAdvertentieMedium.Location = new System.Drawing.Point(148, 193);
            this.tbAdvertentieMedium.Name = "tbAdvertentieMedium";
            this.tbAdvertentieMedium.Size = new System.Drawing.Size(100, 20);
            this.tbAdvertentieMedium.TabIndex = 14;
            // 
            // tbAdvertentieContent
            // 
            this.tbAdvertentieContent.Location = new System.Drawing.Point(148, 227);
            this.tbAdvertentieContent.Name = "tbAdvertentieContent";
            this.tbAdvertentieContent.Size = new System.Drawing.Size(100, 20);
            this.tbAdvertentieContent.TabIndex = 15;
            // 
            // tbAdvertentieOntwerper
            // 
            this.tbAdvertentieOntwerper.Location = new System.Drawing.Point(148, 256);
            this.tbAdvertentieOntwerper.Name = "tbAdvertentieOntwerper";
            this.tbAdvertentieOntwerper.Size = new System.Drawing.Size(100, 20);
            this.tbAdvertentieOntwerper.TabIndex = 16;
            // 
            // btOk
            // 
            this.btOk.Location = new System.Drawing.Point(77, 293);
            this.btOk.Name = "btOk";
            this.btOk.Size = new System.Drawing.Size(75, 23);
            this.btOk.TabIndex = 17;
            this.btOk.Text = "Ok";
            this.btOk.UseVisualStyleBackColor = true;
            this.btOk.Click += new System.EventHandler(this.btOk_Click);
            // 
            // btAdvIdOpvragen
            // 
            this.btAdvIdOpvragen.Location = new System.Drawing.Point(189, 293);
            this.btAdvIdOpvragen.Name = "btAdvIdOpvragen";
            this.btAdvIdOpvragen.Size = new System.Drawing.Size(75, 23);
            this.btAdvIdOpvragen.TabIndex = 18;
            this.btAdvIdOpvragen.Text = "Adv.opvragen";
            this.btAdvIdOpvragen.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(398, 374);
            this.Controls.Add(this.btAdvIdOpvragen);
            this.Controls.Add(this.btOk);
            this.Controls.Add(this.tbAdvertentieOntwerper);
            this.Controls.Add(this.tbAdvertentieContent);
            this.Controls.Add(this.tbAdvertentieMedium);
            this.Controls.Add(this.tbAdvertentieNaam);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbCampagneStartdatum);
            this.Controls.Add(this.tbCampagneBudget);
            this.Controls.Add(this.tbCampagneNaam);
            this.Controls.Add(this.tbKlantNaam);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem bestandToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem campagneToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem advertentieToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toevoegenToolStripMenuItem;
        private System.Windows.Forms.TextBox tbKlantNaam;
        private System.Windows.Forms.TextBox tbCampagneNaam;
        private System.Windows.Forms.TextBox tbCampagneBudget;
        private System.Windows.Forms.TextBox tbCampagneStartdatum;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tbAdvertentieNaam;
        private System.Windows.Forms.TextBox tbAdvertentieMedium;
        private System.Windows.Forms.TextBox tbAdvertentieContent;
        private System.Windows.Forms.TextBox tbAdvertentieOntwerper;
        private System.Windows.Forms.Button btOk;
        private System.Windows.Forms.Button btAdvIdOpvragen;
    }
}

