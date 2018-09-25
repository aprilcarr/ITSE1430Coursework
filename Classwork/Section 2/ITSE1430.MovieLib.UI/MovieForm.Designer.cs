namespace ITSE1430.MovieLib.UI
{
    partial class MovieForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose( bool disposing )
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this._txtName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this._txtdescription = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this._txtRelease = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this._runLength = new System.Windows.Forms.TextBox();
            this._buttonSave = new System.Windows.Forms.Button();
            this._buttonCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name";
            // 
            // _txtName
            // 
            this._txtName.Location = new System.Drawing.Point(81, 23);
            this._txtName.Name = "_txtName";
            this._txtName.Size = new System.Drawing.Size(212, 20);
            this._txtName.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Description";
            // 
            // _txtdescription
            // 
            this._txtdescription.Location = new System.Drawing.Point(81, 49);
            this._txtdescription.Multiline = true;
            this._txtdescription.Name = "_txtdescription";
            this._txtdescription.Size = new System.Drawing.Size(193, 126);
            this._txtdescription.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 250);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Release Year";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // _txtRelease
            // 
            this._txtRelease.Location = new System.Drawing.Point(81, 243);
            this._txtRelease.Name = "_txtRelease";
            this._txtRelease.Size = new System.Drawing.Size(195, 20);
            this._txtRelease.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 278);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Run Length";
            // 
            // _runLength
            // 
            this._runLength.Location = new System.Drawing.Point(81, 275);
            this._runLength.Name = "_runLength";
            this._runLength.Size = new System.Drawing.Size(100, 20);
            this._runLength.TabIndex = 7;
            // 
            // _buttonSave
            // 
            this._buttonSave.Location = new System.Drawing.Point(248, 315);
            this._buttonSave.Name = "_buttonSave";
            this._buttonSave.Size = new System.Drawing.Size(84, 23);
            this._buttonSave.TabIndex = 8;
            this._buttonSave.Text = "Save";
            this._buttonSave.UseVisualStyleBackColor = true;
            this._buttonSave.Click += new System.EventHandler(this.OnSave);
            // 
            // _buttonCancel
            // 
            this._buttonCancel.Location = new System.Drawing.Point(329, 315);
            this._buttonCancel.Name = "_buttonCancel";
            this._buttonCancel.Size = new System.Drawing.Size(84, 23);
            this._buttonCancel.TabIndex = 9;
            this._buttonCancel.Text = "Cancel";
            this._buttonCancel.UseVisualStyleBackColor = true;
            this._buttonCancel.Click += new System.EventHandler(this.OnCancel);
            // 
            // MovieForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(425, 350);
            this.ControlBox = false;
            this.Controls.Add(this._buttonCancel);
            this.Controls.Add(this._buttonSave);
            this.Controls.Add(this._runLength);
            this.Controls.Add(this.label4);
            this.Controls.Add(this._txtRelease);
            this.Controls.Add(this.label3);
            this.Controls.Add(this._txtdescription);
            this.Controls.Add(this.label2);
            this.Controls.Add(this._txtName);
            this.Controls.Add(this.label1);
            this.Name = "MovieForm";
            this.ShowInTaskbar = false;
            this.Text = "MovieDetails";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox _txtName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox _txtdescription;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox _txtRelease;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox _runLength;
        private System.Windows.Forms.Button _buttonSave;
        private System.Windows.Forms.Button _buttonCancel;
    }
}