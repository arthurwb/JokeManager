/*
 * William Arthur
 * arthurwb@mail.uc.edu
 * IT 3045
 * Final Project
 * Due December 7
 * Description: Create a GUI for a program that addes a joke and usernamen to a database. 
 * Citations:
 */

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
        // setting up the username and joke so that they can be used later. Data hiding is in effect.
        private String mUsername;
        public String username { get { return mUsername; } set { mUsername = value; } }
        private String mJoke;
        public String joke { get { return mJoke; } set { mJoke = value; } }
        public Form1()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Once the submit button is clicked it will send data to JokeManager so it can add the data to the database.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void submitBtn_Click(object sender, EventArgs e)
        {
            username = usernameTbx.Text;
            joke = JokeTbx.Text;
            String response = sendData().ToString();
            // a more user friendly response
            if (response == "-1")
            {
                outputLbl.Text = "Joke sent to database!";
            } else
            {
                outputLbl.Text = "There was an error somewhere. Error code: " + response;
            }
        }
        /// <summary>
        /// sends the data to JokeManager.SaveJoke with te usernamen and joke that the user put in.
        /// </summary>
        /// <returns>returns a status of -1 through 1 depending on if the data had been added. -1 = success. 0 and 1 are errors.</returns>
        private int sendData()
        {
            int status;
            status = JokeManager.SaveJoke(username, joke);
            return status;
        }
    }
}
