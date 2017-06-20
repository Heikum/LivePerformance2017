namespace LivePerformance2017.Presentation_Layer
{
    partial class Partijform
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
            this.lbpartijen = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.addpartijbutton = new System.Windows.Forms.Button();
            this.verwijderpartijbutton = new System.Windows.Forms.Button();
            this.wijizigpartijbutton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbpartijen
            // 
            this.lbpartijen.FormattingEnabled = true;
            this.lbpartijen.ItemHeight = 25;
            this.lbpartijen.Location = new System.Drawing.Point(12, 48);
            this.lbpartijen.Name = "lbpartijen";
            this.lbpartijen.Size = new System.Drawing.Size(759, 529);
            this.lbpartijen.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(217, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Alle politieke partijen:";
            // 
            // addpartijbutton
            // 
            this.addpartijbutton.Location = new System.Drawing.Point(12, 593);
            this.addpartijbutton.Name = "addpartijbutton";
            this.addpartijbutton.Size = new System.Drawing.Size(217, 80);
            this.addpartijbutton.TabIndex = 2;
            this.addpartijbutton.Text = "Voeg partij toe";
            this.addpartijbutton.UseVisualStyleBackColor = true;
            this.addpartijbutton.Click += new System.EventHandler(this.addpartijbutton_Click);
            // 
            // verwijderpartijbutton
            // 
            this.verwijderpartijbutton.Location = new System.Drawing.Point(277, 593);
            this.verwijderpartijbutton.Name = "verwijderpartijbutton";
            this.verwijderpartijbutton.Size = new System.Drawing.Size(218, 80);
            this.verwijderpartijbutton.TabIndex = 3;
            this.verwijderpartijbutton.Text = "Verwijder partij";
            this.verwijderpartijbutton.UseVisualStyleBackColor = true;
            // 
            // wijizigpartijbutton
            // 
            this.wijizigpartijbutton.Location = new System.Drawing.Point(553, 593);
            this.wijizigpartijbutton.Name = "wijizigpartijbutton";
            this.wijizigpartijbutton.Size = new System.Drawing.Size(218, 80);
            this.wijizigpartijbutton.TabIndex = 4;
            this.wijizigpartijbutton.Text = "Wijzig partij";
            this.wijizigpartijbutton.UseVisualStyleBackColor = true;
            // 
            // Partijform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(783, 687);
            this.Controls.Add(this.wijizigpartijbutton);
            this.Controls.Add(this.verwijderpartijbutton);
            this.Controls.Add(this.addpartijbutton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbpartijen);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "Partijform";
            this.Text = "Partijen ";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbpartijen;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button addpartijbutton;
        private System.Windows.Forms.Button verwijderpartijbutton;
        private System.Windows.Forms.Button wijizigpartijbutton;
    }
}