using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Telerik.WinControls;
using System.Data.Entity;

namespace InventorySystem.AddEntitiesForms
{
    public partial class AddImportDetails : Telerik.WinControls.UI.RadForm
    {
        private static AddImportDetails form;
        InventorySystemEntities _context;
        public AddImportDetails()
        {
            InitializeComponent();
        }
        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            _context = new InventorySystemEntities();

            _context.ImportItems.Load();

            //this.companyBindingSource.DataSource = _context.Companies.Local.ToBindingList();
        }

        public static AddImportDetails GetInstance()
        {
            if (form != null)
            {
                return form;
            }
            form = new AddImportDetails();
            return form;
        }

        private void importItemBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            _context.SaveChanges();
        }
    }
}
