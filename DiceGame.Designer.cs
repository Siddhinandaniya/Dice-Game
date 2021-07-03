﻿namespace ProjectDiceGame
{
    partial class DiceGame
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_RollDice = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbtnProgramP = new System.Windows.Forms.RadioButton();
            this.rbtnPlayerP = new System.Windows.Forms.RadioButton();
            this.players = new System.Windows.Forms.GroupBox();
            this.rbtnPlayer2 = new System.Windows.Forms.RadioButton();
            this.rbtnPlayer1 = new System.Windows.Forms.RadioButton();
            this.Programgrp = new System.Windows.Forms.GroupBox();
            this.rbtnProgram = new System.Windows.Forms.RadioButton();
            this.rbtnPlayer = new System.Windows.Forms.RadioButton();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.dice1p1 = new System.Windows.Forms.Label();
            this.lbl_p1Score = new System.Windows.Forms.Label();
            this.lbl_p1Cmnt = new System.Windows.Forms.Label();
            this.lbl_p2Score = new System.Windows.Forms.Label();
            this.lbl_p2Cmnt = new System.Windows.Forms.Label();
            this.lbl_player1_Name = new System.Windows.Forms.Label();
            this.tbx_name1 = new System.Windows.Forms.TextBox();
            this.lbl_player2_Name = new System.Windows.Forms.Label();
            this.tbx_name2 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.btn_Start = new System.Windows.Forms.Button();
            this.rbtn_roll1 = new System.Windows.Forms.RadioButton();
            this.rbtn_roll2 = new System.Windows.Forms.RadioButton();
            this.rbtn_roll3 = new System.Windows.Forms.RadioButton();
            this.rbtn_roll4 = new System.Windows.Forms.RadioButton();
            this.rbtn_roll5 = new System.Windows.Forms.RadioButton();
            this.rbtn_roll6 = new System.Windows.Forms.RadioButton();
            this.btn_NewStart = new System.Windows.Forms.Button();
            this.lbl_Instructions = new System.Windows.Forms.Label();
            this.grpbxChoose = new System.Windows.Forms.GroupBox();
            this.lbl_acp1 = new System.Windows.Forms.Label();
            this.lbl_acp2 = new System.Windows.Forms.Label();
            this.lbl_goalScore = new System.Windows.Forms.Label();
            this.tbx_GoalScore = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lbl_p2_win = new System.Windows.Forms.Label();
            this.lbl_p1_win = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.picbxDice_6 = new System.Windows.Forms.PictureBox();
            this.picbxDice_5 = new System.Windows.Forms.PictureBox();
            this.picbxDice_4 = new System.Windows.Forms.PictureBox();
            this.picbxDice_3 = new System.Windows.Forms.PictureBox();
            this.picbxDice_2 = new System.Windows.Forms.PictureBox();
            this.picbxDice_1 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            this.players.SuspendLayout();
            this.Programgrp.SuspendLayout();
            this.grpbxChoose.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picbxDice_6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picbxDice_5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picbxDice_4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picbxDice_3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picbxDice_2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picbxDice_1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_RollDice
            // 
            this.btn_RollDice.BackColor = System.Drawing.Color.Orange;
            this.btn_RollDice.Enabled = false;
            this.btn_RollDice.Font = new System.Drawing.Font("Segoe Script", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_RollDice.ForeColor = System.Drawing.Color.Black;
            this.btn_RollDice.Location = new System.Drawing.Point(630, 281);
            this.btn_RollDice.Name = "btn_RollDice";
            this.btn_RollDice.Size = new System.Drawing.Size(197, 48);
            this.btn_RollDice.TabIndex = 8;
            this.btn_RollDice.Text = "Roll Dice";
            this.btn_RollDice.UseVisualStyleBackColor = false;
            this.btn_RollDice.Click += new System.EventHandler(this.btn_RollDice_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.HighlightText;
            this.groupBox1.Controls.Add(this.rbtnProgramP);
            this.groupBox1.Controls.Add(this.rbtnPlayerP);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.Black;
            this.groupBox1.Location = new System.Drawing.Point(35, 26);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(220, 61);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Choose one";
            // 
            // rbtnProgramP
            // 
            this.rbtnProgramP.AutoSize = true;
            this.rbtnProgramP.Location = new System.Drawing.Point(117, 27);
            this.rbtnProgramP.Name = "rbtnProgramP";
            this.rbtnProgramP.Size = new System.Drawing.Size(87, 22);
            this.rbtnProgramP.TabIndex = 1;
            this.rbtnProgramP.Text = "Program";
            this.rbtnProgramP.UseVisualStyleBackColor = true;
            this.rbtnProgramP.CheckedChanged += new System.EventHandler(this.rbtnProgramP_CheckedChanged);
            // 
            // rbtnPlayerP
            // 
            this.rbtnPlayerP.AutoSize = true;
            this.rbtnPlayerP.Location = new System.Drawing.Point(28, 27);
            this.rbtnPlayerP.Name = "rbtnPlayerP";
            this.rbtnPlayerP.Size = new System.Drawing.Size(70, 22);
            this.rbtnPlayerP.TabIndex = 0;
            this.rbtnPlayerP.Text = "Player";
            this.rbtnPlayerP.UseVisualStyleBackColor = true;
            this.rbtnPlayerP.CheckedChanged += new System.EventHandler(this.rbtnPlayer_CheckedChanged);
            // 
            // players
            // 
            this.players.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.players.Controls.Add(this.rbtnPlayer2);
            this.players.Controls.Add(this.rbtnPlayer1);
            this.players.Enabled = false;
            this.players.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.players.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.players.Location = new System.Drawing.Point(711, 524);
            this.players.Name = "players";
            this.players.Size = new System.Drawing.Size(106, 81);
            this.players.TabIndex = 10;
            this.players.TabStop = false;
            this.players.Text = "Players";
            // 
            // rbtnPlayer2
            // 
            this.rbtnPlayer2.AutoSize = true;
            this.rbtnPlayer2.Location = new System.Drawing.Point(6, 48);
            this.rbtnPlayer2.Name = "rbtnPlayer2";
            this.rbtnPlayer2.Size = new System.Drawing.Size(81, 21);
            this.rbtnPlayer2.TabIndex = 1;
            this.rbtnPlayer2.Text = "Player 2";
            this.rbtnPlayer2.UseVisualStyleBackColor = true;
            // 
            // rbtnPlayer1
            // 
            this.rbtnPlayer1.AutoCheck = false;
            this.rbtnPlayer1.AutoSize = true;
            this.rbtnPlayer1.Checked = true;
            this.rbtnPlayer1.Location = new System.Drawing.Point(6, 20);
            this.rbtnPlayer1.Name = "rbtnPlayer1";
            this.rbtnPlayer1.Size = new System.Drawing.Size(81, 21);
            this.rbtnPlayer1.TabIndex = 0;
            this.rbtnPlayer1.TabStop = true;
            this.rbtnPlayer1.Text = "Player 1";
            this.rbtnPlayer1.UseVisualStyleBackColor = true;
            this.rbtnPlayer1.CheckedChanged += new System.EventHandler(this.rbtnPlayer1_CheckedChanged);
            // 
            // Programgrp
            // 
            this.Programgrp.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Programgrp.Controls.Add(this.rbtnProgram);
            this.Programgrp.Controls.Add(this.rbtnPlayer);
            this.Programgrp.Enabled = false;
            this.Programgrp.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Programgrp.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Programgrp.Location = new System.Drawing.Point(711, 436);
            this.Programgrp.Name = "Programgrp";
            this.Programgrp.Size = new System.Drawing.Size(106, 82);
            this.Programgrp.TabIndex = 11;
            this.Programgrp.TabStop = false;
            this.Programgrp.Text = "Program";
            // 
            // rbtnProgram
            // 
            this.rbtnProgram.AutoCheck = false;
            this.rbtnProgram.AutoSize = true;
            this.rbtnProgram.Location = new System.Drawing.Point(16, 51);
            this.rbtnProgram.Name = "rbtnProgram";
            this.rbtnProgram.Size = new System.Drawing.Size(83, 21);
            this.rbtnProgram.TabIndex = 1;
            this.rbtnProgram.Text = "Program";
            this.rbtnProgram.UseVisualStyleBackColor = true;
            this.rbtnProgram.CheckedChanged += new System.EventHandler(this.rbtnProgram_CheckedChanged);
            // 
            // rbtnPlayer
            // 
            this.rbtnPlayer.AutoSize = true;
            this.rbtnPlayer.Location = new System.Drawing.Point(16, 23);
            this.rbtnPlayer.Name = "rbtnPlayer";
            this.rbtnPlayer.Size = new System.Drawing.Size(69, 21);
            this.rbtnPlayer.TabIndex = 0;
            this.rbtnPlayer.Text = "Player";
            this.rbtnPlayer.UseVisualStyleBackColor = true;
            this.rbtnPlayer.CheckedChanged += new System.EventHandler(this.rbtnPlayer_CheckedChanged_1);
            // 
            // label12
            // 
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label12.Location = new System.Drawing.Point(174, 482);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(72, 30);
            this.label12.TabIndex = 0;
            this.label12.Text = "Scores";
            // 
            // label13
            // 
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label13.Location = new System.Drawing.Point(379, 485);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(103, 33);
            this.label13.TabIndex = 0;
            this.label13.Text = "Comment";
            // 
            // dice1p1
            // 
            this.dice1p1.AutoSize = true;
            this.dice1p1.Location = new System.Drawing.Point(204, 164);
            this.dice1p1.Name = "dice1p1";
            this.dice1p1.Size = new System.Drawing.Size(0, 17);
            this.dice1p1.TabIndex = 20;
            // 
            // lbl_p1Score
            // 
            this.lbl_p1Score.AutoSize = true;
            this.lbl_p1Score.Font = new System.Drawing.Font("Arial", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_p1Score.ForeColor = System.Drawing.SystemColors.Desktop;
            this.lbl_p1Score.Location = new System.Drawing.Point(178, 540);
            this.lbl_p1Score.Name = "lbl_p1Score";
            this.lbl_p1Score.Size = new System.Drawing.Size(51, 55);
            this.lbl_p1Score.TabIndex = 26;
            this.lbl_p1Score.Text = "0";
            this.lbl_p1Score.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_p1Cmnt
            // 
            this.lbl_p1Cmnt.AutoSize = true;
            this.lbl_p1Cmnt.BackColor = System.Drawing.SystemColors.HighlightText;
            this.lbl_p1Cmnt.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_p1Cmnt.ForeColor = System.Drawing.SystemColors.Desktop;
            this.lbl_p1Cmnt.Location = new System.Drawing.Point(379, 555);
            this.lbl_p1Cmnt.Name = "lbl_p1Cmnt";
            this.lbl_p1Cmnt.Size = new System.Drawing.Size(34, 23);
            this.lbl_p1Cmnt.TabIndex = 27;
            this.lbl_p1Cmnt.Text = "***";
            this.lbl_p1Cmnt.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_p2Score
            // 
            this.lbl_p2Score.AutoSize = true;
            this.lbl_p2Score.Font = new System.Drawing.Font("Arial", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_p2Score.ForeColor = System.Drawing.SystemColors.Desktop;
            this.lbl_p2Score.Location = new System.Drawing.Point(1009, 533);
            this.lbl_p2Score.Name = "lbl_p2Score";
            this.lbl_p2Score.Size = new System.Drawing.Size(51, 55);
            this.lbl_p2Score.TabIndex = 38;
            this.lbl_p2Score.Text = "0";
            this.lbl_p2Score.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_p2Cmnt
            // 
            this.lbl_p2Cmnt.AutoSize = true;
            this.lbl_p2Cmnt.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_p2Cmnt.ForeColor = System.Drawing.SystemColors.Desktop;
            this.lbl_p2Cmnt.Location = new System.Drawing.Point(1219, 555);
            this.lbl_p2Cmnt.Name = "lbl_p2Cmnt";
            this.lbl_p2Cmnt.Size = new System.Drawing.Size(31, 28);
            this.lbl_p2Cmnt.TabIndex = 39;
            this.lbl_p2Cmnt.Text = "***";
            this.lbl_p2Cmnt.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbl_p2Cmnt.UseCompatibleTextRendering = true;
            // 
            // lbl_player1_Name
            // 
            this.lbl_player1_Name.AutoSize = true;
            this.lbl_player1_Name.Enabled = false;
            this.lbl_player1_Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_player1_Name.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lbl_player1_Name.Location = new System.Drawing.Point(42, 115);
            this.lbl_player1_Name.Name = "lbl_player1_Name";
            this.lbl_player1_Name.Size = new System.Drawing.Size(105, 18);
            this.lbl_player1_Name.TabIndex = 45;
            this.lbl_player1_Name.Text = "Player 1 Name";
            // 
            // tbx_name1
            // 
            this.tbx_name1.Enabled = false;
            this.tbx_name1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbx_name1.Location = new System.Drawing.Point(166, 110);
            this.tbx_name1.Name = "tbx_name1";
            this.tbx_name1.Size = new System.Drawing.Size(102, 24);
            this.tbx_name1.TabIndex = 46;
            this.tbx_name1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbx_name1.MouseLeave += new System.EventHandler(this.tbx_name1_MouseLeave);
            // 
            // lbl_player2_Name
            // 
            this.lbl_player2_Name.AutoSize = true;
            this.lbl_player2_Name.Enabled = false;
            this.lbl_player2_Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_player2_Name.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lbl_player2_Name.Location = new System.Drawing.Point(42, 156);
            this.lbl_player2_Name.Name = "lbl_player2_Name";
            this.lbl_player2_Name.Size = new System.Drawing.Size(105, 18);
            this.lbl_player2_Name.TabIndex = 47;
            this.lbl_player2_Name.Text = "Player 2 Name";
            // 
            // tbx_name2
            // 
            this.tbx_name2.Enabled = false;
            this.tbx_name2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbx_name2.Location = new System.Drawing.Point(166, 153);
            this.tbx_name2.Name = "tbx_name2";
            this.tbx_name2.Size = new System.Drawing.Size(102, 24);
            this.tbx_name2.TabIndex = 48;
            this.tbx_name2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbx_name2.MouseLeave += new System.EventHandler(this.tbx_name2_MouseLeave);
            // 
            // label8
            // 
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label8.Location = new System.Drawing.Point(999, 480);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(72, 30);
            this.label8.TabIndex = 51;
            this.label8.Text = "Scores";
            // 
            // label10
            // 
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label10.Location = new System.Drawing.Point(1215, 482);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(120, 33);
            this.label10.TabIndex = 53;
            this.label10.Text = "Comment";
            // 
            // btn_Start
            // 
            this.btn_Start.BackColor = System.Drawing.SystemColors.Info;
            this.btn_Start.Enabled = false;
            this.btn_Start.ForeColor = System.Drawing.SystemColors.Desktop;
            this.btn_Start.Location = new System.Drawing.Point(166, 259);
            this.btn_Start.Name = "btn_Start";
            this.btn_Start.Size = new System.Drawing.Size(99, 34);
            this.btn_Start.TabIndex = 0;
            this.btn_Start.Text = "Start ";
            this.btn_Start.UseVisualStyleBackColor = false;
            this.btn_Start.Click += new System.EventHandler(this.btnS_Click);
            // 
            // rbtn_roll1
            // 
            this.rbtn_roll1.AutoSize = true;
            this.rbtn_roll1.BackColor = System.Drawing.SystemColors.HighlightText;
            this.rbtn_roll1.ForeColor = System.Drawing.SystemColors.Desktop;
            this.rbtn_roll1.Location = new System.Drawing.Point(24, 27);
            this.rbtn_roll1.Name = "rbtn_roll1";
            this.rbtn_roll1.Size = new System.Drawing.Size(37, 21);
            this.rbtn_roll1.TabIndex = 56;
            this.rbtn_roll1.Text = "1";
            this.rbtn_roll1.UseVisualStyleBackColor = false;
            // 
            // rbtn_roll2
            // 
            this.rbtn_roll2.AutoSize = true;
            this.rbtn_roll2.BackColor = System.Drawing.SystemColors.HighlightText;
            this.rbtn_roll2.ForeColor = System.Drawing.SystemColors.Desktop;
            this.rbtn_roll2.Location = new System.Drawing.Point(67, 27);
            this.rbtn_roll2.Name = "rbtn_roll2";
            this.rbtn_roll2.Size = new System.Drawing.Size(37, 21);
            this.rbtn_roll2.TabIndex = 57;
            this.rbtn_roll2.TabStop = true;
            this.rbtn_roll2.Text = "2";
            this.rbtn_roll2.UseVisualStyleBackColor = false;
            // 
            // rbtn_roll3
            // 
            this.rbtn_roll3.AutoSize = true;
            this.rbtn_roll3.BackColor = System.Drawing.SystemColors.HighlightText;
            this.rbtn_roll3.ForeColor = System.Drawing.SystemColors.Desktop;
            this.rbtn_roll3.Location = new System.Drawing.Point(119, 27);
            this.rbtn_roll3.Name = "rbtn_roll3";
            this.rbtn_roll3.Size = new System.Drawing.Size(37, 21);
            this.rbtn_roll3.TabIndex = 58;
            this.rbtn_roll3.TabStop = true;
            this.rbtn_roll3.Text = "3";
            this.rbtn_roll3.UseVisualStyleBackColor = false;
            // 
            // rbtn_roll4
            // 
            this.rbtn_roll4.AutoSize = true;
            this.rbtn_roll4.BackColor = System.Drawing.SystemColors.HighlightText;
            this.rbtn_roll4.ForeColor = System.Drawing.SystemColors.Desktop;
            this.rbtn_roll4.Location = new System.Drawing.Point(171, 27);
            this.rbtn_roll4.Name = "rbtn_roll4";
            this.rbtn_roll4.Size = new System.Drawing.Size(37, 21);
            this.rbtn_roll4.TabIndex = 59;
            this.rbtn_roll4.TabStop = true;
            this.rbtn_roll4.Text = "4";
            this.rbtn_roll4.UseVisualStyleBackColor = false;
            // 
            // rbtn_roll5
            // 
            this.rbtn_roll5.AutoSize = true;
            this.rbtn_roll5.BackColor = System.Drawing.SystemColors.HighlightText;
            this.rbtn_roll5.ForeColor = System.Drawing.SystemColors.Desktop;
            this.rbtn_roll5.Location = new System.Drawing.Point(226, 27);
            this.rbtn_roll5.Name = "rbtn_roll5";
            this.rbtn_roll5.Size = new System.Drawing.Size(37, 21);
            this.rbtn_roll5.TabIndex = 60;
            this.rbtn_roll5.TabStop = true;
            this.rbtn_roll5.Text = "5";
            this.rbtn_roll5.UseVisualStyleBackColor = false;
            // 
            // rbtn_roll6
            // 
            this.rbtn_roll6.AutoSize = true;
            this.rbtn_roll6.BackColor = System.Drawing.SystemColors.HighlightText;
            this.rbtn_roll6.ForeColor = System.Drawing.SystemColors.Desktop;
            this.rbtn_roll6.Location = new System.Drawing.Point(280, 27);
            this.rbtn_roll6.Name = "rbtn_roll6";
            this.rbtn_roll6.Size = new System.Drawing.Size(37, 21);
            this.rbtn_roll6.TabIndex = 61;
            this.rbtn_roll6.TabStop = true;
            this.rbtn_roll6.Text = "6";
            this.rbtn_roll6.UseVisualStyleBackColor = false;
            // 
            // btn_NewStart
            // 
            this.btn_NewStart.BackColor = System.Drawing.SystemColors.Info;
            this.btn_NewStart.ForeColor = System.Drawing.SystemColors.Desktop;
            this.btn_NewStart.Location = new System.Drawing.Point(664, 611);
            this.btn_NewStart.Name = "btn_NewStart";
            this.btn_NewStart.Size = new System.Drawing.Size(134, 42);
            this.btn_NewStart.TabIndex = 62;
            this.btn_NewStart.Text = "New Game";
            this.btn_NewStart.UseVisualStyleBackColor = false;
            this.btn_NewStart.Click += new System.EventHandler(this.btn_NewStart_Click);
            // 
            // lbl_Instructions
            // 
            this.lbl_Instructions.AutoSize = true;
            this.lbl_Instructions.BackColor = System.Drawing.SystemColors.HighlightText;
            this.lbl_Instructions.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Instructions.ForeColor = System.Drawing.SystemColors.Desktop;
            this.lbl_Instructions.Location = new System.Drawing.Point(253, 732);
            this.lbl_Instructions.Name = "lbl_Instructions";
            this.lbl_Instructions.Size = new System.Drawing.Size(998, 35);
            this.lbl_Instructions.TabIndex = 63;
            this.lbl_Instructions.Text = "\"Please choose one ! you want to play this game with program or player ? \"";
            this.lbl_Instructions.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // grpbxChoose
            // 
            this.grpbxChoose.BackColor = System.Drawing.SystemColors.HighlightText;
            this.grpbxChoose.Controls.Add(this.rbtn_roll1);
            this.grpbxChoose.Controls.Add(this.rbtn_roll2);
            this.grpbxChoose.Controls.Add(this.rbtn_roll3);
            this.grpbxChoose.Controls.Add(this.rbtn_roll6);
            this.grpbxChoose.Controls.Add(this.rbtn_roll4);
            this.grpbxChoose.Controls.Add(this.rbtn_roll5);
            this.grpbxChoose.Location = new System.Drawing.Point(563, 193);
            this.grpbxChoose.Name = "grpbxChoose";
            this.grpbxChoose.Size = new System.Drawing.Size(346, 61);
            this.grpbxChoose.TabIndex = 64;
            this.grpbxChoose.TabStop = false;
            this.grpbxChoose.Text = "Choose Dice Roll";
            // 
            // lbl_acp1
            // 
            this.lbl_acp1.AutoSize = true;
            this.lbl_acp1.Font = new System.Drawing.Font("Calibri", 18F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic)
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_acp1.ForeColor = System.Drawing.SystemColors.Desktop;
            this.lbl_acp1.Location = new System.Drawing.Point(252, 328);
            this.lbl_acp1.Name = "lbl_acp1";
            this.lbl_acp1.Size = new System.Drawing.Size(118, 37);
            this.lbl_acp1.TabIndex = 66;
            this.lbl_acp1.Text = "Player 1";
            this.lbl_acp1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_acp2
            // 
            this.lbl_acp2.AutoSize = true;
            this.lbl_acp2.Font = new System.Drawing.Font("Calibri", 18F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic)
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_acp2.ForeColor = System.Drawing.SystemColors.Desktop;
            this.lbl_acp2.Location = new System.Drawing.Point(1056, 338);
            this.lbl_acp2.Name = "lbl_acp2";
            this.lbl_acp2.Size = new System.Drawing.Size(118, 37);
            this.lbl_acp2.TabIndex = 67;
            this.lbl_acp2.Text = "Player 2";
            this.lbl_acp2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_goalScore
            // 
            this.lbl_goalScore.AutoSize = true;
            this.lbl_goalScore.BackColor = System.Drawing.SystemColors.HighlightText;
            this.lbl_goalScore.Enabled = false;
            this.lbl_goalScore.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_goalScore.ForeColor = System.Drawing.SystemColors.Desktop;
            this.lbl_goalScore.Location = new System.Drawing.Point(41, 193);
            this.lbl_goalScore.Name = "lbl_goalScore";
            this.lbl_goalScore.Size = new System.Drawing.Size(99, 24);
            this.lbl_goalScore.TabIndex = 68;
            this.lbl_goalScore.Text = "Goal Score";
            // 
            // tbx_GoalScore
            // 
            this.tbx_GoalScore.Enabled = false;
            this.tbx_GoalScore.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbx_GoalScore.Location = new System.Drawing.Point(166, 192);
            this.tbx_GoalScore.Name = "tbx_GoalScore";
            this.tbx_GoalScore.Size = new System.Drawing.Size(102, 39);
            this.tbx_GoalScore.TabIndex = 69;
            this.tbx_GoalScore.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbx_GoalScore.MouseLeave += new System.EventHandler(this.tbx_GoalScore_MouseLeave);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label2.Location = new System.Drawing.Point(1057, 405);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 27);
            this.label2.TabIndex = 70;
            this.label2.Text = "win:";
            // 
            // lbl_p2_win
            // 
            this.lbl_p2_win.AutoSize = true;
            this.lbl_p2_win.Font = new System.Drawing.Font("Arial", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_p2_win.ForeColor = System.Drawing.Color.Red;
            this.lbl_p2_win.Location = new System.Drawing.Point(1118, 392);
            this.lbl_p2_win.Name = "lbl_p2_win";
            this.lbl_p2_win.Size = new System.Drawing.Size(51, 55);
            this.lbl_p2_win.TabIndex = 71;
            this.lbl_p2_win.Text = "0";
            this.lbl_p2_win.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_p1_win
            // 
            this.lbl_p1_win.AutoSize = true;
            this.lbl_p1_win.Font = new System.Drawing.Font("Arial", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_p1_win.ForeColor = System.Drawing.Color.Red;
            this.lbl_p1_win.Location = new System.Drawing.Point(315, 382);
            this.lbl_p1_win.Name = "lbl_p1_win";
            this.lbl_p1_win.Size = new System.Drawing.Size(51, 55);
            this.lbl_p1_win.TabIndex = 73;
            this.lbl_p1_win.Text = "0";
            this.lbl_p1_win.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label5.Location = new System.Drawing.Point(254, 395);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 27);
            this.label5.TabIndex = 72;
            this.label5.Text = "win:";
            // 
            // picbxDice_6
            // 
            this.picbxDice_6.Location = new System.Drawing.Point(934, 53);
            this.picbxDice_6.Name = "picbxDice_6";
            this.picbxDice_6.Size = new System.Drawing.Size(70, 60);
            this.picbxDice_6.TabIndex = 5;
            this.picbxDice_6.TabStop = false;
            // 
            // picbxDice_5
            // 
            this.picbxDice_5.Location = new System.Drawing.Point(839, 53);
            this.picbxDice_5.Name = "picbxDice_5";
            this.picbxDice_5.Size = new System.Drawing.Size(70, 60);
            this.picbxDice_5.TabIndex = 4;
            this.picbxDice_5.TabStop = false;
            // 
            // picbxDice_4
            // 
            this.picbxDice_4.Location = new System.Drawing.Point(740, 53);
            this.picbxDice_4.Name = "picbxDice_4";
            this.picbxDice_4.Size = new System.Drawing.Size(70, 60);
            this.picbxDice_4.TabIndex = 3;
            this.picbxDice_4.TabStop = false;
            // 
            // picbxDice_3
            // 
            this.picbxDice_3.Location = new System.Drawing.Point(642, 53);
            this.picbxDice_3.Name = "picbxDice_3";
            this.picbxDice_3.Size = new System.Drawing.Size(70, 60);
            this.picbxDice_3.TabIndex = 2;
            this.picbxDice_3.TabStop = false;
            // 
            // picbxDice_2
            // 
            this.picbxDice_2.Location = new System.Drawing.Point(547, 53);
            this.picbxDice_2.Name = "picbxDice_2";
            this.picbxDice_2.Size = new System.Drawing.Size(70, 60);
            this.picbxDice_2.TabIndex = 1;
            this.picbxDice_2.TabStop = false;
            // 
            // picbxDice_1
            // 
            this.picbxDice_1.Location = new System.Drawing.Point(454, 53);
            this.picbxDice_1.Name = "picbxDice_1";
            this.picbxDice_1.Size = new System.Drawing.Size(70, 60);
            this.picbxDice_1.TabIndex = 0;
            this.picbxDice_1.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ProjectDiceGame.Properties.Resources.rS;
            this.pictureBox1.Location = new System.Drawing.Point(1048, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(347, 219);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 74;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // DiceGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HighlightText;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1600, 853);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lbl_p1_win);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lbl_p2_win);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbx_GoalScore);
            this.Controls.Add(this.lbl_goalScore);
            this.Controls.Add(this.lbl_acp2);
            this.Controls.Add(this.lbl_acp1);
            this.Controls.Add(this.grpbxChoose);
            this.Controls.Add(this.lbl_Instructions);
            this.Controls.Add(this.btn_NewStart);
            this.Controls.Add(this.btn_Start);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.tbx_name2);
            this.Controls.Add(this.lbl_player2_Name);
            this.Controls.Add(this.tbx_name1);
            this.Controls.Add(this.lbl_player1_Name);
            this.Controls.Add(this.lbl_p2Cmnt);
            this.Controls.Add(this.lbl_p2Score);
            this.Controls.Add(this.lbl_p1Cmnt);
            this.Controls.Add(this.lbl_p1Score);
            this.Controls.Add(this.dice1p1);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.Programgrp);
            this.Controls.Add(this.players);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btn_RollDice);
            this.Controls.Add(this.picbxDice_6);
            this.Controls.Add(this.picbxDice_5);
            this.Controls.Add(this.picbxDice_4);
            this.Controls.Add(this.picbxDice_3);
            this.Controls.Add(this.picbxDice_2);
            this.Controls.Add(this.picbxDice_1);
            this.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1618, 900);
            this.MinimumSize = new System.Drawing.Size(1618, 900);
            this.Name = "DiceGame";
            this.Text = "Six Of One (Dice Game)";
            this.Load += new System.EventHandler(this.DiceGame_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.players.ResumeLayout(false);
            this.players.PerformLayout();
            this.Programgrp.ResumeLayout(false);
            this.Programgrp.PerformLayout();
            this.grpbxChoose.ResumeLayout(false);
            this.grpbxChoose.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picbxDice_6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picbxDice_5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picbxDice_4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picbxDice_3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picbxDice_2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picbxDice_1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picbxDice_1;
        private System.Windows.Forms.PictureBox picbxDice_2;
        private System.Windows.Forms.PictureBox picbxDice_3;
        private System.Windows.Forms.PictureBox picbxDice_4;
        private System.Windows.Forms.PictureBox picbxDice_5;
        private System.Windows.Forms.PictureBox picbxDice_6;
        private System.Windows.Forms.Button btn_RollDice;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbtnProgramP;
        private System.Windows.Forms.RadioButton rbtnPlayerP;
        private System.Windows.Forms.GroupBox players;
        private System.Windows.Forms.RadioButton rbtnPlayer2;
        private System.Windows.Forms.RadioButton rbtnPlayer1;
        private System.Windows.Forms.GroupBox Programgrp;
        private System.Windows.Forms.RadioButton rbtnProgram;
        private System.Windows.Forms.RadioButton rbtnPlayer;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label dice1p1;
        private System.Windows.Forms.Label lbl_p1Score;
        private System.Windows.Forms.Label lbl_p1Cmnt;
        private System.Windows.Forms.Label lbl_p2Score;
        private System.Windows.Forms.Label lbl_p2Cmnt;
        private System.Windows.Forms.Label lbl_player1_Name;
        private System.Windows.Forms.TextBox tbx_name1;
        private System.Windows.Forms.Label lbl_player2_Name;
        private System.Windows.Forms.TextBox tbx_name2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btn_Start;
        private System.Windows.Forms.RadioButton rbtn_roll1;
        private System.Windows.Forms.RadioButton rbtn_roll2;
        private System.Windows.Forms.RadioButton rbtn_roll3;
        private System.Windows.Forms.RadioButton rbtn_roll4;
        private System.Windows.Forms.RadioButton rbtn_roll5;
        private System.Windows.Forms.RadioButton rbtn_roll6;
        private System.Windows.Forms.Button btn_NewStart;
        private System.Windows.Forms.Label lbl_Instructions;
        private System.Windows.Forms.GroupBox grpbxChoose;
        private System.Windows.Forms.Label lbl_acp1;
        private System.Windows.Forms.Label lbl_acp2;
        private System.Windows.Forms.Label lbl_goalScore;
        private System.Windows.Forms.TextBox tbx_GoalScore;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbl_p2_win;
        private System.Windows.Forms.Label lbl_p1_win;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

