using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;


namespace WindowsFormsApp3
{
    public partial class Form1 : Form
    {
        
        int velocy = 0;
        int ball_right_movement =0;
        bool onFloor = false;
        int bounce = 5;
        int timeGame = 60;
       

        /////////Goals/////////
        int HeinemannGoals;
        int UriahGoals;
        int Kogosgoals;
        int BoginGoals;


        //////specials//////
       bool uriahAbilityBool1 = false;
        bool uriahAbilityBool2 = false;
        bool boginsAbilityPlayer1 = false;
        bool boginsabilityPlayer2 = false;
        bool heinemannAbilityplayer1 = false;
        bool heinemannAbilityplayer2 = false;
        bool shimshonAbilityplayer1 = false;
        bool shimshonAbilityplayer2 = false;
        bool trigoInSpace1 = false;
        bool trigoInSpace2 = false;
        bool player2Right12 = false;
        bool playerDown = false;
        bool playerLeft12 = false;


        //////player1///////

        bool playerLeft = false;
        bool playerRight = false;
        int player1_score = 0;
        bool playerOnFloor = true;
        int player_velocy = 0;
        int player1Energy = 0;
        bool player1IsUriah = false;
        bool player1ISHeinemann = false;
        bool player1IsKogos = false;
        bool player1IsBogin = false;
        bool player1IsShimshon = false;
        bool player1IsYair = false;
        bool player1IShani = false;
        bool player1isShaked = false;
        int playerMovementSpeed = 4;

        //////player2//////

        bool player2Left = false;
        bool player2Right = false;
        int player2_score = 0;
        bool player2OnFloor = true;
        int player2_velocy = 0;
        int player2Energy = 0;
        int player2MovementSpeed = 4;
       

        bool player2IsUriah = false;
        bool player2ISHeinemann = false;
        bool player2IsKogos = false;
        bool player2IsShaked = false; 
        bool player2IsBogin = false;
        bool player2IsShimshon = false;
        bool player2IsYair = false;
        bool player2IsShani = false;
        bool player2down = false;


