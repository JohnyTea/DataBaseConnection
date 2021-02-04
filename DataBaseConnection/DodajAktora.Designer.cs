namespace DataBaseConnection
{
    partial class DodajAktora
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
            this.add_button = new System.Windows.Forms.Button();
            this.actor_name_textBox = new System.Windows.Forms.TextBox();
            this.cancel_button = new System.Windows.Forms.Button();
            this.actor_lastName_textBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // add_button
            // 
            this.add_button.Location = new System.Drawing.Point(10, 64);
            this.add_button.Name = "add_button";
            this.add_button.Size = new System.Drawing.Size(75, 23);
            this.add_button.TabIndex = 0;
            this.add_button.Text = "Dodaj";
            this.add_button.UseVisualStyleBackColor = true;
            this.add_button.Click += new System.EventHandler(this.add_button_Click);
            // 
            // actor_name_textBox
            // 
            this.actor_name_textBox.Location = new System.Drawing.Point(12, 12);
            this.actor_name_textBox.Name = "actor_name_textBox";
            this.actor_name_textBox.Size = new System.Drawing.Size(100, 20);
            this.actor_name_textBox.TabIndex = 1;
            // 
            // cancel_button
            // 
            this.cancel_button.Location = new System.Drawing.Point(91, 64);
            this.cancel_button.Name = "cancel_button";
            this.cancel_button.Size = new System.Drawing.Size(75, 23);
            this.cancel_button.TabIndex = 2;
            this.cancel_button.Text = "Anuluj";
            this.cancel_button.UseVisualStyleBackColor = true;
            this.cancel_button.Click += new System.EventHandler(this.cancel_button_Click);
            // 
            // actor_lastName_textBox
            // 
            this.actor_lastName_textBox.Location = new System.Drawing.Point(12, 38);
            this.actor_lastName_textBox.Name = "actor_lastName_textBox";
            this.actor_lastName_textBox.Size = new System.Drawing.Size(100, 20);
            this.actor_lastName_textBox.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(118, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Imię";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(118, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Nazwisko";
            // 
            // DodajAktora
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(178, 93);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.actor_lastName_textBox);
            this.Controls.Add(this.cancel_button);
            this.Controls.Add(this.actor_name_textBox);
            this.Controls.Add(this.add_button);
            this.Name = "DodajAktora";
            this.Text = "DodajAktora";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button add_button;
        private System.Windows.Forms.TextBox actor_name_textBox;
        private System.Windows.Forms.Button cancel_button;
        private System.Windows.Forms.TextBox actor_lastName_textBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}