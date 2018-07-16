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
            this.panLogin = new System.Windows.Forms.Panel();
            this.panChooseCategory = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.grpGameMode = new System.Windows.Forms.GroupBox();
            this.radioCountry = new System.Windows.Forms.RadioButton();
            this.radioFlag = new System.Windows.Forms.RadioButton();
            this.radioCapital = new System.Windows.Forms.RadioButton();
            this.btnGameStart = new System.Windows.Forms.Button();
            this.panGame = new System.Windows.Forms.Panel();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnNextQuestion = new System.Windows.Forms.Button();
            this.grpAnswers = new System.Windows.Forms.GroupBox();
            this.lblCategory = new System.Windows.Forms.Label();
            this.lblQuestion = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblQuestionNumber = new System.Windows.Forms.Label();
            this.panLogin.SuspendLayout();
            this.panChooseCategory.SuspendLayout();
            this.grpGameMode.SuspendLayout();
            this.panGame.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbDisplayName
            // 
            this.tbDisplayName.Location = new System.Drawing.Point(55, 34);
            this.tbDisplayName.Name = "tbDisplayName";
            this.tbDisplayName.Size = new System.Drawing.Size(100, 20);
            this.tbDisplayName.TabIndex = 5;
            // 
            // btnSignIn
            // 
            this.btnSignIn.Location = new System.Drawing.Point(55, 86);
            this.btnSignIn.Name = "btnSignIn";
            this.btnSignIn.Size = new System.Drawing.Size(100, 23);
            this.btnSignIn.TabIndex = 7;
            this.btnSignIn.Text = "Anmelden";
            this.btnSignIn.UseVisualStyleBackColor = true;
            this.btnSignIn.Click += new System.EventHandler(this.btnSignIn_Click);
            // 
            // btnSignUp
            // 
            this.btnSignUp.Location = new System.Drawing.Point(55, 115);
            this.btnSignUp.Name = "btnSignUp";
            this.btnSignUp.Size = new System.Drawing.Size(100, 23);
            this.btnSignUp.TabIndex = 4;
            this.btnSignUp.Text = "Neues Konto";
            this.btnSignUp.UseVisualStyleBackColor = true;
            this.btnSignUp.Click += new System.EventHandler(this.btnSignUp_Click);
            // 
            // tbPassword
            // 
            this.tbPassword.Location = new System.Drawing.Point(55, 60);
            this.tbPassword.Name = "tbPassword";
            this.tbPassword.Size = new System.Drawing.Size(100, 20);
            this.tbPassword.TabIndex = 6;
            // 
            // panLogin
            // 
            this.panLogin.Controls.Add(this.tbDisplayName);
            this.panLogin.Controls.Add(this.tbPassword);
            this.panLogin.Controls.Add(this.btnSignIn);
            this.panLogin.Controls.Add(this.btnSignUp);
            this.panLogin.Location = new System.Drawing.Point(12, 12);
            this.panLogin.Name = "panLogin";
            this.panLogin.Size = new System.Drawing.Size(200, 177);
            this.panLogin.TabIndex = 8;
            // 
            // panChooseCategory
            // 
            this.panChooseCategory.Controls.Add(this.label1);
            this.panChooseCategory.Controls.Add(this.grpGameMode);
            this.panChooseCategory.Controls.Add(this.btnGameStart);
            this.panChooseCategory.Location = new System.Drawing.Point(236, 12);
            this.panChooseCategory.Name = "panChooseCategory";
            this.panChooseCategory.Size = new System.Drawing.Size(407, 430);
            this.panChooseCategory.TabIndex = 9;
            this.panChooseCategory.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(61, 96);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(157, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Bitte wählen Sie eine Kategorie.";
            // 
            // grpGameMode
            // 
            this.grpGameMode.Controls.Add(this.radioCountry);
            this.grpGameMode.Controls.Add(this.radioFlag);
            this.grpGameMode.Controls.Add(this.radioCapital);
            this.grpGameMode.Location = new System.Drawing.Point(64, 124);
            this.grpGameMode.Name = "grpGameMode";
            this.grpGameMode.Size = new System.Drawing.Size(200, 100);
            this.grpGameMode.TabIndex = 5;
            this.grpGameMode.TabStop = false;
            this.grpGameMode.Text = "Spiel";
            // 
            // radioCountry
            // 
            this.radioCountry.AutoSize = true;
            this.radioCountry.Location = new System.Drawing.Point(34, 19);
            this.radioCountry.Name = "radioCountry";
            this.radioCountry.Size = new System.Drawing.Size(58, 17);
            this.radioCountry.TabIndex = 1;
            this.radioCountry.TabStop = true;
            this.radioCountry.Text = "Länder";
            this.radioCountry.UseVisualStyleBackColor = true;
            // 
            // radioFlag
            // 
            this.radioFlag.AutoSize = true;
            this.radioFlag.Location = new System.Drawing.Point(34, 42);
            this.radioFlag.Name = "radioFlag";
            this.radioFlag.Size = new System.Drawing.Size(63, 17);
            this.radioFlag.TabIndex = 2;
            this.radioFlag.TabStop = true;
            this.radioFlag.Text = "Flaggen";
            this.radioFlag.UseVisualStyleBackColor = true;
            // 
            // radioCapital
            // 
            this.radioCapital.AutoSize = true;
            this.radioCapital.Location = new System.Drawing.Point(34, 65);
            this.radioCapital.Name = "radioCapital";
            this.radioCapital.Size = new System.Drawing.Size(83, 17);
            this.radioCapital.TabIndex = 3;
            this.radioCapital.TabStop = true;
            this.radioCapital.Text = "Hauptstädte";
            this.radioCapital.UseVisualStyleBackColor = true;
            // 
            // btnGameStart
            // 
            this.btnGameStart.Location = new System.Drawing.Point(174, 244);
            this.btnGameStart.Name = "btnGameStart";
            this.btnGameStart.Size = new System.Drawing.Size(90, 23);
            this.btnGameStart.TabIndex = 4;
            this.btnGameStart.Text = "Spiel Starten";
            this.btnGameStart.UseVisualStyleBackColor = true;
            this.btnGameStart.Click += new System.EventHandler(this.btnGameStart_Click);
            // 
            // panGame
            // 
            this.panGame.Controls.Add(this.btnCancel);
            this.panGame.Controls.Add(this.btnNextQuestion);
            this.panGame.Controls.Add(this.grpAnswers);
            this.panGame.Controls.Add(this.lblCategory);
            this.panGame.Controls.Add(this.lblQuestion);
            this.panGame.Controls.Add(this.label2);
            this.panGame.Controls.Add(this.lblQuestionNumber);
            this.panGame.Location = new System.Drawing.Point(236, 12);
            this.panGame.Name = "panGame";
            this.panGame.Size = new System.Drawing.Size(407, 430);
            this.panGame.TabIndex = 10;
            this.panGame.Visible = false;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(57, 386);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 6;
            this.btnCancel.Text = "Abbrechen";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnNextQuestion
            // 
            this.btnNextQuestion.Location = new System.Drawing.Point(254, 386);
            this.btnNextQuestion.Name = "btnNextQuestion";
            this.btnNextQuestion.Size = new System.Drawing.Size(75, 23);
            this.btnNextQuestion.TabIndex = 5;
            this.btnNextQuestion.Text = "Weiter";
            this.btnNextQuestion.UseVisualStyleBackColor = true;
            this.btnNextQuestion.Click += new System.EventHandler(this.btnNextQuestion_Click);
            // 
            // grpAnswers
            // 
            this.grpAnswers.Location = new System.Drawing.Point(70, 221);
            this.grpAnswers.Name = "grpAnswers";
            this.grpAnswers.Size = new System.Drawing.Size(265, 136);
            this.grpAnswers.TabIndex = 4;
            this.grpAnswers.TabStop = false;
            this.grpAnswers.Text = "Antworten";
            // 
            // lblCategory
            // 
            this.lblCategory.AutoSize = true;
            this.lblCategory.Location = new System.Drawing.Point(55, 108);
            this.lblCategory.Name = "lblCategory";
            this.lblCategory.Size = new System.Drawing.Size(35, 13);
            this.lblCategory.TabIndex = 3;
            this.lblCategory.Text = "label3";
            // 
            // lblQuestion
            // 
            this.lblQuestion.AutoSize = true;
            this.lblQuestion.Location = new System.Drawing.Point(54, 164);
            this.lblQuestion.Name = "lblQuestion";
            this.lblQuestion.Size = new System.Drawing.Size(35, 13);
            this.lblQuestion.TabIndex = 2;
            this.lblQuestion.Text = "label3";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(55, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Frage";
            // 
            // lblQuestionNumber
            // 
            this.lblQuestionNumber.AutoSize = true;
            this.lblQuestionNumber.Location = new System.Drawing.Point(95, 41);
            this.lblQuestionNumber.Name = "lblQuestionNumber";
            this.lblQuestionNumber.Size = new System.Drawing.Size(35, 13);
            this.lblQuestionNumber.TabIndex = 0;
            this.lblQuestionNumber.Text = "label2";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(690, 509);
            this.Controls.Add(this.panLogin);
            this.Controls.Add(this.panGame);
            this.Controls.Add(this.panChooseCategory);
            this.Name = "Form1";
            this.Text = "Quiz";
            this.panLogin.ResumeLayout(false);
            this.panLogin.PerformLayout();
            this.panChooseCategory.ResumeLayout(false);
            this.panChooseCategory.PerformLayout();
            this.grpGameMode.ResumeLayout(false);
            this.grpGameMode.PerformLayout();
            this.panGame.ResumeLayout(false);
            this.panGame.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox tbDisplayName;
        private System.Windows.Forms.Button btnSignIn;
        private System.Windows.Forms.Button btnSignUp;
        private System.Windows.Forms.TextBox tbPassword;
        private System.Windows.Forms.Panel panLogin;
        private System.Windows.Forms.Panel panChooseCategory;
        private System.Windows.Forms.Button btnGameStart;
        private System.Windows.Forms.RadioButton radioCapital;
        private System.Windows.Forms.RadioButton radioFlag;
        private System.Windows.Forms.RadioButton radioCountry;
        private System.Windows.Forms.GroupBox grpGameMode;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panGame;
        private System.Windows.Forms.Button btnNextQuestion;
        private System.Windows.Forms.GroupBox grpAnswers;
        private System.Windows.Forms.Label lblCategory;
        private System.Windows.Forms.Label lblQuestion;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblQuestionNumber;
        private System.Windows.Forms.Button btnCancel;
    }
}

