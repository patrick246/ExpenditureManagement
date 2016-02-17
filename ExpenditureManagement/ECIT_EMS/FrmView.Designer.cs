﻿namespace ECIT_EMS
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
            this.styleManager1 = new DevComponents.DotNetBar.StyleManager(this.components);
            this.btnSend = new DevComponents.DotNetBar.ButtonX();
            this.A_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.p_description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.date = new DevComponents.DotNetBar.Controls.DataGridViewDateTimeInputColumn();
            this.category = new DevComponents.DotNetBar.Controls.DataGridViewComboBoxExColumn();
            this.company = new DevComponents.DotNetBar.Controls.DataGridViewComboBoxExColumn();
            this.location = new DevComponents.DotNetBar.Controls.DataGridViewComboBoxExColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRecord)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvRecord
            // 
            this.dgvRecord.AllowUserToAddRows = false;
            this.dgvRecord.AllowUserToResizeRows = false;
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
            this.dgvRecord.Size = new System.Drawing.Size(1222, 181);
            this.dgvRecord.TabIndex = 0;
            this.dgvRecord.KeyUp += new System.Windows.Forms.KeyEventHandler(this.onKeyUp);
            // 
            // styleManager1
            // 
            this.styleManager1.ManagerStyle = DevComponents.DotNetBar.eStyle.Office2010Black;
            // 
            // btnSend
            // 
            this.btnSend.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnSend.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnSend.Location = new System.Drawing.Point(1095, 187);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(115, 39);
            this.btnSend.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnSend.TabIndex = 1;
            this.btnSend.Text = "Eintragen";
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // A_ID
            // 
            this.A_ID.HeaderText = "Nr.";
            this.A_ID.Name = "A_ID";
            this.A_ID.Width = 163;
            // 
            // productname
            // 
            this.productname.HeaderText = "Gegenstand";
            this.productname.Name = "productname";
            this.productname.Width = 162;
            // 
            // p_description
            // 
            this.p_description.HeaderText = "Beschreibung";
            this.p_description.Name = "p_description";
            this.p_description.Width = 163;
            // 
            // price
            // 
            this.price.HeaderText = "Preis";
            this.price.Name = "price";
            this.price.Width = 163;
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
            this.date.Width = 162;
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
            this.category.Width = 163;
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
            this.company.Width = 162;
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
            this.location.Width = 163;
            // 
            // FrmView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1222, 708);
            this.Controls.Add(this.btnSend);
            this.Controls.Add(this.dgvRecord);
            this.DoubleBuffered = true;
            this.Name = "FrmView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EMS by ECIT";
            ((System.ComponentModel.ISupportInitialize)(this.dgvRecord)).EndInit();
            this.ResumeLayout(false);

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
    }
}

