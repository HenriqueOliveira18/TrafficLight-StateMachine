namespace Semaforo
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
            this.label1 = new System.Windows.Forms.Label();
            this.GreenBox = new System.Windows.Forms.PictureBox();
            this.yellowBox = new System.Windows.Forms.PictureBox();
            this.redBox = new System.Windows.Forms.PictureBox();
            this.changeStateBtn = new System.Windows.Forms.Button();
            this.currentStateLabel = new System.Windows.Forms.Label();
            this.resetBtn = new System.Windows.Forms.Button();
            this.orangeBox = new System.Windows.Forms.PictureBox();
            this.startBlinkBtn = new System.Windows.Forms.Button();
            this.StartStateMachineBtn = new System.Windows.Forms.Button();
            this.sqlConnectBtn = new System.Windows.Forms.Button();
            this.sql_label = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.addPersonBtn = new System.Windows.Forms.Button();
            this.msgBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.nameBox = new System.Windows.Forms.TextBox();
            this.refreshTableBtn = new System.Windows.Forms.Button();
            this.deleteRowBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.GreenBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.yellowBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.redBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.orangeBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 94);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "label1";
            // 
            // GreenBox
            // 
            this.GreenBox.BackColor = System.Drawing.Color.Green;
            this.GreenBox.Location = new System.Drawing.Point(206, 136);
            this.GreenBox.Name = "GreenBox";
            this.GreenBox.Size = new System.Drawing.Size(28, 32);
            this.GreenBox.TabIndex = 2;
            this.GreenBox.TabStop = false;
            // 
            // yellowBox
            // 
            this.yellowBox.BackColor = System.Drawing.Color.Yellow;
            this.yellowBox.Location = new System.Drawing.Point(206, 175);
            this.yellowBox.Name = "yellowBox";
            this.yellowBox.Size = new System.Drawing.Size(28, 32);
            this.yellowBox.TabIndex = 3;
            this.yellowBox.TabStop = false;
            // 
            // redBox
            // 
            this.redBox.BackColor = System.Drawing.Color.Red;
            this.redBox.Location = new System.Drawing.Point(206, 213);
            this.redBox.Name = "redBox";
            this.redBox.Size = new System.Drawing.Size(28, 30);
            this.redBox.TabIndex = 4;
            this.redBox.TabStop = false;
            // 
            // changeStateBtn
            // 
            this.changeStateBtn.Location = new System.Drawing.Point(42, 110);
            this.changeStateBtn.Name = "changeStateBtn";
            this.changeStateBtn.Size = new System.Drawing.Size(131, 52);
            this.changeStateBtn.TabIndex = 5;
            this.changeStateBtn.Text = "Change State";
            this.changeStateBtn.UseVisualStyleBackColor = true;
            this.changeStateBtn.Click += new System.EventHandler(this.changeStateBtn_Click);
            // 
            // currentStateLabel
            // 
            this.currentStateLabel.AutoSize = true;
            this.currentStateLabel.Location = new System.Drawing.Point(185, 277);
            this.currentStateLabel.Name = "currentStateLabel";
            this.currentStateLabel.Size = new System.Drawing.Size(66, 13);
            this.currentStateLabel.TabIndex = 6;
            this.currentStateLabel.Text = "CurrentState";
            // 
            // resetBtn
            // 
            this.resetBtn.Location = new System.Drawing.Point(42, 168);
            this.resetBtn.Name = "resetBtn";
            this.resetBtn.Size = new System.Drawing.Size(131, 49);
            this.resetBtn.TabIndex = 7;
            this.resetBtn.Text = "Reset To Green State";
            this.resetBtn.UseVisualStyleBackColor = true;
            this.resetBtn.Click += new System.EventHandler(this.resetBtn_Click);
            // 
            // orangeBox
            // 
            this.orangeBox.BackColor = System.Drawing.Color.Orange;
            this.orangeBox.Location = new System.Drawing.Point(253, 136);
            this.orangeBox.Name = "orangeBox";
            this.orangeBox.Size = new System.Drawing.Size(22, 107);
            this.orangeBox.TabIndex = 8;
            this.orangeBox.TabStop = false;
            // 
            // startBlinkBtn
            // 
            this.startBlinkBtn.Location = new System.Drawing.Point(42, 223);
            this.startBlinkBtn.Name = "startBlinkBtn";
            this.startBlinkBtn.Size = new System.Drawing.Size(131, 49);
            this.startBlinkBtn.TabIndex = 9;
            this.startBlinkBtn.Text = "Start Blinking";
            this.startBlinkBtn.UseVisualStyleBackColor = true;
            this.startBlinkBtn.Click += new System.EventHandler(this.startBlinkBtn_Click);
            // 
            // StartStateMachineBtn
            // 
            this.StartStateMachineBtn.Location = new System.Drawing.Point(0, 0);
            this.StartStateMachineBtn.Name = "StartStateMachineBtn";
            this.StartStateMachineBtn.Size = new System.Drawing.Size(75, 23);
            this.StartStateMachineBtn.TabIndex = 10;
            // 
            // sqlConnectBtn
            // 
            this.sqlConnectBtn.Location = new System.Drawing.Point(451, 12);
            this.sqlConnectBtn.Name = "sqlConnectBtn";
            this.sqlConnectBtn.Size = new System.Drawing.Size(159, 44);
            this.sqlConnectBtn.TabIndex = 11;
            this.sqlConnectBtn.Text = "Refresh SQL Table";
            this.sqlConnectBtn.UseVisualStyleBackColor = true;
            this.sqlConnectBtn.Click += new System.EventHandler(this.sqlConnectBtn_Click);
            // 
            // sql_label
            // 
            this.sql_label.AutoSize = true;
            this.sql_label.Location = new System.Drawing.Point(485, 67);
            this.sql_label.Name = "sql_label";
            this.sql_label.Size = new System.Drawing.Size(48, 13);
            this.sql_label.TabIndex = 12;
            this.sql_label.Text = "sql_label";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.RosyBrown;
            this.pictureBox1.Location = new System.Drawing.Point(188, 123);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(102, 140);
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            // 
            // addPersonBtn
            // 
            this.addPersonBtn.Location = new System.Drawing.Point(351, 233);
            this.addPersonBtn.Name = "addPersonBtn";
            this.addPersonBtn.Size = new System.Drawing.Size(82, 29);
            this.addPersonBtn.TabIndex = 14;
            this.addPersonBtn.Text = "Add Person";
            this.addPersonBtn.UseVisualStyleBackColor = true;
            this.addPersonBtn.Click += new System.EventHandler(this.addPersonBtn_Click);
            // 
            // msgBox
            // 
            this.msgBox.Location = new System.Drawing.Point(351, 207);
            this.msgBox.Name = "msgBox";
            this.msgBox.Size = new System.Drawing.Size(82, 20);
            this.msgBox.TabIndex = 15;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(348, 194);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 13);
            this.label2.TabIndex = 16;
            this.label2.Text = "Msg";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(348, 158);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 18;
            this.label3.Text = "Name";
            // 
            // nameBox
            // 
            this.nameBox.Location = new System.Drawing.Point(351, 171);
            this.nameBox.Name = "nameBox";
            this.nameBox.Size = new System.Drawing.Size(82, 20);
            this.nameBox.TabIndex = 17;
            // 
            // refreshTableBtn
            // 
            this.refreshTableBtn.Location = new System.Drawing.Point(0, 0);
            this.refreshTableBtn.Name = "refreshTableBtn";
            this.refreshTableBtn.Size = new System.Drawing.Size(75, 23);
            this.refreshTableBtn.TabIndex = 0;
            // 
            // deleteRowBtn
            // 
            this.deleteRowBtn.Location = new System.Drawing.Point(451, 260);
            this.deleteRowBtn.Name = "deleteRowBtn";
            this.deleteRowBtn.Size = new System.Drawing.Size(159, 23);
            this.deleteRowBtn.TabIndex = 19;
            this.deleteRowBtn.Text = "Delete Last Row";
            this.deleteRowBtn.UseVisualStyleBackColor = true;
            this.deleteRowBtn.Click += new System.EventHandler(this.deleteRowBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(625, 300);
            this.Controls.Add(this.deleteRowBtn);
            this.Controls.Add(this.refreshTableBtn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.nameBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.msgBox);
            this.Controls.Add(this.addPersonBtn);
            this.Controls.Add(this.sql_label);
            this.Controls.Add(this.sqlConnectBtn);
            this.Controls.Add(this.startBlinkBtn);
            this.Controls.Add(this.orangeBox);
            this.Controls.Add(this.resetBtn);
            this.Controls.Add(this.currentStateLabel);
            this.Controls.Add(this.changeStateBtn);
            this.Controls.Add(this.redBox);
            this.Controls.Add(this.yellowBox);
            this.Controls.Add(this.GreenBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.StartStateMachineBtn);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GreenBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.yellowBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.redBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.orangeBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox GreenBox;
        private System.Windows.Forms.PictureBox yellowBox;
        private System.Windows.Forms.PictureBox redBox;
        private System.Windows.Forms.Button changeStateBtn;
        private System.Windows.Forms.Label currentStateLabel;
        private System.Windows.Forms.Button resetBtn;
        private System.Windows.Forms.PictureBox orangeBox;
        private System.Windows.Forms.Button startBlinkBtn;
        private System.Windows.Forms.Button StartStateMachineBtn;
        private System.Windows.Forms.Button sqlConnectBtn;
        private System.Windows.Forms.Label sql_label;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button addPersonBtn;
        private System.Windows.Forms.TextBox msgBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox nameBox;
        private System.Windows.Forms.Button refreshTableBtn;
        private System.Windows.Forms.Button deleteRowBtn;
    }
}