        public Form1()
        {
           


            Form2 Check = new Form2();
            Check.Show();
            Hide();

            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

            timeLabel.Text = "Time: " + timeGame;
            //////////spcials/////////


            if (uriahAbilityBool1)
            {
                ball.Location = player2.Location;
            }

            if (uriahAbilityBool2)
            {
                ball.Location = player.Location;
            }

            ////////////bogins ability///////////

            if (boginsAbilityPlayer1 && boginAbility.Enabled == true)
            {
                label1.Visible = true;
                player2MovementSpeed = 0;
                label1.Text = "אחות של בוגין";
                

            }
            if (!(boginsAbilityPlayer1) && player1IsBogin)
            {
                label1.Visible = false;
                player2MovementSpeed = 4;

            }


            if (boginsabilityPlayer2 && boginAbility.Enabled == true)
            {
                label1.Visible = true;
                playerMovementSpeed = 0;
                label1.Text = "אחות של בוגין";


            }
            if (!(boginsabilityPlayer2) && player2IsBogin)
            {
                label1.Visible = false;
                playerMovementSpeed = 4;

            }


            ///////Heinmann ability///////
            if (heinemannAbilityplayer1 && player1ISHeinemann)
            {
                player2MovementSpeed = -4;
            }
            if (heinemannAbilityplayer2 && player2ISHeinemann)
            {
                playerMovementSpeed = -4;
            }


            ///////////Shimshon ability////////

            if (shimshonAbilityplayer1 && Time.Enabled == true)
            {
                label1.Visible = true;

                player2MovementSpeed = 0;

                trigoInSpace1 = true;


                label1.Text = "טריגונומטריה במרחב";


            }
            if (!(shimshonAbilityplayer1) && player1IsShimshon)
            {
                label1.Visible = false;
                player2MovementSpeed = 4;

            }
            if (player2Right12)
            {
                player2.Left += 3;
            }

            if (playerLeft12)
            {
                player.Left -= 3;
            }

            if (trigoInSpace1)
            {
                bool player2up;
               
                if (player2.Top >100)
                {
                    player2up = true;   
                }
                else
                {
                    player2up = false;
                    player2Right12 = true;

                    
                }
                if (player2.Left + player2.Width >= pictureBox2.Left)
                {
                    player2Right12 = false;
                    player2up = false;
                    player2down = true;
                    
                }
                

                if (player2up)
                {
                    player2.Top -= 3;
                }
                if (player2down)
                {
                    player2.Top += 3;
                    if (player2.Top + player2.Height >= Ground.Top)
                    {
                        trigoInSpace1 = false;
                        shimshonAbilityplayer1 = false;
                        player2up = false;
                        player2down = false;
                        player2Right12 = false;
                    }
                }
               
            }

            /////////player 2///////////

            if (shimshonAbilityplayer2 && Time.Enabled == true)
            {
                label1.Visible = true;

                playerMovementSpeed = 0;

                trigoInSpace2 = true;


                label1.Text = "טריגונומטריה במרחב";


            }
            if (!(shimshonAbilityplayer2) && player2IsShimshon)
            {
                label1.Visible = false;
                playerMovementSpeed = 4;

            }

            if (trigoInSpace2)
            {
                bool playerup;

                
                if (player.Top > 100)
                {
                    playerup = true;
                }
                else
                {
                    playerup = false;
                    playerLeft12 = true;


                }
                if (player.Left  <= pictureBox1.Left + pictureBox1.Width)
                {
                    playerLeft12 = false;
                    playerup = false;
                    playerDown = true;

                }

                if (playerup)
                {
                    player.Top -= 3;
                }



                if (playerDown)
                {
                    player.Top += 3;
                    if (player.Top + player.Height >= Ground.Top)
                    {
                        trigoInSpace2 = false;
                        shimshonAbilityplayer2 = false;
                        playerup = false;
                        playerDown = false;
                        playerLeft12 = false;
                    }
                }

            }



            ////////////energy/////////////



            player1_energy.Value = player1Energy;
            player2_energy.Value = player2Energy;

            if (player1Energy == 100)
            {
                EnergylPLayer.Visible = true;
            }
            else
            {
                EnergylPLayer.Visible = false;
            }

            if (player2Energy == 100)
            {
                energylPLayer2.Visible = true;
            }
            else
            {
                energylPLayer2.Visible = false;
            }


            p1Score_label.Text = "Score: " + player1_score;
            p2score_label.Text = "Score: " + player2_score;

            /////////winning///////////

            if (ball.Bounds.IntersectsWith(goalPC.Bounds) && (!(uriahAbilityBool2)))
            {
                if (ball.Top + ball.Height == goalPlayer.Top)
                {
                    ball.Top -= 5;
                    velocy = -velocy;
                }
                else
                {

                    wingPlayer1();
                }
                
            }

            if (ball.Bounds.IntersectsWith(goalPlayer.Bounds) && (!(uriahAbilityBool1)))
            {
                if (ball.Top + ball.Height == goalPC.Top)
                {
                    ball.Top -= 5;
                    velocy = -velocy;
                }
                else
                {
                    wingplayer2();
                }
               
            }

            ////////////////player movement///////////////

            if (player.Left < 0)
            {
                playerLeft = false;
            }
            if (player.Left > Width)
            {
                playerRight = false;
            }

            if (playerLeft)
            {
                player.Left -= playerMovementSpeed;

            }
            if (playerRight)
            {
                player.Left += playerMovementSpeed;
            }


            ////////////////player 2 movement//////

            if (player2.Left < 0)
            {
                player2Left = false;
            }
            if (player2.Left > Width)
            {
                player2Right = false;
            }

            if (player2Left)
            {
                player2.Left -= player2MovementSpeed;
            }
            if (player2Right)
            {
                player2.Left += player2MovementSpeed;

            }


       ////////////////ball jumping gravity/////////////

            if (onFloor == false)
            {
                ball.Top += velocy;
            }


           


            if (ball.Bounds.IntersectsWith(Ground.Bounds))
            {

             
                    velocy = -velocy;
                   
                    ball.Top -= 1;
                velocy++;               
                
                if (velocy == 0)
                {
                    onFloor = true;
                }

               
            }

            if (ball.Top < 0)
            {
                velocy = 5;

            }

            

            /////////////player jumping gravity//////////////

            if (!(playerOnFloor))
            {
                player.Top += player_velocy;
            }
            if (player.Bounds.IntersectsWith(Ground.Bounds))
            {
                playerOnFloor = true;
                //player_velocy = 0;
            }

            //////////////player 2 jumping////////////

            if (!(player2OnFloor))
            {
                player2.Top += player2_velocy;
            }
            if (player2.Bounds.IntersectsWith(Ground.Bounds))
            {
                player2OnFloor = true;
                //player_velocy = 0;
            }

            //////////////ball impact with player 1//////////////

            ball.Left += ball_right_movement;

            if (ball.Bounds.IntersectsWith(player.Bounds))
            {
                if ((ball.Left + 25) <= (player.Left + 25) )
                {
                    ball_right_movement = -8;
                    velocy -= 5;
                    onFloor = false;
                }


                if ((ball.Left) >= (player.Left + 25))
                {
                    ball_right_movement = 8;
                    velocy -= 5;
                    onFloor = false;
                }






            }

            //////////////////ball impact with player 2///////////

            if (ball.Bounds.IntersectsWith(player2.Bounds))
            {
                if ((ball.Left + 25) <= (player2.Left + 25))
                {
                    ball_right_movement = -8;
                    velocy -= 5;
                    onFloor = false;
                }


                if ((ball.Left) >= (player2.Left + 25))
                {
                    ball_right_movement = 8;
                    velocy -= 5;
                    onFloor = false;
                }






            }


            if (ball.Bounds.IntersectsWith(crossbar1.Bounds))
            {
                velocy = -velocy;
                ball.Top -= 1;
                ball_right_movement = 8;
                

            }


            if (ball.Bounds.IntersectsWith(crossbar2.Bounds))
            {
                velocy = -velocy;
                ball.Top -= 1;
                ball_right_movement = -8;
            }


            if (ball.Left < 0)
            {
                ball_right_movement += 5;
            }
            if (ball.Left > Width)
            {
                ball_right_movement -= 5;
            }


            //if ((ball.Left >= player.Left) && ((ball.Left + ball.Width) <= (player.Left + player.Width)))
            //{
              //  if (ball.Top + ball.Height == player.Top)
                //{
                 //   velocy = -velocy;
               // }
           // }
        }

