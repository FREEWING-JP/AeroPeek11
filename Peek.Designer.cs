namespace AeroPeek11
{
    partial class Peek
    {
        private System.ComponentModel.IContainer Components = null;

        protected override void Dispose(bool Disposing)
        {
            if(Disposing && (Components != null))
            {
                Components.Dispose();
            }

            base.Dispose(Disposing);
        }

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Peek));
            this.SuspendLayout();
            // 
            // Peek
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(54, 31);
            this.ControlBox = false;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Peek";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AeroPeek11";
            this.TopMost = true;
            this.TransparencyKey = System.Drawing.Color.Maroon;
            this.Load += new System.EventHandler(this.Peek_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Peek_MouseDown);
            this.MouseEnter += new System.EventHandler(this.Peek_MouseEnter);
            this.MouseLeave += new System.EventHandler(this.Peek_MouseLeave);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Peek_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Peek_MouseUp);
            this.ResumeLayout(false);

        }
    }
}