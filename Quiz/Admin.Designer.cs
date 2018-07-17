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
            this.tbNewQuestion = new System.Windows.Forms.TextBox();
            this.grpTextAnswers = new System.Windows.Forms.GroupBox();
            this.btnSaveNewQuestion = new System.Windows.Forms.Button();
            this.lbQuestions = new System.Windows.Forms.ListBox();
            this.tbNewCat = new System.Windows.Forms.TextBox();
            this.btnNewCat = new System.Windows.Forms.Button();
            this.btnDelCat = new System.Windows.Forms.Button();
            this.lbCat = new System.Windows.Forms.ListBox();
            this.grpQuestion.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpQuestion
            // 
            this.grpQuestion.Controls.Add(this.tbNewQuestion);
            this.grpQuestion.Location = new System.Drawing.Point(12, 252);
            this.grpQuestion.Name = "grpQuestion";
            this.grpQuestion.Size = new System.Drawing.Size(412, 52);
            this.grpQuestion.TabIndex = 21;
            this.grpQuestion.TabStop = false;
            this.grpQuestion.Text = "Frage";
            // 
            // tbNewQuestion
            // 
            this.tbNewQuestion.Location = new System.Drawing.Point(6, 19);
            this.tbNewQuestion.Name = "tbNewQuestion";
            this.tbNewQuestion.Size = new System.Drawing.Size(396, 20);
            this.tbNewQuestion.TabIndex = 8;
            // 
            // grpTextAnswers
            // 
            this.grpTextAnswers.Location = new System.Drawing.Point(12, 310);
            this.grpTextAnswers.Name = "grpTextAnswers";
            this.grpTextAnswers.Size = new System.Drawing.Size(412, 141);
            this.grpTextAnswers.TabIndex = 20;
            this.grpTextAnswers.TabStop = false;
            this.grpTextAnswers.Text = "Anworten";
            // 
            // btnSaveNewQuestion
            // 
            this.btnSaveNewQuestion.Location = new System.Drawing.Point(349, 457);
            this.btnSaveNewQuestion.Name = "btnSaveNewQuestion";
            this.btnSaveNewQuestion.Size = new System.Drawing.Size(75, 23);
            this.btnSaveNewQuestion.TabIndex = 9;
            this.btnSaveNewQuestion.Text = "Speichern";
            this.btnSaveNewQuestion.UseVisualStyleBackColor = true;
            this.btnSaveNewQuestion.Click += new System.EventHandler(this.btnSaveNewQuestion_Click);
            // 
            // lbQuestions
            // 
            this.lbQuestions.FormattingEnabled = true;
            this.lbQuestions.Location = new System.Drawing.Point(12, 142);
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
            // Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(439, 490);
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
    }
}