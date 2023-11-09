using Npgsql;
using System;
using System.Data;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace ARM
{
    public partial class Companies : Form
    {
        SqlCommands commands = new SqlCommands();
        public Companies()
        {

            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            commands.Connection();
            LoadCompanies();
            CenterToScreen();
        }

        
        private void LoadCompanies()
        {
            treeTrades.Nodes.Clear();
            DataTable dt = commands.GetData(@"select company_name, id from companies");

            foreach (DataRow dr in dt.Rows)
            {
                string companyName = dr["company_name"].ToString();
                var node = new TreeNode(companyName, 0, 0);
                treeTrades.Nodes.Add(node);
                node.Tag = dr["id"].ToString();
                LoadDepartments(node, (int)dr["id"]);
            }
        }

        public void LoadDepartments(TreeNode parent, int company_id)
        {

            DataTable dt = commands.GetData(@"select * from departments where company_id = @company_id", company_id, "company_id");

            foreach (DataRow dr in dt.Rows)
            {
                string departmentName = dr["department_name"].ToString();
                var node = new TreeNode(departmentName, 1, 1);
                parent.Nodes.Add(node);
                node.Tag = dr["id"].ToString();
                LoadEmployees(node, (int)dr["id"]);
            }
        }

        public void LoadEmployees(TreeNode parent, int department_id)
        {

            DataTable dt = commands.GetData(@"select * from employees where department_id = @department_id", department_id, "department_id");
            foreach (DataRow dr in dt.Rows)
            {
                string person = dr["first_name"].ToString() + " " + dr["last_name"].ToString();
                var node = new TreeNode(person, 2, 2);
                parent.Nodes.Add(node);
                node.Tag = dr["id"].ToString();
            }
        }

        private void AddDepartment(TreeNode selectedNode, string tableName)
        {
            try
            {
                var name = InputDemartment();
                var s = $"insert into {tableName} (department_name, company_id) values (@department_name, @company_id)";
                if (!string.IsNullOrEmpty(name))
                {
                    commands.AddData(s, (name, Convert.ToInt32(selectedNode.Tag)), ("department_name", "company_id"));
                    LoadCompanies();
                }
            }
            catch
            {
                MessageBox.Show("Ошибочное действие!");
            }
        }
        private void AddEmployees(TreeNode selectedNode, string tableName)
        {
            try
            {
                var s = $"insert into {tableName} (first_name, last_name, department_id) values (@first_name, @last_name, @department_id)";
                (string, string) person = InputEmployee();
                if (!string.IsNullOrEmpty(person.Item1) && !string.IsNullOrEmpty(person.Item2))
                {
                    commands.AddData(s, (person.Item1, person.Item2, Convert.ToInt32(selectedNode.Tag)), ("first_name", "last_name", "department_id"));
                    AddRefresh(selectedNode);
                }
            }
            catch
            {
                MessageBox.Show("Ошибочное действие!");
            }

        }
        private void AddCompanies()
        {
            try
            {
                var s = $"insert into companies (company_name) values (@company_name)";
                var name = InputDemartment();
                if (!string.IsNullOrEmpty(name))
                {
                    commands.AddData(s, name, "company_name");
                    LoadCompanies();
                }
            }
            catch
            {
                MessageBox.Show("Ошибочное действие!");
            }
            
        }
        private string InputDemartment()
        {
            var f = new InputDepartments();
            f.ShowDialog();
            return f.DepartmentName;
        }
        private (string, string) InputEmployee()
        {
            var f = new InputEmployees();
            f.ShowDialog();
            return (f.FirstName, f.LastName);
        }


        private void удалитьToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            if (treeTrades.SelectedNode != null)
            {
                var s = "delete from employees where id = @id";
                commands.DeleteData(s, Convert.ToInt32(treeTrades.SelectedNode.Tag), "id");
                try
                {
                    treeTrades.SelectedNode.Remove();
                    AddRefresh(treeTrades.SelectedNode);
                }
                catch(Exception ex) 
                {
                    MessageBox.Show(ex.Message);
                }
                
            }
        }

        private void удалитьToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (treeTrades.SelectedNode != null)
            {
                var s = "delete from departments where id = @id";
                commands.DeleteData(s, Convert.ToInt32(treeTrades.SelectedNode.Tag), "id");
                try
                {
                    treeTrades.SelectedNode.Remove();
                    RefreshData(treeTrades.SelectedNode);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                
            }
        }

        private void удалитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (treeTrades.SelectedNode != null)
            {
                var s = "delete from companies where id = @id";
                commands.DeleteData(s, Convert.ToInt32(treeTrades.SelectedNode.Tag), "id");
                try
                {
                    treeTrades.SelectedNode.Remove();
                    RefreshData(treeTrades.SelectedNode);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
               
            }
        }

        private void RefreshData(TreeNode selectedNode)
        {
            selectedNode.Nodes.Clear();
            LoadDepartments(treeTrades.SelectedNode, Convert.ToInt32(treeTrades.SelectedNode.Tag));
            LoadEmployees(treeTrades.SelectedNode, Convert.ToInt32(treeTrades.SelectedNode.Tag));
        }

        public void AddRefresh(TreeNode node)
        {
            node.Nodes.Clear();
            LoadEmployees(node, Convert.ToInt32(node.Tag));
            
        }
        public void RefreshDepartments(TreeNode node)
        {
            DataTable dt = commands.GetData(@"select department_name from departments where id = @id", Convert.ToInt32(node.Tag), "id");
            node.Text = dt.Rows[0]["department_name"].ToString();
        }
        public void RefreshEmployee(TreeNode node)
        {
            node.Nodes.Clear();
            DataTable dt = commands.GetData(@"select first_name, last_name from employees where id = @id", Convert.ToInt32(node.Tag), "id");
            node.Text = $"{dt.Rows[0]["first_name"]} {dt.Rows[0]["last_name"]}";
        }

        public void RefreshCompanies(TreeNode node)
        {
            DataTable dt = commands.GetData(@"select company_name from companies where id = @id", Convert.ToInt32(node.Tag), "id");
            node.Text = dt.Rows[0]["company_name"].ToString();
        }

        //Изменение отдела
        private void изменитьToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            var selectedNode = treeTrades.SelectedNode;
            string old_name = selectedNode.Text;
            var cmd = "update departments set department_name = @name where id = @id";
            var f = new InputDepartments();
            f.AddOldInformation(old_name);
            f.ShowDialog();
            old_name = f.DepartmentName;
            if (old_name != null)
            {
                commands.UpdateData(cmd, old_name, Convert.ToInt32(selectedNode.Tag), ("@name", "@id"));
                RefreshDepartments(selectedNode);
            }
            
        }

        //Изменение сотрудника
        private void изменитьToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            var selectedNode = treeTrades.SelectedNode;
            var old_info = selectedNode.Text.Split();
            string first_name = old_info[0];
            string last_name = old_info[1];
            var cmd = "update employees set first_name = @first_name, last_name = @last_name where id = @id";
            var f = new InputEmployees();
            f.AddOldInformation(first_name, last_name);
            f.ShowDialog();
            first_name = f.FirstName;
            last_name = f.LastName;
            commands.UpdateData(cmd, (first_name, last_name), Convert.ToInt32(selectedNode.Tag), ("@first_name","last_name", "@id"));
            RefreshEmployee(selectedNode);
        }

        //изменить компанию
        private void изменитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var selectedNode = treeTrades.SelectedNode;
            string old_name = selectedNode.Text;
            var cmd = "update companies set company_name = @name where id = @id";
            var f = new InputDepartments();
            f.AddOldInformation(old_name);
            f.ShowDialog();
            old_name = f.DepartmentName;
            if (old_name != null)
            {
                commands.UpdateData(cmd, old_name, Convert.ToInt32(selectedNode.Tag), ("@name", "@id"));
                RefreshCompanies(selectedNode);
            }
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                cmAddCompanies.Show(this, e.Location);
            }
        }
        private void добавитьToolStripMenuItem1_Click(object sender, EventArgs e)
        {

            TreeNode selectedNode = treeTrades.SelectedNode;
            AddEmployees(selectedNode, "employees");
        }

        private void добавитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TreeNode selectedNode = treeTrades.SelectedNode;
            AddDepartment(selectedNode, "departments");
        }

        private void добавитьКомпаниюToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddCompanies();
        }

        private void treeTrades_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            TreeNode selectedNode = e.Node;
            int level = selectedNode.Level;



            if (e.Button == MouseButtons.Right)
            {
                if (e.Node.Level == 0)
                {
                    treeTrades.ContextMenuStrip = cmCompanies;
                }
                else if (e.Node.Level == 1)
                {
                    treeTrades.ContextMenuStrip = cmDepartments;
                }
                else
                    treeTrades.ContextMenuStrip = cmEmployees;
            }
        }


    }

}
