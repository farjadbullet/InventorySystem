using System;
using System.Data.Entity;
using Telerik.WinControls;
using System.Windows.Forms;
using InventorySystem.AddEntitiesForms;

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

            _context.Suppliers.Load();

            this.supplierBindingSource.DataSource = _context.Suppliers.Local.ToBindingList();
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
            AddImportDetails forms = AddImportDetails.GetInstance();
            var dialogResult = forms.ShowDialog();
            {
                var isDialogResultOK = dialogResult == DialogResult.OK;
                if (isDialogResultOK)
                {

                }
            }
        }

        private void BtnAddProductionDetails_Click(object sender, EventArgs e)
        {

        }

        private void BtnAddItemExpenses_Click(object sender, EventArgs e)
        {

        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            ImportItem importItems = new ImportItem
            {
                ContainerId = this.TextBoxContainer.Text,
                ArrivalDate = this.TextBoxArrivalDate.Text,
                OrderDate = this.TextBoxOrderDate.Text,
                Status = this.TextBoxStatus.Text,
                SupplierId = int.Parse(this.TextBoxSupplier.Items[0].Value.ToString()),
            };
            _context.ImportItems.Add(importItems);
            _context.SaveChanges();
            
            RadMessageBox.SetThemeName(this.telerikMetroBlueTheme1.ThemeName.ToString());
            RadMessageBox.Show("Saved Successfully!", "Success");
        }
    }
}
