namespace NickMenu
{
    partial class frmNickMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmNickMenu));
            this.Menu = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.saladQuantityText = new System.Windows.Forms.TextBox();
            this.saladPriceText = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pastaSaladRadioButton = new System.Windows.Forms.RadioButton();
            this.fruitSaladRadioButton = new System.Windows.Forms.RadioButton();
            this.saladLabel = new System.Windows.Forms.Label();
            this.drinksLabel = new System.Windows.Forms.Label();
            this.dessertsLabel = new System.Windows.Forms.Label();
            this.messageLabel = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.drinkNumberText = new System.Windows.Forms.TextBox();
            this.drinkPriceText = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.fruitJuiceRadioButton = new System.Windows.Forms.RadioButton();
            this.smoothieRadioButton = new System.Windows.Forms.RadioButton();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label11 = new System.Windows.Forms.Label();
            this.dessertQtext = new System.Windows.Forms.TextBox();
            this.dessertPriceText = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.shortCakeRadioButton = new System.Windows.Forms.RadioButton();
            this.cupCakeRadioButton = new System.Windows.Forms.RadioButton();
            this.calculateButton = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.panel3.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            this.SuspendLayout();
            // 
            // Menu
            // 
            this.Menu.AutoSize = true;
            this.Menu.Font = new System.Drawing.Font("Elephant", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Menu.Location = new System.Drawing.Point(41, 24);
            this.Menu.Name = "Menu";
            this.Menu.Size = new System.Drawing.Size(280, 103);
            this.Menu.TabIndex = 0;
            this.Menu.Text = "Menu";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightCoral;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.saladQuantityText);
            this.panel1.Controls.Add(this.saladPriceText);
            this.panel1.Controls.Add(this.tableLayoutPanel1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pastaSaladRadioButton);
            this.panel1.Controls.Add(this.fruitSaladRadioButton);
            this.panel1.Location = new System.Drawing.Point(165, 165);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(346, 472);
            this.panel1.TabIndex = 1;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(14, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(66, 20);
            this.label7.TabIndex = 9;
            this.label7.Text = "Salads";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // saladQuantityText
            // 
            this.saladQuantityText.Location = new System.Drawing.Point(207, 373);
            this.saladQuantityText.Name = "saladQuantityText";
            this.saladQuantityText.Size = new System.Drawing.Size(100, 22);
            this.saladQuantityText.TabIndex = 8;
            this.saladQuantityText.Text = "0";
            this.saladQuantityText.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // saladPriceText
            // 
            this.saladPriceText.Enabled = false;
            this.saladPriceText.Location = new System.Drawing.Point(207, 309);
            this.saladPriceText.Name = "saladPriceText";
            this.saladPriceText.ReadOnly = true;
            this.saladPriceText.Size = new System.Drawing.Size(100, 22);
            this.saladPriceText.TabIndex = 3;
            this.saladPriceText.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.pictureBox2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.pictureBox1, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(180, 57);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(152, 189);
            this.tableLayoutPanel1.TabIndex = 7;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(3, 97);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(146, 88);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(3, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(146, 88);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(63, 378);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Salad Quantity";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(63, 309);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Salad Price";
            // 
            // pastaSaladRadioButton
            // 
            this.pastaSaladRadioButton.AutoSize = true;
            this.pastaSaladRadioButton.Location = new System.Drawing.Point(46, 185);
            this.pastaSaladRadioButton.Name = "pastaSaladRadioButton";
            this.pastaSaladRadioButton.Size = new System.Drawing.Size(105, 21);
            this.pastaSaladRadioButton.TabIndex = 1;
            this.pastaSaladRadioButton.TabStop = true;
            this.pastaSaladRadioButton.Text = "Pasta Salad";
            this.pastaSaladRadioButton.UseVisualStyleBackColor = true;
            this.pastaSaladRadioButton.CheckedChanged += new System.EventHandler(this.pastaSaladRadioButton_CheckedChanged);
            // 
            // fruitSaladRadioButton
            // 
            this.fruitSaladRadioButton.AutoSize = true;
            this.fruitSaladRadioButton.Location = new System.Drawing.Point(46, 86);
            this.fruitSaladRadioButton.Name = "fruitSaladRadioButton";
            this.fruitSaladRadioButton.Size = new System.Drawing.Size(97, 21);
            this.fruitSaladRadioButton.TabIndex = 0;
            this.fruitSaladRadioButton.TabStop = true;
            this.fruitSaladRadioButton.Text = "Fruit Salad";
            this.fruitSaladRadioButton.UseVisualStyleBackColor = true;
            this.fruitSaladRadioButton.CheckedChanged += new System.EventHandler(this.fruitSaladRadioButton_CheckedChanged);
            // 
            // saladLabel
            // 
            this.saladLabel.AutoSize = true;
            this.saladLabel.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.saladLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.saladLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saladLabel.Location = new System.Drawing.Point(228, 691);
            this.saladLabel.Name = "saladLabel";
            this.saladLabel.Size = new System.Drawing.Size(228, 26);
            this.saladLabel.TabIndex = 3;
            this.saladLabel.Text = "Please Choose a Salad";
            // 
            // drinksLabel
            // 
            this.drinksLabel.AutoSize = true;
            this.drinksLabel.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.drinksLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.drinksLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.drinksLabel.Location = new System.Drawing.Point(729, 691);
            this.drinksLabel.Name = "drinksLabel";
            this.drinksLabel.Size = new System.Drawing.Size(235, 27);
            this.drinksLabel.TabIndex = 4;
            this.drinksLabel.Text = "Please Choose a Drink";
            // 
            // dessertsLabel
            // 
            this.dessertsLabel.AutoSize = true;
            this.dessertsLabel.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.dessertsLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.dessertsLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.dessertsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dessertsLabel.Location = new System.Drawing.Point(1247, 691);
            this.dessertsLabel.Name = "dessertsLabel";
            this.dessertsLabel.Size = new System.Drawing.Size(259, 27);
            this.dessertsLabel.TabIndex = 5;
            this.dessertsLabel.Text = "Please Choose a Dessert";
            // 
            // messageLabel
            // 
            this.messageLabel.AutoSize = true;
            this.messageLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.messageLabel.Location = new System.Drawing.Point(532, 814);
            this.messageLabel.Name = "messageLabel";
            this.messageLabel.Size = new System.Drawing.Size(133, 25);
            this.messageLabel.TabIndex = 6;
            this.messageLabel.Text = "Your total is:";
            this.messageLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.LightCoral;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.drinkNumberText);
            this.panel2.Controls.Add(this.drinkPriceText);
            this.panel2.Controls.Add(this.tableLayoutPanel2);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.label10);
            this.panel2.Controls.Add(this.fruitJuiceRadioButton);
            this.panel2.Controls.Add(this.smoothieRadioButton);
            this.panel2.Location = new System.Drawing.Point(732, 165);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(346, 472);
            this.panel2.TabIndex = 7;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(14, 9);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(64, 20);
            this.label8.TabIndex = 9;
            this.label8.Text = "Drinks";
            // 
            // drinkNumberText
            // 
            this.drinkNumberText.Location = new System.Drawing.Point(207, 373);
            this.drinkNumberText.Name = "drinkNumberText";
            this.drinkNumberText.Size = new System.Drawing.Size(100, 22);
            this.drinkNumberText.TabIndex = 8;
            this.drinkNumberText.Text = "0";
            this.drinkNumberText.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // drinkPriceText
            // 
            this.drinkPriceText.Enabled = false;
            this.drinkPriceText.Location = new System.Drawing.Point(207, 309);
            this.drinkPriceText.Name = "drinkPriceText";
            this.drinkPriceText.ReadOnly = true;
            this.drinkPriceText.Size = new System.Drawing.Size(100, 22);
            this.drinkPriceText.TabIndex = 0;
            this.drinkPriceText.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.pictureBox3, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.pictureBox4, 0, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(180, 57);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(152, 189);
            this.tableLayoutPanel2.TabIndex = 7;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(3, 97);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(146, 88);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 1;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(3, 3);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(146, 88);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 0;
            this.pictureBox4.TabStop = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(63, 378);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(98, 17);
            this.label9.TabIndex = 3;
            this.label9.Text = "Drink Quantity";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(63, 309);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(77, 17);
            this.label10.TabIndex = 2;
            this.label10.Text = "Drink Price";
            // 
            // fruitJuiceRadioButton
            // 
            this.fruitJuiceRadioButton.AutoSize = true;
            this.fruitJuiceRadioButton.Location = new System.Drawing.Point(46, 185);
            this.fruitJuiceRadioButton.Name = "fruitJuiceRadioButton";
            this.fruitJuiceRadioButton.Size = new System.Drawing.Size(94, 21);
            this.fruitJuiceRadioButton.TabIndex = 1;
            this.fruitJuiceRadioButton.TabStop = true;
            this.fruitJuiceRadioButton.Text = "Fruit Juice";
            this.fruitJuiceRadioButton.UseVisualStyleBackColor = true;
            this.fruitJuiceRadioButton.CheckedChanged += new System.EventHandler(this.fruitJuiceRadioButton_CheckedChanged);
            // 
            // smoothieRadioButton
            // 
            this.smoothieRadioButton.AutoSize = true;
            this.smoothieRadioButton.Location = new System.Drawing.Point(46, 86);
            this.smoothieRadioButton.Name = "smoothieRadioButton";
            this.smoothieRadioButton.Size = new System.Drawing.Size(88, 21);
            this.smoothieRadioButton.TabIndex = 0;
            this.smoothieRadioButton.TabStop = true;
            this.smoothieRadioButton.Text = "Smoothie";
            this.smoothieRadioButton.UseVisualStyleBackColor = true;
            this.smoothieRadioButton.CheckedChanged += new System.EventHandler(this.smoothieRadioButton_CheckedChanged);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.LightCoral;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.label11);
            this.panel3.Controls.Add(this.dessertQtext);
            this.panel3.Controls.Add(this.dessertPriceText);
            this.panel3.Controls.Add(this.tableLayoutPanel3);
            this.panel3.Controls.Add(this.label12);
            this.panel3.Controls.Add(this.label13);
            this.panel3.Controls.Add(this.shortCakeRadioButton);
            this.panel3.Controls.Add(this.cupCakeRadioButton);
            this.panel3.Location = new System.Drawing.Point(1232, 165);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(346, 472);
            this.panel3.TabIndex = 10;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(14, 9);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(76, 20);
            this.label11.TabIndex = 9;
            this.label11.Text = "Dessert";
            // 
            // dessertQtext
            // 
            this.dessertQtext.BackColor = System.Drawing.SystemColors.Window;
            this.dessertQtext.Location = new System.Drawing.Point(207, 373);
            this.dessertQtext.Name = "dessertQtext";
            this.dessertQtext.Size = new System.Drawing.Size(100, 22);
            this.dessertQtext.TabIndex = 8;
            this.dessertQtext.Text = "0";
            this.dessertQtext.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // dessertPriceText
            // 
            this.dessertPriceText.Enabled = false;
            this.dessertPriceText.Location = new System.Drawing.Point(207, 309);
            this.dessertPriceText.Name = "dessertPriceText";
            this.dessertPriceText.ReadOnly = true;
            this.dessertPriceText.Size = new System.Drawing.Size(100, 22);
            this.dessertPriceText.TabIndex = 0;
            this.dessertPriceText.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 1;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Controls.Add(this.pictureBox5, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.pictureBox6, 0, 0);
            this.tableLayoutPanel3.Location = new System.Drawing.Point(180, 57);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 2;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(152, 189);
            this.tableLayoutPanel3.TabIndex = 7;
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox5.Image")));
            this.pictureBox5.Location = new System.Drawing.Point(3, 97);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(146, 88);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox5.TabIndex = 1;
            this.pictureBox5.TabStop = false;
            // 
            // pictureBox6
            // 
            this.pictureBox6.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox6.Image")));
            this.pictureBox6.Location = new System.Drawing.Point(3, 3);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(146, 88);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox6.TabIndex = 0;
            this.pictureBox6.TabStop = false;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(63, 378);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(114, 17);
            this.label12.TabIndex = 3;
            this.label12.Text = "Dessert Quantity";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(63, 309);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(93, 17);
            this.label13.TabIndex = 2;
            this.label13.Text = "Dessert Price";
            // 
            // shortCakeRadioButton
            // 
            this.shortCakeRadioButton.AutoSize = true;
            this.shortCakeRadioButton.Location = new System.Drawing.Point(46, 185);
            this.shortCakeRadioButton.Name = "shortCakeRadioButton";
            this.shortCakeRadioButton.Size = new System.Drawing.Size(99, 21);
            this.shortCakeRadioButton.TabIndex = 1;
            this.shortCakeRadioButton.TabStop = true;
            this.shortCakeRadioButton.Text = "Short Cake";
            this.shortCakeRadioButton.UseVisualStyleBackColor = true;
            this.shortCakeRadioButton.CheckedChanged += new System.EventHandler(this.shortCakeRadioButton_CheckedChanged);
            // 
            // cupCakeRadioButton
            // 
            this.cupCakeRadioButton.AutoSize = true;
            this.cupCakeRadioButton.Location = new System.Drawing.Point(46, 86);
            this.cupCakeRadioButton.Name = "cupCakeRadioButton";
            this.cupCakeRadioButton.Size = new System.Drawing.Size(90, 21);
            this.cupCakeRadioButton.TabIndex = 0;
            this.cupCakeRadioButton.TabStop = true;
            this.cupCakeRadioButton.Text = "Cup Cake";
            this.cupCakeRadioButton.UseVisualStyleBackColor = true;
            this.cupCakeRadioButton.CheckedChanged += new System.EventHandler(this.cupCakeRadioButton_CheckedChanged);
            // 
            // calculateButton
            // 
            this.calculateButton.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.calculateButton.Cursor = System.Windows.Forms.Cursors.Default;
            this.calculateButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.calculateButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.calculateButton.Location = new System.Drawing.Point(1066, 65);
            this.calculateButton.Name = "calculateButton";
            this.calculateButton.Size = new System.Drawing.Size(141, 42);
            this.calculateButton.TabIndex = 11;
            this.calculateButton.Text = "Calculate";
            this.calculateButton.UseVisualStyleBackColor = false;
            this.calculateButton.Click += new System.EventHandler(this.calculateButton_Click);
            // 
            // clearButton
            // 
            this.clearButton.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.clearButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.clearButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clearButton.Location = new System.Drawing.Point(1288, 65);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(141, 42);
            this.clearButton.TabIndex = 12;
            this.clearButton.Text = "Clear";
            this.clearButton.UseVisualStyleBackColor = false;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.exitButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.exitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitButton.Location = new System.Drawing.Point(1506, 65);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(141, 42);
            this.exitButton.TabIndex = 13;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = false;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // frmNickMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MistyRose;
            this.ClientSize = new System.Drawing.Size(1782, 934);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.calculateButton);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.messageLabel);
            this.Controls.Add(this.dessertsLabel);
            this.Controls.Add(this.drinksLabel);
            this.Controls.Add(this.saladLabel);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Menu);
            this.Name = "frmNickMenu";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Menu;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox saladQuantityText;
        private System.Windows.Forms.TextBox saladPriceText;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton pastaSaladRadioButton;
        private System.Windows.Forms.RadioButton fruitSaladRadioButton;
        private System.Windows.Forms.Label saladLabel;
        private System.Windows.Forms.Label drinksLabel;
        private System.Windows.Forms.Label dessertsLabel;
        private System.Windows.Forms.Label messageLabel;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox drinkNumberText;
        private System.Windows.Forms.TextBox drinkPriceText;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.RadioButton fruitJuiceRadioButton;
        private System.Windows.Forms.RadioButton smoothieRadioButton;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox dessertQtext;
        private System.Windows.Forms.TextBox dessertPriceText;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.RadioButton shortCakeRadioButton;
        private System.Windows.Forms.RadioButton cupCakeRadioButton;
        private System.Windows.Forms.Button calculateButton;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Button exitButton;
    }
}

