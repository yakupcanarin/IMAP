using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Net.Security;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using S22.Imap;
using Deneme;
namespace mail_IMAP
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            gb_Transactions.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {

            try
            {
                ImapClient client = new ImapClient("imap.gmail.com", 993, txt_Email.Text, txt_Password.Text, AuthMethod.Auto, true);
                MessageBox.Show("Connected to IMAP Server", "Success", MessageBoxButtons.OK);
                gb_Login.Visible = false;
                gb_Transactions.Visible = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error reason --> " + ex.Message, "Error!", MessageBoxButtons.OK);
            }


        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkB_Show.Checked == true)
            {
                txt_Password.PasswordChar = '\0';
            }
            else
            {
                txt_Password.PasswordChar = '•';
            }
        }

        private void btn_SearchMessage_Click(object sender, EventArgs e)
        {
            ImapClient client = new ImapClient("imap.gmail.com", 993, txt_Email.Text, txt_Password.Text, AuthMethod.Auto, true);
            IEnumerable<uint> uids = client.Search(SearchCondition.From(txt_Dest_Email.Text));
            listBox1.Items.Clear();
            listBox1.Items.Add("Message ID's which mail is from" + " ' " + txt_Dest_Email.Text + " ' ");
            foreach (var item in uids)
            {
                listBox1.Items.Add(item);
            }
        }

        private void btn_GetHeaders_Click(object sender, EventArgs e)
        {
            ImapClient client = new ImapClient("imap.gmail.com", 993, txt_Email.Text, txt_Password.Text, AuthMethod.Auto, true);
            IEnumerable<uint> uids = client.Search(SearchCondition.Answered());
            
            listBox1.Items.Clear();
            listBox1.Items.Add("Now you see ' Answered ' mails ");
            foreach (var item in uids)
            {
                listBox1.Items.Add(item);
            }
        }
    }
}
