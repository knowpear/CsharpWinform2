using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace show_me_the_ASCII
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //### ReadAndConverttextBox 用來接收文本

        //### ReadAndConvertButton_Click Event
        private void ReadAndConvertButton_Click(object sender, EventArgs e)
        {
            //judge the specific TextBox isNull or not
            bool isNull = ReadAndGetASCII.isNull(ReadAndConverttextBox);
            if (isNull)
            {
                MessageBox.Show("Your input is null");
                return;
            }

            //#### 判斷是否是數字
            bool isNumeric = int.TryParse(ReadAndConverttextBox.Text.ToString(), out int judgementResult);
            if(isNumeric) //輸入是數字的情況
            {
                //#### 調用getChar方法並輸出
                char charResult = ReadAndGetASCII.getChar(ReadAndConverttextBox);
                Clipboard.SetText(charResult.ToString());
                MessageBox.Show($"the char is: {charResult}\n"+
                    $"It's in your Clipboard!");
            }
            else //其他情況, 字母, 字符等
            {
                //#### 調用getASCII方法並輸出
                int intResult = ReadAndGetASCII.getASCII(ReadAndConverttextBox);
                Clipboard.SetText(intResult.ToString());
                MessageBox.Show($"the ASCII is: {intResult}\n" + 
                    $"It's in your Clipboard!");
            }
        }
    }
}
