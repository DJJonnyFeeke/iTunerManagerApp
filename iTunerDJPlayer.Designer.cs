using System.ComponentModel;
using System.Windows.Forms;

namespace iTunerManagerApp
{
    partial class TunerDjPlayer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TunerDjPlayer));
            this.picMixer = new System.Windows.Forms.PictureBox();
            this.picRightPlayer = new System.Windows.Forms.PictureBox();
            this.picLeftPlayer = new System.Windows.Forms.PictureBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)(this.picMixer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picRightPlayer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLeftPlayer)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // picMixer
            // 
            this.picMixer.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.picMixer.BackColor = System.Drawing.Color.Transparent;
            this.picMixer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picMixer.Image = global::iTunerManagerApp.Properties.AudioPlayer.djmSkin;
            this.picMixer.Location = new System.Drawing.Point(687, 6);
            this.picMixer.Name = "picMixer";
            this.picMixer.Size = new System.Drawing.Size(512, 709);
            this.picMixer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picMixer.TabIndex = 3;
            this.picMixer.TabStop = false;
            // 
            // picRightPlayer
            // 
            this.picRightPlayer.BackColor = System.Drawing.Color.Transparent;
            this.picRightPlayer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picRightPlayer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.picRightPlayer.Image = global::iTunerManagerApp.Properties.AudioPlayer.cdjSkin;
            this.picRightPlayer.Location = new System.Drawing.Point(1208, 6);
            this.picRightPlayer.Name = "picRightPlayer";
            this.picRightPlayer.Size = new System.Drawing.Size(672, 709);
            this.picRightPlayer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picRightPlayer.TabIndex = 2;
            this.picRightPlayer.TabStop = false;
            // 
            // picLeftPlayer
            // 
            this.picLeftPlayer.BackColor = System.Drawing.Color.Transparent;
            this.picLeftPlayer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picLeftPlayer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.picLeftPlayer.Image = global::iTunerManagerApp.Properties.AudioPlayer.cdjSkin;
            this.picLeftPlayer.Location = new System.Drawing.Point(6, 6);
            this.picLeftPlayer.Name = "picLeftPlayer";
            this.picLeftPlayer.Size = new System.Drawing.Size(672, 709);
            this.picLeftPlayer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picLeftPlayer.TabIndex = 1;
            this.picLeftPlayer.TabStop = false;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.AutoSize = true;
            this.tableLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.Black;
            this.tableLayoutPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.tableLayoutPanel1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.OutsetDouble;
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.Controls.Add(this.picLeftPlayer, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.picRightPlayer, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.picMixer, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.GrowStyle = System.Windows.Forms.TableLayoutPanelGrowStyle.FixedSize;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1886, 972);
            this.tableLayoutPanel1.TabIndex = 5;
            // 
            // iTunerDJPlayer
            // 
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1886, 972);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "TunerDjPlayer";
            this.Sizable = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "iTuner Audio Player";
            this.TopMost = true;
            this.TransparencyKey = System.Drawing.SystemColors.ActiveCaption;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.picMixer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picRightPlayer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLeftPlayer)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PictureBox picLeftPlayer;
        private PictureBox picRightPlayer;
        private PictureBox picMixer;
        private TableLayoutPanel tableLayoutPanel1;


    }
}