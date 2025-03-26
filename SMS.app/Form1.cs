using SMS.domain;

namespace SMS.app
{
    public partial class Form1 : Form
    {
        public object StudentName { get; private set; }

        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            var student = new Student
            {
                StudentId = 1,
                StudentName = "John Doe",
                StudentEmail = "johndoe@gmail.com"
            };

            textBoxID.Text = student.StudentId.ToString();
            textBoxName.Text = student.StudentName;
            textBoxEmail.Text = student.StudentEmail;
        }

        private void buttonShow_Click(object sender, EventArgs e)
        {
            var student = new Student
            {
                StudentId = 2,
                StudentName = "Doe",
                StudentEmail = "doe@gmail.com"
            };

            textBoxID.Text = student.StudentId.ToString();
            textBoxName.Text = student.StudentName;
            textBoxEmail.Text = student.StudentEmail;
        }
        }

    }
