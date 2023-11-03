namespace TrafficLight
{
    partial class TrafficLightForm
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pbRed = new System.Windows.Forms.PictureBox();
            this.pbYellow = new System.Windows.Forms.PictureBox();
            this.pbGreen = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lCurrentState = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.bBlinking = new System.Windows.Forms.Button();
            this.bReset = new System.Windows.Forms.Button();
            this.bState = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbRed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbYellow)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbGreen)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.pictureBox1.Location = new System.Drawing.Point(247, 45);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(140, 279);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // pbRed
            // 
            this.pbRed.BackColor = System.Drawing.Color.Red;
            this.pbRed.Location = new System.Drawing.Point(271, 65);
            this.pbRed.Name = "pbRed";
            this.pbRed.Size = new System.Drawing.Size(93, 67);
            this.pbRed.TabIndex = 1;
            this.pbRed.TabStop = false;
            // 
            // pbYellow
            // 
            this.pbYellow.BackColor = System.Drawing.Color.Yellow;
            this.pbYellow.Location = new System.Drawing.Point(271, 151);
            this.pbYellow.Name = "pbYellow";
            this.pbYellow.Size = new System.Drawing.Size(93, 67);
            this.pbYellow.TabIndex = 2;
            this.pbYellow.TabStop = false;
            // 
            // pbGreen
            // 
            this.pbGreen.BackColor = System.Drawing.Color.LimeGreen;
            this.pbGreen.Location = new System.Drawing.Point(271, 238);
            this.pbGreen.Name = "pbGreen";
            this.pbGreen.Size = new System.Drawing.Size(93, 67);
            this.pbGreen.TabIndex = 3;
            this.pbGreen.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(54, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Current State:";
            // 
            // lCurrentState
            // 
            this.lCurrentState.AutoSize = true;
            this.lCurrentState.Location = new System.Drawing.Point(139, 45);
            this.lCurrentState.Name = "lCurrentState";
            this.lCurrentState.Size = new System.Drawing.Size(43, 13);
            this.lCurrentState.TabIndex = 5;
            this.lCurrentState.Text = "------------";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.bBlinking, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.bReset, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.bState, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(51, 75);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(170, 221);
            this.tableLayoutPanel1.TabIndex = 6;
            // 
            // bBlinking
            // 
            this.bBlinking.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bBlinking.Location = new System.Drawing.Point(3, 149);
            this.bBlinking.Name = "bBlinking";
            this.bBlinking.Size = new System.Drawing.Size(164, 69);
            this.bBlinking.TabIndex = 2;
            this.bBlinking.Text = "Start Blinking";
            this.bBlinking.UseVisualStyleBackColor = true;
            this.bBlinking.Click += new System.EventHandler(this.bBlinking_Click);
            // 
            // bReset
            // 
            this.bReset.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bReset.Location = new System.Drawing.Point(3, 76);
            this.bReset.Name = "bReset";
            this.bReset.Size = new System.Drawing.Size(164, 67);
            this.bReset.TabIndex = 1;
            this.bReset.Text = "Reset";
            this.bReset.UseVisualStyleBackColor = true;
            this.bReset.Click += new System.EventHandler(this.bReset_Click);
            // 
            // bState
            // 
            this.bState.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bState.Location = new System.Drawing.Point(3, 3);
            this.bState.Name = "bState";
            this.bState.Size = new System.Drawing.Size(164, 67);
            this.bState.TabIndex = 0;
            this.bState.Text = "Change State";
            this.bState.UseVisualStyleBackColor = true;
            this.bState.Click += new System.EventHandler(this.bState_Click);
            // 
            // TrafficLightForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(453, 382);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.lCurrentState);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pbGreen);
            this.Controls.Add(this.pbYellow);
            this.Controls.Add(this.pbRed);
            this.Controls.Add(this.pictureBox1);
            this.Name = "TrafficLightForm";
            this.Text = "TrafficLight";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.TrafficLightForm_FormClosed);
            this.Load += new System.EventHandler(this.TrafficLightForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbRed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbYellow)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbGreen)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pbRed;
        private System.Windows.Forms.PictureBox pbYellow;
        private System.Windows.Forms.PictureBox pbGreen;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lCurrentState;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button bBlinking;
        private System.Windows.Forms.Button bReset;
        private System.Windows.Forms.Button bState;
    }
}

