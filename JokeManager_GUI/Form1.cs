using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using JokeManagerNamespace;

namespace JokeManager_GUI
{
    public partial class Form1 : Form
    {
        private String mUsername;
        public String username { get { return mUsername; } set { mUsername = value; } }
        private String mJoke;
        public String joke { get { return mJoke; } set { mJoke = value; } }
        public Form1()
        {
            InitializeComponent();
        }

        private void submitBtn_Click(object sender, EventArgs e)
        {
            username = usernameTbx.Text;
            joke = JokeTbx.Text;
            outputLbl.Text = sendData().ToString();
        }
        private int sendData()
        {
            int status;
            status = JokeManager.SaveJoke(username, joke);
            return status;
        }
    }
}
