using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CISESPORT
{
    public partial class FormTeamInfo : Form
    {
        private Team _teams;
        public FormTeamInfo()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           FormAllPlayer formAllPlayer= new FormAllPlayer();
           formAllPlayer.ShowDialog();
           if(formAllPlayer.DialogResult == DialogResult.OK)
            {
                Player PlayerInfo = formAllPlayer.GetselectedPlayer();
                this.TBName1.Text = PlayerInfo.Name;
                this.TBGamename1.Text = PlayerInfo.Gamename;
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            FormAllPlayer formAllPlayer = new FormAllPlayer();
            formAllPlayer.ShowDialog();
            if (formAllPlayer.DialogResult == DialogResult.OK)
            {
                Player PlayerInfo = formAllPlayer.GetselectedPlayer();
                this.TBName2.Text = PlayerInfo.Name;
                this.TBGamename2.Text = PlayerInfo.Gamename;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FormAllPlayer formAllPlayer = new FormAllPlayer();
            formAllPlayer.ShowDialog();
            if (formAllPlayer.DialogResult == DialogResult.OK)
            {
                Player PlayerInfo = formAllPlayer.GetselectedPlayer();
                this.TBName3.Text = PlayerInfo.Name;
                this.TBGamename3.Text = PlayerInfo.Gamename;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            FormAllPlayer formAllPlayer = new FormAllPlayer();
            formAllPlayer.ShowDialog();
            if (formAllPlayer.DialogResult == DialogResult.OK)
            {
                Player PlayerInfo = formAllPlayer.GetselectedPlayer();
                this.TBName4.Text = PlayerInfo.Name;
                this.TBGamename4.Text = PlayerInfo.Gamename;
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            FormAllPlayer formAllPlayer = new FormAllPlayer();
            formAllPlayer.ShowDialog();
            if (formAllPlayer.DialogResult == DialogResult.OK)
            {
                Player PlayerInfo = formAllPlayer.GetselectedPlayer();
                this.TBName5.Text = PlayerInfo.Name;
                this.TBGamename5.Text = PlayerInfo.Gamename;
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            string team = TBTeam.Text;
            string name1 = TBName1.Text;
            string gamename1 = TBGamename1.Text;
            string name2 = TBName2.Text;
            string gamename2 = TBGamename2.Text;
            string name3 = TBName3.Text;
            string gamename3 = TBGamename3.Text;
            string name4 = TBName4.Text;
            string gamename4 = TBGamename4.Text;
            string name5 = TBName5.Text;
            string gamename5 = TBGamename5.Text;

            _teams = new Team(team, name1, gamename1, name2, gamename2, name3, gamename3, name4, gamename4, name5, gamename5);
            this.DialogResult= DialogResult.OK;
        }
        public Team getTeam() { return _teams; }
    }
}
