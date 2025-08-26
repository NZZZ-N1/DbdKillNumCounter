namespace DbdKillNumCounter
{
    partial class MainForm
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.Button_StartCount = new System.Windows.Forms.Button();
            this.Button_ClearCount = new System.Windows.Forms.Button();
            this.Button_SetPierce = new System.Windows.Forms.Button();
            this.Text_Tip = new System.Windows.Forms.Label();
            this.Button_CloseCount = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Button_StartCount
            // 
            this.Button_StartCount.Location = new System.Drawing.Point(12, 37);
            this.Button_StartCount.Name = "Button_StartCount";
            this.Button_StartCount.Size = new System.Drawing.Size(193, 23);
            this.Button_StartCount.TabIndex = 0;
            this.Button_StartCount.Text = "Start counting (开启计数)";
            this.Button_StartCount.UseVisualStyleBackColor = true;
            this.Button_StartCount.Click += new System.EventHandler(this.Button_StartCount_Click);
            // 
            // Button_ClearCount
            // 
            this.Button_ClearCount.Location = new System.Drawing.Point(12, 66);
            this.Button_ClearCount.Name = "Button_ClearCount";
            this.Button_ClearCount.Size = new System.Drawing.Size(193, 23);
            this.Button_ClearCount.TabIndex = 1;
            this.Button_ClearCount.Text = "Reset counting (清空计数)";
            this.Button_ClearCount.UseVisualStyleBackColor = true;
            this.Button_ClearCount.Click += new System.EventHandler(this.Button_ClearCount_Click);
            // 
            // Button_SetPierce
            // 
            this.Button_SetPierce.Location = new System.Drawing.Point(12, 95);
            this.Button_SetPierce.Name = "Button_SetPierce";
            this.Button_SetPierce.Size = new System.Drawing.Size(193, 23);
            this.Button_SetPierce.TabIndex = 2;
            this.Button_SetPierce.Text = "Set penetrable (设置穿透)";
            this.Button_SetPierce.UseVisualStyleBackColor = true;
            this.Button_SetPierce.Click += new System.EventHandler(this.Button_SetPierce_Click);
            // 
            // Text_Tip
            // 
            this.Text_Tip.AutoSize = true;
            this.Text_Tip.Location = new System.Drawing.Point(12, 9);
            this.Text_Tip.Name = "Text_Tip";
            this.Text_Tip.Size = new System.Drawing.Size(167, 12);
            this.Text_Tip.TabIndex = 3;
            this.Text_Tip.Text = "Use F1、F2、F3、F4 to count";
            // 
            // Button_CloseCount
            // 
            this.Button_CloseCount.Location = new System.Drawing.Point(12, 132);
            this.Button_CloseCount.Name = "Button_CloseCount";
            this.Button_CloseCount.Size = new System.Drawing.Size(193, 23);
            this.Button_CloseCount.TabIndex = 4;
            this.Button_CloseCount.Text = "Close counting (关闭计数)";
            this.Button_CloseCount.UseVisualStyleBackColor = true;
            this.Button_CloseCount.Click += new System.EventHandler(this.Button_CloseCount_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(217, 167);
            this.Controls.Add(this.Button_CloseCount);
            this.Controls.Add(this.Text_Tip);
            this.Controls.Add(this.Button_SetPierce);
            this.Controls.Add(this.Button_ClearCount);
            this.Controls.Add(this.Button_StartCount);
            this.MaximumSize = new System.Drawing.Size(233, 206);
            this.MinimumSize = new System.Drawing.Size(233, 206);
            this.Name = "MainForm";
            this.Text = "DbdKillNumCounter";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Button_StartCount;
        private System.Windows.Forms.Button Button_ClearCount;
        private System.Windows.Forms.Button Button_SetPierce;
        private System.Windows.Forms.Label Text_Tip;
        private System.Windows.Forms.Button Button_CloseCount;
    }
}

