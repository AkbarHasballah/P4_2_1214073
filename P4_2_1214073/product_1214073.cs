using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P4_2_1214073
{
    public class product_1214073
    {
        private string myType;
        private string myTitle;

        public product_1214073()
        {

        }
        public product_1214073(string type, string title)// ini adalah method constructor
        {
            this.myType = type;
            this.myTitle = title;


        }
        public string MyType
        {
            get
            {
                return myType;
            }
            set
            {
                myType = value;
            }
        }
        public string MyTitle
        {
            get
            {
                return myTitle;
            }
            set
            {
                myTitle = value;
            }
        }
    }
}
