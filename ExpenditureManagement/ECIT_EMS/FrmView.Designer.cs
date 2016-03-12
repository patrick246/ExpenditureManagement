namespace ECIT_EMS
{
    partial class FrmView
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvRecord = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.A_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.amount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.p_description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.date = new DevComponents.DotNetBar.Controls.DataGridViewDateTimeInputColumn();
            this.category = new DevComponents.DotNetBar.Controls.DataGridViewComboBoxExColumn();
            this.company = new DevComponents.DotNetBar.Controls.DataGridViewComboBoxExColumn();
            this.location = new DevComponents.DotNetBar.Controls.DataGridViewComboBoxExColumn();
            this.styleManager1 = new DevComponents.DotNetBar.StyleManager(this.components);
            this.btnSend = new DevComponents.DotNetBar.ButtonX();
            this.btnRmvRow = new DevComponents.DotNetBar.ButtonX();
            this.btnAddRow = new DevComponents.DotNetBar.ButtonX();
            this.ribbonControl1 = new DevComponents.DotNetBar.RibbonControl();
            this.ribbonPanel1 = new DevComponents.DotNetBar.RibbonPanel();
            this.ribbonDebts = new DevComponents.DotNetBar.RibbonBar();
            this.btnBorrow = new DevComponents.DotNetBar.ButtonItem();
            this.btnDebts = new DevComponents.DotNetBar.ButtonItem();
            this.ribbonManager = new DevComponents.DotNetBar.RibbonBar();
            this.btnEarnings = new DevComponents.DotNetBar.ButtonItem();
            this.btnExpenses = new DevComponents.DotNetBar.ButtonItem();
            this.btnFixcosts = new DevComponents.DotNetBar.ButtonItem();
            this.btnBankaccount = new DevComponents.DotNetBar.ButtonItem();
            this.ribbonPanel2 = new DevComponents.DotNetBar.RibbonPanel();
            this.ribbonBar3 = new DevComponents.DotNetBar.RibbonBar();
            this.btnEnableSearch = new DevComponents.DotNetBar.ButtonItem();
            this.btnStats = new DevComponents.DotNetBar.ButtonItem();
            this.ribbonBar2 = new DevComponents.DotNetBar.RibbonBar();
            this.btnLocAdd = new DevComponents.DotNetBar.ButtonItem();
            this.btnShopAdd = new DevComponents.DotNetBar.ButtonItem();
            this.btnCatAdd = new DevComponents.DotNetBar.ButtonItem();
            this.office2007StartbtnAdd = new DevComponents.DotNetBar.Office2007StartButton();
            this.itemContainer1 = new DevComponents.DotNetBar.ItemContainer();
            this.itemContainer2 = new DevComponents.DotNetBar.ItemContainer();
            this.itemContainer3 = new DevComponents.DotNetBar.ItemContainer();
            this.buttonItem6 = new DevComponents.DotNetBar.ButtonItem();
            this.buttonItem7 = new DevComponents.DotNetBar.ButtonItem();
            this.galleryContainer1 = new DevComponents.DotNetBar.GalleryContainer();
            this.itemContainer4 = new DevComponents.DotNetBar.ItemContainer();
            this.buttonItem12 = new DevComponents.DotNetBar.ButtonItem();
            this.buttonItem13 = new DevComponents.DotNetBar.ButtonItem();
            this.DocumentationTab = new DevComponents.DotNetBar.RibbonTabItem();
            this.AnalysisTab = new DevComponents.DotNetBar.RibbonTabItem();
            this.styleManager2 = new DevComponents.DotNetBar.StyleManager(this.components);
            this.dgvSearch = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.Search_nr = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Search_amount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Search_product = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Search_description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Search_price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Search_date = new DevComponents.DotNetBar.Controls.DataGridViewDateTimeInputColumn();
            this.Search_category = new DevComponents.DotNetBar.Controls.DataGridViewComboBoxExColumn();
            this.Search_shop = new DevComponents.DotNetBar.Controls.DataGridViewComboBoxExColumn();
            this.Search_location = new DevComponents.DotNetBar.Controls.DataGridViewComboBoxExColumn();
            this.dtpFrom = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dtpTo = new System.Windows.Forms.DateTimePicker();
            this.cmbCat = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbShop = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbLoc = new System.Windows.Forms.ComboBox();
            this.grpSearch = new System.Windows.Forms.GroupBox();
            this.grpAdd = new System.Windows.Forms.GroupBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.txtAdd = new System.Windows.Forms.TextBox();
            this.lblAdd = new System.Windows.Forms.Label();
            this.txtKeyWord = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.chbPrice = new System.Windows.Forms.CheckBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtMax = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txtMin = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.label7 = new System.Windows.Forms.Label();
            this.chbShop = new System.Windows.Forms.CheckBox();
            this.label6 = new System.Windows.Forms.Label();
            this.chbPeriod = new System.Windows.Forms.CheckBox();
            this.chbLoc = new System.Windows.Forms.CheckBox();
            this.chbCat = new System.Windows.Forms.CheckBox();
            this.chbKeyWord = new System.Windows.Forms.CheckBox();
            this.btnDelEntry = new System.Windows.Forms.Button();
            this.grpStats = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lblInfo = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRecord)).BeginInit();
            this.ribbonControl1.SuspendLayout();
            this.ribbonPanel1.SuspendLayout();
            this.ribbonPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSearch)).BeginInit();
            this.grpSearch.SuspendLayout();
            this.grpAdd.SuspendLayout();
            this.grpStats.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvRecord
            // 
            this.dgvRecord.AllowUserToAddRows = false;
            this.dgvRecord.AllowUserToResizeRows = false;
            this.dgvRecord.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvRecord.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvRecord.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvRecord.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.A_ID,
            this.amount,
            this.productname,
            this.p_description,
            this.price,
            this.date,
            this.category,
            this.company,
            this.location});
            dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle13.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle13.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle13.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle13.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle13.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle13.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvRecord.DefaultCellStyle = dataGridViewCellStyle13;
            this.dgvRecord.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnKeystroke;
            this.dgvRecord.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(170)))), ((int)(((byte)(170)))));
            this.dgvRecord.Location = new System.Drawing.Point(0, 105);
            this.dgvRecord.Name = "dgvRecord";
            this.dgvRecord.RowHeadersVisible = false;
            this.dgvRecord.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvRecord.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgvRecord.SelectAllSignVisible = false;
            this.dgvRecord.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvRecord.ShowEditingIcon = false;
            this.dgvRecord.Size = new System.Drawing.Size(1278, 351);
            this.dgvRecord.TabIndex = 0;
            this.dgvRecord.KeyUp += new System.Windows.Forms.KeyEventHandler(this.onKeyUp);
            // 
            // A_ID
            // 
            this.A_ID.HeaderText = "Nr.";
            this.A_ID.Name = "A_ID";
            // 
            // amount
            // 
            this.amount.HeaderText = "Menge";
            this.amount.Name = "amount";
            // 
            // productname
            // 
            this.productname.HeaderText = "Gegenstand";
            this.productname.Name = "productname";
            // 
            // p_description
            // 
            this.p_description.HeaderText = "Beschreibung";
            this.p_description.Name = "p_description";
            // 
            // price
            // 
            this.price.HeaderText = "Preis in €";
            this.price.Name = "price";
            // 
            // date
            // 
            this.date.HeaderText = "Datum";
            this.date.InputHorizontalAlignment = DevComponents.Editors.eHorizontalAlignment.Left;
            // 
            // 
            // 
            this.date.MonthCalendar.AnnuallyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this.date.MonthCalendar.BackgroundStyle.BackColor = System.Drawing.SystemColors.Window;
            this.date.MonthCalendar.BackgroundStyle.Class = "";
            this.date.MonthCalendar.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.date.MonthCalendar.CommandsBackgroundStyle.Class = "";
            this.date.MonthCalendar.CommandsBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.date.MonthCalendar.DisplayMonth = new System.DateTime(2016, 2, 1, 0, 0, 0, 0);
            this.date.MonthCalendar.FirstDayOfWeek = System.DayOfWeek.Monday;
            this.date.MonthCalendar.MarkedDates = new System.DateTime[0];
            this.date.MonthCalendar.MonthlyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this.date.MonthCalendar.NavigationBackgroundStyle.Class = "";
            this.date.MonthCalendar.NavigationBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.date.MonthCalendar.WeeklyMarkedDays = new System.DayOfWeek[0];
            this.date.Name = "date";
            // 
            // category
            // 
            this.category.DropDownHeight = 106;
            this.category.DropDownWidth = 121;
            this.category.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.category.HeaderText = "Kategorie";
            this.category.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.category.IntegralHeight = false;
            this.category.ItemHeight = 13;
            this.category.MaxDropDownItems = 20;
            this.category.Name = "category";
            this.category.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.category.RightToLeft = System.Windows.Forms.RightToLeft.No;
            // 
            // company
            // 
            this.company.DropDownHeight = 106;
            this.company.DropDownWidth = 121;
            this.company.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.company.HeaderText = "Shop";
            this.company.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.company.IntegralHeight = false;
            this.company.ItemHeight = 13;
            this.company.Name = "company";
            this.company.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.company.RightToLeft = System.Windows.Forms.RightToLeft.No;
            // 
            // location
            // 
            this.location.DropDownHeight = 106;
            this.location.DropDownWidth = 121;
            this.location.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.location.HeaderText = "Ort";
            this.location.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.location.IntegralHeight = false;
            this.location.ItemHeight = 13;
            this.location.Name = "location";
            this.location.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.location.RightToLeft = System.Windows.Forms.RightToLeft.No;
            // 
            // styleManager1
            // 
            this.styleManager1.ManagerStyle = DevComponents.DotNetBar.eStyle.Office2010Black;
            // 
            // btnSend
            // 
            this.btnSend.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnSend.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSend.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnSend.Location = new System.Drawing.Point(1151, 587);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(115, 39);
            this.btnSend.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnSend.TabIndex = 1;
            this.btnSend.Text = "Eintragen";
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // btnRmvRow
            // 
            this.btnRmvRow.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnRmvRow.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnRmvRow.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnRmvRow.Location = new System.Drawing.Point(12, 572);
            this.btnRmvRow.Name = "btnRmvRow";
            this.btnRmvRow.Size = new System.Drawing.Size(87, 24);
            this.btnRmvRow.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnRmvRow.TabIndex = 2;
            this.btnRmvRow.Text = "Zeile löschen";
            this.btnRmvRow.Click += new System.EventHandler(this.btnRmvRow_Click);
            // 
            // btnAddRow
            // 
            this.btnAddRow.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnAddRow.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnAddRow.AutoSize = true;
            this.btnAddRow.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnAddRow.Location = new System.Drawing.Point(12, 602);
            this.btnAddRow.Name = "btnAddRow";
            this.btnAddRow.Size = new System.Drawing.Size(87, 24);
            this.btnAddRow.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnAddRow.TabIndex = 3;
            this.btnAddRow.Text = "Zeile hinzufügen";
            this.btnAddRow.Click += new System.EventHandler(this.btnAddRow_Click);
            // 
            // ribbonControl1
            // 
            // 
            // 
            // 
            this.ribbonControl1.BackgroundStyle.Class = "";
            this.ribbonControl1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.ribbonControl1.CaptionVisible = true;
            this.ribbonControl1.Controls.Add(this.ribbonPanel1);
            this.ribbonControl1.Controls.Add(this.ribbonPanel2);
            this.ribbonControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.ribbonControl1.Items.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.office2007StartbtnAdd,
            this.DocumentationTab,
            this.AnalysisTab});
            this.ribbonControl1.KeyTipsFont = new System.Drawing.Font("Tahoma", 7F);
            this.ribbonControl1.Location = new System.Drawing.Point(0, 0);
            this.ribbonControl1.Name = "ribbonControl1";
            this.ribbonControl1.Padding = new System.Windows.Forms.Padding(0, 0, 0, 2);
            this.ribbonControl1.Size = new System.Drawing.Size(1278, 101);
            this.ribbonControl1.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.ribbonControl1.TabGroupHeight = 14;
            this.ribbonControl1.TabIndex = 4;
            this.ribbonControl1.Text = "ribbonControl1";
            // 
            // ribbonPanel1
            // 
            this.ribbonPanel1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.ribbonPanel1.Controls.Add(this.ribbonDebts);
            this.ribbonPanel1.Controls.Add(this.ribbonManager);
            this.ribbonPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ribbonPanel1.Location = new System.Drawing.Point(0, 53);
            this.ribbonPanel1.Name = "ribbonPanel1";
            this.ribbonPanel1.Padding = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.ribbonPanel1.Size = new System.Drawing.Size(1278, 46);
            // 
            // 
            // 
            this.ribbonPanel1.Style.Class = "";
            this.ribbonPanel1.Style.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.ribbonPanel1.StyleMouseDown.Class = "";
            this.ribbonPanel1.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.ribbonPanel1.StyleMouseOver.Class = "";
            this.ribbonPanel1.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.ribbonPanel1.TabIndex = 1;
            // 
            // ribbonDebts
            // 
            this.ribbonDebts.AutoOverflowEnabled = true;
            // 
            // 
            // 
            this.ribbonDebts.BackgroundMouseOverStyle.Class = "";
            this.ribbonDebts.BackgroundMouseOverStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.ribbonDebts.BackgroundStyle.Class = "";
            this.ribbonDebts.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.ribbonDebts.ContainerControlProcessDialogKey = true;
            this.ribbonDebts.Dock = System.Windows.Forms.DockStyle.Left;
            this.ribbonDebts.Items.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.btnBorrow,
            this.btnDebts});
            this.ribbonDebts.Location = new System.Drawing.Point(237, 0);
            this.ribbonDebts.Name = "ribbonDebts";
            this.ribbonDebts.Size = new System.Drawing.Size(100, 43);
            this.ribbonDebts.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.ribbonDebts.TabIndex = 1;
            this.ribbonDebts.Text = "Leihgaben";
            // 
            // 
            // 
            this.ribbonDebts.TitleStyle.Class = "";
            this.ribbonDebts.TitleStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.ribbonDebts.TitleStyleMouseOver.Class = "";
            this.ribbonDebts.TitleStyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // btnBorrow
            // 
            this.btnBorrow.Name = "btnBorrow";
            this.btnBorrow.SubItemsExpandWidth = 14;
            this.btnBorrow.Text = "Verleih";
            this.btnBorrow.Click += new System.EventHandler(this.btnBorrow_Click);
            // 
            // btnDebts
            // 
            this.btnDebts.Name = "btnDebts";
            this.btnDebts.SubItemsExpandWidth = 14;
            this.btnDebts.Text = "Schulden";
            this.btnDebts.Click += new System.EventHandler(this.btnDebts_Click);
            // 
            // ribbonManager
            // 
            this.ribbonManager.AutoOverflowEnabled = true;
            // 
            // 
            // 
            this.ribbonManager.BackgroundMouseOverStyle.Class = "";
            this.ribbonManager.BackgroundMouseOverStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.ribbonManager.BackgroundStyle.Class = "";
            this.ribbonManager.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.ribbonManager.ContainerControlProcessDialogKey = true;
            this.ribbonManager.Dock = System.Windows.Forms.DockStyle.Left;
            this.ribbonManager.Items.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.btnEarnings,
            this.btnExpenses,
            this.btnFixcosts,
            this.btnBankaccount});
            this.ribbonManager.Location = new System.Drawing.Point(3, 0);
            this.ribbonManager.Name = "ribbonManager";
            this.ribbonManager.Size = new System.Drawing.Size(234, 43);
            this.ribbonManager.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.ribbonManager.TabIndex = 0;
            this.ribbonManager.Text = "Verwaltung";
            // 
            // 
            // 
            this.ribbonManager.TitleStyle.Class = "";
            this.ribbonManager.TitleStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.ribbonManager.TitleStyleMouseOver.Class = "";
            this.ribbonManager.TitleStyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // btnEarnings
            // 
            this.btnEarnings.Name = "btnEarnings";
            this.btnEarnings.SubItemsExpandWidth = 14;
            this.btnEarnings.Text = "Einnahmen";
            this.btnEarnings.Click += new System.EventHandler(this.btnEarnings_Click);
            // 
            // btnExpenses
            // 
            this.btnExpenses.Name = "btnExpenses";
            this.btnExpenses.SubItemsExpandWidth = 14;
            this.btnExpenses.Text = "Ausgaben";
            this.btnExpenses.Click += new System.EventHandler(this.btnExpenses_Click);
            // 
            // btnFixcosts
            // 
            this.btnFixcosts.Name = "btnFixcosts";
            this.btnFixcosts.SubItemsExpandWidth = 14;
            this.btnFixcosts.Text = "Feste Kosten";
            this.btnFixcosts.Click += new System.EventHandler(this.btnFixcosts_Click);
            // 
            // btnBankaccount
            // 
            this.btnBankaccount.Name = "btnBankaccount";
            this.btnBankaccount.SubItemsExpandWidth = 14;
            this.btnBankaccount.Text = "Konto";
            this.btnBankaccount.Click += new System.EventHandler(this.btnBankaccount_Click);
            // 
            // ribbonPanel2
            // 
            this.ribbonPanel2.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.ribbonPanel2.Controls.Add(this.ribbonBar3);
            this.ribbonPanel2.Controls.Add(this.ribbonBar2);
            this.ribbonPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ribbonPanel2.Location = new System.Drawing.Point(0, 53);
            this.ribbonPanel2.Name = "ribbonPanel2";
            this.ribbonPanel2.Padding = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.ribbonPanel2.Size = new System.Drawing.Size(1278, 46);
            // 
            // 
            // 
            this.ribbonPanel2.Style.Class = "";
            this.ribbonPanel2.Style.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.ribbonPanel2.StyleMouseDown.Class = "";
            this.ribbonPanel2.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.ribbonPanel2.StyleMouseOver.Class = "";
            this.ribbonPanel2.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.ribbonPanel2.TabIndex = 2;
            this.ribbonPanel2.Visible = false;
            // 
            // ribbonBar3
            // 
            this.ribbonBar3.AutoOverflowEnabled = true;
            // 
            // 
            // 
            this.ribbonBar3.BackgroundMouseOverStyle.Class = "";
            this.ribbonBar3.BackgroundMouseOverStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.ribbonBar3.BackgroundStyle.Class = "";
            this.ribbonBar3.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.ribbonBar3.ContainerControlProcessDialogKey = true;
            this.ribbonBar3.Dock = System.Windows.Forms.DockStyle.Left;
            this.ribbonBar3.Items.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.btnEnableSearch,
            this.btnStats});
            this.ribbonBar3.Location = new System.Drawing.Point(149, 0);
            this.ribbonBar3.Name = "ribbonBar3";
            this.ribbonBar3.Size = new System.Drawing.Size(88, 43);
            this.ribbonBar3.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.ribbonBar3.TabIndex = 1;
            this.ribbonBar3.Text = "Einkäufe";
            // 
            // 
            // 
            this.ribbonBar3.TitleStyle.Class = "";
            this.ribbonBar3.TitleStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.ribbonBar3.TitleStyleMouseOver.Class = "";
            this.ribbonBar3.TitleStyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // btnEnableSearch
            // 
            this.btnEnableSearch.Name = "btnEnableSearch";
            this.btnEnableSearch.SubItemsExpandWidth = 14;
            this.btnEnableSearch.Text = "Suche";
            this.btnEnableSearch.Click += new System.EventHandler(this.btnEnableSearch_Click);
            // 
            // btnStats
            // 
            this.btnStats.Name = "btnStats";
            this.btnStats.SubItemsExpandWidth = 14;
            this.btnStats.Text = "Statistik";
            this.btnStats.Click += new System.EventHandler(this.btnStats_Click);
            // 
            // ribbonBar2
            // 
            this.ribbonBar2.AutoOverflowEnabled = true;
            // 
            // 
            // 
            this.ribbonBar2.BackgroundMouseOverStyle.Class = "";
            this.ribbonBar2.BackgroundMouseOverStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.ribbonBar2.BackgroundStyle.Class = "";
            this.ribbonBar2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.ribbonBar2.ContainerControlProcessDialogKey = true;
            this.ribbonBar2.Dock = System.Windows.Forms.DockStyle.Left;
            this.ribbonBar2.Items.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.btnLocAdd,
            this.btnShopAdd,
            this.btnCatAdd});
            this.ribbonBar2.Location = new System.Drawing.Point(3, 0);
            this.ribbonBar2.Name = "ribbonBar2";
            this.ribbonBar2.Size = new System.Drawing.Size(146, 43);
            this.ribbonBar2.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.ribbonBar2.TabIndex = 0;
            this.ribbonBar2.Text = "Hinzufügen";
            // 
            // 
            // 
            this.ribbonBar2.TitleStyle.Class = "";
            this.ribbonBar2.TitleStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.ribbonBar2.TitleStyleMouseOver.Class = "";
            this.ribbonBar2.TitleStyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // btnLocAdd
            // 
            this.btnLocAdd.Name = "btnLocAdd";
            this.btnLocAdd.SubItemsExpandWidth = 14;
            this.btnLocAdd.Text = "Lokalität";
            this.btnLocAdd.Click += new System.EventHandler(this.btnLocAdd_Click);
            // 
            // btnShopAdd
            // 
            this.btnShopAdd.Name = "btnShopAdd";
            this.btnShopAdd.SubItemsExpandWidth = 14;
            this.btnShopAdd.Text = "Laden";
            this.btnShopAdd.Click += new System.EventHandler(this.btnShopAdd_Click);
            // 
            // btnCatAdd
            // 
            this.btnCatAdd.Name = "btnCatAdd";
            this.btnCatAdd.SubItemsExpandWidth = 14;
            this.btnCatAdd.Text = "Kategorie";
            this.btnCatAdd.Click += new System.EventHandler(this.btnCatAdd_Click);
            // 
            // office2007StartbtnAdd
            // 
            this.office2007StartbtnAdd.AutoExpandOnClick = true;
            this.office2007StartbtnAdd.CanCustomize = false;
            this.office2007StartbtnAdd.HotTrackingStyle = DevComponents.DotNetBar.eHotTrackingStyle.Image;
            this.office2007StartbtnAdd.ImageFixedSize = new System.Drawing.Size(16, 16);
            this.office2007StartbtnAdd.ImagePaddingHorizontal = 0;
            this.office2007StartbtnAdd.ImagePaddingVertical = 0;
            this.office2007StartbtnAdd.Name = "office2007StartbtnAdd";
            this.office2007StartbtnAdd.ShowSubItems = false;
            this.office2007StartbtnAdd.SubItems.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.itemContainer1});
            this.office2007StartbtnAdd.Text = "&File";
            // 
            // itemContainer1
            // 
            // 
            // 
            // 
            this.itemContainer1.BackgroundStyle.Class = "RibbonFileMenuContainer";
            this.itemContainer1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.itemContainer1.LayoutOrientation = DevComponents.DotNetBar.eOrientation.Vertical;
            this.itemContainer1.Name = "itemContainer1";
            this.itemContainer1.SubItems.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.itemContainer2,
            this.itemContainer4});
            // 
            // itemContainer2
            // 
            // 
            // 
            // 
            this.itemContainer2.BackgroundStyle.Class = "RibbonFileMenuTwoColumnContainer";
            this.itemContainer2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.itemContainer2.ItemSpacing = 0;
            this.itemContainer2.Name = "itemContainer2";
            this.itemContainer2.SubItems.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.itemContainer3,
            this.galleryContainer1});
            // 
            // itemContainer3
            // 
            // 
            // 
            // 
            this.itemContainer3.BackgroundStyle.Class = "RibbonFileMenuColumnOneContainer";
            this.itemContainer3.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.itemContainer3.LayoutOrientation = DevComponents.DotNetBar.eOrientation.Vertical;
            this.itemContainer3.MinimumSize = new System.Drawing.Size(120, 0);
            this.itemContainer3.Name = "itemContainer3";
            this.itemContainer3.SubItems.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.buttonItem6,
            this.buttonItem7});
            // 
            // buttonItem6
            // 
            this.buttonItem6.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.buttonItem6.Name = "buttonItem6";
            this.buttonItem6.SubItemsExpandWidth = 24;
            this.buttonItem6.Text = "&Print...";
            // 
            // buttonItem7
            // 
            this.buttonItem7.BeginGroup = true;
            this.buttonItem7.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.buttonItem7.Name = "buttonItem7";
            this.buttonItem7.SubItemsExpandWidth = 24;
            this.buttonItem7.Text = "&Close";
            // 
            // galleryContainer1
            // 
            // 
            // 
            // 
            this.galleryContainer1.BackgroundStyle.Class = "RibbonFileMenuColumnTwoContainer";
            this.galleryContainer1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.galleryContainer1.EnableGalleryPopup = false;
            this.galleryContainer1.LayoutOrientation = DevComponents.DotNetBar.eOrientation.Vertical;
            this.galleryContainer1.MinimumSize = new System.Drawing.Size(180, 240);
            this.galleryContainer1.MultiLine = false;
            this.galleryContainer1.Name = "galleryContainer1";
            this.galleryContainer1.PopupUsesStandardScrollbars = false;
            // 
            // itemContainer4
            // 
            // 
            // 
            // 
            this.itemContainer4.BackgroundStyle.Class = "RibbonFileMenuBottomContainer";
            this.itemContainer4.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.itemContainer4.HorizontalItemAlignment = DevComponents.DotNetBar.eHorizontalItemsAlignment.Right;
            this.itemContainer4.Name = "itemContainer4";
            this.itemContainer4.SubItems.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.buttonItem12,
            this.buttonItem13});
            // 
            // buttonItem12
            // 
            this.buttonItem12.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.buttonItem12.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.buttonItem12.Name = "buttonItem12";
            this.buttonItem12.SubItemsExpandWidth = 24;
            this.buttonItem12.Text = "Opt&ions";
            // 
            // buttonItem13
            // 
            this.buttonItem13.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.buttonItem13.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.buttonItem13.Name = "buttonItem13";
            this.buttonItem13.SubItemsExpandWidth = 24;
            this.buttonItem13.Text = "E&xit";
            // 
            // DocumentationTab
            // 
            this.DocumentationTab.Checked = true;
            this.DocumentationTab.Name = "DocumentationTab";
            this.DocumentationTab.Panel = this.ribbonPanel1;
            this.DocumentationTab.Text = "Dokumentation";
            this.DocumentationTab.Click += new System.EventHandler(this.DocumentationTab_Click);
            // 
            // AnalysisTab
            // 
            this.AnalysisTab.Name = "AnalysisTab";
            this.AnalysisTab.Panel = this.ribbonPanel2;
            this.AnalysisTab.Text = "Analyse";
            this.AnalysisTab.Click += new System.EventHandler(this.AnalysisTab_Click);
            // 
            // styleManager2
            // 
            this.styleManager2.ManagerStyle = DevComponents.DotNetBar.eStyle.Office2010Black;
            // 
            // dgvSearch
            // 
            this.dgvSearch.AllowUserToAddRows = false;
            this.dgvSearch.AllowUserToResizeRows = false;
            this.dgvSearch.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvSearch.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvSearch.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvSearch.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Search_nr,
            this.Search_amount,
            this.Search_product,
            this.Search_description,
            this.Search_price,
            this.Search_date,
            this.Search_category,
            this.Search_shop,
            this.Search_location});
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle14.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle14.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle14.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle14.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle14.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvSearch.DefaultCellStyle = dataGridViewCellStyle14;
            this.dgvSearch.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnKeystroke;
            this.dgvSearch.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(170)))), ((int)(((byte)(170)))));
            this.dgvSearch.Location = new System.Drawing.Point(0, 235);
            this.dgvSearch.Name = "dgvSearch";
            this.dgvSearch.RowHeadersVisible = false;
            this.dgvSearch.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvSearch.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgvSearch.SelectAllSignVisible = false;
            this.dgvSearch.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSearch.ShowEditingIcon = false;
            this.dgvSearch.Size = new System.Drawing.Size(1278, 404);
            this.dgvSearch.TabIndex = 5;
            this.dgvSearch.Visible = false;
            // 
            // Search_nr
            // 
            this.Search_nr.HeaderText = "Nr.";
            this.Search_nr.Name = "Search_nr";
            // 
            // Search_amount
            // 
            this.Search_amount.HeaderText = "Menge";
            this.Search_amount.Name = "Search_amount";
            // 
            // Search_product
            // 
            this.Search_product.HeaderText = "Gegenstand";
            this.Search_product.Name = "Search_product";
            // 
            // Search_description
            // 
            this.Search_description.HeaderText = "Beschreibung";
            this.Search_description.Name = "Search_description";
            // 
            // Search_price
            // 
            this.Search_price.HeaderText = "Preis in €";
            this.Search_price.Name = "Search_price";
            // 
            // Search_date
            // 
            this.Search_date.HeaderText = "Datum";
            this.Search_date.InputHorizontalAlignment = DevComponents.Editors.eHorizontalAlignment.Left;
            // 
            // 
            // 
            this.Search_date.MonthCalendar.AnnuallyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this.Search_date.MonthCalendar.BackgroundStyle.BackColor = System.Drawing.SystemColors.Window;
            this.Search_date.MonthCalendar.BackgroundStyle.Class = "";
            this.Search_date.MonthCalendar.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.Search_date.MonthCalendar.CommandsBackgroundStyle.Class = "";
            this.Search_date.MonthCalendar.CommandsBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.Search_date.MonthCalendar.DisplayMonth = new System.DateTime(2016, 2, 1, 0, 0, 0, 0);
            this.Search_date.MonthCalendar.FirstDayOfWeek = System.DayOfWeek.Monday;
            this.Search_date.MonthCalendar.MarkedDates = new System.DateTime[0];
            this.Search_date.MonthCalendar.MonthlyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this.Search_date.MonthCalendar.NavigationBackgroundStyle.Class = "";
            this.Search_date.MonthCalendar.NavigationBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.Search_date.MonthCalendar.WeeklyMarkedDays = new System.DayOfWeek[0];
            this.Search_date.Name = "Search_date";
            // 
            // Search_category
            // 
            this.Search_category.DropDownHeight = 106;
            this.Search_category.DropDownWidth = 121;
            this.Search_category.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Search_category.HeaderText = "Kategorie";
            this.Search_category.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.Search_category.IntegralHeight = false;
            this.Search_category.ItemHeight = 13;
            this.Search_category.MaxDropDownItems = 20;
            this.Search_category.Name = "Search_category";
            this.Search_category.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Search_category.RightToLeft = System.Windows.Forms.RightToLeft.No;
            // 
            // Search_shop
            // 
            this.Search_shop.DropDownHeight = 106;
            this.Search_shop.DropDownWidth = 121;
            this.Search_shop.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Search_shop.HeaderText = "Shop";
            this.Search_shop.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.Search_shop.IntegralHeight = false;
            this.Search_shop.ItemHeight = 13;
            this.Search_shop.Name = "Search_shop";
            this.Search_shop.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Search_shop.RightToLeft = System.Windows.Forms.RightToLeft.No;
            // 
            // Search_location
            // 
            this.Search_location.DropDownHeight = 106;
            this.Search_location.DropDownWidth = 121;
            this.Search_location.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Search_location.HeaderText = "Ort";
            this.Search_location.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.Search_location.IntegralHeight = false;
            this.Search_location.ItemHeight = 13;
            this.Search_location.Name = "Search_location";
            this.Search_location.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Search_location.RightToLeft = System.Windows.Forms.RightToLeft.No;
            // 
            // dtpFrom
            // 
            this.dtpFrom.Location = new System.Drawing.Point(41, 32);
            this.dtpFrom.Name = "dtpFrom";
            this.dtpFrom.Size = new System.Drawing.Size(200, 20);
            this.dtpFrom.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Von:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(24, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Bis:";
            // 
            // dtpTo
            // 
            this.dtpTo.Location = new System.Drawing.Point(41, 60);
            this.dtpTo.Name = "dtpTo";
            this.dtpTo.Size = new System.Drawing.Size(200, 20);
            this.dtpTo.TabIndex = 9;
            // 
            // cmbCat
            // 
            this.cmbCat.FormattingEnabled = true;
            this.cmbCat.Location = new System.Drawing.Point(473, 84);
            this.cmbCat.Name = "cmbCat";
            this.cmbCat.Size = new System.Drawing.Size(121, 21);
            this.cmbCat.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(412, 86);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Kategorie:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(412, 61);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "Shop:";
            // 
            // cmbShop
            // 
            this.cmbShop.FormattingEnabled = true;
            this.cmbShop.Location = new System.Drawing.Point(473, 57);
            this.cmbShop.Name = "cmbShop";
            this.cmbShop.Size = new System.Drawing.Size(121, 21);
            this.cmbShop.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(412, 34);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(24, 13);
            this.label5.TabIndex = 15;
            this.label5.Text = "Ort:";
            // 
            // cmbLoc
            // 
            this.cmbLoc.FormattingEnabled = true;
            this.cmbLoc.Location = new System.Drawing.Point(473, 30);
            this.cmbLoc.Name = "cmbLoc";
            this.cmbLoc.Size = new System.Drawing.Size(121, 21);
            this.cmbLoc.TabIndex = 14;
            // 
            // grpSearch
            // 
            this.grpSearch.Controls.Add(this.lblInfo);
            this.grpSearch.Controls.Add(this.txtKeyWord);
            this.grpSearch.Controls.Add(this.chbPrice);
            this.grpSearch.Controls.Add(this.btnSearch);
            this.grpSearch.Controls.Add(this.txtMax);
            this.grpSearch.Controls.Add(this.txtMin);
            this.grpSearch.Controls.Add(this.cmbShop);
            this.grpSearch.Controls.Add(this.label4);
            this.grpSearch.Controls.Add(this.label7);
            this.grpSearch.Controls.Add(this.chbShop);
            this.grpSearch.Controls.Add(this.label6);
            this.grpSearch.Controls.Add(this.chbPeriod);
            this.grpSearch.Controls.Add(this.chbLoc);
            this.grpSearch.Controls.Add(this.chbCat);
            this.grpSearch.Controls.Add(this.cmbLoc);
            this.grpSearch.Controls.Add(this.dtpTo);
            this.grpSearch.Controls.Add(this.label5);
            this.grpSearch.Controls.Add(this.label2);
            this.grpSearch.Controls.Add(this.cmbCat);
            this.grpSearch.Controls.Add(this.label1);
            this.grpSearch.Controls.Add(this.label3);
            this.grpSearch.Controls.Add(this.dtpFrom);
            this.grpSearch.Controls.Add(this.chbKeyWord);
            this.grpSearch.Controls.Add(this.grpAdd);
            this.grpSearch.Location = new System.Drawing.Point(12, 107);
            this.grpSearch.Name = "grpSearch";
            this.grpSearch.Size = new System.Drawing.Size(618, 122);
            this.grpSearch.TabIndex = 16;
            this.grpSearch.TabStop = false;
            this.grpSearch.Text = "Suche nach:";
            this.grpSearch.Visible = false;
            // 
            // grpAdd
            // 
            this.grpAdd.Controls.Add(this.btnAdd);
            this.grpAdd.Controls.Add(this.txtAdd);
            this.grpAdd.Controls.Add(this.lblAdd);
            this.grpAdd.Location = new System.Drawing.Point(0, 0);
            this.grpAdd.Name = "grpAdd";
            this.grpAdd.Size = new System.Drawing.Size(618, 122);
            this.grpAdd.TabIndex = 17;
            this.grpAdd.TabStop = false;
            this.grpAdd.Text = "Hinzufügen:";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(119, 87);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(94, 29);
            this.btnAdd.TabIndex = 13;
            this.btnAdd.Text = "Hinzufügen";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // txtAdd
            // 
            this.txtAdd.Location = new System.Drawing.Point(85, 48);
            this.txtAdd.Name = "txtAdd";
            this.txtAdd.Size = new System.Drawing.Size(128, 20);
            this.txtAdd.TabIndex = 12;
            // 
            // lblAdd
            // 
            this.lblAdd.AutoSize = true;
            this.lblAdd.Location = new System.Drawing.Point(19, 50);
            this.lblAdd.Name = "lblAdd";
            this.lblAdd.Size = new System.Drawing.Size(50, 13);
            this.lblAdd.TabIndex = 11;
            this.lblAdd.Text = "Lokalität:";
            // 
            // txtKeyWord
            // 
            // 
            // 
            // 
            this.txtKeyWord.Border.Class = "TextBoxBorder";
            this.txtKeyWord.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtKeyWord.Location = new System.Drawing.Point(264, 84);
            this.txtKeyWord.Name = "txtKeyWord";
            this.txtKeyWord.Size = new System.Drawing.Size(110, 20);
            this.txtKeyWord.TabIndex = 28;
            // 
            // chbPrice
            // 
            this.chbPrice.AutoSize = true;
            this.chbPrice.Location = new System.Drawing.Point(300, 10);
            this.chbPrice.Name = "chbPrice";
            this.chbPrice.Size = new System.Drawing.Size(69, 17);
            this.chbPrice.TabIndex = 25;
            this.chbPrice.Text = "Preis in €";
            this.chbPrice.UseVisualStyleBackColor = true;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(43, 87);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(94, 29);
            this.btnSearch.TabIndex = 16;
            this.btnSearch.Text = "Suchen";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtMax
            // 
            // 
            // 
            // 
            this.txtMax.Border.Class = "TextBoxBorder";
            this.txtMax.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtMax.Location = new System.Drawing.Point(296, 58);
            this.txtMax.Name = "txtMax";
            this.txtMax.Size = new System.Drawing.Size(78, 20);
            this.txtMax.TabIndex = 24;
            // 
            // txtMin
            // 
            // 
            // 
            // 
            this.txtMin.Border.Class = "TextBoxBorder";
            this.txtMin.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtMin.Location = new System.Drawing.Point(296, 32);
            this.txtMin.Name = "txtMin";
            this.txtMin.Size = new System.Drawing.Size(78, 20);
            this.txtMin.TabIndex = 23;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(261, 63);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(24, 13);
            this.label7.TabIndex = 22;
            this.label7.Text = "Bis:";
            // 
            // chbShop
            // 
            this.chbShop.AutoSize = true;
            this.chbShop.Location = new System.Drawing.Point(396, 61);
            this.chbShop.Name = "chbShop";
            this.chbShop.Size = new System.Drawing.Size(15, 14);
            this.chbShop.TabIndex = 18;
            this.chbShop.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(261, 34);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(29, 13);
            this.label6.TabIndex = 21;
            this.label6.Text = "Von:";
            // 
            // chbPeriod
            // 
            this.chbPeriod.AutoSize = true;
            this.chbPeriod.Location = new System.Drawing.Point(106, 10);
            this.chbPeriod.Name = "chbPeriod";
            this.chbPeriod.Size = new System.Drawing.Size(67, 17);
            this.chbPeriod.TabIndex = 20;
            this.chbPeriod.Text = "Zeitraum";
            this.chbPeriod.UseVisualStyleBackColor = true;
            // 
            // chbLoc
            // 
            this.chbLoc.AutoSize = true;
            this.chbLoc.Location = new System.Drawing.Point(395, 33);
            this.chbLoc.Name = "chbLoc";
            this.chbLoc.Size = new System.Drawing.Size(15, 14);
            this.chbLoc.TabIndex = 19;
            this.chbLoc.UseVisualStyleBackColor = true;
            // 
            // chbCat
            // 
            this.chbCat.AutoSize = true;
            this.chbCat.Location = new System.Drawing.Point(396, 86);
            this.chbCat.Name = "chbCat";
            this.chbCat.Size = new System.Drawing.Size(15, 14);
            this.chbCat.TabIndex = 17;
            this.chbCat.UseVisualStyleBackColor = true;
            // 
            // chbKeyWord
            // 
            this.chbKeyWord.AutoSize = true;
            this.chbKeyWord.Location = new System.Drawing.Point(185, 87);
            this.chbKeyWord.Name = "chbKeyWord";
            this.chbKeyWord.Size = new System.Drawing.Size(73, 17);
            this.chbKeyWord.TabIndex = 29;
            this.chbKeyWord.Text = "Stichwort:";
            this.chbKeyWord.UseVisualStyleBackColor = true;
            // 
            // btnDelEntry
            // 
            this.btnDelEntry.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDelEntry.Location = new System.Drawing.Point(1172, 200);
            this.btnDelEntry.Name = "btnDelEntry";
            this.btnDelEntry.Size = new System.Drawing.Size(94, 29);
            this.btnDelEntry.TabIndex = 30;
            this.btnDelEntry.Text = "Eintrag löschen";
            this.btnDelEntry.UseVisualStyleBackColor = true;
            this.btnDelEntry.Visible = false;
            this.btnDelEntry.Click += new System.EventHandler(this.btnDelEntry_Click);
            // 
            // grpStats
            // 
            this.grpStats.CanvasColor = System.Drawing.SystemColors.Control;
            this.grpStats.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.grpStats.Controls.Add(this.label9);
            this.grpStats.Controls.Add(this.label8);
            this.grpStats.Location = new System.Drawing.Point(0, 102);
            this.grpStats.Name = "grpStats";
            this.grpStats.Size = new System.Drawing.Size(1278, 537);
            // 
            // 
            // 
            this.grpStats.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.grpStats.Style.BackColorGradientAngle = 90;
            this.grpStats.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.grpStats.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.grpStats.Style.BorderBottomWidth = 1;
            this.grpStats.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.grpStats.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.grpStats.Style.BorderLeftWidth = 1;
            this.grpStats.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.grpStats.Style.BorderRightWidth = 1;
            this.grpStats.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.grpStats.Style.BorderTopWidth = 1;
            this.grpStats.Style.Class = "";
            this.grpStats.Style.CornerDiameter = 4;
            this.grpStats.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded;
            this.grpStats.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center;
            this.grpStats.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.grpStats.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near;
            // 
            // 
            // 
            this.grpStats.StyleMouseDown.Class = "";
            this.grpStats.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.grpStats.StyleMouseOver.Class = "";
            this.grpStats.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.grpStats.TabIndex = 14;
            this.grpStats.Text = "Statistiken";
            this.grpStats.Visible = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(1098, 482);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(35, 13);
            this.label9.TabIndex = 1;
            this.label9.Text = "label9";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(0, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(35, 13);
            this.label8.TabIndex = 0;
            this.label8.Text = "label8";
            // 
            // lblInfo
            // 
            this.lblInfo.AutoSize = true;
            this.lblInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInfo.Location = new System.Drawing.Point(396, 106);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(40, 12);
            this.lblInfo.TabIndex = 2;
            this.lblInfo.Text = "Suche...";
            // 
            // FrmView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1278, 638);
            this.Controls.Add(this.btnDelEntry);
            this.Controls.Add(this.grpSearch);
            this.Controls.Add(this.ribbonControl1);
            this.Controls.Add(this.btnAddRow);
            this.Controls.Add(this.btnRmvRow);
            this.Controls.Add(this.btnSend);
            this.Controls.Add(this.grpStats);
            this.Controls.Add(this.dgvSearch);
            this.Controls.Add(this.dgvRecord);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximumSize = new System.Drawing.Size(1800, 1000);
            this.MinimumSize = new System.Drawing.Size(640, 570);
            this.Name = "FrmView";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EMS by ECIT";
            this.TitleText = "Expenditure Manager";
            ((System.ComponentModel.ISupportInitialize)(this.dgvRecord)).EndInit();
            this.ribbonControl1.ResumeLayout(false);
            this.ribbonControl1.PerformLayout();
            this.ribbonPanel1.ResumeLayout(false);
            this.ribbonPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSearch)).EndInit();
            this.grpSearch.ResumeLayout(false);
            this.grpSearch.PerformLayout();
            this.grpAdd.ResumeLayout(false);
            this.grpAdd.PerformLayout();
            this.grpStats.ResumeLayout(false);
            this.grpStats.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevComponents.DotNetBar.Controls.DataGridViewX dgvRecord;
        private DevComponents.DotNetBar.StyleManager styleManager1;
        private DevComponents.DotNetBar.ButtonX btnSend;
        private DevComponents.DotNetBar.ButtonX btnRmvRow;
        private DevComponents.DotNetBar.ButtonX btnAddRow;
        private DevComponents.DotNetBar.RibbonControl ribbonControl1;
        private DevComponents.DotNetBar.RibbonPanel ribbonPanel2;
        private DevComponents.DotNetBar.RibbonPanel ribbonPanel1;
        private DevComponents.DotNetBar.Office2007StartButton office2007StartbtnAdd;
        private DevComponents.DotNetBar.ItemContainer itemContainer1;
        private DevComponents.DotNetBar.ItemContainer itemContainer2;
        private DevComponents.DotNetBar.ItemContainer itemContainer3;
        private DevComponents.DotNetBar.ButtonItem buttonItem6;
        private DevComponents.DotNetBar.ButtonItem buttonItem7;
        private DevComponents.DotNetBar.GalleryContainer galleryContainer1;
        private DevComponents.DotNetBar.ItemContainer itemContainer4;
        private DevComponents.DotNetBar.ButtonItem buttonItem12;
        private DevComponents.DotNetBar.ButtonItem buttonItem13;
        private DevComponents.DotNetBar.RibbonTabItem DocumentationTab;
        private DevComponents.DotNetBar.RibbonTabItem AnalysisTab;
        private DevComponents.DotNetBar.StyleManager styleManager2;
        private DevComponents.DotNetBar.RibbonBar ribbonBar3;
        private DevComponents.DotNetBar.ButtonItem btnEnableSearch;
        private DevComponents.DotNetBar.ButtonItem btnStats;
        private DevComponents.DotNetBar.RibbonBar ribbonBar2;
        private DevComponents.DotNetBar.ButtonItem btnLocAdd;
        private DevComponents.DotNetBar.ButtonItem btnShopAdd;
        private DevComponents.DotNetBar.ButtonItem btnCatAdd;
        private DevComponents.DotNetBar.Controls.DataGridViewX dgvSearch;
        private System.Windows.Forms.DateTimePicker dtpFrom;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtpTo;
        private System.Windows.Forms.ComboBox cmbCat;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbShop;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmbLoc;
        private System.Windows.Forms.GroupBox grpSearch;
        private System.Windows.Forms.GroupBox grpAdd;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox txtAdd;
        private System.Windows.Forms.Label lblAdd;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.DataGridViewTextBoxColumn A_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn amount;
        private System.Windows.Forms.DataGridViewTextBoxColumn productname;
        private System.Windows.Forms.DataGridViewTextBoxColumn p_description;
        private System.Windows.Forms.DataGridViewTextBoxColumn price;
        private DevComponents.DotNetBar.Controls.DataGridViewDateTimeInputColumn date;
        private DevComponents.DotNetBar.Controls.DataGridViewComboBoxExColumn category;
        private DevComponents.DotNetBar.Controls.DataGridViewComboBoxExColumn company;
        private DevComponents.DotNetBar.Controls.DataGridViewComboBoxExColumn location;
        private System.Windows.Forms.DataGridViewTextBoxColumn Search_nr;
        private System.Windows.Forms.DataGridViewTextBoxColumn Search_amount;
        private System.Windows.Forms.DataGridViewTextBoxColumn Search_product;
        private System.Windows.Forms.DataGridViewTextBoxColumn Search_description;
        private System.Windows.Forms.DataGridViewTextBoxColumn Search_price;
        private DevComponents.DotNetBar.Controls.DataGridViewDateTimeInputColumn Search_date;
        private DevComponents.DotNetBar.Controls.DataGridViewComboBoxExColumn Search_category;
        private DevComponents.DotNetBar.Controls.DataGridViewComboBoxExColumn Search_shop;
        private DevComponents.DotNetBar.Controls.DataGridViewComboBoxExColumn Search_location;
        private System.Windows.Forms.CheckBox chbCat;
        private System.Windows.Forms.CheckBox chbPeriod;
        private System.Windows.Forms.CheckBox chbLoc;
        private System.Windows.Forms.CheckBox chbShop;
        private System.Windows.Forms.CheckBox chbPrice;
        private DevComponents.DotNetBar.Controls.TextBoxX txtMax;
        private DevComponents.DotNetBar.Controls.TextBoxX txtMin;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.CheckBox chbKeyWord;
        private DevComponents.DotNetBar.Controls.TextBoxX txtKeyWord;
        private System.Windows.Forms.Button btnDelEntry;
        private DevComponents.DotNetBar.Controls.GroupPanel grpStats;
        private DevComponents.DotNetBar.RibbonBar ribbonManager;
        private DevComponents.DotNetBar.ButtonItem btnEarnings;
        private DevComponents.DotNetBar.ButtonItem btnExpenses;
        private DevComponents.DotNetBar.RibbonBar ribbonDebts;
        private DevComponents.DotNetBar.ButtonItem btnBorrow;
        private DevComponents.DotNetBar.ButtonItem btnDebts;
        private DevComponents.DotNetBar.ButtonItem btnFixcosts;
        private DevComponents.DotNetBar.ButtonItem btnBankaccount;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblInfo;
    }
}

