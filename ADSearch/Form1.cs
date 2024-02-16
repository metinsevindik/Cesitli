using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.DirectoryServices;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Linq;

namespace ADSearch
{
    public partial class Form1 : Form
    {
        List<string> tempList = new List<string>();
        public Form1()
        {
            InitializeComponent();
        }

        private void SearchBtn_Click(object sender, EventArgs e)
        {
            string username = SearchTxt.Text;
            DirectoryEntry dirEntry = new DirectoryEntry(domainTxt.Text);
            DirectorySearcher search = new DirectorySearcher(dirEntry);
            search.PropertiesToLoad.Add("cn");
            search.PropertiesToLoad.Add("displayName");
            search.PropertiesToLoad.Add("manager");
            search.PropertiesToLoad.Add("mail");
            search.PropertiesToLoad.Add("sAMAccountName");
            search.PropertiesToLoad.Add("memberOf");
            if (username.IndexOf('@') > -1)
            {
                // userprincipal username
                search.Filter = "(userPrincipalName=" + username + ")";
            }
            else
            {
                // samaccountname username
                String samaccount = username;
                if (username.IndexOf(@"\") > -1)
                {
                    samaccount = username.Substring(username.IndexOf(@"\") + 1);
                }
                search.Filter = "(sAMAccountName=" + samaccount + ")";
            }
            SearchResult result = search.FindOne();
            listBox1.Items.Clear();
            tempList.Clear();
            if (result != null)
            {

                foreach (var item in result.Properties["memberof"])
                {
                    var cn = item.ToString().Substring(3, item.ToString().IndexOf("OU") - 4);
                    listBox1.Items.Add(cn);
                    tempList.Add(cn);
                }
            }
            else
                MessageBox.Show("Kayıt bulunamadı!");


        }

        private void SearchTxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void findinlisttxt_TextChanged(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            if (findinlisttxt.Text == "")
            {
                foreach (var item in tempList)
                {
                    listBox1.Items.Add(item.ToString());
                }
            }
            else
            {
                foreach (var item in tempList)
                {
                    if (item.ToLower().Contains(findinlisttxt.Text.ToLower()))
                    {
                        listBox1.Items.Add(item);
                    }
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            resultUserList.Clear();
            NotPermissionUserList.Clear();
            domaindebulunamayan.Clear();
            string usernames = coklukisiTxt.Text;
            DirectoryEntry dirEntry = new DirectoryEntry(domainTxt.Text);
            DirectorySearcher search = new DirectorySearcher(dirEntry);
            search.PropertiesToLoad.Add("cn");
            search.PropertiesToLoad.Add("displayName");
            search.PropertiesToLoad.Add("manager");
            search.PropertiesToLoad.Add("mail");
            search.PropertiesToLoad.Add("sAMAccountName");
            search.PropertiesToLoad.Add("memberOf");
            foreach (var usernametrimmed in usernames.Split(','))
            {
                var username = usernametrimmed.Trim();
                if (username == null || username == "") continue;
                if (username.IndexOf('@') > -1)
                {
                    // userprincipal username
                    search.Filter = "(userPrincipalName=" + username + ")";
                }
                else
                {
                    // samaccountname username
                    String samaccount = username;
                    if (username.IndexOf(@"\") > -1)
                    {
                        samaccount = username.Substring(username.IndexOf(@"\") + 1);
                    }
                    search.Filter = "(sAMAccountName=" + samaccount + ")";
                }
                SearchResult result = search.FindOne();
                listBox1.Items.Clear();
                tempList.Clear();
                if (result != null)
                {
                    var yetkivarmi = false;
                    foreach (var item in result.Properties["memberof"])
                    {
                        var cn = item.ToString().Substring(3, item.ToString().IndexOf("OU") - 4);
                        //listBox1.Items.Add(cn);
                        //tempList.Add(cn);
                        if (cn.ToString() == arananGrupTxt.Text)
                        {
                            yetkivarmi = true; 
                            break;
                        }
                    }
                    if (yetkivarmi)
                        resultUserList.Text += username + ",";
                    else
                        NotPermissionUserList.Text += username + ",";
                }
                else
                {
                    domaindebulunamayan.Text += username + ",";
                }
            }

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