        private void gravity_Tick(object sender, EventArgs e)
        {
            velocy++;
            player_velocy++;
            player2_velocy++;

            ///energy///
            if (player1Energy < 100)
            {
                player1Energy++;
            }
            if (player2Energy < 100)
            {
                player2Energy++;
            }

          
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Left: playerLeft = true;
                    break;
                    
                case Keys.Right: playerRight = true;
                    break;
                case Keys.Enter: timer1.Enabled = true;
                    ball.Top = 200;
                    bounce = 5;
                    ball.Left = 100;
                    break;
                case Keys.A: player2Left = true;
                    break;
                case Keys.D: player2Right = true;
                    break;


                    
            }

            

            if (e.KeyCode == Keys.Enter)
            {
                int player1pic = Form2.player1Pic;
                int player2pic = Form2.player2Pic;
                Time.Enabled = true;

                if (player1pic==1)
                {
                    player2.Image = Properties.Resources.heineman_logo;
                    player2ISHeinemann = true;
                }
                if (player1pic == 2)
                {
                    player2.Image = Properties.Resources.uriahLogo1;
                    player2IsUriah = true;
                }
                if (player1pic == 3)
                {
                    player2.Image = Properties.Resources.KogosLogo;
                    player2IsKogos = true;
                }
                if (player1pic == 4)
                {
                    player2.Image = Properties.Resources.boginLogo;
                    player2IsBogin = true;
                }
                if (player1pic == 5)
                {
                    player2.Image = Properties.Resources.shimsoniLogo;
                    player2IsShimshon = true;
                }
                if (player1pic == 6)
                {
                    player2.Image = Properties.Resources.Screenshot_2017_12_04_12_13_15_1;
                    player2IsYair = true;
                }

                if (player1pic == 7)
                {
                    player2.Image = Properties.Resources.ShaniLogo;
                    player2IsShani = true;
                }

                if (player2pic == 1)
                {
                    player.Image = Properties.Resources.heineman_logo;
                    player1ISHeinemann = true;
                }
                if (player2pic == 2)
                {
                    player.Image = Properties.Resources.uriahLogo1;
                    player1IsUriah = true;
                }
                if (player2pic == 3)
                {
                    player.Image = Properties.Resources.KogosLogo;
                    player1IsKogos = true;
                }
                if (player2pic == 4)
                {
                    player.Image = Properties.Resources.boginLogo;
                    player1IsBogin = true;
                }

                if (player2pic == 5)
                {
                    player.Image = Properties.Resources.shimsoniLogo;
                    player1IsShimshon = true;
                }
                if (player2pic == 6)
                {
                    player.Image = Properties.Resources.Screenshot_2017_12_04_12_13_15_1;
                    player1IsYair = true;
                }
                if (player2pic == 7)
                {
                    player.Image = Properties.Resources.ShaniLogo;
                    player1IShani = true;
                }

                timer1.Enabled = true;
                timer2.Enabled = true;
                gravity.Enabled = true;
                player.Visible = true;
                player2.Visible = true;
                label1.Visible = false;

            }

            ///////////////close + Write goals//////////////

