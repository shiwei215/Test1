namespace WindowsFormsApplication10
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonAddNewUser = new System.Windows.Forms.Button();
            this.buttonShowAllInfos = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dateTimePickerUserBirthday = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxUserMobilePhone = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxUserName = new System.Windows.Forms.TextBox();
            this.textBoxUserList = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonAddNewUser
            // 
            this.buttonAddNewUser.Location = new System.Drawing.Point(54, 113);
            this.buttonAddNewUser.Name = "buttonAddNewUser";
            this.buttonAddNewUser.Size = new System.Drawing.Size(118, 27);
            this.buttonAddNewUser.TabIndex = 0;
            this.buttonAddNewUser.Text = "Add New User";
            this.buttonAddNewUser.UseVisualStyleBackColor = true;
            this.buttonAddNewUser.Click += new System.EventHandler(this.buttonAddNewUser_Click);
            // 
            // buttonShowAllInfos
            // 
            this.buttonShowAllInfos.Location = new System.Drawing.Point(9, 17);
            this.buttonShowAllInfos.Name = "buttonShowAllInfos";
            this.buttonShowAllInfos.Size = new System.Drawing.Size(118, 23);
            this.buttonShowAllInfos.TabIndex = 1;
            this.buttonShowAllInfos.Text = "Show All infos";
            this.buttonShowAllInfos.UseVisualStyleBackColor = true;
            this.buttonShowAllInfos.Click += new System.EventHandler(this.buttonShowAllInfos_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dateTimePickerUserBirthday);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.textBoxUserMobilePhone);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.textBoxUserName);
            this.groupBox1.Controls.Add(this.buttonAddNewUser);
            this.groupBox1.Location = new System.Drawing.Point(45, 31);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(299, 158);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // dateTimePickerUserBirthday
            // 
            this.dateTimePickerUserBirthday.Location = new System.Drawing.Point(82, 79);
            this.dateTimePickerUserBirthday.Name = "dateTimePickerUserBirthday";
            this.dateTimePickerUserBirthday.Size = new System.Drawing.Size(200, 21);
            this.dateTimePickerUserBirthday.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 85);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 12);
            this.label3.TabIndex = 2;
            this.label3.Text = "Birthday:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 12);
            this.label2.TabIndex = 2;
            this.label2.Text = "MobilePhone:";
            // 
            // textBoxUserMobilePhone
            // 
            this.textBoxUserMobilePhone.Location = new System.Drawing.Point(105, 49);
            this.textBoxUserMobilePhone.Name = "textBoxUserMobilePhone";
            this.textBoxUserMobilePhone.Size = new System.Drawing.Size(100, 21);
            this.textBoxUserMobilePhone.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 12);
            this.label1.TabIndex = 2;
            this.label1.Text = "Name:";
            // 
            // textBoxUserName
            // 
            this.textBoxUserName.Location = new System.Drawing.Point(105, 22);
            this.textBoxUserName.Name = "textBoxUserName";
            this.textBoxUserName.Size = new System.Drawing.Size(100, 21);
            this.textBoxUserName.TabIndex = 1;
            // 
            // textBoxUserList
            // 
            this.textBoxUserList.Location = new System.Drawing.Point(8, 46);
            this.textBoxUserList.Multiline = true;
            this.textBoxUserList.Name = "textBoxUserList";
            this.textBoxUserList.Size = new System.Drawing.Size(283, 147);
            this.textBoxUserList.TabIndex = 1;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.buttonShowAllInfos);
            this.groupBox2.Controls.Add(this.textBoxUserList);
            this.groupBox2.Location = new System.Drawing.Point(36, 223);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(307, 203);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "groupBox2";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(678, 462);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonAddNewUser;
        private System.Windows.Forms.Button buttonShowAllInfos;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DateTimePicker dateTimePickerUserBirthday;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxUserName;
        private System.Windows.Forms.TextBox textBoxUserMobilePhone;
        private System.Windows.Forms.TextBox textBoxUserList;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}

