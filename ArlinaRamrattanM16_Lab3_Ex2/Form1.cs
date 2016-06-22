using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Entity;
using System.Data.Entity.Validation;

namespace ArlinaRamrattanM16_Lab3_Ex2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            ArlinaDBEntities aDBC = new ArlinaDBEntities();
            ArlinaTB newRow = new ArlinaTB();
            newRow.learnerName = tbLearnerName.Text;
            newRow.learnerAge = Convert.ToInt32(tbLearnerAge.Text);
            newRow.favMovie = tbFavMovie.Text;
            newRow.favDrink = tbFavDrink.Text;

            aDBC.ArlinaTBs.Add(newRow);


        }


        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        //Method to get the next automated value for the learnerID  from the database
       /* private void getNextId()
        {

            try
            {
                int id;
                //create a connection with ArlinaDB database
                ArlinaDBEntities aDBC = new ArlinaDBEntities();
                ArlinaTB newRow = new ArlinaTB();
                //getting the highest Id number already used
                id = aDBC.ArlinaTBs.learnerId.Max(learnerId);

                //making id equal to the next value that the table will automatically generate 
                id = (int)cmd.ExecuteScalar() + 1;
                //MessageBox.Show("Value Recieved");//used to check if value was grabbed
                conn.Close();
                tbLearnerId.Text = id.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }


        }*/
        private void clearBoxes()
        {
            tbLearnerId.Text = "";
            tbLearnerName.Text = "";
            tbLearnerAge.Text = "";
            tbFavMovie.Text = "";
            tbFavDrink.Text = "";
            tbLearnerId.Focus();
           // getNextId();
        }

    }
}
