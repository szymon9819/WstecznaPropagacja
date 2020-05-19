namespace WstecznaPropagacja
{
    partial class WlasnegoSchematu
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.utworzSiecBtn = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.strukturaSieciLbl = new System.Windows.Forms.Label();
            this.resetBtn = new System.Windows.Forms.Button();
            this.zapiszDoPlikuBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(22, 52);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(33, 20);
            this.textBox1.TabIndex = 0;
            this.textBox1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox1_KeyDown);
            this.textBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(304, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Schemat sieci (ilość wejść, [ilość neuronów na danej warstwie])";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Np. 2, 2, 1";
            // 
            // utworzSiecBtn
            // 
            this.utworzSiecBtn.Location = new System.Drawing.Point(22, 95);
            this.utworzSiecBtn.Name = "utworzSiecBtn";
            this.utworzSiecBtn.Size = new System.Drawing.Size(99, 22);
            this.utworzSiecBtn.TabIndex = 3;
            this.utworzSiecBtn.Text = "utwórz sieć";
            this.utworzSiecBtn.UseVisualStyleBackColor = true;
            this.utworzSiecBtn.Click += new System.EventHandler(this.utworzSiecBtn_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(61, 50);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "dodaj";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // strukturaSieciLbl
            // 
            this.strukturaSieciLbl.AutoSize = true;
            this.strukturaSieciLbl.Location = new System.Drawing.Point(22, 79);
            this.strukturaSieciLbl.Name = "strukturaSieciLbl";
            this.strukturaSieciLbl.Size = new System.Drawing.Size(0, 13);
            this.strukturaSieciLbl.TabIndex = 5;
            // 
            // resetBtn
            // 
            this.resetBtn.Location = new System.Drawing.Point(142, 49);
            this.resetBtn.Name = "resetBtn";
            this.resetBtn.Size = new System.Drawing.Size(75, 23);
            this.resetBtn.TabIndex = 6;
            this.resetBtn.Text = "Resetuj";
            this.resetBtn.UseVisualStyleBackColor = true;
            this.resetBtn.Click += new System.EventHandler(this.resetBtn_Click);
            // 
            // zapiszDoPlikuBtn
            // 
            this.zapiszDoPlikuBtn.Enabled = false;
            this.zapiszDoPlikuBtn.Location = new System.Drawing.Point(22, 133);
            this.zapiszDoPlikuBtn.Name = "zapiszDoPlikuBtn";
            this.zapiszDoPlikuBtn.Size = new System.Drawing.Size(99, 23);
            this.zapiszDoPlikuBtn.TabIndex = 7;
            this.zapiszDoPlikuBtn.Text = "Zapisz do pliku";
            this.zapiszDoPlikuBtn.UseVisualStyleBackColor = true;
            this.zapiszDoPlikuBtn.Click += new System.EventHandler(this.zapiszDoPlikuBtn_Click);
            // 
            // WlasnegoSchematu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.Controls.Add(this.zapiszDoPlikuBtn);
            this.Controls.Add(this.resetBtn);
            this.Controls.Add(this.strukturaSieciLbl);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.utworzSiecBtn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Name = "WlasnegoSchematu";
            this.Size = new System.Drawing.Size(704, 234);
            this.Load += new System.EventHandler(this.WlasnegoSchematu_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button utworzSiecBtn;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label strukturaSieciLbl;
        private System.Windows.Forms.Button resetBtn;
        private System.Windows.Forms.Button zapiszDoPlikuBtn;
    }
}
