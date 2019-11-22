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
    public partial class ModelDatabase : Form
    {
        //Global Variables
        string DatabaseLocatition;

        public ModelDatabase()
        {
            InitializeComponent();
        }

        private void setDatabaseLocationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog getDB = new OpenFileDialog();
            getDB.Filter = "Database |*.accdb";

            if (getDB.ShowDialog() == DialogResult.OK)
            {
                DatabaseLocatition = getDB.FileName;
            }

        }
        public void dBRefresh()
        {
            // clear database to stop duplication on refresh
            dataGridViewer.Rows.Clear();


            //setting the db connection
            OleDbConnection ModelDB = new OleDbConnection(@"provider=Microsoft.ACE.OLEDB.12.0;data source =" + DatabaseLocatition);

            //opening the connection
            ModelDB.Open();

            //setting the query
            OleDbCommand getAll = new OleDbCommand("SELECT * FROM Models;", ModelDB);

            //setting the query
            OleDbDataReader dr = getAll.ExecuteReader();

            //using the query results
            while (dr.Read())
            {
                dataGridViewer.Rows.Add(
                    Convert.ToInt32(dr[0]),
                    dr[1].ToString(),
                    dr[2].ToString(),
                    dr[3].ToString(),
                    dr[4].ToString(),
                    dr[5].ToString(),
                    Convert.ToInt32(dr[6]),
                    dr[7].ToString());

            }

           
            //close the db connection
            ModelDB.Close();

            //dispose of the connection
            ModelDB.Dispose();

        }

        private void searchDB()
        {
            //resets status label back to blank
            statusLabel.Text = ("");

            // clear database to stop duplication on refresh
            dataGridViewer.Rows.Clear();


            //setting the db connection
            OleDbConnection ModelDB = new OleDbConnection(@"provider=Microsoft.ACE.OLEDB.12.0;data source =" + DatabaseLocatition);

            //opening the connection
            ModelDB.Open();

            //setting the query
            OleDbCommand getAll = new OleDbCommand("SELECT * FROM Models WHERE Manafacturer LIKE '"
                + searchBox.Text + "%' OR ChassisCode LIKe '" + searchBox.Text + "%' OR Make LIKE '" 
                + searchBox.Text + "%' OR Model LIKE '" + searchBox.Text + "%' OR Variant LIKE '"
                + searchBox.Text + "%' Or Description LIKE '"+ searchBox.Text + "%' ;", ModelDB);

            //setting the query
            OleDbDataReader dr = getAll.ExecuteReader();

            //using the query results
            while (dr.Read())
            {
                dataGridViewer.Rows.Add(
                    Convert.ToInt32(dr[0]),
                    dr[1].ToString(),
                    dr[2].ToString(),
                    dr[3].ToString(),
                    dr[4].ToString(),
                    dr[5].ToString(),
                    Convert.ToInt32(dr[6]),
                    dr[7].ToString());

            }

            //close the db connection
            ModelDB.Close();

            //dispose of the connection
            ModelDB.Dispose();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            //accidently clicked
        }

        private void panel1_Click(object sender, EventArgs e)
        {
            searchDB();
        }

        private void searchBox_TextChanged(object sender, EventArgs e)
        {
            searchDB();
        }

        private void showDatabaseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dBRefresh();
        
        }

        private void refreshToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dBRefresh();
        }

        private void deleteEntryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //getting the ID of the selected row
            int id = Convert.ToInt32(dataGridViewer.CurrentRow.Cells[0].Value);

            //setting the database
            OleDbConnection modelDB = new OleDbConnection(@"provider=Microsoft.ACE.OLEDB.12.0;data source = " + DatabaseLocatition);

            //opening the database
            modelDB.Open();

            //setting the query
            OleDbCommand deleteEntry = new OleDbCommand("DELETE * FROM Models WHERE id = " + id + ";", modelDB);

            //sending query and getting the result
            int result = deleteEntry.ExecuteNonQuery();

            if (result > 0)
            {
                statusLabel.Text = ("Entry Successfully Deleted");
                
            }
            else
            {
                statusLabel.Text = ("Entry Deletion Failure");
            }

            //closing the database
            modelDB.Close();

            //disposing the database
            modelDB.Dispose();

            //refreshes the database
            dBRefresh();
        }

        private void addEntryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dBInsert insertEntry = new dBInsert(DatabaseLocatition, this);
            insertEntry.ShowDialog();
        }

        private void editEntryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(dataGridViewer.CurrentRow.Cells[0].Value);

            editDetails editEntry = new editDetails(DatabaseLocatition, this, id);
            editEntry.ShowDialog();


        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
