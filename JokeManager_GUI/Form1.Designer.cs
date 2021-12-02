
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
            this.userLbl = new System.Windows.Forms.Label();
            this.jokeLbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // usernameTbx
            // 
            this.usernameTbx.Location = new System.Drawing.Point(12, 25);
            this.usernameTbx.Name = "usernameTbx";
            this.usernameTbx.Size = new System.Drawing.Size(100, 20);
            this.usernameTbx.TabIndex = 0;
            // 
            // JokeTbx
            // 
            this.JokeTbx.Location = new System.Drawing.Point(118, 25);
            this.JokeTbx.Name = "JokeTbx";
            this.JokeTbx.Size = new System.Drawing.Size(270, 20);
            this.JokeTbx.TabIndex = 1;
            // 
            // submitBtn
            // 
            this.submitBtn.BackColor = System.Drawing.Color.LightCoral;
            this.submitBtn.Location = new System.Drawing.Point(394, 23);
            this.submitBtn.Name = "submitBtn";
            this.submitBtn.Size = new System.Drawing.Size(75, 23);
            this.submitBtn.TabIndex = 2;
            this.submitBtn.Text = "Submit";
            this.submitBtn.UseVisualStyleBackColor = false;
            this.submitBtn.Click += new System.EventHandler(this.submitBtn_Click);
            // 
            // outputLbl
            // 
            this.outputLbl.AutoSize = true;
            this.outputLbl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.outputLbl.Location = new System.Drawing.Point(12, 48);
            this.outputLbl.Name = "outputLbl";
            this.outputLbl.Size = new System.Drawing.Size(86, 15);
            this.outputLbl.TabIndex = 3;
            this.outputLbl.Text = "database output";
            this.outputLbl.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // userLbl
            // 
            this.userLbl.AutoSize = true;
            this.userLbl.Location = new System.Drawing.Point(12, 9);
            this.userLbl.Name = "userLbl";
            this.userLbl.Size = new System.Drawing.Size(61, 13);
            this.userLbl.TabIndex = 4;
            this.userLbl.Text = "Enter UCID";
            // 
            // jokeLbl
            // 
            this.jokeLbl.AutoSize = true;
            this.jokeLbl.Location = new System.Drawing.Point(115, 9);
            this.jokeLbl.Name = "jokeLbl";
            this.jokeLbl.Size = new System.Drawing.Size(58, 13);
            this.jokeLbl.TabIndex = 5;
            this.jokeLbl.Text = "Enter Joke";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(480, 73);
            this.Controls.Add(this.jokeLbl);
            this.Controls.Add(this.userLbl);
            this.Controls.Add(this.outputLbl);
            this.Controls.Add(this.submitBtn);
            this.Controls.Add(this.JokeTbx);
            this.Controls.Add(this.usernameTbx);
            this.Name = "Form1";
            this.Text = "Joke Form";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox usernameTbx;
        private System.Windows.Forms.TextBox JokeTbx;
        private System.Windows.Forms.Button submitBtn;
        private System.Windows.Forms.Label outputLbl;
        private System.Windows.Forms.Label userLbl;
        private System.Windows.Forms.Label jokeLbl;
    }
}

