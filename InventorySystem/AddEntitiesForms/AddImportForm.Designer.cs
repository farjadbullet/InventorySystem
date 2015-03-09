namespace InventorySystem
{
    partial class AddImportForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddImportForm));
            this.TextBoxContact2 = new Telerik.WinControls.UI.RadTextBoxControl();
            this.TextBoxCompanyName = new Telerik.WinControls.UI.RadAutoCompleteBox();
            this.radLabel3 = new Telerik.WinControls.UI.RadLabel();
            this.radLabel4 = new Telerik.WinControls.UI.RadLabel();
            this.radLabel2 = new Telerik.WinControls.UI.RadLabel();
            this.radLabel1 = new Telerik.WinControls.UI.RadLabel();
            this.TextBoxContact = new Telerik.WinControls.UI.RadTextBoxControl();
            this.TextBoxName = new Telerik.WinControls.UI.RadTextBoxControl();
            this.BtnAddOrderDetails = new Telerik.WinControls.UI.RadButton();
            this.BtnAddProductionDetails = new Telerik.WinControls.UI.RadButton();
            this.BtnAddItemExpenses = new Telerik.WinControls.UI.RadButton();
            this.BtnSave = new Telerik.WinControls.UI.RadButton();
            ((System.ComponentModel.ISupportInitialize)(this.TextBoxContact2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TextBoxCompanyName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TextBoxContact)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TextBoxName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnAddOrderDetails)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnAddProductionDetails)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnAddItemExpenses)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnSave)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // TextBoxContact2
            // 
            this.TextBoxContact2.BackColor = System.Drawing.Color.DimGray;
            this.TextBoxContact2.Location = new System.Drawing.Point(12, 256);
            this.TextBoxContact2.Name = "TextBoxContact2";
            this.TextBoxContact2.Size = new System.Drawing.Size(140, 20);
            this.TextBoxContact2.TabIndex = 17;
            this.TextBoxContact2.ThemeName = "TelerikMetroBlue";
            // 
            // TextBoxCompanyName
            // 
            this.TextBoxCompanyName.AutoCompleteDisplayMember = "CompanyName";
            this.TextBoxCompanyName.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.TextBoxCompanyName.AutoCompleteValueMember = "Id";
            this.TextBoxCompanyName.Location = new System.Drawing.Point(12, 160);
            this.TextBoxCompanyName.Name = "TextBoxCompanyName";
            this.TextBoxCompanyName.Size = new System.Drawing.Size(140, 20);
            this.TextBoxCompanyName.TabIndex = 16;
            this.TextBoxCompanyName.ThemeName = "TelerikMetroBlue";
            // 
            // radLabel3
            // 
            this.radLabel3.Location = new System.Drawing.Point(12, 234);
            this.radLabel3.Name = "radLabel3";
            this.radLabel3.Size = new System.Drawing.Size(38, 16);
            this.radLabel3.TabIndex = 13;
            this.radLabel3.Text = "Status";
            this.radLabel3.ThemeName = "TelerikMetroBlue";
            // 
            // radLabel4
            // 
            this.radLabel4.Location = new System.Drawing.Point(12, 186);
            this.radLabel4.Name = "radLabel4";
            this.radLabel4.Size = new System.Drawing.Size(65, 16);
            this.radLabel4.TabIndex = 14;
            this.radLabel4.Text = "Arrival Date";
            this.radLabel4.ThemeName = "TelerikMetroBlue";
            // 
            // radLabel2
            // 
            this.radLabel2.Location = new System.Drawing.Point(12, 138);
            this.radLabel2.Name = "radLabel2";
            this.radLabel2.Size = new System.Drawing.Size(62, 16);
            this.radLabel2.TabIndex = 15;
            this.radLabel2.Text = "Order Date";
            this.radLabel2.ThemeName = "TelerikMetroBlue";
            // 
            // radLabel1
            // 
            this.radLabel1.Location = new System.Drawing.Point(12, 90);
            this.radLabel1.Name = "radLabel1";
            this.radLabel1.Size = new System.Drawing.Size(68, 16);
            this.radLabel1.TabIndex = 12;
            this.radLabel1.Text = "Container Id";
            this.radLabel1.ThemeName = "TelerikMetroBlue";
            // 
            // TextBoxContact
            // 
            this.TextBoxContact.BackColor = System.Drawing.Color.DimGray;
            this.TextBoxContact.Location = new System.Drawing.Point(12, 208);
            this.TextBoxContact.Name = "TextBoxContact";
            this.TextBoxContact.Size = new System.Drawing.Size(140, 20);
            this.TextBoxContact.TabIndex = 11;
            this.TextBoxContact.ThemeName = "TelerikMetroBlue";
            // 
            // TextBoxName
            // 
            this.TextBoxName.BackColor = System.Drawing.Color.DarkRed;
            this.TextBoxName.Location = new System.Drawing.Point(12, 112);
            this.TextBoxName.Name = "TextBoxName";
            this.TextBoxName.Size = new System.Drawing.Size(140, 20);
            this.TextBoxName.TabIndex = 10;
            this.TextBoxName.ThemeName = "TelerikMetroBlue";
            // 
            // BtnAddOrderDetails
            // 
            this.BtnAddOrderDetails.Location = new System.Drawing.Point(12, 312);
            this.BtnAddOrderDetails.Name = "BtnAddOrderDetails";
            this.BtnAddOrderDetails.Size = new System.Drawing.Size(140, 24);
            this.BtnAddOrderDetails.TabIndex = 18;
            this.BtnAddOrderDetails.Text = "Add Order Details";
            this.BtnAddOrderDetails.ThemeName = "TelerikMetroBlue";
            this.BtnAddOrderDetails.Click += new System.EventHandler(this.BtnAddOrderDetails_Click);
            // 
            // BtnAddProductionDetails
            // 
            this.BtnAddProductionDetails.Location = new System.Drawing.Point(12, 342);
            this.BtnAddProductionDetails.Name = "BtnAddProductionDetails";
            this.BtnAddProductionDetails.Size = new System.Drawing.Size(140, 24);
            this.BtnAddProductionDetails.TabIndex = 19;
            this.BtnAddProductionDetails.Text = "Add Production Details";
            this.BtnAddProductionDetails.ThemeName = "TelerikMetroBlue";
            this.BtnAddProductionDetails.Click += new System.EventHandler(this.BtnAddProductionDetails_Click);
            // 
            // BtnAddItemExpenses
            // 
            this.BtnAddItemExpenses.Location = new System.Drawing.Point(12, 372);
            this.BtnAddItemExpenses.Name = "BtnAddItemExpenses";
            this.BtnAddItemExpenses.Size = new System.Drawing.Size(140, 24);
            this.BtnAddItemExpenses.TabIndex = 20;
            this.BtnAddItemExpenses.Text = "Add Order Expenses";
            this.BtnAddItemExpenses.ThemeName = "TelerikMetroBlue";
            this.BtnAddItemExpenses.Click += new System.EventHandler(this.BtnAddItemExpenses_Click);
            // 
            // BtnSave
            // 
            this.BtnSave.Location = new System.Drawing.Point(12, 282);
            this.BtnSave.Name = "BtnSave";
            this.BtnSave.Size = new System.Drawing.Size(140, 24);
            this.BtnSave.TabIndex = 21;
            this.BtnSave.Text = "Save Order";
            this.BtnSave.ThemeName = "TelerikMetroBlue";
            this.BtnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // AddImportForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::InventorySystem.Properties.Resources.logo;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(225, 422);
            this.Controls.Add(this.BtnSave);
            this.Controls.Add(this.BtnAddItemExpenses);
            this.Controls.Add(this.BtnAddProductionDetails);
            this.Controls.Add(this.BtnAddOrderDetails);
            this.Controls.Add(this.TextBoxContact2);
            this.Controls.Add(this.TextBoxCompanyName);
            this.Controls.Add(this.radLabel3);
            this.Controls.Add(this.radLabel4);
            this.Controls.Add(this.radLabel2);
            this.Controls.Add(this.radLabel1);
            this.Controls.Add(this.TextBoxContact);
            this.Controls.Add(this.TextBoxName);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AddImportForm";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "AddImportForm";
            this.ThemeName = "TelerikMetroBlue";
            ((System.ComponentModel.ISupportInitialize)(this.TextBoxContact2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TextBoxCompanyName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TextBoxContact)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TextBoxName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnAddOrderDetails)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnAddProductionDetails)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnAddItemExpenses)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnSave)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Telerik.WinControls.UI.RadTextBoxControl TextBoxContact2;
        private Telerik.WinControls.UI.RadAutoCompleteBox TextBoxCompanyName;
        private Telerik.WinControls.UI.RadLabel radLabel3;
        private Telerik.WinControls.UI.RadLabel radLabel4;
        private Telerik.WinControls.UI.RadLabel radLabel2;
        private Telerik.WinControls.UI.RadLabel radLabel1;
        private Telerik.WinControls.UI.RadTextBoxControl TextBoxContact;
        private Telerik.WinControls.UI.RadTextBoxControl TextBoxName;
        private Telerik.WinControls.UI.RadButton BtnAddOrderDetails;
        private Telerik.WinControls.UI.RadButton BtnAddProductionDetails;
        private Telerik.WinControls.UI.RadButton BtnAddItemExpenses;
        private Telerik.WinControls.UI.RadButton BtnSave;
    }
}
