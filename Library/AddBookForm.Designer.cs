namespace Library
{
    partial class AddBookForm
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
            this.textBoxTitle = new System.Windows.Forms.TextBox();
            this.textBoxPublisher = new System.Windows.Forms.TextBox();
            this.textBoxNumOfPages = new System.Windows.Forms.TextBox();
            this.textBoxAuthors = new System.Windows.Forms.TextBox();
            this.textBoxID = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxStatus = new System.Windows.Forms.TextBox();
            this.textBoxPublisherAdress = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBoxTitle
            // 
            this.textBoxTitle.Location = new System.Drawing.Point(221, 70);
            this.textBoxTitle.Name = "textBoxTitle";
            this.textBoxTitle.Size = new System.Drawing.Size(191, 31);
            this.textBoxTitle.TabIndex = 21;
            // 
            // textBoxPublisher
            // 
            this.textBoxPublisher.Location = new System.Drawing.Point(221, 205);
            this.textBoxPublisher.Name = "textBoxPublisher";
            this.textBoxPublisher.Size = new System.Drawing.Size(191, 31);
            this.textBoxPublisher.TabIndex = 20;
            // 
            // textBoxNumOfPages
            // 
            this.textBoxNumOfPages.Location = new System.Drawing.Point(221, 115);
            this.textBoxNumOfPages.Name = "textBoxNumOfPages";
            this.textBoxNumOfPages.Size = new System.Drawing.Size(191, 31);
            this.textBoxNumOfPages.TabIndex = 19;
            // 
            // textBoxAuthors
            // 
            this.textBoxAuthors.Location = new System.Drawing.Point(221, 160);
            this.textBoxAuthors.Name = "textBoxAuthors";
            this.textBoxAuthors.Size = new System.Drawing.Size(191, 31);
            this.textBoxAuthors.TabIndex = 18;
            // 
            // textBoxID
            // 
            this.textBoxID.Location = new System.Drawing.Point(221, 25);
            this.textBoxID.Name = "textBoxID";
            this.textBoxID.Size = new System.Drawing.Size(191, 31);
            this.textBoxID.TabIndex = 17;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(30, 163);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(73, 25);
            this.label6.TabIndex = 16;
            this.label6.Text = "Автори";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(30, 208);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 25);
            this.label4.TabIndex = 15;
            this.label4.Text = "Видання";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(30, 118);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(157, 25);
            this.label3.TabIndex = 14;
            this.label3.Text = "Кількість сторінок";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 25);
            this.label2.TabIndex = 13;
            this.label2.Text = "Назва";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 25);
            this.label1.TabIndex = 12;
            this.label1.Text = "ID";
            // 
            // textBoxStatus
            // 
            this.textBoxStatus.Location = new System.Drawing.Point(221, 295);
            this.textBoxStatus.Name = "textBoxStatus";
            this.textBoxStatus.Size = new System.Drawing.Size(191, 31);
            this.textBoxStatus.TabIndex = 25;
            // 
            // textBoxPublisherAdress
            // 
            this.textBoxPublisherAdress.Location = new System.Drawing.Point(221, 250);
            this.textBoxPublisherAdress.Name = "textBoxPublisherAdress";
            this.textBoxPublisherAdress.Size = new System.Drawing.Size(191, 31);
            this.textBoxPublisherAdress.TabIndex = 24;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(30, 255);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(133, 25);
            this.label5.TabIndex = 23;
            this.label5.Text = "Місце видання";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(30, 300);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(63, 25);
            this.label7.TabIndex = 22;
            this.label7.Text = "Статус";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(30, 351);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(382, 44);
            this.button1.TabIndex = 26;
            this.button1.Text = "Додати";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // AddBookForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(447, 408);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBoxStatus);
            this.Controls.Add(this.textBoxPublisherAdress);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textBoxTitle);
            this.Controls.Add(this.textBoxPublisher);
            this.Controls.Add(this.textBoxNumOfPages);
            this.Controls.Add(this.textBoxAuthors);
            this.Controls.Add(this.textBoxID);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "AddBookForm";
            this.Text = "Додати книгу";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox textBoxTitle;
        private TextBox textBoxPublisher;
        private TextBox textBoxNumOfPages;
        private TextBox textBoxAuthors;
        private TextBox textBoxID;
        private Label label6;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox textBoxStatus;
        private TextBox textBoxPublisherAdress;
        private Label label5;
        private Label label7;
        private Button button1;
    }
}