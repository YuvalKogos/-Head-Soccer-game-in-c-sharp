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
using Microsoft.VisualBasic;

namespace WindowsFormsApp3
{
    public partial class Form2 : Form
    {
        public static int player1Pic;
        public static int player2Pic;
        public static int heinmaennGoalsF2;
        public static int uriahGoalsF2;
        public static int kogosGoalsF2;
        public static int boginGoalsF2;
        public static int shimshonGoalsF2;
        public static bool Reset;
        public static int HeinemannGamesPlayed;
        public static int UriahGamesPlayed;
        public static int BoginGamesPlayed;
        public static int KogosGamesPlayed;
        public static int ShimshonGamesPlayed;
        public static double HeinamannPercent;
        public static double UriahPercent;
        public static double BoginPercent;
        public static double KogosPercent;
        public static double ShimshonPercent;
        public static int HeinemamaWins;
        public static int BoginaWins;
        public static int KogosWins;
        public static int UriahWins;
        public static int ShimShonWins;


        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
            player1Pic = Convert.ToInt32(textBox1.Text);
            
            player2Pic = Convert.ToInt32(textBox2.Text);
           

            heinmaennGoalsF2 = Convert.ToInt32(System.IO.File.ReadAllText(@"C:\Users\yuval\Desktop\My game C#\HighScores\highScoreHeinemann"));
            uriahGoalsF2 = Convert.ToInt32(System.IO.File.ReadAllText(@"C:\Users\yuval\Desktop\My game C#\HighScores\highScoreUriah"));
            kogosGoalsF2 = Convert.ToInt32(System.IO.File.ReadAllText(@"C:\Users\yuval\Desktop\My game C#\HighScores\highScoreKogos"));
            boginGoalsF2 = Convert.ToInt32(System.IO.File.ReadAllText(@"C:\Users\yuval\Desktop\My game C#\HighScores\highScoreBogin"));

            if (File.Exists(@"C:\Users\yuval\Desktop\My game C#\HighScores\highScoreShimshon"))
            {
                shimshonGoalsF2 = Convert.ToInt32(System.IO.File.ReadAllText(@"C:\Users\yuval\Desktop\My game C#\HighScores\highScoreShimshon"));
            }

            //////games played//////

            
            HeinemannGamesPlayed = Convert.ToInt32(System.IO.File.ReadAllText(@"C:\Users\yuval\Desktop\My game C#\HighScores\GamesPlayed\GamesPlayedHeinemann"));
            BoginGamesPlayed = Convert.ToInt32(System.IO.File.ReadAllText(@"C:\Users\yuval\Desktop\My game C#\HighScores\GamesPlayed\GamesPlayedBogin"));
            KogosGamesPlayed = Convert.ToInt32(System.IO.File.ReadAllText(@"C:\Users\yuval\Desktop\My game C#\HighScores\GamesPlayed\GamesPlayedKogos"));
            UriahGamesPlayed = Convert.ToInt32(System.IO.File.ReadAllText(@"C:\Users\yuval\Desktop\My game C#\HighScores\GamesPlayed\GamesPlayedUriah"));
            ShimshonGamesPlayed = Convert.ToInt32(System.IO.File.ReadAllText(@"C:\Users\yuval\Desktop\My game C#\HighScores\GamesPlayed\GamesPlayedShimshon"));


            /////////wins////////

            HeinemamaWins = Convert.ToInt32(System.IO.File.ReadAllText(@"C:\Users\yuval\Desktop\My game C#\HighScores\Wins\HeinemannWins"));
            BoginaWins = Convert.ToInt32(System.IO.File.ReadAllText(@"C:\Users\yuval\Desktop\My game C#\HighScores\Wins\BoginWins"));
            KogosWins = Convert.ToInt32(System.IO.File.ReadAllText(@"C:\Users\yuval\Desktop\My game C#\HighScores\Wins\KogosWins"));
            UriahWins = Convert.ToInt32(System.IO.File.ReadAllText(@"C:\Users\yuval\Desktop\My game C#\HighScores\Wins\UriahWins"));
            ShimShonWins = Convert.ToInt32(System.IO.File.ReadAllText(@"C:\Users\yuval\Desktop\My game C#\HighScores\Wins\SimshonWins"));


            var form1 = (Form1)Tag;
            this.Show();
            Close();

        }

