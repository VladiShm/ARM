namespace ARM
{
    partial class Companies
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Companies));
            this.treeTrades = new System.Windows.Forms.TreeView();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.cmCompanies = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.добавитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.удалитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.изменитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cmDepartments = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.добавитьToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.изменитьToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.удалитьToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.cmEmployees = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.изменитьToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.удалитьToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.cmAddCompanies = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.добавитьКомпаниюToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cmCompanies.SuspendLayout();
            this.cmDepartments.SuspendLayout();
            this.cmEmployees.SuspendLayout();
            this.cmAddCompanies.SuspendLayout();
            this.SuspendLayout();
            // 
            // treeTrades
            // 
            this.treeTrades.BackColor = System.Drawing.Color.SeaShell;
            this.treeTrades.Font = new System.Drawing.Font("Gadugi", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.treeTrades.ImageIndex = 0;
            this.treeTrades.ImageList = this.imageList1;
            this.treeTrades.Location = new System.Drawing.Point(12, 12);
            this.treeTrades.Name = "treeTrades";
            this.treeTrades.SelectedImageIndex = 0;
            this.treeTrades.Size = new System.Drawing.Size(453, 769);
            this.treeTrades.TabIndex = 1;
            this.treeTrades.NodeMouseClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.treeTrades_NodeMouseClick);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "Hexagon Synchronize.png");
            this.imageList1.Images.SetKeyName(1, "Restart.png");
            this.imageList1.Images.SetKeyName(2, "User Male.png");
            // 
            // cmCompanies
            // 
            this.cmCompanies.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.cmCompanies.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.добавитьToolStripMenuItem,
            this.удалитьToolStripMenuItem,
            this.изменитьToolStripMenuItem});
            this.cmCompanies.Name = "cmCompanies";
            this.cmCompanies.Size = new System.Drawing.Size(211, 104);
            // 
            // добавитьToolStripMenuItem
            // 
            this.добавитьToolStripMenuItem.Name = "добавитьToolStripMenuItem";
            this.добавитьToolStripMenuItem.Size = new System.Drawing.Size(210, 24);
            this.добавитьToolStripMenuItem.Text = "Добавить";
            this.добавитьToolStripMenuItem.Click += new System.EventHandler(this.добавитьToolStripMenuItem_Click);
            // 
            // удалитьToolStripMenuItem
            // 
            this.удалитьToolStripMenuItem.Name = "удалитьToolStripMenuItem";
            this.удалитьToolStripMenuItem.Size = new System.Drawing.Size(210, 24);
            this.удалитьToolStripMenuItem.Text = "Удалить";
            this.удалитьToolStripMenuItem.Click += new System.EventHandler(this.удалитьToolStripMenuItem_Click);
            // 
            // изменитьToolStripMenuItem
            // 
            this.изменитьToolStripMenuItem.Name = "изменитьToolStripMenuItem";
            this.изменитьToolStripMenuItem.Size = new System.Drawing.Size(210, 24);
            this.изменитьToolStripMenuItem.Text = "Изменить";
            this.изменитьToolStripMenuItem.Click += new System.EventHandler(this.изменитьToolStripMenuItem_Click);
            // 
            // cmDepartments
            // 
            this.cmDepartments.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.cmDepartments.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.добавитьToolStripMenuItem1,
            this.изменитьToolStripMenuItem1,
            this.удалитьToolStripMenuItem1});
            this.cmDepartments.Name = "cmDepartments";
            this.cmDepartments.Size = new System.Drawing.Size(148, 76);
            // 
            // добавитьToolStripMenuItem1
            // 
            this.добавитьToolStripMenuItem1.Name = "добавитьToolStripMenuItem1";
            this.добавитьToolStripMenuItem1.Size = new System.Drawing.Size(147, 24);
            this.добавитьToolStripMenuItem1.Text = "Добавить";
            this.добавитьToolStripMenuItem1.Click += new System.EventHandler(this.добавитьToolStripMenuItem1_Click);
            // 
            // изменитьToolStripMenuItem1
            // 
            this.изменитьToolStripMenuItem1.Name = "изменитьToolStripMenuItem1";
            this.изменитьToolStripMenuItem1.Size = new System.Drawing.Size(147, 24);
            this.изменитьToolStripMenuItem1.Text = "Изменить";
            this.изменитьToolStripMenuItem1.Click += new System.EventHandler(this.изменитьToolStripMenuItem1_Click);
            // 
            // удалитьToolStripMenuItem1
            // 
            this.удалитьToolStripMenuItem1.Name = "удалитьToolStripMenuItem1";
            this.удалитьToolStripMenuItem1.Size = new System.Drawing.Size(147, 24);
            this.удалитьToolStripMenuItem1.Text = "Удалить";
            this.удалитьToolStripMenuItem1.Click += new System.EventHandler(this.удалитьToolStripMenuItem1_Click);
            // 
            // cmEmployees
            // 
            this.cmEmployees.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.cmEmployees.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.изменитьToolStripMenuItem2,
            this.удалитьToolStripMenuItem2});
            this.cmEmployees.Name = "contextMenuStrip1";
            this.cmEmployees.Size = new System.Drawing.Size(148, 52);
            // 
            // изменитьToolStripMenuItem2
            // 
            this.изменитьToolStripMenuItem2.Name = "изменитьToolStripMenuItem2";
            this.изменитьToolStripMenuItem2.Size = new System.Drawing.Size(147, 24);
            this.изменитьToolStripMenuItem2.Text = "Изменить";
            this.изменитьToolStripMenuItem2.Click += new System.EventHandler(this.изменитьToolStripMenuItem2_Click);
            // 
            // удалитьToolStripMenuItem2
            // 
            this.удалитьToolStripMenuItem2.Name = "удалитьToolStripMenuItem2";
            this.удалитьToolStripMenuItem2.Size = new System.Drawing.Size(147, 24);
            this.удалитьToolStripMenuItem2.Text = "Удалить";
            this.удалитьToolStripMenuItem2.Click += new System.EventHandler(this.удалитьToolStripMenuItem2_Click);
            // 
            // cmAddCompanies
            // 
            this.cmAddCompanies.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.cmAddCompanies.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.добавитьКомпаниюToolStripMenuItem});
            this.cmAddCompanies.Name = "cmAddCompanies";
            this.cmAddCompanies.Size = new System.Drawing.Size(224, 28);
            // 
            // добавитьКомпаниюToolStripMenuItem
            // 
            this.добавитьКомпаниюToolStripMenuItem.Name = "добавитьКомпаниюToolStripMenuItem";
            this.добавитьКомпаниюToolStripMenuItem.Size = new System.Drawing.Size(223, 24);
            this.добавитьКомпаниюToolStripMenuItem.Text = "Добавить компанию";
            this.добавитьКомпаниюToolStripMenuItem.Click += new System.EventHandler(this.добавитьКомпаниюToolStripMenuItem_Click);
            // 
            // Companies
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SeaShell;
            this.ClientSize = new System.Drawing.Size(924, 793);
            this.Controls.Add(this.treeTrades);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Companies";
            this.Text = "Companies";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            this.cmCompanies.ResumeLayout(false);
            this.cmDepartments.ResumeLayout(false);
            this.cmEmployees.ResumeLayout(false);
            this.cmAddCompanies.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TreeView treeTrades;
        private System.Windows.Forms.ContextMenuStrip cmCompanies;
        private System.Windows.Forms.ToolStripMenuItem добавитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem удалитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem изменитьToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip cmDepartments;
        private System.Windows.Forms.ToolStripMenuItem добавитьToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem изменитьToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem удалитьToolStripMenuItem1;
        private System.Windows.Forms.ContextMenuStrip cmEmployees;
        private System.Windows.Forms.ToolStripMenuItem изменитьToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem удалитьToolStripMenuItem2;
        private System.Windows.Forms.ContextMenuStrip cmAddCompanies;
        private System.Windows.Forms.ToolStripMenuItem добавитьКомпаниюToolStripMenuItem;
        private System.Windows.Forms.ImageList imageList1;
    }
}

