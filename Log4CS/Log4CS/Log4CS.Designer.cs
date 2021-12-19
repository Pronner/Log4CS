
namespace Log4CS
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
            this.components = new System.ComponentModel.Container();
            this.terminal = new System.Windows.Forms.RichTextBox();
            this.StartLogger = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // terminal
            // 
            this.terminal.BackColor = System.Drawing.Color.Black;
            this.terminal.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.terminal.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.terminal.Location = new System.Drawing.Point(-1, 0);
            this.terminal.Name = "terminal";
            this.terminal.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.ForcedBoth;
            this.terminal.Size = new System.Drawing.Size(865, 491);
            this.terminal.TabIndex = 0;
            this.terminal.Text = "";
            this.terminal.TextChanged += new System.EventHandler(this.terminal_TextChanged);
            this.terminal.KeyDown += new System.Windows.Forms.KeyEventHandler(this.terminal_KeyDown);
            // 
            // StartLogger
            // 
            this.StartLogger.Interval = 1;
            this.StartLogger.Tick += new System.EventHandler(this.StartLogger_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(860, 489);
            this.Controls.Add(this.terminal);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Log4CS";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox terminal;
        private System.Windows.Forms.Timer StartLogger;
    }
}

