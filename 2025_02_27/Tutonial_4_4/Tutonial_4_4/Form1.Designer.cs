namespace Tutonial_4_4
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            distanceTextBox = new TextBox();
            gasTextBox = new TextBox();
            averageLabel = new Label();
            calculatebutton = new Button();
            exitButton = new Button();
            logListBox = new ListBox();
            button1 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft JhengHei UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 136);
            label1.Location = new Point(43, 27);
            label1.Name = "label1";
            label1.Size = new Size(143, 24);
            label1.TabIndex = 0;
            label1.Text = "輸入行駛里程數";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft JhengHei UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 136);
            label2.Location = new Point(43, 117);
            label2.Name = "label2";
            label2.Size = new Size(143, 24);
            label2.TabIndex = 1;
            label2.Text = "消耗油量公升數";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft JhengHei UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 136);
            label3.Location = new Point(43, 200);
            label3.Name = "label3";
            label3.Size = new Size(124, 24);
            label3.TabIndex = 2;
            label3.Text = "您的平均油耗";
            // 
            // distanceTextBox
            // 
            distanceTextBox.Location = new Point(203, 27);
            distanceTextBox.Name = "distanceTextBox";
            distanceTextBox.Size = new Size(100, 23);
            distanceTextBox.TabIndex = 3;
            // 
            // gasTextBox
            // 
            gasTextBox.Location = new Point(203, 121);
            gasTextBox.Name = "gasTextBox";
            gasTextBox.Size = new Size(100, 23);
            gasTextBox.TabIndex = 4;
            // 
            // averageLabel
            // 
            averageLabel.BorderStyle = BorderStyle.Fixed3D;
            averageLabel.Font = new Font("Microsoft JhengHei UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 136);
            averageLabel.Location = new Point(190, 199);
            averageLabel.Name = "averageLabel";
            averageLabel.Size = new Size(138, 49);
            averageLabel.TabIndex = 5;
            averageLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // calculatebutton
            // 
            calculatebutton.Font = new Font("Microsoft JhengHei UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 136);
            calculatebutton.Location = new Point(65, 322);
            calculatebutton.Name = "calculatebutton";
            calculatebutton.Size = new Size(121, 63);
            calculatebutton.TabIndex = 6;
            calculatebutton.Text = "計算";
            calculatebutton.UseVisualStyleBackColor = true;
            calculatebutton.Click += calculatebutton_Click;
            // 
            // exitButton
            // 
            exitButton.Font = new Font("Microsoft JhengHei UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 136);
            exitButton.Location = new Point(261, 322);
            exitButton.Name = "exitButton";
            exitButton.Size = new Size(121, 63);
            exitButton.TabIndex = 7;
            exitButton.Text = "離開";
            exitButton.UseVisualStyleBackColor = true;
            exitButton.Click += exitButton_Click;
            // 
            // logListBox
            // 
            logListBox.FormattingEnabled = true;
            logListBox.ItemHeight = 15;
            logListBox.Location = new Point(444, 47);
            logListBox.Name = "logListBox";
            logListBox.Size = new Size(309, 289);
            logListBox.TabIndex = 8;
            // 
            // button1
            // 
            button1.Font = new Font("Microsoft JhengHei UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 136);
            button1.Location = new Point(508, 367);
            button1.Name = "button1";
            button1.Size = new Size(120, 33);
            button1.TabIndex = 9;
            button1.Text = "總平均油耗";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button1);
            Controls.Add(logListBox);
            Controls.Add(exitButton);
            Controls.Add(calculatebutton);
            Controls.Add(averageLabel);
            Controls.Add(gasTextBox);
            Controls.Add(distanceTextBox);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox distanceTextBox;
        private TextBox gasTextBox;
        private Label averageLabel;
        private Button calculatebutton;
        private Button exitButton;
        private ListBox logListBox;
        private Button button1;
    }
}
