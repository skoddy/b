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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabCat = new System.Windows.Forms.TabPage();
            this.lbCatItems = new System.Windows.Forms.ListBox();
            this.tbNewAnswer = new System.Windows.Forms.TextBox();
            this.btnAddToCat = new System.Windows.Forms.Button();
            this.tbNewCat = new System.Windows.Forms.TextBox();
            this.btnNewCat = new System.Windows.Forms.Button();
            this.btnDelCat = new System.Windows.Forms.Button();
            this.lbCat = new System.Windows.Forms.ListBox();
            this.tabQuestions = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.grpAnswerAsPicture = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.grpQuestion = new System.Windows.Forms.GroupBox();
            this.btnChoosePicture = new System.Windows.Forms.Button();
            this.tbQuestion = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.chkQuestionWithPicture = new System.Windows.Forms.CheckBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.tabControl1.SuspendLayout();
            this.tabCat.SuspendLayout();
            this.tabQuestions.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.grpAnswerAsPicture.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.grpQuestion.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabCat);
            this.tabControl1.Controls.Add(this.tabQuestions);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(653, 641);
            this.tabControl1.TabIndex = 0;
            // 
            // tabCat
            // 
            this.tabCat.Controls.Add(this.lbCatItems);
            this.tabCat.Controls.Add(this.tbNewAnswer);
            this.tabCat.Controls.Add(this.btnAddToCat);
            this.tabCat.Controls.Add(this.tbNewCat);
            this.tabCat.Controls.Add(this.btnNewCat);
            this.tabCat.Controls.Add(this.btnDelCat);
            this.tabCat.Controls.Add(this.lbCat);
            this.tabCat.Location = new System.Drawing.Point(4, 22);
            this.tabCat.Name = "tabCat";
            this.tabCat.Padding = new System.Windows.Forms.Padding(3);
            this.tabCat.Size = new System.Drawing.Size(645, 615);
            this.tabCat.TabIndex = 0;
            this.tabCat.Text = "Cat";
            this.tabCat.UseVisualStyleBackColor = true;
            // 
            // lbCatItems
            // 
            this.lbCatItems.FormattingEnabled = true;
            this.lbCatItems.Location = new System.Drawing.Point(279, 54);
            this.lbCatItems.Name = "lbCatItems";
            this.lbCatItems.Size = new System.Drawing.Size(120, 95);
            this.lbCatItems.TabIndex = 6;
            // 
            // tbNewAnswer
            // 
            this.tbNewAnswer.Location = new System.Drawing.Point(319, 330);
            this.tbNewAnswer.Name = "tbNewAnswer";
            this.tbNewAnswer.Size = new System.Drawing.Size(100, 20);
            this.tbNewAnswer.TabIndex = 5;
            // 
            // btnAddToCat
            // 
            this.btnAddToCat.Location = new System.Drawing.Point(425, 330);
            this.btnAddToCat.Name = "btnAddToCat";
            this.btnAddToCat.Size = new System.Drawing.Size(75, 23);
            this.btnAddToCat.TabIndex = 4;
            this.btnAddToCat.Text = "add";
            this.btnAddToCat.UseVisualStyleBackColor = true;
            this.btnAddToCat.Click += new System.EventHandler(this.btnAddToCat_Click);
            // 
            // tbNewCat
            // 
            this.tbNewCat.Location = new System.Drawing.Point(319, 268);
            this.tbNewCat.Name = "tbNewCat";
            this.tbNewCat.Size = new System.Drawing.Size(100, 20);
            this.tbNewCat.TabIndex = 3;
            // 
            // btnNewCat
            // 
            this.btnNewCat.Location = new System.Drawing.Point(425, 266);
            this.btnNewCat.Name = "btnNewCat";
            this.btnNewCat.Size = new System.Drawing.Size(47, 23);
            this.btnNewCat.TabIndex = 2;
            this.btnNewCat.Text = "new";
            this.btnNewCat.UseVisualStyleBackColor = true;
            this.btnNewCat.Click += new System.EventHandler(this.btnNewCat_Click);
            // 
            // btnDelCat
            // 
            this.btnDelCat.Location = new System.Drawing.Point(142, 166);
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
            this.lbCat.Location = new System.Drawing.Point(51, 54);
            this.lbCat.Name = "lbCat";
            this.lbCat.Size = new System.Drawing.Size(120, 95);
            this.lbCat.TabIndex = 0;
            this.lbCat.SelectedIndexChanged += new System.EventHandler(this.lbCat_SelectedIndexChanged);
            // 
            // tabQuestions
            // 
            this.tabQuestions.Controls.Add(this.groupBox1);
            this.tabQuestions.Controls.Add(this.button3);
            this.tabQuestions.Controls.Add(this.grpAnswerAsPicture);
            this.tabQuestions.Controls.Add(this.grpQuestion);
            this.tabQuestions.Controls.Add(this.comboBox1);
            this.tabQuestions.Location = new System.Drawing.Point(4, 22);
            this.tabQuestions.Name = "tabQuestions";
            this.tabQuestions.Padding = new System.Windows.Forms.Padding(3);
            this.tabQuestions.Size = new System.Drawing.Size(645, 615);
            this.tabQuestions.TabIndex = 1;
            this.tabQuestions.Text = "Fragen";
            this.tabQuestions.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBox2);
            this.groupBox1.Location = new System.Drawing.Point(83, 362);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(433, 135);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Antwort als Text";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(6, 19);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(421, 20);
            this.textBox2.TabIndex = 0;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(441, 518);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 6;
            this.button3.Text = "button3";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // grpAnswerAsPicture
            // 
            this.grpAnswerAsPicture.Controls.Add(this.button2);
            this.grpAnswerAsPicture.Controls.Add(this.pictureBox2);
            this.grpAnswerAsPicture.Location = new System.Drawing.Point(83, 264);
            this.grpAnswerAsPicture.Name = "grpAnswerAsPicture";
            this.grpAnswerAsPicture.Size = new System.Drawing.Size(433, 92);
            this.grpAnswerAsPicture.TabIndex = 5;
            this.grpAnswerAsPicture.TabStop = false;
            this.grpAnswerAsPicture.Text = "Antwort als Bild";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(135, 19);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 3;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(6, 19);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(100, 50);
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // grpQuestion
            // 
            this.grpQuestion.Controls.Add(this.btnChoosePicture);
            this.grpQuestion.Controls.Add(this.tbQuestion);
            this.grpQuestion.Controls.Add(this.pictureBox1);
            this.grpQuestion.Controls.Add(this.chkQuestionWithPicture);
            this.grpQuestion.Location = new System.Drawing.Point(83, 106);
            this.grpQuestion.Name = "grpQuestion";
            this.grpQuestion.Size = new System.Drawing.Size(433, 138);
            this.grpQuestion.TabIndex = 4;
            this.grpQuestion.TabStop = false;
            this.grpQuestion.Text = "Frage";
            // 
            // btnChoosePicture
            // 
            this.btnChoosePicture.Location = new System.Drawing.Point(135, 88);
            this.btnChoosePicture.Name = "btnChoosePicture";
            this.btnChoosePicture.Size = new System.Drawing.Size(104, 23);
            this.btnChoosePicture.TabIndex = 3;
            this.btnChoosePicture.Text = "Bild auswählen";
            this.btnChoosePicture.UseVisualStyleBackColor = true;
            // 
            // tbQuestion
            // 
            this.tbQuestion.Location = new System.Drawing.Point(6, 19);
            this.tbQuestion.Name = "tbQuestion";
            this.tbQuestion.Size = new System.Drawing.Size(421, 20);
            this.tbQuestion.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(17, 65);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 50);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // chkQuestionWithPicture
            // 
            this.chkQuestionWithPicture.AutoSize = true;
            this.chkQuestionWithPicture.Location = new System.Drawing.Point(135, 65);
            this.chkQuestionWithPicture.Name = "chkQuestionWithPicture";
            this.chkQuestionWithPicture.Size = new System.Drawing.Size(89, 17);
            this.chkQuestionWithPicture.TabIndex = 2;
            this.chkQuestionWithPicture.Text = "Frage mit Bild";
            this.chkQuestionWithPicture.UseVisualStyleBackColor = true;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(395, 39);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 3;
            // 
            // Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(653, 641);
            this.Controls.Add(this.tabControl1);
            this.Name = "Admin";
            this.Text = "Admin";
            this.tabControl1.ResumeLayout(false);
            this.tabCat.ResumeLayout(false);
            this.tabCat.PerformLayout();
            this.tabQuestions.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.grpAnswerAsPicture.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.grpQuestion.ResumeLayout(false);
            this.grpQuestion.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabCat;
        private System.Windows.Forms.TextBox tbNewCat;
        private System.Windows.Forms.Button btnNewCat;
        private System.Windows.Forms.Button btnDelCat;
        private System.Windows.Forms.ListBox lbCat;
        private System.Windows.Forms.TabPage tabQuestions;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox tbQuestion;
        private System.Windows.Forms.CheckBox chkQuestionWithPicture;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.GroupBox grpAnswerAsPicture;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.GroupBox grpQuestion;
        private System.Windows.Forms.Button btnChoosePicture;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ListBox lbCatItems;
        private System.Windows.Forms.TextBox tbNewAnswer;
        private System.Windows.Forms.Button btnAddToCat;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}