using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace BIM_Project_Directroy_Creator
{
    public partial class Form1 : Form
    {
        private string ProjectName;
        private string ProjectPath;
        private int DirectoryLevels = 2;
        private List<string> L1_Directroies = new List<string>();
        private List<string> L2_Directories = new List<string>();
        private List<string> Directories = new List<string>();
        private string copyright = @"中建安装集团有限公司
工程研究院-BIM应用研发中心
TEL: 025-56663428";

        public Form1()
        {
            InitializeComponent();  
        }

        private void Get_Path(TreeNode tn) //递归遍历TreeView
        {
            Directories.Add( tn.FullPath); //将目录结构写入列表
            foreach(TreeNode tnSub in tn.Nodes)
            {
                Get_Path(tnSub);
            }
        }


        private void button1_Click(object sender, EventArgs e)
        {
            if(tre_Driectroy.SelectedNode == null)
            {
                MessageBox.Show("选择一个节点", "提示信息");
            }
            else
            {
                 if(tre_Driectroy.SelectedNode.Level <= DirectoryLevels) //控制子节点深度，最多3三级
                {
                    TreeNode tmp;
                    tmp = new TreeNode("节点");
                    tre_Driectroy.SelectedNode.Nodes.Add(tmp);
                    tre_Driectroy.ExpandAll();
                    tre_Driectroy.SelectedNode = tmp;
                    this.tre_Driectroy.HideSelection = false;
                }
            }
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                if (tre_Driectroy.SelectedNode == null)
                {
                    MessageBox.Show("请选择一个节点", "提示信息");
                }
                else
                {
                    TreeNode tmp = new TreeNode("节点");
                    tre_Driectroy.SelectedNode.Parent.Nodes.Add(tmp);
                    tre_Driectroy.ExpandAll();
                    this.tre_Driectroy.HideSelection = false;
                }
            }
            catch (Exception)
            {

               //throw;
            }
           
        }

        private void button3_Click(object sender, EventArgs e)
        {
          if (tre_Driectroy.SelectedNode.Nodes.Count == 0)
            {
                tre_Driectroy.SelectedNode.Remove();
            }
            else
            {
                MessageBox.Show("请先删除此节点下的所有子节点", "提示信息", MessageBoxButtons.OK); 
            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (this.rad_FromTemplate.Checked == true)
            {
                this.but_SelectTemplate.Enabled = true;
            }
            else
            {
                this.but_SelectTemplate.Enabled = false;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.button4.Enabled = false;
            this.but_SelectTemplate.Enabled = false;
            this.but_CreateDirectories.Enabled = false;
            this.but_AddChildNode.Enabled = false;
            this.but_AddParentNode.Enabled = false;
            this.but_DeleteNode.Enabled = false;
            this.txt_ProjectName.Enabled = false;
            this.but_ManualCreateRoot.Enabled = false;
            this.but_ChangePath.Enabled = false;
            this.chk_UseCurrentPath.Enabled = false;
            this.lab_Attation.Text = 
@"使用方法：尽量选用从模板生成目录方式，详细内容用文本编辑器打开模板文件。
                   模板文件请使用UTF-8编码方式。
                   生成目录后，在创建文件夹之前可以在目录节点上鼠标右键单击，编辑该节点。";
            this.lab_CR.Text = this.copyright;
        }

        private void but_SelectTemplate_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog1 = new OpenFileDialog())
            {
                openFileDialog1.InitialDirectory = Directory.GetCurrentDirectory();
                openFileDialog1.Filter = "Text File|*.txt";
                openFileDialog1.RestoreDirectory = true;
                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    lab_TemplateFile.Text = openFileDialog1.FileName;
                    this.button4.Enabled = true;
                    try
                    {
                        StreamReader sr = new StreamReader(lab_TemplateFile.Text, Encoding.UTF8); //打开模板文件
                        ProjectName = sr.ReadLine().Trim(); //读取模板文件中第一行，项目名称
                        ProjectPath = sr.ReadLine().Trim(); //读取模板文件中第二行，项目存储路径
                        this.lab_ProjectName.Text = ProjectName;
                        this.lab_ProjectPath.Text = ProjectPath;
                        this.but_ChangePath.Enabled = true;
                        

                        //读取模板文件中的目录信息
                        string line = "";
                        while ( (line = sr.ReadLine()).Trim()!= null )
                        { //读取目录信息，判断一级目录和二级目录，存储到对应列表中。
                            int Pointer_Start, Pointer_End;
                            line = line.Replace("\t", "");
                            Pointer_Start = line.IndexOf("-");
                            Pointer_End = line.LastIndexOf("-");
                            if(Pointer_Start == Pointer_End)
                            {
                                L1_Directroies.Add(line);
                            }
                            else
                            {
                                L2_Directories.Add(line);
                            }
                            
                        }
                     
                        
                    }
                    catch (Exception)
                    {

                        //throw;
                    }
                    

                }
                else
                {
                    lab_TemplateFile.Text = "请选择一个模板文件";
                }

            }

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.tre_Driectroy.Nodes.Count != 0)
                {
                    DialogResult dr = MessageBox.Show("是否要清空并新建目录结构？", "重要提示", MessageBoxButtons.OKCancel);
                    if (dr == DialogResult.OK)
                    {
                        this.tre_Driectroy.Nodes.Clear();
                        TreeNode ProjectRoot = new TreeNode();
                        ProjectRoot = this.tre_Driectroy.Nodes.Add(this.ProjectName);
                    }
                }
                else
                {
                    this.tre_Driectroy.Nodes.Add(ProjectName);
                }
                foreach (var itemL1 in L1_Directroies)
                {
                    TreeNode cur_Node = new TreeNode();
                    cur_Node = tre_Driectroy.Nodes[0].Nodes.Add(itemL1);
                    tre_Driectroy.SelectedNode = cur_Node;
                    foreach (var itemL2 in L2_Directories)
                    {
                        if(itemL1.Substring(0,itemL1.IndexOf("-")) == itemL2.Substring(0, itemL2.IndexOf("-")))
                        {
                            cur_Node.Nodes.Add(itemL2);
                        }
                    }
                }
               
                this.tre_Driectroy.ExpandAll();
                this.tre_Driectroy.SelectedNode = this.tre_Driectroy.Nodes[0];
                this.button4.Enabled = false;
                this.but_CreateDirectories.Enabled = true;
                this.but_AddChildNode.Enabled = true;
                this.but_AddParentNode.Enabled = true;
                this.but_DeleteNode.Enabled = true;
                this.chk_UseCurrentPath.Enabled = true;

            }
            catch (Exception)
            {
                // throw;
            }
        }

        private void tre_Driectroy_NodeMouseDoubleClick(object sender, TreeNodeMouseClickEventArgs e)
        {
           // MessageBox.Show(Convert.ToString(e.Node.Index));
        }

        private void tre_Driectroy_MouseClick(object sender, MouseEventArgs e)
        {
            if(e.Button == MouseButtons.Right)
            {
                //e.Node.BeginEdit();
            }
        }

        private void tre_Driectroy_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {//右键选择节点启用编辑功能
            if(e.Button == MouseButtons.Right)
            {
                tre_Driectroy.LabelEdit = true;
                tre_Driectroy.SelectedNode.BeginEdit();
            }
        }

        private void but_CreateDirectories_Click(object sender, EventArgs e)
        {//创建目录
            foreach(TreeNode tn in tre_Driectroy.Nodes)
            {
                Get_Path(tn);
               
                foreach (var item in Directories)
                {
                    if( !Directory.Exists(item))
                    {
                        Directory.CreateDirectory((this.lab_ProjectPath.Text + @"\"  + item).Replace(@"\\", @"\"));
                    }
                }
                
            }
            if(MessageBox.Show("目录创建完成。\n\r是否需要打开此文件夹？"+ (this.lab_ProjectPath.Text + @"\" + this.lab_ProjectName.Text).Replace(@"\\", @"\"), "提示", MessageBoxButtons.YesNo) == DialogResult.Yes   )
            {
                System.Diagnostics.Process.Start("explorer.exe", (this.lab_ProjectPath.Text + @"\" + this.lab_ProjectName.Text).Replace(@"\\", @"\"));
            }
        }

        private void rad_Manual_Click(object sender, EventArgs e)
        {
           
            try
            {
                if( this.tre_Driectroy.Nodes[0].GetNodeCount(false) > 0  )
                {
                    if( MessageBox.Show("目录结构已经存在，是否清除该目录？ \n 清除后将不可恢复！", "重要提示", MessageBoxButtons.YesNo) == DialogResult.Yes  )
                    {
                        this.tre_Driectroy.Nodes.Clear();
                        this.txt_ProjectName.Enabled = true;
                        this.txt_ProjectName.Text = "请输入项目名称";
                    }
                    else
                    {
                        if(MessageBox.Show("是否保留当前目录根节点？", "重要提示", MessageBoxButtons.YesNo) == DialogResult.Yes)
                        {
                            this.txt_ProjectName.Enabled = false;
                            this.txt_ProjectName.Text = this.tre_Driectroy.Nodes[0].Text;
                            this.but_ManualCreateRoot.Enabled = false;
                            this.but_AddChildNode.Enabled = true;
                            this.but_AddParentNode.Enabled = true;
                            this.but_DeleteNode.Enabled = true;
                        }
                        else
                        {
                            this.txt_ProjectName.Enabled = true;
                            this.txt_ProjectName.Text = this.tre_Driectroy.Nodes[0].Text;
                        }
                    }
                }
            }
            catch (Exception)
            {
            }
        }

        private void txt_ProjectName_TextChanged(object sender, EventArgs e)
        {
            this.but_ManualCreateRoot.Enabled = true;
        }

        private void rad_Manual_CheckedChanged(object sender, EventArgs e)
        {
            if(this.rad_Manual.Checked == true)
            {
                this.txt_ProjectName.Enabled = true;
                this.but_ManualCreateRoot.Enabled = true;
            }
            else
            {
                this.txt_ProjectName.Enabled = false;
                this.but_ManualCreateRoot.Enabled = false;
            }
        }

        private void but_ManualCreateRoot_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.txt_ProjectName.Text.Trim().Length > 0) //判断项目根节点长度，0长度不创建
                {
                    if (this.tre_Driectroy.Nodes.Count > 0) //判断当前目录结构是否存在，
                    {
                        this.tre_Driectroy.Nodes[0].Text = this.txt_ProjectName.Text.Trim(); //如果有目录存在，将根节点名称替换
                    }
                    else
                    {//不存在目录结构，
                        TreeNode tmp = new TreeNode(this.txt_ProjectName.Text.Trim());
                        tre_Driectroy.Nodes.Add(tmp);
                    }
                    this.but_ManualCreateRoot.Enabled = false;
                    this.txt_ProjectName.Enabled = false;
                    this.but_AddChildNode.Enabled = true;
                    this.but_AddParentNode.Enabled = true;
                    this.but_DeleteNode.Enabled = true;
                    this.button4.Enabled = false;
                    this.but_CreateDirectories.Enabled = true;
                    //this.ProjectName = string.Empty;
                    //this.ProjectPath = string.Empty;
                    this.ProjectName = this.tre_Driectroy.Nodes[0].Text.Trim();
                    this.ProjectPath = Directory.GetCurrentDirectory();
                    this.lab_ProjectName.Text = ProjectName;
                    this.lab_ProjectPath.Text = ProjectPath;
                    this.but_ChangePath.Enabled = true;
                    this.chk_UseCurrentPath.Enabled = true;

                }
                else
                {
                    MessageBox.Show("请检查项目名称", "检查", MessageBoxButtons.OK);
                    this.txt_ProjectName.Focus();
                }
                
            }
            catch (Exception)
            {

            }
           
            
        }

        private void chk_UseCurrentPath_CheckStateChanged(object sender, EventArgs e)
        {
            if( this.chk_UseCurrentPath.Checked  )
            {
                this.lab_ProjectPath.Text = Directory.GetCurrentDirectory();
            }
            else
            {
                this.lab_ProjectPath.Text = ProjectPath;
            }
        }

        private void but_ChangePath_Click(object sender, EventArgs e)
        {
            this.chk_UseCurrentPath.Checked = false;
            FolderBrowserDialog FolderPath = new FolderBrowserDialog();
            if(FolderPath.ShowDialog() == DialogResult.OK)
            {
                lab_ProjectPath.Text = FolderPath.SelectedPath;
            }
        }
    }
}
