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
    public partial class editDetails : Form
    {
        //Global Variables
        ModelDatabase myParent;
        string dbLocation;
        int id;


        public editDetails(string dbLOC, ModelDatabase parent, int ID)
        {
            
            myParent = parent;
            dbLocation = dbLOC;
            id = ID;

            InitializeComponent();
        }

        private void updateButt_Click(object sender, EventArgs e)
        {
            try
            {
                //setting the database
                OleDbConnection modelDB = new OleDbConnection
                    (@"provider=Microsoft.ACE.OLEDB.12.0; data source =" + dbLocation);

                //opening the database
                modelDB.Open();

                //setting Query
                OleDbCommand editModels
                    = new OleDbCommand
                    ("UPDATE Models SET Manafacturer = '"
                    + manafEdit.Text + "' ,ChassisCode = '"
                    + chassisEdit.Text + "' ,Make = '"
                    + makeEdit.Text + "' ,Model = '"
                    + modelEdit.Text + "' ,Variant = '"
                    + variantEdit.Text + "' ,Qty = "
                    + Convert.ToInt32(qtyEdit.Text) + ",Description = '"
                    + descrEdit.Text + "' WHERE ID = "
                    + id + ";", modelDB);

                int result = editModels.ExecuteNonQuery();

                if (result > 0)
                {

                }

                else
                {
                    MessageBox.Show("Failed");
                }


                //closing the database
                modelDB.Close();

                //disposing of the connection
                modelDB.Dispose();

                //refreshing the database
                myParent.dBRefresh();

                //closing the form
                this.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void editDetails_Load(object sender, EventArgs e)
        {
            //setting the database
            OleDbConnection modelDB = new OleDbConnection
                (@"provider=Microsoft.ACE.OLEDB.12.0; data source =" + dbLocation);

            modelDB.Open();

            // opening the database
            OleDbCommand gettingID = new OleDbCommand("SELECT * FROM Models Where ID = " + id + ";", modelDB);

            //reading the database
            OleDbDataReader dr = gettingID.ExecuteReader();

            while (dr.Read())
            {
                manafEdit.Text = dr[1].ToString();
                chassisEdit.Text = dr[2].ToString();
                makeEdit.Text = dr[3].ToString();
                modelEdit.Text = dr[4].ToString();
                variantEdit.Text = dr[5].ToString();
                qtyEdit.Text = Convert.ToInt32(dr[6]).ToString();
                descrEdit.Text = dr[7].ToString();
            }

            //closing the database
            modelDB.Close();

            //disposing of the connection
            modelDB.Dispose();

         
        }

        private void cancelButt_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
