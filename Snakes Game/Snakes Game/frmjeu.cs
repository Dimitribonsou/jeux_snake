using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Imaging;// bibliotheque pour compresser les photos prises en images JPG
using WMPLib;

namespace Snakes_Game
{
    public partial class frmjeu : Form
    {
      List<Cercle> snake = new List<Cercle>();//liste permettant l'ajout du serpant (systeme d'empilement)
      Cercle food = new Cercle();// variable permettant de creer la nourriture
       public  double time ;
       public  int maxWidth;
       public  int maxHeight;
       public  bool pause,vson;
       public  int score;
       public  int highscore,nbvie=2;
       public string nomniv;
        public Random rand = new Random();

       public bool goLeft, goRight, goDown, goUp;


        public frmjeu()
        {
            InitializeComponent();
            lbDate.Text = DateTime.Now.ToShortDateString();
            new Parametres();
            try
            {
                
                lbafNiv.Text = nomniv ;
            }
            catch (Exception)
            {

            }
            lbafflevel.Visible = true;
            lbafflevel.Text = "Level 1";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
              lbafNiv.Text = nomniv.ToString();
        }

        private void KeyIsDown(object sender, KeyEventArgs e)//gestion des touches directionnelles du clavier actives
        {
          
            if (e.KeyCode == Keys.Left && Parametres.Directions != "right")
            {
                goLeft = true;
            }

            if (e.KeyCode == Keys.Right && Parametres.Directions != "left")
            {
                goRight = true;
            }

            if (e.KeyCode == Keys.Up && Parametres.Directions != "down")
            {
                goUp = true;
            }

            if (e.KeyCode == Keys.Down && Parametres.Directions != "up")
            {
                goDown = true;
            }
            if (e.KeyCode == Keys.Space)
            {
                pause = true;
                gameTimer.Stop();

                if (MessageBox.Show("Pause" + Environment.NewLine + "Voulez vous  continuer ??", "Pause", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                {
                    gameTimer.Start();
                    return;
                }
                else
                {
                    Acceuil ac = new Acceuil();
                    ac.Show();
                }
               
            }
          
        }

        private void KeyIsUp(object sender, KeyEventArgs e)//gestion des touches directionnelles du clavier inactif
        {

            if (e.KeyCode == Keys.Left)
            {
                goLeft = false;
            }

            if (e.KeyCode == Keys.Right)
            {
                goRight = false;
            }

            if (e.KeyCode == Keys.Up )
            {
                goUp = false;
            }

            if (e.KeyCode == Keys.Down)
            {
                goDown = false;
            }
            if (e.KeyCode == Keys.Space)
            {
                pause = false;
            }

        }

        //private void StartGame(object sender, EventArgs e)
        //{
        //    RestartGame();
        //}

        private void TakeSnap(object sender, EventArgs e) //methode permettant de gerer le bouton snap
        {
            Label caption = new Label();
            caption.Text = "Mon score est  " + score + " Et mon meilleur score est  " + highscore+ " Sur le  snake game Pour le moment";
            caption.Font = new Font("Arial", 12, FontStyle.Bold);
            caption.ForeColor = Color.Black;
            caption.AutoSize = false;
            caption.Width = picCanvas.Width;//picCanvas picture box contenant le jeu
            caption.Height = 30;
            caption.TextAlign = ContentAlignment.MiddleCenter;
            picCanvas.Controls.Add(caption);

            
            SaveFileDialog dialog = new SaveFileDialog();
            dialog.FileName = "Snake Game snap";
            dialog.DefaultExt = "jpg";
            dialog.Filter = " JPG Image File | *.jpg";
            dialog.ValidateNames = true;

            if (dialog.ShowDialog() == DialogResult.OK) {
                int width = Convert.ToInt32(picCanvas.Width);
                int height = Convert.ToInt32(picCanvas.Height);

                Bitmap bmp = new Bitmap(width,height);
                picCanvas.DrawToBitmap(bmp, new Rectangle(0, 0, width, height));
                bmp.Save(dialog.FileName, ImageFormat.Jpeg);
                picCanvas.Controls.Remove(caption);
            }
        }

        public void gameTimerEvent(object sender, EventArgs e)
        {

            // parametrages des directions
            time += 0.03;
            lbtime.Text = time.ToString("#")+"s";
            lbheure.Text = DateTime.Now.ToLongTimeString();
            if (time <0.5)
            {
                gameTimer.Interval = 200;
            }
            if(goLeft){
                Parametres.Directions = "left";
            }
            if (goRight)
            {
                Parametres.Directions = "right";
            }
            if (goDown)
            {
                Parametres.Directions = "down";
            }
            if (goUp)
            {
                Parametres.Directions = "up";
            }
            if (pause)
            {
                Parametres.Directions = "space";
            }
            
            // fin de parametrages
            //Gestion des niveaux

            if ((int)time <= 25 && score >= 5)
            {

                lblevel.Text = "2";
                gameTimer.Interval += 5;

            }
       
            if ((int)time <= 50 && score >= 10)
            {
               // lbafflevel.Text = "Level 3";
                lblevel.Text = "3";
                gameTimer.Interval +=10;
             

            }
            //else
            //{
            //    GameOver();
            //}
            if ((int)time <= 70 && score >= 20)
            {
               // lbafflevel.Text = "Level 4";
                gameTimer.Interval += 15;
                lblevel.Text = "4";

            }
            //else
            //{
            //    GameOver();
            //}
            if ((int)time==90 && score >= 35)
            {
                gameTimer.Interval += 20;
                lblevel.Text = "5";
                lbafflevel.Text = "Level 5";
            }
            //else
            //{
            //    GameOver();
            //}  
            
            #region MyRegion
            //if (time == 25)
            //{
            //    if (score >= 5)
            //    {
            //        MessageBox.Show("Vous Avez eu un score de " + score +"bon pour un debut");
            //    }
            //    else
            //    {
            //        MessageBox.Show("Vous Avez eu un score inferieur a 5 en 25s ");
            //        GameOver();

            //    }
            //}
            #endregion
        
            for (int i = snake.Count - 1; i >= 0; i--)
            {
                if (snake[i].X>=maxWidth||snake[i].Y>=maxHeight)
                {

                    pictureBoxLive2.Image = Properties.Resources.vide;
                    pictureBoxLive2.SizeMode = PictureBoxSizeMode.StretchImage;
                    GameOver();
                    
                }
                if (i == 0)
                {
                    switch (Parametres.Directions)
                    {

                        case "left":
                            snake[i].X--;
                            break;
                        case "right":
                            snake[i].X++;
                            break;
                        case "down":
                            snake[i].Y++;
                            break;
                        case "up":
                            snake[i].Y--;
                            break;
                        default: break;
                    }
                    if (snake[i].X < 0)
                    {
                        snake[i].X = maxWidth;
                    }
                    if (snake[i].X > maxWidth)
                    {
                        snake[i].X = 0;
                    }
                    if (snake[i].Y < 0)
                    {
                        snake[i].Y = maxHeight;
                    }
                    if (snake[i].Y > maxHeight)
                    {
                        snake[i].Y = 0;
                    }
                    if (snake[i].X == food.X && snake[i].Y == food.Y) {
                      
                        EatFood();
                    }

                    for (int j = 1; j < snake.Count; j++) {
                        if (snake[i].X == snake[j].X && snake[i].Y == snake[j].Y) {
                           // nbvie = nbvie - 1; 
                            pictureBoxLive2.Image = Properties.Resources.vide;
                            pictureBoxLive2.SizeMode = PictureBoxSizeMode.StretchImage;
                              GameOver();
                        }
                    }
                }
                else {
                    snake[i].X = snake[i - 1].X;//deplacement du serpent
                    snake[i].Y = snake[i - 1].Y;
                } 
            }
            picCanvas.Invalidate();
        }

        private void UpdatePictureBoxGraphics(object sender, PaintEventArgs e)
        {
            Graphics canvas = e.Graphics;

            Brush snakecolour;
            //creation des cercle a l'aide de la classe craphics
            for (int i = 0; i < snake.Count; i++)
            {
                if (i == 0)
                {
                    snakecolour = Brushes.Black;//definition de la couleur noir pour la tete du serpent
                }
                else {
                    snakecolour = Brushes.DarkGreen;//definition de la couleur verte pour le tronc du serpent
                }
                
                canvas.FillEllipse(snakecolour , new Rectangle
                    (
                        snake[i].X * Parametres.Width,
                        snake[i].Y * Parametres.Height,
                        Parametres.Width, Parametres.Height
                    ));//creation des cercles pour la construction du serpent
            }

            canvas.FillEllipse(Brushes.DarkRed, new Rectangle
                    (
                    
                        food.X * Parametres.Width,
                        food.Y * Parametres.Height,
                        Parametres.Width, Parametres.Height
                    ));//creation du cercle de couleur rouge pour la nourriture
        }

        public void RestartGame() 
        {
            maxWidth = picCanvas.Width / Parametres.Width -2;//definition  de la largeur de la zone de jeu
            maxHeight = picCanvas.Width / (Parametres.Height+6);//definition de la hauteur de la zone de jeu

            snake.Clear();//vider la liste la liste contenant les cercles au demmarrage du jeu
             time=0;
             lbGameOver.Visible = false;
             btnRestart.Visible = false;
             btnSnap.Enabled = false;
             btnRestart.Enabled = false;
             lbtime.Text = "0s";
             lblevel.Text = "1";
            score = 0;
            lbscore.Text=  score.ToString();
            pictureBoxLive2.Image = Properties.Resources.coeur;
            pictureBoxLive2.SizeMode = PictureBoxSizeMode.StretchImage;
            Cercle head = new Cercle { X = 10, Y = 5 };

            snake.Add(head); // ajout de la tete du serpent a la liste

            for (int i = 0; i < 2; i++) {//definition de la taille du serpent au demarrage a l'aide de la boucle for
                Cercle body = new Cercle();
                snake.Add(body);
            }

            food = new Cercle { X = rand.Next(2, maxWidth), Y = rand.Next(2, maxHeight) };//nouveau affichage de la nourriture a une position aleatoire a l'aide de la classe Random

            gameTimer.Start();//demarage du jeu

        }

        public void EatFood() 
        {
            score += 1;
            lbscore.Text = score.ToString(); 
           
            Cercle body = new Cercle //ajout d'un nouveau cercle a la suite de la liste
            {
                X = snake[snake.Count - 1].X,
                Y = snake[snake.Count - 1].Y
            };

            snake.Add(body);

            food = new Cercle { X = rand.Next(2, maxWidth), Y = rand.Next(2, maxHeight) };//creation d'un nouveau emplacement pour la nourriture
        }

        public void GameOver() 
        {
            gameTimer.Stop();//arret de la fonction timer
            btnSnap.Enabled = true;
            btnRestart.Enabled = true;
            if (score > highscore) {
                highscore = score;
                txtHigh_score.Text = "Meilleur  Score: " + Environment.NewLine + highscore;
                txtHigh_score.ForeColor = Color.Magenta;
                txtHigh_score.TextAlign = ContentAlignment.MiddleCenter;
                
            }
            btnRestart.Visible = true;
            btnRestart.BackColor = Color.Red;
            lbGameOver.Visible = true;
            lbGameOver.Text = " GAME OVER !!";
            //if (MessageBox.Show(" GAME OVER  !! \n\n "+" Votre Score est : " +score+ " \n\nVoulez Vous Continuer ??", "Game Over", MessageBoxButtons.YesNo, MessageBoxIcon.Error) == DialogResult.Yes)
            //{
            //    RestartGame();
            //}
            //else 
            //{
            //    this.Close();
            //}
        }

        private void btnRestart_Click(object sender, EventArgs e)
        {
            RestartGame();
          
        }

        //private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        //{
        //    Aide AD = new Aide();
        //    AD.ShowDialog();
        //}
    }
}
