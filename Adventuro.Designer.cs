namespace Adventure
{
    partial class Adventuro
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Adventuro));
            this.lytgrid = new System.Windows.Forms.TableLayoutPanel();
            this.btn_left = new System.Windows.Forms.Button();
            this.btn_front = new System.Windows.Forms.Button();
            this.btn_back = new System.Windows.Forms.Button();
            this.btn_right = new System.Windows.Forms.Button();
            this.btn_def = new System.Windows.Forms.Button();
            this.btn_off = new System.Windows.Forms.Button();
            this.lbl_hp = new System.Windows.Forms.Label();
            this.lbl_attack = new System.Windows.Forms.Label();
            this.lbl_def = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pnl_text = new System.Windows.Forms.Panel();
            this.lbl_game = new System.Windows.Forms.Label();
            this.lbl_off = new System.Windows.Forms.Label();
            this.lbl_defv = new System.Windows.Forms.Label();
            this.pnl_move = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pnl_text.SuspendLayout();
            this.pnl_move.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lytgrid
            // 
            this.lytgrid.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.lytgrid.ColumnCount = 5;
            this.lytgrid.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.lytgrid.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.lytgrid.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.lytgrid.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.lytgrid.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.lytgrid.Location = new System.Drawing.Point(12, 105);
            this.lytgrid.Name = "lytgrid";
            this.lytgrid.RowCount = 5;
            this.lytgrid.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.lytgrid.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.lytgrid.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.lytgrid.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.lytgrid.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.lytgrid.Size = new System.Drawing.Size(180, 180);
            this.lytgrid.TabIndex = 2;
            this.lytgrid.CellPaint += new System.Windows.Forms.TableLayoutCellPaintEventHandler(this.lytgrid_CellPaint);
            // 
            // btn_left
            // 
            this.btn_left.Location = new System.Drawing.Point(3, 63);
            this.btn_left.Name = "btn_left";
            this.btn_left.Size = new System.Drawing.Size(75, 23);
            this.btn_left.TabIndex = 1;
            this.btn_left.Text = "<-";
            this.btn_left.UseVisualStyleBackColor = true;
            this.btn_left.Click += new System.EventHandler(this.btn_left_Click);
            // 
            // btn_front
            // 
            this.btn_front.Location = new System.Drawing.Point(84, 26);
            this.btn_front.Name = "btn_front";
            this.btn_front.Size = new System.Drawing.Size(75, 23);
            this.btn_front.TabIndex = 2;
            this.btn_front.Text = "^";
            this.btn_front.UseVisualStyleBackColor = true;
            this.btn_front.Click += new System.EventHandler(this.btn_front_Click);
            // 
            // btn_back
            // 
            this.btn_back.Location = new System.Drawing.Point(84, 101);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(75, 23);
            this.btn_back.TabIndex = 3;
            this.btn_back.Text = "v";
            this.btn_back.UseVisualStyleBackColor = true;
            this.btn_back.Click += new System.EventHandler(this.btn_back_Click);
            // 
            // btn_right
            // 
            this.btn_right.Location = new System.Drawing.Point(168, 63);
            this.btn_right.Name = "btn_right";
            this.btn_right.Size = new System.Drawing.Size(75, 23);
            this.btn_right.TabIndex = 4;
            this.btn_right.Text = "->";
            this.btn_right.UseVisualStyleBackColor = true;
            this.btn_right.Click += new System.EventHandler(this.btn_right_Click);
            // 
            // btn_def
            // 
            this.btn_def.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_def.BackgroundImage")));
            this.btn_def.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_def.Location = new System.Drawing.Point(135, 480);
            this.btn_def.Name = "btn_def";
            this.btn_def.Size = new System.Drawing.Size(75, 43);
            this.btn_def.TabIndex = 5;
            this.btn_def.TabStop = false;
            this.btn_def.UseVisualStyleBackColor = true;
            this.btn_def.Click += new System.EventHandler(this.btn_def_Click);
            // 
            // btn_off
            // 
            this.btn_off.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_off.BackgroundImage")));
            this.btn_off.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_off.Location = new System.Drawing.Point(38, 480);
            this.btn_off.Name = "btn_off";
            this.btn_off.Size = new System.Drawing.Size(75, 43);
            this.btn_off.TabIndex = 6;
            this.btn_off.TabStop = false;
            this.btn_off.UseVisualStyleBackColor = true;
            this.btn_off.Click += new System.EventHandler(this.btn_off_Click);
            // 
            // lbl_hp
            // 
            this.lbl_hp.AutoSize = true;
            this.lbl_hp.Location = new System.Drawing.Point(234, 105);
            this.lbl_hp.Name = "lbl_hp";
            this.lbl_hp.Size = new System.Drawing.Size(46, 17);
            this.lbl_hp.TabIndex = 7;
            this.lbl_hp.Text = "label1";
            // 
            // lbl_attack
            // 
            this.lbl_attack.AutoSize = true;
            this.lbl_attack.Location = new System.Drawing.Point(234, 136);
            this.lbl_attack.Name = "lbl_attack";
            this.lbl_attack.Size = new System.Drawing.Size(46, 17);
            this.lbl_attack.TabIndex = 8;
            this.lbl_attack.Text = "label1";
            // 
            // lbl_def
            // 
            this.lbl_def.AutoSize = true;
            this.lbl_def.Location = new System.Drawing.Point(234, 169);
            this.lbl_def.Name = "lbl_def";
            this.lbl_def.Size = new System.Drawing.Size(46, 17);
            this.lbl_def.TabIndex = 9;
            this.lbl_def.Text = "label1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(201, 105);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 17);
            this.label1.TabIndex = 10;
            this.label1.Text = "HP";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(201, 136);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 17);
            this.label2.TabIndex = 11;
            this.label2.Text = "atk";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(201, 169);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(28, 17);
            this.label3.TabIndex = 12;
            this.label3.Text = "def";
            // 
            // pnl_text
            // 
            this.pnl_text.AutoScroll = true;
            this.pnl_text.BackColor = System.Drawing.Color.White;
            this.pnl_text.Controls.Add(this.lbl_game);
            this.pnl_text.Location = new System.Drawing.Point(286, 105);
            this.pnl_text.Name = "pnl_text";
            this.pnl_text.Size = new System.Drawing.Size(465, 435);
            this.pnl_text.TabIndex = 13;
            // 
            // lbl_game
            // 
            this.lbl_game.AutoSize = true;
            this.lbl_game.Location = new System.Drawing.Point(13, 11);
            this.lbl_game.Name = "lbl_game";
            this.lbl_game.Size = new System.Drawing.Size(46, 17);
            this.lbl_game.TabIndex = 0;
            this.lbl_game.Text = "label4";
            // 
            // lbl_off
            // 
            this.lbl_off.AutoSize = true;
            this.lbl_off.Location = new System.Drawing.Point(66, 526);
            this.lbl_off.Name = "lbl_off";
            this.lbl_off.Size = new System.Drawing.Size(15, 17);
            this.lbl_off.TabIndex = 14;
            this.lbl_off.Text = "^";
            // 
            // lbl_defv
            // 
            this.lbl_defv.AutoSize = true;
            this.lbl_defv.Location = new System.Drawing.Point(166, 526);
            this.lbl_defv.Name = "lbl_defv";
            this.lbl_defv.Size = new System.Drawing.Size(15, 17);
            this.lbl_defv.TabIndex = 15;
            this.lbl_defv.Text = "^";
            // 
            // pnl_move
            // 
            this.pnl_move.Controls.Add(this.btn_right);
            this.pnl_move.Controls.Add(this.btn_left);
            this.pnl_move.Controls.Add(this.btn_front);
            this.pnl_move.Controls.Add(this.btn_back);
            this.pnl_move.Location = new System.Drawing.Point(12, 302);
            this.pnl_move.Name = "pnl_move";
            this.pnl_move.Size = new System.Drawing.Size(248, 147);
            this.pnl_move.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(250, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(302, 69);
            this.label4.TabIndex = 18;
            this.label4.Text = "Adventuro";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(169, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(75, 66);
            this.pictureBox1.TabIndex = 19;
            this.pictureBox1.TabStop = false;
            // 
            // Adventuro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(763, 552);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.pnl_move);
            this.Controls.Add(this.lbl_defv);
            this.Controls.Add(this.lbl_off);
            this.Controls.Add(this.pnl_text);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbl_def);
            this.Controls.Add(this.lbl_attack);
            this.Controls.Add(this.lbl_hp);
            this.Controls.Add(this.btn_off);
            this.Controls.Add(this.btn_def);
            this.Controls.Add(this.lytgrid);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Adventuro";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.pnl_text.ResumeLayout(false);
            this.pnl_text.PerformLayout();
            this.pnl_move.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel lytgrid;
        private System.Windows.Forms.Button btn_left;
        private System.Windows.Forms.Button btn_front;
        private System.Windows.Forms.Button btn_back;
        private System.Windows.Forms.Button btn_right;
        private System.Windows.Forms.Button btn_def;
        private System.Windows.Forms.Button btn_off;
        private System.Windows.Forms.Label lbl_hp;
        private System.Windows.Forms.Label lbl_attack;
        private System.Windows.Forms.Label lbl_def;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel pnl_text;
        private System.Windows.Forms.Label lbl_game;
        private System.Windows.Forms.Label lbl_off;
        private System.Windows.Forms.Label lbl_defv;
        private System.Windows.Forms.Panel pnl_move;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

