using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;
using DevComponents.DotNetBar;

namespace ECIT_EMS
{
    public partial class FrmView : Office2007Form
    {
        private ArrayList dgvData = new ArrayList();
        private ArrayList cats = new ArrayList();
        private ArrayList shops = new ArrayList();
        private ArrayList locs = new ArrayList();

        private int c, rows = 0;
        Controller theController;
        public FrmView()
        {
            var catList = new List<string>() {};
            var shopList = new List<string>() {};
            var locList = new List<string>() {};

            theController = new Controller(this);
            InitializeComponent();
            theController.TakeQuery("SELECT Active FROM firstaccess", "first use?");
            if (Convert.ToInt32(theController.getOutcome(0)) == 0)
            {
                c = 0;
                theController.TakeInsert("UPDATE firstaccess SET Active = 1", "first used");
            }
            else
            {
                theController.TakeQuery("SELECT MAX(A_ID) FROM acquisition", "get highest ID");
                c = Convert.ToInt32(theController.getOutcome(0));
            }
            dgvRecord.Rows.Add(c.ToString());

            theController.TakeQuery("SELECT catName FROM categories","get categories");
            cats = theController.getAll();
            foreach (var cat in cats)
            {
                catList.Add(cat.ToString());
            }
            category.DataSource = catList;

            theController.TakeQuery("SELECT C_name FROM company", "get shops");
            shops = theController.getAll();
            foreach (var shop in shops)
            {
                shopList.Add(shop.ToString());
            }
            company.DataSource = shopList;
            
            theController.TakeQuery("SELECT L_name FROM locations", "get locations");
            locs = theController.getAll();
            foreach (var loc in locs)
            {
                locList.Add(loc.ToString());
            }
            location.DataSource = locList;
            
        }


        private void btnSend_Click(object sender, EventArgs e)
        {

            foreach (DataGridViewRow y in dgvRecord.Rows)
            {
                ++rows;
                foreach (DataGridViewCell x in y.Cells)
                {
                    if (x.Value == null || x.Value.Equals(""))
                    {
                        x.Value = "none";
                    }
                    dgvData.Add(x.Value.ToString());

                }
            }



            for (int i = 0; i < rows; i++)
            {
                theController.TakeInsert("INSERT INTO product(P_name, P_description, P_price, P_category) VALUES('" + dgvData[1 + (i * 8)] + "','" + dgvData[2 + (i * 8)] + "','" + dgvData[3 + (i * 8)] + "', '" + dgvData[5 + (i * 8)] + "')", "insert product");
                string lastID = theController.getLastInsert();
                theController.TakeInsert("INSERT INTO acquisition(A_product, A_date, A_shop) VALUES('"+ lastID +"', '"+ dgvData[4 +(i*8)] +"', '"+ dgvData[6 + (i * 8)] + "')", "insert acquisition");
            }

            rows = 0;
        }

        private void onKeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && dgvRecord.Focus())
            {
                ++c;
                dgvRecord.Rows.Add(c.ToString());
            }
        }
    }
}
