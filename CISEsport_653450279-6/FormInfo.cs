namespace CISESPORT
{
    public partial class FormInfo : Form
    {
        private Player _newPlayer;
        public FormInfo()
        {
            InitializeComponent();
        }

        //Add new player info
        private void button1_Click(object sender, EventArgs e)
        {
            string name = textBoxName.Text;
            string lname = textBoxLname.Text;
            string id = textBoxID.Text;
            string field = textBoxField.Text;
            string gname = textBoxGName.Text;
            string mail = textBoxMail.Text;
            string tel = textBoxTel.Text;
            int iage = 0;
            try
            {
                string age = textBoxAge.Text;
                iage = Int32.Parse(age);
            }
            catch (FormatException ex) {
                //Do something if have some exception
                MessageBox.Show("ใส่ตัวเลขไอสัส อ่านหน่อย");
                return;
            }
            _newPlayer = new Player(name, lname, id, field, gname, mail, tel, iage);

            this.DialogResult = DialogResult.OK;
        }
        public Player GetPlayer() { return _newPlayer; }
    }
}