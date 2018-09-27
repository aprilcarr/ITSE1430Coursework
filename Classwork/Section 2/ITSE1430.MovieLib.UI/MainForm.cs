using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ITSE1430MovieLib;

namespace ITSE1430.MovieLib.UI
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void eExitToolStripMenuItem_Click( object sender, EventArgs e )
        {
            if (MessageBox.Show("Are you sure you want to exit?", "Close", MessageBoxButtons.YesNo) == DialogResult.No)
                return;           

            Close();
        }       

        private void helpToolStripMenuItem_Click( object sender, EventArgs e )
        {

        }

        private void OnHelpAbout( object sender, EventArgs e )
        {
            MessageBox.Show(this,"Sorry", "Help", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        private void OnMovieAdd( object sender, EventArgs e )
        {
            var form = new MovieForm();

            if (form.ShowDialog(this) == DialogResult.Cancel)
                return;

            //MessageBox.Show("Adding movie");
            //Movie = form.Movie;
           // Movie.Name = "";
        }

        private Movie Movie;

        private void MainForm_Load( object sender, EventArgs e )
        {

        }
    }
}
