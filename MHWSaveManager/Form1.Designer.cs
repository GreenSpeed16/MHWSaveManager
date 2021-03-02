
namespace MHWSaveManager
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
            this.SaveBox = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.CurrentSaveLabel = new System.Windows.Forms.Label();
            this.MainSaveButton = new System.Windows.Forms.Button();
            this.LoadButton = new System.Windows.Forms.Button();
            this.DeleteButton = new System.Windows.Forms.Button();
            this.SetMainButton = new System.Windows.Forms.Button();
            this.SaveCurrentSave = new System.Windows.Forms.Button();
            this.SetWorldPath = new System.Windows.Forms.Button();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.SuspendLayout();
            // 
            // SaveBox
            // 
            this.SaveBox.FormattingEnabled = true;
            this.SaveBox.Location = new System.Drawing.Point(463, 35);
            this.SaveBox.Name = "SaveBox";
            this.SaveBox.Size = new System.Drawing.Size(103, 160);
            this.SaveBox.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(495, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Saves";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(262, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Current Save:";
            // 
            // CurrentSaveLabel
            // 
            this.CurrentSaveLabel.AutoSize = true;
            this.CurrentSaveLabel.Location = new System.Drawing.Point(282, 63);
            this.CurrentSaveLabel.Name = "CurrentSaveLabel";
            this.CurrentSaveLabel.Size = new System.Drawing.Size(31, 13);
            this.CurrentSaveLabel.TabIndex = 4;
            this.CurrentSaveLabel.Text = "Hello";
            // 
            // MainSaveButton
            // 
            this.MainSaveButton.Location = new System.Drawing.Point(463, 310);
            this.MainSaveButton.Name = "MainSaveButton";
            this.MainSaveButton.Size = new System.Drawing.Size(103, 23);
            this.MainSaveButton.TabIndex = 5;
            this.MainSaveButton.Text = "Load Main Save";
            this.MainSaveButton.UseVisualStyleBackColor = true;
            this.MainSaveButton.Click += new System.EventHandler(this.MainSaveButton_Click);
            // 
            // LoadButton
            // 
            this.LoadButton.Location = new System.Drawing.Point(463, 217);
            this.LoadButton.Name = "LoadButton";
            this.LoadButton.Size = new System.Drawing.Size(103, 23);
            this.LoadButton.TabIndex = 6;
            this.LoadButton.Text = "Load Selected";
            this.LoadButton.UseVisualStyleBackColor = true;
            this.LoadButton.Click += new System.EventHandler(this.LoadButton_Click);
            // 
            // DeleteButton
            // 
            this.DeleteButton.Location = new System.Drawing.Point(463, 262);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(103, 23);
            this.DeleteButton.TabIndex = 7;
            this.DeleteButton.Text = "Delete Selected";
            this.DeleteButton.UseVisualStyleBackColor = true;
            this.DeleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // SetMainButton
            // 
            this.SetMainButton.Location = new System.Drawing.Point(31, 101);
            this.SetMainButton.Name = "SetMainButton";
            this.SetMainButton.Size = new System.Drawing.Size(109, 23);
            this.SetMainButton.TabIndex = 8;
            this.SetMainButton.Text = "Set Main Save";
            this.SetMainButton.UseVisualStyleBackColor = true;
            this.SetMainButton.Click += new System.EventHandler(this.SetMainButton_Click);
            // 
            // SaveCurrentSave
            // 
            this.SaveCurrentSave.Location = new System.Drawing.Point(27, 142);
            this.SaveCurrentSave.Name = "SaveCurrentSave";
            this.SaveCurrentSave.Size = new System.Drawing.Size(113, 23);
            this.SaveCurrentSave.TabIndex = 9;
            this.SaveCurrentSave.Text = "Save Current";
            this.SaveCurrentSave.UseVisualStyleBackColor = true;
            this.SaveCurrentSave.Click += new System.EventHandler(this.SaveCurrentSave_Click);
            // 
            // SetWorldPath
            // 
            this.SetWorldPath.Location = new System.Drawing.Point(31, 63);
            this.SetWorldPath.Name = "SetWorldPath";
            this.SetWorldPath.Size = new System.Drawing.Size(109, 23);
            this.SetWorldPath.TabIndex = 10;
            this.SetWorldPath.Text = "Set World Folder";
            this.SetWorldPath.UseVisualStyleBackColor = true;
            this.SetWorldPath.Click += new System.EventHandler(this.SetWorldPath_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(593, 426);
            this.tabControl1.TabIndex = 11;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.SaveCurrentSave);
            this.tabPage1.Controls.Add(this.DeleteButton);
            this.tabPage1.Controls.Add(this.CurrentSaveLabel);
            this.tabPage1.Controls.Add(this.SetMainButton);
            this.tabPage1.Controls.Add(this.MainSaveButton);
            this.tabPage1.Controls.Add(this.SetWorldPath);
            this.tabPage1.Controls.Add(this.LoadButton);
            this.tabPage1.Controls.Add(this.SaveBox);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(585, 400);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Save Files";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(585, 400);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Create Save";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(617, 450);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "SaveTheWorld";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox SaveBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label CurrentSaveLabel;
        private System.Windows.Forms.Button MainSaveButton;
        private System.Windows.Forms.Button LoadButton;
        private System.Windows.Forms.Button DeleteButton;
        private System.Windows.Forms.Button SetMainButton;
        private System.Windows.Forms.Button SaveCurrentSave;
        private System.Windows.Forms.Button SetWorldPath;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
    }
}

