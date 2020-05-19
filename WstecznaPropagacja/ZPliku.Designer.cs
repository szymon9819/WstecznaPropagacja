namespace WstecznaPropagacja
{
    partial class ZPliku
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
            this.zatwierdzBtn = new System.Windows.Forms.Button();
            this.wybierzPlikBtn = new System.Windows.Forms.Button();
            this.sciezkaDoPlikuZWagamiBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.przeuczSiecBtn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.parametrBetaBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.zapiszWagiBtn = new System.Windows.Forms.Button();
            this.testPanel = new System.Windows.Forms.Panel();
            this.resetBtn = new System.Windows.Forms.Button();
            this.wyjscieLbl = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.wynikTestuLbl = new System.Windows.Forms.Label();
            this.dodajBtn = new System.Windows.Forms.Button();
            this.testujBtn = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.testPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // zatwierdzBtn
            // 
            this.zatwierdzBtn.Location = new System.Drawing.Point(493, 21);
            this.zatwierdzBtn.Name = "zatwierdzBtn";
            this.zatwierdzBtn.Size = new System.Drawing.Size(116, 23);
            this.zatwierdzBtn.TabIndex = 7;
            this.zatwierdzBtn.Text = "Zatwierdź";
            this.zatwierdzBtn.UseVisualStyleBackColor = true;
            this.zatwierdzBtn.Click += new System.EventHandler(this.zatwierdzBtn_Click);
            // 
            // wybierzPlikBtn
            // 
            this.wybierzPlikBtn.Location = new System.Drawing.Point(371, 21);
            this.wybierzPlikBtn.Name = "wybierzPlikBtn";
            this.wybierzPlikBtn.Size = new System.Drawing.Size(116, 23);
            this.wybierzPlikBtn.TabIndex = 6;
            this.wybierzPlikBtn.Text = "Wybierz Plik";
            this.wybierzPlikBtn.UseVisualStyleBackColor = true;
            this.wybierzPlikBtn.Click += new System.EventHandler(this.wybierzPlikBtn_Click);
            // 
            // sciezkaDoPlikuZWagamiBox
            // 
            this.sciezkaDoPlikuZWagamiBox.Location = new System.Drawing.Point(13, 23);
            this.sciezkaDoPlikuZWagamiBox.Name = "sciezkaDoPlikuZWagamiBox";
            this.sciezkaDoPlikuZWagamiBox.Size = new System.Drawing.Size(352, 20);
            this.sciezkaDoPlikuZWagamiBox.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(160, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Podaj sciezke do pliku z wagami";
            // 
            // przeuczSiecBtn
            // 
            this.przeuczSiecBtn.Enabled = false;
            this.przeuczSiecBtn.Location = new System.Drawing.Point(13, 58);
            this.przeuczSiecBtn.Name = "przeuczSiecBtn";
            this.przeuczSiecBtn.Size = new System.Drawing.Size(144, 37);
            this.przeuczSiecBtn.TabIndex = 8;
            this.przeuczSiecBtn.Text = "Przeucz sieć";
            this.przeuczSiecBtn.UseVisualStyleBackColor = true;
            this.przeuczSiecBtn.Click += new System.EventHandler(this.przeuczSiecBtn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 13);
            this.label2.TabIndex = 9;
            // 
            // parametrBetaBox
            // 
            this.parametrBetaBox.Location = new System.Drawing.Point(185, 75);
            this.parametrBetaBox.Name = "parametrBetaBox";
            this.parametrBetaBox.Size = new System.Drawing.Size(40, 20);
            this.parametrBetaBox.TabIndex = 10;
            this.parametrBetaBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.parametrBetaBox_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(182, 59);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Parametr Beta";
            // 
            // zapiszWagiBtn
            // 
            this.zapiszWagiBtn.Enabled = false;
            this.zapiszWagiBtn.Location = new System.Drawing.Point(13, 111);
            this.zapiszWagiBtn.Name = "zapiszWagiBtn";
            this.zapiszWagiBtn.Size = new System.Drawing.Size(144, 35);
            this.zapiszWagiBtn.TabIndex = 12;
            this.zapiszWagiBtn.Text = "Zapisz nowe wagi";
            this.zapiszWagiBtn.UseVisualStyleBackColor = true;
            this.zapiszWagiBtn.Click += new System.EventHandler(this.zapiszWagiBtn_Click);
            // 
            // testPanel
            // 
            this.testPanel.Controls.Add(this.resetBtn);
            this.testPanel.Controls.Add(this.wyjscieLbl);
            this.testPanel.Controls.Add(this.label5);
            this.testPanel.Controls.Add(this.wynikTestuLbl);
            this.testPanel.Controls.Add(this.dodajBtn);
            this.testPanel.Controls.Add(this.testujBtn);
            this.testPanel.Controls.Add(this.label4);
            this.testPanel.Controls.Add(this.textBox1);
            this.testPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.testPanel.Location = new System.Drawing.Point(0, 171);
            this.testPanel.Name = "testPanel";
            this.testPanel.Size = new System.Drawing.Size(672, 149);
            this.testPanel.TabIndex = 13;
            this.testPanel.Visible = false;
            // 
            // resetBtn
            // 
            this.resetBtn.Location = new System.Drawing.Point(137, 41);
            this.resetBtn.Name = "resetBtn";
            this.resetBtn.Size = new System.Drawing.Size(75, 23);
            this.resetBtn.TabIndex = 7;
            this.resetBtn.Text = "Reset";
            this.resetBtn.UseVisualStyleBackColor = true;
            this.resetBtn.Click += new System.EventHandler(this.resetBtn_Click);
            // 
            // wyjscieLbl
            // 
            this.wyjscieLbl.AutoSize = true;
            this.wyjscieLbl.Location = new System.Drawing.Point(18, 92);
            this.wyjscieLbl.Name = "wyjscieLbl";
            this.wyjscieLbl.Size = new System.Drawing.Size(50, 13);
            this.wyjscieLbl.TabIndex = 6;
            this.wyjscieLbl.Text = "Wyjscie: ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(18, 69);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Wejscia";
            // 
            // wynikTestuLbl
            // 
            this.wynikTestuLbl.AutoSize = true;
            this.wynikTestuLbl.Location = new System.Drawing.Point(15, 93);
            this.wynikTestuLbl.Name = "wynikTestuLbl";
            this.wynikTestuLbl.Size = new System.Drawing.Size(0, 13);
            this.wynikTestuLbl.TabIndex = 4;
            // 
            // dodajBtn
            // 
            this.dodajBtn.Location = new System.Drawing.Point(56, 42);
            this.dodajBtn.Name = "dodajBtn";
            this.dodajBtn.Size = new System.Drawing.Size(75, 23);
            this.dodajBtn.TabIndex = 3;
            this.dodajBtn.Text = "Dodaj";
            this.dodajBtn.UseVisualStyleBackColor = true;
            this.dodajBtn.Click += new System.EventHandler(this.dodajBtn_Click);
            // 
            // testujBtn
            // 
            this.testujBtn.Enabled = false;
            this.testujBtn.Location = new System.Drawing.Point(218, 41);
            this.testujBtn.Name = "testujBtn";
            this.testujBtn.Size = new System.Drawing.Size(75, 23);
            this.testujBtn.TabIndex = 2;
            this.testujBtn.Text = "Testuj";
            this.testujBtn.UseVisualStyleBackColor = true;
            this.testujBtn.Click += new System.EventHandler(this.testujBtn_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(24, 11);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(249, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Testowanie jest tylko dla siecie z dwoma wejsciami ";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(18, 44);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(32, 20);
            this.textBox1.TabIndex = 0;
            this.textBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // ZPliku
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.Controls.Add(this.testPanel);
            this.Controls.Add(this.zapiszWagiBtn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.parametrBetaBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.przeuczSiecBtn);
            this.Controls.Add(this.zatwierdzBtn);
            this.Controls.Add(this.wybierzPlikBtn);
            this.Controls.Add(this.sciezkaDoPlikuZWagamiBox);
            this.Controls.Add(this.label1);
            this.Name = "ZPliku";
            this.Size = new System.Drawing.Size(672, 320);
            this.testPanel.ResumeLayout(false);
            this.testPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button zatwierdzBtn;
        private System.Windows.Forms.Button wybierzPlikBtn;
        private System.Windows.Forms.TextBox sciezkaDoPlikuZWagamiBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button przeuczSiecBtn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox parametrBetaBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button zapiszWagiBtn;
        private System.Windows.Forms.Panel testPanel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label wynikTestuLbl;
        private System.Windows.Forms.Button dodajBtn;
        private System.Windows.Forms.Button testujBtn;
        private System.Windows.Forms.Label wyjscieLbl;
        private System.Windows.Forms.Button resetBtn;
    }
}