        private void Form2_Load(object sender, EventArgs e)
        {

            HeinemannGamesPlayed = Convert.ToInt32(System.IO.File.ReadAllText(@"C:\Users\yuval\Desktop\My game C#\HighScores\GamesPlayed\GamesPlayedHeinemann"));
            BoginGamesPlayed = Convert.ToInt32(System.IO.File.ReadAllText(@"C:\Users\yuval\Desktop\My game C#\HighScores\GamesPlayed\GamesPlayedBogin"));
            KogosGamesPlayed = Convert.ToInt32(System.IO.File.ReadAllText(@"C:\Users\yuval\Desktop\My game C#\HighScores\GamesPlayed\GamesPlayedKogos"));
            UriahGamesPlayed = Convert.ToInt32(System.IO.File.ReadAllText(@"C:\Users\yuval\Desktop\My game C#\HighScores\GamesPlayed\GamesPlayedUriah"));
            ShimshonGamesPlayed = Convert.ToInt32(System.IO.File.ReadAllText(@"C:\Users\yuval\Desktop\My game C#\HighScores\GamesPlayed\GamesPlayedShimshon"));

            heinmaennGoalsF2 = Convert.ToInt32(System.IO.File.ReadAllText(@"C:\Users\yuval\Desktop\My game C#\HighScores\highScoreHeinemann"));
            uriahGoalsF2 = Convert.ToInt32(System.IO.File.ReadAllText(@"C:\Users\yuval\Desktop\My game C#\HighScores\highScoreUriah"));
            kogosGoalsF2 = Convert.ToInt32(System.IO.File.ReadAllText(@"C:\Users\yuval\Desktop\My game C#\HighScores\highScoreKogos"));
            boginGoalsF2 = Convert.ToInt32(System.IO.File.ReadAllText(@"C:\Users\yuval\Desktop\My game C#\HighScores\highScoreBogin"));

            HeinemamaWins = Convert.ToInt32(System.IO.File.ReadAllText(@"C:\Users\yuval\Desktop\My game C#\HighScores\Wins\HeinemannWins"));
            BoginaWins = Convert.ToInt32(System.IO.File.ReadAllText(@"C:\Users\yuval\Desktop\My game C#\HighScores\Wins\BoginWins"));
            KogosWins = Convert.ToInt32(System.IO.File.ReadAllText(@"C:\Users\yuval\Desktop\My game C#\HighScores\Wins\KogosWins"));
            UriahWins = Convert.ToInt32(System.IO.File.ReadAllText(@"C:\Users\yuval\Desktop\My game C#\HighScores\Wins\UriahWins"));
            ShimShonWins = Convert.ToInt32(System.IO.File.ReadAllText(@"C:\Users\yuval\Desktop\My game C#\HighScores\Wins\SimshonWins"));


            double lev1kog = KogosWins / (double)KogosGamesPlayed;
            double lev1heinemann = HeinemamaWins / (double)HeinemannGamesPlayed;
            double lev1bogin = BoginaWins / (double)BoginGamesPlayed;

            MessageBox.Show(KogosWins.ToString());
            MessageBox.Show(lev1heinemann.ToString());

            HeinamannPercent = (int)lev1heinemann;
            BoginPercent = (BoginaWins / BoginGamesPlayed) * 100;
            UriahPercent = (UriahWins / UriahGamesPlayed) * 100;

            KogosPercent = lev1kog * 100;
            KogosPercent = KogosPercent * 100;
            int temp = (int)KogosPercent;

            KogosPercent = temp / 100.0;
 
            ShimshonPercent = (ShimShonWins / ShimshonGamesPlayed) * 100;
           
            
              

            if (File.Exists(@"C:\Users\yuval\Desktop\My game C#\HighScores\highScoreUriah"))
            {
                HSUriah2.Text = "Uriah: " + System.IO.File.ReadAllText(@"C:\Users\yuval\Desktop\My game C#\HighScores\highScoreUriah");
            }

            

            if (File.Exists(@"C:\Users\yuval\Desktop\My game C#\HighScores\highScoreHeinemann"))
            {
                HSHeinmaenn2.Text = "Heinamann: " + System.IO.File.ReadAllText((@"C:\Users\yuval\Desktop\My game C#\HighScores\highScoreHeinemann"));
            }

            if (File.Exists(@"C:\Users\yuval\Desktop\My game C#\HighScores\highScoreKogos"))
            {
                HSKogos2.Text = "Kogos: " + System.IO.File.ReadAllText(@"C:\Users\yuval\Desktop\My game C#\HighScores\highScoreKogos");
            }

            if (File.Exists(@"C:\Users\yuval\Desktop\My game C#\HighScores\highScoreBogin"))
            {
                HSBogin2.Text = "Bogin: " + System.IO.File.ReadAllText(@"C:\Users\yuval\Desktop\My game C#\HighScores\highScoreBogin");
            }

            if (File.Exists(@"C:\Users\yuval\Desktop\My game C#\HighScores\highScoreShimshon"))
            {
                HSShimshon.Text = "shimshoni: " + System.IO.File.ReadAllText(@"C:\Users\yuval\Desktop\My game C#\HighScores\highScoreShimshon");
            }


            /////////////games played///////////


            if (File.Exists(@"C:\Users\yuval\Desktop\My game C#\HighScores\GamesPlayed\GamesPlayedHeinemann"))
            {

                HSHeinmaenn2.Text = "Heinamann: " + System.IO.File.ReadAllText(@"C:\Users\yuval\Desktop\My game C#\HighScores\highScoreHeinemann") + " | " + System.IO.File.ReadAllText(@"C:\Users\yuval\Desktop\My game C#\HighScores\GamesPlayed\GamesPlayedHeinemann") + " | " + HeinamannPercent.ToString() + "%";

                //   HSHeinmaenn2.Text = " , " + System.IO.File.ReadAllText(@"C:\Users\yuval\Desktop\My game C#\HighScores\GamesPlayed\GamesPlayedHeinemann");
            }

            if (File.Exists(@"C:\Users\yuval\Desktop\My game C#\HighScores\GamesPlayed\GamesPlayedBogin"))
            {

                HSBogin2.Text = "Bogin: " + System.IO.File.ReadAllText(@"C:\Users\yuval\Desktop\My game C#\HighScores\highScoreBogin") + " | " + System.IO.File.ReadAllText(@"C:\Users\yuval\Desktop\My game C#\HighScores\GamesPlayed\GamesPlayedBogin") + " | " + BoginPercent.ToString() + "%";


                // HSBogin2.Text += " , " + System.IO.File.ReadAllText(@"C:\Users\yuval\Desktop\My game C#\HighScores\GamesPlayed\GamesPlayedBogin");
            }

            if (File.Exists(@"C:\Users\yuval\Desktop\My game C#\HighScores\GamesPlayed\GamesPlayedKogos"))
            {

                HSKogos2.Text = "Kogos: " + System.IO.File.ReadAllText(@"C:\Users\yuval\Desktop\My game C#\HighScores\highScoreKogos") + " | " + System.IO.File.ReadAllText(@"C:\Users\yuval\Desktop\My game C#\HighScores\GamesPlayed\GamesPlayedKogos") + " | " + KogosPercent.ToString() + "%";


                //HSKogos2.Text += " , " + System.IO.File.ReadAllText(@"C:\Users\yuval\Desktop\My game C#\HighScores\GamesPlayed\GamesPlayedKogos");
            }

            if (File.Exists(@"C:\Users\yuval\Desktop\My game C#\HighScores\GamesPlayed\GamesPlayedUriah"))
            {

                HSUriah2.Text = "Uriah: " + System.IO.File.ReadAllText(@"C:\Users\yuval\Desktop\My game C#\HighScores\highScoreUriah") + " | " + System.IO.File.ReadAllText(@"C:\Users\yuval\Desktop\My game C#\HighScores\GamesPlayed\GamesPlayedUriah") + " | " + UriahPercent.ToString() + "%";



                // HSUriah2.Text += " , " + System.IO.File.ReadAllText(@"C:\Users\yuval\Desktop\My game C#\HighScores\GamesPlayed\GamesPlayedUriah");
            }

            if (File.Exists(@"C:\Users\yuval\Desktop\My game C#\HighScores\GamesPlayed\GamesPlayedShimshon"))
            {

                HSShimshon.Text = "shimshoni: " + System.IO.File.ReadAllText(@"C:\Users\yuval\Desktop\My game C#\HighScores\highScoreShimshon") + " | " + System.IO.File.ReadAllText(@"C:\Users\yuval\Desktop\My game C#\HighScores\GamesPlayed\GamesPlayedShimshon") + " | " + ShimshonPercent.ToString() +"%";


                //HSShimshon.Text += " , " + System.IO.File.ReadAllText(@"C:\Users\yuval\Desktop\My game C#\HighScores\GamesPlayed\GamesPlayedShimshon");
            }

            ///////////wins///////////

            HSHeinmaenn2.Text += " | " + System.IO.File.ReadAllText(@"C:\Users\yuval\Desktop\My game C#\HighScores\highScoreHeinemann");
            HSBogin2.Text += " | " + System.IO.File.ReadAllText(@"C:\Users\yuval\Desktop\My game C#\HighScores\Wins\BoginWins");
            HSKogos2.Text += " | " + System.IO.File.ReadAllText(@"C:\Users\yuval\Desktop\My game C#\HighScores\Wins\KogosWins");
            HSUriah2.Text += " | " + System.IO.File.ReadAllText(@"C:\Users\yuval\Desktop\My game C#\HighScores\Wins\UriahWins");
            HSShimshon.Text += " | " + System.IO.File.ReadAllText(@"C:\Users\yuval\Desktop\My game C#\HighScores\Wins\SimshonWins");


        }

