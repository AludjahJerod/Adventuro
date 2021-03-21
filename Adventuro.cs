using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Adventure
{
    public partial class Adventuro : Form
    {

        InteractionFacade game = new InteractionFacade();
        OffensiveStance offensive = new OffensiveStance();
        DefensiveStance defensive = new DefensiveStance();

        public Adventuro()
        {
            InitializeComponent();
            RefreshArrows();
            pnl_move.Enabled = false;
            UpdateStats();
            lbl_defv.Hide();
            lbl_off.Hide();

            lbl_game.Text = "Welcome to the Dungeon, great adventurer!!\n";
        }

        public void UpdateStats()
        {
            lbl_attack.Text = game.Player.Attack.ToString();
            lbl_def.Text = game.Player.Defence.ToString();
            lbl_hp.Text = game.Player.HP.ToString();
            RefreshScroll();
            CheckEnd();
        }

        public void CheckEnd()
        {
            if (game.End)
            {
                DialogResult dialog = MessageBox.Show("Game Ended", "Game Ended", MessageBoxButtons.OK);
                if (dialog == DialogResult.OK)
                    Application.Exit();
                else
                    Application.Exit();
            }
        }

        public void RefreshArrows()
        {
            if (game.Board.Px == 0)
                btn_left.Enabled = false;
            else if (game.Board.Px == 4)
                btn_right.Enabled = false;
            else
            {
                btn_left.Enabled = true;
                btn_right.Enabled = true;
            }

            if (game.Board.Py == 0)
                btn_front.Enabled = false;
            else if (game.Board.Py == 4)
                btn_back.Enabled = false;
            else
            {
                btn_back.Enabled = true;
                btn_front.Enabled = true;
            }
        }

        private void lytgrid_CellPaint(object sender, TableLayoutCellPaintEventArgs e)
        {
            using (var b = new SolidBrush(game.Board.brd[e.Column, e.Row].Clr))
            {
                e.Graphics.FillRectangle(b, e.CellBounds);
            }
        }

        private void btn_off_Click(object sender, EventArgs e)
        {
            game.SetStrategy(offensive); 
            lbl_off.Show();
            lbl_defv.Hide();
            if (game.Fight == false)
            {                
                if (pnl_move.Enabled == false)
                {
                    pnl_move.Enabled = true;
                }
            }
            else
            {
                lbl_game.Text+= game.Action(true);
                UpdateStats();
            }
        }

        private void btn_def_Click(object sender, EventArgs e)
        {
            game.SetStrategy(defensive);
            lbl_defv.Show();
            lbl_off.Hide();
            if (game.Fight == false)
            {
                if (pnl_move.Enabled == false)
                {
                    pnl_move.Enabled = true;
                }
            }
            else
            {
                lbl_game.Text += game.Action(true);
                UpdateStats();
            }
        }

        private void btn_front_Click(object sender, EventArgs e)
        {
            lbl_game.Text += game.Move(0, -1);
            lytgrid.Refresh();
            RefreshArrows();
            UpdateStats();
            pnl_move.Enabled = false;
        }

        private void btn_left_Click(object sender, EventArgs e)
        {
            lbl_game.Text += game.Move(-1, 0);
            lytgrid.Refresh();
            RefreshArrows();
            UpdateStats();
            pnl_move.Enabled = false;
        }

        private void btn_right_Click(object sender, EventArgs e)
        {
            lbl_game.Text += game.Move(1, 0);
            lytgrid.Refresh();
            RefreshArrows();
            UpdateStats();
            pnl_move.Enabled = false;
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            lbl_game.Text += game.Move(0, 1);
            lytgrid.Refresh();
            RefreshArrows();
            UpdateStats();
            pnl_move.Enabled = false;
        }

        public void RefreshScroll()
        {
            pnl_text.VerticalScroll.Value = pnl_text.VerticalScroll.Maximum;
            pnl_text.PerformLayout();
        }
    }
}
