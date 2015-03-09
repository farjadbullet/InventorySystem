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
    public partial class AddProducerForm : Telerik.WinControls.UI.RadForm
    {
        InventorySystemEntities _context;
        private static AddProducerForm form;
        private AddProducerForm()
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

        public static AddProducerForm GetInstance()
        {
            if (form != null)
            {
                return form;
            }
            form = new AddProducerForm();
            return form;
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            Producer producer = new Producer
            {
                Producer1 = this.TextBoxName.Text,
                CompanyId = int.Parse(this.TextBoxCompanyName.Items[0].Value.ToString()),
                Contact = this.TextBoxContact.Text,
                Contact2 = this.TextBoxContact2.Text,
            };
            _context.Producers.Add(producer);
            _context.SaveChanges();
            this.DialogResult = DialogResult.OK;
            RadMessageBox.SetThemeName(this.telerikMetroBlueTheme1.ThemeName.ToString());
            RadMessageBox.Show("Saved Successfully!", "Success");
        }
    }
}
