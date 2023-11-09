using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ARM
{
    public partial class InputEmployees : Form
    {
        public InputEmployees()
        {
            InitializeComponent();

        }

        public string FirstName
        {
            private set; get;
        }

        public string LastName
        {
            private set; get;
        }

        public void AddOldInformation(string first_name, string last_name)
        {
            FirstName =first_name; 
            LastName =last_name;
            textBox1.Text = first_name;
            textBox2.Text = last_name;
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void InputEmployees_Load(object sender, EventArgs e)
        {
            CenterToParent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox1.Text) || string.IsNullOrWhiteSpace(textBox2.Text))
            {
                MessageBox.Show("Поле не должно быть пустым!");
                return;
            }
            FirstName =textBox1.Text;
            LastName = textBox2.Text;
            DialogResult = DialogResult.Cancel;
            Close();
        }

        
    }
}
