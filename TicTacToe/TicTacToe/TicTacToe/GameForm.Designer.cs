namespace TicTacToe
{
    partial class GameForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GameForm));
            this.lblPlayer = new System.Windows.Forms.Label();
            this.tblLayout = new System.Windows.Forms.TableLayoutPanel();
            this.pb00 = new System.Windows.Forms.PictureBox();
            this.pb01 = new System.Windows.Forms.PictureBox();
            this.pb02 = new System.Windows.Forms.PictureBox();
            this.pb10 = new System.Windows.Forms.PictureBox();
            this.pb11 = new System.Windows.Forms.PictureBox();
            this.pb12 = new System.Windows.Forms.PictureBox();
            this.pb20 = new System.Windows.Forms.PictureBox();
            this.pb21 = new System.Windows.Forms.PictureBox();
            this.pb22 = new System.Windows.Forms.PictureBox();
            this.lblInfo = new System.Windows.Forms.Label();
            this.lblYourTurn = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pnlTurn = new System.Windows.Forms.Panel();
            this.pbTurn = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tblLayout.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb00)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb01)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb02)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb12)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb20)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb21)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb22)).BeginInit();
            this.panel1.SuspendLayout();
            this.pnlTurn.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbTurn)).BeginInit();
            this.SuspendLayout();
            // 
            // lblPlayer
            // 
            this.lblPlayer.AutoSize = true;
            this.lblPlayer.Font = new System.Drawing.Font("Berlin Sans FB Demi", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlayer.ForeColor = System.Drawing.Color.Maroon;
            this.lblPlayer.Location = new System.Drawing.Point(60, 10);
            this.lblPlayer.Name = "lblPlayer";
            this.lblPlayer.Size = new System.Drawing.Size(97, 18);
            this.lblPlayer.TabIndex = 0;
            this.lblPlayer.Text = "PlayerName";
            // 
            // tblLayout
            // 
            this.tblLayout.BackColor = System.Drawing.Color.Transparent;
            this.tblLayout.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.OutsetDouble;
            this.tblLayout.ColumnCount = 3;
            this.tblLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tblLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tblLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tblLayout.Controls.Add(this.pb00, 0, 0);
            this.tblLayout.Controls.Add(this.pb01, 1, 0);
            this.tblLayout.Controls.Add(this.pb02, 2, 0);
            this.tblLayout.Controls.Add(this.pb10, 0, 1);
            this.tblLayout.Controls.Add(this.pb11, 1, 1);
            this.tblLayout.Controls.Add(this.pb12, 2, 1);
            this.tblLayout.Controls.Add(this.pb20, 0, 2);
            this.tblLayout.Controls.Add(this.pb21, 1, 2);
            this.tblLayout.Controls.Add(this.pb22, 2, 2);
            this.tblLayout.Location = new System.Drawing.Point(47, 69);
            this.tblLayout.Name = "tblLayout";
            this.tblLayout.RowCount = 3;
            this.tblLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tblLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tblLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tblLayout.Size = new System.Drawing.Size(451, 350);
            this.tblLayout.TabIndex = 1;
            // 
            // pb00
            // 
            this.pb00.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pb00.BackColor = System.Drawing.Color.White;
            this.pb00.Location = new System.Drawing.Point(6, 6);
            this.pb00.Name = "pb00";
            this.pb00.Size = new System.Drawing.Size(140, 106);
            this.pb00.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb00.TabIndex = 0;
            this.pb00.TabStop = false;
            this.pb00.Click += new System.EventHandler(this.pb00_Click);
            // 
            // pb01
            // 
            this.pb01.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pb01.BackColor = System.Drawing.Color.White;
            this.pb01.Location = new System.Drawing.Point(155, 6);
            this.pb01.Name = "pb01";
            this.pb01.Size = new System.Drawing.Size(140, 106);
            this.pb01.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb01.TabIndex = 1;
            this.pb01.TabStop = false;
            this.pb01.Click += new System.EventHandler(this.pb01_Click);
            // 
            // pb02
            // 
            this.pb02.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pb02.BackColor = System.Drawing.Color.White;
            this.pb02.Location = new System.Drawing.Point(304, 6);
            this.pb02.Name = "pb02";
            this.pb02.Size = new System.Drawing.Size(141, 106);
            this.pb02.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb02.TabIndex = 2;
            this.pb02.TabStop = false;
            this.pb02.Click += new System.EventHandler(this.pb02_Click);
            // 
            // pb10
            // 
            this.pb10.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pb10.BackColor = System.Drawing.Color.White;
            this.pb10.Location = new System.Drawing.Point(6, 121);
            this.pb10.Name = "pb10";
            this.pb10.Size = new System.Drawing.Size(140, 106);
            this.pb10.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb10.TabIndex = 3;
            this.pb10.TabStop = false;
            this.pb10.Click += new System.EventHandler(this.pb10_Click);
            // 
            // pb11
            // 
            this.pb11.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pb11.BackColor = System.Drawing.Color.White;
            this.pb11.Location = new System.Drawing.Point(155, 121);
            this.pb11.Name = "pb11";
            this.pb11.Size = new System.Drawing.Size(140, 106);
            this.pb11.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb11.TabIndex = 4;
            this.pb11.TabStop = false;
            this.pb11.Click += new System.EventHandler(this.pb11_Click);
            // 
            // pb12
            // 
            this.pb12.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pb12.BackColor = System.Drawing.Color.White;
            this.pb12.Location = new System.Drawing.Point(304, 121);
            this.pb12.Name = "pb12";
            this.pb12.Size = new System.Drawing.Size(141, 106);
            this.pb12.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb12.TabIndex = 5;
            this.pb12.TabStop = false;
            this.pb12.Click += new System.EventHandler(this.pb12_Click);
            // 
            // pb20
            // 
            this.pb20.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pb20.BackColor = System.Drawing.Color.White;
            this.pb20.Location = new System.Drawing.Point(6, 236);
            this.pb20.Name = "pb20";
            this.pb20.Size = new System.Drawing.Size(140, 108);
            this.pb20.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb20.TabIndex = 6;
            this.pb20.TabStop = false;
            this.pb20.Click += new System.EventHandler(this.pb20_Click);
            // 
            // pb21
            // 
            this.pb21.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pb21.BackColor = System.Drawing.Color.White;
            this.pb21.Location = new System.Drawing.Point(155, 236);
            this.pb21.Name = "pb21";
            this.pb21.Size = new System.Drawing.Size(140, 108);
            this.pb21.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb21.TabIndex = 7;
            this.pb21.TabStop = false;
            this.pb21.Click += new System.EventHandler(this.pb21_Click);
            // 
            // pb22
            // 
            this.pb22.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pb22.BackColor = System.Drawing.Color.White;
            this.pb22.Location = new System.Drawing.Point(304, 236);
            this.pb22.Name = "pb22";
            this.pb22.Size = new System.Drawing.Size(141, 108);
            this.pb22.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb22.TabIndex = 8;
            this.pb22.TabStop = false;
            this.pb22.Click += new System.EventHandler(this.pb22_Click);
            // 
            // lblInfo
            // 
            this.lblInfo.Font = new System.Drawing.Font("Berlin Sans FB", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInfo.ForeColor = System.Drawing.Color.Maroon;
            this.lblInfo.Location = new System.Drawing.Point(50, 433);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(448, 23);
            this.lblInfo.TabIndex = 2;
            this.lblInfo.Text = "Waiting for player...";
            // 
            // lblYourTurn
            // 
            this.lblYourTurn.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblYourTurn.AutoSize = true;
            this.lblYourTurn.Font = new System.Drawing.Font("Berlin Sans FB Demi", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblYourTurn.ForeColor = System.Drawing.Color.LimeGreen;
            this.lblYourTurn.Location = new System.Drawing.Point(44, 6);
            this.lblYourTurn.Name = "lblYourTurn";
            this.lblYourTurn.Size = new System.Drawing.Size(75, 18);
            this.lblYourTurn.TabIndex = 3;
            this.lblYourTurn.Text = "Your turn";
            this.lblYourTurn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pnlTurn);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.lblPlayer);
            this.panel1.Location = new System.Drawing.Point(47, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(451, 42);
            this.panel1.TabIndex = 4;
            // 
            // pnlTurn
            // 
            this.pnlTurn.Controls.Add(this.pbTurn);
            this.pnlTurn.Controls.Add(this.lblYourTurn);
            this.pnlTurn.Location = new System.Drawing.Point(326, 4);
            this.pnlTurn.Name = "pnlTurn";
            this.pnlTurn.Size = new System.Drawing.Size(122, 35);
            this.pnlTurn.TabIndex = 5;
            // 
            // pbTurn
            // 
            this.pbTurn.Location = new System.Drawing.Point(7, 3);
            this.pbTurn.Name = "pbTurn";
            this.pbTurn.Size = new System.Drawing.Size(31, 28);
            this.pbTurn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbTurn.TabIndex = 4;
            this.pbTurn.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Berlin Sans FB", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "Player:";
            // 
            // GameForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(554, 464);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblInfo);
            this.Controls.Add(this.tblLayout);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "GameForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TicTacToe";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.GameForm_FormClosed);
            this.tblLayout.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pb00)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb01)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb02)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb12)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb20)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb21)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb22)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.pnlTurn.ResumeLayout(false);
            this.pnlTurn.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbTurn)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblPlayer;
        private System.Windows.Forms.TableLayoutPanel tblLayout;
        private System.Windows.Forms.PictureBox pb00;
        private System.Windows.Forms.PictureBox pb01;
        private System.Windows.Forms.PictureBox pb02;
        private System.Windows.Forms.PictureBox pb10;
        private System.Windows.Forms.PictureBox pb11;
        private System.Windows.Forms.PictureBox pb12;
        private System.Windows.Forms.PictureBox pb20;
        private System.Windows.Forms.PictureBox pb21;
        private System.Windows.Forms.PictureBox pb22;
        private System.Windows.Forms.Label lblInfo;
        private System.Windows.Forms.Label lblYourTurn;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel pnlTurn;
        private System.Windows.Forms.PictureBox pbTurn;
    }
}