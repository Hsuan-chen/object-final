using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace test
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: 這行程式碼會將資料載入 'dDDDDataSet1.DATA1' 資料表。您可以視需要進行移動或移除。
            this.dATA1TableAdapter1.Fill(this.dDDDDataSet1.DATA1);
            

        }

        private void button1_Click(object sender, EventArgs e) //新增
        {
            this.dATA1TableAdapter1.Insert(textBox1.Text,textBox3.Text, textBox4.Text, textBox5.Text,textBox2.Text);
            this.dATA1TableAdapter1.Fill(this.dDDDDataSet1.DATA1);
            
        }

        private void button4_Click(object sender, EventArgs e) //清空欄位的值
        {
            textBox1.Clear();
            this.pictureBox1.Image = null;
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
        }

        private void button2_Click(object sender, EventArgs e) //修改
        {
            this.dATA1BindingSource1.EndEdit();
            this.dATA1TableAdapter1.Update(this.dDDDDataSet1);
        }

        private void button3_Click(object sender, EventArgs e) //刪除
        {
            this.dATA1TableAdapter1.Delete(textBox1.Text, textBox3.Text, textBox4.Text, textBox5.Text,textBox2.Text);
            this.dATA1TableAdapter1.Fill(this.dDDDDataSet1.DATA1);
        }

        private void button5_Click(object sender, EventArgs e) //搜尋聯絡人
        {
            switch (comboBox1.Text)
            {
                case "姓名":
                    this.dATA1BindingSource1.Position = this.dATA1BindingSource1.Find("姓名", textBox6.Text);
                    break;
                
                case "電話":
                    this.dATA1BindingSource1.Position = this.dATA1BindingSource1.Find("電話", textBox6.Text);
                    break;
                case "縣市":
                    this.dATA1BindingSource1.Position = this.dATA1BindingSource1.Find("縣市", textBox6.Text);
                    break;
                case "E-mail":
                    this.dATA1BindingSource1.Position = this.dATA1BindingSource1.Find("E-mail", textBox6.Text);
                    break;

            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e) //插入圖片
        {
            OpenFileDialog of1 = new OpenFileDialog(); //開啟選擇檔案
            if (of1.ShowDialog() == DialogResult.OK)
            {
                textBox2.Text = of1.FileName;   //textBox5顯示位置
                pictureBox1.Image = Image.FromFile(of1.FileName);

            }
        }
    }
}
