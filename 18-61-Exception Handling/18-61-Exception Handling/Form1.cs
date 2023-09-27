namespace _18_61_Exception_Handling
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int result = Convert.ToInt32(textBox1.Text) / Convert.ToInt32(textBox2.Text);
            }
            catch (DivideByZeroException ex)
            {
                throw new Exception("You can't divide numbers by zero");
            }
            catch (Exception ex)
            {
                throw new Exception("Please use numbers");
            }
            finally
            {
                MessageBox.Show("Completed");
            }
      
        }
    }
}