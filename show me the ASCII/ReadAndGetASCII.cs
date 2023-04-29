using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace show_me_the_ASCII
{
    internal static class ReadAndGetASCII
    {
        //#### judge the textBox is empty or not
        public static bool isNull(TextBox textBox)
        {
            if (textBox.TextLength == 0) //空格不算空
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        //- [Csharpwhystatic.png] (https://we-1307938470.cos.ap-beijing.myqcloud.com/pictures/Csharpwhystatic.png)
        //#### 讀取文本框首字符方法
        public static char ReadChar(TextBox textBox)
        {
            return textBox.Text[0]; //取文本的0號索引, 即第一個字符
        }

        //#### 獲取首字符ASCII方法
        public static int getASCII(TextBox textBox)
        {
            return (int)ReadChar(textBox);
        }

        //#### 讀取文本框數字方法
        public static char ReadASCII(TextBox textBox)
        {
            int tempresult = Convert.ToInt32(textBox.Text);
            char result = (char)tempresult; //轉來轉去的
            return result;
        }
        //#### 通過ASCII獲取char方法
        public static char getChar(TextBox textBox)
        {
            char result = (char)ReadASCII(textBox);
            return result;
        }
    }
}