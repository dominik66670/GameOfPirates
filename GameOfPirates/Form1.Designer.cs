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
            label_competition_type = new Label();
            panel_competition_type = new Panel();
            radioButton_competition_type_invasion = new RadioButton();
            radioButton_competition_type_roulette = new RadioButton();
            radioButton_competition_name_tournament = new RadioButton();
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
            panel_boat_players_profile = new Panel();
            label_1 = new Label();
            textBox_B_player_profile_1_1 = new TextBox();
            label_B_player_1 = new Label();
            textBox_B_player_profile_1_2 = new TextBox();
            textBox_B_player_profile_1_3 = new TextBox();
            label1 = new Label();
            label2 = new Label();
            textBox_B_player_profile_1_prob = new TextBox();
            label3 = new Label();
            textBox_B_player_profile_2_prob = new TextBox();
            textBox_B_player_profile_2_3 = new TextBox();
            textBox_B_player_profile_2_2 = new TextBox();
            textBox_B_player_profile_2_1 = new TextBox();
            textBox_B_player_profile_3_prob = new TextBox();
            textBox_B_player_profile_3_3 = new TextBox();
            textBox_B_player_profile_3_2 = new TextBox();
            textBox_B_player_profile_3_1 = new TextBox();
            textBox_B_player_profile_4_prob = new TextBox();
            textBox_B_player_profile_4_3 = new TextBox();
            textBox_B_player_profile_4_2 = new TextBox();
            textBox_B_player_profile_4_1 = new TextBox();
            textBox_B_player_profile_5_prob = new TextBox();
            textBox_B_player_profile_5_3 = new TextBox();
            textBox_B_player_profile_5_2 = new TextBox();
            textBox_B_player_profile_5_1 = new TextBox();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            panel_first_page.SuspendLayout();
            panel_competition_type.SuspendLayout();
            panel_max_num_of_games.SuspendLayout();
            panel_Network_of_boats.SuspendLayout();
            panel_boat_players_profile.SuspendLayout();
            SuspendLayout();
            // 
            // panel_first_page
            // 
            panel_first_page.Controls.Add(panel_boat_players_profile);
            panel_first_page.Controls.Add(label_competition_type);
            panel_first_page.Controls.Add(panel_competition_type);
            panel_first_page.Controls.Add(label_boat_players_profiles);
            panel_first_page.Controls.Add(panel_max_num_of_games);
            panel_first_page.Controls.Add(panel_Network_of_boats);
            panel_first_page.Controls.Add(label_network_of_boats);
            panel_first_page.Location = new Point(12, 12);
            panel_first_page.Name = "panel_first_page";
            panel_first_page.Size = new Size(1056, 522);
            panel_first_page.TabIndex = 0;
            // 
            // label_competition_type
            // 
            label_competition_type.AutoSize = true;
            label_competition_type.Location = new Point(16, 202);
            label_competition_type.Name = "label_competition_type";
            label_competition_type.Size = new Size(98, 15);
            label_competition_type.TabIndex = 4;
            label_competition_type.Text = "competition type";
            // 
            // panel_competition_type
            // 
            panel_competition_type.BorderStyle = BorderStyle.FixedSingle;
            panel_competition_type.Controls.Add(radioButton_competition_type_invasion);
            panel_competition_type.Controls.Add(radioButton_competition_type_roulette);
            panel_competition_type.Controls.Add(radioButton_competition_name_tournament);
            panel_competition_type.Location = new Point(16, 220);
            panel_competition_type.Name = "panel_competition_type";
            panel_competition_type.Size = new Size(193, 76);
            panel_competition_type.TabIndex = 3;
            // 
            // radioButton_competition_type_invasion
            // 
            radioButton_competition_type_invasion.AutoSize = true;
            radioButton_competition_type_invasion.Location = new Point(3, 53);
            radioButton_competition_type_invasion.Name = "radioButton_competition_type_invasion";
            radioButton_competition_type_invasion.Size = new Size(69, 19);
            radioButton_competition_type_invasion.TabIndex = 2;
            radioButton_competition_type_invasion.Text = "invasion";
            radioButton_competition_type_invasion.UseVisualStyleBackColor = true;
            // 
            // radioButton_competition_type_roulette
            // 
            radioButton_competition_type_roulette.AutoSize = true;
            radioButton_competition_type_roulette.Location = new Point(3, 28);
            radioButton_competition_type_roulette.Name = "radioButton_competition_type_roulette";
            radioButton_competition_type_roulette.Size = new Size(66, 19);
            radioButton_competition_type_roulette.TabIndex = 1;
            radioButton_competition_type_roulette.Text = "roulette";
            radioButton_competition_type_roulette.UseVisualStyleBackColor = true;
            // 
            // radioButton_competition_name_tournament
            // 
            radioButton_competition_name_tournament.AutoSize = true;
            radioButton_competition_name_tournament.Checked = true;
            radioButton_competition_name_tournament.Location = new Point(3, 3);
            radioButton_competition_name_tournament.Name = "radioButton_competition_name_tournament";
            radioButton_competition_name_tournament.Size = new Size(88, 19);
            radioButton_competition_name_tournament.TabIndex = 0;
            radioButton_competition_name_tournament.TabStop = true;
            radioButton_competition_name_tournament.Text = "tournament";
            radioButton_competition_name_tournament.UseVisualStyleBackColor = true;
            // 
            // label_boat_players_profiles
            // 
            label_boat_players_profiles.AutoSize = true;
            label_boat_players_profiles.Location = new Point(16, 299);
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
            // panel_boat_players_profile
            // 
            panel_boat_players_profile.BorderStyle = BorderStyle.FixedSingle;
            panel_boat_players_profile.Controls.Add(label7);
            panel_boat_players_profile.Controls.Add(label6);
            panel_boat_players_profile.Controls.Add(label5);
            panel_boat_players_profile.Controls.Add(label4);
            panel_boat_players_profile.Controls.Add(textBox_B_player_profile_5_prob);
            panel_boat_players_profile.Controls.Add(textBox_B_player_profile_5_3);
            panel_boat_players_profile.Controls.Add(textBox_B_player_profile_5_2);
            panel_boat_players_profile.Controls.Add(textBox_B_player_profile_5_1);
            panel_boat_players_profile.Controls.Add(textBox_B_player_profile_4_prob);
            panel_boat_players_profile.Controls.Add(textBox_B_player_profile_4_3);
            panel_boat_players_profile.Controls.Add(textBox_B_player_profile_4_2);
            panel_boat_players_profile.Controls.Add(textBox_B_player_profile_4_1);
            panel_boat_players_profile.Controls.Add(textBox_B_player_profile_3_prob);
            panel_boat_players_profile.Controls.Add(textBox_B_player_profile_3_3);
            panel_boat_players_profile.Controls.Add(textBox_B_player_profile_3_2);
            panel_boat_players_profile.Controls.Add(textBox_B_player_profile_3_1);
            panel_boat_players_profile.Controls.Add(textBox_B_player_profile_2_prob);
            panel_boat_players_profile.Controls.Add(textBox_B_player_profile_2_3);
            panel_boat_players_profile.Controls.Add(textBox_B_player_profile_2_2);
            panel_boat_players_profile.Controls.Add(textBox_B_player_profile_2_1);
            panel_boat_players_profile.Controls.Add(label3);
            panel_boat_players_profile.Controls.Add(textBox_B_player_profile_1_prob);
            panel_boat_players_profile.Controls.Add(label2);
            panel_boat_players_profile.Controls.Add(label1);
            panel_boat_players_profile.Controls.Add(textBox_B_player_profile_1_3);
            panel_boat_players_profile.Controls.Add(textBox_B_player_profile_1_2);
            panel_boat_players_profile.Controls.Add(label_B_player_1);
            panel_boat_players_profile.Controls.Add(textBox_B_player_profile_1_1);
            panel_boat_players_profile.Controls.Add(label_1);
            panel_boat_players_profile.Location = new Point(16, 317);
            panel_boat_players_profile.Name = "panel_boat_players_profile";
            panel_boat_players_profile.Size = new Size(261, 169);
            panel_boat_players_profile.TabIndex = 5;
            // 
            // label_1
            // 
            label_1.AutoSize = true;
            label_1.Location = new Point(69, 1);
            label_1.Name = "label_1";
            label_1.Size = new Size(13, 15);
            label_1.TabIndex = 0;
            label_1.Text = "1";
            // 
            // textBox_B_player_profile_1_1
            // 
            textBox_B_player_profile_1_1.BorderStyle = BorderStyle.FixedSingle;
            textBox_B_player_profile_1_1.Location = new Point(60, 19);
            textBox_B_player_profile_1_1.Name = "textBox_B_player_profile_1_1";
            textBox_B_player_profile_1_1.Size = new Size(31, 23);
            textBox_B_player_profile_1_1.TabIndex = 1;
            textBox_B_player_profile_1_1.Text = "1";
            textBox_B_player_profile_1_1.TextAlign = HorizontalAlignment.Center;
            // 
            // label_B_player_1
            // 
            label_B_player_1.AutoSize = true;
            label_B_player_1.Location = new Point(3, 21);
            label_B_player_1.Name = "label_B_player_1";
            label_B_player_1.Size = new Size(51, 15);
            label_B_player_1.TabIndex = 2;
            label_B_player_1.Text = "B_pref_1";
            // 
            // textBox_B_player_profile_1_2
            // 
            textBox_B_player_profile_1_2.BorderStyle = BorderStyle.FixedSingle;
            textBox_B_player_profile_1_2.Location = new Point(97, 19);
            textBox_B_player_profile_1_2.Name = "textBox_B_player_profile_1_2";
            textBox_B_player_profile_1_2.Size = new Size(31, 23);
            textBox_B_player_profile_1_2.TabIndex = 3;
            textBox_B_player_profile_1_2.TextAlign = HorizontalAlignment.Center;
            // 
            // textBox_B_player_profile_1_3
            // 
            textBox_B_player_profile_1_3.BorderStyle = BorderStyle.FixedSingle;
            textBox_B_player_profile_1_3.Location = new Point(134, 19);
            textBox_B_player_profile_1_3.Name = "textBox_B_player_profile_1_3";
            textBox_B_player_profile_1_3.Size = new Size(31, 23);
            textBox_B_player_profile_1_3.TabIndex = 4;
            textBox_B_player_profile_1_3.TextAlign = HorizontalAlignment.Center;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(106, 1);
            label1.Name = "label1";
            label1.Size = new Size(13, 15);
            label1.TabIndex = 5;
            label1.Text = "2";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(143, 1);
            label2.Name = "label2";
            label2.Size = new Size(13, 15);
            label2.TabIndex = 6;
            label2.Text = "3";
            // 
            // textBox_B_player_profile_1_prob
            // 
            textBox_B_player_profile_1_prob.BorderStyle = BorderStyle.FixedSingle;
            textBox_B_player_profile_1_prob.Location = new Point(199, 19);
            textBox_B_player_profile_1_prob.Name = "textBox_B_player_profile_1_prob";
            textBox_B_player_profile_1_prob.Size = new Size(32, 23);
            textBox_B_player_profile_1_prob.TabIndex = 7;
            textBox_B_player_profile_1_prob.Text = "0.20";
            textBox_B_player_profile_1_prob.TextAlign = HorizontalAlignment.Center;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(199, 1);
            label3.Name = "label3";
            label3.Size = new Size(32, 15);
            label3.TabIndex = 8;
            label3.Text = "prob";
            // 
            // textBox_B_player_profile_2_prob
            // 
            textBox_B_player_profile_2_prob.BorderStyle = BorderStyle.FixedSingle;
            textBox_B_player_profile_2_prob.Location = new Point(199, 48);
            textBox_B_player_profile_2_prob.Name = "textBox_B_player_profile_2_prob";
            textBox_B_player_profile_2_prob.Size = new Size(32, 23);
            textBox_B_player_profile_2_prob.TabIndex = 12;
            textBox_B_player_profile_2_prob.Text = "0.20";
            textBox_B_player_profile_2_prob.TextAlign = HorizontalAlignment.Center;
            // 
            // textBox_B_player_profile_2_3
            // 
            textBox_B_player_profile_2_3.BorderStyle = BorderStyle.FixedSingle;
            textBox_B_player_profile_2_3.Location = new Point(134, 48);
            textBox_B_player_profile_2_3.Name = "textBox_B_player_profile_2_3";
            textBox_B_player_profile_2_3.Size = new Size(31, 23);
            textBox_B_player_profile_2_3.TabIndex = 11;
            textBox_B_player_profile_2_3.TextAlign = HorizontalAlignment.Center;
            // 
            // textBox_B_player_profile_2_2
            // 
            textBox_B_player_profile_2_2.BorderStyle = BorderStyle.FixedSingle;
            textBox_B_player_profile_2_2.Location = new Point(97, 48);
            textBox_B_player_profile_2_2.Name = "textBox_B_player_profile_2_2";
            textBox_B_player_profile_2_2.Size = new Size(31, 23);
            textBox_B_player_profile_2_2.TabIndex = 10;
            textBox_B_player_profile_2_2.TextAlign = HorizontalAlignment.Center;
            // 
            // textBox_B_player_profile_2_1
            // 
            textBox_B_player_profile_2_1.BorderStyle = BorderStyle.FixedSingle;
            textBox_B_player_profile_2_1.Location = new Point(60, 48);
            textBox_B_player_profile_2_1.Name = "textBox_B_player_profile_2_1";
            textBox_B_player_profile_2_1.Size = new Size(31, 23);
            textBox_B_player_profile_2_1.TabIndex = 9;
            textBox_B_player_profile_2_1.Text = "2";
            textBox_B_player_profile_2_1.TextAlign = HorizontalAlignment.Center;
            // 
            // textBox_B_player_profile_3_prob
            // 
            textBox_B_player_profile_3_prob.BorderStyle = BorderStyle.FixedSingle;
            textBox_B_player_profile_3_prob.Location = new Point(199, 77);
            textBox_B_player_profile_3_prob.Name = "textBox_B_player_profile_3_prob";
            textBox_B_player_profile_3_prob.Size = new Size(32, 23);
            textBox_B_player_profile_3_prob.TabIndex = 16;
            textBox_B_player_profile_3_prob.Text = "0.20";
            textBox_B_player_profile_3_prob.TextAlign = HorizontalAlignment.Center;
            // 
            // textBox_B_player_profile_3_3
            // 
            textBox_B_player_profile_3_3.BorderStyle = BorderStyle.FixedSingle;
            textBox_B_player_profile_3_3.Location = new Point(134, 77);
            textBox_B_player_profile_3_3.Name = "textBox_B_player_profile_3_3";
            textBox_B_player_profile_3_3.Size = new Size(31, 23);
            textBox_B_player_profile_3_3.TabIndex = 15;
            textBox_B_player_profile_3_3.TextAlign = HorizontalAlignment.Center;
            // 
            // textBox_B_player_profile_3_2
            // 
            textBox_B_player_profile_3_2.BorderStyle = BorderStyle.FixedSingle;
            textBox_B_player_profile_3_2.Location = new Point(97, 77);
            textBox_B_player_profile_3_2.Name = "textBox_B_player_profile_3_2";
            textBox_B_player_profile_3_2.Size = new Size(31, 23);
            textBox_B_player_profile_3_2.TabIndex = 14;
            textBox_B_player_profile_3_2.Text = "1";
            textBox_B_player_profile_3_2.TextAlign = HorizontalAlignment.Center;
            // 
            // textBox_B_player_profile_3_1
            // 
            textBox_B_player_profile_3_1.BorderStyle = BorderStyle.FixedSingle;
            textBox_B_player_profile_3_1.Location = new Point(60, 77);
            textBox_B_player_profile_3_1.Name = "textBox_B_player_profile_3_1";
            textBox_B_player_profile_3_1.Size = new Size(31, 23);
            textBox_B_player_profile_3_1.TabIndex = 13;
            textBox_B_player_profile_3_1.TextAlign = HorizontalAlignment.Center;
            // 
            // textBox_B_player_profile_4_prob
            // 
            textBox_B_player_profile_4_prob.BorderStyle = BorderStyle.FixedSingle;
            textBox_B_player_profile_4_prob.Location = new Point(199, 106);
            textBox_B_player_profile_4_prob.Name = "textBox_B_player_profile_4_prob";
            textBox_B_player_profile_4_prob.Size = new Size(32, 23);
            textBox_B_player_profile_4_prob.TabIndex = 20;
            textBox_B_player_profile_4_prob.Text = "0.40";
            textBox_B_player_profile_4_prob.TextAlign = HorizontalAlignment.Center;
            // 
            // textBox_B_player_profile_4_3
            // 
            textBox_B_player_profile_4_3.BorderStyle = BorderStyle.FixedSingle;
            textBox_B_player_profile_4_3.Location = new Point(134, 106);
            textBox_B_player_profile_4_3.Name = "textBox_B_player_profile_4_3";
            textBox_B_player_profile_4_3.Size = new Size(31, 23);
            textBox_B_player_profile_4_3.TabIndex = 19;
            textBox_B_player_profile_4_3.Text = "1";
            textBox_B_player_profile_4_3.TextAlign = HorizontalAlignment.Center;
            // 
            // textBox_B_player_profile_4_2
            // 
            textBox_B_player_profile_4_2.BorderStyle = BorderStyle.FixedSingle;
            textBox_B_player_profile_4_2.Location = new Point(97, 106);
            textBox_B_player_profile_4_2.Name = "textBox_B_player_profile_4_2";
            textBox_B_player_profile_4_2.Size = new Size(31, 23);
            textBox_B_player_profile_4_2.TabIndex = 18;
            textBox_B_player_profile_4_2.Text = "3";
            textBox_B_player_profile_4_2.TextAlign = HorizontalAlignment.Center;
            // 
            // textBox_B_player_profile_4_1
            // 
            textBox_B_player_profile_4_1.BorderStyle = BorderStyle.FixedSingle;
            textBox_B_player_profile_4_1.Location = new Point(60, 106);
            textBox_B_player_profile_4_1.Name = "textBox_B_player_profile_4_1";
            textBox_B_player_profile_4_1.Size = new Size(31, 23);
            textBox_B_player_profile_4_1.TabIndex = 17;
            textBox_B_player_profile_4_1.TextAlign = HorizontalAlignment.Center;
            // 
            // textBox_B_player_profile_5_prob
            // 
            textBox_B_player_profile_5_prob.BorderStyle = BorderStyle.FixedSingle;
            textBox_B_player_profile_5_prob.Location = new Point(199, 135);
            textBox_B_player_profile_5_prob.Name = "textBox_B_player_profile_5_prob";
            textBox_B_player_profile_5_prob.Size = new Size(32, 23);
            textBox_B_player_profile_5_prob.TabIndex = 24;
            textBox_B_player_profile_5_prob.Text = "0";
            textBox_B_player_profile_5_prob.TextAlign = HorizontalAlignment.Center;
            // 
            // textBox_B_player_profile_5_3
            // 
            textBox_B_player_profile_5_3.BorderStyle = BorderStyle.FixedSingle;
            textBox_B_player_profile_5_3.Location = new Point(134, 135);
            textBox_B_player_profile_5_3.Name = "textBox_B_player_profile_5_3";
            textBox_B_player_profile_5_3.Size = new Size(31, 23);
            textBox_B_player_profile_5_3.TabIndex = 23;
            textBox_B_player_profile_5_3.Text = "11";
            textBox_B_player_profile_5_3.TextAlign = HorizontalAlignment.Center;
            // 
            // textBox_B_player_profile_5_2
            // 
            textBox_B_player_profile_5_2.BorderStyle = BorderStyle.FixedSingle;
            textBox_B_player_profile_5_2.Location = new Point(97, 135);
            textBox_B_player_profile_5_2.Name = "textBox_B_player_profile_5_2";
            textBox_B_player_profile_5_2.Size = new Size(31, 23);
            textBox_B_player_profile_5_2.TabIndex = 22;
            textBox_B_player_profile_5_2.Text = "11";
            textBox_B_player_profile_5_2.TextAlign = HorizontalAlignment.Center;
            // 
            // textBox_B_player_profile_5_1
            // 
            textBox_B_player_profile_5_1.BorderStyle = BorderStyle.FixedSingle;
            textBox_B_player_profile_5_1.Location = new Point(60, 135);
            textBox_B_player_profile_5_1.Name = "textBox_B_player_profile_5_1";
            textBox_B_player_profile_5_1.Size = new Size(31, 23);
            textBox_B_player_profile_5_1.TabIndex = 21;
            textBox_B_player_profile_5_1.Text = "11";
            textBox_B_player_profile_5_1.TextAlign = HorizontalAlignment.Center;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(3, 50);
            label4.Name = "label4";
            label4.Size = new Size(51, 15);
            label4.TabIndex = 25;
            label4.Text = "B_pref_2";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(3, 79);
            label5.Name = "label5";
            label5.Size = new Size(51, 15);
            label5.TabIndex = 26;
            label5.Text = "B_pref_3";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(3, 108);
            label6.Name = "label6";
            label6.Size = new Size(51, 15);
            label6.TabIndex = 27;
            label6.Text = "B_pref_4";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(3, 137);
            label7.Name = "label7";
            label7.Size = new Size(51, 15);
            label7.TabIndex = 28;
            label7.Text = "B_pref_5";
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
            panel_competition_type.ResumeLayout(false);
            panel_competition_type.PerformLayout();
            panel_max_num_of_games.ResumeLayout(false);
            panel_max_num_of_games.PerformLayout();
            panel_Network_of_boats.ResumeLayout(false);
            panel_Network_of_boats.PerformLayout();
            panel_boat_players_profile.ResumeLayout(false);
            panel_boat_players_profile.PerformLayout();
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
        private Label label_competition_type;
        private Panel panel_competition_type;
        private RadioButton radioButton_competition_name_tournament;
        private RadioButton radioButton_competition_type_invasion;
        private RadioButton radioButton_competition_type_roulette;
        private Panel panel_boat_players_profile;
        private TextBox textBox_B_player_profile_1_1;
        private Label label_1;
        private TextBox textBox_B_player_profile_1_3;
        private TextBox textBox_B_player_profile_1_2;
        private Label label_B_player_1;
        private Label label1;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private TextBox textBox_B_player_profile_5_prob;
        private TextBox textBox_B_player_profile_5_3;
        private TextBox textBox_B_player_profile_5_2;
        private TextBox textBox_B_player_profile_5_1;
        private TextBox textBox_B_player_profile_4_prob;
        private TextBox textBox_B_player_profile_4_3;
        private TextBox textBox_B_player_profile_4_2;
        private TextBox textBox_B_player_profile_4_1;
        private TextBox textBox_B_player_profile_3_prob;
        private TextBox textBox_B_player_profile_3_3;
        private TextBox textBox_B_player_profile_3_2;
        private TextBox textBox_B_player_profile_3_1;
        private TextBox textBox_B_player_profile_2_prob;
        private TextBox textBox_B_player_profile_2_3;
        private TextBox textBox_B_player_profile_2_2;
        private TextBox textBox_B_player_profile_2_1;
        private Label label3;
        private TextBox textBox_B_player_profile_1_prob;
        private Label label2;
    }
}
