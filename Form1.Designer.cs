
namespace APIreq
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
            this.reqButton = new System.Windows.Forms.Button();
            this.outputTextbox = new System.Windows.Forms.TextBox();
            this.exportButton = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // reqButton
            // 
            this.reqButton.Location = new System.Drawing.Point(12, 12);
            this.reqButton.Name = "reqButton";
            this.reqButton.Size = new System.Drawing.Size(130, 52);
            this.reqButton.TabIndex = 0;
            this.reqButton.Text = "REQUEST";
            this.reqButton.UseVisualStyleBackColor = true;
            this.reqButton.Click += new System.EventHandler(this.reqButton_Click);
            // 
            // outputTextbox
            // 
            this.outputTextbox.Location = new System.Drawing.Point(12, 85);
            this.outputTextbox.Multiline = true;
            this.outputTextbox.Name = "outputTextbox";
            this.outputTextbox.ReadOnly = true;
            this.outputTextbox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.outputTextbox.Size = new System.Drawing.Size(561, 342);
            this.outputTextbox.TabIndex = 1;
            this.outputTextbox.TextChanged += new System.EventHandler(this.outputTextbox_TextChanged);
            // 
            // exportButton
            // 
            this.exportButton.Location = new System.Drawing.Point(284, 12);
            this.exportButton.Name = "exportButton";
            this.exportButton.Size = new System.Drawing.Size(130, 52);
            this.exportButton.TabIndex = 2;
            this.exportButton.Text = "EXPORT";
            this.exportButton.UseVisualStyleBackColor = true;
            this.exportButton.Click += new System.EventHandler(this.exportButton_Click);
            // 
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(148, 12);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(130, 52);
            this.clearButton.TabIndex = 3;
            this.clearButton.Text = "CLEAR";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(585, 439);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.exportButton);
            this.Controls.Add(this.outputTextbox);
            this.Controls.Add(this.reqButton);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button reqButton;
        private System.Windows.Forms.TextBox outputTextbox;
        private System.Windows.Forms.Button exportButton;
        private System.Windows.Forms.Button clearButton;
    }
}

