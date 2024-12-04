namespace Practika05._11
{
    public partial class Form1 : Form
    {
        private Form childForm;
        private TextBox textBoxChild;

        public Form1()
        {
            InitializeComponent();
            // Создаем дочернюю форму и показываем её
            childForm = new Form();
            textBoxChild = new TextBox() { Dock = DockStyle.Fill };
            childForm.Controls.Add(textBoxChild);
            childForm.Text = "Child Form";
            childForm.Show();
        }

      
        }

        
    }


