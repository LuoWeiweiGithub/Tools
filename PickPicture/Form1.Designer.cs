namespace PickPicture
{
    partial class Form1
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
            this.txtPicPath = new System.Windows.Forms.TextBox();
            this.btnLoadPic = new System.Windows.Forms.Button();
            this.openPicDialog = new System.Windows.Forms.OpenFileDialog();
            this.panel1 = new System.Windows.Forms.Panel();
            this.picOriginal = new System.Windows.Forms.PictureBox();
            this.lblX = new System.Windows.Forms.Label();
            this.lblY = new System.Windows.Forms.Label();
            this.txtX1 = new System.Windows.Forms.TextBox();
            this.txtY1 = new System.Windows.Forms.TextBox();
            this.txtX2 = new System.Windows.Forms.TextBox();
            this.txtY2 = new System.Windows.Forms.TextBox();
            this.btnPick = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.picPicked = new System.Windows.Forms.PictureBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picOriginal)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picPicked)).BeginInit();
            this.SuspendLayout();
            // 
            // txtPicPath
            // 
            this.txtPicPath.Location = new System.Drawing.Point(2, 13);
            this.txtPicPath.Name = "txtPicPath";
            this.txtPicPath.Size = new System.Drawing.Size(377, 21);
            this.txtPicPath.TabIndex = 0;
            this.txtPicPath.DoubleClick += new System.EventHandler(this.txtPicPath_DoubleClick);
            // 
            // btnLoadPic
            // 
            this.btnLoadPic.Location = new System.Drawing.Point(399, 10);
            this.btnLoadPic.Name = "btnLoadPic";
            this.btnLoadPic.Size = new System.Drawing.Size(75, 23);
            this.btnLoadPic.TabIndex = 1;
            this.btnLoadPic.Text = "Load Pic";
            this.btnLoadPic.UseVisualStyleBackColor = true;
            this.btnLoadPic.Click += new System.EventHandler(this.btnLoadPic_Click);
            // 
            // openPicDialog
            // 
            this.openPicDialog.FileName = "Open Picture";
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.Controls.Add(this.picOriginal);
            this.panel1.Location = new System.Drawing.Point(13, 69);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(613, 666);
            this.panel1.TabIndex = 2;
            // 
            // picOriginal
            // 
            this.picOriginal.Location = new System.Drawing.Point(3, 3);
            this.picOriginal.Name = "picOriginal";
            this.picOriginal.Size = new System.Drawing.Size(100, 50);
            this.picOriginal.TabIndex = 0;
            this.picOriginal.TabStop = false;
            this.picOriginal.MouseClick += new System.Windows.Forms.MouseEventHandler(this.picOriginal_MouseClick);
            // 
            // lblX
            // 
            this.lblX.AutoSize = true;
            this.lblX.Location = new System.Drawing.Point(505, 20);
            this.lblX.Name = "lblX";
            this.lblX.Size = new System.Drawing.Size(41, 12);
            this.lblX.TabIndex = 3;
            this.lblX.Text = "label1";
            // 
            // lblY
            // 
            this.lblY.AutoSize = true;
            this.lblY.Location = new System.Drawing.Point(576, 21);
            this.lblY.Name = "lblY";
            this.lblY.Size = new System.Drawing.Size(41, 12);
            this.lblY.TabIndex = 4;
            this.lblY.Text = "label1";
            // 
            // txtX1
            // 
            this.txtX1.Location = new System.Drawing.Point(673, 10);
            this.txtX1.Name = "txtX1";
            this.txtX1.Size = new System.Drawing.Size(100, 21);
            this.txtX1.TabIndex = 5;
            // 
            // txtY1
            // 
            this.txtY1.Location = new System.Drawing.Point(797, 9);
            this.txtY1.Name = "txtY1";
            this.txtY1.Size = new System.Drawing.Size(100, 21);
            this.txtY1.TabIndex = 6;
            // 
            // txtX2
            // 
            this.txtX2.Location = new System.Drawing.Point(673, 38);
            this.txtX2.Name = "txtX2";
            this.txtX2.Size = new System.Drawing.Size(100, 21);
            this.txtX2.TabIndex = 7;
            // 
            // txtY2
            // 
            this.txtY2.Location = new System.Drawing.Point(797, 37);
            this.txtY2.Name = "txtY2";
            this.txtY2.Size = new System.Drawing.Size(100, 21);
            this.txtY2.TabIndex = 8;
            // 
            // btnPick
            // 
            this.btnPick.Location = new System.Drawing.Point(903, 10);
            this.btnPick.Name = "btnPick";
            this.btnPick.Size = new System.Drawing.Size(75, 23);
            this.btnPick.TabIndex = 9;
            this.btnPick.Text = "Pick";
            this.btnPick.UseVisualStyleBackColor = true;
            this.btnPick.Click += new System.EventHandler(this.btnPick_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.picPicked);
            this.panel2.Location = new System.Drawing.Point(633, 69);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(406, 621);
            this.panel2.TabIndex = 10;
            // 
            // picPicked
            // 
            this.picPicked.Location = new System.Drawing.Point(3, 3);
            this.picPicked.Name = "picPicked";
            this.picPicked.Size = new System.Drawing.Size(100, 50);
            this.picPicked.TabIndex = 0;
            this.picPicked.TabStop = false;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(903, 38);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 11;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1051, 797);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.btnPick);
            this.Controls.Add(this.txtY2);
            this.Controls.Add(this.txtX2);
            this.Controls.Add(this.txtY1);
            this.Controls.Add(this.txtX1);
            this.Controls.Add(this.lblY);
            this.Controls.Add(this.lblX);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnLoadPic);
            this.Controls.Add(this.txtPicPath);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picOriginal)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picPicked)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtPicPath;
        private System.Windows.Forms.Button btnLoadPic;
        private System.Windows.Forms.OpenFileDialog openPicDialog;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox picOriginal;
        private System.Windows.Forms.Label lblX;
        private System.Windows.Forms.Label lblY;
        private System.Windows.Forms.TextBox txtX1;
        private System.Windows.Forms.TextBox txtY1;
        private System.Windows.Forms.TextBox txtX2;
        private System.Windows.Forms.TextBox txtY2;
        private System.Windows.Forms.Button btnPick;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox picPicked;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
    }
}

