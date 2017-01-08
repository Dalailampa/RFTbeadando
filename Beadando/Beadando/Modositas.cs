using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Beadando
{
    public partial class Modositas : Form
    {
        SQLFunctions database = new SQLFunctions();
        int rekordid;
        public Modositas(int id)
        {
            InitializeComponent();
            rekordid = id;
            DataTable dt = database.SelectId(id);
            _tboxNev.Text = (string)dt.Rows[0]["Nev"];
            _tboxCim.Text = (string)dt.Rows[0]["Cim"];
           
            int ar = (int)dt.Rows[0]["Ar"];
        }

        private void _btnMentes_Click(object sender, EventArgs e)
        {
            string nev = _tboxNev.Text;
            string cim = _tboxCim.Text;
            database.Modosit(rekordid, nev, cim);
            
            Close();
        }

        private void _btnVissza_Click(object sender, EventArgs e)
        {
            Close();
        }        
    }
}
