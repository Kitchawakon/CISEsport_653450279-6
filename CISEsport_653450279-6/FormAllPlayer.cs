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
    public partial class FormAllPlayer : Form
    {
        private List<Player> listPlayer = new List<Player>();
        Player selectedPlayer;
        public FormAllPlayer()
        {
            InitializeComponent();
        }
        private void newPlayerToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FormInfo formInfo = new FormInfo();
            formInfo.ShowDialog();

            if (formInfo.DialogResult == DialogResult.OK)
            {
                Player newPlayer = formInfo.GetPlayer();
                listPlayer.Add(newPlayer);
                this.dataGridView1.DataSource = null;
                this.dataGridView1.DataSource = listPlayer;
                formInfo.Close();
            }
        }
        private void saveFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFile = new SaveFileDialog();
            saveFile.Filter = "CSV|*.csv|TEXT|*.txt";
            saveFile.ShowDialog();
            if(saveFile.FileName != "")
            {
                using (StreamWriter writer = new StreamWriter(saveFile.FileName))
                {
                    foreach (Player item in listPlayer)
                    {
                        writer.WriteLine(String.Format("{0},{1},{2},{3},{4},{5},{6},{7}", item.Name, item.Lastname, item.ID, item.Field, item.Gamename, item.Email, item.Tel, item.Age));
                    }
                }
            }
        }

        

        //Show Data player
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                this.selectedPlayer = (Player)row.DataBoundItem;

                this.textBoxName.Text = selectedPlayer.Name;
                this.textBoxID.Text = selectedPlayer.ID;
                this.textBoxField.Text = selectedPlayer.Field;
                this.textBoxGName.Text = selectedPlayer.Gamename;
                
            }
            string iName = textBoxName.Text, iLname = "", iID = textBoxID.Text, iField = textBoxField.Text, iGname = textBoxGName.Text, iMail = "", iTel = "",age = "0";
            int iage = Int32.Parse(age);
            selectedPlayer = new Player(iName,iLname,iID,iField,iGname,iMail,iTel,iage);
        }
        public Player GetselectedPlayer() { return selectedPlayer; }

        
        //open file
        private void openFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "CSV|*.csv|TEXT|*.txt";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                using (StreamReader reader = new StreamReader(openFileDialog.FileName))
                {
                    while (!reader.EndOfStream)
                    {
                        string[] line = reader.ReadLine().Split(',');
                        if (line.Length >= 8) // Check that there are enough fields
                        {
                            Player players = new Player(line[0],line[1],line[2],line[3],line[4],line[5],line[6],Int32.Parse(line[7]));
                            listPlayer.Add(players);
                        }
                    }

                }
                this.dataGridView1.DataSource = null;
                this.dataGridView1.DataSource = listPlayer;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
