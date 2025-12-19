namespace TestApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            string? name = null;

            MessageBox.Show($"Hello, {name ?? "Guest"}!");

            int? length = name?.Length;
        }
    }
}
