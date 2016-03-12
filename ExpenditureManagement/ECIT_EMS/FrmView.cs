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
        string add, record = "exp";
        Controller theController;
        DialogResult res;
        public FrmView()
        {
            theController = new Controller(this, "sqlite");
            InitializeComponent();
            dgvRecord.EditMode = DataGridViewEditMode.EditOnEnter;
            theController.TakeQuery("SELECT COUNT(A_ID) FROM acquisition");//, "get amount");
            c = Convert.ToInt32(theController.getOutcome(0));
            dgvRecord.Rows.Add((++c).ToString());

            refreshDropDowns();
        }

        private void refreshDropDowns()
        {
            var catList = new List<string>() { };
            var shopList = new List<string>() { };
            var locList = new List<string>() { };


            theController.TakeQuery("SELECT catName FROM categories;");//, "get categories");
            cats = theController.getAll();
            if (cats != null)
                foreach (var cat in cats)
                {
                    catList.Add(cat.ToString());
                }
            category.DataSource = catList;
            cmbCat.DataSource = catList;

            theController.TakeQuery("SELECT C_name FROM company;");//, "get shops");
            shops = theController.getAll();
            if (shops != null)
                foreach (var shop in shops)
                {
                    shopList.Add(shop.ToString());
                }
            company.DataSource = shopList;
            cmbShop.DataSource = shopList;

            theController.TakeQuery("SELECT L_name FROM locations;");//, "get locations");
            locs = theController.getAll();
            if (locs != null)
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
                switch (record)
                {
                    case "exp":
                        theController.TakeQuery("SELECT catID FROM categories WHERE catName = '" + dgvData[6 + (i * 9)] + "' ");//, "Get Category ID");
                        string cat = theController.getOutcome(0);
                        theController.TakeQuery("SELECT L_ID FROM locations WHERE L_name = '" + dgvData[8 + (i * 9)] + "' ");//, "Get Location ID");
                        string loc = theController.getOutcome(0);
                        theController.TakeQuery("SELECT C_ID FROM company WHERE C_name = '" + dgvData[7 + (i * 9)] + "' ");//, "Get Company ID");
                        string shop = theController.getOutcome(0);
                        string myPrice = dgvData[4 + (i * 9)].ToString();
                        myPrice = myPrice.Replace(',', '.');
                        theController.TakeInsert("INSERT INTO product(P_amount, P_name, P_description, P_price, P_category) VALUES('" + dgvData[1 + (i * 9)] + "','" + dgvData[2 + (i * 9)] + "','" + dgvData[3 + (i * 9)] + "','" + myPrice + "', '" + cat + "')");//, "insert product");
                        string lastID = theController.getSQLiteLastInsert();
                        theController.TakeInsert("INSERT INTO acquisition(A_product, A_date, A_shop, A_loc) VALUES('" + lastID + "', '" + convertDate(dgvData[5 + (i * 9)].ToString()) + "', '" + shop + "', '" + loc + "')");//, "insert acquisition");
                        break;

                    case "ear":
                        break;

                    case "deb":
                        break;

                    case "bor":
                        break;
                }

            }

            rows = 0;

            for (int p = dgvRecord.Rows.Count - 1; p >= 0; p--)
            {
                dgvRecord.Rows.RemoveAt(p);
            }

            theController.TakeQuery("SELECT COUNT(A_ID) FROM acquisition");//, "get amount");
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
            theController.TakeQuery("SELECT COUNT(A_ID) FROM acquisition");//, "get amount");
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
            btnDelEntry.Visible = true;
            dgvRecord.Visible = false;
            btnAddRow.Visible = false;
            btnSend.Visible = false;
            btnRmvRow.Visible = false;
            grpStats.Visible = false;
        }

        private void DocumentationTab_Click(object sender, EventArgs e)
        {
            dgvSearch.Visible = false;
            grpSearch.Visible = false;
            btnDelEntry.Visible = false;
            grpStats.Visible = false;
            dgvRecord.Visible = true;
            btnAddRow.Visible = true;
            btnSend.Visible = true;
            btnRmvRow.Visible = true;
            refreshDropDowns();
        }

        private void btnEnableSearch_Click(object sender, EventArgs e)
        {
            dgvSearch.Visible = true;
            grpStats.Visible = false;
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
                        theController.TakeQuery("SELECT COUNT(*) FROM locations WHERE L_name = '" + txtAdd.Text + "';");//, "check if it already exists");
                        if (theController.getOutcome(0) == "1")
                        {
                            MessageBox.Show(txtAdd.Text + " existiert bereits");
                            return;
                        }
                        res = MessageBox.Show(txtAdd.Text + " als Ort hinzufügen?", "Sind Sie sicher?", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
                        if (res == DialogResult.Yes)
                            theController.TakeInsert("INSERT INTO locations(L_name) VALUES('" + txtAdd.Text + "');");//, "Insert new Location");
                        break;
                    case "shop":
                        theController.TakeQuery("SELECT COUNT(*) FROM company WHERE C_name = '" + txtAdd.Text + "';");//, "check if it already exists");
                        if (theController.getOutcome(0) == "1")
                        {
                            MessageBox.Show(txtAdd.Text + " existiert bereits");
                            return;
                        }
                        res = MessageBox.Show(txtAdd.Text + " als Shop hinzufügen?", "Sind Sie sicher?", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
                        if (res == DialogResult.Yes)
                            theController.TakeInsert("INSERT INTO company(C_name) VALUES('" + txtAdd.Text + "');");//, "Insert new shop");
                        break;
                    case "cat":
                        theController.TakeQuery("SELECT COUNT(*) FROM categories WHERE catName = '" + txtAdd.Text + "';");//, "check if it already exists");
                        if (theController.getOutcome(0) == "1")
                        {
                            MessageBox.Show(txtAdd.Text + " existiert bereits");
                            return;
                        }
                        res = MessageBox.Show(txtAdd.Text + " als Kategorie hinzufügen?", "Sind Sie sicher?", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
                        if (res == DialogResult.Yes)
                            theController.TakeInsert("INSERT INTO categories(catName) VALUES('" + txtAdd.Text + "');");//, "Insert new category");
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
            grpStats.Visible = false;
            grpAdd.Visible = true;
            grpSearch.Visible = true;
            lblAdd.Text = "Lokalität:";
            add = "loc";
        }

        private void btnShopAdd_Click(object sender, EventArgs e)
        {
            grpStats.Visible = false;
            grpAdd.Visible = true;
            grpSearch.Visible = true;
            lblAdd.Text = "Shop:";
            add = "shop";
        }

        private void btnCatAdd_Click(object sender, EventArgs e)
        {
            grpStats.Visible = false;
            grpAdd.Visible = true;
            grpSearch.Visible = true;
            lblAdd.Text = "Kategorie:";
            add = "cat";
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Stopwatch sw = new System.Diagnostics.Stopwatch();
            sw.Start();
            for (int m = dgvSearch.Rows.Count - 1; m >= 0; m--)
            {
                dgvSearch.Rows.RemoveAt(m);
            }
            DataTable dataTable;
            string From = dtpFrom.Value.ToString("yyyy-MM-dd");
            string To = dtpTo.Value.ToString("yyyy-MM-dd");
            string condition_period, condition_category, condition_shop, condition_location, condition_price, condition_keyword;

            if (chbPeriod.Checked)
            {
                condition_period = "A_date BETWEEN '" + From + "' AND '" + To + "'";
            }
            else
            {
                condition_period = "A_date BETWEEN '1000-01-01' AND '9999-12-31'";
            }
            if (chbShop.Checked)
            {
                condition_shop = " AND A_shop = '" + (Convert.ToInt32(cmbShop.SelectedIndex) + 1).ToString() + "'";
            }
            else
            {
                condition_shop = "";
            }
            if (chbLoc.Checked)
            {
                condition_location = " AND A_loc = " + (Convert.ToInt32(cmbLoc.SelectedIndex) + 1).ToString() + "";
                //MessageBox.Show(condition_location);
            }
            else
            {
                condition_location = "";
            }
            if (chbCat.Checked)
            {
                condition_category = " AND A_product IN (SELECT P_ID FROM product WHERE P_category = " + (Convert.ToInt32(cmbCat.SelectedIndex) + 1).ToString() + ")";
            }
            else
            {
                condition_category = "";
            }
            if (chbPrice.Checked)
            {
                condition_price = "";
                if (txtMin.TextLength > 0 && txtMax.TextLength > 0)
                {
                    condition_price = " AND A_product IN (SELECT P_ID FROM product WHERE P_price >= '" + (txtMin.Text).Replace(',', '.') + "') AND A_product IN (SELECT P_ID FROM product WHERE P_price <= '" + (txtMax.Text).Replace(',', '.') + "')";
                }
                else if (txtMin.TextLength > 0)
                {
                    condition_price = " AND A_product IN (SELECT P_ID FROM product WHERE P_price >= '" + (txtMin.Text).Replace(',', '.') + "')";
                }
                else if (txtMax.TextLength > 0)
                {
                    condition_price = " AND A_product IN (SELECT P_ID FROM product WHERE P_price <= '" + (txtMax.Text).Replace(',', '.') + "')";
                }

            }
            else
            {
                condition_price = "";
            }
            if (chbKeyWord.Checked)
            {
                condition_keyword = " AND A_product IN (SELECT P_ID FROM product WHERE P_name LIKE '%" + txtKeyWord.Text + "%')";
            }
            else
            {
                condition_keyword = "";
            }


            dataTable = theController.fetch("SELECT A_product, A_shop, A_date, A_loc, A_ID FROM acquisition WHERE " + condition_period + condition_shop + condition_location + condition_category + condition_price + condition_keyword);//, "");


            foreach (DataRow drow in dataTable.Rows)
            {
                theController.TakeQuery("SELECT P_name FROM product WHERE P_ID = '" + drow[0].ToString() + "'");//, "get productname by ID");
                string name = theController.getOutcome(0);
                theController.TakeQuery("SELECT P_description FROM product WHERE P_ID = '" + drow[0].ToString() + "'");//, "get description by ID");
                string description = theController.getOutcome(0);
                theController.TakeQuery("SELECT P_price FROM product WHERE P_ID = '" + drow[0].ToString() + "'");//, "get price by ID");
                string price = theController.getOutcome(0);
                theController.TakeQuery("SELECT C_name FROM company WHERE C_ID = '" + drow[1].ToString() + "'");//, "get shopname by ID");
                string shop = theController.getOutcome(0);
                theController.TakeQuery("SELECT P_category FROM product WHERE P_ID = '" + drow[0].ToString() + "'");//, "get catID by product_ID");
                string catID = theController.getOutcome(0);
                theController.TakeQuery("SELECT catName FROM categories WHERE catID = '" + catID + "'");//, "get categoryname by ID");
                string cat = theController.getOutcome(0);
                theController.TakeQuery("SELECT L_name FROM locations WHERE L_ID = '" + drow[3].ToString() + "'");//, "get locationname by ID");
                string loc = theController.getOutcome(0);
                theController.TakeQuery("SELECT P_amount FROM product WHERE P_ID = '" + drow[0].ToString() + "'");//, "get amount by ID");
                string am = theController.getOutcome(0);

                dgvSearch.Rows.Add(drow[4], am, name, description, price, drow[2], cat, shop, loc);
            }
            double a = sw.ElapsedMilliseconds;
            sw.Stop();

            int b = dgvSearch.Rows.Count;
            if (b == 1)
            {
                lblInfo.Text = b + " Eintrag in " + (a / 1000).ToString() + " Sekunden gefunden.";
            }
            else
            {
                lblInfo.Text = b + " Einträge in " + (a / 1000).ToString() + " Sekunden gefunden.";
            }
        }

        private void btnDelEntry_Click(object sender, EventArgs e)
        {
            if (dgvSearch.Rows.Count > 0 && dgvSearch.CurrentRow.Index >= 0)
            {
                string delRecord = dgvSearch.CurrentRow.Cells[0].Value.ToString();
                string delP_ID, nameP;
                theController.TakeQuery("SELECT A_product FROM acquisition WHERE A_ID = '" + delRecord + "' ");//, "");
                delP_ID = theController.getOutcome(0);
                theController.TakeQuery("SELECT P_name FROM product WHERE P_ID = '" + delP_ID + "'");//, "");
                nameP = theController.getOutcome(0);
                res = MessageBox.Show(nameP + " wirklich löschen ?", "Sind Sie sicher?", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (res == DialogResult.Yes)
                {
                    theController.TakeInsert("DELETE FROM product WHERE P_ID = '" + delP_ID + "'");//, "Delete selected record");
                    theController.TakeInsert("DELETE FROM acquisition WHERE A_ID = '" + delRecord + "'");//, "Delete selected record");
                    dgvSearch.Rows.Remove(dgvSearch.CurrentRow);
                    res = DialogResult.None;
                }
            }
            else
            {
                MessageBox.Show("Nichts zum Löschen vorhanden.", "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnStats_Click(object sender, EventArgs e)
        {
            grpStats.Visible = true;
            grpSearch.Visible = false;
            dgvSearch.Visible = false;
            btnDelEntry.Visible = false;
        }

        private void btnExpenses_Click(object sender, EventArgs e)
        {
            record = "exp";

            //dgvRecord.DataSource = null;
            //dgvRecord.Columns.Add("A_ID", "Nr.");
            //dgvRecord.Columns.Add("amount", "Menge");
            //dgvRecord.Columns.Add("product", "Gegenstand");
            //dgvRecord.Columns.Add("description", "Beschreibung");
            //dgvRecord.Columns.Add("price", "Preis in €");
            //// DataGridViewDateTimeInputColumn dat = new DataGridViewDateTimeInputColumn();
            //dgvRecord.Columns.Add("date", "Datum");
            //dgvRecord.Columns.Add("category", "Kategorie");
            //dgvRecord.Columns.Add("shop", "Shop");
            //dgvRecord.Columns.Add("location", "Ort");
            //DataGridViewTextBoxColumn col = new DataGridViewTextBoxColumn();
            //dgvRecord.Columns.Add(col);
            btnEarnings.ForeColor = Color.Black;
            btnFixcosts.ForeColor = Color.Black;
            btnBankaccount.ForeColor = Color.Black;
            btnDebts.ForeColor = Color.Black;
            btnBorrow.ForeColor = Color.Black;
            btnExpenses.ForeColor = Color.OrangeRed;
        }

        private void btnEarnings_Click(object sender, EventArgs e)
        {
            record = "ear";

            btnExpenses.ForeColor = Color.Black;
            btnFixcosts.ForeColor = Color.Black;
            btnDebts.ForeColor = Color.Black;
            btnBankaccount.ForeColor = Color.Black;
            btnBorrow.ForeColor = Color.Black;
            btnEarnings.ForeColor = Color.OrangeRed;
        }

        private void btnBorrow_Click(object sender, EventArgs e)
        {
            record = "bor";

            btnExpenses.ForeColor = Color.Black;
            btnDebts.ForeColor = Color.Black;
            btnEarnings.ForeColor = Color.Black;
            btnFixcosts.ForeColor = Color.Black;
            btnBankaccount.ForeColor = Color.Black;
            btnBorrow.ForeColor = Color.OrangeRed;
        }

        private void btnDebts_Click(object sender, EventArgs e)
        {
            record = "deb";

            btnExpenses.ForeColor = Color.Black;
            btnBorrow.ForeColor = Color.Black;
            btnEarnings.ForeColor = Color.Black;
            btnFixcosts.ForeColor = Color.Black;
            btnBankaccount.ForeColor = Color.Black;
            btnDebts.ForeColor = Color.OrangeRed;
        }

        private void btnFixcosts_Click(object sender, EventArgs e)
        {
            btnExpenses.ForeColor = Color.Black;
            btnEarnings.ForeColor = Color.Black;
            btnDebts.ForeColor = Color.Black;
            btnBankaccount.ForeColor = Color.Black;
            btnBorrow.ForeColor = Color.Black;
            btnFixcosts.ForeColor = Color.OrangeRed;
        }

        private void btnBankaccount_Click(object sender, EventArgs e)
        {
            btnExpenses.ForeColor = Color.Black;
            btnEarnings.ForeColor = Color.Black;
            btnFixcosts.ForeColor = Color.Black;
            btnBorrow.ForeColor = Color.Black;
            btnDebts.ForeColor = Color.Black;
            btnBankaccount.ForeColor = Color.OrangeRed;
        }


        private void onKeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && dgvRecord.Focus())
            {
                theController.TakeQuery("SELECT COUNT(A_ID) FROM acquisition");//, "get amount");
                c = Convert.ToInt32(theController.getOutcome(0));
                c += dgvRecord.Rows.Count;
                dgvRecord.Rows.Add((++c).ToString());
            }
        }
    }
}
