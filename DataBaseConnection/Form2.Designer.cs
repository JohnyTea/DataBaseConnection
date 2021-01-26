namespace DataBaseConnection
{
    partial class FilmyAktorzyForm
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
            this.FilmyAktorzy_ListBox = new System.Windows.Forms.ListBox();
            this.deleta_all_button = new System.Windows.Forms.Button();
            this.add_Actor_button = new System.Windows.Forms.Button();
            this.Add_Many_Actors_Button = new System.Windows.Forms.Button();
            this.delete_Actor_Button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // FilmyAktorzy_ListBox
            // 
            this.FilmyAktorzy_ListBox.FormattingEnabled = true;
            this.FilmyAktorzy_ListBox.Location = new System.Drawing.Point(12, 12);
            this.FilmyAktorzy_ListBox.Name = "FilmyAktorzy_ListBox";
            this.FilmyAktorzy_ListBox.Size = new System.Drawing.Size(120, 420);
            this.FilmyAktorzy_ListBox.TabIndex = 0;
            // 
            // deleta_all_button
            // 
            this.deleta_all_button.Location = new System.Drawing.Point(139, 12);
            this.deleta_all_button.Name = "deleta_all_button";
            this.deleta_all_button.Size = new System.Drawing.Size(110, 23);
            this.deleta_all_button.TabIndex = 1;
            this.deleta_all_button.Text = "Usuń Wszystkich";
            this.deleta_all_button.UseVisualStyleBackColor = true;
            // 
            // add_Actor_button
            // 
            this.add_Actor_button.Location = new System.Drawing.Point(138, 70);
            this.add_Actor_button.Name = "add_Actor_button";
            this.add_Actor_button.Size = new System.Drawing.Size(110, 23);
            this.add_Actor_button.TabIndex = 2;
            this.add_Actor_button.Text = "Dodaj Aktora";
            this.add_Actor_button.UseVisualStyleBackColor = true;
            this.add_Actor_button.Click += new System.EventHandler(this.add_Actor_button_Click);
            // 
            // Add_Many_Actors_Button
            // 
            this.Add_Many_Actors_Button.Location = new System.Drawing.Point(138, 99);
            this.Add_Many_Actors_Button.Name = "Add_Many_Actors_Button";
            this.Add_Many_Actors_Button.Size = new System.Drawing.Size(110, 23);
            this.Add_Many_Actors_Button.TabIndex = 3;
            this.Add_Many_Actors_Button.Text = "Dodaj Aktorów";
            this.Add_Many_Actors_Button.UseVisualStyleBackColor = true;
            // 
            // delete_Actor_Button
            // 
            this.delete_Actor_Button.Location = new System.Drawing.Point(139, 41);
            this.delete_Actor_Button.Name = "delete_Actor_Button";
            this.delete_Actor_Button.Size = new System.Drawing.Size(109, 23);
            this.delete_Actor_Button.TabIndex = 4;
            this.delete_Actor_Button.Text = "Usuń aktora";
            this.delete_Actor_Button.UseVisualStyleBackColor = true;
            // 
            // FilmyAktorzyForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(295, 450);
            this.Controls.Add(this.delete_Actor_Button);
            this.Controls.Add(this.Add_Many_Actors_Button);
            this.Controls.Add(this.add_Actor_button);
            this.Controls.Add(this.deleta_all_button);
            this.Controls.Add(this.FilmyAktorzy_ListBox);
            this.Name = "FilmyAktorzyForm";
            this.Text = "Aktorzy Grający w Filmie";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox FilmyAktorzy_ListBox;
        private System.Windows.Forms.Button deleta_all_button;
        private System.Windows.Forms.Button add_Actor_button;
        private System.Windows.Forms.Button Add_Many_Actors_Button;
        private System.Windows.Forms.Button delete_Actor_Button;
    }
}