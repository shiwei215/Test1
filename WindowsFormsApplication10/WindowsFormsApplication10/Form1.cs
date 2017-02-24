using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication10
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonAddNewUser_Click(object sender, EventArgs e)
        {
            try
            {


                User user = new User()
                {
                    ID = Guid.NewGuid(),
                    Name = textBoxUserName.Text,
                    Sex = true,
                    Birthday = DateTime.Now,
                    MobilePhone = textBoxUserMobilePhone.Text,
                    Email = "123456789@163.com",
                    Comment = ""
                };
                object retValue=user.Insert();
                MessageBox.Show(retValue.ToString());
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void buttonShowAllInfos_Click(object sender, EventArgs e)
        {
            try
            {
                textBoxUserList.Text = "";

                string txt = "";
                List<User> list = User.Fetch("");
                if((list!=null)&(list.Count>0))
                {
                    foreach(User u in list)
                    {
                        string info = u.Name + " " + u.MobilePhone + " " + ((DateTime)u.Birthday).ToShortDateString();

                        txt += info + "\r\n";
                    }
                    txt = "total:" + list.Count.ToString()+"\r\n"+txt;
                }
                textBoxUserList.Text = txt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }



    }
}
