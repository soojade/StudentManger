using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace StudentManger {
    public partial class fmMain : Form {
        private string fileName = string.Empty; // 数据文件路径
        private List<string> studentList = new List<string>(); // 保存读取到的学生信息
        public fmMain() {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e) {

        }

        private void button2_Click(object sender, EventArgs e) {

        }

        private void button4_Click(object sender, EventArgs e) {

        }

        private void label6_Click(object sender, EventArgs e) {

        }

        private void fmMain_Load(object sender, EventArgs e) {

        }

        // 导入数据事件
        private void BTNImport_Click(object sender, EventArgs e) {
            // 打开文件
            OpenFileDialog openFile = new OpenFileDialog();
            openFile.Filter = "文本文件(*.txt)|*.txt|所有文件(*.*)|*.*";
            if (openFile.ShowDialog()==DialogResult.OK) {
                fileName = openFile.FileName;
            }

            try {
                studentList = ReadFileToList(fileName);
            } catch (Exception exc) {
                MessageBox.Show("读取文件错误：" + exc.Message,"系统消息", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        // 读取数据
        private List<string> ReadFileToList(string file) {

        }

    }
}
