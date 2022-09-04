
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
            this.startBtnClick = new System.Windows.Forms.ToolStripMenuItem();
            this.fdSave = new System.Windows.Forms.SaveFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.picGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cellSize)).BeginInit();
            this.mMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // picGrid
            // 
            this.picGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.picGrid.Location = new System.Drawing.Point(16, 36);
            this.picGrid.Name = "picGrid";
            this.picGrid.Size = new System.Drawing.Size(783, 390);
            this.picGrid.TabIndex = 0;
            this.picGrid.TabStop = false;
            this.picGrid.MouseClick += new System.Windows.Forms.MouseEventHandler(this.grid_mouseClick);
            // 
            // cellSize
            // 
            this.cellSize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.cellSize.Location = new System.Drawing.Point(72, 440);
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
            this.cellSize.Size = new System.Drawing.Size(51, 20);
            this.cellSize.TabIndex = 1;
            this.cellSize.Value = new decimal(new int[] {
            7,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 440);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Cell Size:";
            // 
            // resetBtn
            // 
            this.resetBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.resetBtn.Location = new System.Drawing.Point(144, 437);
            this.resetBtn.Name = "resetBtn";
            this.resetBtn.Size = new System.Drawing.Size(64, 20);
            this.resetBtn.TabIndex = 3;
            this.resetBtn.Text = "Reset";
            this.resetBtn.UseVisualStyleBackColor = true;
            this.resetBtn.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // startBtn
            // 
            this.startBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.startBtn.Location = new System.Drawing.Point(714, 437);
            this.startBtn.Name = "startBtn";
            this.startBtn.Size = new System.Drawing.Size(64, 20);
            this.startBtn.TabIndex = 5;
            this.startBtn.Text = "Start";
            this.startBtn.UseVisualStyleBackColor = true;
            this.startBtn.Click += new System.EventHandler(this.startBtn_Click);
            // 
            // clearBtn
            // 
            this.clearBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.clearBtn.Location = new System.Drawing.Point(221, 437);
            this.clearBtn.Name = "clearBtn";
            this.clearBtn.Size = new System.Drawing.Size(64, 20);
            this.clearBtn.TabIndex = 6;
            this.clearBtn.Text = "Clear";
            this.clearBtn.UseVisualStyleBackColor = true;
            this.clearBtn.Click += new System.EventHandler(this.clear_btnClick);
            // 
            // mMain
            // 
            this.mMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileClick,
            this.gameClick});
            this.mMain.Location = new System.Drawing.Point(0, 0);
            this.mMain.Name = "mMain";
            this.mMain.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.mMain.Size = new System.Drawing.Size(809, 24);
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
            this.fileClick.Size = new System.Drawing.Size(37, 20);
            this.fileClick.Text = "&File";
            // 
            // loadPatterClick
            // 
            this.loadPatterClick.Name = "loadPatterClick";
            this.loadPatterClick.Size = new System.Drawing.Size(180, 22);
            this.loadPatterClick.Text = "&Load Pattern";
            this.loadPatterClick.Click += new System.EventHandler(this.loadPattern_Click);
            // 
            // savePatternClick
            // 
            this.savePatternClick.Name = "savePatternClick";
            this.savePatternClick.Size = new System.Drawing.Size(180, 22);
            this.savePatternClick.Text = "&Save Pattern";
            this.savePatternClick.Click += new System.EventHandler(this.savePattern_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(177, 6);
            // 
            // exitClick
            // 
            this.exitClick.Name = "exitClick";
            this.exitClick.Size = new System.Drawing.Size(180, 22);
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
            this.startBtnClick});
            this.gameClick.Name = "gameClick";
            this.gameClick.Size = new System.Drawing.Size(50, 20);
            this.gameClick.Text = "&Game";
            // 
            // resetGridClick
            // 
            this.resetGridClick.Name = "resetGridClick";
            this.resetGridClick.Size = new System.Drawing.Size(180, 22);
            this.resetGridClick.Text = "&Reset Grid";
            this.resetGridClick.Click += new System.EventHandler(this.resetGrid_tool);
            // 
            // clearGridClick
            // 
            this.clearGridClick.Name = "clearGridClick";
            this.clearGridClick.Size = new System.Drawing.Size(180, 22);
            this.clearGridClick.Text = "&Clear Grid";
            this.clearGridClick.Click += new System.EventHandler(this.clearGrid_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(177, 6);
            // 
            // startBtnClick
            // 
            this.startBtnClick.Name = "startBtnClick";
            this.startBtnClick.Size = new System.Drawing.Size(180, 22);
            this.startBtnClick.Text = "&Start";
            this.startBtnClick.Click += new System.EventHandler(this.startTool_Click);
            // 
            // TonioLife
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(809, 504);
            this.Controls.Add(this.clearBtn);
            this.Controls.Add(this.startBtn);
            this.Controls.Add(this.resetBtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cellSize);
            this.Controls.Add(this.picGrid);
            this.Controls.Add(this.mMain);
            this.MainMenuStrip = this.mMain;
            this.MinimumSize = new System.Drawing.Size(825, 543);
            this.Name = "TonioLife";
            this.Text = "Tonio\'s Game Of Life";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.tonio_Closing);
            this.Load += new System.EventHandler(this.ConwayMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cellSize)).EndInit();
            this.mMain.ResumeLayout(false);
            this.mMain.PerformLayout();
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
    }
}

