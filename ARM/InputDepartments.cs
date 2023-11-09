using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ARM
{
    public partial class InputDepartments : Form
    {
        
        
        public InputDepartments()
        {
            InitializeComponent();
        }

        public string DepartmentName
        {
            private set;get;
        }
        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }
        public void AddOldInformation(string name)
        {
            tbDeparrtment.Text = name;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            
            if (string.IsNullOrWhiteSpace(tbDeparrtment.Text))
            {
                MessageBox.Show("Поле не должно быть пустым!");
                return;
            }


            DepartmentName = tbDeparrtment.Text;
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void tbDeparrtment_TextChanged(object sender, EventArgs e)
        {
            

        }

        private void InputDepartments_Load(object sender, EventArgs e)
        {
            CenterToParent();
        }
    }
}
