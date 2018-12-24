namespace BIM_Project_Directroy_Creator
{
    partial class Form1
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
            this.lab_ToolName = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lab_ToolName
            // 
            this.lab_ToolName.AutoSize = true;
            this.lab_ToolName.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lab_ToolName.Location = new System.Drawing.Point(282, 11);
            this.lab_ToolName.Name = "lab_ToolName";
            this.lab_ToolName.Size = new System.Drawing.Size(234, 22);
            this.lab_ToolName.TabIndex = 0;
            this.lab_ToolName.Text = "BIM项目标准目录结构创建工具";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lab_ToolName);
            this.Name = "Form1";
            this.Text = "CCIEE-BIM Project Directory Creator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lab_ToolName;
    }
}

