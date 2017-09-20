using System.ComponentModel;
using System.Windows.Forms;
using iTunerSkin.Controls;

namespace iTunerManagerApp
{
    partial class TunerCreateItem
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private IContainer components = null;

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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TunerCreateItem));
            this.grpImage = new System.Windows.Forms.GroupBox();
            this.imageLoader = new System.Windows.Forms.PictureBox();
            this.btnFindImage = new iTunerSkin.Controls.iTunerRaisedButton();
            this.imageFind = new System.Windows.Forms.PictureBox();
            this.btnCreate = new iTunerSkin.Controls.iTunerRaisedButton();
            this.grpDevice = new System.Windows.Forms.GroupBox();
            this.btnGetWalkthrough = new iTunerSkin.Controls.iTunerRaisedButton();
            this.iTunerCheckBox10 = new iTunerSkin.Controls.iTunerCheckBox();
            this.iTunerCheckBox9 = new iTunerSkin.Controls.iTunerCheckBox();
            this.iTunerCheckBox8 = new iTunerSkin.Controls.iTunerCheckBox();
            this.iTunerCheckBox7 = new iTunerSkin.Controls.iTunerCheckBox();
            this.iTunerCheckBox6 = new iTunerSkin.Controls.iTunerCheckBox();
            this.iTunerCheckBox5 = new iTunerSkin.Controls.iTunerCheckBox();
            this.iTunerCheckBox4 = new iTunerSkin.Controls.iTunerCheckBox();
            this.iTunerCheckBox3 = new iTunerSkin.Controls.iTunerCheckBox();
            this.iTunerCheckBox2 = new iTunerSkin.Controls.iTunerCheckBox();
            this.iTunerCheckBox1 = new iTunerSkin.Controls.iTunerCheckBox();
            this.grpType = new System.Windows.Forms.GroupBox();
            this.iTunerRadioButton5 = new iTunerSkin.Controls.iTunerRadioButton();
            this.iTunerRadioButton4 = new iTunerSkin.Controls.iTunerRadioButton();
            this.iTunerRadioButton3 = new iTunerSkin.Controls.iTunerRadioButton();
            this.iTunerRadioButton1 = new iTunerSkin.Controls.iTunerRadioButton();
            this.iTunerRadioButton2 = new iTunerSkin.Controls.iTunerRadioButton();
            this.grpInformation = new System.Windows.Forms.GroupBox();
            this.txtGenre = new iTunerSkin.Controls.iTunerSingleLineTextField();
            this.lblGenre = new iTunerSkin.Controls.iTunerLabel();
            this.txtDescription = new iTunerSkin.Controls.iTunerSingleLineTextField();
            this.lblDescription = new iTunerSkin.Controls.iTunerLabel();
            this.lblName = new iTunerSkin.Controls.iTunerLabel();
            this.txtName = new iTunerSkin.Controls.iTunerSingleLineTextField();
            this.grpLocation = new System.Windows.Forms.GroupBox();
            this.btnAddFile = new iTunerSkin.Controls.iTunerRaisedButton();
            this.txtLocation = new iTunerSkin.Controls.iTunerSingleLineTextField();
            this.grpEmulator = new System.Windows.Forms.GroupBox();
            this.btnGetEmulator = new iTunerSkin.Controls.iTunerRaisedButton();
            this.iTunerCheckBox11 = new iTunerSkin.Controls.iTunerCheckBox();
            this.iTunerCheckBox12 = new iTunerSkin.Controls.iTunerCheckBox();
            this.iTunerCheckBox13 = new iTunerSkin.Controls.iTunerCheckBox();
            this.iTunerCheckBox14 = new iTunerSkin.Controls.iTunerCheckBox();
            this.iTunerCheckBox15 = new iTunerSkin.Controls.iTunerCheckBox();
            this.iTunerCheckBox16 = new iTunerSkin.Controls.iTunerCheckBox();
            this.iTunerCheckBox17 = new iTunerSkin.Controls.iTunerCheckBox();
            this.iTunerCheckBox18 = new iTunerSkin.Controls.iTunerCheckBox();
            this.iTunerCheckBox19 = new iTunerSkin.Controls.iTunerCheckBox();
            this.iTunerCheckBox20 = new iTunerSkin.Controls.iTunerCheckBox();
            this.grpImage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imageLoader)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageFind)).BeginInit();
            this.grpDevice.SuspendLayout();
            this.grpType.SuspendLayout();
            this.grpInformation.SuspendLayout();
            this.grpLocation.SuspendLayout();
            this.grpEmulator.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpImage
            // 
            this.grpImage.BackColor = System.Drawing.SystemColors.Control;
            this.grpImage.Controls.Add(this.imageLoader);
            this.grpImage.Controls.Add(this.btnFindImage);
            this.grpImage.Controls.Add(this.imageFind);
            this.grpImage.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.grpImage.Location = new System.Drawing.Point(12, 422);
            this.grpImage.Name = "grpImage";
            this.grpImage.Size = new System.Drawing.Size(256, 182);
            this.grpImage.TabIndex = 15;
            this.grpImage.TabStop = false;
            this.grpImage.Text = "Image Search:";
            // 
            // imageLoader
            // 
            this.imageLoader.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.imageLoader.BackColor = System.Drawing.Color.DarkGray;
            this.imageLoader.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.imageLoader.Cursor = System.Windows.Forms.Cursors.AppStarting;
            this.imageLoader.Image = global::iTunerManagerApp.Properties.Resources.Search;
            this.imageLoader.Location = new System.Drawing.Point(6, 19);
            this.imageLoader.Name = "imageLoader";
            this.imageLoader.Size = new System.Drawing.Size(157, 157);
            this.imageLoader.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imageLoader.TabIndex = 2;
            this.imageLoader.TabStop = false;
            this.imageLoader.Visible = false;
            // 
            // btnFindImage
            // 
            this.btnFindImage.AutoSize = true;
            this.btnFindImage.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnFindImage.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFindImage.Depth = 0;
            this.btnFindImage.Enabled = false;
            this.btnFindImage.Icon = null;
            this.btnFindImage.Location = new System.Drawing.Point(173, 140);
            this.btnFindImage.MouseState = iTunerSkin.MouseState.HOVER;
            this.btnFindImage.Name = "btnFindImage";
            this.btnFindImage.Primary = true;
            this.btnFindImage.Size = new System.Drawing.Size(77, 36);
            this.btnFindImage.TabIndex = 1;
            this.btnFindImage.Text = "Get Image";
            this.btnFindImage.UseVisualStyleBackColor = true;
            this.btnFindImage.Click += new System.EventHandler(this.btnFindImage_Click);
            // 
            // imageFind
            // 
            this.imageFind.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.imageFind.BackColor = System.Drawing.Color.White;
            this.imageFind.BackgroundImage = global::iTunerManagerApp.Properties.Resources.ImagePattern;
            this.imageFind.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.imageFind.Cursor = System.Windows.Forms.Cursors.No;
            this.imageFind.Image = global::iTunerManagerApp.Properties.Resources.ImagePattern;
            this.imageFind.Location = new System.Drawing.Point(6, 19);
            this.imageFind.Name = "imageFind";
            this.imageFind.Size = new System.Drawing.Size(157, 157);
            this.imageFind.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imageFind.TabIndex = 0;
            this.imageFind.TabStop = false;
            this.imageFind.WaitOnLoad = true;
            // 
            // btnCreate
            // 
            this.btnCreate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCreate.AutoSize = true;
            this.btnCreate.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnCreate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCreate.Depth = 0;
            this.btnCreate.Icon = null;
            this.btnCreate.Location = new System.Drawing.Point(760, 571);
            this.btnCreate.MouseState = iTunerSkin.MouseState.HOVER;
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Primary = true;
            this.btnCreate.Size = new System.Drawing.Size(60, 36);
            this.btnCreate.TabIndex = 14;
            this.btnCreate.Text = "Create";
            this.btnCreate.UseVisualStyleBackColor = true;
            // 
            // grpDevice
            // 
            this.grpDevice.BackColor = System.Drawing.SystemColors.Control;
            this.grpDevice.Controls.Add(this.btnGetWalkthrough);
            this.grpDevice.Controls.Add(this.iTunerCheckBox10);
            this.grpDevice.Controls.Add(this.iTunerCheckBox9);
            this.grpDevice.Controls.Add(this.iTunerCheckBox8);
            this.grpDevice.Controls.Add(this.iTunerCheckBox7);
            this.grpDevice.Controls.Add(this.iTunerCheckBox6);
            this.grpDevice.Controls.Add(this.iTunerCheckBox5);
            this.grpDevice.Controls.Add(this.iTunerCheckBox4);
            this.grpDevice.Controls.Add(this.iTunerCheckBox3);
            this.grpDevice.Controls.Add(this.iTunerCheckBox2);
            this.grpDevice.Controls.Add(this.iTunerCheckBox1);
            this.grpDevice.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.grpDevice.Location = new System.Drawing.Point(12, 294);
            this.grpDevice.Name = "grpDevice";
            this.grpDevice.Size = new System.Drawing.Size(401, 122);
            this.grpDevice.TabIndex = 13;
            this.grpDevice.TabStop = false;
            this.grpDevice.Text = "Consoles:";
            // 
            // btnGetWalkthrough
            // 
            this.btnGetWalkthrough.AutoSize = true;
            this.btnGetWalkthrough.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnGetWalkthrough.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGetWalkthrough.Depth = 0;
            this.btnGetWalkthrough.Icon = null;
            this.btnGetWalkthrough.Location = new System.Drawing.Point(271, 80);
            this.btnGetWalkthrough.MouseState = iTunerSkin.MouseState.HOVER;
            this.btnGetWalkthrough.Name = "btnGetWalkthrough";
            this.btnGetWalkthrough.Primary = true;
            this.btnGetWalkthrough.Size = new System.Drawing.Size(124, 36);
            this.btnGetWalkthrough.TabIndex = 10;
            this.btnGetWalkthrough.Text = "Get WalkThrough";
            this.btnGetWalkthrough.UseVisualStyleBackColor = true;
            // 
            // iTunerCheckBox10
            // 
            this.iTunerCheckBox10.AutoSize = true;
            this.iTunerCheckBox10.Cursor = System.Windows.Forms.Cursors.Hand;
            this.iTunerCheckBox10.Depth = 0;
            this.iTunerCheckBox10.Font = new System.Drawing.Font("Roboto", 8F);
            this.iTunerCheckBox10.Location = new System.Drawing.Point(289, 20);
            this.iTunerCheckBox10.Margin = new System.Windows.Forms.Padding(0);
            this.iTunerCheckBox10.MouseLocation = new System.Drawing.Point(-1, -1);
            this.iTunerCheckBox10.MouseState = iTunerSkin.MouseState.HOVER;
            this.iTunerCheckBox10.Name = "iTunerCheckBox10";
            this.iTunerCheckBox10.Ripple = true;
            this.iTunerCheckBox10.Size = new System.Drawing.Size(70, 30);
            this.iTunerCheckBox10.TabIndex = 9;
            this.iTunerCheckBox10.Text = "PS-VITA";
            this.iTunerCheckBox10.UseVisualStyleBackColor = true;
            // 
            // iTunerCheckBox9
            // 
            this.iTunerCheckBox9.AutoSize = true;
            this.iTunerCheckBox9.Cursor = System.Windows.Forms.Cursors.Hand;
            this.iTunerCheckBox9.Depth = 0;
            this.iTunerCheckBox9.Font = new System.Drawing.Font("Roboto", 8F);
            this.iTunerCheckBox9.Location = new System.Drawing.Point(78, 78);
            this.iTunerCheckBox9.Margin = new System.Windows.Forms.Padding(0);
            this.iTunerCheckBox9.MouseLocation = new System.Drawing.Point(-1, -1);
            this.iTunerCheckBox9.MouseState = iTunerSkin.MouseState.HOVER;
            this.iTunerCheckBox9.Name = "iTunerCheckBox9";
            this.iTunerCheckBox9.Ripple = true;
            this.iTunerCheckBox9.Size = new System.Drawing.Size(83, 30);
            this.iTunerCheckBox9.TabIndex = 8;
            this.iTunerCheckBox9.Text = "XBOX-ONE";
            this.iTunerCheckBox9.UseVisualStyleBackColor = true;
            // 
            // iTunerCheckBox8
            // 
            this.iTunerCheckBox8.AutoSize = true;
            this.iTunerCheckBox8.Cursor = System.Windows.Forms.Cursors.Hand;
            this.iTunerCheckBox8.Depth = 0;
            this.iTunerCheckBox8.Font = new System.Drawing.Font("Roboto", 8F);
            this.iTunerCheckBox8.Location = new System.Drawing.Point(121, 48);
            this.iTunerCheckBox8.Margin = new System.Windows.Forms.Padding(0);
            this.iTunerCheckBox8.MouseLocation = new System.Drawing.Point(-1, -1);
            this.iTunerCheckBox8.MouseState = iTunerSkin.MouseState.HOVER;
            this.iTunerCheckBox8.Name = "iTunerCheckBox8";
            this.iTunerCheckBox8.Ripple = true;
            this.iTunerCheckBox8.Size = new System.Drawing.Size(45, 30);
            this.iTunerCheckBox8.TabIndex = 7;
            this.iTunerCheckBox8.Text = "WII";
            this.iTunerCheckBox8.UseVisualStyleBackColor = true;
            // 
            // iTunerCheckBox7
            // 
            this.iTunerCheckBox7.AutoSize = true;
            this.iTunerCheckBox7.Cursor = System.Windows.Forms.Cursors.Hand;
            this.iTunerCheckBox7.Depth = 0;
            this.iTunerCheckBox7.Font = new System.Drawing.Font("Roboto", 8F);
            this.iTunerCheckBox7.Location = new System.Drawing.Point(13, 48);
            this.iTunerCheckBox7.Margin = new System.Windows.Forms.Padding(0);
            this.iTunerCheckBox7.MouseLocation = new System.Drawing.Point(-1, -1);
            this.iTunerCheckBox7.MouseState = iTunerSkin.MouseState.HOVER;
            this.iTunerCheckBox7.Name = "iTunerCheckBox7";
            this.iTunerCheckBox7.Ripple = true;
            this.iTunerCheckBox7.Size = new System.Drawing.Size(91, 30);
            this.iTunerCheckBox7.TabIndex = 6;
            this.iTunerCheckBox7.Text = "Nintendo-DS";
            this.iTunerCheckBox7.UseVisualStyleBackColor = true;
            // 
            // iTunerCheckBox6
            // 
            this.iTunerCheckBox6.AutoSize = true;
            this.iTunerCheckBox6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.iTunerCheckBox6.Depth = 0;
            this.iTunerCheckBox6.Font = new System.Drawing.Font("Roboto", 8F);
            this.iTunerCheckBox6.Location = new System.Drawing.Point(233, 20);
            this.iTunerCheckBox6.Margin = new System.Windows.Forms.Padding(0);
            this.iTunerCheckBox6.MouseLocation = new System.Drawing.Point(-1, -1);
            this.iTunerCheckBox6.MouseState = iTunerSkin.MouseState.HOVER;
            this.iTunerCheckBox6.Name = "iTunerCheckBox6";
            this.iTunerCheckBox6.Ripple = true;
            this.iTunerCheckBox6.Size = new System.Drawing.Size(50, 30);
            this.iTunerCheckBox6.TabIndex = 5;
            this.iTunerCheckBox6.Text = "PSP";
            this.iTunerCheckBox6.UseVisualStyleBackColor = true;
            // 
            // iTunerCheckBox5
            // 
            this.iTunerCheckBox5.AutoSize = true;
            this.iTunerCheckBox5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.iTunerCheckBox5.Depth = 0;
            this.iTunerCheckBox5.Font = new System.Drawing.Font("Roboto", 8F);
            this.iTunerCheckBox5.Location = new System.Drawing.Point(178, 20);
            this.iTunerCheckBox5.Margin = new System.Windows.Forms.Padding(0);
            this.iTunerCheckBox5.MouseLocation = new System.Drawing.Point(-1, -1);
            this.iTunerCheckBox5.MouseState = iTunerSkin.MouseState.HOVER;
            this.iTunerCheckBox5.Name = "iTunerCheckBox5";
            this.iTunerCheckBox5.Ripple = true;
            this.iTunerCheckBox5.Size = new System.Drawing.Size(49, 30);
            this.iTunerCheckBox5.TabIndex = 4;
            this.iTunerCheckBox5.Text = "PS4";
            this.iTunerCheckBox5.UseVisualStyleBackColor = true;
            // 
            // iTunerCheckBox4
            // 
            this.iTunerCheckBox4.AutoSize = true;
            this.iTunerCheckBox4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.iTunerCheckBox4.Depth = 0;
            this.iTunerCheckBox4.Font = new System.Drawing.Font("Roboto", 8F);
            this.iTunerCheckBox4.Location = new System.Drawing.Point(123, 20);
            this.iTunerCheckBox4.Margin = new System.Windows.Forms.Padding(0);
            this.iTunerCheckBox4.MouseLocation = new System.Drawing.Point(-1, -1);
            this.iTunerCheckBox4.MouseState = iTunerSkin.MouseState.HOVER;
            this.iTunerCheckBox4.Name = "iTunerCheckBox4";
            this.iTunerCheckBox4.Ripple = true;
            this.iTunerCheckBox4.Size = new System.Drawing.Size(49, 30);
            this.iTunerCheckBox4.TabIndex = 3;
            this.iTunerCheckBox4.Text = "PS3";
            this.iTunerCheckBox4.UseVisualStyleBackColor = true;
            // 
            // iTunerCheckBox3
            // 
            this.iTunerCheckBox3.AutoSize = true;
            this.iTunerCheckBox3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.iTunerCheckBox3.Depth = 0;
            this.iTunerCheckBox3.Font = new System.Drawing.Font("Roboto", 8F);
            this.iTunerCheckBox3.Location = new System.Drawing.Point(68, 19);
            this.iTunerCheckBox3.Margin = new System.Windows.Forms.Padding(0);
            this.iTunerCheckBox3.MouseLocation = new System.Drawing.Point(-1, -1);
            this.iTunerCheckBox3.MouseState = iTunerSkin.MouseState.HOVER;
            this.iTunerCheckBox3.Name = "iTunerCheckBox3";
            this.iTunerCheckBox3.Ripple = true;
            this.iTunerCheckBox3.Size = new System.Drawing.Size(49, 30);
            this.iTunerCheckBox3.TabIndex = 2;
            this.iTunerCheckBox3.Text = "PS2";
            this.iTunerCheckBox3.UseVisualStyleBackColor = true;
            // 
            // iTunerCheckBox2
            // 
            this.iTunerCheckBox2.AutoSize = true;
            this.iTunerCheckBox2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.iTunerCheckBox2.Depth = 0;
            this.iTunerCheckBox2.Font = new System.Drawing.Font("Roboto", 8F);
            this.iTunerCheckBox2.Location = new System.Drawing.Point(13, 19);
            this.iTunerCheckBox2.Margin = new System.Windows.Forms.Padding(0);
            this.iTunerCheckBox2.MouseLocation = new System.Drawing.Point(-1, -1);
            this.iTunerCheckBox2.MouseState = iTunerSkin.MouseState.HOVER;
            this.iTunerCheckBox2.Name = "iTunerCheckBox2";
            this.iTunerCheckBox2.Ripple = true;
            this.iTunerCheckBox2.Size = new System.Drawing.Size(49, 30);
            this.iTunerCheckBox2.TabIndex = 1;
            this.iTunerCheckBox2.Text = "PS1";
            this.iTunerCheckBox2.UseVisualStyleBackColor = true;
            // 
            // iTunerCheckBox1
            // 
            this.iTunerCheckBox1.AutoSize = true;
            this.iTunerCheckBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.iTunerCheckBox1.Depth = 0;
            this.iTunerCheckBox1.Font = new System.Drawing.Font("Roboto", 8F);
            this.iTunerCheckBox1.Location = new System.Drawing.Point(13, 78);
            this.iTunerCheckBox1.Margin = new System.Windows.Forms.Padding(0);
            this.iTunerCheckBox1.MouseLocation = new System.Drawing.Point(-1, -1);
            this.iTunerCheckBox1.MouseState = iTunerSkin.MouseState.HOVER;
            this.iTunerCheckBox1.Name = "iTunerCheckBox1";
            this.iTunerCheckBox1.Ripple = true;
            this.iTunerCheckBox1.Size = new System.Drawing.Size(57, 30);
            this.iTunerCheckBox1.TabIndex = 0;
            this.iTunerCheckBox1.Text = "XBOX";
            this.iTunerCheckBox1.UseVisualStyleBackColor = true;
            // 
            // grpType
            // 
            this.grpType.BackColor = System.Drawing.SystemColors.Control;
            this.grpType.Controls.Add(this.iTunerRadioButton5);
            this.grpType.Controls.Add(this.iTunerRadioButton4);
            this.grpType.Controls.Add(this.iTunerRadioButton3);
            this.grpType.Controls.Add(this.iTunerRadioButton1);
            this.grpType.Controls.Add(this.iTunerRadioButton2);
            this.grpType.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.grpType.Location = new System.Drawing.Point(12, 234);
            this.grpType.Name = "grpType";
            this.grpType.Size = new System.Drawing.Size(401, 54);
            this.grpType.TabIndex = 12;
            this.grpType.TabStop = false;
            this.grpType.Text = "Type:";
            // 
            // iTunerRadioButton5
            // 
            this.iTunerRadioButton5.AutoSize = true;
            this.iTunerRadioButton5.BackColor = System.Drawing.Color.White;
            this.iTunerRadioButton5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.iTunerRadioButton5.Depth = 0;
            this.iTunerRadioButton5.Font = new System.Drawing.Font("Roboto", 8F);
            this.iTunerRadioButton5.Location = new System.Drawing.Point(3, 16);
            this.iTunerRadioButton5.Margin = new System.Windows.Forms.Padding(0);
            this.iTunerRadioButton5.MouseLocation = new System.Drawing.Point(-1, -1);
            this.iTunerRadioButton5.MouseState = iTunerSkin.MouseState.HOVER;
            this.iTunerRadioButton5.Name = "iTunerRadioButton5";
            this.iTunerRadioButton5.Ripple = true;
            this.iTunerRadioButton5.Size = new System.Drawing.Size(57, 30);
            this.iTunerRadioButton5.TabIndex = 4;
            this.iTunerRadioButton5.TabStop = true;
            this.iTunerRadioButton5.Text = "Audio";
            this.iTunerRadioButton5.UseVisualStyleBackColor = false;
            // 
            // iTunerRadioButton4
            // 
            this.iTunerRadioButton4.AutoSize = true;
            this.iTunerRadioButton4.BackColor = System.Drawing.Color.White;
            this.iTunerRadioButton4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.iTunerRadioButton4.Depth = 0;
            this.iTunerRadioButton4.Font = new System.Drawing.Font("Roboto", 8F);
            this.iTunerRadioButton4.Location = new System.Drawing.Point(312, 16);
            this.iTunerRadioButton4.Margin = new System.Windows.Forms.Padding(0);
            this.iTunerRadioButton4.MouseLocation = new System.Drawing.Point(-1, -1);
            this.iTunerRadioButton4.MouseState = iTunerSkin.MouseState.HOVER;
            this.iTunerRadioButton4.Name = "iTunerRadioButton4";
            this.iTunerRadioButton4.Ripple = true;
            this.iTunerRadioButton4.Size = new System.Drawing.Size(64, 30);
            this.iTunerRadioButton4.TabIndex = 3;
            this.iTunerRadioButton4.TabStop = true;
            this.iTunerRadioButton4.Text = "Images";
            this.iTunerRadioButton4.UseVisualStyleBackColor = false;
            // 
            // iTunerRadioButton3
            // 
            this.iTunerRadioButton3.AutoSize = true;
            this.iTunerRadioButton3.BackColor = System.Drawing.Color.White;
            this.iTunerRadioButton3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.iTunerRadioButton3.Depth = 0;
            this.iTunerRadioButton3.Font = new System.Drawing.Font("Roboto", 8F);
            this.iTunerRadioButton3.Location = new System.Drawing.Point(213, 16);
            this.iTunerRadioButton3.Margin = new System.Windows.Forms.Padding(0);
            this.iTunerRadioButton3.MouseLocation = new System.Drawing.Point(-1, -1);
            this.iTunerRadioButton3.MouseState = iTunerSkin.MouseState.HOVER;
            this.iTunerRadioButton3.Name = "iTunerRadioButton3";
            this.iTunerRadioButton3.Ripple = true;
            this.iTunerRadioButton3.Size = new System.Drawing.Size(84, 30);
            this.iTunerRadioButton3.TabIndex = 2;
            this.iTunerRadioButton3.TabStop = true;
            this.iTunerRadioButton3.Text = "Documents";
            this.iTunerRadioButton3.UseVisualStyleBackColor = false;
            // 
            // iTunerRadioButton1
            // 
            this.iTunerRadioButton1.AutoSize = true;
            this.iTunerRadioButton1.BackColor = System.Drawing.Color.White;
            this.iTunerRadioButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.iTunerRadioButton1.Depth = 0;
            this.iTunerRadioButton1.Font = new System.Drawing.Font("Roboto", 8F);
            this.iTunerRadioButton1.Location = new System.Drawing.Point(68, 16);
            this.iTunerRadioButton1.Margin = new System.Windows.Forms.Padding(0);
            this.iTunerRadioButton1.MouseLocation = new System.Drawing.Point(-1, -1);
            this.iTunerRadioButton1.MouseState = iTunerSkin.MouseState.HOVER;
            this.iTunerRadioButton1.Name = "iTunerRadioButton1";
            this.iTunerRadioButton1.Ripple = true;
            this.iTunerRadioButton1.Size = new System.Drawing.Size(66, 30);
            this.iTunerRadioButton1.TabIndex = 0;
            this.iTunerRadioButton1.TabStop = true;
            this.iTunerRadioButton1.Text = "Gaming";
            this.iTunerRadioButton1.UseVisualStyleBackColor = false;
            // 
            // iTunerRadioButton2
            // 
            this.iTunerRadioButton2.AutoSize = true;
            this.iTunerRadioButton2.BackColor = System.Drawing.Color.White;
            this.iTunerRadioButton2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.iTunerRadioButton2.Depth = 0;
            this.iTunerRadioButton2.Font = new System.Drawing.Font("Roboto", 8F);
            this.iTunerRadioButton2.Location = new System.Drawing.Point(145, 16);
            this.iTunerRadioButton2.Margin = new System.Windows.Forms.Padding(0);
            this.iTunerRadioButton2.MouseLocation = new System.Drawing.Point(-1, -1);
            this.iTunerRadioButton2.MouseState = iTunerSkin.MouseState.HOVER;
            this.iTunerRadioButton2.Name = "iTunerRadioButton2";
            this.iTunerRadioButton2.Ripple = true;
            this.iTunerRadioButton2.Size = new System.Drawing.Size(59, 30);
            this.iTunerRadioButton2.TabIndex = 1;
            this.iTunerRadioButton2.TabStop = true;
            this.iTunerRadioButton2.Text = "Books";
            this.iTunerRadioButton2.UseVisualStyleBackColor = false;
            // 
            // grpInformation
            // 
            this.grpInformation.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpInformation.BackColor = System.Drawing.SystemColors.Control;
            this.grpInformation.Controls.Add(this.txtGenre);
            this.grpInformation.Controls.Add(this.lblGenre);
            this.grpInformation.Controls.Add(this.txtDescription);
            this.grpInformation.Controls.Add(this.lblDescription);
            this.grpInformation.Controls.Add(this.lblName);
            this.grpInformation.Controls.Add(this.txtName);
            this.grpInformation.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.grpInformation.Location = new System.Drawing.Point(12, 71);
            this.grpInformation.Name = "grpInformation";
            this.grpInformation.Size = new System.Drawing.Size(804, 89);
            this.grpInformation.TabIndex = 11;
            this.grpInformation.TabStop = false;
            this.grpInformation.Text = "Information:";
            // 
            // txtGenre
            // 
            this.txtGenre.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtGenre.Depth = 0;
            this.txtGenre.Hint = "";
            this.txtGenre.Location = new System.Drawing.Point(471, 16);
            this.txtGenre.MaxLength = 32767;
            this.txtGenre.MouseState = iTunerSkin.MouseState.HOVER;
            this.txtGenre.Name = "txtGenre";
            this.txtGenre.PasswordChar = '\0';
            this.txtGenre.SelectedText = "";
            this.txtGenre.SelectionLength = 0;
            this.txtGenre.SelectionStart = 0;
            this.txtGenre.Size = new System.Drawing.Size(324, 20);
            this.txtGenre.TabIndex = 5;
            this.txtGenre.TabStop = false;
            this.txtGenre.Text = "...";
            this.txtGenre.UseSystemPasswordChar = false;
            // 
            // lblGenre
            // 
            this.lblGenre.AutoSize = true;
            this.lblGenre.Depth = 0;
            this.lblGenre.Font = new System.Drawing.Font("Roboto", 9F);
            this.lblGenre.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.lblGenre.Location = new System.Drawing.Point(413, 20);
            this.lblGenre.MouseState = iTunerSkin.MouseState.HOVER;
            this.lblGenre.Name = "lblGenre";
            this.lblGenre.Size = new System.Drawing.Size(41, 15);
            this.lblGenre.TabIndex = 4;
            this.lblGenre.Text = "Genre:";
            // 
            // txtDescription
            // 
            this.txtDescription.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDescription.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtDescription.Depth = 0;
            this.txtDescription.Hint = "";
            this.txtDescription.Location = new System.Drawing.Point(99, 44);
            this.txtDescription.MaxLength = 32767;
            this.txtDescription.MouseState = iTunerSkin.MouseState.HOVER;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.PasswordChar = '\0';
            this.txtDescription.SelectedText = "";
            this.txtDescription.SelectionLength = 0;
            this.txtDescription.SelectionStart = 0;
            this.txtDescription.Size = new System.Drawing.Size(696, 20);
            this.txtDescription.TabIndex = 3;
            this.txtDescription.TabStop = false;
            this.txtDescription.Text = "...";
            this.txtDescription.UseSystemPasswordChar = false;
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Depth = 0;
            this.lblDescription.Font = new System.Drawing.Font("Roboto", 9F);
            this.lblDescription.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.lblDescription.Location = new System.Drawing.Point(6, 49);
            this.lblDescription.MouseState = iTunerSkin.MouseState.HOVER;
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(71, 15);
            this.lblDescription.TabIndex = 2;
            this.lblDescription.Text = "Description:";
            this.lblDescription.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblName
            // 
            this.lblName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblName.AutoSize = true;
            this.lblName.Depth = 0;
            this.lblName.Font = new System.Drawing.Font("Roboto", 9F);
            this.lblName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.lblName.Location = new System.Drawing.Point(6, 20);
            this.lblName.MouseState = iTunerSkin.MouseState.HOVER;
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(43, 15);
            this.lblName.TabIndex = 1;
            this.lblName.Text = "Name:";
            this.lblName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtName
            // 
            this.txtName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtName.Depth = 0;
            this.txtName.Hint = "";
            this.txtName.Location = new System.Drawing.Point(102, 16);
            this.txtName.MaxLength = 32767;
            this.txtName.MouseState = iTunerSkin.MouseState.HOVER;
            this.txtName.Name = "txtName";
            this.txtName.PasswordChar = '\0';
            this.txtName.SelectedText = "";
            this.txtName.SelectionLength = 0;
            this.txtName.SelectionStart = 0;
            this.txtName.Size = new System.Drawing.Size(167, 20);
            this.txtName.TabIndex = 0;
            this.txtName.TabStop = false;
            this.txtName.Text = "...";
            this.txtName.UseSystemPasswordChar = false;
            // 
            // grpLocation
            // 
            this.grpLocation.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpLocation.BackColor = System.Drawing.SystemColors.Control;
            this.grpLocation.Controls.Add(this.btnAddFile);
            this.grpLocation.Controls.Add(this.txtLocation);
            this.grpLocation.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.grpLocation.Location = new System.Drawing.Point(12, 166);
            this.grpLocation.Name = "grpLocation";
            this.grpLocation.Size = new System.Drawing.Size(804, 62);
            this.grpLocation.TabIndex = 10;
            this.grpLocation.TabStop = false;
            this.grpLocation.Text = "Location of File (#If Required):";
            // 
            // btnAddFile
            // 
            this.btnAddFile.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddFile.AutoSize = true;
            this.btnAddFile.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnAddFile.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddFile.Depth = 0;
            this.btnAddFile.Enabled = false;
            this.btnAddFile.Icon = global::iTunerManagerApp.Properties.Resources.NewFolder;
            this.btnAddFile.Location = new System.Drawing.Point(722, 16);
            this.btnAddFile.MouseState = iTunerSkin.MouseState.HOVER;
            this.btnAddFile.Name = "btnAddFile";
            this.btnAddFile.Primary = true;
            this.btnAddFile.Size = new System.Drawing.Size(70, 36);
            this.btnAddFile.TabIndex = 5;
            this.btnAddFile.Text = "Add";
            this.btnAddFile.UseVisualStyleBackColor = true;
            // 
            // txtLocation
            // 
            this.txtLocation.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtLocation.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtLocation.Depth = 0;
            this.txtLocation.Enabled = false;
            this.txtLocation.Hint = "";
            this.txtLocation.Location = new System.Drawing.Point(6, 29);
            this.txtLocation.MaxLength = 32767;
            this.txtLocation.MouseState = iTunerSkin.MouseState.HOVER;
            this.txtLocation.Name = "txtLocation";
            this.txtLocation.PasswordChar = '\0';
            this.txtLocation.SelectedText = "";
            this.txtLocation.SelectionLength = 0;
            this.txtLocation.SelectionStart = 0;
            this.txtLocation.Size = new System.Drawing.Size(710, 20);
            this.txtLocation.TabIndex = 0;
            this.txtLocation.TabStop = false;
            this.txtLocation.Text = "...";
            this.txtLocation.UseSystemPasswordChar = false;
            // 
            // grpEmulator
            // 
            this.grpEmulator.BackColor = System.Drawing.SystemColors.Control;
            this.grpEmulator.Controls.Add(this.btnGetEmulator);
            this.grpEmulator.Controls.Add(this.iTunerCheckBox11);
            this.grpEmulator.Controls.Add(this.iTunerCheckBox12);
            this.grpEmulator.Controls.Add(this.iTunerCheckBox13);
            this.grpEmulator.Controls.Add(this.iTunerCheckBox14);
            this.grpEmulator.Controls.Add(this.iTunerCheckBox15);
            this.grpEmulator.Controls.Add(this.iTunerCheckBox16);
            this.grpEmulator.Controls.Add(this.iTunerCheckBox17);
            this.grpEmulator.Controls.Add(this.iTunerCheckBox18);
            this.grpEmulator.Controls.Add(this.iTunerCheckBox19);
            this.grpEmulator.Controls.Add(this.iTunerCheckBox20);
            this.grpEmulator.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.grpEmulator.Location = new System.Drawing.Point(419, 294);
            this.grpEmulator.Name = "grpEmulator";
            this.grpEmulator.Size = new System.Drawing.Size(401, 122);
            this.grpEmulator.TabIndex = 16;
            this.grpEmulator.TabStop = false;
            this.grpEmulator.Text = "Emulators:";
            // 
            // btnGetEmulator
            // 
            this.btnGetEmulator.AutoSize = true;
            this.btnGetEmulator.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnGetEmulator.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGetEmulator.Depth = 0;
            this.btnGetEmulator.Icon = null;
            this.btnGetEmulator.Location = new System.Drawing.Point(289, 80);
            this.btnGetEmulator.MouseState = iTunerSkin.MouseState.HOVER;
            this.btnGetEmulator.Name = "btnGetEmulator";
            this.btnGetEmulator.Primary = true;
            this.btnGetEmulator.Size = new System.Drawing.Size(101, 36);
            this.btnGetEmulator.TabIndex = 10;
            this.btnGetEmulator.Text = "Get Emulator";
            this.btnGetEmulator.UseVisualStyleBackColor = true;
            // 
            // iTunerCheckBox11
            // 
            this.iTunerCheckBox11.AutoSize = true;
            this.iTunerCheckBox11.Cursor = System.Windows.Forms.Cursors.Hand;
            this.iTunerCheckBox11.Depth = 0;
            this.iTunerCheckBox11.Font = new System.Drawing.Font("Roboto", 8F);
            this.iTunerCheckBox11.Location = new System.Drawing.Point(289, 20);
            this.iTunerCheckBox11.Margin = new System.Windows.Forms.Padding(0);
            this.iTunerCheckBox11.MouseLocation = new System.Drawing.Point(-1, -1);
            this.iTunerCheckBox11.MouseState = iTunerSkin.MouseState.HOVER;
            this.iTunerCheckBox11.Name = "iTunerCheckBox11";
            this.iTunerCheckBox11.Ripple = true;
            this.iTunerCheckBox11.Size = new System.Drawing.Size(70, 30);
            this.iTunerCheckBox11.TabIndex = 9;
            this.iTunerCheckBox11.Text = "PS-VITA";
            this.iTunerCheckBox11.UseVisualStyleBackColor = true;
            // 
            // iTunerCheckBox12
            // 
            this.iTunerCheckBox12.AutoSize = true;
            this.iTunerCheckBox12.Cursor = System.Windows.Forms.Cursors.Hand;
            this.iTunerCheckBox12.Depth = 0;
            this.iTunerCheckBox12.Font = new System.Drawing.Font("Roboto", 8F);
            this.iTunerCheckBox12.Location = new System.Drawing.Point(78, 78);
            this.iTunerCheckBox12.Margin = new System.Windows.Forms.Padding(0);
            this.iTunerCheckBox12.MouseLocation = new System.Drawing.Point(-1, -1);
            this.iTunerCheckBox12.MouseState = iTunerSkin.MouseState.HOVER;
            this.iTunerCheckBox12.Name = "iTunerCheckBox12";
            this.iTunerCheckBox12.Ripple = true;
            this.iTunerCheckBox12.Size = new System.Drawing.Size(83, 30);
            this.iTunerCheckBox12.TabIndex = 8;
            this.iTunerCheckBox12.Text = "XBOX-ONE";
            this.iTunerCheckBox12.UseVisualStyleBackColor = true;
            // 
            // iTunerCheckBox13
            // 
            this.iTunerCheckBox13.AutoSize = true;
            this.iTunerCheckBox13.Cursor = System.Windows.Forms.Cursors.Hand;
            this.iTunerCheckBox13.Depth = 0;
            this.iTunerCheckBox13.Font = new System.Drawing.Font("Roboto", 8F);
            this.iTunerCheckBox13.Location = new System.Drawing.Point(121, 48);
            this.iTunerCheckBox13.Margin = new System.Windows.Forms.Padding(0);
            this.iTunerCheckBox13.MouseLocation = new System.Drawing.Point(-1, -1);
            this.iTunerCheckBox13.MouseState = iTunerSkin.MouseState.HOVER;
            this.iTunerCheckBox13.Name = "iTunerCheckBox13";
            this.iTunerCheckBox13.Ripple = true;
            this.iTunerCheckBox13.Size = new System.Drawing.Size(45, 30);
            this.iTunerCheckBox13.TabIndex = 7;
            this.iTunerCheckBox13.Text = "WII";
            this.iTunerCheckBox13.UseVisualStyleBackColor = true;
            // 
            // iTunerCheckBox14
            // 
            this.iTunerCheckBox14.AutoSize = true;
            this.iTunerCheckBox14.Cursor = System.Windows.Forms.Cursors.Hand;
            this.iTunerCheckBox14.Depth = 0;
            this.iTunerCheckBox14.Font = new System.Drawing.Font("Roboto", 8F);
            this.iTunerCheckBox14.Location = new System.Drawing.Point(13, 48);
            this.iTunerCheckBox14.Margin = new System.Windows.Forms.Padding(0);
            this.iTunerCheckBox14.MouseLocation = new System.Drawing.Point(-1, -1);
            this.iTunerCheckBox14.MouseState = iTunerSkin.MouseState.HOVER;
            this.iTunerCheckBox14.Name = "iTunerCheckBox14";
            this.iTunerCheckBox14.Ripple = true;
            this.iTunerCheckBox14.Size = new System.Drawing.Size(91, 30);
            this.iTunerCheckBox14.TabIndex = 6;
            this.iTunerCheckBox14.Text = "Nintendo-DS";
            this.iTunerCheckBox14.UseVisualStyleBackColor = true;
            // 
            // iTunerCheckBox15
            // 
            this.iTunerCheckBox15.AutoSize = true;
            this.iTunerCheckBox15.Cursor = System.Windows.Forms.Cursors.Hand;
            this.iTunerCheckBox15.Depth = 0;
            this.iTunerCheckBox15.Font = new System.Drawing.Font("Roboto", 8F);
            this.iTunerCheckBox15.Location = new System.Drawing.Point(233, 20);
            this.iTunerCheckBox15.Margin = new System.Windows.Forms.Padding(0);
            this.iTunerCheckBox15.MouseLocation = new System.Drawing.Point(-1, -1);
            this.iTunerCheckBox15.MouseState = iTunerSkin.MouseState.HOVER;
            this.iTunerCheckBox15.Name = "iTunerCheckBox15";
            this.iTunerCheckBox15.Ripple = true;
            this.iTunerCheckBox15.Size = new System.Drawing.Size(50, 30);
            this.iTunerCheckBox15.TabIndex = 5;
            this.iTunerCheckBox15.Text = "PSP";
            this.iTunerCheckBox15.UseVisualStyleBackColor = true;
            // 
            // iTunerCheckBox16
            // 
            this.iTunerCheckBox16.AutoSize = true;
            this.iTunerCheckBox16.Cursor = System.Windows.Forms.Cursors.Hand;
            this.iTunerCheckBox16.Depth = 0;
            this.iTunerCheckBox16.Font = new System.Drawing.Font("Roboto", 8F);
            this.iTunerCheckBox16.Location = new System.Drawing.Point(178, 20);
            this.iTunerCheckBox16.Margin = new System.Windows.Forms.Padding(0);
            this.iTunerCheckBox16.MouseLocation = new System.Drawing.Point(-1, -1);
            this.iTunerCheckBox16.MouseState = iTunerSkin.MouseState.HOVER;
            this.iTunerCheckBox16.Name = "iTunerCheckBox16";
            this.iTunerCheckBox16.Ripple = true;
            this.iTunerCheckBox16.Size = new System.Drawing.Size(49, 30);
            this.iTunerCheckBox16.TabIndex = 4;
            this.iTunerCheckBox16.Text = "PS4";
            this.iTunerCheckBox16.UseVisualStyleBackColor = true;
            // 
            // iTunerCheckBox17
            // 
            this.iTunerCheckBox17.AutoSize = true;
            this.iTunerCheckBox17.Cursor = System.Windows.Forms.Cursors.Hand;
            this.iTunerCheckBox17.Depth = 0;
            this.iTunerCheckBox17.Font = new System.Drawing.Font("Roboto", 8F);
            this.iTunerCheckBox17.Location = new System.Drawing.Point(123, 20);
            this.iTunerCheckBox17.Margin = new System.Windows.Forms.Padding(0);
            this.iTunerCheckBox17.MouseLocation = new System.Drawing.Point(-1, -1);
            this.iTunerCheckBox17.MouseState = iTunerSkin.MouseState.HOVER;
            this.iTunerCheckBox17.Name = "iTunerCheckBox17";
            this.iTunerCheckBox17.Ripple = true;
            this.iTunerCheckBox17.Size = new System.Drawing.Size(49, 30);
            this.iTunerCheckBox17.TabIndex = 3;
            this.iTunerCheckBox17.Text = "PS3";
            this.iTunerCheckBox17.UseVisualStyleBackColor = true;
            // 
            // iTunerCheckBox18
            // 
            this.iTunerCheckBox18.AutoSize = true;
            this.iTunerCheckBox18.Cursor = System.Windows.Forms.Cursors.Hand;
            this.iTunerCheckBox18.Depth = 0;
            this.iTunerCheckBox18.Font = new System.Drawing.Font("Roboto", 8F);
            this.iTunerCheckBox18.Location = new System.Drawing.Point(68, 19);
            this.iTunerCheckBox18.Margin = new System.Windows.Forms.Padding(0);
            this.iTunerCheckBox18.MouseLocation = new System.Drawing.Point(-1, -1);
            this.iTunerCheckBox18.MouseState = iTunerSkin.MouseState.HOVER;
            this.iTunerCheckBox18.Name = "iTunerCheckBox18";
            this.iTunerCheckBox18.Ripple = true;
            this.iTunerCheckBox18.Size = new System.Drawing.Size(49, 30);
            this.iTunerCheckBox18.TabIndex = 2;
            this.iTunerCheckBox18.Text = "PS2";
            this.iTunerCheckBox18.UseVisualStyleBackColor = true;
            // 
            // iTunerCheckBox19
            // 
            this.iTunerCheckBox19.AutoSize = true;
            this.iTunerCheckBox19.Cursor = System.Windows.Forms.Cursors.Hand;
            this.iTunerCheckBox19.Depth = 0;
            this.iTunerCheckBox19.Font = new System.Drawing.Font("Roboto", 8F);
            this.iTunerCheckBox19.Location = new System.Drawing.Point(13, 19);
            this.iTunerCheckBox19.Margin = new System.Windows.Forms.Padding(0);
            this.iTunerCheckBox19.MouseLocation = new System.Drawing.Point(-1, -1);
            this.iTunerCheckBox19.MouseState = iTunerSkin.MouseState.HOVER;
            this.iTunerCheckBox19.Name = "iTunerCheckBox19";
            this.iTunerCheckBox19.Ripple = true;
            this.iTunerCheckBox19.Size = new System.Drawing.Size(49, 30);
            this.iTunerCheckBox19.TabIndex = 1;
            this.iTunerCheckBox19.Text = "PS1";
            this.iTunerCheckBox19.UseVisualStyleBackColor = true;
            // 
            // iTunerCheckBox20
            // 
            this.iTunerCheckBox20.AutoSize = true;
            this.iTunerCheckBox20.Cursor = System.Windows.Forms.Cursors.Hand;
            this.iTunerCheckBox20.Depth = 0;
            this.iTunerCheckBox20.Font = new System.Drawing.Font("Roboto", 8F);
            this.iTunerCheckBox20.Location = new System.Drawing.Point(13, 78);
            this.iTunerCheckBox20.Margin = new System.Windows.Forms.Padding(0);
            this.iTunerCheckBox20.MouseLocation = new System.Drawing.Point(-1, -1);
            this.iTunerCheckBox20.MouseState = iTunerSkin.MouseState.HOVER;
            this.iTunerCheckBox20.Name = "iTunerCheckBox20";
            this.iTunerCheckBox20.Ripple = true;
            this.iTunerCheckBox20.Size = new System.Drawing.Size(57, 30);
            this.iTunerCheckBox20.TabIndex = 0;
            this.iTunerCheckBox20.Text = "XBOX";
            this.iTunerCheckBox20.UseVisualStyleBackColor = true;
            // 
            // iTunerCreateItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(832, 619);
            this.Controls.Add(this.grpEmulator);
            this.Controls.Add(this.grpImage);
            this.Controls.Add(this.btnCreate);
            this.Controls.Add(this.grpDevice);
            this.Controls.Add(this.grpType);
            this.Controls.Add(this.grpInformation);
            this.Controls.Add(this.grpLocation);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "TunerCreateItem";
            this.Sizable = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "iTuner Manager App: Create New Item";
            this.TopMost = true;
            this.grpImage.ResumeLayout(false);
            this.grpImage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imageLoader)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageFind)).EndInit();
            this.grpDevice.ResumeLayout(false);
            this.grpDevice.PerformLayout();
            this.grpType.ResumeLayout(false);
            this.grpType.PerformLayout();
            this.grpInformation.ResumeLayout(false);
            this.grpInformation.PerformLayout();
            this.grpLocation.ResumeLayout(false);
            this.grpLocation.PerformLayout();
            this.grpEmulator.ResumeLayout(false);
            this.grpEmulator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private GroupBox grpImage;
        private PictureBox imageLoader;
        private iTunerRaisedButton btnFindImage;
        private PictureBox imageFind;
        private iTunerRaisedButton btnCreate;
        private GroupBox grpDevice;
        private iTunerRaisedButton btnGetWalkthrough;
        private iTunerCheckBox iTunerCheckBox10;
        private iTunerCheckBox iTunerCheckBox9;
        private iTunerCheckBox iTunerCheckBox8;
        private iTunerCheckBox iTunerCheckBox7;
        private iTunerCheckBox iTunerCheckBox6;
        private iTunerCheckBox iTunerCheckBox5;
        private iTunerCheckBox iTunerCheckBox4;
        private iTunerCheckBox iTunerCheckBox3;
        private iTunerCheckBox iTunerCheckBox2;
        private iTunerCheckBox iTunerCheckBox1;
        private GroupBox grpType;
        private iTunerRadioButton iTunerRadioButton5;
        private iTunerRadioButton iTunerRadioButton4;
        private iTunerRadioButton iTunerRadioButton3;
        private iTunerRadioButton iTunerRadioButton1;
        private iTunerRadioButton iTunerRadioButton2;
        private GroupBox grpInformation;
        private iTunerSingleLineTextField txtGenre;
        private iTunerLabel lblGenre;
        private iTunerSingleLineTextField txtDescription;
        private iTunerLabel lblDescription;
        private iTunerLabel lblName;
        private iTunerSingleLineTextField txtName;
        private GroupBox grpLocation;
        private iTunerRaisedButton btnAddFile;
        private iTunerSingleLineTextField txtLocation;
        private GroupBox grpEmulator;
        private iTunerRaisedButton btnGetEmulator;
        private iTunerCheckBox iTunerCheckBox11;
        private iTunerCheckBox iTunerCheckBox12;
        private iTunerCheckBox iTunerCheckBox13;
        private iTunerCheckBox iTunerCheckBox14;
        private iTunerCheckBox iTunerCheckBox15;
        private iTunerCheckBox iTunerCheckBox16;
        private iTunerCheckBox iTunerCheckBox17;
        private iTunerCheckBox iTunerCheckBox18;
        private iTunerCheckBox iTunerCheckBox19;
        private iTunerCheckBox iTunerCheckBox20;
    }
}