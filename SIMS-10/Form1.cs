using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SIMS_10
{
    public partial class Form1 : Form
    {
        Dice dice;
        GameController controller;
        public Form1()
        {
            InitializeComponent();            

            pointsLabel.Text = "На кубике: 0";
            playerLabel.Text = "Игрок: 0";
            aiLabel.Text = "Компьютер: 0";
            dice = new Dice();            
        }

        private void rollButton_Click(object sender, EventArgs e)
        {
            int value = dice.Roll();
            if (controller == null)
            {
                controller = new GameController(value);
                if (controller.isPlayer == false)
                {
                    gameLabel.Text = gameLabel.Text + "\nПервым ходит компьютер:";
                    rollButton.Enabled = false;
                    aiSteps();
                    Thread.Sleep(1000);
                    rollButton.Enabled = true;
                }
                else
                {
                    gameLabel.Text = gameLabel.Text + "\nПервым ходит игрок:";
                }                
            }
            else
            {

                if (controller.playerRolls < GameController.RollsCount)
                {
                    gameLabel.Text = gameLabel.Text + "\nХод игрока:" + value;

                    controller.playerRolls++;
                    if (value != 1)
                    {
                        controller.playerScore += value;                        
                    }
                    else
                    {
                        controller.aiScore += controller.playerScore;
                        controller.playerScore = 0;
                        controller.playerRolls = 0;
                        rollButton.Enabled = false;
                        aiSteps();
                        Thread.Sleep(1000);
                        rollButton.Enabled = true;
                    }
                    if (controller.playerScore >= 100)
                        StopGame("пользователь");
                    if (controller.aiScore >= 100)                    
                        StopGame("компьютер");                    
                }
                else if(controller.playerRolls == GameController.RollsCount)
                {
                    controller.playerRolls = 0;                    

                    rollButton.Enabled = false;
                    aiSteps();
                    Thread.Sleep(1000);
                    rollButton.Enabled = true;
                }
            }
            pointsLabel.Text = "На кубике: "+value.ToString();
            playerLabel.Text = "Игрок: "+controller.playerScore.ToString();
            aiLabel.Text = "Компьютер: "+controller.aiScore.ToString();
        }

        public void aiSteps()
        {
            int i = 0;
            while (i < GameController.RollsCount)
            {
                Thread.Sleep(1000);
                int value = controller.aiRoll;
                gameLabel.Text = gameLabel.Text + "\nХод компьютера:" + value;
                if (value != 1)
                {
                    controller.aiScore += value;
                    if (controller.aiScore >= 100)
                    {
                        StopGame("компьютер");
                        break;
                    }
                }
                else
                {
                    controller.playerScore += controller.aiScore;
                    controller.aiScore = 0;
                    i = GameController.RollsCount;
                    if (controller.playerScore >= 100)
                    {
                        StopGame("пользователь");
                        break;
                    }
                }
                i++;
                pointsLabel.Text = "На кубике: " + value.ToString();
                playerLabel.Text = "Игрок: " + controller.playerScore.ToString();
                aiLabel.Text = "Компьютер: " + controller.aiScore.ToString();
            }
        }

        public void StopGame(string winner)
        {
            rollButton.Enabled = false;
            MessageBox.Show("Победил "+ winner+"!");
            this.Close();
        }
    }
}
