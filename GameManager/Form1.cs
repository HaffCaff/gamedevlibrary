using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GameManager
{
    public partial class Form1 : Form
    {

        string[] game = {"","","","" }; // initialize array so every button click we are just adding to it

        public Form1()
        {
            InitializeComponent();
             
            //Initilize DataGridView
            dataGridView1.ColumnCount = 4;
            dataGridView1.Columns[0].Name = "Name";
            dataGridView1.Columns[0].Name = "Platform";
            dataGridView1.Columns[2].Name = "Release Year";
            dataGridView1.Columns[3].Name = "Rating";

            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void Add_Click(object sender, EventArgs e)
        {
            AddGame();  // When clicked run this function
        }

        //ADD TO DGV 

        private void AddGame()  // The function that will be run when user clicks button
        {
            game = new[] { gamename.Text, gamesystem.Text, gamedate.Text, gamerate.Text };  // takes all input from textboxes and adds them to the grid
            dataGridView1.Rows.Add(game);

            // Resets all texts boxes to nothing
            gamename.Text = "";
            gamesystem.Text = "";
            gamedate.Text = "";
            gamerate.Text = "";
        }

        //SORTING BUTTINGS

        private void sortname_Click(object sender, EventArgs e)
        {
            dataGridView1.Sort(dataGridView1.Columns[0], ListSortDirection.Ascending);  // Sorts games by name
        }

        private void sortsystem_Click(object sender, EventArgs e)
        {
            dataGridView1.Sort(dataGridView1.Columns[1], ListSortDirection.Ascending);  // sorts game  by system
        }

        private void sortyear_Click(object sender, EventArgs e)
        {
            dataGridView1.Sort(dataGridView1.Columns[2], ListSortDirection.Ascending); //  sort game by year
        }

        private void sortrating_Click(object sender, EventArgs e)
        {
            dataGridView1.Sort(dataGridView1.Columns[3], ListSortDirection.Descending);  // sort game by rating
        }
    }
}
