namespace Quiz
{
    partial class Admin
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
            this.grpQuestion = new System.Windows.Forms.GroupBox();
            this.btnGetImage = new System.Windows.Forms.Button();
            this.pbQuestionImage = new System.Windows.Forms.PictureBox();
            this.tbNewQuestion = new System.Windows.Forms.TextBox();
            this.grpTextAnswers = new System.Windows.Forms.GroupBox();
            this.btnSaveNewQuestion = new System.Windows.Forms.Button();
            this.lbQuestions = new System.Windows.Forms.ListBox();
            this.tbNewCat = new System.Windows.Forms.TextBox();
            this.btnNewCat = new System.Windows.Forms.Button();
            this.btnDelCat = new System.Windows.Forms.Button();
            this.lbCat = new System.Windows.Forms.ListBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.grpQuestion.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbQuestionImage)).BeginInit();
            this.SuspendLayout();
            // 
            // grpQuestion
            // 
            this.grpQuestion.Controls.Add(this.btnGetImage);
            this.grpQuestion.Controls.Add(this.pbQuestionImage);
            this.grpQuestion.Controls.Add(this.tbNewQuestion);
            this.grpQuestion.Location = new System.Drawing.Point(12, 113);
            this.grpQuestion.Name = "grpQuestion";
            this.grpQuestion.Size = new System.Drawing.Size(412, 220);
            this.grpQuestion.TabIndex = 21;
            this.grpQuestion.TabStop = false;
            this.grpQuestion.Text = "Frage";
            // 
            // btnGetImage
            // 
            this.btnGetImage.Location = new System.Drawing.Point(232, 192);
            this.btnGetImage.Name = "btnGetImage";
            this.btnGetImage.Size = new System.Drawing.Size(170, 23);
            this.btnGetImage.TabIndex = 11;
            this.btnGetImage.Text = "Bild hinzufügen";
            this.btnGetImage.UseVisualStyleBackColor = true;
            this.btnGetImage.Click += new System.EventHandler(this.btnGetImage_Click);
            // 
            // pbQuestionImage
            // 
            this.pbQuestionImage.Location = new System.Drawing.Point(232, 19);
            this.pbQuestionImage.Name = "pbQuestionImage";
            this.pbQuestionImage.Size = new System.Drawing.Size(170, 167);
            this.pbQuestionImage.TabIndex = 10;
            this.pbQuestionImage.TabStop = false;
            // 
            // tbNewQuestion
            // 
            this.tbNewQuestion.Location = new System.Drawing.Point(6, 19);
            this.tbNewQuestion.Multiline = true;
            this.tbNewQuestion.Name = "tbNewQuestion";
            this.tbNewQuestion.Size = new System.Drawing.Size(220, 196);
            this.tbNewQuestion.TabIndex = 8;
            // 
            // grpTextAnswers
            // 
            this.grpTextAnswers.Location = new System.Drawing.Point(430, 158);
            this.grpTextAnswers.Name = "grpTextAnswers";
            this.grpTextAnswers.Size = new System.Drawing.Size(412, 141);
            this.grpTextAnswers.TabIndex = 20;
            this.grpTextAnswers.TabStop = false;
            this.grpTextAnswers.Text = "Anworten";
            // 
            // btnSaveNewQuestion
            // 
            this.btnSaveNewQuestion.Location = new System.Drawing.Point(726, 129);
            this.btnSaveNewQuestion.Name = "btnSaveNewQuestion";
            this.btnSaveNewQuestion.Size = new System.Drawing.Size(116, 23);
            this.btnSaveNewQuestion.TabIndex = 9;
            this.btnSaveNewQuestion.Text = "Frage speichern";
            this.btnSaveNewQuestion.UseVisualStyleBackColor = true;
            this.btnSaveNewQuestion.Click += new System.EventHandler(this.btnSaveNewQuestion_Click);
            // 
            // lbQuestions
            // 
            this.lbQuestions.FormattingEnabled = true;
            this.lbQuestions.Location = new System.Drawing.Point(297, 12);
            this.lbQuestions.Name = "lbQuestions";
            this.lbQuestions.Size = new System.Drawing.Size(396, 95);
            this.lbQuestions.TabIndex = 7;
            this.lbQuestions.SelectedIndexChanged += new System.EventHandler(this.lbQuestions_SelectedIndexChanged);
            // 
            // tbNewCat
            // 
            this.tbNewCat.Location = new System.Drawing.Point(138, 12);
            this.tbNewCat.Name = "tbNewCat";
            this.tbNewCat.Size = new System.Drawing.Size(100, 20);
            this.tbNewCat.TabIndex = 3;
            // 
            // btnNewCat
            // 
            this.btnNewCat.Location = new System.Drawing.Point(244, 10);
            this.btnNewCat.Name = "btnNewCat";
            this.btnNewCat.Size = new System.Drawing.Size(47, 23);
            this.btnNewCat.TabIndex = 2;
            this.btnNewCat.Text = "new";
            this.btnNewCat.UseVisualStyleBackColor = true;
            this.btnNewCat.Click += new System.EventHandler(this.btnNewCat_Click);
            // 
            // btnDelCat
            // 
            this.btnDelCat.Location = new System.Drawing.Point(138, 84);
            this.btnDelCat.Name = "btnDelCat";
            this.btnDelCat.Size = new System.Drawing.Size(29, 23);
            this.btnDelCat.TabIndex = 1;
            this.btnDelCat.Text = "del";
            this.btnDelCat.UseVisualStyleBackColor = true;
            this.btnDelCat.Click += new System.EventHandler(this.btnDelCat_Click);
            // 
            // lbCat
            // 
            this.lbCat.FormattingEnabled = true;
            this.lbCat.Location = new System.Drawing.Point(12, 12);
            this.lbCat.Name = "lbCat";
            this.lbCat.Size = new System.Drawing.Size(120, 95);
            this.lbCat.TabIndex = 0;
            this.lbCat.SelectedIndexChanged += new System.EventHandler(this.lbCat_SelectedIndexChanged);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(430, 129);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(115, 23);
            this.button1.TabIndex = 23;
            this.button1.Text = "Antwort mit Text";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(551, 129);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(124, 23);
            this.button2.TabIndex = 24;
            this.button2.Text = "Antwort mit Bild";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(960, 658);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.grpQuestion);
            this.Controls.Add(this.grpTextAnswers);
            this.Controls.Add(this.lbCat);
            this.Controls.Add(this.btnSaveNewQuestion);
            this.Controls.Add(this.btnDelCat);
            this.Controls.Add(this.lbQuestions);
            this.Controls.Add(this.btnNewCat);
            this.Controls.Add(this.tbNewCat);
            this.Name = "Admin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Admin";
            this.grpQuestion.ResumeLayout(false);
            this.grpQuestion.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbQuestionImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox tbNewCat;
        private System.Windows.Forms.Button btnNewCat;
        private System.Windows.Forms.Button btnDelCat;
        private System.Windows.Forms.ListBox lbCat;
        private System.Windows.Forms.ListBox lbQuestions;
        private System.Windows.Forms.Button btnSaveNewQuestion;
        private System.Windows.Forms.TextBox tbNewQuestion;
        private System.Windows.Forms.GroupBox grpQuestion;
        private System.Windows.Forms.GroupBox grpTextAnswers;
        private System.Windows.Forms.Button btnGetImage;
        private System.Windows.Forms.PictureBox pbQuestionImage;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}