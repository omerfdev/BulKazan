namespace BulKazan
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            btnOne = new Button();
            btnTwo = new Button();
            btnThree = new Button();
            lblComputer = new Label();
            lblUser = new Label();
            lblComputerCount = new Label();
            lblUserCount = new Label();
            SuspendLayout();
            // 
            // btnOne
            // 
            btnOne.Location = new Point(48, 145);
            btnOne.Margin = new Padding(4, 3, 4, 3);
            btnOne.Name = "btnOne";
            btnOne.Size = new Size(250, 250);
            btnOne.TabIndex = 0;
            btnOne.UseVisualStyleBackColor = true;
            // 
            // btnTwo
            // 
            btnTwo.Location = new Point(364, 145);
            btnTwo.Margin = new Padding(4, 3, 4, 3);
            btnTwo.Name = "btnTwo";
            btnTwo.Size = new Size(250, 250);
            btnTwo.TabIndex = 1;
            btnTwo.UseVisualStyleBackColor = true;
            // 
            // btnThree
            // 
            btnThree.Location = new Point(668, 145);
            btnThree.Margin = new Padding(4, 3, 4, 3);
            btnThree.Name = "btnThree";
            btnThree.Size = new Size(250, 250);
            btnThree.TabIndex = 2;
            btnThree.UseVisualStyleBackColor = true;
            // 
            // lblComputer
            // 
            lblComputer.AutoSize = true;
            lblComputer.Location = new Point(48, 47);
            lblComputer.Margin = new Padding(4, 0, 4, 0);
            lblComputer.Name = "lblComputer";
            lblComputer.Size = new Size(85, 20);
            lblComputer.TabIndex = 3;
            lblComputer.Text = "Computer=";
            // 
            // lblUser
            // 
            lblUser.AutoSize = true;
            lblUser.Location = new Point(84, 86);
            lblUser.Margin = new Padding(4, 0, 4, 0);
            lblUser.Name = "lblUser";
            lblUser.Size = new Size(48, 20);
            lblUser.TabIndex = 4;
            lblUser.Text = "User=";
            // 
            // lblComputerCount
            // 
            lblComputerCount.AutoSize = true;
            lblComputerCount.ForeColor = Color.Red;
            lblComputerCount.Location = new Point(140, 47);
            lblComputerCount.Margin = new Padding(4, 0, 4, 0);
            lblComputerCount.Name = "lblComputerCount";
            lblComputerCount.Size = new Size(17, 20);
            lblComputerCount.TabIndex = 5;
            lblComputerCount.Text = "0";
            // 
            // lblUserCount
            // 
            lblUserCount.AutoSize = true;
            lblUserCount.ForeColor = Color.Red;
            lblUserCount.Location = new Point(140, 86);
            lblUserCount.Margin = new Padding(4, 0, 4, 0);
            lblUserCount.Name = "lblUserCount";
            lblUserCount.Size = new Size(17, 20);
            lblUserCount.TabIndex = 6;
            lblUserCount.Text = "0";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(981, 568);
            Controls.Add(lblUserCount);
            Controls.Add(lblComputerCount);
            Controls.Add(lblUser);
            Controls.Add(lblComputer);
            Controls.Add(btnThree);
            Controls.Add(btnTwo);
            Controls.Add(btnOne);
            Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4, 3, 4, 3);
            MaximumSize = new Size(999, 800);
            MinimumSize = new Size(999, 573);
            Name = "Form1";
            Text = "Bul Kazan!";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnOne;
        private Button btnTwo;
        private Button btnThree;
        private Label lblComputer;
        private Label lblUser;
        private Label lblComputerCount;
        private Label lblUserCount;
    }
}