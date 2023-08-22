using Microsoft.VisualBasic.Devices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TicTacToeGame.Models;
using Computer = TicTacToeGame.Models.Computer;

namespace TicTacToeGame
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }



        private void button11_Click(object sender, EventArgs e)
        {

            if (button2.Text != null && ((Txt00.Text == "X" || Txt00.Text == "x")))
            {
                button2.Text = Txt00.Text.ToUpper();

                button11.Enabled = false;
                Txt00.Enabled = false;
            }
        }

        private void button12_Click(object sender, EventArgs e)
        {

            if (button3.Text != null && ((Txt01.Text == "X" || Txt01.Text == "x")))
            {
                button3.Text = Txt01.Text.ToUpper();
                button12.Enabled = false;
                Txt01.Enabled = false;

            }
        }

        private void button13_Click(object sender, EventArgs e)
        {

            if (button4.Text != null && ((Txt02.Text == "X" || Txt02.Text == "x")))
            {
                button4.Text = Txt02.Text.ToUpper();
                button13.Enabled = false;
                Txt02.Enabled = false;
            }
        }

        private void button14_Click(object sender, EventArgs e)
        {

            if (button5.Text != null && ((Txt03.Text == "X" || Txt03.Text == "x")))
            {
                button5.Text = Txt03.Text.ToUpper();
                button14.Enabled = false;
                Txt03.Enabled = false;
            }
        }

        private void button15_Click(object sender, EventArgs e)
        {

            if (button6.Text != null && ((Txt04.Text == "X" || Txt04.Text == "x")))
            {
                button6.Text = Txt04.Text.ToUpper();
                button15.Enabled = false;
                Txt04.Enabled = false;
            }
        }

        private void button16_Click(object sender, EventArgs e)
        {

            if (button7.Text != null && ((Txt05.Text == "X" || Txt05.Text == "x")))
            {
                button7.Text = Txt05.Text.ToUpper();
                button16.Enabled = false;
                Txt05.Enabled = false;
            }
        }

        private void button17_Click(object sender, EventArgs e)
        {

            if (button8.Text != null && ((Txt06.Text == "X" || Txt06.Text == "x")))
            {
                button8.Text = Txt06.Text.ToUpper();
                button17.Enabled = false;
                Txt06.Enabled = false;
            }
        }

        private void button18_Click(object sender, EventArgs e)
        {

            if (button9.Text != null && ((Txt07.Text == "X" || Txt07.Text == "x")))
            {
                button9.Text = Txt07.Text.ToUpper();
                button18.Enabled = false;
                Txt07.Enabled = false;
            }
        }

        private void button19_Click(object sender, EventArgs e)
        {

            if (button10.Text != null && ((Txt08.Text == "X" || Txt08.Text == "x")))
            {
                button10.Text = Txt08.Text.ToUpper();
                button19.Enabled = false;
                Txt08.Enabled = false;
            }
        }

        private void BtnBilgisayar_Click(object sender, EventArgs e)
        {
            string[] textBoxes = { Txt00.Text, Txt01.Text, Txt02.Text, Txt03.Text, Txt04.Text, Txt05.Text, Txt06.Text, Txt07.Text, Txt08.Text };

            Random rnd = new Random();
            int randomTextBox = rnd.Next(0, 9);

            Computer computer1 = new Computer("Macintosh", textBoxes);
            LblRandomNumber.Text = randomTextBox.ToString();
            //LblRandomTxtBox.Text = textBoxes[randomTextBox];
            LblPCName.Text = computer1.Name;
            WinSituation();
            if (textBoxes[randomTextBox] == "")
            {
                textBoxes[randomTextBox] = "O";

                UpdateUIElement(randomTextBox);

            }


            void UpdateUIElement(int index)
            {
                switch (index)
                {
                    case 0:
                        button2.Text = "O";
                        button11.Enabled = false;
                        Txt00.Enabled = false;
                        break;
                    case 1:
                        button3.Text = "O";
                        button12.Enabled = false;
                        Txt01.Enabled = false;
                        break;
                    case 2:
                        button4.Text = "O";
                        button13.Enabled = false;
                        Txt02.Enabled = false;
                        break;
                    case 3:
                        button5.Text = "O";
                        button14.Enabled = false;
                        Txt03.Enabled = false;
                        break;
                    case 4:
                        button6.Text = "O";
                        button15.Enabled = false;
                        Txt04.Enabled = false;
                        break;
                    case 5:
                        button7.Text = "O";
                        button16.Enabled = false;
                        Txt05.Enabled = false;
                        break;
                    case 6:
                        button8.Text = "O";
                        button17.Enabled = false;
                        Txt06.Enabled = false;
                        break;
                    case 7:
                        button9.Text = "O";
                        button18.Enabled = false;
                        Txt07.Enabled = false;
                        break;
                    case 8:
                        button10.Text = "O";
                        button19.Enabled = false;
                        Txt08.Enabled = false;
                        break;
                    default:
                        // Invalid index, handle appropriately
                        break;

                }
            }
            WinSituation();
            void WinSituation()
            {
                // Player 1 as me winning situations
                if (button2.Text == "X" && button5.Text == "X" && button8.Text == "X")
                {
                    MessageBox.Show("Ben Kazandım.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Application.Exit();
                }
                else if (button2.Text == "X" && button3.Text == "X" && button4.Text == "X")
                {
                    MessageBox.Show("Ben Kazandım.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Application.Exit();
                }
                else if (button2.Text == "X" && button6.Text == "X" && button10.Text == "X")
                {
                    MessageBox.Show("Ben Kazandım.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Application.Exit();
                }
                else if (button3.Text == "X" && button6.Text == "X" && button9.Text == "X")
                {
                    MessageBox.Show("Ben Kazandım.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Application.Exit();
                }
                else if (button4.Text == "X" && button7.Text == "X" && button10.Text == "X")
                {
                    MessageBox.Show("Ben Kazandım.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Application.Exit();
                }
                else if (button4.Text == "X" && button6.Text == "X" && button8.Text == "X")
                {
                    MessageBox.Show("Ben kazandım.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Application.Exit();
                }
                // Player 2 as PC winning situations

                else if (button2.Text == "O" && button5.Text == "O" && button8.Text == "O")
                {
                    MessageBox.Show("PC kazandı.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Application.Exit();
                }
                else if (button2.Text == "O" && button3.Text == "O" && button4.Text == "O")
                {
                    MessageBox.Show("PC kazandı.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Application.Exit();
                }
                else if (button2.Text == "O" && button6.Text == "O" && button10.Text == "O")
                {
                    MessageBox.Show("PC kazandı.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Application.Exit();
                }
                else if (button3.Text == "O" && button6.Text == "O" && button9.Text == "O")
                {
                    MessageBox.Show("PC kazandı.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Application.Exit();
                }
                else if (button4.Text == "O" && button7.Text == "O" && button10.Text == "O")
                {
                    MessageBox.Show("PC kazandı.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Application.Exit();
                }
                else if (button4.Text == "O" && button6.Text == "O" && button8.Text == "O")
                {
                    MessageBox.Show("PC kazandı.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Application.Exit();
                }



            }
        }
    }
}
