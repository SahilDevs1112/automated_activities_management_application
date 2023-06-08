using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Office.Interop.Excel;
using Excel = Microsoft.Office.Interop.Excel;

namespace Automated_Activities
{
    public partial class MainPage : Form
    {
        public MainPage()
        {
            InitializeComponent();
        }
        public SqlConnection con = new SqlConnection(@"Data Source=USHYDSAKHUNTIA4;Initial Catalog=AutomatedActivites;Integrated Security=True;Connect Timeout=30;Encrypt=False");

        public string programFiles = Environment.ExpandEnvironmentVariables("%ProgramW6432%");
        public string programFilesX86 = Environment.ExpandEnvironmentVariables("%ProgramFiles(x86)%");

        public bool StopFile = false;
        private void AllActivitiesLabel_Click(object sender, EventArgs e)
        {
            AllActivitiesPage.BringToFront();
        }

        private void ScheduledActivitiesLabel_Click(object sender, EventArgs e)
        {
            ScheduledActvitiesPage2.BringToFront();
        }

        private void AddNewActivityLabel_Click(object sender, EventArgs e)
        {
            AddNewActivityPage.BringToFront();
        }

        private void RecentActivitiesLabel_Click(object sender, EventArgs e)
        {
            RecentActivitesPage.BringToFront();
        }

        private void DeletedActivtiesLabel_Click(object sender, EventArgs e)
        {
            DeletedActvitiesPage.BringToFront();
        }

        public void CheckConState()
        {
            if (con != null && con.State == ConnectionState.Open)
            {
                con.Close();
            }
        }

