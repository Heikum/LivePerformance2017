namespace LivePerformance2017.Presentation_Layer.Partij
{
    partial class Wijzigpartijform
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
            this.wijzigpartijbutton = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tbpartijnaam = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbvolledigepartijnaam = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbpartijkleur = new System.Windows.Forms.TextBox();
            this.tbpartijlijsttrekker = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // wijzigpartijbutton
            // 
            this.wijzigpartijbutton.Location = new System.Drawing.Point(25, 261);
            this.wijzigpartijbutton.Name = "wijzigpartijbutton";
            this.wijzigpartijbutton.Size = new System.Drawing.Size(440, 80);
            this.wijzigpartijbutton.TabIndex = 13;
            this.wijzigpartijbutton.Text = "Wijzig";
            this.wijzigpartijbutton.UseVisualStyleBackColor = true;
            this.wijzigpartijbutton.Click += new System.EventHandler(this.wijzigpartijbutton_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.tbpartijnaam);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.tbvolledigepartijnaam);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.tbpartijkleur);
            this.groupBox1.Controls.Add(this.tbpartijlijsttrekker);
            this.groupBox1.Location = new System.Drawing.Point(24, 24);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(441, 230);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 25);
            this.label1.TabIndex = 6;
            this.label1.Text = "Naam:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 88);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(169, 25);
            this.label4.TabIndex = 9;
            this.label4.Text = "Volledige Naam:";
            // 
            // tbpartijnaam
            // 
            this.tbpartijnaam.Location = new System.Drawing.Point(210, 23);
            this.tbpartijnaam.Multiline = true;
            this.tbpartijnaam.Name = "tbpartijnaam";
            this.tbpartijnaam.Size = new System.Drawing.Size(218, 42);
            this.tbpartijnaam.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 184);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(123, 25);
            this.label3.TabIndex = 8;
            this.label3.Text = "Lijsttrekker:";
            // 
            // tbvolledigepartijnaam
            // 
            this.tbvolledigepartijnaam.Location = new System.Drawing.Point(210, 71);
            this.tbvolledigepartijnaam.Multiline = true;
            this.tbvolledigepartijnaam.Name = "tbvolledigepartijnaam";
            this.tbvolledigepartijnaam.Size = new System.Drawing.Size(218, 42);
            this.tbvolledigepartijnaam.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 136);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 25);
            this.label2.TabIndex = 7;
            this.label2.Text = "Kleur:";
            // 
            // tbpartijkleur
            // 
            this.tbpartijkleur.Location = new System.Drawing.Point(210, 119);
            this.tbpartijkleur.Multiline = true;
            this.tbpartijkleur.Name = "tbpartijkleur";
            this.tbpartijkleur.Size = new System.Drawing.Size(218, 42);
            this.tbpartijkleur.TabIndex = 2;
            // 
            // tbpartijlijsttrekker
            // 
            this.tbpartijlijsttrekker.Location = new System.Drawing.Point(210, 167);
            this.tbpartijlijsttrekker.Multiline = true;
            this.tbpartijlijsttrekker.Name = "tbpartijlijsttrekker";
            this.tbpartijlijsttrekker.Size = new System.Drawing.Size(218, 42);
            this.tbpartijlijsttrekker.TabIndex = 3;
            // 
            // Wijzigpartijform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(489, 364);
            this.Controls.Add(this.wijzigpartijbutton);
            this.Controls.Add(this.groupBox1);
            this.Name = "Wijzigpartijform";
            this.Text = "Wijzig een partij";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button wijzigpartijbutton;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbpartijnaam;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbvolledigepartijnaam;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbpartijkleur;
        private System.Windows.Forms.TextBox tbpartijlijsttrekker;
    }
}