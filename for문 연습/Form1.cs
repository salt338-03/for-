using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace for문_연습
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }



        private void button1_Click(object sender, EventArgs e)
        {
            textBox2.Text = string.Empty;
            int Student;
            int.TryParse(textBox1.Text, out Student);
            string[] StudentName = new string[Student];
            int[] StudentScore = new int[Student];

            // Random 객체를 한 번만 생성
            Random random = new Random();
            if (int.TryParse(textBox1.Text, out Student))
            {
                int i = 0;

                while (i < Student)
                {
                    StudentName[i] = $"학생{i + 1}";
                    i++;
                   
                }
                i = 0;

                while (i < Student)
                {
                    StudentScore[i] = random.Next(1, 101); 
                    i++;
                }

                //for (int i = 0; i < Student; i++)
                //{
                //    StudentName[i] = $"학생{i + 1}";
                //}
                //for (int i = 0; i < Student; i++)
                //{
                //    난수 생성
                //    StudentScore[i] = random.Next(1, 101); // 1부터 100까지의 난수
                //}

                GenerateString(Student, StudentName, StudentScore);
            }
            else
            {
                MessageBox.Show("숫자만입력해줘요");
            }


        }
        void GenerateString(int Student1, string[] a, int[] b)
        {
            int i = 0;
            while (i < Student1)
            {
                textBox2.Text += ($"{a[i]} 의 점수는 {b[i]}\r\n");
                i++;
            }
            //for (int i = 0; i < Student1; i++)
            //{
            //    textBox2.Text += ($"{a[i]} 의 점수는 {b[i]}\r\n");
            //}
            return;
        }


        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
