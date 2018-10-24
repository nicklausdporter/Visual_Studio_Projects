namespace OrderingMortyApp
{
    partial class frmOrderingMorty
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmOrderingMorty));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.tinyRB = new System.Windows.Forms.RadioButton();
            this.robotMortyRB = new System.Windows.Forms.RadioButton();
            this.presidentMortyRB = new System.Windows.Forms.RadioButton();
            this.evilMortyRB = new System.Windows.Forms.RadioButton();
            this.cowboyRB = new System.Windows.Forms.RadioButton();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.addButton = new System.Windows.Forms.Button();
            this.deleteButton = new System.Windows.Forms.Button();
            this.totalButton = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.pictureCB = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkGreen;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(955, 38);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DarkGreen;
            this.panel2.Location = new System.Drawing.Point(1, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(51, 740);
            this.panel2.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(47, 34);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(908, 206);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.tinyRB);
            this.panel3.Controls.Add(this.robotMortyRB);
            this.panel3.Controls.Add(this.presidentMortyRB);
            this.panel3.Controls.Add(this.evilMortyRB);
            this.panel3.Controls.Add(this.cowboyRB);
            this.panel3.Location = new System.Drawing.Point(113, 373);
            this.panel3.Margin = new System.Windows.Forms.Padding(4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(169, 204);
            this.panel3.TabIndex = 3;
            // 
            // tinyRB
            // 
            this.tinyRB.AutoSize = true;
            this.tinyRB.Location = new System.Drawing.Point(20, 154);
            this.tinyRB.Margin = new System.Windows.Forms.Padding(4);
            this.tinyRB.Name = "tinyRB";
            this.tinyRB.Size = new System.Drawing.Size(126, 21);
            this.tinyRB.TabIndex = 18;
            this.tinyRB.TabStop = true;
            this.tinyRB.Text = "Tiny Rick Morty";
            this.tinyRB.UseVisualStyleBackColor = true;
            this.tinyRB.CheckedChanged += new System.EventHandler(this.tinyRB_CheckedChanged);
            // 
            // robotMortyRB
            // 
            this.robotMortyRB.AutoSize = true;
            this.robotMortyRB.Location = new System.Drawing.Point(20, 119);
            this.robotMortyRB.Margin = new System.Windows.Forms.Padding(4);
            this.robotMortyRB.Name = "robotMortyRB";
            this.robotMortyRB.Size = new System.Drawing.Size(106, 21);
            this.robotMortyRB.TabIndex = 17;
            this.robotMortyRB.TabStop = true;
            this.robotMortyRB.Text = "Robot Morty";
            this.robotMortyRB.UseVisualStyleBackColor = true;
            this.robotMortyRB.CheckedChanged += new System.EventHandler(this.robotMortyRB_CheckedChanged);
            // 
            // presidentMortyRB
            // 
            this.presidentMortyRB.AutoSize = true;
            this.presidentMortyRB.Location = new System.Drawing.Point(20, 91);
            this.presidentMortyRB.Margin = new System.Windows.Forms.Padding(4);
            this.presidentMortyRB.Name = "presidentMortyRB";
            this.presidentMortyRB.Size = new System.Drawing.Size(128, 21);
            this.presidentMortyRB.TabIndex = 16;
            this.presidentMortyRB.TabStop = true;
            this.presidentMortyRB.Text = "President Morty";
            this.presidentMortyRB.UseVisualStyleBackColor = true;
            this.presidentMortyRB.CheckedChanged += new System.EventHandler(this.presidentMortyRB_CheckedChanged);
            // 
            // evilMortyRB
            // 
            this.evilMortyRB.AutoSize = true;
            this.evilMortyRB.Location = new System.Drawing.Point(20, 55);
            this.evilMortyRB.Margin = new System.Windows.Forms.Padding(4);
            this.evilMortyRB.Name = "evilMortyRB";
            this.evilMortyRB.Size = new System.Drawing.Size(90, 21);
            this.evilMortyRB.TabIndex = 15;
            this.evilMortyRB.TabStop = true;
            this.evilMortyRB.Text = "Evil Morty";
            this.evilMortyRB.UseVisualStyleBackColor = true;
            this.evilMortyRB.CheckedChanged += new System.EventHandler(this.evilMortyRB_CheckedChanged);
            // 
            // cowboyRB
            // 
            this.cowboyRB.AutoSize = true;
            this.cowboyRB.Location = new System.Drawing.Point(20, 20);
            this.cowboyRB.Margin = new System.Windows.Forms.Padding(4);
            this.cowboyRB.Name = "cowboyRB";
            this.cowboyRB.Size = new System.Drawing.Size(117, 21);
            this.cowboyRB.TabIndex = 14;
            this.cowboyRB.TabStop = true;
            this.cowboyRB.Text = "Cowboy Morty";
            this.cowboyRB.UseVisualStyleBackColor = true;
            this.cowboyRB.CheckedChanged += new System.EventHandler(this.cowboyRB_CheckedChanged);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.DarkGreen;
            this.pictureBox2.Location = new System.Drawing.Point(350, 375);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(176, 183);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 4;
            this.pictureBox2.TabStop = false;
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Birthday",
            "Anniversary ",
            "I\'m Sorry",
            "Just Because",
            "I Love You",
            "Thank You!"});
            this.comboBox1.Location = new System.Drawing.Point(587, 374);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(4);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(160, 184);
            this.comboBox1.TabIndex = 5;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(129, 353);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 17);
            this.label1.TabIndex = 6;
            this.label1.Text = "Flowers";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(347, 354);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 17);
            this.label2.TabIndex = 7;
            this.label2.Text = "Picture:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(583, 353);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 17);
            this.label3.TabIndex = 8;
            this.label3.Text = "Occasion:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // addButton
            // 
            this.addButton.BackColor = System.Drawing.Color.DarkGreen;
            this.addButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.addButton.FlatAppearance.BorderSize = 0;
            this.addButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.addButton.Location = new System.Drawing.Point(756, 374);
            this.addButton.Margin = new System.Windows.Forms.Padding(4);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(100, 28);
            this.addButton.TabIndex = 9;
            this.addButton.Text = "Add";
            this.addButton.UseVisualStyleBackColor = false;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // deleteButton
            // 
            this.deleteButton.BackColor = System.Drawing.Color.DarkGreen;
            this.deleteButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.deleteButton.FlatAppearance.BorderSize = 0;
            this.deleteButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.deleteButton.Location = new System.Drawing.Point(756, 410);
            this.deleteButton.Margin = new System.Windows.Forms.Padding(4);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(100, 28);
            this.deleteButton.TabIndex = 10;
            this.deleteButton.Text = "Delete ";
            this.deleteButton.UseVisualStyleBackColor = false;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // totalButton
            // 
            this.totalButton.BackColor = System.Drawing.Color.DarkGreen;
            this.totalButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.totalButton.FlatAppearance.BorderSize = 0;
            this.totalButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.totalButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.totalButton.Location = new System.Drawing.Point(756, 446);
            this.totalButton.Margin = new System.Windows.Forms.Padding(4);
            this.totalButton.Name = "totalButton";
            this.totalButton.Size = new System.Drawing.Size(100, 28);
            this.totalButton.TabIndex = 11;
            this.totalButton.Text = "Total";
            this.totalButton.UseVisualStyleBackColor = false;
            this.totalButton.Click += new System.EventHandler(this.totalButton_Click);
            // 
            // clearButton
            // 
            this.clearButton.BackColor = System.Drawing.Color.DarkGreen;
            this.clearButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.clearButton.FlatAppearance.BorderSize = 0;
            this.clearButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.clearButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.clearButton.Location = new System.Drawing.Point(99, 670);
            this.clearButton.Margin = new System.Windows.Forms.Padding(4);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(100, 28);
            this.clearButton.TabIndex = 12;
            this.clearButton.Text = "Clear";
            this.clearButton.UseVisualStyleBackColor = false;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.BackColor = System.Drawing.Color.DarkGreen;
            this.exitButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.exitButton.FlatAppearance.BorderSize = 0;
            this.exitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exitButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.exitButton.Location = new System.Drawing.Point(236, 670);
            this.exitButton.Margin = new System.Windows.Forms.Padding(4);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(100, 28);
            this.exitButton.TabIndex = 13;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = false;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // pictureCB
            // 
            this.pictureCB.AutoSize = true;
            this.pictureCB.Location = new System.Drawing.Point(350, 566);
            this.pictureCB.Margin = new System.Windows.Forms.Padding(4);
            this.pictureCB.Name = "pictureCB";
            this.pictureCB.Size = new System.Drawing.Size(98, 21);
            this.pictureCB.TabIndex = 14;
            this.pictureCB.Text = "Hide Morty";
            this.pictureCB.UseVisualStyleBackColor = true;
            this.pictureCB.CheckedChanged += new System.EventHandler(this.pictureCB_CheckedChanged);
            // 
            // frmOrderingMorty
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.ClientSize = new System.Drawing.Size(956, 734);
            this.Controls.Add(this.pictureCB);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.totalButton);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmOrderingMorty";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.Button totalButton;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.RadioButton tinyRB;
        private System.Windows.Forms.RadioButton robotMortyRB;
        private System.Windows.Forms.RadioButton presidentMortyRB;
        private System.Windows.Forms.RadioButton evilMortyRB;
        private System.Windows.Forms.RadioButton cowboyRB;
        private System.Windows.Forms.CheckBox pictureCB;
    }
}

