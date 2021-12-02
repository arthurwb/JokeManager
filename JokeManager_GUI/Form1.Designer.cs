
namespace JokeManager_GUI
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
            this.usernameTbx = new System.Windows.Forms.TextBox();
            this.JokeTbx = new System.Windows.Forms.TextBox();
            this.submitBtn = new System.Windows.Forms.Button();
            this.outputLbl = new System.Windows.Forms.Label();
            this.databaseOutputLbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // usernameTbx
            // 
            this.usernameTbx.Location = new System.Drawing.Point(304, 155);
            this.usernameTbx.Name = "usernameTbx";
            this.usernameTbx.Size = new System.Drawing.Size(100, 20);
            this.usernameTbx.TabIndex = 0;
            this.usernameTbx.Text = "Enter UCID";
            // 
            // JokeTbx
            // 
            this.JokeTbx.Location = new System.Drawing.Point(491, 155);
            this.JokeTbx.Name = "JokeTbx";
            this.JokeTbx.Size = new System.Drawing.Size(100, 20);
            this.JokeTbx.TabIndex = 1;
            this.JokeTbx.Text = "Enter Joke";
            // 
            // submitBtn
            // 
            this.submitBtn.Location = new System.Drawing.Point(410, 181);
            this.submitBtn.Name = "submitBtn";
            this.submitBtn.Size = new System.Drawing.Size(75, 23);
            this.submitBtn.TabIndex = 2;
            this.submitBtn.Text = "Submit";
            this.submitBtn.UseVisualStyleBackColor = true;
            this.submitBtn.Click += new System.EventHandler(this.submitBtn_Click);
            // 
            // outputLbl
            // 
            this.outputLbl.AutoSize = true;
            this.outputLbl.Location = new System.Drawing.Point(407, 239);
            this.outputLbl.Name = "outputLbl";
            this.outputLbl.Size = new System.Drawing.Size(84, 13);
            this.outputLbl.TabIndex = 3;
            this.outputLbl.Text = "database output";
            // 
            // databaseOutputLbl
            // 
            this.databaseOutputLbl.AutoSize = true;
            this.databaseOutputLbl.Location = new System.Drawing.Point(41, 45);
            this.databaseOutputLbl.Name = "databaseOutputLbl";
            this.databaseOutputLbl.Size = new System.Drawing.Size(84, 13);
            this.databaseOutputLbl.TabIndex = 4;
            this.databaseOutputLbl.Text = "database output";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.databaseOutputLbl);
            this.Controls.Add(this.outputLbl);
            this.Controls.Add(this.submitBtn);
            this.Controls.Add(this.JokeTbx);
            this.Controls.Add(this.usernameTbx);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox usernameTbx;
        private System.Windows.Forms.TextBox JokeTbx;
        private System.Windows.Forms.Button submitBtn;
        private System.Windows.Forms.Label outputLbl;
        private System.Windows.Forms.Label databaseOutputLbl;
    }
}

