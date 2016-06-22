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
    }
}
