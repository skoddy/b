namespace Quiz
{
    partial class Form1
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.tbDisplayName = new System.Windows.Forms.TextBox();
            this.btnSignIn = new System.Windows.Forms.Button();
            this.btnSignUp = new System.Windows.Forms.Button();
            this.tbPassword = new System.Windows.Forms.TextBox();
            this.panAuth = new System.Windows.Forms.Panel();
            this.btnAdmin = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.panChooseCategory = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.grpChooseCategory = new System.Windows.Forms.GroupBox();
            this.btnGameStart = new System.Windows.Forms.Button();
            this.panGame = new System.Windows.Forms.Panel();
            this.lblMaxQuestions = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnHighScores = new System.Windows.Forms.Button();
            this.btnAnswer = new System.Windows.Forms.Button();
            this.lblResult = new System.Windows.Forms.Label();
            this.lblScore = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.grpQuestion = new System.Windows.Forms.GroupBox();
            this.pbQuestion = new System.Windows.Forms.PictureBox();
            this.lblQuestion = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnNextQuestion = new System.Windows.Forms.Button();
            this.grpAnswers = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lblQuestionNumber = new System.Windows.Forms.Label();
            this.panHighScores = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.btnNewGame = new System.Windows.Forms.Button();
            this.grpHighscores = new System.Windows.Forms.GroupBox();
            this.lblHSNumber = new System.Windows.Forms.Label();
            this.lblHSName = new System.Windows.Forms.Label();
            this.lblHSScore = new System.Windows.Forms.Label();
            this.lblHSDate = new System.Windows.Forms.Label();
            this.panAuth.SuspendLayout();
            this.panChooseCategory.SuspendLayout();
            this.panGame.SuspendLayout();
            this.grpQuestion.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbQuestion)).BeginInit();
            this.panHighScores.SuspendLayout();
            this.grpHighscores.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbDisplayName
            // 
            this.tbDisplayName.Location = new System.Drawing.Point(107, 174);
            this.tbDisplayName.Name = "tbDisplayName";
            this.tbDisplayName.Size = new System.Drawing.Size(100, 20);
            this.tbDisplayName.TabIndex = 1;
            // 
            // btnSignIn
            // 
            this.btnSignIn.Location = new System.Drawing.Point(107, 226);
            this.btnSignIn.Name = "btnSignIn";
            this.btnSignIn.Size = new System.Drawing.Size(100, 23);
            this.btnSignIn.TabIndex = 3;
            this.btnSignIn.Text = "Anmelden";
            this.btnSignIn.UseVisualStyleBackColor = true;
            this.btnSignIn.Click += new System.EventHandler(this.btnSignIn_Click);
            // 
            // btnSignUp
            // 
            this.btnSignUp.Location = new System.Drawing.Point(107, 255);
            this.btnSignUp.Name = "btnSignUp";
            this.btnSignUp.Size = new System.Drawing.Size(100, 23);
            this.btnSignUp.TabIndex = 4;
            this.btnSignUp.Text = "Neues Konto";
            this.btnSignUp.UseVisualStyleBackColor = true;
            this.btnSignUp.Click += new System.EventHandler(this.btnSignUp_Click);
            // 
            // tbPassword
            // 
            this.tbPassword.Location = new System.Drawing.Point(107, 200);
            this.tbPassword.Name = "tbPassword";
            this.tbPassword.Size = new System.Drawing.Size(100, 20);
            this.tbPassword.TabIndex = 2;
            this.tbPassword.UseSystemPasswordChar = true;
            // 
            // panAuth
            // 
            this.panAuth.Controls.Add(this.btnAdmin);
            this.panAuth.Controls.Add(this.label4);
            this.panAuth.Controls.Add(this.tbDisplayName);
            this.panAuth.Controls.Add(this.tbPassword);
            this.panAuth.Controls.Add(this.btnSignIn);
            this.panAuth.Controls.Add(this.btnSignUp);
            this.panAuth.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panAuth.Location = new System.Drawing.Point(0, 0);
            this.panAuth.Name = "panAuth";
            this.panAuth.Size = new System.Drawing.Size(318, 509);
            this.panAuth.TabIndex = 8;
            this.panAuth.Visible = false;
            // 
            // btnAdmin
            // 
            this.btnAdmin.Location = new System.Drawing.Point(270, 474);
            this.btnAdmin.Name = "btnAdmin";
            this.btnAdmin.Size = new System.Drawing.Size(19, 23);
            this.btnAdmin.TabIndex = 9;
            this.btnAdmin.Text = "<";
            this.btnAdmin.UseVisualStyleBackColor = true;
            this.btnAdmin.Click += new System.EventHandler(this.btnAdmin_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Dock = System.Windows.Forms.DockStyle.Top;
            this.label4.Font = new System.Drawing.Font("Palatino Linotype", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(0, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(302, 86);
            this.label4.TabIndex = 8;
            this.label4.Text = "Das Quiz";
            // 
            // panChooseCategory
            // 
            this.panChooseCategory.Controls.Add(this.label1);
            this.panChooseCategory.Controls.Add(this.grpChooseCategory);
            this.panChooseCategory.Controls.Add(this.btnGameStart);
            this.panChooseCategory.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panChooseCategory.Location = new System.Drawing.Point(0, 0);
            this.panChooseCategory.Name = "panChooseCategory";
            this.panChooseCategory.Size = new System.Drawing.Size(318, 509);
            this.panChooseCategory.TabIndex = 9;
            this.panChooseCategory.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(50, 125);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(157, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Bitte wählen Sie eine Kategorie.";
            // 
            // grpChooseCategory
            // 
            this.grpChooseCategory.Location = new System.Drawing.Point(53, 153);
            this.grpChooseCategory.Name = "grpChooseCategory";
            this.grpChooseCategory.Size = new System.Drawing.Size(58, 41);
            this.grpChooseCategory.TabIndex = 5;
            this.grpChooseCategory.TabStop = false;
            this.grpChooseCategory.Text = "Spiel";
            // 
            // btnGameStart
            // 
            this.btnGameStart.Location = new System.Drawing.Point(197, 474);
            this.btnGameStart.Name = "btnGameStart";
            this.btnGameStart.Size = new System.Drawing.Size(90, 23);
            this.btnGameStart.TabIndex = 4;
            this.btnGameStart.Text = "Spiel Starten";
            this.btnGameStart.UseVisualStyleBackColor = true;
            this.btnGameStart.Click += new System.EventHandler(this.btnGameStart_Click);
            // 
            // panGame
            // 
            this.panGame.Controls.Add(this.lblMaxQuestions);
            this.panGame.Controls.Add(this.label5);
            this.panGame.Controls.Add(this.btnHighScores);
            this.panGame.Controls.Add(this.btnAnswer);
            this.panGame.Controls.Add(this.lblResult);
            this.panGame.Controls.Add(this.lblScore);
            this.panGame.Controls.Add(this.label3);
            this.panGame.Controls.Add(this.grpQuestion);
            this.panGame.Controls.Add(this.btnCancel);
            this.panGame.Controls.Add(this.btnNextQuestion);
            this.panGame.Controls.Add(this.grpAnswers);
            this.panGame.Controls.Add(this.label2);
            this.panGame.Controls.Add(this.lblQuestionNumber);
            this.panGame.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panGame.Location = new System.Drawing.Point(0, 0);
            this.panGame.Name = "panGame";
            this.panGame.Size = new System.Drawing.Size(318, 509);
            this.panGame.TabIndex = 10;
            this.panGame.Visible = false;
            // 
            // lblMaxQuestions
            // 
            this.lblMaxQuestions.AutoSize = true;
            this.lblMaxQuestions.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaxQuestions.Location = new System.Drawing.Point(167, 9);
            this.lblMaxQuestions.Name = "lblMaxQuestions";
            this.lblMaxQuestions.Size = new System.Drawing.Size(41, 13);
            this.lblMaxQuestions.TabIndex = 14;
            this.lblMaxQuestions.Text = "label6";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(136, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(25, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "von";
            // 
            // btnHighScores
            // 
            this.btnHighScores.Enabled = false;
            this.btnHighScores.Location = new System.Drawing.Point(116, 474);
            this.btnHighScores.Name = "btnHighScores";
            this.btnHighScores.Size = new System.Drawing.Size(75, 23);
            this.btnHighScores.TabIndex = 3;
            this.btnHighScores.Text = "Bestenliste";
            this.btnHighScores.UseVisualStyleBackColor = true;
            this.btnHighScores.Click += new System.EventHandler(this.btnHighScores_Click);
            // 
            // btnAnswer
            // 
            this.btnAnswer.Location = new System.Drawing.Point(206, 342);
            this.btnAnswer.Name = "btnAnswer";
            this.btnAnswer.Size = new System.Drawing.Size(75, 23);
            this.btnAnswer.TabIndex = 1;
            this.btnAnswer.Text = "Antworten";
            this.btnAnswer.UseVisualStyleBackColor = true;
            this.btnAnswer.Click += new System.EventHandler(this.btnAnswer_Click);
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Location = new System.Drawing.Point(16, 424);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(35, 13);
            this.lblResult.TabIndex = 10;
            this.lblResult.Text = "label4";
            // 
            // lblScore
            // 
            this.lblScore.AutoSize = true;
            this.lblScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblScore.Location = new System.Drawing.Point(62, 34);
            this.lblScore.Name = "lblScore";
            this.lblScore.Size = new System.Drawing.Size(14, 13);
            this.lblScore.TabIndex = 9;
            this.lblScore.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 34);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Punkte:";
            // 
            // grpQuestion
            // 
            this.grpQuestion.Controls.Add(this.pbQuestion);
            this.grpQuestion.Controls.Add(this.lblQuestion);
            this.grpQuestion.Location = new System.Drawing.Point(15, 73);
            this.grpQuestion.Name = "grpQuestion";
            this.grpQuestion.Size = new System.Drawing.Size(266, 100);
            this.grpQuestion.TabIndex = 7;
            this.grpQuestion.TabStop = false;
            this.grpQuestion.Text = "Frage";
            // 
            // pbQuestion
            // 
            this.pbQuestion.Location = new System.Drawing.Point(198, 10);
            this.pbQuestion.Name = "pbQuestion";
            this.pbQuestion.Size = new System.Drawing.Size(64, 64);
            this.pbQuestion.TabIndex = 1;
            this.pbQuestion.TabStop = false;
            // 
            // lblQuestion
            // 
            this.lblQuestion.AutoSize = true;
            this.lblQuestion.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblQuestion.Location = new System.Drawing.Point(3, 16);
            this.lblQuestion.MaximumSize = new System.Drawing.Size(150, 0);
            this.lblQuestion.Name = "lblQuestion";
            this.lblQuestion.Size = new System.Drawing.Size(35, 13);
            this.lblQuestion.TabIndex = 0;
            this.lblQuestion.Text = "label3";
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(16, 474);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 4;
            this.btnCancel.TabStop = false;
            this.btnCancel.Text = "Abbrechen";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnNextQuestion
            // 
            this.btnNextQuestion.Enabled = false;
            this.btnNextQuestion.Location = new System.Drawing.Point(206, 474);
            this.btnNextQuestion.Name = "btnNextQuestion";
            this.btnNextQuestion.Size = new System.Drawing.Size(75, 23);
            this.btnNextQuestion.TabIndex = 2;
            this.btnNextQuestion.Text = "Weiter";
            this.btnNextQuestion.UseVisualStyleBackColor = true;
            this.btnNextQuestion.Click += new System.EventHandler(this.btnNextQuestion_Click);
            // 
            // grpAnswers
            // 
            this.grpAnswers.Location = new System.Drawing.Point(16, 176);
            this.grpAnswers.Name = "grpAnswers";
            this.grpAnswers.Size = new System.Drawing.Size(265, 136);
            this.grpAnswers.TabIndex = 4;
            this.grpAnswers.TabStop = false;
            this.grpAnswers.Text = "Antworten";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Frage Nummer";
            // 
            // lblQuestionNumber
            // 
            this.lblQuestionNumber.AutoSize = true;
            this.lblQuestionNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuestionNumber.Location = new System.Drawing.Point(89, 9);
            this.lblQuestionNumber.Name = "lblQuestionNumber";
            this.lblQuestionNumber.Size = new System.Drawing.Size(41, 13);
            this.lblQuestionNumber.TabIndex = 0;
            this.lblQuestionNumber.Text = "label2";
            // 
            // panHighScores
            // 
            this.panHighScores.Controls.Add(this.button2);
            this.panHighScores.Controls.Add(this.btnNewGame);
            this.panHighScores.Controls.Add(this.grpHighscores);
            this.panHighScores.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panHighScores.Location = new System.Drawing.Point(0, 0);
            this.panHighScores.Name = "panHighScores";
            this.panHighScores.Size = new System.Drawing.Size(318, 509);
            this.panHighScores.TabIndex = 11;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(16, 474);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 7;
            this.button2.Text = "Abmelden";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // btnNewGame
            // 
            this.btnNewGame.Location = new System.Drawing.Point(214, 474);
            this.btnNewGame.Name = "btnNewGame";
            this.btnNewGame.Size = new System.Drawing.Size(75, 23);
            this.btnNewGame.TabIndex = 6;
            this.btnNewGame.Text = "Neues Spiel";
            this.btnNewGame.UseVisualStyleBackColor = true;
            this.btnNewGame.Click += new System.EventHandler(this.btnNewGame_Click);
            // 
            // grpHighscores
            // 
            this.grpHighscores.Controls.Add(this.lblHSNumber);
            this.grpHighscores.Controls.Add(this.lblHSName);
            this.grpHighscores.Controls.Add(this.lblHSScore);
            this.grpHighscores.Controls.Add(this.lblHSDate);
            this.grpHighscores.Location = new System.Drawing.Point(3, 3);
            this.grpHighscores.Name = "grpHighscores";
            this.grpHighscores.Size = new System.Drawing.Size(312, 434);
            this.grpHighscores.TabIndex = 5;
            this.grpHighscores.TabStop = false;
            this.grpHighscores.Text = "Bestenliste";
            // 
            // lblHSNumber
            // 
            this.lblHSNumber.AutoSize = true;
            this.lblHSNumber.Location = new System.Drawing.Point(20, 28);
            this.lblHSNumber.Name = "lblHSNumber";
            this.lblHSNumber.Size = new System.Drawing.Size(30, 13);
            this.lblHSNumber.TabIndex = 4;
            this.lblHSNumber.Text = "Platz";
            // 
            // lblHSName
            // 
            this.lblHSName.AutoSize = true;
            this.lblHSName.Location = new System.Drawing.Point(88, 28);
            this.lblHSName.Name = "lblHSName";
            this.lblHSName.Size = new System.Drawing.Size(35, 13);
            this.lblHSName.TabIndex = 1;
            this.lblHSName.Text = "Name";
            // 
            // lblHSScore
            // 
            this.lblHSScore.AutoSize = true;
            this.lblHSScore.Location = new System.Drawing.Point(239, 28);
            this.lblHSScore.Name = "lblHSScore";
            this.lblHSScore.Size = new System.Drawing.Size(41, 13);
            this.lblHSScore.TabIndex = 3;
            this.lblHSScore.Text = "Punkte";
            // 
            // lblHSDate
            // 
            this.lblHSDate.AutoSize = true;
            this.lblHSDate.Location = new System.Drawing.Point(156, 28);
            this.lblHSDate.Name = "lblHSDate";
            this.lblHSDate.Size = new System.Drawing.Size(38, 13);
            this.lblHSDate.TabIndex = 2;
            this.lblHSDate.Text = "Datum";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(318, 509);
            this.Controls.Add(this.panHighScores);
            this.Controls.Add(this.panChooseCategory);
            this.Controls.Add(this.panGame);
            this.Controls.Add(this.panAuth);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quiz";
            this.panAuth.ResumeLayout(false);
            this.panAuth.PerformLayout();
            this.panChooseCategory.ResumeLayout(false);
            this.panChooseCategory.PerformLayout();
            this.panGame.ResumeLayout(false);
            this.panGame.PerformLayout();
            this.grpQuestion.ResumeLayout(false);
            this.grpQuestion.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbQuestion)).EndInit();
            this.panHighScores.ResumeLayout(false);
            this.grpHighscores.ResumeLayout(false);
            this.grpHighscores.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox tbDisplayName;
        private System.Windows.Forms.Button btnSignIn;
        private System.Windows.Forms.Button btnSignUp;
        private System.Windows.Forms.TextBox tbPassword;
        private System.Windows.Forms.Panel panAuth;
        private System.Windows.Forms.Panel panChooseCategory;
        private System.Windows.Forms.Button btnGameStart;
        private System.Windows.Forms.GroupBox grpChooseCategory;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panGame;
        private System.Windows.Forms.Button btnNextQuestion;
        private System.Windows.Forms.GroupBox grpAnswers;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblQuestionNumber;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.GroupBox grpQuestion;
        private System.Windows.Forms.Label lblQuestion;
        private System.Windows.Forms.Label lblScore;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.Button btnAnswer;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pbQuestion;
        private System.Windows.Forms.Button btnAdmin;
        private System.Windows.Forms.Button btnHighScores;
        private System.Windows.Forms.Label lblMaxQuestions;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panHighScores;
        private System.Windows.Forms.GroupBox grpHighscores;
        private System.Windows.Forms.Label lblHSNumber;
        private System.Windows.Forms.Label lblHSName;
        private System.Windows.Forms.Label lblHSScore;
        private System.Windows.Forms.Label lblHSDate;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnNewGame;
    }
}

