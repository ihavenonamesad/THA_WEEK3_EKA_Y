namespace THA_W3_EKA_Y
{
    partial class MainForm
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
            this.Next_btn = new System.Windows.Forms.Button();
            this.Name_lbl = new System.Windows.Forms.Label();
            this.Name_txt = new System.Windows.Forms.TextBox();
            this.Artist_lbl = new System.Windows.Forms.Label();
            this.Artist_txt = new System.Windows.Forms.TextBox();
            this.True_check = new System.Windows.Forms.CheckBox();
            this.Submit_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Next_btn
            // 
            this.Next_btn.Location = new System.Drawing.Point(256, 195);
            this.Next_btn.Name = "Next_btn";
            this.Next_btn.Size = new System.Drawing.Size(120, 34);
            this.Next_btn.TabIndex = 0;
            this.Next_btn.Text = "Open Next Form";
            this.Next_btn.UseVisualStyleBackColor = true;
            this.Next_btn.Click += new System.EventHandler(this.Next_btn_Click);
            // 
            // Name_lbl
            // 
            this.Name_lbl.AutoSize = true;
            this.Name_lbl.Location = new System.Drawing.Point(53, 67);
            this.Name_lbl.Name = "Name_lbl";
            this.Name_lbl.Size = new System.Drawing.Size(35, 13);
            this.Name_lbl.TabIndex = 1;
            this.Name_lbl.Text = "Name";
            this.Name_lbl.Click += new System.EventHandler(this.Name_lbl_Click);
            // 
            // Name_txt
            // 
            this.Name_txt.Location = new System.Drawing.Point(153, 60);
            this.Name_txt.Name = "Name_txt";
            this.Name_txt.Size = new System.Drawing.Size(213, 20);
            this.Name_txt.TabIndex = 2;
            // 
            // Artist_lbl
            // 
            this.Artist_lbl.AutoSize = true;
            this.Artist_lbl.Location = new System.Drawing.Point(53, 99);
            this.Artist_lbl.Name = "Artist_lbl";
            this.Artist_lbl.Size = new System.Drawing.Size(88, 13);
            this.Artist_lbl.TabIndex = 3;
            this.Artist_lbl.Text = "My Favorite Artist";
            // 
            // Artist_txt
            // 
            this.Artist_txt.Location = new System.Drawing.Point(153, 92);
            this.Artist_txt.Name = "Artist_txt";
            this.Artist_txt.Size = new System.Drawing.Size(213, 20);
            this.Artist_txt.TabIndex = 4;
            // 
            // True_check
            // 
            this.True_check.AutoSize = true;
            this.True_check.Location = new System.Drawing.Point(56, 135);
            this.True_check.Name = "True_check";
            this.True_check.Size = new System.Drawing.Size(194, 17);
            this.True_check.TabIndex = 5;
            this.True_check.Text = "All of the content I put above is true";
            this.True_check.UseVisualStyleBackColor = true;
            this.True_check.CheckedChanged += new System.EventHandler(this.True_check_CheckedChanged);
            // 
            // Submit_btn
            // 
            this.Submit_btn.Enabled = false;
            this.Submit_btn.Location = new System.Drawing.Point(66, 195);
            this.Submit_btn.Name = "Submit_btn";
            this.Submit_btn.Size = new System.Drawing.Size(120, 34);
            this.Submit_btn.TabIndex = 6;
            this.Submit_btn.Text = "Submit";
            this.Submit_btn.UseVisualStyleBackColor = true;
            this.Submit_btn.Click += new System.EventHandler(this.Submit_btn_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Submit_btn);
            this.Controls.Add(this.True_check);
            this.Controls.Add(this.Artist_txt);
            this.Controls.Add(this.Artist_lbl);
            this.Controls.Add(this.Name_txt);
            this.Controls.Add(this.Name_lbl);
            this.Controls.Add(this.Next_btn);
            this.Name = "MainForm";
            this.Text = "Main WIndow Form";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Next_btn;
        private System.Windows.Forms.Label Name_lbl;
        private System.Windows.Forms.TextBox Name_txt;
        private System.Windows.Forms.Label Artist_lbl;
        private System.Windows.Forms.TextBox Artist_txt;
        private System.Windows.Forms.CheckBox True_check;
        private System.Windows.Forms.Button Submit_btn;
    }
}

