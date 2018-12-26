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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.lab_ToolName = new System.Windows.Forms.Label();
            this.tre_Driectroy = new System.Windows.Forms.TreeView();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.but_AddChildNode = new System.Windows.Forms.Button();
            this.but_AddParentNode = new System.Windows.Forms.Button();
            this.but_DeleteNode = new System.Windows.Forms.Button();
            this.rad_FromTemplate = new System.Windows.Forms.RadioButton();
            this.rad_Manual = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txt_ProjectName = new System.Windows.Forms.TextBox();
            this.but_ManualCreateRoot = new System.Windows.Forms.Button();
            this.lab_TemplateFile = new System.Windows.Forms.Label();
            this.but_SelectTemplate = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.lab_ProjectName = new System.Windows.Forms.Label();
            this.lab_ProjectPath = new System.Windows.Forms.Label();
            this.but_CreateDirectories = new System.Windows.Forms.Button();
            this.lab_Attation = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.chk_UseCurrentPath = new System.Windows.Forms.CheckBox();
            this.but_ChangePath = new System.Windows.Forms.Button();
            this.lab_CR = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
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
            this.tre_Driectroy.Font = new System.Drawing.Font("微软雅黑", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tre_Driectroy.HideSelection = false;
            this.tre_Driectroy.ImageIndex = 0;
            this.tre_Driectroy.ImageList = this.imageList1;
            this.tre_Driectroy.Location = new System.Drawing.Point(12, 57);
            this.tre_Driectroy.Name = "tre_Driectroy";
            this.tre_Driectroy.SelectedImageIndex = 0;
            this.tre_Driectroy.Size = new System.Drawing.Size(311, 529);
            this.tre_Driectroy.TabIndex = 1;
            this.tre_Driectroy.NodeMouseClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.tre_Driectroy_NodeMouseClick);
            this.tre_Driectroy.NodeMouseDoubleClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.tre_Driectroy_NodeMouseDoubleClick);
            this.tre_Driectroy.MouseClick += new System.Windows.Forms.MouseEventHandler(this.tre_Driectroy_MouseClick);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "Floder.png");
            // 
            // but_AddChildNode
            // 
            this.but_AddChildNode.Font = new System.Drawing.Font("Microsoft YaHei UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.but_AddChildNode.Location = new System.Drawing.Point(6, 80);
            this.but_AddChildNode.Name = "but_AddChildNode";
            this.but_AddChildNode.Size = new System.Drawing.Size(100, 23);
            this.but_AddChildNode.TabIndex = 2;
            this.but_AddChildNode.Text = "添加子节点";
            this.but_AddChildNode.UseVisualStyleBackColor = true;
            this.but_AddChildNode.Click += new System.EventHandler(this.button1_Click);
            // 
            // but_AddParentNode
            // 
            this.but_AddParentNode.Font = new System.Drawing.Font("Microsoft YaHei UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.but_AddParentNode.Location = new System.Drawing.Point(6, 39);
            this.but_AddParentNode.Name = "but_AddParentNode";
            this.but_AddParentNode.Size = new System.Drawing.Size(100, 23);
            this.but_AddParentNode.TabIndex = 3;
            this.but_AddParentNode.Text = "添加平级节点";
            this.but_AddParentNode.UseVisualStyleBackColor = true;
            this.but_AddParentNode.Click += new System.EventHandler(this.button2_Click);
            // 
            // but_DeleteNode
            // 
            this.but_DeleteNode.Font = new System.Drawing.Font("Microsoft YaHei UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.but_DeleteNode.Location = new System.Drawing.Point(6, 118);
            this.but_DeleteNode.Name = "but_DeleteNode";
            this.but_DeleteNode.Size = new System.Drawing.Size(100, 23);
            this.but_DeleteNode.TabIndex = 4;
            this.but_DeleteNode.Text = "删除节点";
            this.but_DeleteNode.UseVisualStyleBackColor = true;
            this.but_DeleteNode.Click += new System.EventHandler(this.button3_Click);
            // 
            // rad_FromTemplate
            // 
            this.rad_FromTemplate.AutoSize = true;
            this.rad_FromTemplate.Font = new System.Drawing.Font("Microsoft YaHei UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rad_FromTemplate.Location = new System.Drawing.Point(23, 49);
            this.rad_FromTemplate.Name = "rad_FromTemplate";
            this.rad_FromTemplate.Size = new System.Drawing.Size(103, 20);
            this.rad_FromTemplate.TabIndex = 5;
            this.rad_FromTemplate.Text = "从模板文件创建";
            this.rad_FromTemplate.UseVisualStyleBackColor = true;
            this.rad_FromTemplate.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // rad_Manual
            // 
            this.rad_Manual.AutoSize = true;
            this.rad_Manual.Font = new System.Drawing.Font("Microsoft YaHei UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rad_Manual.Location = new System.Drawing.Point(23, 19);
            this.rad_Manual.Name = "rad_Manual";
            this.rad_Manual.Size = new System.Drawing.Size(70, 20);
            this.rad_Manual.TabIndex = 6;
            this.rad_Manual.Text = "手动创建";
            this.rad_Manual.UseVisualStyleBackColor = true;
            this.rad_Manual.CheckedChanged += new System.EventHandler(this.rad_Manual_CheckedChanged);
            this.rad_Manual.Click += new System.EventHandler(this.rad_Manual_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txt_ProjectName);
            this.groupBox1.Controls.Add(this.but_ManualCreateRoot);
            this.groupBox1.Controls.Add(this.lab_TemplateFile);
            this.groupBox1.Controls.Add(this.but_SelectTemplate);
            this.groupBox1.Controls.Add(this.rad_Manual);
            this.groupBox1.Controls.Add(this.rad_FromTemplate);
            this.groupBox1.Location = new System.Drawing.Point(329, 57);
            this.groupBox1.MaximumSize = new System.Drawing.Size(500, 150);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(459, 121);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "创建模式";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // txt_ProjectName
            // 
            this.txt_ProjectName.Location = new System.Drawing.Point(138, 19);
            this.txt_ProjectName.Name = "txt_ProjectName";
            this.txt_ProjectName.Size = new System.Drawing.Size(194, 20);
            this.txt_ProjectName.TabIndex = 10;
            this.txt_ProjectName.TextChanged += new System.EventHandler(this.txt_ProjectName_TextChanged);
            // 
            // but_ManualCreateRoot
            // 
            this.but_ManualCreateRoot.Font = new System.Drawing.Font("微软雅黑", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.but_ManualCreateRoot.Location = new System.Drawing.Point(347, 18);
            this.but_ManualCreateRoot.Name = "but_ManualCreateRoot";
            this.but_ManualCreateRoot.Size = new System.Drawing.Size(103, 23);
            this.but_ManualCreateRoot.TabIndex = 9;
            this.but_ManualCreateRoot.Text = "建立项目根节点";
            this.but_ManualCreateRoot.UseVisualStyleBackColor = true;
            this.but_ManualCreateRoot.Click += new System.EventHandler(this.but_ManualCreateRoot_Click);
            // 
            // lab_TemplateFile
            // 
            this.lab_TemplateFile.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lab_TemplateFile.Enabled = false;
            this.lab_TemplateFile.Font = new System.Drawing.Font("Microsoft YaHei UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lab_TemplateFile.Location = new System.Drawing.Point(3, 79);
            this.lab_TemplateFile.Name = "lab_TemplateFile";
            this.lab_TemplateFile.Size = new System.Drawing.Size(453, 39);
            this.lab_TemplateFile.TabIndex = 8;
            this.lab_TemplateFile.Text = "请选择一个模板文件";
            // 
            // but_SelectTemplate
            // 
            this.but_SelectTemplate.Location = new System.Drawing.Point(138, 49);
            this.but_SelectTemplate.Name = "but_SelectTemplate";
            this.but_SelectTemplate.Size = new System.Drawing.Size(28, 20);
            this.but_SelectTemplate.TabIndex = 7;
            this.but_SelectTemplate.Text = "...";
            this.but_SelectTemplate.UseVisualStyleBackColor = true;
            this.but_SelectTemplate.Click += new System.EventHandler(this.but_SelectTemplate_Click);
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button4.Location = new System.Drawing.Point(556, 276);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(150, 40);
            this.button4.TabIndex = 8;
            this.button4.Text = "创建项目";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // lab_ProjectName
            // 
            this.lab_ProjectName.AutoSize = true;
            this.lab_ProjectName.Font = new System.Drawing.Font("Microsoft YaHei UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lab_ProjectName.Location = new System.Drawing.Point(336, 181);
            this.lab_ProjectName.Name = "lab_ProjectName";
            this.lab_ProjectName.Size = new System.Drawing.Size(63, 16);
            this.lab_ProjectName.TabIndex = 9;
            this.lab_ProjectName.Text = "项目名称：";
            // 
            // lab_ProjectPath
            // 
            this.lab_ProjectPath.AutoSize = true;
            this.lab_ProjectPath.Font = new System.Drawing.Font("Microsoft YaHei UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lab_ProjectPath.Location = new System.Drawing.Point(336, 203);
            this.lab_ProjectPath.Name = "lab_ProjectPath";
            this.lab_ProjectPath.Size = new System.Drawing.Size(63, 16);
            this.lab_ProjectPath.TabIndex = 10;
            this.lab_ProjectPath.Text = "项目路径：";
            // 
            // but_CreateDirectories
            // 
            this.but_CreateDirectories.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.but_CreateDirectories.Location = new System.Drawing.Point(556, 340);
            this.but_CreateDirectories.Name = "but_CreateDirectories";
            this.but_CreateDirectories.Size = new System.Drawing.Size(150, 40);
            this.but_CreateDirectories.TabIndex = 13;
            this.but_CreateDirectories.Text = "创建目录结构";
            this.but_CreateDirectories.UseVisualStyleBackColor = true;
            this.but_CreateDirectories.Click += new System.EventHandler(this.but_CreateDirectories_Click);
            // 
            // lab_Attation
            // 
            this.lab_Attation.AutoEllipsis = true;
            this.lab_Attation.AutoSize = true;
            this.lab_Attation.Font = new System.Drawing.Font("Microsoft YaHei UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lab_Attation.Location = new System.Drawing.Point(341, 462);
            this.lab_Attation.Name = "lab_Attation";
            this.lab_Attation.Size = new System.Drawing.Size(39, 16);
            this.lab_Attation.TabIndex = 14;
            this.lab_Attation.Text = "label1";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.but_AddParentNode);
            this.groupBox2.Controls.Add(this.but_AddChildNode);
            this.groupBox2.Controls.Add(this.but_DeleteNode);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft YaHei UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(339, 276);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(116, 164);
            this.groupBox2.TabIndex = 15;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "节点编辑";
            // 
            // chk_UseCurrentPath
            // 
            this.chk_UseCurrentPath.AutoSize = true;
            this.chk_UseCurrentPath.Font = new System.Drawing.Font("微软雅黑", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chk_UseCurrentPath.Location = new System.Drawing.Point(613, 386);
            this.chk_UseCurrentPath.Name = "chk_UseCurrentPath";
            this.chk_UseCurrentPath.Size = new System.Drawing.Size(93, 20);
            this.chk_UseCurrentPath.TabIndex = 16;
            this.chk_UseCurrentPath.Text = "使用当前路径";
            this.chk_UseCurrentPath.UseVisualStyleBackColor = true;
            this.chk_UseCurrentPath.CheckStateChanged += new System.EventHandler(this.chk_UseCurrentPath_CheckStateChanged);
            // 
            // but_ChangePath
            // 
            this.but_ChangePath.Font = new System.Drawing.Font("微软雅黑", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.but_ChangePath.Location = new System.Drawing.Point(339, 227);
            this.but_ChangePath.Name = "but_ChangePath";
            this.but_ChangePath.Size = new System.Drawing.Size(75, 23);
            this.but_ChangePath.TabIndex = 17;
            this.but_ChangePath.Text = "修改路径";
            this.but_ChangePath.UseVisualStyleBackColor = true;
            this.but_ChangePath.Click += new System.EventHandler(this.but_ChangePath_Click);
            // 
            // lab_CR
            // 
            this.lab_CR.AutoSize = true;
            this.lab_CR.Font = new System.Drawing.Font("微软雅黑", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lab_CR.ForeColor = System.Drawing.Color.Blue;
            this.lab_CR.Location = new System.Drawing.Point(584, 538);
            this.lab_CR.Name = "lab_CR";
            this.lab_CR.Size = new System.Drawing.Size(39, 16);
            this.lab_CR.TabIndex = 18;
            this.lab_CR.Text = "label1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 598);
            this.Controls.Add(this.lab_CR);
            this.Controls.Add(this.but_ChangePath);
            this.Controls.Add(this.chk_UseCurrentPath);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.lab_Attation);
            this.Controls.Add(this.but_CreateDirectories);
            this.Controls.Add(this.lab_ProjectPath);
            this.Controls.Add(this.lab_ProjectName);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.tre_Driectroy);
            this.Controls.Add(this.lab_ToolName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "中建安装-BIM项目标准目录结构创建工具";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lab_ToolName;
        private System.Windows.Forms.TreeView tre_Driectroy;
        private System.Windows.Forms.Button but_AddChildNode;
        private System.Windows.Forms.Button but_AddParentNode;
        private System.Windows.Forms.Button but_DeleteNode;
        private System.Windows.Forms.RadioButton rad_FromTemplate;
        private System.Windows.Forms.RadioButton rad_Manual;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button but_SelectTemplate;
        private System.Windows.Forms.Label lab_TemplateFile;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label lab_ProjectName;
        private System.Windows.Forms.Label lab_ProjectPath;
        private System.Windows.Forms.Button but_CreateDirectories;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Label lab_Attation;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txt_ProjectName;
        private System.Windows.Forms.Button but_ManualCreateRoot;
        private System.Windows.Forms.CheckBox chk_UseCurrentPath;
        private System.Windows.Forms.Button but_ChangePath;
        private System.Windows.Forms.Label lab_CR;
    }
}

