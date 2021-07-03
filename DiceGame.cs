using System;    
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectDiceGame
{     /*  
          Project- Dice Game ( Six Of One)
          Purpose of the code: Six of One (DICE GAME)
          This game can be played between two players or single player can play with the Program */
    public partial class DiceGame : Form
    {
        //Declaration of Variables
        Image[] diceImage;
        int[] dice;
        Random random;
        Random r;
        int Score1 = 0;
        int Score2 = 0;
        int TurnScore1 = 0;
        int TurnScore2 = 0;
        int number_of_dice = 0;
        int number_of_1s = 0;
        Boolean double_score = false;
        Boolean checkChange = false;
        int target_counter = 0;
        int countp1 = 0;
        int countp2 = 0;

        public DiceGame()
        {
            InitializeComponent();
            //InitializeGame();
        }

        private void NewGame()       // new game method to put all controls back to 0 // intialization  to 0 
        {
            Score1 = 0;
            Score2 = 0;
            TurnScore1 = 0;
            TurnScore2 = 0;
            number_of_dice = 0;
            number_of_1s = 0;
            double_score = false;
            checkChange = false;
            target_counter = 0;
            lbl_p2Score.Text = " " + Score2.ToString();
            lbl_p1Score.Text = " " + Score2.ToString();
            lbl_p1Cmnt.Text = "";
            lbl_p2Cmnt.Text = "";
        }


        private void RollDice()     // roll dice method to roll a dice in a game 
        {
            number_of_1s = 0;
            double_score = false;

            // Reference P1: Externally Dice Images
            // Purpose: Dice Images to show Dice to roll in a form 
            // Date: 3 March 2020
            // Source: Online Website / 
            //   http://indiedevelopmentblog.blogspot.com/p/c-dice-game-tutorial-series.html // dice image
            // Assistance:  from online website, this help to get pictures of dice to use in the game.
            // 7 Dice Images // Intialization
            diceImage = new Image[7];
            diceImage[0] = Properties.Resources.dice_blank;     // location of image
            diceImage[1] = Properties.Resources.dice_1;                    // dice images that I took from online website 
            diceImage[2] = Properties.Resources.dice_2;
            diceImage[3] = Properties.Resources.dice_3;
            diceImage[4] = Properties.Resources.dice_4;
            diceImage[5] = Properties.Resources.dice_5;
            diceImage[6] = Properties.Resources.dice_6;

            r = new Random();     // random number

            dice = new int[6] { 0, 0, 0, 0, 0, 0 };  // dice length is 6  //position (index of dice) {0,0,0,0,0,0}  // every index has some random number that we don't know (random)

            //try and catch(exception) Incase some errors occurs in the try block // catch will define a block of code to be executed .

            if (rbtn_roll1.Checked)               // if radio button 1 checked then  1 dice rolled.
            {
                number_of_dice = 1;
            }
            else if (rbtn_roll2.Checked)            // if radio button 2 checked then  2 dice rolled.
            {
                number_of_dice = 2;
            }
            else if (rbtn_roll3.Checked)                 // if radio button 3 checked then  3 dice rolled.
            {
                number_of_dice = 3;
            }
            else if (rbtn_roll4.Checked)                 // if radio button 4 checked then  4 dice rolled.
            {
                number_of_dice = 4;
            }
            else if (rbtn_roll5.Checked)          // if radio button 5 checked then  5 dice rolled.
            {
                number_of_dice = 5;
            }
            else if (rbtn_roll6.Checked)           // if radio button 6 checked then  6 dice rolled.
            {
                number_of_dice = 6;
            }


            if (rbtnProgram.Checked)              // if Program radio button checked then it will choose random number between 1 to 6 
            {
                random = new Random();       
                number_of_dice = random.Next(1, 7);

            }

            try
            {
                for (int n = 1; n <= 10; n++)                   //using for loop // 10 times dice rolled the show up with last vale // Animation
                {
                    for (int i = 0; i < number_of_dice; i++)  // increament of loop // condition is till 1 
                    {
                        dice[i] = r.Next(1, 7);                         // dice[i] (dice value) can be any random number between 1 to 6 ! // 

                        picbxDice_1.Image = diceImage[dice[0]];       // Using pictureBox to show Image of Dice
                        picbxDice_2.Image = diceImage[dice[1]];      // Image will be showing up depends on the value of number of dice 
                        picbxDice_3.Image = diceImage[dice[2]];
                        picbxDice_4.Image = diceImage[dice[3]];
                        picbxDice_5.Image = diceImage[dice[4]];
                        picbxDice_6.Image = diceImage[dice[5]];
                        System.Threading.Thread.Sleep(50);      // slower the dice rolled 
                        Application.DoEvents();

                    }
                }
                foreach (int dvalue in dice)      // using for loop to  recognice all values in the dice 
                {
                    if (dvalue == 1)                  // if any dice value is a 1 then it would be calculated through number_of_1s !
                   number_of_1s++;      // number of 1s counts 
                }

               // code for add the scores of the six dice to player's score
                if (number_of_1s == 1)                 // if 1s are printed only 1 time in a dice row then there will be no score for turn 
                {
                    if (rbtnPlayer1.Checked == true || rbtnPlayer.Checked == true) // if player 1's turn then score will be added to her score ! 
                    {
                        Score1 = 0;
                        lbl_p1Cmnt.Text = "1, No score";
                    }
                    if (rbtnPlayer2.Checked == true || rbtnProgram.Checked == true)  //  if player 2's turn or program's turn  then score will be added to her score !
                    {
                        Score2 = 0;
                        lbl_p2Cmnt.Text = "1, No score";
                    }
                }
                else if (number_of_1s == 2)      // if 1s are printed  2 times in a dice row then there will be snake's eyes and score back to 0 
                {
                    if (rbtnPlayer1.Checked == true || rbtnPlayer.Checked == true)    // if player 1's turn then score will be added to her score ! 
                    {
                        TurnScore1 = 0;
                        lbl_p1Cmnt.Text = "Snake's eye, score back to 0";
                        if (Score1 == 0) { lbl_p1Cmnt.Text = "Snake's eye, No Score"; }
                    }
                    if (rbtnPlayer2.Checked == true || rbtnProgram.Checked == true)  //  if player 2's turn then score will be added to her score !
                    {
                        TurnScore2 = 0;
                        lbl_p2Cmnt.Text = "Snake's eye, score back to 0 ";
                        if (Score2 == 0) { lbl_p2Cmnt.Text = "Snake's eye, No Score"; }
                    }
                }
                else if (number_of_1s == 3)
                {    // if 1s are printed  3 times in a dice row then there will be dead drop player looses the game immediately !
                    if (rbtnPlayer1.Checked == true || rbtnPlayer.Checked == true)
                    {
                        Score1 = 0;
                        lbl_p1Cmnt.Text = "Dead drop !! Game lost....";
                    }
                    if (rbtnPlayer2.Checked == true || rbtnProgram.Checked == true)
                    {
                        Score2 = 0;
                        lbl_p2Cmnt.Text = "Dead drop !! Game lost... ";
                    }
                }
                else if (number_of_1s >= 4)  //if 1s are printed 4 times in a dice row then there will be Boojum and player win the game immidiately !
                {

                    if (rbtnPlayer1.Checked == true || rbtnPlayer.Checked == true)    //player 1 
                    {
                        lbl_p1Cmnt.Text = ("Boojum !");
                    }
                    if (rbtnPlayer2.Checked == true || rbtnProgram.Checked == true)   //player 2 or program's turn
                    {
                        lbl_p2Cmnt.Text = ("Boojum ! ");
                    }
                }
                else
                {
                    foreach (int element in dice)
                    {
                        if (rbtnPlayer1.Checked == true || rbtnPlayer.Checked == true)
                        {
                            TurnScore1 += element;   // addition of turnscore 
                        }
                        if (rbtnPlayer2.Checked == true || rbtnProgram.Checked == true)
                        {
                            TurnScore2 += element;
                        }
                    }
                    foreach (int element in dice)   // checking if any other number repeated thrice 
                    {
                        int target = element;
                        target_counter = 0;
                        for (int compare =0; compare< dice.Length; compare++)
                        {

                            if (target == dice[compare] && target > 0 )
                            {
                                target_counter++;
                                if (target_counter >= 3)
                                {
                                    double_score = true;
                                }
                            }
                        }
                    }
                    if (double_score == true && number_of_1s == 0)
                    {
                        if (rbtnPlayer1.Checked == true || rbtnPlayer.Checked == true)
                        {
                            TurnScore1 = TurnScore1 + TurnScore1;
                           // score doubled to player's score when it's snaffle 
                            lbl_p1Cmnt.Text = "snaffle";
                        }
                        if (rbtnPlayer2.Checked == true || rbtnProgram.Checked == true)
                        {
                            TurnScore2 = TurnScore2 + TurnScore2 ;                        
                            lbl_p2Cmnt.Text = "snaffle";
                        }
                    }
                    else
                    {
                        if (rbtnPlayer1.Checked == true || rbtnPlayer.Checked == true)
                        {
                            lbl_p1Cmnt.Text = "any other case ! ";            // any other case score added to previous score!!
                        }
                        if (rbtnPlayer2.Checked == true || rbtnProgram.Checked == true)
                        {
                            lbl_p2Cmnt.Text = "any other case !";
                        }

                    }
                }

                if (rbtnPlayer1.Checked == true || rbtnPlayer.Checked == true)
                {
                    Score1 = Score1 + TurnScore1;
                    lbl_p1Score.Text = " " + Score1.ToString();                // sum of the score will be printed on score label ! // player1's final score !!
                }
                if (rbtnPlayer2.Checked == true || rbtnProgram.Checked == true)
                {
                    Score2 = Score2 + TurnScore2;
                    lbl_p2Score.Text = " " + Score2.ToString();       // player2's final sum
                }


                if (rbtnProgram.Checked == true)             // if program is playing then it will compare program's score with goal score
                {
                    int goalScore = Convert.ToInt32(tbx_GoalScore.Text); // taking player's input goal score value 
                    if (Score2 >= goalScore) // player2's goalscore condition       
                    {
                        lbl_Instructions.Text = "                             " + "Program won the game ! New Game Starts !";
                        lbl_p2Score.Text = Score2.ToString();
                        countp2++;    // wins counts
                         btn_RollDice.Enabled = false;

                    }
                    lbl_p2_win.Text = countp2.ToString();
                    
                }
            }
            catch (Exception)
            {
                MessageBox.Show(" Sorry ! you haven't select any dice number ! please select number 1-6 !", "Error");
            }


        }

        private void btn_RollDice_Click(object sender, EventArgs e)     // button for roll the dice 
        {

            if (rbtnPlayerP.Checked == true)      // code for alternate player's turn accordingly ! // check change 
            {
                if (checkChange == true)
                {
                    rbtnPlayer1.Checked = true;
                    rbtnPlayer2.Checked = false;
                }
                else
                {
                    rbtnPlayer1.Checked = false;
                    rbtnPlayer2.Checked = true;
                }
                RollDice();              // callig  Rolldice method 
                if (checkChange == true) checkChange = false;
                else checkChange = true;
            }


            if(rbtnPlayer.Checked)    // if player's turn roll dice will be called again // this player is playing with program
            {
                RollDice();
            }

            if (rbtnProgramP.Checked == true)    // code for alternate player and program 
            {
                if(rbtnPlayer.Checked == true)
                {
                    rbtnPlayer.Checked = false;
                    rbtnProgram.Checked = true;
                }
            }

            if (rbtnPlayer1.Checked)     // code for instruction label showing player's turn and what to do
            {
                string p1 = Convert.ToString(tbx_name2.Text);
                lbl_Instructions.Text = "                   " + p1 + "'s turn ! please choose how many dice you want to roll !";

            }
            if (rbtnPlayer2.Checked == true)          // code for instruction label and player's turn & what to do 
            {
                string p2 = Convert.ToString(tbx_name1.Text);
                lbl_Instructions.Text = "                 " + p2 + "'s turn ! please choose how many dice you want to roll !";

            }

            string player1 = Convert.ToString(tbx_name1.Text);
            string player2 = Convert.ToString(tbx_name2.Text);

            if (number_of_1s == 3)     // if there are three 1s are printed then these rules will be implemented
            {
                if (rbtnPlayer1.Checked == true || rbtnPlayer.Checked == true)
                {
                    lbl_Instructions.Text = "Dead drop ! " + player1 + " looses the game " + player2 + " won the game !" + " New Game Starts !";
                    countp2++;   // count wins
                    btn_RollDice.Enabled = false;
                }
                if (rbtnPlayer2.Checked == true || rbtnProgram.Checked == true)
                {
                    lbl_Instructions.Text = "Dead drop ! " + player2 + " looses the game " + player1 + " won the game !" + " New Game Starts !";
                    countp1++;  // count wins 
                    btn_RollDice.Enabled = false;
                }
                lbl_p1_win.Text = countp1.ToString();  // win number will be printed accordingly 
                lbl_p2_win.Text = countp2.ToString();
            }
         


            if (number_of_1s >= 4)    // if there are more than four 1s then these rules will be implemented 
            {
                if (rbtnPlayer1.Checked == true || rbtnPlayer.Checked == true)          //if player 1 is playing this instructions will be show up accordingly
                {
                    lbl_Instructions.Text = "                      Boojum " + player1 + " won the game !" + " New Game Starts !";
                    countp1++;
                    btn_RollDice.Enabled = false;
                }
                if (rbtnPlayer2.Checked == true || rbtnProgram.Checked == true)
                {
                    lbl_Instructions.Text = "                        Boojum " + player2 + " won the game !" + " New Game Starts !";
                    countp2++;
                    btn_RollDice.Enabled = false;
                }
                lbl_p1_win.Text = countp1.ToString();
                lbl_p2_win.Text = countp2.ToString();
            }
         
            //code for player's reaches their goal score and win the game 

            try
            {
                int goalScore = Convert.ToInt32(tbx_GoalScore.Text);  
                 //int countp1 = 0;
                if (rbtnPlayer1.Checked == true  || rbtnPlayer.Checked == true)
                {

                    if (Score1 >= goalScore)    // if player1's score greater than or equal to goalscore then player 1 win the game 
                    {
                        lbl_Instructions.Text = "                          "  + player1 + " won the game !" + " New Game Starts !";
                        lbl_p1Score.Text = Score1.ToString();
                        countp1++;
                        btn_RollDice.Enabled = false;
                    }
                    lbl_p1_win.Text = countp1.ToString();   
                    Score1 = 0;
                }
               
                if (rbtnPlayer2.Checked == true || rbtnProgram.Checked == true)  
                {
                    if (Score2 >= goalScore) // player2's goalscore condition
                    {
                        lbl_Instructions.Text = "                             "  + player2 + " won the game !" + " New Game Starts !";
                        lbl_p2Score.Text = Score2.ToString();
                        countp2++;
                        btn_RollDice.Enabled = false;
                    }
                    lbl_p2_win.Text = countp2.ToString();
                    Score2 = 0;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("please Choose Goal Score");   // exception handling if players didn't choose their goal score ! 
            }

        }

        private void rbtnPlayer_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtnPlayerP.Checked == true)    //if player is playing with another player then some unnecessary controls needed to be handled, disabled or unchecked !
            {
                lbl_Instructions.Text = "                                   Please Enter Player Name ! ";
                lbl_player1_Name.Enabled = true;
                lbl_player2_Name.Enabled = true;
                tbx_name1.Enabled = true;
                tbx_name2.Enabled = true;
                Programgrp.Enabled = false;
                rbtnProgram.Checked = false;
                rbtnPlayer.Checked = false;
            }

        }

        private void rbtnProgramP_CheckedChanged(object sender, EventArgs e) //if player is playing with program  then some unnecessary controls needed to be handled, disabled or unchecked !
        {
            if (rbtnProgramP.Checked == true)   
            {
               
                players.Enabled = false;          // players group box will be disabled as it's not useful for program ann single player game
                rbtnPlayer1.Checked = false;
                rbtnPlayer2.Checked = false;
                lbl_Instructions.Text = "                  Please Enter Player Name ! & Goal Score ! ";
                lbl_player1_Name.Enabled = true;
                tbx_name1.Enabled = true;
                lbl_player2_Name.Enabled = true;
                tbx_name2.Enabled = true;
                tbx_name2.Text = "Program";
                lbl_goalScore.Enabled = true;
                tbx_GoalScore.Enabled = true; 
            }
        }

        private void rbtnPlayer1_CheckedChanged(object sender, EventArgs e)   // code for alternate turns for the player automatically 
        {
            if (checkChange == true)
            {
                rbtnPlayer1.Checked = true;
                rbtnPlayer2.Checked = false;
            }
            else
            {
                rbtnPlayer1.Checked = false;
                rbtnPlayer2.Checked = true;
            }
        }

        private void btnS_Click(object sender, EventArgs e)  // start button for start the game 
        {
            if (rbtnProgramP.Checked == true)   // if game is playing with program then program check box will appear 
            {
                
                rbtnPlayer.Checked = true;
                Programgrp.Enabled = true;

            }

            if (tbx_name1.Text == "") { MessageBox.Show("Please Enter Player 1 Name"); }        // instructions 
            if (rbtnPlayerP.Checked == true && tbx_name2.Text == "") { MessageBox.Show("Please Enter Player 2 Name"); } // if player2 name is empty the message box will be appear 
            try { int GoalScore = Convert.ToInt32(tbx_GoalScore.Text); }     
            catch (Exception) { MessageBox.Show("Please Enter valid Goal Score"); }
            if (rbtnPlayerP.Checked == true) 
            { 
            string player2 = Convert.ToString(tbx_name2.Text);
            lbl_Instructions.Text = "                             " + player2 + "'s turn ! Choose how many dice to roll !";
            lbl_acp2.Text = player2;
            players.Enabled = true;
            }
            btn_RollDice.Enabled = true;   // button roll dice will be enabled when you click start button

        }

        private void btn_NewStart_Click(object sender, EventArgs e)     // controls handled for the new game 
        {
            try
            {
                rbtnProgram.Enabled = true;                          // all controls will be set up for new game
                lbl_Instructions.Text = "                                Please choose goal score";
                tbx_GoalScore.Text = "";
                btn_RollDice.Enabled = false;
                btn_Start.Enabled = false;
                number_of_dice = 0;
                picbxDice_1.Image = diceImage[0];  // Using pictureBox to show Image of Dice
                picbxDice_2.Image = diceImage[0];      // All blanck dice images will be show up when user play new game
                picbxDice_3.Image = diceImage[0];
                picbxDice_4.Image = diceImage[0];
                picbxDice_5.Image = diceImage[0];
                picbxDice_6.Image = diceImage[0];
                NewGame();    // calling new game method here // score reset to 0 

            }
            catch (Exception)
            {
                MessageBox.Show("New game started ! Follow Instructions !");  //event handler
            }
        }


        private void tbx_name1_MouseLeave(object sender, EventArgs e)   // mouse leave event for players name 
        {
            string player1 = Convert.ToString(tbx_name1.Text);          // taking player 1's name to label to show name   
            lbl_acp1.Text = player1;                       //player enter names in text box it will appear in label accordingly !!
            if (player1 == "")              // if player name empty the message box will appear & give message to user
             MessageBox.Show("Please enter player 1 Name");
            
        }

        private void tbx_name2_MouseLeave(object sender, EventArgs e)  // mouse leave event for players name 
        {
            string player2 = Convert.ToString(tbx_name2.Text);        // same for player 2 as above // Name appear in label 
            lbl_acp2.Text = player2;
            lbl_Instructions.Text = "                                        Choose Goal Score ";
            if (player2 == " ") { lbl_Instructions.Text = "Choose Goal Score";  }    // if there's some name for player then this instruction will be show up
            if (player2 == "")      // if player 2 name is empty then this message box will appear 
                MessageBox.Show("Please enter player 2 Name");
            tbx_GoalScore.Enabled = true; 
            lbl_goalScore.Enabled = true;
        }

        private void tbx_GoalScore_MouseLeave(object sender, EventArgs e)
        {
            lbl_Instructions.Text = "                                   Press Start button to play game !";
            btn_Start.Enabled = true;
        }

        private void DiceGame_Load(object sender, EventArgs e)  // in the form 2 group boxes will be disapper as it's not usable for game user !
        {
            players.Visible = false;        // players group box will disappear 
            Programgrp.Visible = false;    //program groupbox will disappear
        }

        private void rbtnProgram_CheckedChanged(object sender, EventArgs e)
        {
            if(rbtnProgram.Checked == true)                  //if program is playing with user the following steps will be followed
            {
                {
                 
                    int goalScore = Convert.ToInt32(tbx_GoalScore.Text);  // taking user's input goal score
                    System.Threading.Thread.Sleep(1000);           // 1 second gap between player & program's dice rolled up
                    if (Score1 < goalScore )                  // if player score is less than goal score then program dice will be rolled up automatically otherwise not !
                    { RollDice();  }                   // rolling the dice !
                }
                rbtnProgram.Checked = false;
                rbtnPlayer.Checked = true;
            }
        }

        private void rbtnPlayer_CheckedChanged_1(object sender, EventArgs e)      //if player playing with program // showing label who's turn it is with player name .
        {
            if (rbtnPlayer.Checked == true)  // when player is playing rules will be implemented acordingly 
            {
                int goalScore = Convert.ToInt32(tbx_GoalScore.Text);   // taking user input goal score to compare with score 
                string p1 = Convert.ToString(tbx_name1.Text);             // taking input name of player 1
                if(Score2 < goalScore)       // if program score is less than goal score then following instruction will be printed and player will take the turn
                lbl_Instructions.Text = "                   " + p1 + "'s turn ! please choose how many dice you want to roll !";           // instructions

            }
            else
            {
                 // code for program's turn and program's name will be showing up in instruction label 
                string p2 = Convert.ToString(tbx_name2.Text);         // taking program's name to input in instruction !     
                lbl_Instructions.Text = "                 " + p2 + "'s turn ! please choose how many dice you want to roll !";  // if there's no players turn then program will take the turn and this instruction will be printed !

            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
        // Reference P2: Externally Dice Image
        // Purpose: one red colour dice Image so, form looks better  
        // Date: 5 March 2020
        // Source: Online Website / 
         //  https://www.kindpng.com/imgv/Tmwmbb_about-how-to-choose-a-good-board-game/

         // Assistance:  from online website, this help to get picture of dice that I was looking for the form

        }
    }
       
}
