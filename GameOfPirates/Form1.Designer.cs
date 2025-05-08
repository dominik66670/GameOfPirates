namespace GameOfPirates
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
            components = new System.ComponentModel.Container();
            panel_first_page = new Panel();
            label_boat_players_profiles = new Label();
            panel_max_num_of_games = new Panel();
            label_num_of_runs = new Label();
            label_delta_competition = new Label();
            label_delta_games_statis = new Label();
            label_max_num_of_games = new Label();
            textBox_num_of_runs = new TextBox();
            textBox_delta_competition = new TextBox();
            textBox_delta_games_statis = new TextBox();
            textBox_max_num_of_games = new TextBox();
            panel_Network_of_boats = new Panel();
            textBox_num_of_cols_n = new TextBox();
            textBox_num_of_rows_m = new TextBox();
            textbox_num_of_boats_k = new TextBox();
            label_num_of_cols_n = new Label();
            label_num_of_rows_m = new Label();
            label_num_of_boats_k = new Label();
            label_network_of_boats = new Label();
            contextMenuStrip1 = new ContextMenuStrip(components);
            panel_first_page.SuspendLayout();
            panel_max_num_of_games.SuspendLayout();
            panel_Network_of_boats.SuspendLayout();
            SuspendLayout();
            // 
            // panel_first_page
            // 
            panel_first_page.Controls.Add(label_boat_players_profiles);
            panel_first_page.Controls.Add(panel_max_num_of_games);
            panel_first_page.Controls.Add(panel_Network_of_boats);
            panel_first_page.Controls.Add(label_network_of_boats);
            panel_first_page.Location = new Point(12, 12);
            panel_first_page.Name = "panel_first_page";
            panel_first_page.Size = new Size(1056, 522);
            panel_first_page.TabIndex = 0;
            // 
            // label_boat_players_profiles
            // 
            label_boat_players_profiles.AutoSize = true;
            label_boat_players_profiles.Location = new Point(20, 202);
            label_boat_players_profiles.Name = "label_boat_players_profiles";
            label_boat_players_profiles.Size = new Size(117, 15);
            label_boat_players_profiles.TabIndex = 2;
            label_boat_players_profiles.Text = "boat_players_profiles";
            // 
            // panel_max_num_of_games
            // 
            panel_max_num_of_games.BorderStyle = BorderStyle.FixedSingle;
            panel_max_num_of_games.Controls.Add(label_num_of_runs);
            panel_max_num_of_games.Controls.Add(label_delta_competition);
            panel_max_num_of_games.Controls.Add(label_delta_games_statis);
            panel_max_num_of_games.Controls.Add(label_max_num_of_games);
            panel_max_num_of_games.Controls.Add(textBox_num_of_runs);
            panel_max_num_of_games.Controls.Add(textBox_delta_competition);
            panel_max_num_of_games.Controls.Add(textBox_delta_games_statis);
            panel_max_num_of_games.Controls.Add(textBox_max_num_of_games);
            panel_max_num_of_games.Location = new Point(16, 105);
            panel_max_num_of_games.Name = "panel_max_num_of_games";
            panel_max_num_of_games.Size = new Size(193, 94);
            panel_max_num_of_games.TabIndex = 1;
            // 
            // label_num_of_runs
            // 
            label_num_of_runs.AutoSize = true;
            label_num_of_runs.Location = new Point(3, 66);
            label_num_of_runs.Name = "label_num_of_runs";
            label_num_of_runs.Size = new Size(76, 15);
            label_num_of_runs.TabIndex = 12;
            label_num_of_runs.Text = "num_of_runs";
            // 
            // label_delta_competition
            // 
            label_delta_competition.AutoSize = true;
            label_delta_competition.Location = new Point(3, 46);
            label_delta_competition.Name = "label_delta_competition";
            label_delta_competition.Size = new Size(103, 15);
            label_delta_competition.TabIndex = 11;
            label_delta_competition.Text = "delta_competition";
            // 
            // label_delta_games_statis
            // 
            label_delta_games_statis.AutoSize = true;
            label_delta_games_statis.Location = new Point(3, 26);
            label_delta_games_statis.Name = "label_delta_games_statis";
            label_delta_games_statis.Size = new Size(105, 15);
            label_delta_games_statis.TabIndex = 10;
            label_delta_games_statis.Text = "delta_games_statis";
            // 
            // label_max_num_of_games
            // 
            label_max_num_of_games.AutoSize = true;
            label_max_num_of_games.Location = new Point(3, 5);
            label_max_num_of_games.Name = "label_max_num_of_games";
            label_max_num_of_games.Size = new Size(115, 15);
            label_max_num_of_games.TabIndex = 9;
            label_max_num_of_games.Text = "max_num_of_games";
            // 
            // textBox_num_of_runs
            // 
            textBox_num_of_runs.BorderStyle = BorderStyle.FixedSingle;
            textBox_num_of_runs.Location = new Point(124, 64);
            textBox_num_of_runs.Name = "textBox_num_of_runs";
            textBox_num_of_runs.Size = new Size(49, 23);
            textBox_num_of_runs.TabIndex = 8;
            textBox_num_of_runs.Text = "1";
            textBox_num_of_runs.TextAlign = HorizontalAlignment.Center;
            // 
            // textBox_delta_competition
            // 
            textBox_delta_competition.BorderStyle = BorderStyle.FixedSingle;
            textBox_delta_competition.Location = new Point(124, 44);
            textBox_delta_competition.Name = "textBox_delta_competition";
            textBox_delta_competition.Size = new Size(49, 23);
            textBox_delta_competition.TabIndex = 7;
            textBox_delta_competition.Text = "10";
            textBox_delta_competition.TextAlign = HorizontalAlignment.Center;
            // 
            // textBox_delta_games_statis
            // 
            textBox_delta_games_statis.BorderStyle = BorderStyle.FixedSingle;
            textBox_delta_games_statis.Location = new Point(124, 24);
            textBox_delta_games_statis.Name = "textBox_delta_games_statis";
            textBox_delta_games_statis.Size = new Size(49, 23);
            textBox_delta_games_statis.TabIndex = 6;
            textBox_delta_games_statis.Text = "1";
            textBox_delta_games_statis.TextAlign = HorizontalAlignment.Center;
            // 
            // textBox_max_num_of_games
            // 
            textBox_max_num_of_games.BorderStyle = BorderStyle.FixedSingle;
            textBox_max_num_of_games.Location = new Point(124, 3);
            textBox_max_num_of_games.Name = "textBox_max_num_of_games";
            textBox_max_num_of_games.Size = new Size(49, 23);
            textBox_max_num_of_games.TabIndex = 5;
            textBox_max_num_of_games.Text = "10";
            textBox_max_num_of_games.TextAlign = HorizontalAlignment.Center;
            // 
            // panel_Network_of_boats
            // 
            panel_Network_of_boats.BackColor = Color.Transparent;
            panel_Network_of_boats.BorderStyle = BorderStyle.FixedSingle;
            panel_Network_of_boats.Controls.Add(textBox_num_of_cols_n);
            panel_Network_of_boats.Controls.Add(textBox_num_of_rows_m);
            panel_Network_of_boats.Controls.Add(textbox_num_of_boats_k);
            panel_Network_of_boats.Controls.Add(label_num_of_cols_n);
            panel_Network_of_boats.Controls.Add(label_num_of_rows_m);
            panel_Network_of_boats.Controls.Add(label_num_of_boats_k);
            panel_Network_of_boats.Location = new Point(16, 25);
            panel_Network_of_boats.Name = "panel_Network_of_boats";
            panel_Network_of_boats.Size = new Size(193, 74);
            panel_Network_of_boats.TabIndex = 0;
            // 
            // textBox_num_of_cols_n
            // 
            textBox_num_of_cols_n.BorderStyle = BorderStyle.FixedSingle;
            textBox_num_of_cols_n.Location = new Point(124, 45);
            textBox_num_of_cols_n.Name = "textBox_num_of_cols_n";
            textBox_num_of_cols_n.Size = new Size(49, 23);
            textBox_num_of_cols_n.TabIndex = 6;
            textBox_num_of_cols_n.Text = "3";
            textBox_num_of_cols_n.TextAlign = HorizontalAlignment.Center;
            // 
            // textBox_num_of_rows_m
            // 
            textBox_num_of_rows_m.BorderStyle = BorderStyle.FixedSingle;
            textBox_num_of_rows_m.Location = new Point(124, 25);
            textBox_num_of_rows_m.Name = "textBox_num_of_rows_m";
            textBox_num_of_rows_m.Size = new Size(49, 23);
            textBox_num_of_rows_m.TabIndex = 5;
            textBox_num_of_rows_m.Text = "4";
            textBox_num_of_rows_m.TextAlign = HorizontalAlignment.Center;
            // 
            // textbox_num_of_boats_k
            // 
            textbox_num_of_boats_k.BorderStyle = BorderStyle.FixedSingle;
            textbox_num_of_boats_k.Location = new Point(124, 4);
            textbox_num_of_boats_k.Name = "textbox_num_of_boats_k";
            textbox_num_of_boats_k.Size = new Size(49, 23);
            textbox_num_of_boats_k.TabIndex = 4;
            textbox_num_of_boats_k.Text = "12";
            textbox_num_of_boats_k.TextAlign = HorizontalAlignment.Center;
            // 
            // label_num_of_cols_n
            // 
            label_num_of_cols_n.AutoSize = true;
            label_num_of_cols_n.Location = new Point(3, 47);
            label_num_of_cols_n.Name = "label_num_of_cols_n";
            label_num_of_cols_n.Size = new Size(86, 15);
            label_num_of_cols_n.TabIndex = 3;
            label_num_of_cols_n.Text = "num_of_cols N";
            // 
            // label_num_of_rows_m
            // 
            label_num_of_rows_m.AutoSize = true;
            label_num_of_rows_m.Location = new Point(3, 27);
            label_num_of_rows_m.Name = "label_num_of_rows_m";
            label_num_of_rows_m.Size = new Size(92, 15);
            label_num_of_rows_m.TabIndex = 2;
            label_num_of_rows_m.Text = "num_of_rows M";
            // 
            // label_num_of_boats_k
            // 
            label_num_of_boats_k.AutoSize = true;
            label_num_of_boats_k.Location = new Point(3, 6);
            label_num_of_boats_k.Name = "label_num_of_boats_k";
            label_num_of_boats_k.Size = new Size(92, 15);
            label_num_of_boats_k.TabIndex = 1;
            label_num_of_boats_k.Text = "num_of_boats K";
            // 
            // label_network_of_boats
            // 
            label_network_of_boats.AutoSize = true;
            label_network_of_boats.Location = new Point(20, 7);
            label_network_of_boats.Name = "label_network_of_boats";
            label_network_of_boats.Size = new Size(98, 15);
            label_network_of_boats.TabIndex = 0;
            label_network_of_boats.Text = "Network of boats";
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(61, 4);
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1080, 546);
            Controls.Add(panel_first_page);
            Name = "Form1";
            Text = "Game of pirates V 1.0";
            panel_first_page.ResumeLayout(false);
            panel_first_page.PerformLayout();
            panel_max_num_of_games.ResumeLayout(false);
            panel_max_num_of_games.PerformLayout();
            panel_Network_of_boats.ResumeLayout(false);
            panel_Network_of_boats.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel_first_page;
        private Panel panel_Network_of_boats;
        private Label label_network_of_boats;
        private Label label_num_of_cols_n;
        private Label label_num_of_rows_m;
        private Label label_num_of_boats_k;
        private TextBox textBox_num_of_rows_m;
        private TextBox textbox_num_of_boats_k;
        private TextBox textBox_num_of_cols_n;
        private Panel panel_max_num_of_games;
        private TextBox textBox_max_num_of_games;
        private ContextMenuStrip contextMenuStrip1;
        private Label label_num_of_runs;
        private Label label_delta_competition;
        private Label label_delta_games_statis;
        private Label label_max_num_of_games;
        private TextBox textBox_num_of_runs;
        private TextBox textBox_delta_competition;
        private TextBox textBox_delta_games_statis;
        private Label label_boat_players_profiles;
    }
}
