namespace Lab5_CB
{
    partial class search
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.all_btn = new System.Windows.Forms.Button();
            this.insert_btn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.titleLb = new System.Windows.Forms.Label();
            this.unLb = new System.Windows.Forms.Label();
            this.unCo = new System.Windows.Forms.ComboBox();
            this.unBox = new System.Windows.Forms.TextBox();
            this.obCo = new System.Windows.Forms.ComboBox();
            this.lastBox = new System.Windows.Forms.TextBox();
            this.firstBox = new System.Windows.Forms.TextBox();
            this.idBox = new System.Windows.Forms.TextBox();
            this.putStuff = new System.Windows.Forms.DataGridView();
            this.search_btn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.putStuff)).BeginInit();
            this.SuspendLayout();
            // 
            // all_btn
            // 
            this.all_btn.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.all_btn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.all_btn.Location = new System.Drawing.Point(404, 246);
            this.all_btn.Name = "all_btn";
            this.all_btn.Size = new System.Drawing.Size(142, 25);
            this.all_btn.TabIndex = 0;
            this.all_btn.Text = "Display All";
            this.all_btn.UseVisualStyleBackColor = false;
            this.all_btn.Click += new System.EventHandler(this.all_btn_Click);
            // 
            // insert_btn
            // 
            this.insert_btn.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.insert_btn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.insert_btn.Location = new System.Drawing.Point(568, 246);
            this.insert_btn.Name = "insert_btn";
            this.insert_btn.Size = new System.Drawing.Size(142, 25);
            this.insert_btn.TabIndex = 1;
            this.insert_btn.Text = "Insert New Entry";
            this.insert_btn.UseVisualStyleBackColor = false;
            this.insert_btn.Click += new System.EventHandler(this.insert_btn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Search Parameters: ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label4.Location = new System.Drawing.Point(63, 38);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 13);
            this.label4.TabIndex = 15;
            this.label4.Text = "Type : ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label3.Location = new System.Drawing.Point(39, 117);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "Last Name :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label2.Location = new System.Drawing.Point(40, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "First Name :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label5.Location = new System.Drawing.Point(69, 65);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "ID # :";
            // 
            // titleLb
            // 
            this.titleLb.AutoSize = true;
            this.titleLb.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.titleLb.Location = new System.Drawing.Point(106, 141);
            this.titleLb.Name = "titleLb";
            this.titleLb.Size = new System.Drawing.Size(16, 13);
            this.titleLb.TabIndex = 19;
            this.titleLb.Text = "...";
            // 
            // unLb
            // 
            this.unLb.AutoSize = true;
            this.unLb.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.unLb.Location = new System.Drawing.Point(106, 191);
            this.unLb.Name = "unLb";
            this.unLb.Size = new System.Drawing.Size(16, 13);
            this.unLb.TabIndex = 18;
            this.unLb.Text = "...";
            // 
            // unCo
            // 
            this.unCo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.unCo.FormattingEnabled = true;
            this.unCo.Items.AddRange(new object[] {
            "Student",
            "Teacher",
            "Administrator"});
            this.unCo.Location = new System.Drawing.Point(109, 157);
            this.unCo.Name = "unCo";
            this.unCo.Size = new System.Drawing.Size(131, 21);
            this.unCo.TabIndex = 17;
            this.unCo.SelectedIndexChanged += new System.EventHandler(this.unCo_SelectedIndexChanged);
            // 
            // unBox
            // 
            this.unBox.Location = new System.Drawing.Point(109, 207);
            this.unBox.MaxLength = 15;
            this.unBox.Name = "unBox";
            this.unBox.Size = new System.Drawing.Size(131, 20);
            this.unBox.TabIndex = 16;
            // 
            // obCo
            // 
            this.obCo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.obCo.FormattingEnabled = true;
            this.obCo.Items.AddRange(new object[] {
            "Student",
            "Teacher",
            "Administrator"});
            this.obCo.Location = new System.Drawing.Point(109, 35);
            this.obCo.Name = "obCo";
            this.obCo.Size = new System.Drawing.Size(131, 21);
            this.obCo.TabIndex = 20;
            this.obCo.SelectedIndexChanged += new System.EventHandler(this.obCo_SelectedIndexChanged);
            // 
            // lastBox
            // 
            this.lastBox.Location = new System.Drawing.Point(109, 114);
            this.lastBox.MaxLength = 15;
            this.lastBox.Name = "lastBox";
            this.lastBox.Size = new System.Drawing.Size(131, 20);
            this.lastBox.TabIndex = 24;
            // 
            // firstBox
            // 
            this.firstBox.Location = new System.Drawing.Point(109, 88);
            this.firstBox.MaxLength = 15;
            this.firstBox.Name = "firstBox";
            this.firstBox.Size = new System.Drawing.Size(131, 20);
            this.firstBox.TabIndex = 23;
            // 
            // idBox
            // 
            this.idBox.Location = new System.Drawing.Point(109, 62);
            this.idBox.MaxLength = 5;
            this.idBox.Name = "idBox";
            this.idBox.Size = new System.Drawing.Size(131, 20);
            this.idBox.TabIndex = 22;
            this.idBox.TextChanged += new System.EventHandler(this.idBox_TextChanged);
            // 
            // putStuff
            // 
            this.putStuff.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.putStuff.Cursor = System.Windows.Forms.Cursors.Hand;
            this.putStuff.Location = new System.Drawing.Point(275, 24);
            this.putStuff.Name = "putStuff";
            this.putStuff.ReadOnly = true;
            this.putStuff.Size = new System.Drawing.Size(581, 203);
            this.putStuff.TabIndex = 25;
            this.putStuff.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.putStuff_CellDoubleClick);
            // 
            // search_btn
            // 
            this.search_btn.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.search_btn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.search_btn.Location = new System.Drawing.Point(104, 246);
            this.search_btn.Name = "search_btn";
            this.search_btn.Size = new System.Drawing.Size(142, 25);
            this.search_btn.TabIndex = 26;
            this.search_btn.Text = "Search";
            this.search_btn.UseVisualStyleBackColor = false;
            this.search_btn.Click += new System.EventHandler(this.search_btn_Click);
            // 
            // search
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(892, 311);
            this.Controls.Add(this.search_btn);
            this.Controls.Add(this.putStuff);
            this.Controls.Add(this.lastBox);
            this.Controls.Add(this.firstBox);
            this.Controls.Add(this.idBox);
            this.Controls.Add(this.obCo);
            this.Controls.Add(this.titleLb);
            this.Controls.Add(this.unLb);
            this.Controls.Add(this.unCo);
            this.Controls.Add(this.unBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.insert_btn);
            this.Controls.Add(this.all_btn);
            this.ForeColor = System.Drawing.Color.Red;
            this.Name = "search";
            this.Text = "search";
            this.Load += new System.EventHandler(this.search_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.putStuff)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button all_btn;
        private System.Windows.Forms.Button insert_btn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label titleLb;
        private System.Windows.Forms.Label unLb;
        private System.Windows.Forms.ComboBox unCo;
        private System.Windows.Forms.TextBox unBox;
        private System.Windows.Forms.ComboBox obCo;
        private System.Windows.Forms.TextBox lastBox;
        private System.Windows.Forms.TextBox firstBox;
        private System.Windows.Forms.TextBox idBox;
        private System.Windows.Forms.DataGridView putStuff;
        private System.Windows.Forms.Button search_btn;
    }
}