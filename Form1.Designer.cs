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
            this.textPoligon = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // panelPoligon
            // 
            this.panelPoligon.Location = new System.Drawing.Point(610, 12);
            this.panelPoligon.Name = "panelPoligon";
            this.panelPoligon.Size = new System.Drawing.Size(667, 615);
            this.panelPoligon.TabIndex = 0;
            this.panelPoligon.Paint += new System.Windows.Forms.PaintEventHandler(this.panelPoligon_Paint);
            // 
            // textPoligon
            // 
            this.textPoligon.AcceptsReturn = true;
            this.textPoligon.Location = new System.Drawing.Point(12, 320);
            this.textPoligon.Multiline = true;
            this.textPoligon.Name = "textPoligon";
            this.textPoligon.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textPoligon.Size = new System.Drawing.Size(592, 307);
            this.textPoligon.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1289, 639);
            this.Controls.Add(this.textPoligon);
            this.Controls.Add(this.panelPoligon);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelPoligon;
        private System.Windows.Forms.TextBox textPoligon;
    }
}

