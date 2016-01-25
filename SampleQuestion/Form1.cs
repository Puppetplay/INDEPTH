using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SampleQuestion
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void bt우아한형제들1_Click(object sender, EventArgs e)
        {
            //string input = "132-132121231-13213";
            string input = "54543453-5435-543--5435";
            MessageBox.Show(우아한형제들1(input));
        }

        private string 우아한형제들1(string s)
        {
            string input = s.Replace("-", "");
            List<string> strs = new List<string>();
            for(int i = 0; i < input.Length / 3; ++i)
            {
                strs.Add(input.Substring(i * 3, 3));
            }

            string lastStr = string.Empty;
            if(input.Length % 3 != 0)
            {
                lastStr = input.Substring((input.Length / 3) * 3, input.Length - (input.Length / 3) * 3);
            }

            string result = string.Empty;
            if (strs.Count > 0)
            {
                if (lastStr.Length == 1)
                {
                    lastStr = strs[strs.Count - 1].Substring(2, 1) + lastStr;
                    strs[strs.Count - 1] = strs[strs.Count - 1].Substring(0, 2);
                }
                foreach (string str in strs)
                {
                    result += str + "-";
                }

                if (lastStr.Length == 0)
                {
                    result = result.Remove(result.Length - 1, 1);
                }
                else
                {
                    result += lastStr;
                }
            }


            return result;
                    
          
        }
    }
}
