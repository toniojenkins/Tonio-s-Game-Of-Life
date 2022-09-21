

namespace GameOfLife
{
    partial class TonioLife
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
            this.picGrid = new System.Windows.Forms.PictureBox();
            this.cellSize = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.resetBtn = new System.Windows.Forms.Button();
            this.startBtn = new System.Windows.Forms.Button();
            this.clearBtn = new System.Windows.Forms.Button();
            this.mMain = new System.Windows.Forms.MenuStrip();
            this.fileClick = new System.Windows.Forms.ToolStripMenuItem();
            this.loadPatterClick = new System.Windows.Forms.ToolStripMenuItem();
            this.savePatternClick = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.exitClick = new System.Windows.Forms.ToolStripMenuItem();
            this.gameClick = new System.Windows.Forms.ToolStripMenuItem();
            this.resetGridClick = new System.Windows.Forms.ToolStripMenuItem();
            this.clearGridClick = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.advanceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.colorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.backgroundToolColor = new System.Windows.Forms.ToolStripMenuItem();
            this.bckgrndRed = new System.Windows.Forms.ToolStripMenuItem();
            this.bckgrndBlue = new System.Windows.Forms.ToolStripMenuItem();
            this.bckgrndYellow = new System.Windows.Forms.ToolStripMenuItem();
            this.bckgrndBrown = new System.Windows.Forms.ToolStripMenuItem();
            this.bckgrndAqua = new System.Windows.Forms.ToolStripMenuItem();
            this.bckgrndHotPink = new System.Windows.Forms.ToolStripMenuItem();
            this.bckgrndDarkGreen = new System.Windows.Forms.ToolStripMenuItem();
            this.bckgrndRandom = new System.Windows.Forms.ToolStripMenuItem();
            this.cellToolColor = new System.Windows.Forms.ToolStripMenuItem();
            this.cellColorRed = new System.Windows.Forms.ToolStripMenuItem();
            this.cellColorBlue = new System.Windows.Forms.ToolStripMenuItem();
            this.cellColorYellow = new System.Windows.Forms.ToolStripMenuItem();
            this.cellColorBrown = new System.Windows.Forms.ToolStripMenuItem();
            this.cellColorAqua = new System.Windows.Forms.ToolStripMenuItem();
            this.cellColorHotPink = new System.Windows.Forms.ToolStripMenuItem();
            this.cellColorDarkGreen = new System.Windows.Forms.ToolStripMenuItem();
            this.cellColorRandom = new System.Windows.Forms.ToolStripMenuItem();
            this.startBtnClick = new System.Windows.Forms.ToolStripMenuItem();
            this.nodeDelay = new System.Windows.Forms.NumericUpDown();
            this.fdSave = new System.Windows.Forms.SaveFileDialog();
            this.colorBtn = new System.Windows.Forms.Button();
            this.nxtBtn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cellSize)).BeginInit();
            this.mMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nodeDelay)).BeginInit();
            this.SuspendLayout();
            // 
            // picGrid
            // 
            this.picGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.picGrid.Location = new System.Drawing.Point(32, 69);
            this.picGrid.Margin = new System.Windows.Forms.Padding(6);
            this.picGrid.Name = "picGrid";
            this.picGrid.Size = new System.Drawing.Size(1566, 750);
            this.picGrid.TabIndex = 0;
            this.picGrid.TabStop = false;
            this.picGrid.MouseClick += new System.Windows.Forms.MouseEventHandler(this.grid_mouseClick);
            // 
            // cellSize
            // 
            this.cellSize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.cellSize.Location = new System.Drawing.Point(144, 837);
            this.cellSize.Margin = new System.Windows.Forms.Padding(6);
            this.cellSize.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.cellSize.Minimum = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.cellSize.Name = "cellSize";
            this.cellSize.Size = new System.Drawing.Size(96, 31);
            this.cellSize.TabIndex = 1;
            this.cellSize.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.cellSize.Value = new decimal(new int[] {
            9,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 840);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Cell Size:";
            // 
            // resetBtn
            // 
            this.resetBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.resetBtn.Location = new System.Drawing.Point(284, 833);
            this.resetBtn.Margin = new System.Windows.Forms.Padding(6);
            this.resetBtn.Name = "resetBtn";
            this.resetBtn.Size = new System.Drawing.Size(128, 38);
            this.resetBtn.TabIndex = 3;
            this.resetBtn.Text = "Reset";
            this.resetBtn.UseVisualStyleBackColor = true;
            this.resetBtn.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // startBtn
            // 
            this.startBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.startBtn.Location = new System.Drawing.Point(1466, 848);
            this.startBtn.Margin = new System.Windows.Forms.Padding(6);
            this.startBtn.Name = "startBtn";
            this.startBtn.Size = new System.Drawing.Size(128, 38);
            this.startBtn.TabIndex = 5;
            this.startBtn.Text = "Start";
            this.startBtn.UseVisualStyleBackColor = true;
            this.startBtn.Click += new System.EventHandler(this.startBtn_Click);
            // 
            // clearBtn
            // 
            this.clearBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.clearBtn.Location = new System.Drawing.Point(442, 833);
            this.clearBtn.Margin = new System.Windows.Forms.Padding(6);
            this.clearBtn.Name = "clearBtn";
            this.clearBtn.Size = new System.Drawing.Size(128, 38);
            this.clearBtn.TabIndex = 6;
            this.clearBtn.Text = "Clear";
            this.clearBtn.UseVisualStyleBackColor = true;
            this.clearBtn.Click += new System.EventHandler(this.clear_btnClick);
            // 
            // mMain
            // 
            this.mMain.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.mMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileClick,
            this.gameClick});
            this.mMain.Location = new System.Drawing.Point(0, 0);
            this.mMain.Name = "mMain";
            this.mMain.Padding = new System.Windows.Forms.Padding(10, 4, 0, 4);
            this.mMain.Size = new System.Drawing.Size(1618, 44);
            this.mMain.TabIndex = 7;
            this.mMain.Text = "menuStrip1";
            // 
            // fileClick
            // 
            this.fileClick.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loadPatterClick,
            this.savePatternClick,
            this.toolStripSeparator3,
            this.exitClick});
            this.fileClick.Name = "fileClick";
            this.fileClick.Size = new System.Drawing.Size(72, 36);
            this.fileClick.Text = "&File";
            // 
            // loadPatterClick
            // 
            this.loadPatterClick.Name = "loadPatterClick";
            this.loadPatterClick.Size = new System.Drawing.Size(282, 44);
            this.loadPatterClick.Text = "&Load Pattern";
            this.loadPatterClick.Click += new System.EventHandler(this.loadPattern_Click);
            // 
            // savePatternClick
            // 
            this.savePatternClick.Name = "savePatternClick";
            this.savePatternClick.Size = new System.Drawing.Size(282, 44);
            this.savePatternClick.Text = "&Save Pattern";
            this.savePatternClick.Click += new System.EventHandler(this.savePattern_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(279, 6);
            // 
            // exitClick
            // 
            this.exitClick.Name = "exitClick";
            this.exitClick.Size = new System.Drawing.Size(282, 44);
            this.exitClick.Text = "E&xit";
            this.exitClick.Click += new System.EventHandler(this.exitTool_Click);
            // 
            // gameClick
            // 
            this.gameClick.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.resetGridClick,
            this.clearGridClick,
            this.toolStripSeparator1,
            this.advanceToolStripMenuItem,
            this.colorToolStripMenuItem,
            this.startBtnClick});
            this.gameClick.Name = "gameClick";
            this.gameClick.Size = new System.Drawing.Size(97, 36);
            this.gameClick.Text = "&Game";
            // 
            // resetGridClick
            // 
            this.resetGridClick.Name = "resetGridClick";
            this.resetGridClick.Size = new System.Drawing.Size(257, 44);
            this.resetGridClick.Text = "&Reset Grid";
            this.resetGridClick.Click += new System.EventHandler(this.resetGrid_tool);
            // 
            // clearGridClick
            // 
            this.clearGridClick.Name = "clearGridClick";
            this.clearGridClick.Size = new System.Drawing.Size(257, 44);
            this.clearGridClick.Text = "&Clear Grid";
            this.clearGridClick.Click += new System.EventHandler(this.clearGrid_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(254, 6);
            // 
            // advanceToolStripMenuItem
            // 
            this.advanceToolStripMenuItem.Name = "advanceToolStripMenuItem";
            this.advanceToolStripMenuItem.Size = new System.Drawing.Size(257, 44);
            // 
            // colorToolStripMenuItem
            // 
            this.colorToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.backgroundToolColor,
            this.cellToolColor});
            this.colorToolStripMenuItem.Name = "colorToolStripMenuItem";
            this.colorToolStripMenuItem.Size = new System.Drawing.Size(257, 44);
            this.colorToolStripMenuItem.Text = "Color";
            // 
            // backgroundToolColor
            // 
            this.backgroundToolColor.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bckgrndRed,
            this.bckgrndBlue,
            this.bckgrndYellow,
            this.bckgrndBrown,
            this.bckgrndAqua,
            this.bckgrndHotPink,
            this.bckgrndDarkGreen,
            this.bckgrndRandom});
            this.backgroundToolColor.Name = "backgroundToolColor";
            this.backgroundToolColor.Size = new System.Drawing.Size(340, 44);
            this.backgroundToolColor.Text = "Background Color";
            // 
            // bckgrndRed
            // 
            this.bckgrndRed.Name = "bckgrndRed";
            this.bckgrndRed.Size = new System.Drawing.Size(262, 44);
            this.bckgrndRed.Text = "Red";
            // 
            // bckgrndBlue
            // 
            this.bckgrndBlue.Name = "bckgrndBlue";
            this.bckgrndBlue.Size = new System.Drawing.Size(262, 44);
            this.bckgrndBlue.Text = "Blue";
            // 
            // bckgrndYellow
            // 
            this.bckgrndYellow.Name = "bckgrndYellow";
            this.bckgrndYellow.Size = new System.Drawing.Size(262, 44);
            this.bckgrndYellow.Text = "Yellow";
            // 
            // bckgrndBrown
            // 
            this.bckgrndBrown.Name = "bckgrndBrown";
            this.bckgrndBrown.Size = new System.Drawing.Size(262, 44);
            this.bckgrndBrown.Text = "Brown";
            // 
            // bckgrndAqua
            // 
            this.bckgrndAqua.Name = "bckgrndAqua";
            this.bckgrndAqua.Size = new System.Drawing.Size(262, 44);
            this.bckgrndAqua.Text = "Aqua";
            // 
            // bckgrndHotPink
            // 
            this.bckgrndHotPink.Name = "bckgrndHotPink";
            this.bckgrndHotPink.Size = new System.Drawing.Size(262, 44);
            this.bckgrndHotPink.Text = "HotPink";
            // 
            // bckgrndDarkGreen
            // 
            this.bckgrndDarkGreen.Name = "bckgrndDarkGreen";
            this.bckgrndDarkGreen.Size = new System.Drawing.Size(262, 44);
            this.bckgrndDarkGreen.Text = "DarkGreen";
            // 
            // bckgrndRandom
            // 
            this.bckgrndRandom.Name = "bckgrndRandom";
            this.bckgrndRandom.Size = new System.Drawing.Size(262, 44);
            this.bckgrndRandom.Text = "Random";
            // 
            // cellToolColor
            // 
            this.cellToolColor.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cellColorRed,
            this.cellColorBlue,
            this.cellColorYellow,
            this.cellColorBrown,
            this.cellColorAqua,
            this.cellColorHotPink,
            this.cellColorDarkGreen,
            this.cellColorRandom});
            this.cellToolColor.Name = "cellToolColor";
            this.cellToolColor.Size = new System.Drawing.Size(340, 44);
            this.cellToolColor.Text = "Cell Color";
            // 
            // cellColorRed
            // 
            this.cellColorRed.Name = "cellColorRed";
            this.cellColorRed.Size = new System.Drawing.Size(262, 44);
            this.cellColorRed.Text = "Red";
            this.cellColorRed.Click += new System.EventHandler(this.menuColor);
            // 
            // cellColorBlue
            // 
            this.cellColorBlue.Name = "cellColorBlue";
            this.cellColorBlue.Size = new System.Drawing.Size(262, 44);
            this.cellColorBlue.Text = "Blue";
            this.cellColorBlue.Click += new System.EventHandler(this.menuColor);
            // 
            // cellColorYellow
            // 
            this.cellColorYellow.Name = "cellColorYellow";
            this.cellColorYellow.Size = new System.Drawing.Size(262, 44);
            this.cellColorYellow.Text = "Yellow";
            this.cellColorYellow.Click += new System.EventHandler(this.menuColor);
            // 
            // cellColorBrown
            // 
            this.cellColorBrown.Name = "cellColorBrown";
            this.cellColorBrown.Size = new System.Drawing.Size(262, 44);
            this.cellColorBrown.Text = "Brown";
            this.cellColorBrown.Click += new System.EventHandler(this.menuColor);
            // 
            // cellColorAqua
            // 
            this.cellColorAqua.Name = "cellColorAqua";
            this.cellColorAqua.Size = new System.Drawing.Size(262, 44);
            this.cellColorAqua.Text = "Aqua";
            this.cellColorAqua.Click += new System.EventHandler(this.menuColor);
            // 
            // cellColorHotPink
            // 
            this.cellColorHotPink.Name = "cellColorHotPink";
            this.cellColorHotPink.Size = new System.Drawing.Size(262, 44);
            this.cellColorHotPink.Text = "HotPink";
            this.cellColorHotPink.Click += new System.EventHandler(this.menuColor);
            // 
            // cellColorDarkGreen
            // 
            this.cellColorDarkGreen.Name = "cellColorDarkGreen";
            this.cellColorDarkGreen.Size = new System.Drawing.Size(262, 44);
            this.cellColorDarkGreen.Text = "DarkGreen";
            this.cellColorDarkGreen.Click += new System.EventHandler(this.menuColor);
            // 
            // cellColorRandom
            // 
            this.cellColorRandom.Name = "cellColorRandom";
            this.cellColorRandom.Size = new System.Drawing.Size(262, 44);
            this.cellColorRandom.Text = "Random";
            this.cellColorRandom.Click += new System.EventHandler(this.changeColor);
            // 
            // startBtnClick
            // 
            this.startBtnClick.Name = "startBtnClick";
            this.startBtnClick.Size = new System.Drawing.Size(257, 44);
            this.startBtnClick.Text = "&Start";
            this.startBtnClick.Click += new System.EventHandler(this.startTool_Click);
            // 
            // nodeDelay
            // 
            this.nodeDelay.Location = new System.Drawing.Point(1466, 898);
            this.nodeDelay.Margin = new System.Windows.Forms.Padding(6);
            this.nodeDelay.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.nodeDelay.Name = "nodeDelay";
            this.nodeDelay.Size = new System.Drawing.Size(126, 31);
            this.nodeDelay.TabIndex = 8;
            this.nodeDelay.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // colorBtn
            // 
            this.colorBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.colorBtn.Location = new System.Drawing.Point(442, 883);
            this.colorBtn.Margin = new System.Windows.Forms.Padding(6);
            this.colorBtn.Name = "colorBtn";
            this.colorBtn.Size = new System.Drawing.Size(128, 38);
            this.colorBtn.TabIndex = 8;
            this.colorBtn.Text = "Color";
            this.colorBtn.UseVisualStyleBackColor = true;
            this.colorBtn.Click += new System.EventHandler(this.changeColor);
            // 
            // nxtBtn
            // 
            this.nxtBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.nxtBtn.Location = new System.Drawing.Point(1326, 848);
            this.nxtBtn.Margin = new System.Windows.Forms.Padding(6);
            this.nxtBtn.Name = "nxtBtn";
            this.nxtBtn.Size = new System.Drawing.Size(128, 38);
            this.nxtBtn.TabIndex = 10;
            this.nxtBtn.Text = "Next";
            this.nxtBtn.UseVisualStyleBackColor = true;
            this.nxtBtn.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 890);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 25);
            this.label2.TabIndex = 11;
            this.label2.Text = "Alive Cell:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(152, 890);
            this.label3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 25);
            this.label3.TabIndex = 12;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(26, 929);
            this.label4.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(124, 25);
            this.label4.TabIndex = 13;
            this.label4.Text = "Generation:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(166, 929);
            this.label5.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(0, 25);
            this.label5.TabIndex = 14;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(1321, 900);
            this.label6.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(115, 25);
            this.label6.TabIndex = 15;
            this.label6.Text = "Delay(ms):";
            // 
            // TonioLife
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1618, 969);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.nodeDelay);
            this.Controls.Add(this.nxtBtn);
            this.Controls.Add(this.colorBtn);
            this.Controls.Add(this.clearBtn);
            this.Controls.Add(this.startBtn);
            this.Controls.Add(this.resetBtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cellSize);
            this.Controls.Add(this.picGrid);
            this.Controls.Add(this.mMain);
            this.MainMenuStrip = this.mMain;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.MinimumSize = new System.Drawing.Size(1624, 979);
            this.Name = "TonioLife";
            this.Text = "Tonio\'s Game Of Life";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.tonio_Closing);
            this.Load += new System.EventHandler(this.tonio_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cellSize)).EndInit();
            this.mMain.ResumeLayout(false);
            this.mMain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nodeDelay)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picGrid;
        private System.Windows.Forms.NumericUpDown cellSize;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button resetBtn;
        private System.Windows.Forms.Button startBtn;
        private System.Windows.Forms.Button clearBtn;
        private System.Windows.Forms.MenuStrip mMain;
        private System.Windows.Forms.ToolStripMenuItem gameClick;
        private System.Windows.Forms.ToolStripMenuItem resetGridClick;
        private System.Windows.Forms.ToolStripMenuItem clearGridClick;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem advanceToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem startBtnClick;
        private System.Windows.Forms.SaveFileDialog fdSave;
        private System.Windows.Forms.ToolStripMenuItem fileClick;
        private System.Windows.Forms.ToolStripMenuItem loadPatterClick;
        private System.Windows.Forms.ToolStripMenuItem savePatternClick;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem exitClick;
        private System.Windows.Forms.NumericUpDown nodeDelay;
        private System.Windows.Forms.Button colorBtn;
        private System.Windows.Forms.Button nxtBtn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ToolStripMenuItem colorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cellToolColor;
        private System.Windows.Forms.ToolStripMenuItem cellColorRed;
        private System.Windows.Forms.ToolStripMenuItem cellColorBlue;
        private System.Windows.Forms.ToolStripMenuItem cellColorYellow;
        private System.Windows.Forms.ToolStripMenuItem cellColorBrown;
        private System.Windows.Forms.ToolStripMenuItem cellColorAqua;
        private System.Windows.Forms.ToolStripMenuItem cellColorHotPink;
        private System.Windows.Forms.ToolStripMenuItem cellColorDarkGreen;
        private System.Windows.Forms.ToolStripMenuItem cellColorRandom;
        private System.Windows.Forms.ToolStripMenuItem backgroundToolColor;
        private System.Windows.Forms.ToolStripMenuItem bckgrndRed;
        private System.Windows.Forms.ToolStripMenuItem bckgrndBlue;
        private System.Windows.Forms.ToolStripMenuItem bckgrndYellow;
        private System.Windows.Forms.ToolStripMenuItem bckgrndBrown;
        private System.Windows.Forms.ToolStripMenuItem bckgrndAqua;
        private System.Windows.Forms.ToolStripMenuItem bckgrndHotPink;
        private System.Windows.Forms.ToolStripMenuItem bckgrndDarkGreen;
        private System.Windows.Forms.ToolStripMenuItem bckgrndRandom;
        private System.Windows.Forms.Label label6;
    }
}

