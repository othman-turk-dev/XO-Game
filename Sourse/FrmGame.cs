using System;
using System.Drawing;
using System.Windows.Forms;

namespace XO_Game
{
    public partial class FrmGame : Form
    {
        public FrmGame()
        {
            InitializeComponent();
        }

        short Counter;
        short Round;

        enum eBox
        {
            Box1 = 1, Box2 = 2, Box3 = 3, Box4 = 4, Box5 = 5,
            Box6 = 6, Box7 = 7, Box8 = 8
        };
        bool CheckValue(Button Btn1, Button Btn2, Button Btn3)
        {
            if (Btn1.Tag.ToString() != "?" && Btn1.Tag.ToString() == Btn2.Tag.ToString() &&
                Btn1.Tag.ToString() == Btn3.Tag.ToString())
            {

                LP_Winner.Text = LP_NamePlayer.Text;
                LP_NamePlayer.Text = "Game Over";

                return true;
            }

            return false;
        }
        bool ChickWinner()
        {
            if (CheckValue(button1, button2, button3))
                return true;

            if (CheckValue(button4, button5, button6))
                return true;

            if (CheckValue(button7, button8, button9))
                return true;

            if (CheckValue(button1, button4, button7))
                return true;

            if (CheckValue(button2, button5, button8))
                return true;

            if (CheckValue(button3, button6, button9))
                return true;

            if (CheckValue(button1, button5, button9))
                return true;

            if (CheckValue(button3, button5, button7))
                return true;

            if (Counter == 9)
            {
                Random random = new Random();
                eBox Check = (eBox)random.Next(1, 9);

                switch (Check)
                {
                    case eBox.Box1:
                        {
                            ResetButton(button1);
                            ResetButton(button2);
                            ResetButton(button3);
                            break;
                        }

                    case eBox.Box2:
                        {
                            ResetButton(button4);
                            ResetButton(button5);
                            ResetButton(button6);
                            break;
                        }

                    case eBox.Box3:
                        {
                            ResetButton(button7);
                            ResetButton(button8);
                            ResetButton(button9);
                            break;
                        }

                    case eBox.Box4:
                        {
                            ResetButton(button1);
                            ResetButton(button4);
                            ResetButton(button7);
                            break;
                        }

                    case eBox.Box5:
                        {
                            ResetButton(button2);
                            ResetButton(button5);
                            ResetButton(button8);
                            break;
                        }

                    case eBox.Box6:
                        {
                            ResetButton(button3);
                            ResetButton(button6);
                            ResetButton(button9);
                            break;
                        }

                    case eBox.Box7:
                        {
                            ResetButton(button1);
                            ResetButton(button5);
                            ResetButton(button9);
                            break;
                        }

                    case eBox.Box8:
                        {
                            ResetButton(button3);
                            ResetButton(button5);
                            ResetButton(button7);
                            break;
                        }

                }
                Round++;
                Counter -= 3;

                if (Round > 1)
                    LB_Round.Text = Round.ToString();

            }

            return false;
        }
        void UpdateImage(Button Btn)
        {
            if (Btn.Tag.ToString() == "?")
            {
                if (LP_NamePlayer.Text == "Player 1")
                {
                    Btn.BackgroundImage = Properties.Resources.X;
                    BackgroundImageLayout = ImageLayout.Stretch;
                    Btn.Tag = "X";
                    Counter++;

                    if (ChickWinner())
                    {
                        string Message;

                        if (Round > 1)
                            Message = LP_Winner.Text + " Won after " + Round + " Round!";
                        else
                            Message = LP_Winner.Text + " Won in the First Round!";

                        MessageBox.Show(Message, "Game Over", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        groupBox1.Enabled = false;
                        return;
                    }

                    LP_NamePlayer.Text = "Player 2";
                    PB_Player.Image = Properties.Resources.b5528e213dc64f95226dd74e89a3e93f;


                    return;
                }
                else
                {
                    Btn.BackgroundImage = Properties.Resources.O;
                    BackgroundImageLayout = ImageLayout.Stretch;
                    Btn.Tag = "O";
                    Counter++;

                    if (ChickWinner())
                    {
                        string Message;

                        if (Round > 1)
                            Message = LP_Winner.Text + " Won after " + Round + " Round!";
                        else
                            Message = LP_Winner.Text + " Won in the First Round!";

                        MessageBox.Show(Message, "Game Over", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        groupBox1.Enabled = false;
                        return;
                    }

                    LP_NamePlayer.Text = "Player 1";
                    PB_Player.Image = Properties.Resources._1b8079b5a79671e7210211540b2e3705;

                    return;
                }
            }
            MessageBox.Show("Can't Choice");

        }


        private void button_Click(object sender, EventArgs e)
        {
            UpdateImage((Button)(sender));
        }

        void ResetButton(Button Btn)
        {
            Btn.BackgroundImage = Properties.Resources._929b9d9423e84d4e07edf17fd94d5c44;
            BackgroundImageLayout = ImageLayout.Stretch;
            Btn.Tag = "?";
        }

        private void BT_Restart_Click(object sender, EventArgs e)
        {
            if (LP_Winner.Text == "Player 1")
                LP_NamePlayer.Text = "Player 1";
            else
                LP_NamePlayer.Text = "Player 2";

            LP_Winner.Text = "In Progress";
            LB_Round.Text = "1";
            groupBox1.Enabled = true;
            Counter = 0;
            Round = 1;

            ResetButton(button1);
            ResetButton(button2);
            ResetButton(button3);
            ResetButton(button4);
            ResetButton(button5);
            ResetButton(button6);
            ResetButton(button7);
            ResetButton(button8);
            ResetButton(button9);

        }

        private void FrmGame_Load(object sender, EventArgs e)
        {
            Counter = 0;
            Round = 1;
        }
    }
}
