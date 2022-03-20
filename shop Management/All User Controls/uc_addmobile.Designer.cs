namespace shop_Management.All_User_Controls
{
    partial class uc_addmobile
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(uc_addmobile));
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_company = new Guna.UI2.WinForms.Guna2TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_model = new Guna.UI2.WinForms.Guna2TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_ram = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_internal = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_external = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_displau = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txt_rearC = new Guna.UI2.WinForms.Guna2ComboBox();
            this.txt_frontC = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txt_fingerprint = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txt_sim = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txt_network = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.btn_addmobile = new Guna.UI2.WinForms.Guna2Button();
            this.txt_price = new Guna.UI2.WinForms.Guna2TextBox();
            this.btn_reset = new Guna.UI2.WinForms.Guna2Button();
            this.SuspendLayout();
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.TargetControl = this;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Image = ((System.Drawing.Image)(resources.GetObject("label1.Image")));
            this.label1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label1.Location = new System.Drawing.Point(58, 20);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(436, 75);
            this.label1.TabIndex = 0;
            this.label1.Text = "New Phone Record";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(46, 149);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(135, 32);
            this.label3.TabIndex = 1;
            this.label3.Text = "Company";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            this.label3.Enter += new System.EventHandler(this.label3_Enter);
            // 
            // txt_company
            // 
            this.txt_company.BorderColor = System.Drawing.Color.Black;
            this.txt_company.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_company.DefaultText = "";
            this.txt_company.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_company.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_company.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_company.DisabledState.Parent = this.txt_company;
            this.txt_company.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_company.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_company.FocusedState.Parent = this.txt_company;
            this.txt_company.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_company.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_company.HoverState.Parent = this.txt_company;
            this.txt_company.Location = new System.Drawing.Point(49, 203);
            this.txt_company.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.txt_company.Name = "txt_company";
            this.txt_company.PasswordChar = '\0';
            this.txt_company.PlaceholderText = "";
            this.txt_company.SelectedText = "";
            this.txt_company.ShadowDecoration.Parent = this.txt_company;
            this.txt_company.Size = new System.Drawing.Size(422, 36);
            this.txt_company.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.txt_company.TabIndex = 3;
            this.txt_company.TextChanged += new System.EventHandler(this.guna2TextBox3_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(46, 250);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(174, 32);
            this.label2.TabIndex = 1;
            this.label2.Text = "Model Name";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // txt_model
            // 
            this.txt_model.BorderColor = System.Drawing.Color.Black;
            this.txt_model.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_model.DefaultText = "";
            this.txt_model.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_model.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_model.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_model.DisabledState.Parent = this.txt_model;
            this.txt_model.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_model.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_model.FocusedState.Parent = this.txt_model;
            this.txt_model.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_model.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_model.HoverState.Parent = this.txt_model;
            this.txt_model.Location = new System.Drawing.Point(49, 305);
            this.txt_model.Margin = new System.Windows.Forms.Padding(9, 10, 9, 10);
            this.txt_model.Name = "txt_model";
            this.txt_model.PasswordChar = '\0';
            this.txt_model.PlaceholderText = "";
            this.txt_model.SelectedText = "";
            this.txt_model.ShadowDecoration.Parent = this.txt_model;
            this.txt_model.Size = new System.Drawing.Size(422, 41);
            this.txt_model.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.txt_model.TabIndex = 3;
            this.txt_model.TextChanged += new System.EventHandler(this.guna2TextBox1_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(46, 368);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 32);
            this.label4.TabIndex = 1;
            this.label4.Text = "RAM";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // txt_ram
            // 
            this.txt_ram.BackColor = System.Drawing.Color.Transparent;
            this.txt_ram.BorderColor = System.Drawing.Color.Black;
            this.txt_ram.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.txt_ram.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.txt_ram.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_ram.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_ram.FocusedState.Parent = this.txt_ram;
            this.txt_ram.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_ram.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.txt_ram.HoverState.Parent = this.txt_ram;
            this.txt_ram.ItemHeight = 30;
            this.txt_ram.Items.AddRange(new object[] {
            "2 GB",
            "3 GB",
            "4 GB",
            "6 GB",
            "8 Gb",
            "16 GB"});
            this.txt_ram.ItemsAppearance.Parent = this.txt_ram;
            this.txt_ram.Location = new System.Drawing.Point(51, 410);
            this.txt_ram.Name = "txt_ram";
            this.txt_ram.ShadowDecoration.Parent = this.txt_ram;
            this.txt_ram.Size = new System.Drawing.Size(422, 36);
            this.txt_ram.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.txt_ram.TabIndex = 4;
            this.txt_ram.SelectedIndexChanged += new System.EventHandler(this.guna2ComboBox1_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(46, 458);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(216, 32);
            this.label5.TabIndex = 1;
            this.label5.Text = "Internal Storage";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // txt_internal
            // 
            this.txt_internal.BackColor = System.Drawing.Color.Transparent;
            this.txt_internal.BorderColor = System.Drawing.Color.Black;
            this.txt_internal.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.txt_internal.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.txt_internal.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_internal.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_internal.FocusedState.Parent = this.txt_internal;
            this.txt_internal.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_internal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.txt_internal.HoverState.Parent = this.txt_internal;
            this.txt_internal.ItemHeight = 30;
            this.txt_internal.Items.AddRange(new object[] {
            "16 GB",
            "32 GB",
            "64 GB",
            "128 GB",
            "256 GB",
            "512 GB"});
            this.txt_internal.ItemsAppearance.Parent = this.txt_internal;
            this.txt_internal.Location = new System.Drawing.Point(52, 500);
            this.txt_internal.Name = "txt_internal";
            this.txt_internal.ShadowDecoration.Parent = this.txt_internal;
            this.txt_internal.Size = new System.Drawing.Size(422, 36);
            this.txt_internal.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.txt_internal.TabIndex = 4;
            this.txt_internal.SelectedIndexChanged += new System.EventHandler(this.guna2ComboBox2_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(46, 551);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(274, 32);
            this.label6.TabIndex = 1;
            this.label6.Text = "Expandable Memory";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // txt_external
            // 
            this.txt_external.BackColor = System.Drawing.Color.Transparent;
            this.txt_external.BorderColor = System.Drawing.Color.Black;
            this.txt_external.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.txt_external.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.txt_external.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_external.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_external.FocusedState.Parent = this.txt_external;
            this.txt_external.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_external.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.txt_external.HoverState.Parent = this.txt_external;
            this.txt_external.ItemHeight = 30;
            this.txt_external.Items.AddRange(new object[] {
            "16 GB",
            "32 GB",
            "64 GB",
            "128 GB",
            "256 GB",
            "512 GB"});
            this.txt_external.ItemsAppearance.Parent = this.txt_external;
            this.txt_external.Location = new System.Drawing.Point(51, 605);
            this.txt_external.Name = "txt_external";
            this.txt_external.ShadowDecoration.Parent = this.txt_external;
            this.txt_external.Size = new System.Drawing.Size(422, 36);
            this.txt_external.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.txt_external.TabIndex = 4;
            this.txt_external.SelectedIndexChanged += new System.EventHandler(this.guna2ComboBox3_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(46, 658);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(108, 32);
            this.label7.TabIndex = 1;
            this.label7.Text = "Display";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // txt_displau
            // 
            this.txt_displau.BackColor = System.Drawing.Color.Transparent;
            this.txt_displau.BorderColor = System.Drawing.Color.Black;
            this.txt_displau.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.txt_displau.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.txt_displau.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_displau.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_displau.FocusedState.Parent = this.txt_displau;
            this.txt_displau.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.txt_displau.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.txt_displau.HoverState.Parent = this.txt_displau;
            this.txt_displau.ItemHeight = 30;
            this.txt_displau.Items.AddRange(new object[] {
            "5.0 inches",
            "5.5 inches",
            "6.0 inches",
            "7.0 inches",
            "7.5 inches"});
            this.txt_displau.ItemsAppearance.Parent = this.txt_displau;
            this.txt_displau.Location = new System.Drawing.Point(52, 700);
            this.txt_displau.Name = "txt_displau";
            this.txt_displau.ShadowDecoration.Parent = this.txt_displau;
            this.txt_displau.Size = new System.Drawing.Size(422, 36);
            this.txt_displau.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.txt_displau.TabIndex = 4;
            this.txt_displau.SelectedIndexChanged += new System.EventHandler(this.guna2ComboBox4_SelectedIndexChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(582, 149);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(182, 32);
            this.label8.TabIndex = 1;
            this.label8.Text = "Rear Camera";
            this.label8.Click += new System.EventHandler(this.label6_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(582, 247);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(187, 32);
            this.label9.TabIndex = 1;
            this.label9.Text = "Front Camera";
            this.label9.Click += new System.EventHandler(this.label7_Click);
            // 
            // txt_rearC
            // 
            this.txt_rearC.BackColor = System.Drawing.Color.Transparent;
            this.txt_rearC.BorderColor = System.Drawing.Color.Black;
            this.txt_rearC.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.txt_rearC.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.txt_rearC.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_rearC.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_rearC.FocusedState.Parent = this.txt_rearC;
            this.txt_rearC.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.txt_rearC.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.txt_rearC.HoverState.Parent = this.txt_rearC;
            this.txt_rearC.ItemHeight = 30;
            this.txt_rearC.Items.AddRange(new object[] {
            "8 MP",
            "12 MP",
            "14 MP",
            "16 MP",
            "18 MP",
            "20 MP",
            "24 MP",
            "36 MP",
            "48 MP"});
            this.txt_rearC.ItemsAppearance.Parent = this.txt_rearC;
            this.txt_rearC.Location = new System.Drawing.Point(587, 197);
            this.txt_rearC.Name = "txt_rearC";
            this.txt_rearC.ShadowDecoration.Parent = this.txt_rearC;
            this.txt_rearC.Size = new System.Drawing.Size(422, 36);
            this.txt_rearC.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.txt_rearC.TabIndex = 4;
            this.txt_rearC.SelectedIndexChanged += new System.EventHandler(this.guna2ComboBox3_SelectedIndexChanged);
            // 
            // txt_frontC
            // 
            this.txt_frontC.BackColor = System.Drawing.Color.Transparent;
            this.txt_frontC.BorderColor = System.Drawing.Color.Black;
            this.txt_frontC.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.txt_frontC.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.txt_frontC.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_frontC.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_frontC.FocusedState.Parent = this.txt_frontC;
            this.txt_frontC.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.txt_frontC.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.txt_frontC.HoverState.Parent = this.txt_frontC;
            this.txt_frontC.ItemHeight = 30;
            this.txt_frontC.Items.AddRange(new object[] {
            "8 MP",
            "12 MP",
            "14 MP",
            "16 MP",
            "18 MP",
            "20 MP",
            "24 MP",
            "36 MP",
            "48 MP"});
            this.txt_frontC.ItemsAppearance.Parent = this.txt_frontC;
            this.txt_frontC.Location = new System.Drawing.Point(587, 305);
            this.txt_frontC.Name = "txt_frontC";
            this.txt_frontC.ShadowDecoration.Parent = this.txt_frontC;
            this.txt_frontC.Size = new System.Drawing.Size(422, 36);
            this.txt_frontC.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.txt_frontC.TabIndex = 4;
            this.txt_frontC.SelectedIndexChanged += new System.EventHandler(this.guna2ComboBox4_SelectedIndexChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(582, 362);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(248, 32);
            this.label10.TabIndex = 1;
            this.label10.Text = "Fingerprint Sensor";
            this.label10.Click += new System.EventHandler(this.label7_Click);
            // 
            // txt_fingerprint
            // 
            this.txt_fingerprint.BackColor = System.Drawing.Color.Transparent;
            this.txt_fingerprint.BorderColor = System.Drawing.Color.Black;
            this.txt_fingerprint.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.txt_fingerprint.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.txt_fingerprint.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_fingerprint.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_fingerprint.FocusedState.Parent = this.txt_fingerprint;
            this.txt_fingerprint.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_fingerprint.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.txt_fingerprint.HoverState.Parent = this.txt_fingerprint;
            this.txt_fingerprint.ItemHeight = 30;
            this.txt_fingerprint.Items.AddRange(new object[] {
            "Yes",
            "No"});
            this.txt_fingerprint.ItemsAppearance.Parent = this.txt_fingerprint;
            this.txt_fingerprint.Location = new System.Drawing.Point(587, 410);
            this.txt_fingerprint.Name = "txt_fingerprint";
            this.txt_fingerprint.ShadowDecoration.Parent = this.txt_fingerprint;
            this.txt_fingerprint.Size = new System.Drawing.Size(422, 36);
            this.txt_fingerprint.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.txt_fingerprint.TabIndex = 4;
            this.txt_fingerprint.SelectedIndexChanged += new System.EventHandler(this.guna2ComboBox4_SelectedIndexChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(582, 458);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(133, 32);
            this.label11.TabIndex = 1;
            this.label11.Text = "Sim Type";
            this.label11.Click += new System.EventHandler(this.label7_Click);
            // 
            // txt_sim
            // 
            this.txt_sim.BackColor = System.Drawing.Color.Transparent;
            this.txt_sim.BorderColor = System.Drawing.Color.Black;
            this.txt_sim.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.txt_sim.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.txt_sim.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_sim.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_sim.FocusedState.Parent = this.txt_sim;
            this.txt_sim.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_sim.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.txt_sim.HoverState.Parent = this.txt_sim;
            this.txt_sim.ItemHeight = 30;
            this.txt_sim.Items.AddRange(new object[] {
            "One sim",
            "Dual sim",
            "Triple sim"});
            this.txt_sim.ItemsAppearance.Parent = this.txt_sim;
            this.txt_sim.Location = new System.Drawing.Point(588, 500);
            this.txt_sim.Name = "txt_sim";
            this.txt_sim.ShadowDecoration.Parent = this.txt_sim;
            this.txt_sim.Size = new System.Drawing.Size(422, 36);
            this.txt_sim.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.txt_sim.TabIndex = 4;
            this.txt_sim.SelectedIndexChanged += new System.EventHandler(this.guna2ComboBox4_SelectedIndexChanged);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(582, 551);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(117, 32);
            this.label12.TabIndex = 1;
            this.label12.Text = "Network";
            this.label12.Click += new System.EventHandler(this.label7_Click);
            // 
            // txt_network
            // 
            this.txt_network.BackColor = System.Drawing.Color.Transparent;
            this.txt_network.BorderColor = System.Drawing.Color.Black;
            this.txt_network.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.txt_network.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.txt_network.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_network.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_network.FocusedState.Parent = this.txt_network;
            this.txt_network.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_network.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.txt_network.HoverState.Parent = this.txt_network;
            this.txt_network.ItemHeight = 30;
            this.txt_network.Items.AddRange(new object[] {
            "2G",
            "3G",
            "2G,3G & 4G "});
            this.txt_network.ItemsAppearance.Parent = this.txt_network;
            this.txt_network.Location = new System.Drawing.Point(587, 605);
            this.txt_network.Name = "txt_network";
            this.txt_network.ShadowDecoration.Parent = this.txt_network;
            this.txt_network.Size = new System.Drawing.Size(422, 36);
            this.txt_network.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.txt_network.TabIndex = 4;
            this.txt_network.SelectedIndexChanged += new System.EventHandler(this.guna2ComboBox4_SelectedIndexChanged);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(582, 656);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(79, 32);
            this.label13.TabIndex = 1;
            this.label13.Text = "Price";
            this.label13.Click += new System.EventHandler(this.label7_Click);
            // 
            // btn_addmobile
            // 
            this.btn_addmobile.BorderRadius = 20;
            this.btn_addmobile.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            this.btn_addmobile.BorderThickness = 1;
            this.btn_addmobile.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btn_addmobile.CheckedState.FillColor = System.Drawing.Color.Black;
            this.btn_addmobile.CheckedState.ForeColor = System.Drawing.Color.White;
            this.btn_addmobile.CheckedState.Parent = this.btn_addmobile;
            this.btn_addmobile.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_addmobile.CustomImages.Parent = this.btn_addmobile;
            this.btn_addmobile.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(221)))));
            this.btn_addmobile.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_addmobile.ForeColor = System.Drawing.Color.Black;
            this.btn_addmobile.HoverState.Parent = this.btn_addmobile;
            this.btn_addmobile.Location = new System.Drawing.Point(782, 754);
            this.btn_addmobile.Name = "btn_addmobile";
            this.btn_addmobile.ShadowDecoration.Parent = this.btn_addmobile;
            this.btn_addmobile.Size = new System.Drawing.Size(155, 45);
            this.btn_addmobile.TabIndex = 5;
            this.btn_addmobile.Text = "Add Mobile";
            this.btn_addmobile.Click += new System.EventHandler(this.guna2Button1_Click);
            // 
            // txt_price
            // 
            this.txt_price.BorderColor = System.Drawing.Color.Black;
            this.txt_price.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_price.DefaultText = "";
            this.txt_price.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_price.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_price.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_price.DisabledState.Parent = this.txt_price;
            this.txt_price.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_price.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_price.FocusedState.Parent = this.txt_price;
            this.txt_price.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_price.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_price.HoverState.Parent = this.txt_price;
            this.txt_price.Location = new System.Drawing.Point(588, 700);
            this.txt_price.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.txt_price.Name = "txt_price";
            this.txt_price.PasswordChar = '\0';
            this.txt_price.PlaceholderText = "";
            this.txt_price.SelectedText = "";
            this.txt_price.ShadowDecoration.Parent = this.txt_price;
            this.txt_price.Size = new System.Drawing.Size(422, 36);
            this.txt_price.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.txt_price.TabIndex = 3;
            this.txt_price.TextChanged += new System.EventHandler(this.guna2TextBox3_TextChanged);
            // 
            // btn_reset
            // 
            this.btn_reset.BorderRadius = 20;
            this.btn_reset.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            this.btn_reset.BorderThickness = 1;
            this.btn_reset.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btn_reset.CheckedState.FillColor = System.Drawing.Color.Black;
            this.btn_reset.CheckedState.ForeColor = System.Drawing.Color.White;
            this.btn_reset.CheckedState.Parent = this.btn_reset;
            this.btn_reset.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_reset.CustomImages.Parent = this.btn_reset;
            this.btn_reset.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(221)))));
            this.btn_reset.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_reset.ForeColor = System.Drawing.Color.Black;
            this.btn_reset.HoverState.Parent = this.btn_reset;
            this.btn_reset.Location = new System.Drawing.Point(588, 754);
            this.btn_reset.Name = "btn_reset";
            this.btn_reset.ShadowDecoration.Parent = this.btn_reset;
            this.btn_reset.Size = new System.Drawing.Size(155, 45);
            this.btn_reset.TabIndex = 5;
            this.btn_reset.Text = "Reset";
            this.btn_reset.Click += new System.EventHandler(this.guna2Button2_Click);
            // 
            // uc_addmobile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.btn_reset);
            this.Controls.Add(this.btn_addmobile);
            this.Controls.Add(this.txt_network);
            this.Controls.Add(this.txt_sim);
            this.Controls.Add(this.txt_fingerprint);
            this.Controls.Add(this.txt_frontC);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.txt_displau);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.txt_rearC);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txt_external);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txt_internal);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txt_ram);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txt_model);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_price);
            this.Controls.Add(this.txt_company);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "uc_addmobile";
            this.Size = new System.Drawing.Size(1029, 912);
            this.Load += new System.EventHandler(this.uc_addmobile_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2TextBox txt_company;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2ComboBox txt_ram;
        private Guna.UI2.WinForms.Guna2TextBox txt_model;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2ComboBox txt_displau;
        private Guna.UI2.WinForms.Guna2ComboBox txt_external;
        private Guna.UI2.WinForms.Guna2ComboBox txt_internal;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private Guna.UI2.WinForms.Guna2ComboBox txt_sim;
        private Guna.UI2.WinForms.Guna2ComboBox txt_fingerprint;
        private Guna.UI2.WinForms.Guna2ComboBox txt_frontC;
        private Guna.UI2.WinForms.Guna2ComboBox txt_rearC;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private Guna.UI2.WinForms.Guna2ComboBox txt_network;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private Guna.UI2.WinForms.Guna2Button btn_addmobile;
        private Guna.UI2.WinForms.Guna2TextBox txt_price;
        private Guna.UI2.WinForms.Guna2Button btn_reset;
    }
}
