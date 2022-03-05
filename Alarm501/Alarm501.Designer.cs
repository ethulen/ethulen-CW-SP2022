
namespace Alarm501
{
    partial class Alarm501
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
            this.editButton = new System.Windows.Forms.Button();
            this.addButton = new System.Windows.Forms.Button();
            this.snoozeButton = new System.Windows.Forms.Button();
            this.stopButton = new System.Windows.Forms.Button();
            this.AlarmCheck = new System.Windows.Forms.Label();
            this.alarmList = new System.Windows.Forms.ListBox();
            this.status = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // editButton
            // 
            this.editButton.Enabled = false;
            this.editButton.Location = new System.Drawing.Point(62, 30);
            this.editButton.Name = "editButton";
            this.editButton.Size = new System.Drawing.Size(150, 80);
            this.editButton.TabIndex = 0;
            this.editButton.Text = "Edit";
            this.editButton.UseVisualStyleBackColor = true;
            this.editButton.Click += new System.EventHandler(this.editButton_Click);
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(552, 30);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(158, 80);
            this.addButton.TabIndex = 1;
            this.addButton.Text = "+";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // snoozeButton
            // 
            this.snoozeButton.Enabled = false;
            this.snoozeButton.Location = new System.Drawing.Point(62, 738);
            this.snoozeButton.Name = "snoozeButton";
            this.snoozeButton.Size = new System.Drawing.Size(150, 83);
            this.snoozeButton.TabIndex = 3;
            this.snoozeButton.Text = "Snooze";
            this.snoozeButton.UseVisualStyleBackColor = true;
            this.snoozeButton.Click += new System.EventHandler(this.snoozeButton_Click);
            // 
            // stopButton
            // 
            this.stopButton.Enabled = false;
            this.stopButton.Location = new System.Drawing.Point(552, 738);
            this.stopButton.Name = "stopButton";
            this.stopButton.Size = new System.Drawing.Size(157, 83);
            this.stopButton.TabIndex = 4;
            this.stopButton.Text = "Stop";
            this.stopButton.UseVisualStyleBackColor = true;
            this.stopButton.Click += new System.EventHandler(this.stopButton_Click);
            // 
            // AlarmCheck
            // 
            this.AlarmCheck.AutoSize = true;
            this.AlarmCheck.Location = new System.Drawing.Point(321, 835);
            this.AlarmCheck.Name = "AlarmCheck";
            this.AlarmCheck.Size = new System.Drawing.Size(0, 32);
            this.AlarmCheck.TabIndex = 5;
            // 
            // alarmList
            // 
            this.alarmList.FormattingEnabled = true;
            this.alarmList.ItemHeight = 31;
            this.alarmList.Location = new System.Drawing.Point(62, 139);
            this.alarmList.Name = "alarmList";
            this.alarmList.Size = new System.Drawing.Size(647, 593);
            this.alarmList.TabIndex = 6;
            this.alarmList.SelectedIndexChanged += new System.EventHandler(this.alarmList_SelectedIndexChanged);
            // 
            // status
            // 
            this.status.AutoSize = true;
            this.status.Location = new System.Drawing.Point(254, 759);
            this.status.Name = "status";
            this.status.Size = new System.Drawing.Size(0, 32);
            this.status.TabIndex = 8;
            // 
            // Alarm501
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 1083);
            this.Controls.Add(this.status);
            this.Controls.Add(this.alarmList);
            this.Controls.Add(this.AlarmCheck);
            this.Controls.Add(this.stopButton);
            this.Controls.Add(this.snoozeButton);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.editButton);
            this.Name = "Alarm501";
            this.Text = "Alarm501";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button editButton;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Button snoozeButton;
        private System.Windows.Forms.Button stopButton;
        private System.Windows.Forms.Label AlarmCheck;
        private System.Windows.Forms.ListBox alarmList;
        private System.Windows.Forms.Label status;
    }
}

