
namespace Alarm501
{
    partial class newAlarm
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
            this.AlarmSet = new System.Windows.Forms.DateTimePicker();
            this.onOrOff = new System.Windows.Forms.CheckBox();
            this.cancelButton = new System.Windows.Forms.Button();
            this.setButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // AlarmSet
            // 
            this.AlarmSet.Location = new System.Drawing.Point(31, 102);
            this.AlarmSet.Name = "AlarmSet";
            this.AlarmSet.Size = new System.Drawing.Size(589, 38);
            this.AlarmSet.TabIndex = 0;
            this.AlarmSet.Value = new System.DateTime(2022, 1, 24, 11, 41, 8, 0);
            // 
            // onOrOff
            // 
            this.onOrOff.AutoSize = true;
            this.onOrOff.Location = new System.Drawing.Point(667, 102);
            this.onOrOff.Name = "onOrOff";
            this.onOrOff.Size = new System.Drawing.Size(91, 36);
            this.onOrOff.TabIndex = 1;
            this.onOrOff.Text = "On";
            this.onOrOff.UseVisualStyleBackColor = true;
            // 
            // cancelButton
            // 
            this.cancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancelButton.Location = new System.Drawing.Point(31, 335);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(128, 66);
            this.cancelButton.TabIndex = 2;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // setButton
            // 
            this.setButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.setButton.Location = new System.Drawing.Point(630, 347);
            this.setButton.Name = "setButton";
            this.setButton.Size = new System.Drawing.Size(128, 66);
            this.setButton.TabIndex = 3;
            this.setButton.Text = "Set";
            this.setButton.UseVisualStyleBackColor = true;
            this.setButton.Click += new System.EventHandler(this.setButton_Click);
            // 
            // newAlarm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.setButton);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.onOrOff);
            this.Controls.Add(this.AlarmSet);
            this.Name = "newAlarm";
            this.Text = "Add/Edit Alarm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Button setButton;
        public System.Windows.Forms.DateTimePicker AlarmSet;
        public System.Windows.Forms.CheckBox onOrOff;
    }
}