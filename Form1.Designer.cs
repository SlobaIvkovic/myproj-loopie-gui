namespace Loopie_Helper_GUI
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
            panel2 = new Panel();
            picMinimize = new PictureBox();
            picExpand = new PictureBox();
            picClose = new PictureBox();
            panelSideMenu = new Panel();
            panelPredict = new Panel();
            buttonPredict = new Button();
            panelFavorites = new Panel();
            buttonFavorites = new Button();
            panelAnalyze = new Panel();
            panelCustomYellow = new Panel();
            Custom = new Button();
            button1 = new Button();
            buttonAnalyze = new Button();
            panelCompetitions = new Panel();
            panelInternational = new Panel();
            buttonConference = new Button();
            buttonEuropa = new Button();
            buttonChampions = new Button();
            buttonInternational = new Button();
            panelDomestic = new Panel();
            panelSpain = new Panel();
            buttonSpain3 = new Button();
            buttonSpain2 = new Button();
            buttonSpain1 = new Button();
            buttonSpain = new Button();
            panelItaly = new Panel();
            buttonItaly3 = new Button();
            buttonItaly2 = new Button();
            buttonItaly1 = new Button();
            buttonItaly = new Button();
            buttonDomestic = new Button();
            buttonCompetitions = new Button();
            panelLogo = new Panel();
            pictureBox4 = new PictureBox();
            panelSubForm = new Panel();
            splitter1 = new Splitter();
            panelTextBox = new Panel();
            outputTextBox = new TextBox();
            pictureBox1 = new PictureBox();
            panelWindow = new Panel();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picMinimize).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picExpand).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picClose).BeginInit();
            panelSideMenu.SuspendLayout();
            panelAnalyze.SuspendLayout();
            panelCompetitions.SuspendLayout();
            panelInternational.SuspendLayout();
            panelDomestic.SuspendLayout();
            panelSpain.SuspendLayout();
            panelItaly.SuspendLayout();
            panelLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            panelSubForm.SuspendLayout();
            panelTextBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panelWindow.SuspendLayout();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(6, 23, 14);
            panel2.Controls.Add(picMinimize);
            panel2.Controls.Add(picExpand);
            panel2.Controls.Add(picClose);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Margin = new Padding(5);
            panel2.Name = "panel2";
            panel2.Size = new Size(1276, 32);
            panel2.TabIndex = 0;
            panel2.MouseDown += panel2_MouseDown;
            // 
            // picMinimize
            // 
            picMinimize.Dock = DockStyle.Right;
            picMinimize.Image = Properties.Resources.window_minimize;
            picMinimize.Location = new Point(1180, 0);
            picMinimize.Name = "picMinimize";
            picMinimize.Size = new Size(32, 32);
            picMinimize.SizeMode = PictureBoxSizeMode.CenterImage;
            picMinimize.TabIndex = 5;
            picMinimize.TabStop = false;
            picMinimize.Click += picMinimize_Click;
            picMinimize.MouseEnter += picMinimize_MouseEnter;
            picMinimize.MouseLeave += picMinimize_MouseLeave;
            // 
            // picExpand
            // 
            picExpand.Dock = DockStyle.Right;
            picExpand.Image = Properties.Resources.expand;
            picExpand.Location = new Point(1212, 0);
            picExpand.Name = "picExpand";
            picExpand.Size = new Size(32, 32);
            picExpand.SizeMode = PictureBoxSizeMode.CenterImage;
            picExpand.TabIndex = 4;
            picExpand.TabStop = false;
            picExpand.Click += picExpand_Click;
            picExpand.MouseEnter += picExpand_MouseEnter;
            picExpand.MouseLeave += picExpand_MouseLeave;
            // 
            // picClose
            // 
            picClose.Dock = DockStyle.Right;
            picClose.Image = Properties.Resources.x;
            picClose.Location = new Point(1244, 0);
            picClose.Name = "picClose";
            picClose.Size = new Size(32, 32);
            picClose.SizeMode = PictureBoxSizeMode.CenterImage;
            picClose.TabIndex = 3;
            picClose.TabStop = false;
            picClose.Click += picClose_Click;
            picClose.MouseEnter += picClose_MouseEnter;
            picClose.MouseLeave += picClose_MouseLeave;
            // 
            // panelSideMenu
            // 
            panelSideMenu.AutoScroll = true;
            panelSideMenu.BackColor = Color.FromArgb(6, 23, 14);
            panelSideMenu.Controls.Add(panelPredict);
            panelSideMenu.Controls.Add(buttonPredict);
            panelSideMenu.Controls.Add(panelFavorites);
            panelSideMenu.Controls.Add(buttonFavorites);
            panelSideMenu.Controls.Add(panelAnalyze);
            panelSideMenu.Controls.Add(buttonAnalyze);
            panelSideMenu.Controls.Add(panelCompetitions);
            panelSideMenu.Controls.Add(buttonCompetitions);
            panelSideMenu.Controls.Add(panelLogo);
            panelSideMenu.Dock = DockStyle.Left;
            panelSideMenu.Location = new Point(0, 32);
            panelSideMenu.Margin = new Padding(5);
            panelSideMenu.Name = "panelSideMenu";
            panelSideMenu.Padding = new Padding(0, 0, 2, 0);
            panelSideMenu.Size = new Size(347, 730);
            panelSideMenu.TabIndex = 1;
            // 
            // panelPredict
            // 
            panelPredict.BackColor = Color.FromArgb(255, 192, 192);
            panelPredict.Dock = DockStyle.Top;
            panelPredict.Location = new Point(0, 1283);
            panelPredict.Name = "panelPredict";
            panelPredict.Size = new Size(328, 55);
            panelPredict.TabIndex = 2;
            // 
            // buttonPredict
            // 
            buttonPredict.Dock = DockStyle.Top;
            buttonPredict.FlatAppearance.BorderSize = 0;
            buttonPredict.FlatStyle = FlatStyle.Flat;
            buttonPredict.Image = Properties.Resources.hat_wizard_solid;
            buttonPredict.ImageAlign = ContentAlignment.MiddleLeft;
            buttonPredict.Location = new Point(0, 1238);
            buttonPredict.Name = "buttonPredict";
            buttonPredict.Padding = new Padding(10, 0, 0, 0);
            buttonPredict.Size = new Size(328, 45);
            buttonPredict.TabIndex = 6;
            buttonPredict.Text = "Predict";
            buttonPredict.TextAlign = ContentAlignment.MiddleLeft;
            buttonPredict.TextImageRelation = TextImageRelation.ImageBeforeText;
            buttonPredict.UseVisualStyleBackColor = true;
            buttonPredict.Click += buttonPredict_Click;
            buttonPredict.MouseEnter += buttonPredict_MouseEnter;
            buttonPredict.MouseLeave += buttonPredict_MouseLeave;
            // 
            // panelFavorites
            // 
            panelFavorites.BackColor = Color.FromArgb(22, 184, 134);
            panelFavorites.Dock = DockStyle.Top;
            panelFavorites.Location = new Point(0, 1204);
            panelFavorites.Name = "panelFavorites";
            panelFavorites.Size = new Size(328, 34);
            panelFavorites.TabIndex = 5;
            // 
            // buttonFavorites
            // 
            buttonFavorites.Dock = DockStyle.Top;
            buttonFavorites.FlatAppearance.BorderSize = 0;
            buttonFavorites.FlatStyle = FlatStyle.Flat;
            buttonFavorites.Image = Properties.Resources.star_solid;
            buttonFavorites.ImageAlign = ContentAlignment.MiddleLeft;
            buttonFavorites.Location = new Point(0, 1159);
            buttonFavorites.Name = "buttonFavorites";
            buttonFavorites.Padding = new Padding(10, 0, 0, 0);
            buttonFavorites.Size = new Size(328, 45);
            buttonFavorites.TabIndex = 4;
            buttonFavorites.Text = "Favorites";
            buttonFavorites.TextAlign = ContentAlignment.MiddleLeft;
            buttonFavorites.TextImageRelation = TextImageRelation.ImageBeforeText;
            buttonFavorites.UseVisualStyleBackColor = true;
            buttonFavorites.Click += buttonFavorites_Click;
            buttonFavorites.MouseEnter += buttonFavorites_MouseEnter;
            buttonFavorites.MouseLeave += buttonFavorites_MouseLeave;
            // 
            // panelAnalyze
            // 
            panelAnalyze.AutoSize = true;
            panelAnalyze.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            panelAnalyze.BackColor = Color.FromArgb(22, 184, 134);
            panelAnalyze.Controls.Add(panelCustomYellow);
            panelAnalyze.Controls.Add(Custom);
            panelAnalyze.Controls.Add(button1);
            panelAnalyze.Dock = DockStyle.Top;
            panelAnalyze.Location = new Point(0, 1018);
            panelAnalyze.Name = "panelAnalyze";
            panelAnalyze.Size = new Size(328, 141);
            panelAnalyze.TabIndex = 3;
            // 
            // panelCustomYellow
            // 
            panelCustomYellow.BackColor = Color.FromArgb(255, 255, 128);
            panelCustomYellow.Dock = DockStyle.Top;
            panelCustomYellow.Location = new Point(0, 90);
            panelCustomYellow.Name = "panelCustomYellow";
            panelCustomYellow.Size = new Size(328, 51);
            panelCustomYellow.TabIndex = 2;
            // 
            // Custom
            // 
            Custom.Dock = DockStyle.Top;
            Custom.FlatAppearance.BorderSize = 0;
            Custom.FlatStyle = FlatStyle.Flat;
            Custom.Location = new Point(0, 45);
            Custom.Name = "Custom";
            Custom.Padding = new Padding(30, 0, 0, 0);
            Custom.Size = new Size(328, 45);
            Custom.TabIndex = 1;
            Custom.Text = "Custom";
            Custom.TextAlign = ContentAlignment.MiddleLeft;
            Custom.UseVisualStyleBackColor = true;
            Custom.Click += Custom_Click;
            // 
            // button1
            // 
            button1.AutoSize = true;
            button1.Dock = DockStyle.Top;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Location = new Point(0, 0);
            button1.Name = "button1";
            button1.Padding = new Padding(30, 0, 0, 0);
            button1.Size = new Size(328, 45);
            button1.TabIndex = 0;
            button1.Text = "Standard";
            button1.TextAlign = ContentAlignment.MiddleLeft;
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // buttonAnalyze
            // 
            buttonAnalyze.Dock = DockStyle.Top;
            buttonAnalyze.FlatAppearance.BorderSize = 0;
            buttonAnalyze.FlatStyle = FlatStyle.Flat;
            buttonAnalyze.ForeColor = Color.FromArgb(238, 238, 238);
            buttonAnalyze.Image = Properties.Resources.chart_line_solid;
            buttonAnalyze.ImageAlign = ContentAlignment.MiddleLeft;
            buttonAnalyze.Location = new Point(0, 973);
            buttonAnalyze.Name = "buttonAnalyze";
            buttonAnalyze.Padding = new Padding(10, 0, 0, 0);
            buttonAnalyze.Size = new Size(328, 45);
            buttonAnalyze.TabIndex = 2;
            buttonAnalyze.Text = "Analyze";
            buttonAnalyze.TextAlign = ContentAlignment.MiddleLeft;
            buttonAnalyze.TextImageRelation = TextImageRelation.ImageBeforeText;
            buttonAnalyze.UseVisualStyleBackColor = true;
            buttonAnalyze.Click += buttonAnalyze_Click;
            buttonAnalyze.MouseEnter += buttonAnalyze_MouseEnter;
            buttonAnalyze.MouseLeave += buttonAnalyze_MouseLeave;
            // 
            // panelCompetitions
            // 
            panelCompetitions.AutoSize = true;
            panelCompetitions.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            panelCompetitions.BackColor = Color.FromArgb(12, 45, 28);
            panelCompetitions.Controls.Add(panelInternational);
            panelCompetitions.Controls.Add(buttonInternational);
            panelCompetitions.Controls.Add(panelDomestic);
            panelCompetitions.Controls.Add(buttonDomestic);
            panelCompetitions.Dock = DockStyle.Top;
            panelCompetitions.Location = new Point(0, 388);
            panelCompetitions.Name = "panelCompetitions";
            panelCompetitions.Size = new Size(328, 585);
            panelCompetitions.TabIndex = 1;
            panelCompetitions.Visible = false;
            // 
            // panelInternational
            // 
            panelInternational.AutoSize = true;
            panelInternational.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            panelInternational.BackColor = Color.FromArgb(56, 239, 171);
            panelInternational.Controls.Add(buttonConference);
            panelInternational.Controls.Add(buttonEuropa);
            panelInternational.Controls.Add(buttonChampions);
            panelInternational.Dock = DockStyle.Top;
            panelInternational.Location = new Point(0, 450);
            panelInternational.Name = "panelInternational";
            panelInternational.Size = new Size(328, 135);
            panelInternational.TabIndex = 4;
            // 
            // buttonConference
            // 
            buttonConference.Dock = DockStyle.Top;
            buttonConference.FlatAppearance.BorderSize = 0;
            buttonConference.FlatStyle = FlatStyle.Flat;
            buttonConference.ForeColor = Color.FromArgb(238, 238, 238);
            buttonConference.Location = new Point(0, 90);
            buttonConference.Name = "buttonConference";
            buttonConference.Padding = new Padding(50, 0, 0, 0);
            buttonConference.Size = new Size(328, 45);
            buttonConference.TabIndex = 5;
            buttonConference.Text = "League Conference";
            buttonConference.TextAlign = ContentAlignment.MiddleLeft;
            buttonConference.UseVisualStyleBackColor = true;
            // 
            // buttonEuropa
            // 
            buttonEuropa.Dock = DockStyle.Top;
            buttonEuropa.FlatAppearance.BorderSize = 0;
            buttonEuropa.FlatStyle = FlatStyle.Flat;
            buttonEuropa.ForeColor = Color.FromArgb(238, 238, 238);
            buttonEuropa.Location = new Point(0, 45);
            buttonEuropa.Name = "buttonEuropa";
            buttonEuropa.Padding = new Padding(50, 0, 0, 0);
            buttonEuropa.Size = new Size(328, 45);
            buttonEuropa.TabIndex = 4;
            buttonEuropa.Text = "Europa League";
            buttonEuropa.TextAlign = ContentAlignment.MiddleLeft;
            buttonEuropa.UseVisualStyleBackColor = true;
            // 
            // buttonChampions
            // 
            buttonChampions.Dock = DockStyle.Top;
            buttonChampions.FlatAppearance.BorderSize = 0;
            buttonChampions.FlatStyle = FlatStyle.Flat;
            buttonChampions.ForeColor = Color.FromArgb(238, 238, 238);
            buttonChampions.Location = new Point(0, 0);
            buttonChampions.Name = "buttonChampions";
            buttonChampions.Padding = new Padding(50, 0, 0, 0);
            buttonChampions.Size = new Size(328, 45);
            buttonChampions.TabIndex = 2;
            buttonChampions.Text = "ChampionsLeague";
            buttonChampions.TextAlign = ContentAlignment.MiddleLeft;
            buttonChampions.UseVisualStyleBackColor = true;
            // 
            // buttonInternational
            // 
            buttonInternational.Dock = DockStyle.Top;
            buttonInternational.FlatAppearance.BorderSize = 0;
            buttonInternational.FlatStyle = FlatStyle.Flat;
            buttonInternational.ForeColor = Color.FromArgb(238, 238, 238);
            buttonInternational.Image = Properties.Resources.earth_europe_solid;
            buttonInternational.ImageAlign = ContentAlignment.MiddleLeft;
            buttonInternational.Location = new Point(0, 405);
            buttonInternational.Name = "buttonInternational";
            buttonInternational.Padding = new Padding(30, 0, 0, 0);
            buttonInternational.Size = new Size(328, 45);
            buttonInternational.TabIndex = 3;
            buttonInternational.Text = "International";
            buttonInternational.TextAlign = ContentAlignment.MiddleLeft;
            buttonInternational.TextImageRelation = TextImageRelation.ImageBeforeText;
            buttonInternational.UseVisualStyleBackColor = true;
            buttonInternational.Click += buttonInternational_Click;
            buttonInternational.MouseEnter += buttonInternational_MouseEnter;
            buttonInternational.MouseLeave += buttonInternational_MouseLeave;
            // 
            // panelDomestic
            // 
            panelDomestic.AutoSize = true;
            panelDomestic.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            panelDomestic.BackColor = Color.FromArgb(56, 239, 171);
            panelDomestic.Controls.Add(panelSpain);
            panelDomestic.Controls.Add(buttonSpain);
            panelDomestic.Controls.Add(panelItaly);
            panelDomestic.Controls.Add(buttonItaly);
            panelDomestic.Dock = DockStyle.Top;
            panelDomestic.Location = new Point(0, 45);
            panelDomestic.Name = "panelDomestic";
            panelDomestic.Size = new Size(328, 360);
            panelDomestic.TabIndex = 2;
            // 
            // panelSpain
            // 
            panelSpain.AutoSize = true;
            panelSpain.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            panelSpain.BackColor = Color.FromArgb(154, 236, 153);
            panelSpain.Controls.Add(buttonSpain3);
            panelSpain.Controls.Add(buttonSpain2);
            panelSpain.Controls.Add(buttonSpain1);
            panelSpain.Dock = DockStyle.Top;
            panelSpain.Location = new Point(0, 225);
            panelSpain.Name = "panelSpain";
            panelSpain.Size = new Size(328, 135);
            panelSpain.TabIndex = 5;
            // 
            // buttonSpain3
            // 
            buttonSpain3.Dock = DockStyle.Top;
            buttonSpain3.FlatAppearance.BorderSize = 0;
            buttonSpain3.FlatStyle = FlatStyle.Flat;
            buttonSpain3.ForeColor = Color.FromArgb(238, 238, 238);
            buttonSpain3.Location = new Point(0, 90);
            buttonSpain3.Name = "buttonSpain3";
            buttonSpain3.Padding = new Padding(60, 0, 0, 0);
            buttonSpain3.Size = new Size(328, 45);
            buttonSpain3.TabIndex = 5;
            buttonSpain3.Text = "Spain 3";
            buttonSpain3.TextAlign = ContentAlignment.MiddleLeft;
            buttonSpain3.UseVisualStyleBackColor = true;
            // 
            // buttonSpain2
            // 
            buttonSpain2.Dock = DockStyle.Top;
            buttonSpain2.FlatAppearance.BorderSize = 0;
            buttonSpain2.FlatStyle = FlatStyle.Flat;
            buttonSpain2.ForeColor = Color.FromArgb(238, 238, 238);
            buttonSpain2.Location = new Point(0, 45);
            buttonSpain2.Name = "buttonSpain2";
            buttonSpain2.Padding = new Padding(60, 0, 0, 0);
            buttonSpain2.Size = new Size(328, 45);
            buttonSpain2.TabIndex = 4;
            buttonSpain2.Text = "Spain 2";
            buttonSpain2.TextAlign = ContentAlignment.MiddleLeft;
            buttonSpain2.UseVisualStyleBackColor = true;
            // 
            // buttonSpain1
            // 
            buttonSpain1.Dock = DockStyle.Top;
            buttonSpain1.FlatAppearance.BorderSize = 0;
            buttonSpain1.FlatStyle = FlatStyle.Flat;
            buttonSpain1.ForeColor = Color.FromArgb(238, 238, 238);
            buttonSpain1.Location = new Point(0, 0);
            buttonSpain1.Name = "buttonSpain1";
            buttonSpain1.Padding = new Padding(60, 0, 0, 0);
            buttonSpain1.Size = new Size(328, 45);
            buttonSpain1.TabIndex = 3;
            buttonSpain1.Text = "Spain 1";
            buttonSpain1.TextAlign = ContentAlignment.MiddleLeft;
            buttonSpain1.UseVisualStyleBackColor = true;
            // 
            // buttonSpain
            // 
            buttonSpain.Dock = DockStyle.Top;
            buttonSpain.FlatAppearance.BorderSize = 0;
            buttonSpain.FlatStyle = FlatStyle.Flat;
            buttonSpain.ForeColor = Color.FromArgb(238, 238, 238);
            buttonSpain.Image = Properties.Resources.futbol_solid;
            buttonSpain.ImageAlign = ContentAlignment.MiddleLeft;
            buttonSpain.Location = new Point(0, 180);
            buttonSpain.Name = "buttonSpain";
            buttonSpain.Padding = new Padding(50, 0, 0, 0);
            buttonSpain.Size = new Size(328, 45);
            buttonSpain.TabIndex = 4;
            buttonSpain.Text = "Spain";
            buttonSpain.TextAlign = ContentAlignment.MiddleLeft;
            buttonSpain.TextImageRelation = TextImageRelation.ImageBeforeText;
            buttonSpain.UseVisualStyleBackColor = true;
            buttonSpain.Click += buttonSpain_Click;
            buttonSpain.MouseEnter += buttonSpain_MouseEnter;
            buttonSpain.MouseLeave += buttonSpain_MouseLeave;
            // 
            // panelItaly
            // 
            panelItaly.AutoSize = true;
            panelItaly.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            panelItaly.BackColor = Color.FromArgb(154, 236, 153);
            panelItaly.Controls.Add(buttonItaly3);
            panelItaly.Controls.Add(buttonItaly2);
            panelItaly.Controls.Add(buttonItaly1);
            panelItaly.Dock = DockStyle.Top;
            panelItaly.Location = new Point(0, 45);
            panelItaly.Name = "panelItaly";
            panelItaly.Size = new Size(328, 135);
            panelItaly.TabIndex = 3;
            // 
            // buttonItaly3
            // 
            buttonItaly3.Dock = DockStyle.Top;
            buttonItaly3.FlatAppearance.BorderSize = 0;
            buttonItaly3.FlatStyle = FlatStyle.Flat;
            buttonItaly3.ForeColor = Color.FromArgb(238, 238, 238);
            buttonItaly3.Location = new Point(0, 90);
            buttonItaly3.Name = "buttonItaly3";
            buttonItaly3.Padding = new Padding(60, 0, 0, 0);
            buttonItaly3.Size = new Size(328, 45);
            buttonItaly3.TabIndex = 5;
            buttonItaly3.Text = "Italy 3";
            buttonItaly3.TextAlign = ContentAlignment.MiddleLeft;
            buttonItaly3.UseVisualStyleBackColor = true;
            // 
            // buttonItaly2
            // 
            buttonItaly2.Dock = DockStyle.Top;
            buttonItaly2.FlatAppearance.BorderSize = 0;
            buttonItaly2.FlatStyle = FlatStyle.Flat;
            buttonItaly2.ForeColor = Color.FromArgb(238, 238, 238);
            buttonItaly2.Location = new Point(0, 45);
            buttonItaly2.Name = "buttonItaly2";
            buttonItaly2.Padding = new Padding(60, 0, 0, 0);
            buttonItaly2.Size = new Size(328, 45);
            buttonItaly2.TabIndex = 4;
            buttonItaly2.Text = "Italy 2";
            buttonItaly2.TextAlign = ContentAlignment.MiddleLeft;
            buttonItaly2.UseVisualStyleBackColor = true;
            buttonItaly2.Click += buttonItaly2_Click;
            // 
            // buttonItaly1
            // 
            buttonItaly1.Dock = DockStyle.Top;
            buttonItaly1.FlatAppearance.BorderSize = 0;
            buttonItaly1.FlatStyle = FlatStyle.Flat;
            buttonItaly1.ForeColor = Color.FromArgb(238, 238, 238);
            buttonItaly1.ImageAlign = ContentAlignment.MiddleLeft;
            buttonItaly1.Location = new Point(0, 0);
            buttonItaly1.Name = "buttonItaly1";
            buttonItaly1.Padding = new Padding(60, 0, 0, 0);
            buttonItaly1.Size = new Size(328, 45);
            buttonItaly1.TabIndex = 3;
            buttonItaly1.Text = "Italy 1";
            buttonItaly1.TextAlign = ContentAlignment.MiddleLeft;
            buttonItaly1.TextImageRelation = TextImageRelation.ImageBeforeText;
            buttonItaly1.UseVisualStyleBackColor = true;
            buttonItaly1.Click += buttonItaly1_Click;
            buttonItaly1.MouseEnter += buttonItaly1_MouseEnter;
            buttonItaly1.MouseLeave += buttonItaly1_MouseLeave;
            // 
            // buttonItaly
            // 
            buttonItaly.Dock = DockStyle.Top;
            buttonItaly.FlatAppearance.BorderSize = 0;
            buttonItaly.FlatStyle = FlatStyle.Flat;
            buttonItaly.ForeColor = Color.FromArgb(238, 238, 238);
            buttonItaly.Image = Properties.Resources.futbol_solid;
            buttonItaly.ImageAlign = ContentAlignment.MiddleLeft;
            buttonItaly.Location = new Point(0, 0);
            buttonItaly.Name = "buttonItaly";
            buttonItaly.Padding = new Padding(50, 0, 0, 0);
            buttonItaly.Size = new Size(328, 45);
            buttonItaly.TabIndex = 2;
            buttonItaly.Text = "Italy";
            buttonItaly.TextAlign = ContentAlignment.MiddleLeft;
            buttonItaly.TextImageRelation = TextImageRelation.ImageBeforeText;
            buttonItaly.UseVisualStyleBackColor = true;
            buttonItaly.Click += buttonItaly_Click;
            buttonItaly.MouseEnter += buttonItaly_MouseEnter;
            buttonItaly.MouseLeave += buttonItaly_MouseLeave;
            // 
            // buttonDomestic
            // 
            buttonDomestic.Dock = DockStyle.Top;
            buttonDomestic.FlatAppearance.BorderSize = 0;
            buttonDomestic.FlatStyle = FlatStyle.Flat;
            buttonDomestic.ForeColor = Color.FromArgb(238, 238, 238);
            buttonDomestic.Image = Properties.Resources.medal_solid;
            buttonDomestic.ImageAlign = ContentAlignment.MiddleLeft;
            buttonDomestic.Location = new Point(0, 0);
            buttonDomestic.Name = "buttonDomestic";
            buttonDomestic.Padding = new Padding(30, 0, 0, 0);
            buttonDomestic.Size = new Size(328, 45);
            buttonDomestic.TabIndex = 1;
            buttonDomestic.Text = "Domestic";
            buttonDomestic.TextAlign = ContentAlignment.MiddleLeft;
            buttonDomestic.TextImageRelation = TextImageRelation.ImageBeforeText;
            buttonDomestic.UseVisualStyleBackColor = true;
            buttonDomestic.Click += buttonDomestic_Click;
            buttonDomestic.MouseEnter += buttonDomestic_MouseEnter;
            buttonDomestic.MouseLeave += buttonDomestic_MouseLeave;
            // 
            // buttonCompetitions
            // 
            buttonCompetitions.Dock = DockStyle.Top;
            buttonCompetitions.FlatAppearance.BorderSize = 0;
            buttonCompetitions.FlatStyle = FlatStyle.Flat;
            buttonCompetitions.ForeColor = Color.FromArgb(238, 238, 238);
            buttonCompetitions.Image = Properties.Resources.trophy_solid;
            buttonCompetitions.ImageAlign = ContentAlignment.MiddleLeft;
            buttonCompetitions.Location = new Point(0, 343);
            buttonCompetitions.Name = "buttonCompetitions";
            buttonCompetitions.Padding = new Padding(10, 0, 0, 0);
            buttonCompetitions.Size = new Size(328, 45);
            buttonCompetitions.TabIndex = 0;
            buttonCompetitions.Text = "Competitions";
            buttonCompetitions.TextAlign = ContentAlignment.MiddleLeft;
            buttonCompetitions.TextImageRelation = TextImageRelation.ImageBeforeText;
            buttonCompetitions.UseVisualStyleBackColor = true;
            buttonCompetitions.Click += buttonCompetitions_Click;
            buttonCompetitions.MouseEnter += buttonCompetitions_MouseEnter;
            buttonCompetitions.MouseLeave += buttonCompetitions_MouseLeave;
            // 
            // panelLogo
            // 
            panelLogo.Controls.Add(pictureBox4);
            panelLogo.Dock = DockStyle.Top;
            panelLogo.Location = new Point(0, 0);
            panelLogo.Margin = new Padding(5);
            panelLogo.Name = "panelLogo";
            panelLogo.Size = new Size(328, 343);
            panelLogo.TabIndex = 0;
            // 
            // pictureBox4
            // 
            pictureBox4.Dock = DockStyle.Left;
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(0, 0);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(345, 343);
            pictureBox4.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox4.TabIndex = 0;
            pictureBox4.TabStop = false;
            // 
            // panelSubForm
            // 
            panelSubForm.Controls.Add(splitter1);
            panelSubForm.Controls.Add(panelTextBox);
            panelSubForm.Controls.Add(pictureBox1);
            panelSubForm.Dock = DockStyle.Fill;
            panelSubForm.Location = new Point(347, 32);
            panelSubForm.Name = "panelSubForm";
            panelSubForm.Size = new Size(929, 730);
            panelSubForm.TabIndex = 3;
            // 
            // splitter1
            // 
            splitter1.BackColor = Color.FromArgb(27, 102, 62);
            splitter1.Dock = DockStyle.Bottom;
            splitter1.Location = new Point(0, 608);
            splitter1.Name = "splitter1";
            splitter1.Size = new Size(929, 5);
            splitter1.TabIndex = 2;
            splitter1.TabStop = false;
            // 
            // panelTextBox
            // 
            panelTextBox.BackColor = Color.FromArgb(15, 57, 35);
            panelTextBox.Controls.Add(outputTextBox);
            panelTextBox.Dock = DockStyle.Bottom;
            panelTextBox.Location = new Point(0, 613);
            panelTextBox.Name = "panelTextBox";
            panelTextBox.Size = new Size(929, 117);
            panelTextBox.TabIndex = 1;
            // 
            // outputTextBox
            // 
            outputTextBox.AllowDrop = true;
            outputTextBox.BackColor = Color.FromArgb(15, 57, 35);
            outputTextBox.BorderStyle = BorderStyle.None;
            outputTextBox.Dock = DockStyle.Fill;
            outputTextBox.ForeColor = SystemColors.Window;
            outputTextBox.Location = new Point(0, 0);
            outputTextBox.Multiline = true;
            outputTextBox.Name = "outputTextBox";
            outputTextBox.ScrollBars = ScrollBars.Vertical;
            outputTextBox.Size = new Size(929, 117);
            outputTextBox.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.None;
            pictureBox1.Image = Properties.Resources.logoicon;
            pictureBox1.Location = new Point(213, 116);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(428, 438);
            pictureBox1.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // panelWindow
            // 
            panelWindow.AutoScroll = true;
            panelWindow.AutoSize = true;
            panelWindow.BackColor = Color.FromArgb(9, 34, 21);
            panelWindow.Controls.Add(panelSubForm);
            panelWindow.Controls.Add(panelSideMenu);
            panelWindow.Controls.Add(panel2);
            panelWindow.Dock = DockStyle.Fill;
            panelWindow.Location = new Point(2, 2);
            panelWindow.Margin = new Padding(5);
            panelWindow.Name = "panelWindow";
            panelWindow.Size = new Size(1276, 762);
            panelWindow.TabIndex = 0;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(11F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(49, 80, 71);
            ClientSize = new Size(1280, 766);
            Controls.Add(panelWindow);
            Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ForeColor = Color.FromArgb(238, 238, 238);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            ImeMode = ImeMode.AlphaFull;
            Margin = new Padding(5);
            Name = "Form1";
            Padding = new Padding(2);
            Text = "Loopie";
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)picMinimize).EndInit();
            ((System.ComponentModel.ISupportInitialize)picExpand).EndInit();
            ((System.ComponentModel.ISupportInitialize)picClose).EndInit();
            panelSideMenu.ResumeLayout(false);
            panelSideMenu.PerformLayout();
            panelAnalyze.ResumeLayout(false);
            panelAnalyze.PerformLayout();
            panelCompetitions.ResumeLayout(false);
            panelCompetitions.PerformLayout();
            panelInternational.ResumeLayout(false);
            panelDomestic.ResumeLayout(false);
            panelDomestic.PerformLayout();
            panelSpain.ResumeLayout(false);
            panelItaly.ResumeLayout(false);
            panelLogo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            panelSubForm.ResumeLayout(false);
            panelSubForm.PerformLayout();
            panelTextBox.ResumeLayout(false);
            panelTextBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panelWindow.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel2;
        private PictureBox picMinimize;
        private PictureBox picExpand;
        private PictureBox picClose;
        private Panel panelSideMenu;
        private Panel panelPredict;
        private Button buttonPredict;
        private Panel panelFavorites;
        private Button buttonFavorites;
        private Panel panelAnalyze;
        private Panel panelCustomYellow;
        private Button Custom;
        private Button button1;
        private Button buttonAnalyze;
        private Panel panelCompetitions;
        private Panel panelInternational;
        private Button buttonConference;
        private Button buttonEuropa;
        private Button buttonChampions;
        private Button buttonInternational;
        private Panel panelDomestic;
        private Panel panelSpain;
        private Button buttonSpain3;
        private Button buttonSpain2;
        private Button buttonSpain1;
        private Button buttonSpain;
        private Panel panelItaly;
        private Button buttonItaly3;
        private Button buttonItaly2;
        private Button buttonItaly1;
        private Button buttonItaly;
        private Button buttonDomestic;
        private Button buttonCompetitions;
        private Panel panelLogo;
        private PictureBox pictureBox4;
        private Panel panelSubForm;
        private PictureBox pictureBox1;
        private Panel panelWindow;
        private Panel panelTextBox;
        private TextBox outputTextBox;
        private Splitter splitter1;
    }
}
