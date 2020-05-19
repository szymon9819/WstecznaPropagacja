namespace WstecznaPropagacja
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
            this.panelMenu = new System.Windows.Forms.Panel();
            this.menuBtn2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.menuBtn1 = new System.Windows.Forms.Button();
            this.zPliku1 = new WstecznaPropagacja.ZPliku();
            this.wlasnegoSchematu1 = new WstecznaPropagacja.WlasnegoSchematu();
            this.wlasnegoSchematu2 = new WstecznaPropagacja.WlasnegoSchematu();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panelMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelMenu
            // 
            this.panelMenu.Controls.Add(this.label4);
            this.panelMenu.Controls.Add(this.label3);
            this.panelMenu.Controls.Add(this.label2);
            this.panelMenu.Controls.Add(this.menuBtn2);
            this.panelMenu.Controls.Add(this.label1);
            this.panelMenu.Controls.Add(this.menuBtn1);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(194, 317);
            this.panelMenu.TabIndex = 1;
            // 
            // menuBtn2
            // 
            this.menuBtn2.Location = new System.Drawing.Point(26, 135);
            this.menuBtn2.Name = "menuBtn2";
            this.menuBtn2.Size = new System.Drawing.Size(128, 38);
            this.menuBtn2.TabIndex = 2;
            this.menuBtn2.Text = "Własnego schematu";
            this.menuBtn2.UseVisualStyleBackColor = true;
            this.menuBtn2.Click += new System.EventHandler(this.menuBtn2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.label1.Location = new System.Drawing.Point(9, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(179, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "stwórz sieć na podstawie:";
            // 
            // menuBtn1
            // 
            this.menuBtn1.Location = new System.Drawing.Point(26, 52);
            this.menuBtn1.Name = "menuBtn1";
            this.menuBtn1.Size = new System.Drawing.Size(128, 34);
            this.menuBtn1.TabIndex = 0;
            this.menuBtn1.Text = "Pliku";
            this.menuBtn1.UseVisualStyleBackColor = true;
            this.menuBtn1.Click += new System.EventHandler(this.menuBtn1_Click);
            // 
            // zPliku1
            // 
            this.zPliku1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.zPliku1.Location = new System.Drawing.Point(194, 0);
            this.zPliku1.Name = "zPliku1";
            this.zPliku1.Size = new System.Drawing.Size(685, 317);
            this.zPliku1.TabIndex = 2;
            // 
            // wlasnegoSchematu1
            // 
            this.wlasnegoSchematu1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.wlasnegoSchematu1.Location = new System.Drawing.Point(194, 0);
            this.wlasnegoSchematu1.Name = "wlasnegoSchematu1";
            this.wlasnegoSchematu1.Size = new System.Drawing.Size(685, 317);
            this.wlasnegoSchematu1.TabIndex = 3;
            // 
            // wlasnegoSchematu2
            // 
            this.wlasnegoSchematu2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.wlasnegoSchematu2.Location = new System.Drawing.Point(194, 0);
            this.wlasnegoSchematu2.Name = "wlasnegoSchematu2";
            this.wlasnegoSchematu2.Size = new System.Drawing.Size(685, 317);
            this.wlasnegoSchematu2.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(172, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "możliwość uczenia oraz testowania";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(4, 175);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(129, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "tworzy tylko schemat sieci";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 188);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(142, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "można zapisać wagi do pliku";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(879, 317);
            this.Controls.Add(this.wlasnegoSchematu2);
            this.Controls.Add(this.wlasnegoSchematu1);
            this.Controls.Add(this.zPliku1);
            this.Controls.Add(this.panelMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "Form1";
            this.Text = "Propagacja Wsteczna";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panelMenu.ResumeLayout(false);
            this.panelMenu.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button menuBtn1;
        private System.Windows.Forms.Button menuBtn2;
        private ZPliku zPliku1;
        private WlasnegoSchematu wlasnegoSchematu1;
        private WlasnegoSchematu wlasnegoSchematu2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
    }
}

