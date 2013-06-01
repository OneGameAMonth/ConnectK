namespace Connect4
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
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_game)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_rows)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_collumns)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_players)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView_game
            // 
            this.dataGridView_game.AllowUserToAddRows = false;
            this.dataGridView_game.AllowUserToDeleteRows = false;
            this.dataGridView_game.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_game.Location = new System.Drawing.Point(13, 24);
            this.dataGridView_game.Name = "dataGridView_game";
            this.dataGridView_game.RowTemplate.Height = 24;
            this.dataGridView_game.Size = new System.Drawing.Size(917, 455);
            this.dataGridView_game.TabIndex = 0;
            this.dataGridView_game.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView_game_CellMouseClick);
            this.dataGridView_game.SelectionChanged += new System.EventHandler(this.dataGridView_game_SelectionChanged);
            // 
            // numericUpDown_rows
            // 
            this.numericUpDown_rows.Location = new System.Drawing.Point(143, 496);
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
            this.numericUpDown_rows.Size = new System.Drawing.Size(57, 22);
            this.numericUpDown_rows.TabIndex = 1;
            this.numericUpDown_rows.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // button_start
            // 
            this.button_start.Location = new System.Drawing.Point(769, 500);
            this.button_start.Name = "button_start";
            this.button_start.Size = new System.Drawing.Size(75, 23);
            this.button_start.TabIndex = 2;
            this.button_start.Text = "Start";
            this.button_start.UseVisualStyleBackColor = true;
            this.button_start.Click += new System.EventHandler(this.button_start_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(92, 500);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "Rows:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(221, 499);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Collumns:";
            // 
            // numericUpDown_collumns
            // 
            this.numericUpDown_collumns.Location = new System.Drawing.Point(292, 498);
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
            this.numericUpDown_collumns.Size = new System.Drawing.Size(57, 22);
            this.numericUpDown_collumns.TabIndex = 6;
            this.numericUpDown_collumns.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // numericUpDown_players
            // 
            this.numericUpDown_players.Location = new System.Drawing.Point(465, 497);
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
            this.numericUpDown_players.Size = new System.Drawing.Size(57, 22);
            this.numericUpDown_players.TabIndex = 8;
            this.numericUpDown_players.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(365, 500);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 17);
            this.label3.TabIndex = 7;
            this.label3.Text = "Total Players:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(540, 500);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(99, 17);
            this.label4.TabIndex = 9;
            this.label4.Text = "Current Player";
            // 
            // panel_currentPlayer
            // 
            this.panel_currentPlayer.Location = new System.Drawing.Point(645, 500);
            this.panel_currentPlayer.Name = "panel_currentPlayer";
            this.panel_currentPlayer.Size = new System.Drawing.Size(118, 23);
            this.panel_currentPlayer.TabIndex = 10;
            // 
            // button_help
            // 
            this.button_help.Location = new System.Drawing.Point(880, 500);
            this.button_help.Name = "button_help";
            this.button_help.Size = new System.Drawing.Size(50, 23);
            this.button_help.TabIndex = 11;
            this.button_help.Text = "Help";
            this.button_help.UseVisualStyleBackColor = true;
            this.button_help.Click += new System.EventHandler(this.button_help_Click);
            // 
            // Form_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(942, 535);
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
            this.Name = "Form_Main";
            this.Text = "Form_Main";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_game)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_rows)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_collumns)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_players)).EndInit();
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
    }
}