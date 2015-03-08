using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Entity;
using Telerik.WinControls;

namespace InventorySystem
{
    public partial class MainForm : Telerik.WinControls.UI.RadForm
    {
        static MainForm form;
        InventorySystemEntities _context;
        private MainForm()
        {
            InitializeComponent();
        }

        public static MainForm GetInstance()
        {
            if (form != null)
            {
                return form;
            }
            form = new MainForm();
            return form;

        }
        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            _context = new InventorySystemEntities();

            // Call the Load method to get the data for the given DbSet  
            // from the database.  
            // The data is materialized as entities. The entities are managed by  
            // the DbContext instance.  
            _context.Companies.Load();

            // Bind the categoryBindingSource.DataSource to  
            // all the Unchanged, Modified and Added Category objects that  
            // are currently tracked by the DbContext. 
            // Note that we need to call ToBindingList() on the  
            // ObservableCollection<TEntity> returned by 
            // the DbSet.Local property to get the BindingList<T> 
            // in order to facilitate two-way binding in WinForms. 
            this.companyBindingSource.DataSource =
                _context.Companies.Local.ToBindingList();
        }

        private void BtnAddCompany_Click(object sender, EventArgs e)
        {
            AddCompanyForm forms = AddCompanyForm.GetInstance();
            var dialogResult = forms.ShowDialog();
            {
                var isDialogResultOK = dialogResult == DialogResult.OK;
                if (isDialogResultOK)
                {
                    
                    this.companyDataGridView.Refresh();
                }
            }
        }

        private void BtnSearchCompany_Click(object sender, EventArgs e)
        {
            this.companyBindingSource.DataSource =
            _context.Companies.Local.Where(m => m.CompanyName.Contains(this.TextBoxSearchCompany.Text));

        }

        private void companyBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            _context.SaveChanges();
        }


    }
}
