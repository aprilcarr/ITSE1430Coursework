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
    public partial class MovieForm : Form
    {
        public MovieForm()
        {
            InitializeComponent();
        }

        private void label3_Click( object sender, EventArgs e )
        {

        }

        private void OnCancel( object sender, EventArgs e )
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void OnSave( object sender, EventArgs e )
        {
            var movie = new Movie();

            //Name is required
            movie.Name = _txtName.Text;
            if (String.IsNullOrEmpty(_txtName.Text))
                return;

            //Release year is numeric, if set
            movie.ReleaseYear = GetInt32(_txtRelease);
            if (movie.ReleaseYear < 0)
                return;

            movie.Description = _txtdescription.Text;

            //Run length, if set
            movie.runlength = GetInt32(_runLength);
            if (movie.runlength < 0)
                return;

            DialogResult = DialogResult.OK;
            Close();
        }

        private int GetInt32 ( TextBox textBox)
        {
            if (String.IsNullOrEmpty(textBox.Text))
                return 0;
            if (Int32.TryParse(textBox.Text, out var value))
                return value;

            return -1;
        }
    }
}
