
namespace HenGioTatMay
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
            this.components = new System.ComponentModel.Container();
            this.numHour = new System.Windows.Forms.NumericUpDown();
            this.numMinute = new System.Windows.Forms.NumericUpDown();
            this.numSecond = new System.Windows.Forms.NumericUpDown();
            this.btnShutdown = new System.Windows.Forms.Button();
            this.btnRestart = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.lbStatus = new System.Windows.Forms.Label();
            this.lbTime = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.numHour)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMinute)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSecond)).BeginInit();
            this.SuspendLayout();
            // 
            // numHour
            // 
            this.numHour.Location = new System.Drawing.Point(21, 12);
            this.numHour.Name = "numHour";
            this.numHour.Size = new System.Drawing.Size(101, 22);
            this.numHour.TabIndex = 0;
            // 
            // numMinute
            // 
            this.numMinute.Location = new System.Drawing.Point(150, 12);
            this.numMinute.Name = "numMinute";
            this.numMinute.Size = new System.Drawing.Size(101, 22);
            this.numMinute.TabIndex = 0;
            // 
            // numSecond
            // 
            this.numSecond.Location = new System.Drawing.Point(280, 12);
            this.numSecond.Name = "numSecond";
            this.numSecond.Size = new System.Drawing.Size(101, 22);
            this.numSecond.TabIndex = 0;
            // 
            // btnShutdown
            // 
            this.btnShutdown.Location = new System.Drawing.Point(21, 53);
            this.btnShutdown.Name = "btnShutdown";
            this.btnShutdown.Size = new System.Drawing.Size(101, 23);
            this.btnShutdown.TabIndex = 1;
            this.btnShutdown.Text = "Shutdown";
            this.btnShutdown.UseVisualStyleBackColor = true;
            this.btnShutdown.Click += new System.EventHandler(this.btnShutdown_Click);
            // 
            // btnRestart
            // 
            this.btnRestart.Location = new System.Drawing.Point(150, 53);
            this.btnRestart.Name = "btnRestart";
            this.btnRestart.Size = new System.Drawing.Size(101, 23);
            this.btnRestart.TabIndex = 1;
            this.btnRestart.Text = "Restart";
            this.btnRestart.UseVisualStyleBackColor = true;
            this.btnRestart.Click += new System.EventHandler(this.btnRestart_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(280, 53);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(101, 23);
            this.btnCancel.TabIndex = 1;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // lbStatus
            // 
            this.lbStatus.AutoSize = true;
            this.lbStatus.Location = new System.Drawing.Point(21, 93);
            this.lbStatus.Name = "lbStatus";
            this.lbStatus.Size = new System.Drawing.Size(67, 17);
            this.lbStatus.TabIndex = 2;
            this.lbStatus.Text = "Waiting...";
            // 
            // lbTime
            // 
            this.lbTime.AutoSize = true;
            this.lbTime.Location = new System.Drawing.Point(277, 93);
            this.lbTime.Name = "lbTime";
            this.lbTime.Size = new System.Drawing.Size(0, 17);
            this.lbTime.TabIndex = 2;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(393, 114);
            this.Controls.Add(this.lbTime);
            this.Controls.Add(this.lbStatus);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnRestart);
            this.Controls.Add(this.btnShutdown);
            this.Controls.Add(this.numSecond);
            this.Controls.Add(this.numMinute);
            this.Controls.Add(this.numHour);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.numHour)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMinute)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSecond)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown numHour;
        private System.Windows.Forms.NumericUpDown numMinute;
        private System.Windows.Forms.NumericUpDown numSecond;
        private System.Windows.Forms.Button btnShutdown;
        private System.Windows.Forms.Button btnRestart;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label lbStatus;
        private System.Windows.Forms.Label lbTime;
        private System.Windows.Forms.Timer timer1;
    }
}

