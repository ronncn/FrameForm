namespace FrameForm.Skin
{
    partial class DockForm
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
            this.view = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // viewPanels
            // 
            this.viewPanels.Size = new System.Drawing.Size(268, 393);
            // 
            // view
            // 
            this.view.Dock = System.Windows.Forms.DockStyle.Fill;
            this.view.Location = new System.Drawing.Point(2, 34);
            this.view.Name = "view";
            this.view.Size = new System.Drawing.Size(268, 393);
            this.view.TabIndex = 0;
            // 
            // DockForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.ClientSize = new System.Drawing.Size(272, 429);
            this.Controls.Add(this.view);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "DockForm";
            this.ShowIcon = false;
            this.StateIsShow = false;
            this.Activated += new System.EventHandler(this.DockForm_Activated);
            this.Deactivate += new System.EventHandler(this.DockForm_Deactivate);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.DockForm_FormClosing);
            this.Controls.SetChildIndex(this.view, 0);
            this.Controls.SetChildIndex(this.viewPanels, 0);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel view;
    }
}