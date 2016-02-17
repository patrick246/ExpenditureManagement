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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvRecord = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.A_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            ((System.ComponentModel.ISupportInitialize)(this.dgvRecord)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvRecord
            // 
            this.dgvRecord.AllowUserToAddRows = false;
            this.dgvRecord.AllowUserToResizeRows = false;
            this.dgvRecord.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvRecord.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvRecord.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.A_ID,
            this.productname,
            this.p_description,
            this.price,
            this.date,
            this.category,
            this.company,
            this.location});
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvRecord.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgvRecord.Dock = System.Windows.Forms.DockStyle.Top;
            this.dgvRecord.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnKeystroke;
            this.dgvRecord.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(170)))), ((int)(((byte)(170)))));
            this.dgvRecord.Location = new System.Drawing.Point(0, 0);
            this.dgvRecord.Name = "dgvRecord";
            this.dgvRecord.RowHeadersVisible = false;
            this.dgvRecord.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvRecord.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgvRecord.SelectAllSignVisible = false;
            this.dgvRecord.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvRecord.ShowEditingIcon = false;
            this.dgvRecord.Size = new System.Drawing.Size(1050, 445);
            this.dgvRecord.TabIndex = 0;
            this.dgvRecord.KeyUp += new System.Windows.Forms.KeyEventHandler(this.onKeyUp);
            // 
            // A_ID
            // 
            this.A_ID.HeaderText = "Nr.";
            this.A_ID.Name = "A_ID";
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
            this.price.HeaderText = "Preis";
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
            this.btnSend.Location = new System.Drawing.Point(923, 480);
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
            this.btnRmvRow.Location = new System.Drawing.Point(12, 465);
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
            this.btnAddRow.Location = new System.Drawing.Point(12, 495);
            this.btnAddRow.Name = "btnAddRow";
            this.btnAddRow.Size = new System.Drawing.Size(87, 24);
            this.btnAddRow.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnAddRow.TabIndex = 3;
            this.btnAddRow.Text = "Zeile hinzufügen";
            this.btnAddRow.Click += new System.EventHandler(this.btnAddRow_Click);
            // 
            // FrmView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1050, 531);
            this.Controls.Add(this.btnAddRow);
            this.Controls.Add(this.btnRmvRow);
            this.Controls.Add(this.btnSend);
            this.Controls.Add(this.dgvRecord);
            this.DoubleBuffered = true;
            this.MaximumSize = new System.Drawing.Size(1800, 800);
            this.MinimumSize = new System.Drawing.Size(640, 570);
            this.Name = "FrmView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EMS by ECIT";
            this.TitleText = "Expenditure Manager";
            ((System.ComponentModel.ISupportInitialize)(this.dgvRecord)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevComponents.DotNetBar.Controls.DataGridViewX dgvRecord;
        private DevComponents.DotNetBar.StyleManager styleManager1;
        private DevComponents.DotNetBar.ButtonX btnSend;
        private System.Windows.Forms.DataGridViewTextBoxColumn A_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn productname;
        private System.Windows.Forms.DataGridViewTextBoxColumn p_description;
        private System.Windows.Forms.DataGridViewTextBoxColumn price;
        private DevComponents.DotNetBar.Controls.DataGridViewDateTimeInputColumn date;
        private DevComponents.DotNetBar.Controls.DataGridViewComboBoxExColumn category;
        private DevComponents.DotNetBar.Controls.DataGridViewComboBoxExColumn company;
        private DevComponents.DotNetBar.Controls.DataGridViewComboBoxExColumn location;
        private DevComponents.DotNetBar.ButtonX btnRmvRow;
        private DevComponents.DotNetBar.ButtonX btnAddRow;
    }
}

