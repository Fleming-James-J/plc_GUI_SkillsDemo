using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace Skills_Demo
{
    public partial class dBInsert : Form
    {
        //global Variables
        string dbaseLoc;
        ModelDatabase myParent;

        public dBInsert(string dbLoc, ModelDatabase myParentsDetails)
        {
            dbaseLoc = dbLoc;
            myParent = myParentsDetails;

            InitializeComponent();
        }

        private void cancelButt_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void insertButt_Click(object sender, EventArgs e)
        {
            // Setting the database
            OleDbConnection modelDB = new OleDbConnection(@"provider=Microsoft.ACE.OLEDB.12.0; data source = " + dbaseLoc);

            //opening up the database
            modelDB.Open();

            //setting the query to insert the data
            OleDbCommand insertEntry = new OleDbCommand("INSERT into Models(Manafacturer,ChassisCode,Make,Model,Variant,Qty,Description) VALUES('"
                + manafInsert.Text + "','"
                + chassisInsert.Text + "','"
                + makeInsert.Text + "','"
                + modelInsert.Text + "','"
                + variantInsert.Text + "',"
                + Convert.ToInt32(qtyInsert.Text) + ",'"
                + descrInsert.Text+"');", modelDB);

            //sending the query
            int result = insertEntry.ExecuteNonQuery();
            if (result > 0)
            {

            }
            else
            {
                MessageBox.Show("Failure: Entry Not Added");
            }

            //closing the database
            modelDB.Close();

            //disposing of the connection
            modelDB.Dispose();

            //refreshing the Main Database
            myParent.dBRefresh();

            //closing the form
            this.Close();

        }
    }
}
