/*
 * Program Name: Coin Flip
 * How to use: User can input the amount of coin flips they desire but from the range of 1 to 1000
 *             Then the program displays the consecutive heads and tails user roll this turn.
 *             The program will make a record.txt file to store scores if file have not already exist with the default value of 0s to start with.
 *             Then the program will check the high score for consecutive heads or tails.
 *             If the new consecutive is higher than the old consecutive the program will update the file with the new scores
 *             The program will also let user know if they set a new record or not.
 */

using System;
using System.IO;
using System.Windows.Forms;

namespace CoinFlip
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.FixedSingle; // Disallowing resize
            this.MaximizeBox = false; // Disallowing maximize
        }

        private void MakeFile(string filePath)
        {
            // Check if file exist, if not, then make file, else then skip
            if (!File.Exists(filePath))
            {
                using (StreamWriter writer = new StreamWriter(filePath))
                {
                    writer.WriteLine("0");
                    writer.WriteLine("0");
                }
            }
        }

        private void FlipButton_Click(object sender, EventArgs e)
        {
            // Value init
            int Head = 1;
            int Tail = 2;
            int HeadAmount = 0;
            int TailAmount = 0;
            int FlipCount;

            // Input validation making sure its a number between 1 to 1000
            try
            {
                FlipCount = int.Parse(FlipCountTextBox.Text);
            }
            catch
            {
                MessageBox.Show(this, "Amount of Flips must be a number!", "Error");
                return;
            }

            if (FlipCount < 1)
            {
                MessageBox.Show(this, "Amount of Flips Can not be lower than 1!", "Error");
                return;
            }
            if (FlipCount > 1000)
            {
                MessageBox.Show(this, "Amount of Flips Can not be over 1000!", "Error");
                return;
            }

            // Random number generator, that generates 1 or 2
            Random random = new Random();

            for (int i = 0; i < FlipCount; i++) 
            {
                int randomNumber = random.Next(1, 3);
                if (randomNumber == Head) 
                {
                    HeadAmount++;
                } else if (randomNumber == Tail)
                {
                    TailAmount++;
                }
            }

            // Set label text to current scores
            HighestHeadLabel.Text = "Number of Consecutive Heads: " + HeadAmount;
            HighestTailsLabel.Text = "Number of Consecutive Tails: " + TailAmount;

            // Define file path for the file to store the scores
            string filePath = "record.txt";

            MakeFile(filePath);

            // Read all likes from record.txt
            string[] lines = File.ReadAllLines(filePath);

            int line1 = int.Parse(lines[0]); // Line1 for head
            int line2 = int.Parse(lines[1]); // Line2 for tail

            // Check if new score is higher than old scorefor heads, if is, then update old high score to the new one
            if (line1 < HeadAmount)
            {
                NewHeadRecordLabel.Text = "You set a new record for consecutive heads: " + HeadAmount;
                OldHeadRecordLabel.Text = "The record for consecutive heads was: " + line1;
                lines[0] = HeadAmount.ToString();
                File.WriteAllLines(filePath, lines);
            } else
            {
                NewHeadRecordLabel.Text = "You did not set a new record for consecutive heads: " + HeadAmount;
                OldHeadRecordLabel.Text = "The orecord for consecutive heads was: " + line1;
            }

            // Check if new score is higher than old score for tails, if is, then update old high score to the new one
            if (line2 < TailAmount)
            {
                NewTailRecordLabel.Text = "You set a new record for consecutive tails: " + TailAmount;
                OldTailRecordLabel.Text = "The old record for consecutive tails was: " + line2;
                lines[1] = TailAmount.ToString();
                File.WriteAllLines(filePath, lines);
            } else
            {
                NewTailRecordLabel.Text = "You did not set a new record for consecutive tails: " + TailAmount;
                OldTailRecordLabel.Text = "The old record for consecutive tails was: " + line2;
            }
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
