namespace Lab5_CB
{
    partial class update
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
            this.titleLb = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.unLb = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.unCo = new System.Windows.Forms.ComboBox();
            this.unBox = new System.Windows.Forms.TextBox();
            this.lastBox = new System.Windows.Forms.TextBox();
            this.firstBox = new System.Windows.Forms.TextBox();
            this.idBox = new System.Windows.Forms.TextBox();
            this.obCo = new System.Windows.Forms.ComboBox();
            this.update_btn = new System.Windows.Forms.Button();
            this.cancel_btn = new System.Windows.Forms.Button();
            this.oldBox = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.outLb = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // titleLb
            // 
            this.titleLb.AutoSize = true;
            this.titleLb.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.titleLb.Location = new System.Drawing.Point(82, 164);
            this.titleLb.Name = "titleLb";
            this.titleLb.Size = new System.Drawing.Size(16, 13);
            this.titleLb.TabIndex = 25;
            this.titleLb.Text = "...";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label4.Location = new System.Drawing.Point(45, 55);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 13);
            this.label4.TabIndex = 24;
            this.label4.Text = "Type : ";
            // 
            // unLb
            // 
            this.unLb.AutoSize = true;
            this.unLb.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.unLb.Location = new System.Drawing.Point(82, 214);
            this.unLb.Name = "unLb";
            this.unLb.Size = new System.Drawing.Size(16, 13);
            this.unLb.TabIndex = 23;
            this.unLb.Text = "...";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label3.Location = new System.Drawing.Point(16, 138);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 13);
            this.label3.TabIndex = 22;
            this.label3.Text = "Last Name :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label2.Location = new System.Drawing.Point(16, 112);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 21;
            this.label2.Text = "First Name :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label1.Location = new System.Drawing.Point(45, 86);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 20;
            this.label1.Text = "ID # :";
            // 
            // unCo
            // 
            this.unCo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.unCo.FormattingEnabled = true;
            this.unCo.Items.AddRange(new object[] {
            "Student",
            "Teacher",
            "Administrator"});
            this.unCo.Location = new System.Drawing.Point(85, 180);
            this.unCo.Name = "unCo";
            this.unCo.Size = new System.Drawing.Size(131, 21);
            this.unCo.TabIndex = 19;
            this.unCo.SelectedIndexChanged += new System.EventHandler(this.unCo_SelectedIndexChanged);
            // 
            // unBox
            // 
            this.unBox.Location = new System.Drawing.Point(85, 230);
            this.unBox.MaxLength = 15;
            this.unBox.Name = "unBox";
            this.unBox.Size = new System.Drawing.Size(131, 20);
            this.unBox.TabIndex = 18;
            // 
            // lastBox
            // 
            this.lastBox.Location = new System.Drawing.Point(85, 135);
            this.lastBox.MaxLength = 15;
            this.lastBox.Name = "lastBox";
            this.lastBox.Size = new System.Drawing.Size(131, 20);
            this.lastBox.TabIndex = 17;
            // 
            // firstBox
            // 
            this.firstBox.Location = new System.Drawing.Point(85, 109);
            this.firstBox.MaxLength = 15;
            this.firstBox.Name = "firstBox";
            this.firstBox.Size = new System.Drawing.Size(131, 20);
            this.firstBox.TabIndex = 16;
            // 
            // idBox
            // 
            this.idBox.Location = new System.Drawing.Point(85, 83);
            this.idBox.MaxLength = 5;
            this.idBox.Name = "idBox";
            this.idBox.Size = new System.Drawing.Size(131, 20);
            this.idBox.TabIndex = 15;
            // 
            // obCo
            // 
            this.obCo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.obCo.FormattingEnabled = true;
            this.obCo.Items.AddRange(new object[] {
            "Student",
            "Teacher",
            "Administrator"});
            this.obCo.Location = new System.Drawing.Point(85, 52);
            this.obCo.Name = "obCo";
            this.obCo.Size = new System.Drawing.Size(131, 21);
            this.obCo.TabIndex = 14;
            this.obCo.SelectedIndexChanged += new System.EventHandler(this.obCo_SelectedIndexChanged);
            // 
            // update_btn
            // 
            this.update_btn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.update_btn.Location = new System.Drawing.Point(32, 265);
            this.update_btn.Name = "update_btn";
            this.update_btn.Size = new System.Drawing.Size(91, 23);
            this.update_btn.TabIndex = 26;
            this.update_btn.Text = "Update Entry";
            this.update_btn.UseVisualStyleBackColor = true;
            this.update_btn.Click += new System.EventHandler(this.update_btn_Click);
            // 
            // cancel_btn
            // 
            this.cancel_btn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.cancel_btn.Location = new System.Drawing.Point(129, 265);
            this.cancel_btn.Name = "cancel_btn";
            this.cancel_btn.Size = new System.Drawing.Size(91, 23);
            this.cancel_btn.TabIndex = 27;
            this.cancel_btn.Text = "Cancel";
            this.cancel_btn.UseVisualStyleBackColor = true;
            this.cancel_btn.Click += new System.EventHandler(this.cancel_btn_Click);
            // 
            // oldBox
            // 
            this.oldBox.AutoSize = true;
            this.oldBox.Location = new System.Drawing.Point(131, 19);
            this.oldBox.Name = "oldBox";
            this.oldBox.Size = new System.Drawing.Size(39, 13);
            this.oldBox.TabIndex = 28;
            this.oldBox.Text = "oldBox";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(16, 19);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(109, 13);
            this.label6.TabIndex = 29;
            this.label6.Text = "Selected ID Number: ";
            // 
            // outLb
            // 
            this.outLb.AutoSize = true;
            this.outLb.Location = new System.Drawing.Point(16, 315);
            this.outLb.Name = "outLb";
            this.outLb.Size = new System.Drawing.Size(16, 13);
            this.outLb.TabIndex = 30;
            this.outLb.Text = "...";
            // 
            // update
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(265, 503);
            this.Controls.Add(this.outLb);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.oldBox);
            this.Controls.Add(this.cancel_btn);
            this.Controls.Add(this.update_btn);
            this.Controls.Add(this.titleLb);
            this.Controls.Add(this.label4);
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
            this.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Name = "update";
            this.Text = "update";
            this.Load += new System.EventHandler(this.update_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label titleLb;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label unLb;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox unCo;
        private System.Windows.Forms.TextBox unBox;
        private System.Windows.Forms.TextBox lastBox;
        private System.Windows.Forms.TextBox firstBox;
        private System.Windows.Forms.TextBox idBox;
        private System.Windows.Forms.ComboBox obCo;
        private System.Windows.Forms.Button update_btn;
        private System.Windows.Forms.Button cancel_btn;
        private System.Windows.Forms.Label oldBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label outLb;
    }
}