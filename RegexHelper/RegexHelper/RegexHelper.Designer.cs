namespace RegexHelper
{
    partial class RegexHelper
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
            this.tlpMain = new System.Windows.Forms.TableLayoutPanel();
            this.rtxInput = new System.Windows.Forms.RichTextBox();
            this.rtxOutput = new System.Windows.Forms.RichTextBox();
            this.splitContainer = new System.Windows.Forms.SplitContainer();
            this.tplMatch = new System.Windows.Forms.TableLayoutPanel();
            this.btnMatch = new System.Windows.Forms.Button();
            this.txtMatch = new System.Windows.Forms.TextBox();
            this.tlpReplace = new System.Windows.Forms.TableLayoutPanel();
            this.txtReplace = new System.Windows.Forms.TextBox();
            this.btnReplace = new System.Windows.Forms.Button();
            this.tlpMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).BeginInit();
            this.splitContainer.Panel1.SuspendLayout();
            this.splitContainer.Panel2.SuspendLayout();
            this.splitContainer.SuspendLayout();
            this.tplMatch.SuspendLayout();
            this.tlpReplace.SuspendLayout();
            this.SuspendLayout();
            // 
            // tlpMain
            // 
            this.tlpMain.ColumnCount = 1;
            this.tlpMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpMain.Controls.Add(this.rtxInput, 0, 0);
            this.tlpMain.Controls.Add(this.rtxOutput, 0, 2);
            this.tlpMain.Controls.Add(this.splitContainer, 0, 1);
            this.tlpMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpMain.Location = new System.Drawing.Point(0, 0);
            this.tlpMain.Name = "tlpMain";
            this.tlpMain.RowCount = 3;
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpMain.Size = new System.Drawing.Size(1331, 809);
            this.tlpMain.TabIndex = 0;
            // 
            // rtxInput
            // 
            this.rtxInput.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtxInput.Location = new System.Drawing.Point(3, 3);
            this.rtxInput.Name = "rtxInput";
            this.rtxInput.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.rtxInput.Size = new System.Drawing.Size(1325, 378);
            this.rtxInput.TabIndex = 0;
            this.rtxInput.Text = "";
            // 
            // rtxOutput
            // 
            this.rtxOutput.BackColor = System.Drawing.SystemColors.ControlLight;
            this.rtxOutput.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtxOutput.Location = new System.Drawing.Point(3, 427);
            this.rtxOutput.Name = "rtxOutput";
            this.rtxOutput.ReadOnly = true;
            this.rtxOutput.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.rtxOutput.Size = new System.Drawing.Size(1325, 379);
            this.rtxOutput.TabIndex = 1;
            this.rtxOutput.Text = "";
            // 
            // splitContainer
            // 
            this.splitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer.Location = new System.Drawing.Point(3, 387);
            this.splitContainer.Name = "splitContainer";
            // 
            // splitContainer.Panel1
            // 
            this.splitContainer.Panel1.Controls.Add(this.tplMatch);
            this.splitContainer.Panel1MinSize = 100;
            // 
            // splitContainer.Panel2
            // 
            this.splitContainer.Panel2.Controls.Add(this.tlpReplace);
            this.splitContainer.Panel2MinSize = 100;
            this.splitContainer.Size = new System.Drawing.Size(1325, 34);
            this.splitContainer.SplitterDistance = 652;
            this.splitContainer.TabIndex = 2;
            this.splitContainer.SplitterMoved += new System.Windows.Forms.SplitterEventHandler(this.splitContainer_SplitterMoved);
            // 
            // tplMatch
            // 
            this.tplMatch.ColumnCount = 2;
            this.tplMatch.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tplMatch.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 70F));
            this.tplMatch.Controls.Add(this.btnMatch, 1, 0);
            this.tplMatch.Controls.Add(this.txtMatch, 0, 0);
            this.tplMatch.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tplMatch.Location = new System.Drawing.Point(0, 0);
            this.tplMatch.Name = "tplMatch";
            this.tplMatch.RowCount = 1;
            this.tplMatch.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tplMatch.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 34F));
            this.tplMatch.Size = new System.Drawing.Size(652, 34);
            this.tplMatch.TabIndex = 0;
            // 
            // btnMatch
            // 
            this.btnMatch.Location = new System.Drawing.Point(585, 3);
            this.btnMatch.Name = "btnMatch";
            this.btnMatch.Size = new System.Drawing.Size(64, 23);
            this.btnMatch.TabIndex = 0;
            this.btnMatch.Text = "Match";
            this.btnMatch.UseVisualStyleBackColor = true;
            this.btnMatch.Click += new System.EventHandler(this.btnMatch_Click);
            // 
            // txtMatch
            // 
            this.txtMatch.BackColor = System.Drawing.Color.White;
            this.txtMatch.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtMatch.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMatch.Location = new System.Drawing.Point(3, 3);
            this.txtMatch.Name = "txtMatch";
            this.txtMatch.Size = new System.Drawing.Size(576, 27);
            this.txtMatch.TabIndex = 1;
            this.txtMatch.TextChanged += new System.EventHandler(this.TextBoxTextChanged);
            this.txtMatch.KeyDown += new System.Windows.Forms.KeyEventHandler(this.KeyDown);
            // 
            // tlpReplace
            // 
            this.tlpReplace.ColumnCount = 2;
            this.tlpReplace.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpReplace.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 70F));
            this.tlpReplace.Controls.Add(this.txtReplace, 0, 0);
            this.tlpReplace.Controls.Add(this.btnReplace, 1, 0);
            this.tlpReplace.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpReplace.Location = new System.Drawing.Point(0, 0);
            this.tlpReplace.Name = "tlpReplace";
            this.tlpReplace.RowCount = 1;
            this.tlpReplace.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpReplace.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 34F));
            this.tlpReplace.Size = new System.Drawing.Size(669, 34);
            this.tlpReplace.TabIndex = 0;
            // 
            // txtReplace
            // 
            this.txtReplace.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtReplace.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtReplace.Location = new System.Drawing.Point(3, 3);
            this.txtReplace.Name = "txtReplace";
            this.txtReplace.Size = new System.Drawing.Size(593, 27);
            this.txtReplace.TabIndex = 0;
            this.txtReplace.TextChanged += new System.EventHandler(this.TextBoxTextChanged);
            this.txtReplace.KeyDown += new System.Windows.Forms.KeyEventHandler(this.KeyDown);
            // 
            // btnReplace
            // 
            this.btnReplace.Location = new System.Drawing.Point(602, 3);
            this.btnReplace.Name = "btnReplace";
            this.btnReplace.Size = new System.Drawing.Size(64, 23);
            this.btnReplace.TabIndex = 1;
            this.btnReplace.Text = "Replace";
            this.btnReplace.UseVisualStyleBackColor = true;
            this.btnReplace.Click += new System.EventHandler(this.btnReplace_Click);
            // 
            // RegexHelper
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1331, 809);
            this.Controls.Add(this.tlpMain);
            this.MaximizeBox = false;
            this.Name = "RegexHelper";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RegexHelper";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.tlpMain.ResumeLayout(false);
            this.splitContainer.Panel1.ResumeLayout(false);
            this.splitContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).EndInit();
            this.splitContainer.ResumeLayout(false);
            this.tplMatch.ResumeLayout(false);
            this.tplMatch.PerformLayout();
            this.tlpReplace.ResumeLayout(false);
            this.tlpReplace.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlpMain;
        private System.Windows.Forms.RichTextBox rtxInput;
        private System.Windows.Forms.RichTextBox rtxOutput;
        private System.Windows.Forms.SplitContainer splitContainer;
        private System.Windows.Forms.TableLayoutPanel tplMatch;
        private System.Windows.Forms.Button btnMatch;
        private System.Windows.Forms.TextBox txtMatch;
        private System.Windows.Forms.TableLayoutPanel tlpReplace;
        private System.Windows.Forms.TextBox txtReplace;
        private System.Windows.Forms.Button btnReplace;
    }
}

