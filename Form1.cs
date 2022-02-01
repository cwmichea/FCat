using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;//Media libray for SoundPlayer 

namespace FCat
{
    public partial class Form1 : Form
    {   //Create window form file, make difference between regular and customized toolbox elements
        //Add, place, name, choose and get the picture boxes
        //Add and enable Timer and time event, start coding in GameTimerEv.
        //Enable Key down and up events with spacebar and P
        //Create variables included SoundPlayer that needs a Media libray
        int speed = 8;
        int gravityForce = 8;
        int score = 0;
        int previousScore = 0;
        int level = 0;
        int catF = 0;
        bool gameOn = true;
        public SoundPlayer soundPlay;
        public SoundPlayer getFoodPlay;
        public SoundPlayer crashPlay;
        bool playingASound = false;

        public Form1()
        {
            InitializeComponent();
            soundPlay = new SoundPlayer("cat1.wav");
            getFoodPlay = new SoundPlayer("hungrycat.wav");
            crashPlay = new SoundPlayer("kittycrash.wav");
        }

        private void KDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space) { gravityForce = -8; }//Set to negative the gravity force. Negative value is UP
            if (e.KeyCode == Keys.P) { labelPause.Visible = true; gameOn = !gameOn; }//Set on pause the game
        }

        private void KUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space) 
            { gravityForce = 8; 
                if(playingASound==false) { soundPlay.Play(); } 
            }//Switch back to normal the gravity force. Positive value is DOWN. Also play sound only if there is no other sound played
        }

        private void GameTimer(object sender, EventArgs e)
        {
        }

        private void GameTimerEvent(object sender, EventArgs e)
        {
            if (gameOn)//Game is on only when is not paused or it is game over
            {
                //Score text updating
                scoreText.Text = "Score: " + score.ToString() + " level " + level.ToString() + " CatFood " + catF.ToString(); //+ " level " + speed.ToString() + " prescore " + previousScore.ToString() + " prescore " + speed.ToString();   //Show and update score
                //Basic Gameplay 
                labelPause.Visible = false;             //Hide paused text because Game is on
                level = speed - 8;                      //Get a level parameter connected to the speed of the game
                cat.Top += gravityForce;                //Player goes UP
                hit.Top = cat.Top;                      //Hit effect follows cat position
                hit.Visible = false;                    //Hit is invisible during the game, only appears when it crashes
                //Make things move left
                petitC0.Left -= speed;                  //Make the little clouds go left
                petitC1.Left -= speed;
                petitC2.Left -= speed;
                petitC3.Left -= speed;
                petitC4.Left -= speed + 2;
                petitC5.Left -= speed + 1;

                catFood.Left -= speed;                  //Make the catfood goes left

                mountain.Left -= speed;                 //Make the mountain goes left
                dog.Left -= speed;                      //Make the dog goes left and down
                dog.Top += (speed / 3);

                Cloud1.Left -= speed;                   //Make the big clouds go left
                Cloud2.Left -= speed;
                Cloud3.Left -= speed;

                if (petitC0.Left < -55)                 //Make the small clouds teleport to the right, out the window, to cylce it
                { petitC0.Left = 1111; score++; }
                if (petitC1.Left < -55)
                { petitC1.Left = 1111; score++; }
                if (petitC2.Left < -55)
                { petitC2.Left = 1111; score++; }
                if (petitC3.Left < -55)
                { petitC3.Left = 1111; score++; }
                if (petitC4.Left < -55)
                { petitC4.Left = 4444; score++; }
                if (petitC5.Left < -55)
                { petitC5.Left = 4444; score++; }
                //Make things reappear
                if (catFood.Left < -55)                 //Make the catfood teleports to the right, out the window, to cylce it
                { catFood.Left = 4444; ; }              //For memory performance only, Make cat food keeps moving in the same space, although not visible

                if (Cloud1.Left < -55)                  //Make the big clouds teleport to the right, out the window, to cylce it 
                { Cloud1.Left = 2222; score++; }
                if (Cloud2.Left < -55)
                { Cloud2.Left = 2222; score++; }
                if (Cloud3.Left < -55)
                { Cloud3.Left = 2222; score++; }

                if (mountain.Left < -55)               //Make the mountain teleports to the right
                { mountain.Left = 4444;  ; }

                if (score % 20 == 0 && catFood.Visible == false)  //Make pop up a cat food for every +20 more in score
                { catFood.Visible = true; catFood.Left = 1111; }

                if (score % 25 == 0 && score != 0)  //Make pop up a dog for every +25 more in score
                { dog.Left = 1111; dog.Top = 0; }

                //If cat hits sth...
                if (cat.Bounds.IntersectsWith(catFood.Bounds) && catFood.Visible) //Make the cat food add a catfood point, also block playing another sound
                { catF++; catFood.Visible = false; playingASound = true;  getFoodPlay.Play(); }

                if (cat.Bounds.IntersectsWith(petitC1.Bounds) || cat.Bounds.IntersectsWith(petitC2.Bounds) || cat.Bounds.IntersectsWith(petitC3.Bounds) ||
                    cat.Bounds.IntersectsWith(Cloud1.Bounds) || cat.Bounds.IntersectsWith(Cloud2.Bounds) || cat.Bounds.IntersectsWith(Cloud3.Bounds) ||
                    cat.Bounds.IntersectsWith(mountain.Bounds) || cat.Bounds.IntersectsWith(dog.Bounds) || cat.Bounds.IntersectsWith(petitC0.Bounds) ||
                    cat.Bounds.IntersectsWith(petitC4.Bounds) || cat.Bounds.IntersectsWith(petitC5.Bounds))
                { GameOver(); }                         //If cat hits the clouds, mounatin, gameover

                if (cat.Top < -1)                       //If cat goes above the upper border, gameover
                { GameOver(); }
                if (cat.Top > 470)                      //If cat goes below the lower border, gameover
                { GameOver(); }

                //Increase difficulty according to the score range
                if (score % 10 == 0 && previousScore != score)                         //Increase difficulty linealy +1 for each +10 score
                {
                    previousScore = score;
                    //Make sure  to add Difficulty only when 5 score are added, and not for each time iteration
                    speed++;
                }
                else if (score > 150 && score % 5 == 0 && previousScore != score)       //Increase difficulty linealy +1 for each +5 score
                {
                    previousScore = score;
                    //Make sure  to add Difficulty only when 5 score are added, and not for each time iteration
                    speed++;
                }   
            }
            else { }//Do nothing if the game is paused
        }
        private void GameOver()
        {
            playingASound = true;
            crashPlay.Play();
            gameOn = false;
            hit.Visible = true;
            gametimer.Stop();
            scoreText.Text += " \nGame over. Good try!";
        }
    }
}
