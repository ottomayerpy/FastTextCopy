namespace FastTextCopy
{
    partial class Form1_Main
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.ToolItemChange = new System.Windows.Forms.ToolStripMenuItem();
            this.labelEdit = new System.Windows.Forms.Label();
            this.labelHook = new System.Windows.Forms.Label();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolItemChange});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(284, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // ToolItemChange
            // 
            this.ToolItemChange.Name = "ToolItemChange";
            this.ToolItemChange.Size = new System.Drawing.Size(60, 20);
            this.ToolItemChange.Text = "Change";
            this.ToolItemChange.Click += new System.EventHandler(this.ToolItemChange_Click);
            // 
            // labelEdit
            // 
            this.labelEdit.AutoSize = true;
            this.labelEdit.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.labelEdit.Location = new System.Drawing.Point(73, 6);
            this.labelEdit.Name = "labelEdit";
            this.labelEdit.Size = new System.Drawing.Size(70, 13);
            this.labelEdit.TabIndex = 1;
            this.labelEdit.Text = "Editing: False";
            // 
            // labelHook
            // 
            this.labelHook.AutoSize = true;
            this.labelHook.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.labelHook.Location = new System.Drawing.Point(149, 6);
            this.labelHook.Name = "labelHook";
            this.labelHook.Size = new System.Drawing.Size(61, 13);
            this.labelHook.TabIndex = 2;
            this.labelHook.Text = "Hook: True";
            // 
            // richTextBox1
            // 
            this.richTextBox1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.richTextBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTextBox1.Location = new System.Drawing.Point(0, 24);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ReadOnly = true;
            this.richTextBox1.Size = new System.Drawing.Size(284, 237);
            this.richTextBox1.TabIndex = 3;
            this.richTextBox1.Text = "";
            // 
            // Form1_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.labelHook);
            this.Controls.Add(this.labelEdit);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1_Main";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FastTextCopy";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_Main_FormClosing);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem ToolItemChange;
        private System.Windows.Forms.Label labelEdit;
        private System.Windows.Forms.Label labelHook;
        private System.Windows.Forms.RichTextBox richTextBox1;
    }
}