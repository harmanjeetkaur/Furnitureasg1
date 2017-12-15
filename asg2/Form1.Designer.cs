namespace asg2
{
    partial class btnloop
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
            this.btnloop1 = new System.Windows.Forms.Button();
            this.lblmessage1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnloop1
            // 
            this.btnloop1.Location = new System.Drawing.Point(56, 38);
            this.btnloop1.Name = "btnloop1";
            this.btnloop1.Size = new System.Drawing.Size(93, 29);
            this.btnloop1.TabIndex = 0;
            this.btnloop1.Text = "loop1";
            this.btnloop1.UseVisualStyleBackColor = true;
            this.btnloop1.Click += new System.EventHandler(this.btnloop1_Click);
            // 
            // lblmessage1
            // 
            this.lblmessage1.AutoSize = true;
            this.lblmessage1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblmessage1.Location = new System.Drawing.Point(53, 79);
            this.lblmessage1.Name = "lblmessage1";
            this.lblmessage1.Size = new System.Drawing.Size(222, 17);
            this.lblmessage1.TabIndex = 1;
            this.lblmessage1.Text = " click the button to run a loop";
            // 
            // btnloop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(873, 407);
            this.Controls.Add(this.lblmessage1);
            this.Controls.Add(this.btnloop1);
            this.Name = "btnloop";
            this.Text = "loop1";
            this.Load += new System.EventHandler(this.btnloop_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnloop1;
        private System.Windows.Forms.Label lblmessage1;
    }
}

