using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace StudentManger {
    public partial class fmMain : Form {
        private string fileName = string.Empty; // 数据文件路径
        private List<string> studentList = new List<string>(); // 保存读取到的学生信息
        private List<string> queryStudentList = new List<string>(); // 保持查询到的学生信息
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
            LoadDataToDateGrid(studentList);

            string currentId = dgvStudent.Rows[0].Cells[0].Value.ToString();
            string[] currentDetail = GetStudentById(currentId).Split(',');
            LoadDataToDetail(currentDetail);
        }

        // 表格选中事件
        private void dgvStudent_SelectionChanged(object sender, EventArgs e) {
            if (dgvStudent.CurrentRow.Selected == false) {
                return;
            } else {
                string currentId = dgvStudent.CurrentRow.Cells[0].Value.ToString();
                string[] currentDetail = GetStudentById(currentId).Split(',');
                LoadDataToDetail(currentDetail);
            }
        }

        // 按学号查询事件
        private void tbQueryId_TextChanged(object sender, EventArgs e) {
            Query(tbQueryId.Text);
        }

        // 按姓名查询事件
        private void tbQueryName_TextChanged(object sender, EventArgs e) {
            Query(tbQueryName.Text);
        }

        // 按手机号查询事件
        private void tbQueryPhone_TextChanged(object sender, EventArgs e) {
            Query(tbQueryPhone.Text);
        }

        // 读取数据
        private List<string> ReadFileToList(string filePath) {
            List<string> list = new List<string>();
            string line = string.Empty;
            try {
                StreamReader file = new StreamReader(filePath, Encoding.Default);
                while ((line=file.ReadLine())!=null) {
                    list.Add(line);
                }
                file.Close();
            } catch (Exception exc) {
                throw exc;
            }
            return list;
        }

        // 把数据读入DataGrid
        private void LoadDataToDateGrid(List<string> list) {
            foreach (string item in list) {
                string[] studentArr = item.Split(',');
                DataGridViewRow row = new DataGridViewRow();
                row.CreateCells(dgvStudent);
                row.Cells[0].Value = studentArr[0];
                row.Cells[1].Value = studentArr[1];
                row.Cells[2].Value = studentArr[2];
                row.Cells[3].Value = studentArr[3];
                row.Cells[4].Value = studentArr[4];
                dgvStudent.Rows.Add(row);
            }
        }

        // 把数据读入详情列表
        private void LoadDataToDetail(string[] student) {
            tbName.Text = student[0];
            tbId.Text = student[1];
            if (student[2] == "男") {
                rbMan.Checked = true;
            } else {
                rbWoman.Checked = true;
            }
            dtpBDay.Text = student[3];
            tbPhone.Text = student[4];
            tbEmail.Text = student[5];
            tbAddress.Text = student[6];
        }

        // 获取当前学生
        private string GetStudentById(string id) {
            string currentStudent = string.Empty;
            foreach (string item in studentList) {
                if (item.StartsWith(id)) {
                    currentStudent = item;
                    break;
                }
            }
            return currentStudent;
        }

        // 查询
        private void Query(string text) {
            queryStudentList.Clear();
            foreach (string item in studentList) {
                if (item.Contains(text)) {
                    queryStudentList.Add(item);
                }
                dgvStudent.Rows.Clear();
                LoadDataToDateGrid(queryStudentList);
            }
        }
    }
}
