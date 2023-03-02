namespace KittyGame
{
    public partial class FormStart : Form
    {
        public FormStart()
        {
            InitializeComponent();
        }


        private async void buttonStart_Click(object sender, EventArgs e)
        {
            
            if (string.IsNullOrWhiteSpace(textBoxName.Text)) //проверка имени
            {

                panelWarning.Visible = true;
                return;
                
            }


            panelWarning.Visible = false;
            Hide();
            var formMap = new FormMap(textBoxName.Text);
            formMap.Show();
            
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void ¬в_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBoxName_TextChanged(object sender, EventArgs e)
        {

        }
    }
}