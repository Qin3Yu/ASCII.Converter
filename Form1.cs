using System;
using System.Drawing;
using System.Windows.Forms;

namespace ASCII.Converter {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();

            // 允许窗体预览键盘事件
            this.KeyPreview = true;

            // 绑定 KeyDown 事件
            this.KeyDown += new KeyEventHandler(Form1_KeyDown);

            // 修改只读
            textBox_Char1.ReadOnly = true;
            textBox_ASCII1.ReadOnly = true;
            textBox_Char2.ReadOnly = true;
            textBox_ASCII2.ReadOnly = true;

            // 设置窗口为固定边框样式
            this.FormBorderStyle = FormBorderStyle.FixedSingle;

            // 禁用最大化按钮
            this.MaximizeBox = false;

            // 将最小尺寸和最大尺寸设置为当前尺寸
            this.MinimumSize = this.Size;
            this.MaximumSize = this.Size;

        }

        // 快捷转换 KeyDown 事件处理程序
        private void Form1_KeyDown(object sender, KeyEventArgs e) {
            
            // 读取按键为 char
            char ch = (char)e.KeyValue;

            string s1, s2, a1, a2;

            // 如果是字母
            if(ch >='A' && ch <= 'z') {
                textBox_Char1.BackColor = Color.White;
                textBox_ASCII1.BackColor = Color.White;
                textBox_Char2.BackColor = Color.White;
                textBox_ASCII2.BackColor = Color.White;
                s1 = ch.ToString();
                s2 = (char.ToLower(ch)).ToString();
                a1= ((int)ch).ToString();
                a2= ((int)char.ToLower(ch)).ToString();
                textBox_Char1.Text = s1;
                textBox_Char2.Text = s2;
                textBox_ASCII1.Text = a1;
                textBox_ASCII2.Text = a2;
            }

            // 如果是数字
            else if(ch >='0' && ch <= '9') {
                textBox_Char1.BackColor = Color.White;
                textBox_ASCII1.BackColor = Color.White;
                textBox_Char2.BackColor = Form1.DefaultBackColor;
                textBox_ASCII2.BackColor = Form1.DefaultBackColor;
                textBox_Char2.Text = "-";
                textBox_ASCII2.Text = "-";
                s1 = ch.ToString();
                a1 = ((int)ch).ToString();
                textBox_Char1.Text = s1;
                textBox_ASCII1.Text = a1;
            }

            else {
                textBox_Char1.BackColor = Form1.DefaultBackColor;
                textBox_ASCII1.BackColor = Form1.DefaultBackColor;
                textBox_Char2.BackColor = Form1.DefaultBackColor;
                textBox_ASCII2.BackColor = Form1.DefaultBackColor;
                textBox_Char1.Text = "-";
                textBox_ASCII1.Text = "-"; 
                textBox_Char2.Text = "-";
                textBox_ASCII2.Text = "-";
            }
            
        }

        private void Button_Converter_Click(object sender, EventArgs e) {
            string s = "";

            if (textBox_Char3.Text != "") {
                textBox_ASCII3.Text = ((int)textBox_Char3.Text[0]).ToString();
            }
            
            else if(textBox_ASCII3.Text != "") {
                textBox_Char3.Text = ((char)Convert.ToInt32(textBox_ASCII3.Text)).ToString();
            }
        }

        private void Button_Clear_Click(object sender, EventArgs e) {
            textBox_Char3.Text = "";
            textBox_ASCII3.Text = "";
        }
    }
}
