namespace Practika05._11
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.TextBox textBoxParent;

        // Освобождение ресурсов
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        // Инициализация компонентов
        private void InitializeComponent()
        {
            this.textBoxParent = new System.Windows.Forms.TextBox();
            this.SuspendLayout();

            // textBoxParent
            this.textBoxParent.Location = new System.Drawing.Point(12, 12);
            this.textBoxParent.Name = "textBoxParent";
            this.textBoxParent.Size = new System.Drawing.Size(260, 22);
            this.textBoxParent.TabIndex = 0;
            this.textBoxParent.TextChanged += new System.EventHandler(this.textBoxParent_TextChanged);

            // Form1
            this.ClientSize = new System.Drawing.Size(284, 61);
            this.Controls.Add(this.textBoxParent);
            this.Name = "Form1";
            this.Text = "Main Form";
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
