using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITSE1430MovieLib
{
    public class Movie
    {
        public string Name
        {
            get { return _name ?? " "; } //string get () implicit code
            set { _name = value; }// void set ( string value ) 
        }
        //public string GetName ()
        //{
        //    return _name ?? "";
        //}
        //public void  SetName ( string value )
        //{
        //    _name = value;
        //}
        private string _name = " ";

        //public System.String Name;
        public string Description 
        {
            get { return _description ?? ""; }
            set { _description = value; }

        }

        //public string GetDescription ()
        //{
        //    return _description ?? "";
        //}

        //public void SetDescription ( string value )
        //{
        //    _description = value;
        //}

        private string _description;

        public int ReleaseYear { get; set; } = 1900; // no semi colon if there is no initializer
        
        //private int _releaseYear = 1900; *backing field can be initialized like ^
           
       public int RunLength { get; set; }
        
       //private int _runLength;

        //int someValue;
       // private int someValue2;

        //void Foo ()
        //{
        //    var x = Runlength;

        //    var isLong = x > 100;

        //    var y = someValue;
        //}

        public int Id { get; private set; } //mixed accessibility - restrictions 1.  only get one 2. more restrictive IE.prop public, method must be restrictive
        //showing mixed accessibility
        public bool IsColor
        {
            get { return ReleaseYear > 1940;  }
        }
        
        public bool IsOwned { get; set; }
    }
}
