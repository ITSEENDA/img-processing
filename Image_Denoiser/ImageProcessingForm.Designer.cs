﻿using System.Windows.Forms;

namespace PROTO
{
    partial class ImageProcessingForm
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
            this.loadButton = new System.Windows.Forms.Button();
            this.saveButton = new System.Windows.Forms.Button();
            this.logoutButton = new System.Windows.Forms.Button();
            this.processTimer = new System.Windows.Forms.Timer(this.components);
            this.saveTimer = new System.Windows.Forms.Timer(this.components);
            this.inputImageBox = new System.Windows.Forms.PictureBox();
            this.outputImageBox = new System.Windows.Forms.PictureBox();
            this.filterOptionBox = new System.Windows.Forms.ComboBox();
            this.currentSelectedSizeLabel = new System.Windows.Forms.Label();
            this.processButton = new System.Windows.Forms.Button();
            this.resetButton = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.helloLabel = new System.Windows.Forms.Label();
            this.deleteAccountButton = new System.Windows.Forms.Button();
            this.changePasswordButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.inputImageBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.outputImageBox)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // loadButton
            // 
            this.loadButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.loadButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.loadButton.Location = new System.Drawing.Point(52, 299);
            this.loadButton.Name = "loadButton";
            this.loadButton.Size = new System.Drawing.Size(119, 33);
            this.loadButton.TabIndex = 4;
            this.loadButton.Text = "Load";
            this.loadButton.UseVisualStyleBackColor = true;
            this.loadButton.Click += new System.EventHandler(this.OnLoadButtonClick);
            // 
            // saveButton
            // 
            this.saveButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.saveButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.saveButton.Location = new System.Drawing.Point(629, 309);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(119, 33);
            this.saveButton.TabIndex = 5;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.OnSaveButtonClick);
            // 
            // logoutButton
            // 
            this.logoutButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.logoutButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.logoutButton.Location = new System.Drawing.Point(663, 404);
            this.logoutButton.Name = "logoutButton";
            this.logoutButton.Size = new System.Drawing.Size(125, 34);
            this.logoutButton.TabIndex = 6;
            this.logoutButton.Text = "Logout";
            this.logoutButton.UseVisualStyleBackColor = true;
            this.logoutButton.Click += new System.EventHandler(this.OnLogoutButtonClick);
            // 
            // processTimer
            // 
            this.processTimer.Interval = 50;
            // 
            // saveTimer
            // 
            this.saveTimer.Interval = 50;
            // 
            // inputImageBox
            // 
            this.inputImageBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.inputImageBox.Location = new System.Drawing.Point(12, 73);
            this.inputImageBox.Name = "inputImageBox";
            this.inputImageBox.Size = new System.Drawing.Size(254, 214);
            this.inputImageBox.TabIndex = 0;
            this.inputImageBox.TabStop = false;
            // 
            // outputImageBox
            // 
            this.outputImageBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.outputImageBox.Location = new System.Drawing.Point(534, 73);
            this.outputImageBox.Name = "outputImageBox";
            this.outputImageBox.Size = new System.Drawing.Size(254, 214);
            this.outputImageBox.TabIndex = 1;
            this.outputImageBox.TabStop = false;
            // 
            // filterOptionBox
            // 
            this.filterOptionBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.filterOptionBox.FormattingEnabled = true;
            this.filterOptionBox.Location = new System.Drawing.Point(303, 114);
            this.filterOptionBox.Name = "filterOptionBox";
            this.filterOptionBox.Size = new System.Drawing.Size(191, 24);
            this.filterOptionBox.TabIndex = 2;
            // 
            // currentSelectedSizeLabel
            // 
            this.currentSelectedSizeLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.currentSelectedSizeLabel.AutoSize = true;
            this.currentSelectedSizeLabel.Location = new System.Drawing.Point(531, 290);
            this.currentSelectedSizeLabel.Name = "currentSelectedSizeLabel";
            this.currentSelectedSizeLabel.Size = new System.Drawing.Size(202, 16);
            this.currentSelectedSizeLabel.TabIndex = 11;
            this.currentSelectedSizeLabel.Text = "Current selected size: 200x200 px";
            // 
            // processButton
            // 
            this.processButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.processButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.processButton.Location = new System.Drawing.Point(317, 238);
            this.processButton.Name = "processButton";
            this.processButton.Size = new System.Drawing.Size(167, 49);
            this.processButton.TabIndex = 3;
            this.processButton.Text = "Process";
            this.processButton.UseVisualStyleBackColor = true;
            this.processButton.Click += new System.EventHandler(this.OnProcessButtonClick);
            // 
            // resetButton
            // 
            this.resetButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.resetButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.resetButton.Location = new System.Drawing.Point(346, 165);
            this.resetButton.Name = "resetButton";
            this.resetButton.Size = new System.Drawing.Size(106, 29);
            this.resetButton.TabIndex = 12;
            this.resetButton.Text = "ResetFilter";
            this.resetButton.UseVisualStyleBackColor = true;
            this.resetButton.Click += new System.EventHandler(this.OnResetButtonClick);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.changePasswordButton);
            this.panel3.Controls.Add(this.saveButton);
            this.panel3.Controls.Add(this.helloLabel);
            this.panel3.Controls.Add(this.deleteAccountButton);
            this.panel3.Controls.Add(this.resetButton);
            this.panel3.Controls.Add(this.processButton);
            this.panel3.Controls.Add(this.currentSelectedSizeLabel);
            this.panel3.Controls.Add(this.filterOptionBox);
            this.panel3.Controls.Add(this.outputImageBox);
            this.panel3.Controls.Add(this.inputImageBox);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(800, 450);
            this.panel3.TabIndex = 14;
            // 
            // helloLabel
            // 
            this.helloLabel.AutoSize = true;
            this.helloLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.helloLabel.Location = new System.Drawing.Point(12, 18);
            this.helloLabel.Name = "helloLabel";
            this.helloLabel.Size = new System.Drawing.Size(161, 32);
            this.helloLabel.TabIndex = 16;
            this.helloLabel.Text = "Hello user!";
            // 
            // deleteAccountButton
            // 
            this.deleteAccountButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.deleteAccountButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.deleteAccountButton.ForeColor = System.Drawing.Color.Red;
            this.deleteAccountButton.Location = new System.Drawing.Point(629, 12);
            this.deleteAccountButton.Name = "deleteAccountButton";
            this.deleteAccountButton.Size = new System.Drawing.Size(159, 34);
            this.deleteAccountButton.TabIndex = 15;
            this.deleteAccountButton.Text = "Delete Account";
            this.deleteAccountButton.UseVisualStyleBackColor = true;
            this.deleteAccountButton.Click += new System.EventHandler(this.OnDeleteAccountClick);
            // 
            // changePasswordButton
            // 
            this.changePasswordButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.changePasswordButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.changePasswordButton.ForeColor = System.Drawing.Color.Black;
            this.changePasswordButton.Location = new System.Drawing.Point(431, 12);
            this.changePasswordButton.Name = "changePasswordButton";
            this.changePasswordButton.Size = new System.Drawing.Size(192, 34);
            this.changePasswordButton.TabIndex = 17;
            this.changePasswordButton.Text = "Change Password";
            this.changePasswordButton.UseVisualStyleBackColor = true;
            this.changePasswordButton.Click += new System.EventHandler(this.OnChangePasswordButtonClick);
            // 
            // ImageProcessingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.logoutButton);
            this.Controls.Add(this.loadButton);
            this.Controls.Add(this.panel3);
            this.MinimumSize = new System.Drawing.Size(818, 497);
            this.Name = "ImageProcessingForm";
            this.Text = "ImageProcessing";
            ((System.ComponentModel.ISupportInitialize)(this.inputImageBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.outputImageBox)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }




        #endregion
        private System.Windows.Forms.Button loadButton;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Button logoutButton;
        private Timer processTimer;
        private Timer saveTimer;
        private PictureBox inputImageBox;
        private PictureBox outputImageBox;
        private ComboBox filterOptionBox;
        private Label currentSelectedSizeLabel;
        private Button processButton;
        private Button resetButton;
        private Panel panel3;
        private Label helloLabel;
        private Button deleteAccountButton;
        private Button changePasswordButton;
    }
}