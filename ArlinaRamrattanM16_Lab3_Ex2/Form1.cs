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
        //Method so when the form loads the Next value for the learnerId is there
        private void Form1_Load(object sender, EventArgs e)
        {
            getNextId();
        }
        private void btnCreate_Click(object sender, EventArgs e)
        {
            try
            {
                ArlinaDBEntities aDBC = new ArlinaDBEntities();
                ArlinaTB newRow = new ArlinaTB();
                newRow.learnerName = tbLearnerName.Text;
                newRow.learnerAge = Convert.ToInt32(tbLearnerAge.Text);
                newRow.favMovie = tbFavMovie.Text;
                newRow.favDrink = tbFavDrink.Text;

                aDBC.ArlinaTBs.Add(newRow);
                aDBC.SaveChanges();
                MessageBox.Show("Learner Added");
            }
            catch (Exception error)
            {
                MessageBox.Show(error.ToString());
            }


        }
        //The find learner btn 
        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                //creating object of ArlinaDBEntities 
                using (var dbContent = new ArlinaDBEntities())
                {
                    //grabbing the row from the table that matches the id
                    var queryResults = from row in dbContent.ArlinaTBs
                                where row.learnerId.ToString() == tbLearnerId.Text
                                select new
                                {
                                   learnerName = row.learnerName,
                                   learnerAge = row.learnerAge, 
                                   favMovie = row.favMovie,
                                   favDrink = row.favDrink
                                };
                    //Assigning each itme in queryResults to assosiated Textbox
                    foreach (var item in queryResults)
                    {
                        tbLearnerName.Text = item.learnerName;
                        tbLearnerAge.Text = item.learnerAge.ToString();
                        tbFavMovie.Text = item.favMovie;
                        tbFavDrink.Text = item.favDrink;

                    }
                }
            }
            catch (Exception error)
            {
                MessageBox.Show(error.ToString());
            }

        }
        //method to update an exsiting record
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                ArlinaDBEntities aDBC = new ArlinaDBEntities();
                ArlinaTB newRow = new ArlinaTB();
                //grabbing the row from the table that matches the id
                using (aDBC)
                    newRow = aDBC.ArlinaTBs.Where(id => id.learnerId.ToString() == tbLearnerId.Text).FirstOrDefault<ArlinaTB>();
                //Changing the fields of the row if the row grabbed is not empty
                if(newRow != null)
                {
                    newRow.learnerName = tbLearnerName.Text;
                    newRow.learnerAge = Convert.ToInt32(tbLearnerAge.Text);
                    newRow.favMovie = tbFavMovie.Text;
                    newRow.favDrink = tbFavDrink.Text;
                }
                //Saving the changed row 
                using (var dbRow = new ArlinaDBEntities())
                {
                    //mark the row as modified
                    dbRow.Entry(newRow).State = EntityState.Modified;
                    //Save Changes
                    dbRow.SaveChanges();
                    /*aDBC.ArlinaTBs.Add(deleteRow);
                    aDBC.SaveChanges();*/
                    MessageBox.Show("Learner Updated");
                }

            }
            catch (Exception error)
            {
                MessageBox.Show(error.ToString());
            }

        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                ArlinaDBEntities aDBC = new ArlinaDBEntities();
                ArlinaTB deleteRow = new ArlinaTB();
                //grabbing the row from the table that matches the id
                using (aDBC)
                    deleteRow = aDBC.ArlinaTBs.Where(id => id.learnerId.ToString() == tbLearnerId.Text).FirstOrDefault<ArlinaTB>();
               
                //Deleting the selected row 
                using (var dbRow = new ArlinaDBEntities())
                {
                    //mark the row as modified
                    dbRow.Entry(deleteRow).State = EntityState.Deleted;
                    //Save Changes
                    dbRow.SaveChanges();
                    /*aDBC.ArlinaTBs.Add(deleteRow);
                    aDBC.SaveChanges();*/
                    MessageBox.Show("Learner Updated");
                }

            }
            catch (Exception error)
            {
                MessageBox.Show(error.ToString());
            }
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        //Method to get the next automated value for the learnerID  from the database
       private void getNextId()
        {

            try
            {
                int id;
                //create a ArlinaDBEntities object
                ArlinaDBEntities aDBC = new ArlinaDBEntities();
                
                //getting the highest Id number already used
                //making id equal to the next value that the table will automatically generate 
                var idList = from ids in aDBC.ArlinaTBs select ids.learnerId;
                id = Convert.ToInt32(idList.Max())+1;
                MessageBox.Show("Value Recieved");//used to check if value was grabbed
               //Assigning value to textbox
                tbLearnerId.Text = id.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }


        }
        //Used to grab the 
        private void clearBoxes()
        {
            tbLearnerId.Text = "";
            tbLearnerName.Text = "";
            tbLearnerAge.Text = "";
            tbFavMovie.Text = "";
            tbFavDrink.Text = "";
            tbLearnerId.Focus();
           getNextId();
        }








    }
}
