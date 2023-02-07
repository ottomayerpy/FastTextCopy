using System;
using System.Windows.Forms;

namespace FastTextCopy
{
    public partial class Form1_Main : Form
    {
        bool Editing = false;
        bool Copy = false;

        public Form1_Main()
        {
            InitializeComponent();
            KBDHook.OnHookKeyPressEventHandler += new KBDHook.HookKeyPress(KBDHook_OnHookKeyPressEventHandler);
            KBDHook.InstallHook();
        }

        void KBDHook_OnHookKeyPressEventHandler(LLKHEventArgs e)
        {
            if ((e.Keys == Keys.Control) | (e.Keys == Keys.C))
            {
                if (Copy == false)
                {
                    Copy = true;
                    return;
                }
                else
                {
                    richTextBox1.Text += "\n" + Clipboard.GetText();
                    Copy = false;
                }
            }

            if (e.Keys == Keys.End && e.Keys == Keys.D0)
            {
                MessageBox.Show("");
            }
        }

        private void ToolItemChange_Click(object sender, EventArgs e)
        {
            if (Editing == false)
            {
                labelEdit.Text = "Editing: True";
                labelHook.Text = "Hook: False";
                richTextBox1.ReadOnly = false;
                KBDHook.UnInstallHook();
                Editing = true;
                return;
            }

            if (Editing == true)
            {
                labelEdit.Text = "Editing: False";
                labelHook.Text = "Hook: True";
                richTextBox1.ReadOnly = true;
                KBDHook.InstallHook();
                Editing = false;
            }
        }

        private void Form1_Main_FormClosing(object sender, FormClosingEventArgs e)
        {
            KBDHook.UnInstallHook();
        }
    }
}
