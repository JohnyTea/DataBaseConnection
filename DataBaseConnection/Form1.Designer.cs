namespace DataBaseConnection
{
    partial class Form1
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.Connect_Button = new System.Windows.Forms.Button();
            this.movie_listBox = new System.Windows.Forms.ListBox();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.add_movie_button = new System.Windows.Forms.Button();
            this.delete_movie_button = new System.Windows.Forms.Button();
            this.show_actors_button = new System.Windows.Forms.Button();
            this.add_actor = new System.Windows.Forms.Button();
            this.delete_actor_button = new System.Windows.Forms.Button();
            this.exit_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Connect_Button
            // 
            this.Connect_Button.Location = new System.Drawing.Point(12, 234);
            this.Connect_Button.Name = "Connect_Button";
            this.Connect_Button.Size = new System.Drawing.Size(75, 23);
            this.Connect_Button.TabIndex = 0;
            this.Connect_Button.Text = "Zaktualizuj Listę";
            this.Connect_Button.UseVisualStyleBackColor = true;
            this.Connect_Button.Click += new System.EventHandler(this.Update_List_button_Click);
            // 
            // movie_listBox
            // 
            this.movie_listBox.FormattingEnabled = true;
            this.movie_listBox.Location = new System.Drawing.Point(12, 12);
            this.movie_listBox.Name = "movie_listBox";
            this.movie_listBox.Size = new System.Drawing.Size(776, 186);
            this.movie_listBox.TabIndex = 1;
            // 
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;
            this.listBox2.Location = new System.Drawing.Point(682, 200);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(106, 238);
            this.listBox2.TabIndex = 1;
            // 
            // add_movie_button
            // 
            this.add_movie_button.Location = new System.Drawing.Point(12, 205);
            this.add_movie_button.Name = "add_movie_button";
            this.add_movie_button.Size = new System.Drawing.Size(75, 23);
            this.add_movie_button.TabIndex = 2;
            this.add_movie_button.Text = "Dodaj Film";
            this.add_movie_button.UseVisualStyleBackColor = true;
            this.add_movie_button.Click += new System.EventHandler(this.add_movie_button_Click);
            // 
            // delete_movie_button
            // 
            this.delete_movie_button.Location = new System.Drawing.Point(93, 205);
            this.delete_movie_button.Name = "delete_movie_button";
            this.delete_movie_button.Size = new System.Drawing.Size(75, 23);
            this.delete_movie_button.TabIndex = 3;
            this.delete_movie_button.Text = "Usuń Film";
            this.delete_movie_button.UseVisualStyleBackColor = true;
            this.delete_movie_button.Click += new System.EventHandler(this.delete_movie_button_Click);
            // 
            // show_actors_button
            // 
            this.show_actors_button.Location = new System.Drawing.Point(174, 205);
            this.show_actors_button.Name = "show_actors_button";
            this.show_actors_button.Size = new System.Drawing.Size(75, 23);
            this.show_actors_button.TabIndex = 4;
            this.show_actors_button.Text = "Pokaż Aktorów";
            this.show_actors_button.UseVisualStyleBackColor = true;
            this.show_actors_button.Click += new System.EventHandler(this.show_actors_button_Click);
            // 
            // add_actor
            // 
            this.add_actor.Location = new System.Drawing.Point(601, 204);
            this.add_actor.Name = "add_actor";
            this.add_actor.Size = new System.Drawing.Size(75, 23);
            this.add_actor.TabIndex = 5;
            this.add_actor.Text = "Dodaj Aktora";
            this.add_actor.UseVisualStyleBackColor = true;
            // 
            // delete_actor_button
            // 
            this.delete_actor_button.Location = new System.Drawing.Point(601, 233);
            this.delete_actor_button.Name = "delete_actor_button";
            this.delete_actor_button.Size = new System.Drawing.Size(75, 23);
            this.delete_actor_button.TabIndex = 6;
            this.delete_actor_button.Text = "Usuń Aktora";
            this.delete_actor_button.UseVisualStyleBackColor = true;
            // 
            // exit_button
            // 
            this.exit_button.Location = new System.Drawing.Point(12, 394);
            this.exit_button.Name = "exit_button";
            this.exit_button.Size = new System.Drawing.Size(97, 44);
            this.exit_button.TabIndex = 7;
            this.exit_button.Text = "Wyjście";
            this.exit_button.UseVisualStyleBackColor = true;
            this.exit_button.Click += new System.EventHandler(this.exit_button_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.exit_button);
            this.Controls.Add(this.delete_actor_button);
            this.Controls.Add(this.add_actor);
            this.Controls.Add(this.show_actors_button);
            this.Controls.Add(this.delete_movie_button);
            this.Controls.Add(this.add_movie_button);
            this.Controls.Add(this.listBox2);
            this.Controls.Add(this.movie_listBox);
            this.Controls.Add(this.Connect_Button);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Connect_Button;
        private System.Windows.Forms.ListBox movie_listBox;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.Button add_movie_button;
        private System.Windows.Forms.Button delete_movie_button;
        private System.Windows.Forms.Button show_actors_button;
        private System.Windows.Forms.Button add_actor;
        private System.Windows.Forms.Button delete_actor_button;
        private System.Windows.Forms.Button exit_button;
    }
}

