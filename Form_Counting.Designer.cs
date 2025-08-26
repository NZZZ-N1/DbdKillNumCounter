namespace DbdKillNumCounter
{
    partial class Form_Counting
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
            this.Button_CountNum_1 = new System.Windows.Forms.Button();
            this.Button_CountNum_2 = new System.Windows.Forms.Button();
            this.Button_CountNum_4 = new System.Windows.Forms.Button();
            this.Button_CountNum_3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Button_CountNum_1
            // 
            this.Button_CountNum_1.Location = new System.Drawing.Point(12, 12);
            this.Button_CountNum_1.Name = "Button_CountNum_1";
            this.Button_CountNum_1.Size = new System.Drawing.Size(96, 23);
            this.Button_CountNum_1.TabIndex = 0;
            this.Button_CountNum_1.Text = "1楼";
            this.Button_CountNum_1.UseVisualStyleBackColor = true;
            this.Button_CountNum_1.Click += new System.EventHandler(this.Button_CountNum_1_Click);
            // 
            // Button_CountNum_2
            // 
            this.Button_CountNum_2.Location = new System.Drawing.Point(12, 41);
            this.Button_CountNum_2.Name = "Button_CountNum_2";
            this.Button_CountNum_2.Size = new System.Drawing.Size(96, 23);
            this.Button_CountNum_2.TabIndex = 1;
            this.Button_CountNum_2.Text = "2楼";
            this.Button_CountNum_2.UseVisualStyleBackColor = true;
            this.Button_CountNum_2.Click += new System.EventHandler(this.Button_CountNum_2_Click);
            // 
            // Button_CountNum_4
            // 
            this.Button_CountNum_4.Location = new System.Drawing.Point(12, 99);
            this.Button_CountNum_4.Name = "Button_CountNum_4";
            this.Button_CountNum_4.Size = new System.Drawing.Size(96, 23);
            this.Button_CountNum_4.TabIndex = 3;
            this.Button_CountNum_4.Text = "4楼";
            this.Button_CountNum_4.UseVisualStyleBackColor = true;
            this.Button_CountNum_4.Click += new System.EventHandler(this.Button_CountNum_4_Click);
            // 
            // Button_CountNum_3
            // 
            this.Button_CountNum_3.Location = new System.Drawing.Point(12, 70);
            this.Button_CountNum_3.Name = "Button_CountNum_3";
            this.Button_CountNum_3.Size = new System.Drawing.Size(96, 23);
            this.Button_CountNum_3.TabIndex = 2;
            this.Button_CountNum_3.Text = "3楼";
            this.Button_CountNum_3.UseVisualStyleBackColor = true;
            this.Button_CountNum_3.Click += new System.EventHandler(this.Button_CountNum_3_Click);
            // 
            // Form_Counting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(120, 133);
            this.ControlBox = false;
            this.Controls.Add(this.Button_CountNum_4);
            this.Controls.Add(this.Button_CountNum_3);
            this.Controls.Add(this.Button_CountNum_2);
            this.Controls.Add(this.Button_CountNum_1);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.MaximumSize = new System.Drawing.Size(136, 172);
            this.MinimumSize = new System.Drawing.Size(136, 172);
            this.Name = "Form_Counting";
            this.Text = "计数";
            this.Load += new System.EventHandler(this.Form_Counting_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Button_CountNum_1;
        private System.Windows.Forms.Button Button_CountNum_2;
        private System.Windows.Forms.Button Button_CountNum_4;
        private System.Windows.Forms.Button Button_CountNum_3;
    }
}