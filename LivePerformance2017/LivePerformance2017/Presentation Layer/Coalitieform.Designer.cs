namespace LivePerformance2017.Presentation_Layer
{
    partial class Coalitieform
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
            this.lbcoalitie = new System.Windows.Forms.ListBox();
            this.lbpartijen = new System.Windows.Forms.ListBox();
            this.btmaakcoalitie = new System.Windows.Forms.Button();
            this.lbverkiezingen = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbcoalitie = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbpremier = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.checkedlbpartijen = new System.Windows.Forms.CheckedListBox();
            this.label6 = new System.Windows.Forms.Label();
            this.updownzetels = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.exportbutton = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.updownzetels)).BeginInit();
            this.SuspendLayout();
            // 
            // lbcoalitie
            // 
            this.lbcoalitie.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbcoalitie.FormattingEnabled = true;
            this.lbcoalitie.ItemHeight = 25;
            this.lbcoalitie.Location = new System.Drawing.Point(528, 40);
            this.lbcoalitie.Name = "lbcoalitie";
            this.lbcoalitie.Size = new System.Drawing.Size(476, 379);
            this.lbcoalitie.TabIndex = 0;
            this.lbcoalitie.SelectedIndexChanged += new System.EventHandler(this.lbcoalitie_SelectedIndexChanged);
            // 
            // lbpartijen
            // 
            this.lbpartijen.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbpartijen.FormattingEnabled = true;
            this.lbpartijen.ItemHeight = 25;
            this.lbpartijen.Location = new System.Drawing.Point(1010, 40);
            this.lbpartijen.Name = "lbpartijen";
            this.lbpartijen.Size = new System.Drawing.Size(516, 379);
            this.lbpartijen.TabIndex = 1;
            // 
            // btmaakcoalitie
            // 
            this.btmaakcoalitie.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btmaakcoalitie.Location = new System.Drawing.Point(12, 712);
            this.btmaakcoalitie.Name = "btmaakcoalitie";
            this.btmaakcoalitie.Size = new System.Drawing.Size(505, 104);
            this.btmaakcoalitie.TabIndex = 2;
            this.btmaakcoalitie.Text = "Maak coalitie";
            this.btmaakcoalitie.UseVisualStyleBackColor = true;
            this.btmaakcoalitie.Click += new System.EventHandler(this.btmaakcoalitie_Click);
            // 
            // lbverkiezingen
            // 
            this.lbverkiezingen.FormattingEnabled = true;
            this.lbverkiezingen.ItemHeight = 25;
            this.lbverkiezingen.Location = new System.Drawing.Point(12, 40);
            this.lbverkiezingen.Name = "lbverkiezingen";
            this.lbverkiezingen.Size = new System.Drawing.Size(510, 379);
            this.lbverkiezingen.TabIndex = 3;
            this.lbverkiezingen.SelectedIndexChanged += new System.EventHandler(this.lbverkiezingen_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(143, 25);
            this.label1.TabIndex = 4;
            this.label1.Text = "Verkiezingen:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(523, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 25);
            this.label2.TabIndex = 5;
            this.label2.Text = "Coalities:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(1005, 12);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 25);
            this.label3.TabIndex = 6;
            this.label3.Text = "Partijen:";
            // 
            // tbcoalitie
            // 
            this.tbcoalitie.Location = new System.Drawing.Point(181, 495);
            this.tbcoalitie.Multiline = true;
            this.tbcoalitie.Name = "tbcoalitie";
            this.tbcoalitie.Size = new System.Drawing.Size(233, 31);
            this.tbcoalitie.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 495);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(149, 25);
            this.label4.TabIndex = 8;
            this.label4.Text = "Coalitie naam:";
            // 
            // tbpremier
            // 
            this.tbpremier.Location = new System.Drawing.Point(181, 533);
            this.tbpremier.Name = "tbpremier";
            this.tbpremier.Size = new System.Drawing.Size(233, 31);
            this.tbpremier.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 539);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(92, 25);
            this.label5.TabIndex = 10;
            this.label5.Text = "Premier:";
            // 
            // checkedlbpartijen
            // 
            this.checkedlbpartijen.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.checkedlbpartijen.FormattingEnabled = true;
            this.checkedlbpartijen.Location = new System.Drawing.Point(528, 448);
            this.checkedlbpartijen.Name = "checkedlbpartijen";
            this.checkedlbpartijen.Size = new System.Drawing.Size(781, 368);
            this.checkedlbpartijen.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(17, 581);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(77, 25);
            this.label6.TabIndex = 12;
            this.label6.Text = "Zetels:";
            // 
            // updownzetels
            // 
            this.updownzetels.Location = new System.Drawing.Point(181, 571);
            this.updownzetels.Name = "updownzetels";
            this.updownzetels.Size = new System.Drawing.Size(233, 31);
            this.updownzetels.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 455);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(172, 25);
            this.label7.TabIndex = 14;
            this.label7.Text = "Verkiezingnaam:";
            // 
            // exportbutton
            // 
            this.exportbutton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.exportbutton.AutoSize = true;
            this.exportbutton.Location = new System.Drawing.Point(1315, 450);
            this.exportbutton.Name = "exportbutton";
            this.exportbutton.Size = new System.Drawing.Size(211, 366);
            this.exportbutton.TabIndex = 15;
            this.exportbutton.Text = "Exporteer";
            this.exportbutton.UseVisualStyleBackColor = true;
            this.exportbutton.Click += new System.EventHandler(this.exportbutton_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(191, 455);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(19, 25);
            this.label8.TabIndex = 16;
            this.label8.Text = "-";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(332, 439);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(70, 25);
            this.label9.TabIndex = 18;
            this.label9.Text = "label9";
            // 
            // Coalitieform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1534, 828);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.exportbutton);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.updownzetels);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.checkedlbpartijen);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tbpremier);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbcoalitie);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbverkiezingen);
            this.Controls.Add(this.btmaakcoalitie);
            this.Controls.Add(this.lbpartijen);
            this.Controls.Add(this.lbcoalitie);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "Coalitieform";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Coalitieform";
            ((System.ComponentModel.ISupportInitialize)(this.updownzetels)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbcoalitie;
        private System.Windows.Forms.ListBox lbpartijen;
        private System.Windows.Forms.Button btmaakcoalitie;
        private System.Windows.Forms.ListBox lbverkiezingen;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbcoalitie;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbpremier;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckedListBox checkedlbpartijen;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown updownzetels;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button exportbutton;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
    }
}