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
            this.SuspendLayout();
            // 
            // lbcoalitie
            // 
            this.lbcoalitie.FormattingEnabled = true;
            this.lbcoalitie.ItemHeight = 25;
            this.lbcoalitie.Location = new System.Drawing.Point(64, 58);
            this.lbcoalitie.Name = "lbcoalitie";
            this.lbcoalitie.Size = new System.Drawing.Size(216, 379);
            this.lbcoalitie.TabIndex = 0;
            // 
            // lbpartijen
            // 
            this.lbpartijen.FormattingEnabled = true;
            this.lbpartijen.ItemHeight = 25;
            this.lbpartijen.Location = new System.Drawing.Point(441, 58);
            this.lbpartijen.Name = "lbpartijen";
            this.lbpartijen.Size = new System.Drawing.Size(216, 379);
            this.lbpartijen.TabIndex = 1;
            // 
            // btmaakcoalitie
            // 
            this.btmaakcoalitie.Location = new System.Drawing.Point(64, 485);
            this.btmaakcoalitie.Name = "btmaakcoalitie";
            this.btmaakcoalitie.Size = new System.Drawing.Size(466, 104);
            this.btmaakcoalitie.TabIndex = 2;
            this.btmaakcoalitie.Text = "Maak coalitie";
            this.btmaakcoalitie.UseVisualStyleBackColor = true;
            // 
            // Coalitieform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1140, 743);
            this.Controls.Add(this.btmaakcoalitie);
            this.Controls.Add(this.lbpartijen);
            this.Controls.Add(this.lbcoalitie);
            this.Name = "Coalitieform";
            this.Text = "Coalitieform";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lbcoalitie;
        private System.Windows.Forms.ListBox lbpartijen;
        private System.Windows.Forms.Button btmaakcoalitie;
    }
}