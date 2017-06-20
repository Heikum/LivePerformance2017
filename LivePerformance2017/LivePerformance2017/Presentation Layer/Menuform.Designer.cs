namespace LivePerformance2017
{
    partial class MenuForm
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
            this.button3 = new System.Windows.Forms.Button();
            this.partijbutton = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(43, 45);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(280, 89);
            this.button3.TabIndex = 2;
            this.button3.Text = "Uitslagen";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // partijbutton
            // 
            this.partijbutton.Location = new System.Drawing.Point(43, 140);
            this.partijbutton.Name = "partijbutton";
            this.partijbutton.Size = new System.Drawing.Size(280, 89);
            this.partijbutton.TabIndex = 3;
            this.partijbutton.Text = "Partijen";
            this.partijbutton.UseVisualStyleBackColor = true;
            this.partijbutton.Click += new System.EventHandler(this.partijbutton_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(329, 45);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(280, 89);
            this.button5.TabIndex = 4;
            this.button5.Text = "Coalities";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(329, 140);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(280, 89);
            this.button1.TabIndex = 5;
            this.button1.Text = "Placeholder";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // MenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(678, 265);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.partijbutton);
            this.Controls.Add(this.button3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MenuForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu -  VerkiezingCounter";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button partijbutton;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button1;
    }
}

