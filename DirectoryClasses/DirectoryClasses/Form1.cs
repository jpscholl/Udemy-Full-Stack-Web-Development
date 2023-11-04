namespace DirectoryClasses
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_Create_Click(object sender, EventArgs e)
        {
            DirectoryInfo dr = new DirectoryInfo("temp");
            dr.Create();
            MessageBox.Show("Folder was created");
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Directory.Move("temp", @"C:\newfolder\temp");
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            Directory.Delete("temp");
            MessageBox.Show("Folder was deleted");
        }
    }
}