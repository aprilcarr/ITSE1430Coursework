﻿using System;
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
        public Movie Movie { get; set; }

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
            //var movie2 = new Movie();
            //var name = movie2.GetName();

            //Name is required
            movie.Name = _txtName.Text;
            if (String.IsNullOrEmpty(_txtName.Text))
                return;

            //Release year is numeric, if set
            movie.ReleaseYear = GetInt32(_txtRelease);
            if (movie.ReleaseYear < 0)
                return;

            //movie.SetDescription(_txtdescription.Text);
            movie.Description = _txtdescription.Text;

            //Run length, if set
            movie.RunLength =  GetInt32(_runLength);
            if (movie.RunLength < 0)
                return;

            movie.IsOwned = _ownerCheckBox.Checked;

            Movie = movie;
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

        private void _ownerCheckBox_CheckedChanged( object sender, EventArgs e )
        {

        }

        private void MovieForm_Load( object sender, EventArgs e )
        {
            if (Movie != null)
            {
                _txtName.Text = Movie.Name;
                _txtdescription.Text = Movie.Description;
                _txtRelease.Text = Movie.ReleaseYear.ToString();
                _runLength.Text = Movie.RunLength.ToString();
                _ownerCheckBox.Checked = Movie.IsOwned;
            }
        }
    }
}