        private void HSHeinmaenn2_Click(object sender, EventArgs e)
        {

        }

        private void resetbt_Click(object sender, EventArgs e)
        {
            string passCheck = Microsoft.VisualBasic.Interaction.InputBox("Enter Password","Password","");
            if (passCheck == "ets22012")
            {
                heinmaennGoalsF2 = 0;
                uriahGoalsF2 = 0;
                boginGoalsF2 = 0;
                kogosGoalsF2 = 0;
                HSHeinmaenn2.Text = "Heinamann: " + 0;
                HSUriah2.Text = "Uriah: " + 0;
                HSKogos2.Text = "Kogos: " + 0;
                HSBogin2.Text = "Bogin: " + 0;

                ///////Heineman///////



                if (File.Exists(@"C:\Users\yuval\Desktop\My game C#\HighScores\highScoreHeinemann"))
                {
                    File.Delete(@"C:\Users\yuval\Desktop\My game C#\HighScores\highScoreHeinemann");
                }

                System.IO.File.WriteAllText(@"C:\Users\yuval\Desktop\My game C#\HighScores\highScoreHeinemann", "0");

                if (File.Exists(@"C:\Users\yuval\Desktop\My game C#\HighScores\Wins\HeinemannWins"))
                {
                    File.Delete(@"C:\Users\yuval\Desktop\My game C#\HighScores\Wins\HeinemannWins");
                }

                System.IO.File.WriteAllText(@"C:\Users\yuval\Desktop\My game C#\HighScores\Wins\HeinemannWins", "0");


                ///////Bogin//////////
                if (File.Exists(@"C:\Users\yuval\Desktop\My game C#\HighScores\highScoreBogin"))
                {
                    File.Delete((@"C:\Users\yuval\Desktop\My game C#\HighScores\highScoreBogin"));
                }

                System.IO.File.WriteAllText(@"C:\Users\yuval\Desktop\My game C#\HighScores\highScoreBogin", "0");

                if (File.Exists(@"C:\Users\yuval\Desktop\My game C#\HighScores\Wins\BoginWins"))
                {
                    File.Delete(@"C:\Users\yuval\Desktop\My game C#\HighScores\Wins\BoginWins");
                }

                System.IO.File.WriteAllText(@"C:\Users\yuval\Desktop\My game C#\HighScores\Wins\BoginWins", "0");


                ////////Kogos////////

                if (File.Exists(@"C:\Users\yuval\Desktop\My game C#\HighScores\highScoreKogos"))
                {
                    File.Delete(@"C:\Users\yuval\Desktop\My game C#\HighScores\highScoreKogos");
                }

                System.IO.File.WriteAllText(@"C:\Users\yuval\Desktop\My game C#\HighScores\highScoreKogos", "0");

                //////////Uriah////////
                if (File.Exists(@"C:\Users\yuval\Desktop\My game C#\HighScores\highScoreUriah"))
                {
                    File.Delete(@"C:\Users\yuval\Desktop\My game C#\HighScores\highScoreUriah");
                }

                System.IO.File.WriteAllText(@"C:\Users\yuval\Desktop\My game C#\HighScores\highScoreUriah", "0");

                if (File.Exists(@"C:\Users\yuval\Desktop\My game C#\HighScores\Wins\UriahWins"))
                {
                    File.Delete(@"C:\Users\yuval\Desktop\My game C#\HighScores\Wins\UriahWins");
                }

                System.IO.File.WriteAllText(@"C:\Users\yuval\Desktop\My game C#\HighScores\Wins\UriahWins", "0");


                /////////Shimshoni///////
                if (File.Exists(@"C:\Users\yuval\Desktop\My game C#\HighScores\highScoreShimshon"))
                {
                    File.Delete(@"C:\Users\yuval\Desktop\My game C#\HighScores\highScoreShimshon");

                }

                System.IO.File.WriteAllText(@"C:\Users\yuval\Desktop\My game C#\HighScores\highScoreShimshon", "0");

                if (File.Exists(@"C:\Users\yuval\Desktop\My game C#\HighScores\Wins\SimshonWins"))
                {
                    File.Delete(@"C:\Users\yuval\Desktop\My game C#\HighScores\Wins\SimshonWins");
                }

                System.IO.File.WriteAllText(@"C:\Users\yuval\Desktop\My game C#\HighScores\Wins\SimshonWins", "0");





            }

        }
    }
}
