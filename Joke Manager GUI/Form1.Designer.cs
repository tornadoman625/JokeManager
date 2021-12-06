namespace Joke_Manager
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
            this.textbox_UCID = new System.Windows.Forms.TextBox();
            this.UCID = new System.Windows.Forms.Label();
            this.Joke = new System.Windows.Forms.Label();
            this.textbox_Joke = new System.Windows.Forms.TextBox();
            this.submit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textbox_UCID
            // 
            this.textbox_UCID.Location = new System.Drawing.Point(22, 37);
            this.textbox_UCID.Name = "textbox_UCID";
            this.textbox_UCID.Size = new System.Drawing.Size(279, 20);
            this.textbox_UCID.TabIndex = 0;
            // 
            // UCID
            // 
            this.UCID.AutoSize = true;
            this.UCID.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UCID.Location = new System.Drawing.Point(137, 9);
            this.UCID.Name = "UCID";
            this.UCID.Size = new System.Drawing.Size(62, 25);
            this.UCID.TabIndex = 1;
            this.UCID.Text = "UCID";
            this.UCID.Click += new System.EventHandler(this.label1_Click);
            // 
            // Joke
            // 
            this.Joke.AutoSize = true;
            this.Joke.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Joke.Location = new System.Drawing.Point(137, 97);
            this.Joke.Name = "Joke";
            this.Joke.Size = new System.Drawing.Size(58, 25);
            this.Joke.TabIndex = 2;
            this.Joke.Text = "Joke";
            // 
            // textbox_Joke
            // 
            this.textbox_Joke.Location = new System.Drawing.Point(22, 125);
            this.textbox_Joke.Name = "textbox_Joke";
            this.textbox_Joke.Size = new System.Drawing.Size(279, 20);
            this.textbox_Joke.TabIndex = 3;
            // 
            // submit
            // 
            this.submit.Font = new System.Drawing.Font("Comic Sans MS", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.submit.Location = new System.Drawing.Point(22, 173);
            this.submit.Name = "submit";
            this.submit.Size = new System.Drawing.Size(279, 80);
            this.submit.TabIndex = 4;
            this.submit.Text = "Submit Funny Joke";
            this.submit.UseVisualStyleBackColor = true;
            this.submit.Click += new System.EventHandler(this.submit_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(331, 287);
            this.Controls.Add(this.submit);
            this.Controls.Add(this.textbox_Joke);
            this.Controls.Add(this.Joke);
            this.Controls.Add(this.UCID);
            this.Controls.Add(this.textbox_UCID);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textbox_UCID;
        private System.Windows.Forms.Label UCID;
        private System.Windows.Forms.Label Joke;
        private System.Windows.Forms.TextBox textbox_Joke;
        private System.Windows.Forms.Button submit;
    }
}

