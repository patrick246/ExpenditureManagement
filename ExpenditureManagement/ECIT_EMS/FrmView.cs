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
        private ArrayList searchData = new ArrayList();

        private int c, rows = 0;
        string add;
        Controller theController;
        DialogResult res;
        public FrmView()
        {


            theController = new Controller(this);
            InitializeComponent();
            dgvRecord.EditMode = DataGridViewEditMode.EditOnEnter;
            theController.TakeQuery("SELECT COUNT(A_ID) FROM acquisition", "get amount");
            c = Convert.ToInt32(theController.getOutcome(0));

            dgvRecord.Rows.Add((++c).ToString());

            refreshDropDowns();

        }

        private void refreshDropDowns()
        {
            var catList = new List<string>() { };
            var shopList = new List<string>() { };
            var locList = new List<string>() { };

            theController.TakeQuery("SELECT catName FROM categories", "get categories");
            cats = theController.getAll();
            foreach (var cat in cats)
            {
                catList.Add(cat.ToString());
            }
            category.DataSource = catList;
            cmbCat.DataSource = catList;

            theController.TakeQuery("SELECT C_name FROM company", "get shops");
            shops = theController.getAll();
            foreach (var shop in shops)
            {
                shopList.Add(shop.ToString());
            }
            company.DataSource = shopList;
            cmbShop.DataSource = shopList;

            theController.TakeQuery("SELECT L_name FROM locations", "get locations");
            locs = theController.getAll();
            foreach (var loc in locs)
            {
                locList.Add(loc.ToString());
            }
            location.DataSource = locList;
            cmbLoc.DataSource = locList;
        }

        private void btnSend_Click(object sender, EventArgs e)
        {


            foreach (DataGridViewRow y in dgvRecord.Rows)
            {
                ++rows;

                if (y.Cells[6].Value == null)
                {
                    MessageBox.Show("Wähle eine Kategorie aus.");
                    rows = 0;
                    return;
                }
                if (y.Cells[8].Value == null)
                {
                    MessageBox.Show("Wähle einen Ort aus.");
                    rows = 0;
                    return;
                }
                if (y.Cells[7].Value == null)
                {
                    MessageBox.Show("Wähle einen Shop aus.");
                    rows = 0;
                    return;
                }
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

                theController.TakeQuery("SELECT catID FROM categories WHERE catName = '" + dgvData[6 + (i * 9)] + "' ", "Get Category ID");
                string cat = theController.getOutcome(0);
                theController.TakeQuery("SELECT L_ID FROM locations WHERE L_name = '" + dgvData[8 + (i * 9)] + "' ", "Get Location ID");
                string loc = theController.getOutcome(0);
                theController.TakeQuery("SELECT C_ID FROM company WHERE C_name = '" + dgvData[7 + (i * 9)] + "' ", "Get Company ID");
                string shop = theController.getOutcome(0);
                string myPrice = dgvData[4 + (i * 9)].ToString();
                myPrice = myPrice.Replace(',', '.');
                theController.TakeInsert("INSERT INTO product(P_amount, P_name, P_description, P_price, P_category) VALUES('" + dgvData[1 + (i * 9)] + "','" + dgvData[2 + (i * 9)] + "','" + dgvData[3 + (i * 9)] + "','" + myPrice + "', '" + cat + "')", "insert product");
                string lastID = theController.getLastInsert();
                theController.TakeInsert("INSERT INTO acquisition(A_product, A_date, A_shop, A_loc) VALUES('" + lastID + "', '" + convertDate(dgvData[5 + (i * 9)].ToString()) + "', '" + shop + "', '" + loc + "')", "insert acquisition");
            }

            rows = 0;

            for (int p = dgvRecord.Rows.Count - 1; p >= 0; p--)
            {
                dgvRecord.Rows.RemoveAt(p);
            }

            theController.TakeQuery("SELECT COUNT(A_ID) FROM acquisition", "get amount");
            c = Convert.ToInt32(theController.getOutcome(0));
            dgvRecord.Rows.Add((++c).ToString());
            dgvData.Clear();
        }

        private void btnRmvRow_Click(object sender, EventArgs e)
        {
            res = MessageBox.Show("Sind Sie sicher, dass sie die ausgwählte Zeile löschen möchten?", "Achtung!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);
            if (res == DialogResult.Yes)
            {
                c = dgvRecord.CurrentCell.RowIndex;
                dgvRecord.Rows.Remove(dgvRecord.CurrentRow);
                for (int z = c; z < dgvRecord.RowCount; z++)
                {
                    int u = Convert.ToInt32(dgvRecord.Rows[z].Cells[0].Value);
                    --u;
                    dgvRecord.Rows[z].Cells[0].Value = u;
                }
            }
            res = DialogResult.None;
        }
        private void btnAddRow_Click(object sender, EventArgs e)
        {

            theController.TakeQuery("SELECT COUNT(A_ID) FROM acquisition", "get amount");
            c = Convert.ToInt32(theController.getOutcome(0));
            c += dgvRecord.Rows.Count;
            dgvRecord.Rows.Add((++c).ToString());
        }

        private string convertDate(string date)
        {
            if (date == "none")
            {
                date = "00.00.0000 leer";
            }
            date = date.Split(' ')[0];
            string[] spl = date.Split('.');
            return date = spl[2] + "-" + spl[1] + "-" + spl[0];
        }

        private void AnalysisTab_Click(object sender, EventArgs e)
        {
            dgvSearch.Visible = true;

            dgvRecord.Visible = false;
            btnAddRow.Visible = false;
            btnSend.Visible = false;
            btnRmvRow.Visible = false;
        }

        private void DocumentationTab_Click(object sender, EventArgs e)
        {
            dgvSearch.Visible = false;
            grpSearch.Visible = false;
            dgvRecord.Visible = true;
            btnAddRow.Visible = true;
            btnSend.Visible = true;
            btnRmvRow.Visible = true;
            refreshDropDowns();
        }

        private void btnEnableSearch_Click(object sender, EventArgs e)
        {
            if (grpAdd.Visible && grpSearch.Visible)
            {
                grpAdd.Visible = false;
                return;
            }
            grpAdd.Visible = false;
            if (grpSearch.Visible == false)
            {
                grpSearch.Visible = true;
            }
            else
            {
                grpSearch.Visible = false;
            }
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (txtAdd.Text.Length > 0)
            {
                switch (add)
                {
                    case "loc":
                        res = MessageBox.Show(txtAdd.Text + " als Ort hinzufügen?", "Sind Sie sicher?", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
                        if (res == DialogResult.Yes)
                            theController.TakeInsert("INSERT INTO locations(L_name) VALUES('" + txtAdd.Text + "')", "Insert new Location");
                        break;
                    case "shop":
                        res = MessageBox.Show(txtAdd.Text + " als Shop hinzufügen?", "Sind Sie sicher?", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
                        if (res == DialogResult.Yes)
                            theController.TakeInsert("INSERT INTO company(C_name) VALUES('" + txtAdd.Text + "')", "Insert new shop");
                        break;
                    case "cat":
                        res = MessageBox.Show(txtAdd.Text + " als Kategorie hinzufügen?", "Sind Sie sicher?", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
                        if (res == DialogResult.Yes)
                            theController.TakeInsert("INSERT INTO categories(catName) VALUES('" + txtAdd.Text + "')", "Insert new category");
                        break;
                }
            }
            else
            {
                MessageBox.Show("Geben Sie ein Objekt ein, das hinzugefügt werden soll.");
            }
            res = DialogResult.None;
            txtAdd.Clear();
        }
        private void btnLocAdd_Click(object sender, EventArgs e)
        {
            grpAdd.Visible = true;
            grpSearch.Visible = true;
            lblAdd.Text = "Lokalität:";
            add = "loc";
        }

        private void btnShopAdd_Click(object sender, EventArgs e)
        {
            grpAdd.Visible = true;
            grpSearch.Visible = true;
            lblAdd.Text = "Shop:";
            add = "shop";
        }

        private void btnCatAdd_Click(object sender, EventArgs e)
        {
            grpAdd.Visible = true;
            grpSearch.Visible = true;
            lblAdd.Text = "Kategorie:";
            add = "cat";
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            for (int m = dgvSearch.Rows.Count - 1; m >= 0; m--)
            {
                dgvSearch.Rows.RemoveAt(m);
            }
            DataTable dataTable;
            string From = dtpFrom.Value.ToString("yyyy-MM-dd");
            string To = dtpTo.Value.ToString("yyyy-MM-dd");
            string condition_period, condition_category, condition_shop, condition_location;

            if (chbPeriod.Checked)
            {
                condition_period = "A_date BETWEEN '" + From + "' AND '" + To + "'";
            }
            else
            {
                condition_period = "A_date BETWEEN '1000-01-01' AND '9999-12-31'";
                MessageBox.Show(From);
            }
            if (chbShop.Checked)
            {
                condition_shop = " AND A_shop = '" + (Convert.ToInt32(cmbShop.SelectedIndex) + 1).ToString() + "'";
                MessageBox.Show((Convert.ToInt32(cmbShop.SelectedIndex) + 1).ToString());
            }
            else
            {
                condition_shop = "";
            }
            if (chbLoc.Checked)
            {
                condition_location = " AND A_loc = '" + (Convert.ToInt32(cmbLoc.SelectedIndex) + 1).ToString() + "'";
            }
            else
            {
                condition_location = "";
            }

            if (chbCat.Checked)
            {
                condition_category = " AND A_product IN (SELECT P_ID FROM product WHERE P_category = '" + (Convert.ToInt32(cmbCat.SelectedIndex) + 1).ToString() + "')";
            }
            else
            {
                condition_category = "";
            }

            dataTable = theController.fetch("SELECT A_product, A_shop, A_date, A_loc, A_ID FROM acquisition WHERE " + condition_period + condition_shop + condition_location + condition_category, "");


            foreach (DataRow drow in dataTable.Rows)
            {
                theController.TakeQuery("SELECT P_name FROM product WHERE P_ID = '" + drow[0].ToString() + "'", "get productname by ID");
                string name = theController.getOutcome(0);
                theController.TakeQuery("SELECT P_description FROM product WHERE P_ID = '" + drow[0].ToString() + "'", "get description by ID");
                string description = theController.getOutcome(0);
                theController.TakeQuery("SELECT P_price FROM product WHERE P_ID = '" + drow[0].ToString() + "'", "get price by ID");
                string price = theController.getOutcome(0);
                theController.TakeQuery("SELECT C_name FROM company WHERE C_ID = '" + drow[1].ToString() + "'", "get shopname by ID");
                string shop = theController.getOutcome(0);
                theController.TakeQuery("SELECT P_category FROM product WHERE P_ID = '" + drow[0].ToString() + "'", "get catID by product_ID");
                string catID = theController.getOutcome(0);
                theController.TakeQuery("SELECT catName FROM categories WHERE catID = '" + catID + "'", "get categoryname by ID");
                string cat = theController.getOutcome(0);
                theController.TakeQuery("SELECT L_name FROM locations WHERE L_ID = '" + drow[3].ToString() + "'", "get locationname by ID");
                string loc = theController.getOutcome(0);
                theController.TakeQuery("SELECT P_amount FROM product WHERE P_ID = '" + drow[0].ToString() + "'", "get amount by ID");
                string am = theController.getOutcome(0);

                dgvSearch.Rows.Add(drow[4], am, name, description, price, drow[2], cat, shop, loc);
            }



        }



        private void onKeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && dgvRecord.Focus())
            {
                theController.TakeQuery("SELECT COUNT(A_ID) FROM acquisition", "get amount");
                c = Convert.ToInt32(theController.getOutcome(0));
                c += dgvRecord.Rows.Count;
                dgvRecord.Rows.Add((++c).ToString());
            }
        }
    }
}
