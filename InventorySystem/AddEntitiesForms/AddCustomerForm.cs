using System;
using System.Data.Entity;
using System.Windows.Forms;
using Telerik.WinControls;

namespace InventorySystem
{
    public partial class AddCustomerForm : Telerik.WinControls.UI.RadForm
    {
        private static AddCustomerForm form;
        InventorySystemEntities _context;
        private AddCustomerForm()
        {
            InitializeComponent();
            
        }
        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            _context = new InventorySystemEntities();

            _context.Companies.Load();
            this.companyBindingSource.DataSource = _context.Companies.Local.ToBindingList();
        }

        public static AddCustomerForm GetInstance()
        {
            if (form != null)
            {
                return form;
            }
            form = new AddCustomerForm();
            return form;
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            Customer customer = new Customer { 
                Name = this.TextBoxName.Text,
                CompanyId = int.Parse(this.TextBoxCompanyName.Items[0].Value.ToString()),
                Contact = this.TextBoxContact.Text,
                Contact2 = this.TextBoxContact2.Text,
            };
            _context.Customers.Add(customer);
            _context.SaveChanges();
            this.DialogResult = DialogResult.OK;
            RadMessageBox.SetThemeName(this.telerikMetroBlueTheme1.ThemeName.ToString());
            RadMessageBox.Show("Saved Successfully!", "Success");

        }
        
    }
}