            if (e.KeyCode == Keys.Escape)
            {

             //heinaman//

                if (player1ISHeinemann)
                {
                    string HGoals = (player1_score + Form2.heinmaennGoalsF2).ToString();
                    string Wins;
                    int gamesPlayed = (Form2.HeinemannGamesPlayed)+1;

                    if (player1_score > player2_score)
                    {
                         Wins = (Form2.HeinemamaWins+1).ToString();
                    }
                    else
                    {
                         Wins = (Form2.HeinemamaWins).ToString();
                    }
                   

                    if (File.Exists(@"C:\Users\yuval\Desktop\My game C#\HighScores\highScoreHeinemann"))
                    {
                        File.Delete(@"C:\Users\yuval\Desktop\My game C#\HighScores\highScoreHeinemann");
                    }
                    
                    System.IO.File.WriteAllText(@"C:\Users\yuval\Desktop\My game C#\HighScores\highScoreHeinemann", HGoals);

                    if (File.Exists(@"C:\Users\yuval\Desktop\My game C#\HighScores\GamesPlayed\GamesPlayedHeinemann"))
                    {
                        File.Delete(@"C:\Users\yuval\Desktop\My game C#\HighScores\highScoreHeinemann");
                    }

                    System.IO.File.WriteAllText(@"C:\Users\yuval\Desktop\My game C#\HighScores\\GamesPlayed\GamesPlayedHeinemann", gamesPlayed.ToString());

                    /////wins/////

                    if (File.Exists(@"C:\Users\yuval\Desktop\My game C#\HighScores\Wins\HeinemannWins"))
                    {
                        File.Delete(@"C:\Users\yuval\Desktop\My game C#\HighScores\Wins\HeinemannWins");
                    }

                    System.IO.File.WriteAllText(@"C:\Users\yuval\Desktop\My game C#\HighScores\Wins\HeinemannWins", Wins);
                }

                if (player2ISHeinemann)
                {

                    string HGoals = (player2_score + Form2.heinmaennGoalsF2).ToString();
                    int gamesPlayed = (Form2.HeinemannGamesPlayed)+1;
                    string wins;

                    if (player2_score > player1_score)
                    {
                        wins = ((Form2.HeinemamaWins) + 1).ToString();
                    }
                    else
                    {
                        wins = Form2.HeinemamaWins.ToString();
                    }

                    if (File.Exists(@"C:\Users\yuval\Desktop\My game C#\HighScores\highScoreHeinemann"))
                    {
                        File.Delete(@"C:\Users\yuval\Desktop\My game C#\HighScores\highScoreHeinemann");
                    }

                    System.IO.File.WriteAllText(@"C:\Users\yuval\Desktop\My game C#\HighScores\highScoreHeinemann", HGoals);

                    if (File.Exists(@"C:\Users\yuval\Desktop\My game C#\HighScores\GamesPlayed\GamesPlayedHeinemann"))
                    {
                        File.Delete(@"C:\Users\yuval\Desktop\My game C#\HighScores\GamesPlayed\GamesPlayedHeinemann");
                    }

                    System.IO.File.WriteAllText(@"C:\Users\yuval\Desktop\My game C#\HighScores\\GamesPlayed\GamesPlayedHeinemann", gamesPlayed.ToString());
                  
                    /////wins/////

                    if (File.Exists(@"C:\Users\yuval\Desktop\My game C#\HighScores\Wins\HeinemannWins"))
                    {
                        File.Delete(@"C:\Users\yuval\Desktop\My game C#\HighScores\Wins\HeinemannWins");
                    }

                    System.IO.File.WriteAllText(@"C:\Users\yuval\Desktop\My game C#\HighScores\Wins\HeinemannWins", wins);



                }

                //bogin//

                if (player1IsBogin)
                {
                    string BGoals  = (player1_score + Form2.boginGoalsF2).ToString();
                    int gamesPlayed = (Form2.BoginGamesPlayed)+1;
                    string wins;

                    if (player1_score > player2_score)
                    {
                        wins = ((Form2.BoginaWins) + 1).ToString();
                    }
                    else
                    {
                        wins = (Form2.BoginaWins).ToString();
                    }

                    if (File.Exists(@"C:\Users\yuval\Desktop\My game C#\HighScores\highScoreBogin"))
                    {
                        File.Delete((@"C:\Users\yuval\Desktop\My game C#\HighScores\highScoreBogin"));
                    }

                    System.IO.File.WriteAllText(@"C:\Users\yuval\Desktop\My game C#\HighScores\highScoreBogin", BGoals);

                    //games played//
                    if (File.Exists(@"C:\Users\yuval\Desktop\My game C#\HighScores\GamesPlayed\GamesPlayedBogin"))
                    {
                        File.Delete(@"C:\Users\yuval\Desktop\My game C#\HighScores\GamesPlayed\GamesPlayedBogin");
                    }

                    System.IO.File.WriteAllText(@"C:\Users\yuval\Desktop\My game C#\HighScores\\GamesPlayed\GamesPlayedBogin", gamesPlayed.ToString());

                    /////wins/////

                    if (File.Exists(@"C:\Users\yuval\Desktop\My game C#\HighScores\Wins\BoginWins"))
                    {
                        File.Delete(@"C:\Users\yuval\Desktop\My game C#\HighScores\Wins\BoginWins");
                    }

                    System.IO.File.WriteAllText(@"C:\Users\yuval\Desktop\My game C#\HighScores\Wins\BoginWins", wins);


                }

                if (player2IsBogin)
                {
                    string BGoals = (player2_score + Form2.boginGoalsF2).ToString();
                    int gamesPlayed = (Form2.BoginGamesPlayed)+1;
                    string wins;

                    if (player2_score > player1_score)
                    {
                        wins = ((Form2.BoginaWins) + 1).ToString();
                    }
                    else
                    {
                        wins = (Form2.BoginaWins).ToString();
                    }


                    if (File.Exists(@"C:\Users\yuval\Desktop\My game C#\HighScores\highScoreBogin"))
                    {
                        File.Delete((@"C:\Users\yuval\Desktop\My game C#\HighScores\highScoreBogin"));
                    }

                    System.IO.File.WriteAllText(@"C:\Users\yuval\Desktop\My game C#\HighScores\highScoreBogin", BGoals);

                    //games played//
                    if (File.Exists(@"C:\Users\yuval\Desktop\My game C#\HighScores\GamesPlayed\GamesPlayedBogin"))
                    {
                        File.Delete(@"C:\Users\yuval\Desktop\My game C#\HighScores\GamesPlayed\GamesPlayedBogin");
                    }

                    System.IO.File.WriteAllText(@"C:\Users\yuval\Desktop\My game C#\HighScores\\GamesPlayed\GamesPlayedBogin", gamesPlayed.ToString());


                    /////wins/////

                    if (File.Exists(@"C:\Users\yuval\Desktop\My game C#\HighScores\Wins\BoginWins"))
                    {
                        File.Delete(@"C:\Users\yuval\Desktop\My game C#\HighScores\Wins\BoginWins");
                    }

                    System.IO.File.WriteAllText(@"C:\Users\yuval\Desktop\My game C#\HighScores\Wins\BoginWins", wins);


                }

                //kogos//

                if (player1IsKogos)
                {
                    string KGoals = (player1_score + Form2.kogosGoalsF2).ToString();
                    int gamesPlayed = (Form2.KogosGamesPlayed)+1;
                    string wins;

                    if (player1_score > player2_score)
                    {
                        wins = ((Form2.KogosWins) + 1).ToString();
                    }
                    else
                    {
                        wins = (Form2.KogosWins).ToString();
                    }

                    if (File.Exists(@"C:\Users\yuval\Desktop\My game C#\HighScores\highScoreKogos"))
                    {
                        File.Delete(@"C:\Users\yuval\Desktop\My game C#\HighScores\highScoreKogos");
                    }

                    System.IO.File.WriteAllText(@"C:\Users\yuval\Desktop\My game C#\HighScores\highScoreKogos", KGoals);

                    //games played//
                    if (File.Exists(@"C:\Users\yuval\Desktop\My game C#\HighScores\GamesPlayed\GamesPlayedKogos"))
                    {
                        File.Delete(@"C:\Users\yuval\Desktop\My game C#\HighScores\GamesPlayed\GamesPlayedKogos");
                    }

                    System.IO.File.WriteAllText(@"C:\Users\yuval\Desktop\My game C#\HighScores\\GamesPlayed\GamesPlayedKogos", gamesPlayed.ToString());

                    //wins//

                    if (File.Exists(@"C:\Users\yuval\Desktop\My game C#\HighScores\Wins\KogosWins"))
                    {
                        File.Delete(@"C:\Users\yuval\Desktop\My game C#\HighScores\Wins\KogosWins");
                    }

                    System.IO.File.WriteAllText(@"C:\Users\yuval\Desktop\My game C#\HighScores\Wins\KogosWins", wins);

                }
                if (player2IsKogos)
                {
                    string KGoals = (player2_score + Form2.kogosGoalsF2).ToString();
                    int gamesPlayed = (Form2.KogosGamesPlayed)+1;
                    string wins;

                    if (player2_score > player1_score)
                    {
                        wins = ((Form2.KogosWins) + 1).ToString();
                    }
                    else
                    {
                        wins = (Form2.KogosWins).ToString();
                    }


                    if (File.Exists(@"C:\Users\yuval\Desktop\My game C#\HighScores\highScoreKogos"))
                    {
                        File.Delete(@"C:\Users\yuval\Desktop\My game C#\HighScores\highScoreKogos");
                    }

                    System.IO.File.WriteAllText(@"C:\Users\yuval\Desktop\My game C#\HighScores\highScoreKogos", KGoals);

                    //games played//
                    if (File.Exists(@"C:\Users\yuval\Desktop\My game C#\HighScores\GamesPlayed\GamesPlayedKogos"))
                    {
                        File.Delete(@"C:\Users\yuval\Desktop\My game C#\HighScores\GamesPlayed\GamesPlayedKogos");
                    }

                    System.IO.File.WriteAllText(@"C:\Users\yuval\Desktop\My game C#\HighScores\\GamesPlayed\GamesPlayedKogos", gamesPlayed.ToString());

                    //wins//

                    if (File.Exists(@"C:\Users\yuval\Desktop\My game C#\HighScores\Wins\KogosWins"))
                    {
                        File.Delete(@"C:\Users\yuval\Desktop\My game C#\HighScores\Wins\KogosWins");
                    }

                    System.IO.File.WriteAllText(@"C:\Users\yuval\Desktop\My game C#\HighScores\Wins\KogosWins", wins);

                }

                //uriah//

                if (player1IsUriah)
                {


                    string UGoals = (player1_score + Form2.uriahGoalsF2).ToString();
                    int gamesPlayed = (Form2.UriahGamesPlayed)+1;
                    string wins;

                    if (player1_score > player2_score)
                    {
                        wins = ((Form2.UriahWins) + 1).ToString();
                    }
                    else
                    {
                        wins = (Form2.UriahWins).ToString();
                    }


                    if (File.Exists(@"C:\Users\yuval\Desktop\My game C#\HighScores\highScoreUriah"))
                    {
                        File.Delete(@"C:\Users\yuval\Desktop\My game C#\HighScores\highScoreUriah");
                    }

                    System.IO.File.WriteAllText(@"C:\Users\yuval\Desktop\My game C#\HighScores\highScoreUriah", UGoals);

                    //games played//
                    if (File.Exists(@"C:\Users\yuval\Desktop\My game C#\HighScores\GamesPlayed\GamesPlayedUriah"))
                    {
                        File.Delete(@"C:\Users\yuval\Desktop\My game C#\HighScores\GamesPlayed\GamesPlayedUriah");
                    }

                    System.IO.File.WriteAllText(@"C:\Users\yuval\Desktop\My game C#\HighScores\\GamesPlayed\GamesPlayedUriah", gamesPlayed.ToString());

                    //wins//

                    if (File.Exists(@"C:\Users\yuval\Desktop\My game C#\HighScores\Wins\UriahWins"))
                    {
                        File.Delete(@"C:\Users\yuval\Desktop\My game C#\HighScores\Wins\UriahWins");
                    }

                    System.IO.File.WriteAllText(@"C:\Users\yuval\Desktop\My game C#\HighScores\Wins\UriahWins", wins);



                }
                if (player2IsUriah)
                {
                    string UGoals = (player2_score + Form2.uriahGoalsF2).ToString();
                    int gamesPlayed = (Form2.UriahGamesPlayed) + 1;
                    string wins;

                    if (player2_score > player1_score)
                    {
                        wins = ((Form2.UriahWins) + 1).ToString();
                    }
                    else
                    {
                        wins = (Form2.UriahWins).ToString();
                    }

                    if (File.Exists(@"C:\Users\yuval\Desktop\My game C#\HighScores\highScoreUriah"))
                    {
                        File.Delete(@"C:\Users\yuval\Desktop\My game C#\HighScores\highScoreUriah");
                    }

                    System.IO.File.WriteAllText(@"C:\Users\yuval\Desktop\My game C#\HighScores\highScoreUriah", UGoals);

                    //games played//

                    if (File.Exists(@"C:\Users\yuval\Desktop\My game C#\HighScores\GamesPlayed\GamesPlayedUriah"))
                    {
                        File.Delete(@"C:\Users\yuval\Desktop\My game C#\HighScores\GamesPlayed\GamesPlayedUriah");
                    }

                    System.IO.File.WriteAllText(@"C:\Users\yuval\Desktop\My game C#\HighScores\\GamesPlayed\GamesPlayedUriah", gamesPlayed.ToString());

                    //wins//

                    if (File.Exists(@"C:\Users\yuval\Desktop\My game C#\HighScores\Wins\UriahWins"))
                    {
                        File.Delete(@"C:\Users\yuval\Desktop\My game C#\HighScores\Wins\UriahWins");
                    }

                    System.IO.File.WriteAllText(@"C:\Users\yuval\Desktop\My game C#\HighScores\Wins\UriahWins", wins);

                }

                /////shimshon/////
                if (player1IsShimshon)
                {
                    string SGoals = (player1_score + Form2.shimshonGoalsF2).ToString();
                    int gamesPlayed = (Form2.ShimshonGamesPlayed) + 1;
                    string wins;

                    if (player1_score > player2_score)
                    {
                        wins = ((Form2.ShimShonWins) + 1).ToString();
                    }
                    else
                    {
                        wins = (Form2.ShimShonWins).ToString();
                    }

                    if (File.Exists(@"C:\Users\yuval\Desktop\My game C#\HighScores\highScoreShimshon"))
                    {
                        File.Delete(@"C:\Users\yuval\Desktop\My game C#\HighScores\highScoreShimshon");
                       
                    }

                    System.IO.File.WriteAllText(@"C:\Users\yuval\Desktop\My game C#\HighScores\highScoreShimshon", SGoals);


                    //games played//

                    if (File.Exists(@"C:\Users\yuval\Desktop\My game C#\HighScores\GamesPlayed\GamesPlayedShimshon"))
                    {
                        File.Delete(@"C:\Users\yuval\Desktop\My game C#\HighScores\GamesPlayed\GamesPlayedShimshon");
                    }

                    System.IO.File.WriteAllText(@"C:\Users\yuval\Desktop\My game C#\HighScores\\GamesPlayed\GamesPlayedShimshon", gamesPlayed.ToString());
                   
                    //wins//

                    if (File.Exists(@"C:\Users\yuval\Desktop\My game C#\HighScores\Wins\SimshonWins"))
                    {
                        File.Delete(@"C:\Users\yuval\Desktop\My game C#\HighScores\Wins\SimshonWins");
                    }

                    System.IO.File.WriteAllText(@"C:\Users\yuval\Desktop\My game C#\HighScores\Wins\SimshonWins", wins);


                }

                if (player2IsShimshon)
                {
                    string SGoals = (player2_score + Form2.shimshonGoalsF2).ToString();
                    int gamesPlayed = (Form2.ShimshonGamesPlayed) + 1;
                    string wins;

                    if (player2_score > player1_score)
                    {
                        wins = ((Form2.ShimShonWins) + 1).ToString();
                    }
                    else
                    {
                        wins = (Form2.ShimShonWins).ToString();
                    }
                    if (File.Exists(@"C:\Users\yuval\Desktop\My game C#\HighScores\highScoreShimshon"))
                    {
                        File.Delete(@"C:\Users\yuval\Desktop\My game C#\HighScores\highScoreShimshon");
                    }

                    System.IO.File.WriteAllText(@"C:\Users\yuval\Desktop\My game C#\HighScores\highScoreShimshon", SGoals);


                    //games played//

                    if (File.Exists(@"C:\Users\yuval\Desktop\My game C#\HighScores\GamesPlayed\GamesPlayedShimshon"))
                    {
                        File.Delete(@"C:\Users\yuval\Desktop\My game C#\HighScores\GamesPlayed\GamesPlayedShimshon");
                    }

                    System.IO.File.WriteAllText(@"C:\Users\yuval\Desktop\My game C#\HighScores\\GamesPlayed\GamesPlayedShimshon", gamesPlayed.ToString());

                    //wins//

                    if (File.Exists(@"C:\Users\yuval\Desktop\My game C#\HighScores\Wins\SimshonWins"))
                    {
                        File.Delete(@"C:\Users\yuval\Desktop\My game C#\HighScores\Wins\SimshonWins");
                    }

                    System.IO.File.WriteAllText(@"C:\Users\yuval\Desktop\My game C#\HighScores\Wins\SimshonWins", wins);



                }



                this.Close();
            }


