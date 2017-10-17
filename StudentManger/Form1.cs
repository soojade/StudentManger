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
        private int flag = 0; // 判断添加还是修改 0修改 1添加

        public fmMain() {
            InitializeComponent();

            // 禁用详情区域
            gbDetail.Enabled = false;
        }


        private void groupBox1_Enter(object sender, EventArgs e) {

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


        // 进入添加数据状态
        private void btnAdd_Click(object sender, EventArgs e) {
            ToggleEnable(false);
            InputEmpty();
            tbName.Focus();
            flag = 1;
        }

        // 进入修改数据状态
        private void btnUpdate_Click(object sender, EventArgs e) {
            tbId.Enabled = false; // 学号不能修改

            ToggleEnable(false);
            tbName.Focus();
            flag = 0;

        }

        // 删除数据
        private void btnDelete_Click(object sender, EventArgs e) {
            if (dgvStudent.CurrentRow.Selected==false) {
                MessageBox.Show("请先选中后再删除", "系统信息", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            } else {
                string info = "确定要删除" + dgvStudent.CurrentRow.Cells[0].Value + "号学生信息吗？";
                DialogResult res = MessageBox.Show(info, "系统信息", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (res==DialogResult.Yes) {
                    string student = GetStudentById(dgvStudent.CurrentRow.Cells[0].Value.ToString());
                    foreach (var item in studentList) {
                        if (item.Equals(student)) {
                            studentList.Remove(item);
                            dgvStudent.Rows.Clear();
                            LoadDataToDateGrid(studentList);
                            MessageBox.Show("删除成功", "系统消息", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            break;
                        }
                    }
                } else {
                    return;
                }
            }
        }

        // 提交数据
        private void btnSubmit_Click(object sender, EventArgs e) {
            if (!Verification()) {
                return;
            } else {
                string id = tbId.Text.Trim();
                string name = tbName.Text.Trim();
                string sex = rbMan.Checked == true ? "男" : "女";
                string bday = dtpBDay.Text;
                string phone = tbPhone.Text.Trim();
                string email = tbEmail.Text.Trim();
                string addr = tbAddress.Text.Trim();
                string photo = string.Empty;
                string student = id + ',' + name + ',' + sex + ',' + bday + ',' + phone + ',' + email + ',' + addr;
                switch (flag) {
                    case 0: // 修改
                        for (int i = 0; i < studentList.Count; i++) {
                            if (studentList[i].StartsWith(id)) {
                                studentList.RemoveAt(i);
                                studentList.Insert(i, student);
                                dgvStudent.Rows.Clear();
                                LoadDataToDateGrid(studentList);
                                break;
                            }
                        }
                        MessageBox.Show("修改成功", "系统消息", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        InputEmpty();
                        ToggleEnable(true);
                        break;
                    case 1: // 添加
                        studentList.Add(student);
                        dgvStudent.Rows.Clear();
                        LoadDataToDateGrid(studentList);
                        MessageBox.Show("添加成功", "系统消息", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        InputEmpty();
                        ToggleEnable(true);
                        break;
                }
            }
        }

        // 取消修改
        private void btnCancel_Click(object sender, EventArgs e) {

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
            tbId.Text = student[0];
            tbName.Text = student[1];
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

        // 开关转换
        private void ToggleEnable(bool bl) {
            btnImport.Enabled = bl;
            btnAdd.Enabled = bl;
            btnDelete.Enabled = bl;
            btnUpdate.Enabled = bl;
            gbDetail.Enabled = !bl;
        }

        // 清空详情区输入框
        private void InputEmpty() {
            tbName.Text = "";
            tbId.Text = "";
            tbEmail.Text = "";
            tbPhone.Text = "";
            tbAddress.Text = "";
            dtpBDay.Text = "";
            rbMan.Checked = false;
            rbWoman.Checked = false;
        }

        // 输入验证
        private bool Verification() {
            bool bl = true;
            // 学号 姓名不能为空，学号不能重复
            if (string.IsNullOrWhiteSpace(tbId.Text)) {
                MessageBox.Show("学号不能为空！", "系统消息", MessageBoxButtons.OK, MessageBoxIcon.Information);
                tbId.Focus();
                bl=false;
            }
            if (string.IsNullOrWhiteSpace(tbName.Text)) {
                MessageBox.Show("姓名不能为空！", "系统消息", MessageBoxButtons.OK, MessageBoxIcon.Information);
                tbName.Focus();
                bl = false;
            }
            if (flag==1) {
                if (GetStudentById(tbId.Text.Trim())!="") {
                    MessageBox.Show("该学号已存在，请重新输入！", "系统消息", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    tbId.Focus();
                    bl = false;
                }
            }
            return bl;
        }
    }
}
