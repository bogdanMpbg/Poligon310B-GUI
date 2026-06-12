namespace bmpoligon
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
            this.panelPoligon = new System.Windows.Forms.Panel();
            this.listBoxTacke = new System.Windows.Forms.ListBox();
            this.buttonDodaj = new System.Windows.Forms.Button();
            this.labelx = new System.Windows.Forms.Label();
            this.labely = new System.Windows.Forms.Label();
            this.textBoxX = new System.Windows.Forms.TextBox();
            this.textBoxY = new System.Windows.Forms.TextBox();
            this.buttonNapravi = new System.Windows.Forms.Button();
            this.buttonObrisi = new System.Windows.Forms.Button();
            this.buttonOcisti = new System.Windows.Forms.Button();
            this.buttonUcitaj = new System.Windows.Forms.Button();
            this.buttonSnimi = new System.Windows.Forms.Button();
            this.buttonNacrtaj = new System.Windows.Forms.Button();
            this.buttonIzmeni = new System.Windows.Forms.Button();
            this.buttonProst = new System.Windows.Forms.Button();
            this.buttonKonveksan = new System.Windows.Forms.Button();
            this.buttonPovrsina = new System.Windows.Forms.Button();
            this.buttonBoja = new System.Windows.Forms.Button();
            this.checkBoxIvice = new System.Windows.Forms.CheckBox();
            this.checkBoxTacke = new System.Windows.Forms.CheckBox();
            this.buttonSlika = new System.Windows.Forms.Button();
            this.checkBoxMreza = new System.Windows.Forms.CheckBox();
            this.buttonUbaci = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // panelPoligon
            // 
            this.panelPoligon.Location = new System.Drawing.Point(813, 15);
            this.panelPoligon.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panelPoligon.Name = "panelPoligon";
            this.panelPoligon.Size = new System.Drawing.Size(889, 757);
            this.panelPoligon.TabIndex = 0;
            this.panelPoligon.MouseWheel += new System.Windows.Forms.MouseEventHandler(this.panelPoligon_Scroll);
            this.panelPoligon.Paint += new System.Windows.Forms.PaintEventHandler(this.panelPoligon_Paint);
            this.panelPoligon.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelPoligon_MouseDown);
            this.panelPoligon.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panelPoligon_MouseMove);
            this.panelPoligon.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panelPoligon_MouseUp);
            // 
            // listBoxTacke
            // 
            this.listBoxTacke.FormattingEnabled = true;
            this.listBoxTacke.ItemHeight = 16;
            this.listBoxTacke.Items.AddRange(new object[] {
            "(0, 0)",
            "(5, 3)",
            "(7, 0)"});
            this.listBoxTacke.Location = new System.Drawing.Point(17, 426);
            this.listBoxTacke.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.listBoxTacke.Name = "listBoxTacke";
            this.listBoxTacke.Size = new System.Drawing.Size(787, 324);
            this.listBoxTacke.TabIndex = 1;
            this.listBoxTacke.SelectedIndexChanged += new System.EventHandler(this.listBoxTacke_SelectedIndexChanged);
            // 
            // buttonDodaj
            // 
            this.buttonDodaj.Location = new System.Drawing.Point(188, 389);
            this.buttonDodaj.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonDodaj.Name = "buttonDodaj";
            this.buttonDodaj.Size = new System.Drawing.Size(100, 28);
            this.buttonDodaj.TabIndex = 2;
            this.buttonDodaj.Text = "Dodaj";
            this.buttonDodaj.UseVisualStyleBackColor = true;
            this.buttonDodaj.Click += new System.EventHandler(this.buttonDodaj_Click);
            // 
            // labelx
            // 
            this.labelx.AutoSize = true;
            this.labelx.Location = new System.Drawing.Point(16, 364);
            this.labelx.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelx.Name = "labelx";
            this.labelx.Size = new System.Drawing.Size(18, 16);
            this.labelx.TabIndex = 3;
            this.labelx.Text = "X:";
            // 
            // labely
            // 
            this.labely.AutoSize = true;
            this.labely.Location = new System.Drawing.Point(16, 398);
            this.labely.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labely.Name = "labely";
            this.labely.Size = new System.Drawing.Size(19, 16);
            this.labely.TabIndex = 4;
            this.labely.Text = "Y:";
            // 
            // textBoxX
            // 
            this.textBoxX.Location = new System.Drawing.Point(47, 361);
            this.textBoxX.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxX.Name = "textBoxX";
            this.textBoxX.Size = new System.Drawing.Size(132, 22);
            this.textBoxX.TabIndex = 5;
            // 
            // textBoxY
            // 
            this.textBoxY.Location = new System.Drawing.Point(47, 393);
            this.textBoxY.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxY.Name = "textBoxY";
            this.textBoxY.Size = new System.Drawing.Size(132, 22);
            this.textBoxY.TabIndex = 6;
            // 
            // buttonNapravi
            // 
            this.buttonNapravi.Location = new System.Drawing.Point(705, 391);
            this.buttonNapravi.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonNapravi.Name = "buttonNapravi";
            this.buttonNapravi.Size = new System.Drawing.Size(100, 28);
            this.buttonNapravi.TabIndex = 7;
            this.buttonNapravi.Text = "Napravi";
            this.buttonNapravi.UseVisualStyleBackColor = true;
            this.buttonNapravi.Click += new System.EventHandler(this.buttonNapravi_Click);
            // 
            // buttonObrisi
            // 
            this.buttonObrisi.Location = new System.Drawing.Point(404, 389);
            this.buttonObrisi.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonObrisi.Name = "buttonObrisi";
            this.buttonObrisi.Size = new System.Drawing.Size(100, 28);
            this.buttonObrisi.TabIndex = 8;
            this.buttonObrisi.Text = "Obrisi";
            this.buttonObrisi.UseVisualStyleBackColor = true;
            this.buttonObrisi.Click += new System.EventHandler(this.buttonObrisi_Click);
            // 
            // buttonOcisti
            // 
            this.buttonOcisti.Location = new System.Drawing.Point(512, 389);
            this.buttonOcisti.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonOcisti.Name = "buttonOcisti";
            this.buttonOcisti.Size = new System.Drawing.Size(100, 28);
            this.buttonOcisti.TabIndex = 9;
            this.buttonOcisti.Text = "Ocisti";
            this.buttonOcisti.UseVisualStyleBackColor = true;
            this.buttonOcisti.Click += new System.EventHandler(this.buttonOcisti_Click);
            // 
            // buttonUcitaj
            // 
            this.buttonUcitaj.Location = new System.Drawing.Point(16, 15);
            this.buttonUcitaj.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonUcitaj.Name = "buttonUcitaj";
            this.buttonUcitaj.Size = new System.Drawing.Size(100, 28);
            this.buttonUcitaj.TabIndex = 10;
            this.buttonUcitaj.Text = "Ucitaj";
            this.buttonUcitaj.UseVisualStyleBackColor = true;
            this.buttonUcitaj.Click += new System.EventHandler(this.buttonUcitaj_Click);
            // 
            // buttonSnimi
            // 
            this.buttonSnimi.Location = new System.Drawing.Point(16, 50);
            this.buttonSnimi.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonSnimi.Name = "buttonSnimi";
            this.buttonSnimi.Size = new System.Drawing.Size(100, 28);
            this.buttonSnimi.TabIndex = 11;
            this.buttonSnimi.Text = "Snimi";
            this.buttonSnimi.UseVisualStyleBackColor = true;
            this.buttonSnimi.Click += new System.EventHandler(this.buttonSnimi_Click);
            // 
            // buttonNacrtaj
            // 
            this.buttonNacrtaj.Location = new System.Drawing.Point(705, 358);
            this.buttonNacrtaj.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonNacrtaj.Name = "buttonNacrtaj";
            this.buttonNacrtaj.Size = new System.Drawing.Size(100, 28);
            this.buttonNacrtaj.TabIndex = 12;
            this.buttonNacrtaj.Text = "Nacrtaj";
            this.buttonNacrtaj.UseVisualStyleBackColor = true;
            this.buttonNacrtaj.Click += new System.EventHandler(this.buttonNacrtaj_Click);
            // 
            // buttonIzmeni
            // 
            this.buttonIzmeni.Location = new System.Drawing.Point(296, 389);
            this.buttonIzmeni.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonIzmeni.Name = "buttonIzmeni";
            this.buttonIzmeni.Size = new System.Drawing.Size(100, 28);
            this.buttonIzmeni.TabIndex = 13;
            this.buttonIzmeni.Text = "Izmeni";
            this.buttonIzmeni.UseVisualStyleBackColor = true;
            this.buttonIzmeni.Click += new System.EventHandler(this.buttonIzmeni_Click);
            // 
            // buttonProst
            // 
            this.buttonProst.Location = new System.Drawing.Point(124, 15);
            this.buttonProst.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonProst.Name = "buttonProst";
            this.buttonProst.Size = new System.Drawing.Size(100, 28);
            this.buttonProst.TabIndex = 14;
            this.buttonProst.Text = "Prost";
            this.buttonProst.UseVisualStyleBackColor = true;
            this.buttonProst.Click += new System.EventHandler(this.buttonProst_Click);
            // 
            // buttonKonveksan
            // 
            this.buttonKonveksan.Location = new System.Drawing.Point(124, 50);
            this.buttonKonveksan.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonKonveksan.Name = "buttonKonveksan";
            this.buttonKonveksan.Size = new System.Drawing.Size(100, 28);
            this.buttonKonveksan.TabIndex = 15;
            this.buttonKonveksan.Text = "Konveksan";
            this.buttonKonveksan.UseVisualStyleBackColor = true;
            this.buttonKonveksan.Click += new System.EventHandler(this.buttonKonveksan_Click);
            // 
            // buttonPovrsina
            // 
            this.buttonPovrsina.Location = new System.Drawing.Point(124, 86);
            this.buttonPovrsina.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonPovrsina.Name = "buttonPovrsina";
            this.buttonPovrsina.Size = new System.Drawing.Size(100, 28);
            this.buttonPovrsina.TabIndex = 16;
            this.buttonPovrsina.Text = "Povrsina";
            this.buttonPovrsina.UseVisualStyleBackColor = true;
            this.buttonPovrsina.Click += new System.EventHandler(this.buttonPovrsina_Click);
            // 
            // buttonBoja
            // 
            this.buttonBoja.Location = new System.Drawing.Point(705, 15);
            this.buttonBoja.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonBoja.Name = "buttonBoja";
            this.buttonBoja.Size = new System.Drawing.Size(100, 28);
            this.buttonBoja.TabIndex = 17;
            this.buttonBoja.Text = "Boja";
            this.buttonBoja.UseVisualStyleBackColor = true;
            this.buttonBoja.Click += new System.EventHandler(this.buttonBoja_Click);
            // 
            // checkBoxIvice
            // 
            this.checkBoxIvice.AutoSize = true;
            this.checkBoxIvice.Checked = true;
            this.checkBoxIvice.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxIvice.Location = new System.Drawing.Point(705, 50);
            this.checkBoxIvice.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.checkBoxIvice.Name = "checkBoxIvice";
            this.checkBoxIvice.Size = new System.Drawing.Size(54, 20);
            this.checkBoxIvice.TabIndex = 18;
            this.checkBoxIvice.Text = "Ivice";
            this.checkBoxIvice.UseVisualStyleBackColor = true;
            this.checkBoxIvice.CheckedChanged += new System.EventHandler(this.checkBoxIvice_CheckedChanged);
            // 
            // checkBoxTacke
            // 
            this.checkBoxTacke.AutoSize = true;
            this.checkBoxTacke.Checked = true;
            this.checkBoxTacke.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxTacke.Location = new System.Drawing.Point(705, 79);
            this.checkBoxTacke.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.checkBoxTacke.Name = "checkBoxTacke";
            this.checkBoxTacke.Size = new System.Drawing.Size(65, 20);
            this.checkBoxTacke.TabIndex = 19;
            this.checkBoxTacke.Text = "Tacke";
            this.checkBoxTacke.UseVisualStyleBackColor = true;
            this.checkBoxTacke.CheckedChanged += new System.EventHandler(this.checkBoxTacke_CheckedChanged);
            // 
            // buttonSlika
            // 
            this.buttonSlika.Location = new System.Drawing.Point(16, 86);
            this.buttonSlika.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonSlika.Name = "buttonSlika";
            this.buttonSlika.Size = new System.Drawing.Size(100, 28);
            this.buttonSlika.TabIndex = 20;
            this.buttonSlika.Text = "Slika";
            this.buttonSlika.UseVisualStyleBackColor = true;
            this.buttonSlika.Click += new System.EventHandler(this.buttonSlika_Click);
            // 
            // checkBoxMreza
            // 
            this.checkBoxMreza.AutoSize = true;
            this.checkBoxMreza.Location = new System.Drawing.Point(705, 108);
            this.checkBoxMreza.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.checkBoxMreza.Name = "checkBoxMreza";
            this.checkBoxMreza.Size = new System.Drawing.Size(63, 20);
            this.checkBoxMreza.TabIndex = 21;
            this.checkBoxMreza.Text = "Mreza";
            this.checkBoxMreza.UseVisualStyleBackColor = true;
            this.checkBoxMreza.CheckedChanged += new System.EventHandler(this.checkBoxMreza_CheckedChanged);
            // 
            // buttonUbaci
            // 
            this.buttonUbaci.Location = new System.Drawing.Point(188, 358);
            this.buttonUbaci.Margin = new System.Windows.Forms.Padding(4);
            this.buttonUbaci.Name = "buttonUbaci";
            this.buttonUbaci.Size = new System.Drawing.Size(100, 28);
            this.buttonUbaci.TabIndex = 22;
            this.buttonUbaci.Text = "Ubaci";
            this.buttonUbaci.UseVisualStyleBackColor = true;
            this.buttonUbaci.Click += new System.EventHandler(this.buttonUbaci_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1719, 786);
            this.Controls.Add(this.buttonUbaci);
            this.Controls.Add(this.checkBoxMreza);
            this.Controls.Add(this.buttonSlika);
            this.Controls.Add(this.checkBoxTacke);
            this.Controls.Add(this.checkBoxIvice);
            this.Controls.Add(this.buttonBoja);
            this.Controls.Add(this.buttonPovrsina);
            this.Controls.Add(this.buttonKonveksan);
            this.Controls.Add(this.buttonProst);
            this.Controls.Add(this.buttonIzmeni);
            this.Controls.Add(this.buttonNacrtaj);
            this.Controls.Add(this.buttonSnimi);
            this.Controls.Add(this.buttonUcitaj);
            this.Controls.Add(this.buttonOcisti);
            this.Controls.Add(this.buttonObrisi);
            this.Controls.Add(this.buttonNapravi);
            this.Controls.Add(this.textBoxY);
            this.Controls.Add(this.textBoxX);
            this.Controls.Add(this.labely);
            this.Controls.Add(this.labelx);
            this.Controls.Add(this.buttonDodaj);
            this.Controls.Add(this.listBoxTacke);
            this.Controls.Add(this.panelPoligon);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelPoligon;
        private System.Windows.Forms.ListBox listBoxTacke;
        private System.Windows.Forms.Button buttonDodaj;
        private System.Windows.Forms.Label labelx;
        private System.Windows.Forms.Label labely;
        private System.Windows.Forms.TextBox textBoxX;
        private System.Windows.Forms.TextBox textBoxY;
        private System.Windows.Forms.Button buttonNapravi;
        private System.Windows.Forms.Button buttonObrisi;
        private System.Windows.Forms.Button buttonOcisti;
        private System.Windows.Forms.Button buttonUcitaj;
        private System.Windows.Forms.Button buttonSnimi;
        private System.Windows.Forms.Button buttonNacrtaj;
        private System.Windows.Forms.Button buttonIzmeni;
        private System.Windows.Forms.Button buttonProst;
        private System.Windows.Forms.Button buttonKonveksan;
        private System.Windows.Forms.Button buttonPovrsina;
        private System.Windows.Forms.Button buttonBoja;
        private System.Windows.Forms.CheckBox checkBoxIvice;
        private System.Windows.Forms.CheckBox checkBoxTacke;
        private System.Windows.Forms.Button buttonSlika;
        private System.Windows.Forms.CheckBox checkBoxMreza;
        private System.Windows.Forms.Button buttonUbaci;
    }
}