        public void StopMacroFile(Excel.Application xlApp, Workbook wb)
        {
            try {
                wb.Close();
                xlApp.Quit();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void RunAutomatedFileMacro(string Runfile)
        {
            Excel.Application xlApp = new Excel.Application();
            Workbook wb =  xlApp.Workbooks.Open(Runfile);

            try
            {
                xlApp.Visible = true;
                xlApp.Run("Main");

                if (StopFile == true)
                {
                    StopMacroFile(xlApp, wb);
                }

                MessageBox.Show("Excel Macro completed the Activity");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                wb.Close(false);
                xlApp.Quit();
                xlApp.Application.Quit();
            }

        }

        private void AllActivitiesPage_Paint(object sender, PaintEventArgs e)
        {
            try
            {
                CheckConState();
                con.Open();
                string query = "Select * From FilesTbl";
                SqlDataAdapter sda = new SqlDataAdapter(query, con);
                SqlCommandBuilder scb = new SqlCommandBuilder(sda);
                DataSet ds = new DataSet();
                sda.Fill(ds);
                AllActivitesGV.DataSource = ds.Tables[0];
                AllActivitesGV.Columns["AutomatedFiles"].Visible = false;
                con.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void RecentActivityPage_Paint(object sender, PaintEventArgs e)
        {
            try
            {
                CheckConState();
                con.Open();
                string query = "Select * From Recent";
                SqlDataAdapter sda = new SqlDataAdapter(query, con);
                SqlCommandBuilder scb = new SqlCommandBuilder(sda);
                DataSet ds = new DataSet();
                sda.Fill(ds);
                recentActivitiesGV.DataSource = ds.Tables[0];
                recentActivitiesGV.Columns["FileID"].Visible = false;
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void DeletedActvitiesPage_Paint(object sender, PaintEventArgs e)
        {
            try
            {
                CheckConState();
                con.Open();
                string query = "Select * From Deleted";
                SqlDataAdapter sda = new SqlDataAdapter(query, con);
                SqlCommandBuilder scb = new SqlCommandBuilder(sda);
                DataSet ds = new DataSet();
                sda.Fill(ds);
                deletedActvitiesGV.DataSource = ds.Tables[0];
                deletedActvitiesGV.Columns["FileID"].Visible = false;
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void UpdateDeleteActivities(DataSet ds)
        {
            try
            {
                CheckConState();
                con.Open();
                string query = "Insert into Deleted (ActivityName,FileName,Date) Values('" + ds.Tables[0].Rows[0]["ActivityName"].ToString() + "','" + ds.Tables[0].Rows[0]["FileName"].ToString() + "','" + DateTime.Now + "')";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Added to Deleted Activities");
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }
        public void UpdateRecentActivities(DataSet ds)
        {
            try
            {
                CheckConState();
                con.Open();
                string query = "Insert into Recent (ActivityName,FileName,Date) Values('" + ds.Tables[0].Rows[0]["AcitvityName"].ToString() + "','" + ds.Tables[0].Rows[0]["FileName"].ToString() + "','" + DateTime.Now + "')";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Added to Recent Activities");
            }
            catch(Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }


        private void OpenFileDialogBtn_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK) 
            {   
                var file = openFileDialog1.OpenFile();
                try
                {
                    //Copy file to Project Folder

                    var filePath = openFileDialog1.FileName.ToString().Substring(0, openFileDialog1.FileName.ToString().LastIndexOf("\\")).ToString();
                    var destinationfilePath = "C:\\Users\\sakhuntia\\Music\\Dot Net\\Automated Activities\\Automated Files";
                    string destinationFile = openFileDialog1.FileName.ToString().Replace(filePath,destinationfilePath).ToString();
                    File.Copy(openFileDialog1.FileName.ToString(),destinationFile);

                    CheckConState();
                    con.Open();
                    string query = "Insert into FilesTbl (AutomatedFiles,ActivityName,FileName,Duration) Values(CONVERT(varbinary(max),'" + file + "'),'" + ActivityNameTB.Text + "','" + destinationFile + "','" + ActivityDurationCB.Text + "')";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Activity Added Successfully");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

            }
            else
            {
                MessageBox.Show("No Files Selected");
            }
        }

        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            var v = AllActivitesGV.SelectedRows[0].Cells[AllActivitesGV.Columns["ActivityName"].Index].Value.ToString();
            CheckConState();
            try
            {
                DialogResult result = MessageBox.Show("Are you sure to delete this Activity", "Delete Confirmation", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    con.Open();
                    string query = "Select * From FilesTbl Where ActivityName = '" + v + "'";
                    SqlDataAdapter adapter = new SqlDataAdapter(query, con);
                    SqlCommandBuilder cmd = new SqlCommandBuilder(adapter);
                    DataSet ds = new DataSet();
                    adapter.Fill(ds);

                    string fileToDelete = ds.Tables[0].Rows[0]["FileName"].ToString();

                    File.Delete(fileToDelete);

                    string query2 = "Delete From FilesTbl Where ActivityName = '" + v + "'";
                    SqlCommand c = new SqlCommand(query2, con);
                    c.ExecuteNonQuery();

                    con.Close();
                    MessageBox.Show("Activity Deleted Successfully");
                    UpdateDeleteActivities(ds);
                }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        // Run Button
        private void RunBtn_Click(object sender, EventArgs e)
        {
            var v = AllActivitesGV.SelectedRows[0].Cells[AllActivitesGV.Columns["ActivityName"].Index].Value.ToString();
            CheckConState();
            try
            {
                con.Open();
                string query = "Select FileName From FilesTbl Where ActivityName = '" + v + "'";
                SqlDataAdapter adapter = new SqlDataAdapter(query,con);
                SqlCommandBuilder cmd = new SqlCommandBuilder(adapter);
                DataSet d = new DataSet();
                adapter.Fill(d);

                string runFile = d.Tables[0].Rows[0]["FileName"].ToString();

                //Run Automated File
                RunAutomatedFileMacro(runFile);

                con.Close();
                MessageBox.Show("Activity Started Running");
                UpdateRecentActivities(d);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void RefreshBtn_Click(object sender, EventArgs e)
        {
            recentActivitiesGV.Update();
            deletedActvitiesGV.Update();
            recentActivitiesGV.Refresh();
            deletedActvitiesGV.Refresh();
            AllActivitesGV.Update();
            AllActivitesGV.Refresh();
        }

        private void StopBtn_Click(object sender, EventArgs e)
        {
            StopFile = true;
        }
    }
}
