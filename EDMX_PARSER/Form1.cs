using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EDMX_PARSER.DES;

namespace EDMX_PARSER
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            EDMX_PARSER.DES.EDMX edmx = new EDMX_PARSER.DES.EDMX();
            //var w = edmx.GetEntity("Address");
            //var x = edmx.GetRelatedEntity("Address");
            //var y = edmx.GetRelatedEntityAssociation("MPI.DriverEducation.DES.CoreProvider.CoreEntities.ADDR_fkc1");

        }
    }
}
