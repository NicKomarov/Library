namespace Library
{
    partial class MainForm
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
            this.components = new System.ComponentModel.Container();
            this.groupBoxFiles = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBoxButtons = new System.Windows.Forms.GroupBox();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.groupBoxSearch = new System.Windows.Forms.GroupBox();
            this.button9 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button10 = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.groupBoxFiles.SuspendLayout();
            this.groupBoxButtons.SuspendLayout();
            this.groupBoxSearch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxFiles
            // 
            this.groupBoxFiles.Controls.Add(this.button2);
            this.groupBoxFiles.Location = new System.Drawing.Point(3, 3);
            this.groupBoxFiles.Name = "groupBoxFiles";
            this.groupBoxFiles.Size = new System.Drawing.Size(285, 72);
            this.groupBoxFiles.TabIndex = 0;
            this.groupBoxFiles.TabStop = false;
            this.groupBoxFiles.Text = "Робота з файлами";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(9, 30);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(266, 34);
            this.button2.TabIndex = 1;
            this.button2.Text = "Зберегти у файл";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // groupBoxButtons
            // 
            this.groupBoxButtons.Controls.Add(this.button5);
            this.groupBoxButtons.Controls.Add(this.button4);
            this.groupBoxButtons.Controls.Add(this.button3);
            this.groupBoxButtons.Location = new System.Drawing.Point(3, 81);
            this.groupBoxButtons.Name = "groupBoxButtons";
            this.groupBoxButtons.Size = new System.Drawing.Size(285, 150);
            this.groupBoxButtons.TabIndex = 1;
            this.groupBoxButtons.TabStop = false;
            this.groupBoxButtons.Text = "Обробка данних в таблиці";
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(9, 110);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(266, 34);
            this.button5.TabIndex = 2;
            this.button5.Text = "Видалити книгу";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(9, 70);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(266, 34);
            this.button4.TabIndex = 1;
            this.button4.Text = "Редагувати книгу";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(9, 30);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(266, 34);
            this.button3.TabIndex = 0;
            this.button3.Text = "Додати книгу";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // groupBoxSearch
            // 
            this.groupBoxSearch.Controls.Add(this.button9);
            this.groupBoxSearch.Controls.Add(this.button8);
            this.groupBoxSearch.Controls.Add(this.button7);
            this.groupBoxSearch.Controls.Add(this.button6);
            this.groupBoxSearch.Controls.Add(this.label3);
            this.groupBoxSearch.Controls.Add(this.textBox3);
            this.groupBoxSearch.Controls.Add(this.label2);
            this.groupBoxSearch.Controls.Add(this.textBox2);
            this.groupBoxSearch.Controls.Add(this.label1);
            this.groupBoxSearch.Controls.Add(this.textBox1);
            this.groupBoxSearch.Location = new System.Drawing.Point(3, 237);
            this.groupBoxSearch.Name = "groupBoxSearch";
            this.groupBoxSearch.Size = new System.Drawing.Size(285, 287);
            this.groupBoxSearch.TabIndex = 2;
            this.groupBoxSearch.TabStop = false;
            this.groupBoxSearch.Text = "Пошук";
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(9, 243);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(266, 34);
            this.button9.TabIndex = 9;
            this.button9.Text = "Вся таблиця";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(229, 195);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(46, 31);
            this.button8.TabIndex = 8;
            this.button8.Text = "Ок";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(229, 122);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(46, 31);
            this.button7.TabIndex = 7;
            this.button7.Text = "Ок";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(229, 55);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(46, 31);
            this.button6.TabIndex = 6;
            this.button6.Text = "Ок";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 167);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(186, 25);
            this.label3.TabIndex = 5;
            this.label3.Text = "По виданню (адреса)";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(9, 195);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(214, 31);
            this.textBox3.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(215, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "По сторінкам (менше за)";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(9, 122);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(214, 31);
            this.textBox2.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "По автору";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(9, 55);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(214, 31);
            this.textBox1.TabIndex = 0;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(294, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 33;
            this.dataGridView1.Size = new System.Drawing.Size(1020, 563);
            this.dataGridView1.TabIndex = 3;
            // 
            // button10
            // 
            this.button10.Location = new System.Drawing.Point(12, 530);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(266, 45);
            this.button10.TabIndex = 4;
            this.button10.Text = "Про програму";
            this.button10.UseVisualStyleBackColor = true;
            this.button10.Click += new System.EventHandler(this.button10_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 180000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1326, 588);
            this.Controls.Add(this.button10);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBoxSearch);
            this.Controls.Add(this.groupBoxButtons);
            this.Controls.Add(this.groupBoxFiles);
            this.Name = "MainForm";
            this.Text = "Моя бібліотека";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.groupBoxFiles.ResumeLayout(false);
            this.groupBoxButtons.ResumeLayout(false);
            this.groupBoxSearch.ResumeLayout(false);
            this.groupBoxSearch.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private GroupBox groupBoxFiles;
        private Button button2;
        private GroupBox groupBoxButtons;
        private Button button5;
        private Button button4;
        private Button button3;
        private GroupBox groupBoxSearch;
        private Label label1;
        private TextBox textBox1;
        private Button button8;
        private Button button7;
        private Button button6;
        private Label label3;
        private TextBox textBox3;
        private Label label2;
        private TextBox textBox2;
        private DataGridView dataGridView1;
        private Button button9;
        private Button button10;
        private System.Windows.Forms.Timer timer1;
    }
}