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
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(tre_Driectroy.SelectedNode == null)
            {
                MessageBox.Show("选择一个节点", "提示信息");
            }
            else
            {
                TreeNode tmp;
                tmp = new TreeNode("节点");
                tre_Driectroy.SelectedNode.Nodes.Add(tmp);
                tre_Driectroy.SelectedNode = tmp;
                tre_Driectroy.ExpandAll();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(tre_Driectroy.SelectedNode == null)
            {
                MessageBox.Show("请选择一个节点", "提示信息");
            }
            else
            {
                TreeNode tmp = new TreeNode("节点");
                tre_Driectroy.SelectedNode.Parent.Nodes.Add(tmp);
                tre_Driectroy.ExpandAll();
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
            this.groupBox1.Width = 250;
        }

        private void but_SelectTemplate_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.InitialDirectory = @"d:\";
            openFileDialog1.Filter = "Text File|*.txt";
            openFileDialog1.RestoreDirectory = true;
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                lab_TemplateFile.Text = openFileDialog1.FileName;
                this.groupBox1.Width = this.lab_TemplateFile.Width +50;
            }
            else
            {
                lab_TemplateFile.Text = "请选择一个模板文件";
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                StreamReader sr = new StreamReader(lab_TemplateFile.Text);
                using (sr) ;
                {
                    string ProjectName = sr.ReadLine().Trim();
                    this.tre_Driectroy.Nodes.Add(ProjectName);
                }
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
