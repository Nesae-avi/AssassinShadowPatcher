namespace AssassinShadowPatcher
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel_Main = new System.Windows.Forms.Panel();
            this.panel_ExecutableSelection = new System.Windows.Forms.Panel();
            this.button_SelectEXE = new System.Windows.Forms.Button();
            this.textBox_GameExecutablePath = new System.Windows.Forms.TextBox();
            this.panel_Buttons = new System.Windows.Forms.Panel();
            this.button_Restore = new System.Windows.Forms.Button();
            this.button_Patch = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.panel_Main.SuspendLayout();
            this.panel_ExecutableSelection.SuspendLayout();
            this.panel_Buttons.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_Main
            // 
            this.panel_Main.Controls.Add(this.panel_ExecutableSelection);
            this.panel_Main.Controls.Add(this.panel_Buttons);
            this.panel_Main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_Main.Location = new System.Drawing.Point(0, 0);
            this.panel_Main.Name = "panel_Main";
            this.panel_Main.Size = new System.Drawing.Size(475, 190);
            this.panel_Main.TabIndex = 0;
            // 
            // panel_ExecutableSelection
            // 
            this.panel_ExecutableSelection.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel_ExecutableSelection.Controls.Add(this.button_SelectEXE);
            this.panel_ExecutableSelection.Controls.Add(this.textBox_GameExecutablePath);
            this.panel_ExecutableSelection.Location = new System.Drawing.Point(12, 25);
            this.panel_ExecutableSelection.Name = "panel_ExecutableSelection";
            this.panel_ExecutableSelection.Size = new System.Drawing.Size(322, 140);
            this.panel_ExecutableSelection.TabIndex = 1;
            // 
            // button_SelectEXE
            // 
            this.button_SelectEXE.Location = new System.Drawing.Point(120, 75);
            this.button_SelectEXE.Name = "button_SelectEXE";
            this.button_SelectEXE.Size = new System.Drawing.Size(80, 30);
            this.button_SelectEXE.TabIndex = 1;
            this.button_SelectEXE.Text = "Select EXE";
            this.button_SelectEXE.UseVisualStyleBackColor = true;
            this.button_SelectEXE.Click += new System.EventHandler(this.Button_SelectEXE_Click);
            // 
            // textBox_GameExecutablePath
            // 
            this.textBox_GameExecutablePath.AllowDrop = true;
            this.textBox_GameExecutablePath.Location = new System.Drawing.Point(24, 34);
            this.textBox_GameExecutablePath.Name = "textBox_GameExecutablePath";
            this.textBox_GameExecutablePath.PlaceholderText = "Drop the game executable here..";
            this.textBox_GameExecutablePath.Size = new System.Drawing.Size(273, 23);
            this.textBox_GameExecutablePath.TabIndex = 0;
            this.textBox_GameExecutablePath.DragDrop += new System.Windows.Forms.DragEventHandler(this.TextBox_GameExecutablePath_DragDrop);
            this.textBox_GameExecutablePath.DragOver += new System.Windows.Forms.DragEventHandler(this.TextBox_GameExecutablePath_DragOver);
            // 
            // panel_Buttons
            // 
            this.panel_Buttons.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel_Buttons.Controls.Add(this.button_Restore);
            this.panel_Buttons.Controls.Add(this.button_Patch);
            this.panel_Buttons.Location = new System.Drawing.Point(341, 25);
            this.panel_Buttons.Name = "panel_Buttons";
            this.panel_Buttons.Size = new System.Drawing.Size(122, 140);
            this.panel_Buttons.TabIndex = 0;
            // 
            // button_Restore
            // 
            this.button_Restore.Location = new System.Drawing.Point(20, 75);
            this.button_Restore.Name = "button_Restore";
            this.button_Restore.Size = new System.Drawing.Size(80, 30);
            this.button_Restore.TabIndex = 3;
            this.button_Restore.Text = "Restore";
            this.button_Restore.UseVisualStyleBackColor = true;
            this.button_Restore.Click += new System.EventHandler(this.Button_Restore_Click);
            // 
            // button_Patch
            // 
            this.button_Patch.Location = new System.Drawing.Point(20, 33);
            this.button_Patch.Name = "button_Patch";
            this.button_Patch.Size = new System.Drawing.Size(80, 30);
            this.button_Patch.TabIndex = 2;
            this.button_Patch.Text = "Patch";
            this.button_Patch.UseVisualStyleBackColor = true;
            this.button_Patch.Click += new System.EventHandler(this.Button_Patch_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(475, 190);
            this.Controls.Add(this.panel_Main);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Assassin Shadow Patcher";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel_Main.ResumeLayout(false);
            this.panel_ExecutableSelection.ResumeLayout(false);
            this.panel_ExecutableSelection.PerformLayout();
            this.panel_Buttons.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel_Main;
        private Panel panel_ExecutableSelection;
        private Button button_SelectEXE;
        private TextBox textBox_GameExecutablePath;
        private Panel panel_Buttons;
        private Button button_Restore;
        private Button button_Patch;
        private OpenFileDialog openFileDialog1;
    }
}