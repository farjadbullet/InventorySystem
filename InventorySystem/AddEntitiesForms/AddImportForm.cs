using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Telerik.WinControls;
using System.Data.Entity;

namespace InventorySystem
{
    public partial class AddImportForm : Telerik.WinControls.UI.RadForm
    {
        private static AddImportForm form;
        InventorySystemEntities _context;
        private AddImportForm()
        {
            InitializeComponent();
        }
        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            _context = new InventorySystemEntities();

            _context.Companies.Load();
            //this.companyBindingSource.DataSource = _context.Companies.Local.ToBindingList();
        }

        public static AddImportForm GetInstance()
        {
            if (form != null)
            {
                return form;
            }
            form = new AddImportForm();
            return form;
        }

        private void BtnAddOrderDetails_Click(object sender, EventArgs e)
        {

        }

        private void BtnAddProductionDetails_Click(object sender, EventArgs e)
        {

        }

        private void BtnAddItemExpenses_Click(object sender, EventArgs e)
        {

        }

        private void BtnSave_Click(object sender, EventArgs e)
        {

        }
    }
}
