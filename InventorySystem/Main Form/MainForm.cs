using InventorySystem.AddEntitiesForms;
using System;
using System.Data.Entity;
using System.Linq;
using System.Windows.Forms;
using Telerik.WinControls.UI;

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

        void customerDataGridView_EditorRequired(object sender, Telerik.WinControls.UI.EditorRequiredEventArgs e)
        {

            if (this.customerCompanyChildDataGridView.CurrentColumn.Name == "CompanyName")
            {
                e.Editor = new MyAutoCompleteEditor();
            }
        }

        void customerDataGridView_CellEditorInitialized(object sender, Telerik.WinControls.UI.GridViewCellEventArgs e)
        {
            if (this.customerCompanyChildDataGridView.CurrentRow.Cells[2].Value != null)
            {
                if (e.ActiveEditor is MyAutoCompleteEditor)
                {
                    MyAutoCompleteEditor editor = (MyAutoCompleteEditor)e.ActiveEditor;
                    RadAutoCompleteBoxElement element = (RadAutoCompleteBoxElement)editor.EditorElement;
                    element.AutoCompleteMode = AutoCompleteMode.SuggestAppend;

                    element.AutoCompleteDataSource = _context.Companies.ToList();
                    element.AutoCompleteDisplayMember = "CompanyName";
                    element.AutoCompleteValueMember = "Id";
                }
            }
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
            _context.Items.Load();
            _context.Producers.Load();
            _context.Suppliers.Load();
            _context.Orders.Load();
            _context.Customers.Load();



            // Bind the categoryBindingSource.DataSource to  
            // all the Unchanged, Modified and Added Category objects that  
            // are currently tracked by the DbContext. 
            // Note that we need to call ToBindingList() on the  
            // ObservableCollection<TEntity> returned by 
            // the DbSet.Local property to get the BindingList<T> 
            // in order to facilitate two-way binding in WinForms. 
            this.companyBindingSource.DataSource =
                _context.Companies.Local.ToBindingList();
            this.itemBindingSource.DataSource =
                _context.Items.Local.ToBindingList();
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

        private void companyBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            _context.SaveChanges();
        }

        private void itemBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            _context.SaveChanges();
        }

        private void BtnAddCustomer_Click(object sender, EventArgs e)
        {
            AddCustomerForm forms = AddCustomerForm.GetInstance();
            var dialogResult = forms.ShowDialog();
            {
                var isDialogResultOK = dialogResult == DialogResult.OK;
                if (isDialogResultOK)
                {

                    this.customerCompanyChildDataGridView.Refresh();
                    this.customerCompanyParentDataGridView.Refresh();
                }
            }
        }

        private void BtnAddSupplier_Click(object sender, EventArgs e)
        {
            AddSupplierForm forms = AddSupplierForm.GetInstance();
            var dialogResult = forms.ShowDialog();
            {
                var isDialogResultOK = dialogResult == DialogResult.OK;
                if (isDialogResultOK)
                {

                    this.supplierCompanyChildDataGridView.Refresh();
                    this.supplierCompanyParentDataGridView.Refresh();
                }
            }
        }

        private void BtnAddProducer_Click(object sender, EventArgs e)
        {
            AddProducerForm forms = AddProducerForm.GetInstance();
            var dialogResult = forms.ShowDialog();
            {
                var isDialogResultOK = dialogResult == DialogResult.OK;
                if (isDialogResultOK)
                {

                    this.producerCompanyChildDataGridView.Refresh();
                    this.producerCompanyParentDataGridView.Refresh();
                }
            }

        }

        private void BtnAddImport_Click(object sender, EventArgs e)
        {
            AddImportForm forms = AddImportForm.GetInstance();
            var dialogResult = forms.ShowDialog();
            {
                var isDialogResultOK = dialogResult == DialogResult.OK;
                if (isDialogResultOK)
                {

                }
            }
        }


    }
}
