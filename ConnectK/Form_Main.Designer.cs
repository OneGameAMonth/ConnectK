﻿namespace Connect4
{
    partial class Form_Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Main));
            this.dataGridView_game = new System.Windows.Forms.DataGridView();
            this.numericUpDown_rows = new System.Windows.Forms.NumericUpDown();
            this.button_start = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.numericUpDown_collumns = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown_players = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel_currentPlayer = new System.Windows.Forms.Panel();
            this.button_help = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.numericUpDown_connectk = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_game)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_rows)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_collumns)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_players)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_connectk)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView_game
            // 
            this.dataGridView_game.AllowUserToAddRows = false;
            this.dataGridView_game.AllowUserToDeleteRows = false;
            this.dataGridView_game.AllowUserToResizeColumns = false;
            this.dataGridView_game.AllowUserToResizeRows = false;
            this.dataGridView_game.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView_game.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView_game.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_game.Location = new System.Drawing.Point(13, 25);
            this.dataGridView_game.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridView_game.Name = "dataGridView_game";
            this.dataGridView_game.RowHeadersVisible = false;
            this.dataGridView_game.RowTemplate.Height = 24;
            this.dataGridView_game.Size = new System.Drawing.Size(538, 326);
            this.dataGridView_game.TabIndex = 0;
            this.dataGridView_game.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView_game_CellMouseClick);
            this.dataGridView_game.SelectionChanged += new System.EventHandler(this.dataGridView_game_SelectionChanged);
            // 
            // numericUpDown_rows
            // 
            this.numericUpDown_rows.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.numericUpDown_rows.Location = new System.Drawing.Point(65, 362);
            this.numericUpDown_rows.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.numericUpDown_rows.Maximum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.numericUpDown_rows.Minimum = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.numericUpDown_rows.Name = "numericUpDown_rows";
            this.numericUpDown_rows.ReadOnly = true;
            this.numericUpDown_rows.Size = new System.Drawing.Size(43, 22);
            this.numericUpDown_rows.TabIndex = 1;
            this.numericUpDown_rows.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // button_start
            // 
            this.button_start.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button_start.Location = new System.Drawing.Point(481, 396);
            this.button_start.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button_start.Name = "button_start";
            this.button_start.Size = new System.Drawing.Size(75, 23);
            this.button_start.TabIndex = 2;
            this.button_start.Text = "START";
            this.button_start.UseVisualStyleBackColor = true;
            this.button_start.Click += new System.EventHandler(this.button_start_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 364);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "Rows:";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(128, 366);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Collumns:";
            // 
            // numericUpDown_collumns
            // 
            this.numericUpDown_collumns.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.numericUpDown_collumns.Location = new System.Drawing.Point(203, 362);
            this.numericUpDown_collumns.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.numericUpDown_collumns.Maximum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.numericUpDown_collumns.Minimum = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.numericUpDown_collumns.Name = "numericUpDown_collumns";
            this.numericUpDown_collumns.Size = new System.Drawing.Size(43, 22);
            this.numericUpDown_collumns.TabIndex = 6;
            this.numericUpDown_collumns.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // numericUpDown_players
            // 
            this.numericUpDown_players.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.numericUpDown_players.Location = new System.Drawing.Point(515, 362);
            this.numericUpDown_players.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.numericUpDown_players.Maximum = new decimal(new int[] {
            8,
            0,
            0,
            0});
            this.numericUpDown_players.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown_players.Name = "numericUpDown_players";
            this.numericUpDown_players.Size = new System.Drawing.Size(37, 22);
            this.numericUpDown_players.TabIndex = 8;
            this.numericUpDown_players.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(421, 366);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 17);
            this.label3.TabIndex = 7;
            this.label3.Text = "Total Players:";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(257, 399);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(103, 17);
            this.label4.TabIndex = 9;
            this.label4.Text = "Current Player:";
            // 
            // panel_currentPlayer
            // 
            this.panel_currentPlayer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.panel_currentPlayer.Location = new System.Drawing.Point(357, 396);
            this.panel_currentPlayer.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel_currentPlayer.Name = "panel_currentPlayer";
            this.panel_currentPlayer.Size = new System.Drawing.Size(117, 23);
            this.panel_currentPlayer.TabIndex = 10;
            // 
            // button_help
            // 
            this.button_help.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button_help.Location = new System.Drawing.Point(12, 395);
            this.button_help.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button_help.Name = "button_help";
            this.button_help.Size = new System.Drawing.Size(72, 25);
            this.button_help.TabIndex = 11;
            this.button_help.Text = "HELP";
            this.button_help.UseVisualStyleBackColor = true;
            this.button_help.Click += new System.EventHandler(this.button_help_Click);
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(267, 364);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(104, 17);
            this.label5.TabIndex = 12;
            this.label5.Text = "Connect to win:";
            // 
            // numericUpDown_connectk
            // 
            this.numericUpDown_connectk.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.numericUpDown_connectk.Location = new System.Drawing.Point(373, 361);
            this.numericUpDown_connectk.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.numericUpDown_connectk.Maximum = new decimal(new int[] {
            8,
            0,
            0,
            0});
            this.numericUpDown_connectk.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown_connectk.Name = "numericUpDown_connectk";
            this.numericUpDown_connectk.Size = new System.Drawing.Size(37, 22);
            this.numericUpDown_connectk.TabIndex = 13;
            this.numericUpDown_connectk.Value = new decimal(new int[] {
            4,
            0,
            0,
            0});
            // 
            // Form_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(579, 432);
            this.Controls.Add(this.numericUpDown_connectk);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.button_help);
            this.Controls.Add(this.panel_currentPlayer);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.numericUpDown_players);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.numericUpDown_collumns);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button_start);
            this.Controls.Add(this.numericUpDown_rows);
            this.Controls.Add(this.dataGridView_game);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MinimumSize = new System.Drawing.Size(597, 468);
            this.Name = "Form_Main";
            this.Text = "Connect K";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_game)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_rows)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_collumns)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_players)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_connectk)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView_game;
        private System.Windows.Forms.NumericUpDown numericUpDown_rows;
        private System.Windows.Forms.Button button_start;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown numericUpDown_collumns;
        private System.Windows.Forms.NumericUpDown numericUpDown_players;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel_currentPlayer;
        private System.Windows.Forms.Button button_help;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown numericUpDown_connectk;
    }
}