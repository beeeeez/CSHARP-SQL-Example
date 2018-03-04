namespace Lab5_CB
{
    partial class Form1
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
            this.obCo = new System.Windows.Forms.ComboBox();
            this.idBox = new System.Windows.Forms.TextBox();
            this.firstBox = new System.Windows.Forms.TextBox();
            this.lastBox = new System.Windows.Forms.TextBox();
            this.unBox = new System.Windows.Forms.TextBox();
            this.unCo = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.unLb = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.outLb = new System.Windows.Forms.Label();
            this.titleLb = new System.Windows.Forms.Label();
            this.search_btn = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // obCo
            // 
            this.obCo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.obCo.FormattingEnabled = true;
            this.obCo.Items.AddRange(new object[] {
            "Student",
            "Teacher",
            "Administrator"});
            this.obCo.Location = new System.Drawing.Point(86, 26);
            this.obCo.Name = "obCo";
            this.obCo.Size = new System.Drawing.Size(131, 21);
            this.obCo.TabIndex = 0;
            this.obCo.SelectedIndexChanged += new System.EventHandler(this.objectTypeCombo_SelectedIndexChanged);
            // 
            // idBox
            // 
            this.idBox.Location = new System.Drawing.Point(86, 57);
            this.idBox.MaxLength = 5;
            this.idBox.Name = "idBox";
            this.idBox.Size = new System.Drawing.Size(131, 20);
            this.idBox.TabIndex = 1;
            // 
            // firstBox
            // 
            this.firstBox.Location = new System.Drawing.Point(86, 83);
            this.firstBox.MaxLength = 15;
            this.firstBox.Name = "firstBox";
            this.firstBox.Size = new System.Drawing.Size(131, 20);
            this.firstBox.TabIndex = 2;
            // 
            // lastBox
            // 
            this.lastBox.Location = new System.Drawing.Point(86, 109);
            this.lastBox.MaxLength = 15;
            this.lastBox.Name = "lastBox";
            this.lastBox.Size = new System.Drawing.Size(131, 20);
            this.lastBox.TabIndex = 3;
            // 
            // unBox
            // 
            this.unBox.Location = new System.Drawing.Point(86, 204);
            this.unBox.MaxLength = 15;
            this.unBox.Name = "unBox";
            this.unBox.Size = new System.Drawing.Size(131, 20);
            this.unBox.TabIndex = 4;
            // 
            // unCo
            // 
            this.unCo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.unCo.FormattingEnabled = true;
            this.unCo.Items.AddRange(new object[] {
            "Student",
            "Teacher",
            "Administrator"});
            this.unCo.Location = new System.Drawing.Point(86, 154);
            this.unCo.Name = "unCo";
            this.unCo.Size = new System.Drawing.Size(131, 21);
            this.unCo.TabIndex = 5;
            this.unCo.SelectedIndexChanged += new System.EventHandler(this.unCo_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label1.Location = new System.Drawing.Point(46, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "ID # :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label2.Location = new System.Drawing.Point(17, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "First Name :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label3.Location = new System.Drawing.Point(17, 112);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Last Name :";
            // 
            // unLb
            // 
            this.unLb.AutoSize = true;
            this.unLb.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.unLb.Location = new System.Drawing.Point(83, 188);
            this.unLb.Name = "unLb";
            this.unLb.Size = new System.Drawing.Size(16, 13);
            this.unLb.TabIndex = 9;
            this.unLb.Text = "...";
            // 
            // button1
            // 
            this.button1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button1.Location = new System.Drawing.Point(38, 245);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(197, 34);
            this.button1.TabIndex = 10;
            this.button1.Text = "Create a database entry.";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label4.Location = new System.Drawing.Point(46, 29);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Type : ";
            // 
            // outLb
            // 
            this.outLb.AutoSize = true;
            this.outLb.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F);
            this.outLb.Location = new System.Drawing.Point(17, 327);
            this.outLb.Name = "outLb";
            this.outLb.Size = new System.Drawing.Size(0, 15);
            this.outLb.TabIndex = 12;
            // 
            // titleLb
            // 
            this.titleLb.AutoSize = true;
            this.titleLb.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.titleLb.Location = new System.Drawing.Point(83, 138);
            this.titleLb.Name = "titleLb";
            this.titleLb.Size = new System.Drawing.Size(16, 13);
            this.titleLb.TabIndex = 13;
            this.titleLb.Text = "...";
            // 
            // search_btn
            // 
            this.search_btn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.search_btn.Location = new System.Drawing.Point(38, 285);
            this.search_btn.Name = "search_btn";
            this.search_btn.Size = new System.Drawing.Size(197, 32);
            this.search_btn.TabIndex = 15;
            this.search_btn.Text = "Search the database.";
            this.search_btn.UseVisualStyleBackColor = true;
            this.search_btn.Click += new System.EventHandler(this.search_btn_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Lab5_CB.Properties.Resources.willie4;
            this.pictureBox1.Location = new System.Drawing.Point(304, 21);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(394, 396);
            this.pictureBox1.TabIndex = 14;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(715, 499);
            this.Controls.Add(this.search_btn);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.titleLb);
            this.Controls.Add(this.outLb);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.unLb);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.unCo);
            this.Controls.Add(this.unBox);
            this.Controls.Add(this.lastBox);
            this.Controls.Add(this.firstBox);
            this.Controls.Add(this.idBox);
            this.Controls.Add(this.obCo);
            this.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox obCo;
        private System.Windows.Forms.TextBox idBox;
        private System.Windows.Forms.TextBox firstBox;
        private System.Windows.Forms.TextBox lastBox;
        private System.Windows.Forms.TextBox unBox;
        private System.Windows.Forms.ComboBox unCo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label unLb;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label outLb;
        private System.Windows.Forms.Label titleLb;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button search_btn;
    }
}

