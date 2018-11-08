using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;
using System.Threading;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SoundPlayer sp;

        char[] characters = new char[] { 'А','Б', 'В', 'Г', 'Д', 'Е', 'Ж', 'З', 'И',
                                                        'Й', 'К', 'Л', 'М', 'Н', 'О', 'П', 'Р', 'С', 
                                                        'Т', 'У', 'Ф', 'Х', 'Ц', 'Ч', 'Ш', 'Щ', 'Ы', 'Ь',
                                                        'Э', 'Ю', 'Я', 
                                                        'A', 'B', 'C',
                                                        'D', 'E', 'F',
                                                        'G', 'H', 'I',
                                                        'J', 'K', 'L',
                                                        'M', 'N', 'O', 
                                                        'P', 'Q', 'R', 
                                                        'S', 'T', 'U', 'V', 
                                                        'W', 'X', 'Y', 'Z', 
                                                        '1', '2', '3', '4', '5', '6', '7',
                                                        '8', '9', '0'};

        string[] codeMorse = new string[] { "*–", "–***", "*– –", "– –*", 
                                                        "–**", "*", "***–", "– –**",
                                                        "**", "*– – –", "–*–", "*–**",
                                                        "– –", "–*", "– – –", "*– –*", 
                                                        "*–*", "***", "–", "**–", 
                                                        "**–*", "****", "–*–*",
                                                        "– – –*", "– – – –", "− −*−",
                                                        "−*− −", "−**−", "**−**",
                                                        "**− −", "*−*−",  
                                                        "*–", "–***", "–*–*", 
                                                        "–**", "*", "**–*", 
                                                        "– –*", "****", "**", 
                                                        "*– – –", "–*–", "*–**",
                                                        "– –", "–*", "– – –",
                                                        "*– –*", "– –*–", "*–*",
                                                        "***", "–", "**–", "***–",
                                                        "*– –", "–**–", "–*– –", "– –**",
                                                        "*− − − −", 
                                                        "**− − −", "***− −", "****−",
                                                        "*****", "−****", "− −***",
                                                        "− − −**", "− − − −*", "− − − − −"};

        private void button1_Click(object sender, EventArgs e)
        {
            string input = textBox1.Text;
            input = input.ToUpper();
            string output = "";
            int index;
            foreach (char c in input)
            {
                if (c != ' ')
                {
                    index = Array.IndexOf(characters, c);
                    output += codeMorse[index] + " ";
                }
            }
            output = output.Remove(output.Length - 1);
            textBox2.Text = output;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int i = textBox2.Text.Length;
            string kod = textBox2.Text;
            string x = "*";
            string y = "−";
            for (int z = 0; z < i;z++ )
            {
                string text = Convert.ToString(kod[z]);
                if (text == x)
                {
                    sp = new SoundPlayer();
                    sp.Stream = Properties.Resources.T1;
                    sp.Play();
                    System.Threading.Thread.Sleep(250);
                   
                }
                else if (text == " ")
                {
                    
                    
                }
                else
                {
                    sp = new SoundPlayer();
                    sp.Stream = Properties.Resources.Tire1;
                    sp.Play();
                    System.Threading.Thread.Sleep(350);
                   
                }
            }
            //textBox3.Text = Convert.ToString(i);
        }
    }
}
