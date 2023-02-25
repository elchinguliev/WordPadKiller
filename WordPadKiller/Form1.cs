using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WordPadKiller
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }
  

     

    

        private void fontClick_Click(object sender, EventArgs e)
        {
            if (fontDialog1.ShowDialog()==DialogResult.OK)
            {
                textBox1.Font=fontDialog1.Font;

            }
        }

        private void colorClick_Click(object sender, EventArgs e)
        {
       
            if (colorDialog1.ShowDialog()==DialogResult.OK)
            {
                textBox1.ForeColor=colorDialog1.Color;
            }
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog()==DialogResult.OK)
            {
                File.WriteAllText(saveFileDialog1.FileName, textBox1.Text);
            }
        }

        private void Form1_Load_1(object sender, EventArgs e)
        {
            foreach(FontFamily font  in FontFamily.Families)
            {
                comboBoxFonts.Items.Add(font.Name.ToString());
            }
        }

        private void comboBoxFonts_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBox1.Font=new Font(comboBoxFonts.Text, textBox1.Font.Size);
        }

        private void regularFontStyleButton_Click(object sender, EventArgs e)
        {
            textBox1.Font=new Font(textBox1.Font.FontFamily,textBox1.Font.Size,FontStyle.Regular);
        }

        private void obliqueFontStyleButton_Click(object sender, EventArgs e)
        {
            textBox1.Font=new Font(textBox1.Font.FontFamily, textBox1.Font.Size, FontStyle.Italic);

        }

        private void boldFontStyleButton_Click(object sender, EventArgs e)
        {
            textBox1.Font=new Font(textBox1.Font.FontFamily, textBox1.Font.Size, FontStyle.Bold);

        }

        private void boldObliqueFontStyleButton_Click(object sender, EventArgs e)
        {
            textBox1.Font=new Font(textBox1.Font.FontFamily, textBox1.Font.Size, FontStyle.Underline);

        }

        private void LButton_Click(object sender, EventArgs e)
        {
            textBox1.TextAlign=HorizontalAlignment.Left;
        }

        private void CButton_Click(object sender, EventArgs e)
        {
            textBox1.TextAlign=HorizontalAlignment.Center;
        }

        private void RButton_Click(object sender, EventArgs e)
        {
            textBox1.TextAlign=HorizontalAlignment.Right;
        }

        private void comboBoxSize_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBox1.Font=new Font(textBox1.Font.FontFamily, float.Parse(comboBoxSize.SelectedText.ToString()));
        }

   
    }
}