            ///////////special abilities player1///////////

            if (e.KeyCode == Keys.Space && player1IsUriah && player1Energy == 100)
            {

                uriahAbilityBool2 = true;
                uriahAbility.Enabled = true;
                player1Energy = 0;

            }

            if (e.KeyCode == Keys.Space && player1IsBogin && player1Energy == 100)
            {

                boginsAbilityPlayer1 = true;
                boginAbility.Enabled = true;
                player1Energy = 0;

            }

            if (e.KeyCode == Keys.Space && player1ISHeinemann && player1Energy == 100)
            {

                heinemannAbilityplayer1 = true;
                HeinmannAbility.Enabled = true;
                player1Energy = 0;

            }

            if (e.KeyCode == Keys.Space && player1IsShimshon && player1Energy == 100)
            {

                shimshonAbilityplayer1 = true;
                Time.Enabled = true;
                player1Energy = 0;

            }

            /////////special abilities player2/////////

            if (e.KeyCode == Keys.E && player2IsUriah && player2Energy == 100)
            {
                
                uriahAbilityBool1 = true;
                uriahAbility.Enabled = true;
                player2Energy = 0;

            }


            if (e.KeyCode == Keys.E && player2IsBogin && player2Energy == 100)
            {

                boginsabilityPlayer2 = true;
                boginAbility.Enabled = true;
                player2Energy = 0;

            }

