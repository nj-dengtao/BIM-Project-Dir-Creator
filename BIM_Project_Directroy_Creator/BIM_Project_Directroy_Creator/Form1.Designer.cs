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
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("Root");
            this.lab_ToolName = new System.Windows.Forms.Label();
            this.tre_Driectroy = new System.Windows.Forms.TreeView();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.rad_FromTemplate = new System.Windows.Forms.RadioButton();
            this.rad_Manual = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lab_TemplateFile = new System.Windows.Forms.Label();
            this.but_SelectTemplate = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
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
            // tre_Driectroy
            // 
            this.tre_Driectroy.Font = new System.Drawing.Font("微软雅黑", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tre_Driectroy.Location = new System.Drawing.Point(12, 57);
            this.tre_Driectroy.Name = "tre_Driectroy";
            treeNode2.Name = "节点0";
            treeNode2.Text = "Root";
            this.tre_Driectroy.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode2});
            this.tre_Driectroy.Size = new System.Drawing.Size(311, 529);
            this.tre_Driectroy.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(339, 332);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Add Child Node";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(339, 287);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(100, 23);
            this.button2.TabIndex = 3;
            this.button2.Text = "Add Parent Node";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(339, 384);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(100, 23);
            this.button3.TabIndex = 4;
            this.button3.Text = "Delete Node";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // rad_FromTemplate
            // 
            this.rad_FromTemplate.AutoSize = true;
            this.rad_FromTemplate.Checked = true;
            this.rad_FromTemplate.Location = new System.Drawing.Point(23, 42);
            this.rad_FromTemplate.Name = "rad_FromTemplate";
            this.rad_FromTemplate.Size = new System.Drawing.Size(109, 17);
            this.rad_FromTemplate.TabIndex = 5;
            this.rad_FromTemplate.TabStop = true;
            this.rad_FromTemplate.Text = "从模板文件创建";
            this.rad_FromTemplate.UseVisualStyleBackColor = true;
            this.rad_FromTemplate.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // rad_Manual
            // 
            this.rad_Manual.AutoSize = true;
            this.rad_Manual.Location = new System.Drawing.Point(23, 19);
            this.rad_Manual.Name = "rad_Manual";
            this.rad_Manual.Size = new System.Drawing.Size(73, 17);
            this.rad_Manual.TabIndex = 6;
            this.rad_Manual.Text = "手动创建";
            this.rad_Manual.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lab_TemplateFile);
            this.groupBox1.Controls.Add(this.but_SelectTemplate);
            this.groupBox1.Controls.Add(this.rad_Manual);
            this.groupBox1.Controls.Add(this.rad_FromTemplate);
            this.groupBox1.Location = new System.Drawing.Point(329, 57);
            this.groupBox1.MaximumSize = new System.Drawing.Size(500, 100);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(224, 100);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "创建模式";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // lab_TemplateFile
            // 
            this.lab_TemplateFile.AutoSize = true;
            this.lab_TemplateFile.Enabled = false;
            this.lab_TemplateFile.Location = new System.Drawing.Point(7, 79);
            this.lab_TemplateFile.Name = "lab_TemplateFile";
            this.lab_TemplateFile.Size = new System.Drawing.Size(115, 13);
            this.lab_TemplateFile.TabIndex = 8;
            this.lab_TemplateFile.Text = "请选择一个模板文件";
            // 
            // but_SelectTemplate
            // 
            this.but_SelectTemplate.Location = new System.Drawing.Point(138, 39);
            this.but_SelectTemplate.Name = "but_SelectTemplate";
            this.but_SelectTemplate.Size = new System.Drawing.Size(28, 23);
            this.but_SelectTemplate.TabIndex = 7;
            this.but_SelectTemplate.Text = "...";
            this.but_SelectTemplate.UseVisualStyleBackColor = true;
            this.but_SelectTemplate.Click += new System.EventHandler(this.but_SelectTemplate_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(339, 175);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 8;
            this.button4.Text = "创建项目";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 598);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tre_Driectroy);
            this.Controls.Add(this.lab_ToolName);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "CCIEE-BIM Project Directory Creator";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lab_ToolName;
        private System.Windows.Forms.TreeView tre_Driectroy;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.RadioButton rad_FromTemplate;
        private System.Windows.Forms.RadioButton rad_Manual;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button but_SelectTemplate;
        private System.Windows.Forms.Label lab_TemplateFile;
        private System.Windows.Forms.Button button4;
    }
}