            if (e.KeyCode == Keys.E && player2ISHeinemann && player2Energy == 100)
            {

                heinemannAbilityplayer2 = true;
                HeinmannAbility.Enabled = true;
                player2Energy = 0;

            }

            if (e.KeyCode == Keys.E && player2IsShimshon && player2Energy == 100)
            {

                shimshonAbilityplayer2 = true;
                Time.Enabled = true;
                player1Energy = 0;

            }

            if (e.KeyCode == Keys.Up && playerOnFloor)
            {
                player_velocy = -5;
                playerOnFloor = false;
                player.Top -= 5;
            }

            if (e.KeyCode == Keys.W && player2OnFloor)
            {
                player2_velocy = -5;
                player2OnFloor = false;
                player2.Top -= 5;
            }
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Left:
                    playerLeft = false;
                    break;
                case Keys.Right:
                    playerRight = false;
                    break;
                case Keys.A:
                    player2Left = false;
                    break;
                case Keys.D:
                    player2Right = false;
                    break;


            }

           
        }

        private void wingPlayer1()
        {
            ball.Top =50;
            ball.Left = 400;

            player1_score += 1;
        
        }

        private void wingplayer2()
        {
            ball.Top = 50;
            ball.Left = 400;

            player2_score += 1;
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            if (ball_right_movement < 0)
            {
                ball_right_movement++;
            }
            if (ball_right_movement > 0)
            {
                ball_right_movement--;
            }
        }

        private void p1Score_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void uriahAbility_Tick(object sender, EventArgs e)
        {
            uriahAbilityBool1 = false;

            uriahAbilityBool2 = false;
       
            uriahAbility.Enabled = false;
        }

        private void boginAbility_Tick(object sender, EventArgs e)
        {
            boginsAbilityPlayer1 = false;
            boginsabilityPlayer2 = false;
            boginAbility.Enabled = false;
        }

        private void crossbar1_Click(object sender, EventArgs e)
        {

        }

        private void HeinmannAbility_Tick(object sender, EventArgs e)
        {
            if (heinemannAbilityplayer1)
            {
                heinemannAbilityplayer1 = false;
                player2MovementSpeed = 4;
            }
            if (heinemannAbilityplayer2)
            {
                heinemannAbilityplayer2 = false;
                playerMovementSpeed = 4;
            }
            
            HeinmannAbility.Enabled = false;
            
        }

        private void spinningBall_Tick(object sender, EventArgs e)
        {
          
        }

        private void Time_Tick(object sender, EventArgs e)
        {
            if (timeGame >= 0)
            {
                timeGame--;
            }
            
            if (timeGame == 0)
            {
                label1.Visible = true;
                timeLabel.Visible = false;

                if (player1_score > player2_score)
                {
                    label1.Visible = true;
                    if (player1IsBogin)
                    {

                        label1.Text = "Bogina won!!! Press Escape to exit and save";
                    }
                    if (player1ISHeinemann)
                    {
                        label1.Text = "Heinemama won!!! Press Escape to exit and save";
                    }
                    if (player1IsUriah)
                    {
                        label1.Text = "Urititz won!!! Press Escape to exit and save";
                    }
                    if (player1IsKogos)
                    {
                        label1.Text = "Kogoson won!!! Press Escape to exit and save";
                    }
                    if (player1IsShimshon)
                    {
                        label1.Text = "Shimshon won!!! Press Escape to exit and save";
                    }
                }

                if (player2_score > player1_score)
                {
                    label1.Visible = true;
                    if (player2IsBogin)
                    {
                        label1.Text = "Bogina won!!! Press Escape to exit and save";
                    }
                    if (player2ISHeinemann)
                    {
                        label1.Text = "Heinemama won!!! Press Escape to exit and save";
                    }
                    if (player2IsUriah)
                    {
                        label1.Text = "Urititz won!!! Press Escape to exit and save";
                    }
                    if (player2IsKogos)
                    {
                        label1.Text = "Kogoson won!!! Press Escape to exit and save";
                    }
                    if (player2IsShimshon)
                    {
                        label1.Text = "Shimshon won!!! Press Escape to exit and save";
                    }
                }
                if (player1_score == player2_score)
                {
                    label1.Visible = true;
                    label1.Text = "Tie!!!";
                }
                endGame();
            }
        }

        private void endGame()
        {
            timer1.Enabled = false;
            gravity.Enabled = false;
            timer2.Enabled = false;
            Time.Enabled = false;
        }
    }
}
