namespace ISBD
{
    partial class Pracownicy
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Pracownicy));
            System.Windows.Forms.Label idPLabel;
            System.Windows.Forms.Label nazwiskoLabel;
            System.Windows.Forms.Label imieLabel;
            System.Windows.Forms.Label peselLabel;
            System.Windows.Forms.Label dataUrLabel;
            System.Windows.Forms.Label dataZatrLabel;
            System.Windows.Forms.Label telefonLabel;
            System.Windows.Forms.Label miejscowoscLabel;
            System.Windows.Forms.Label wynagrodzenieLabel;
            System.Windows.Forms.Label loginLabel;
            System.Windows.Forms.Label hasloLabel;
            System.Windows.Forms.Label idSLabel;
            this.iSBDDataSet = new ISBD.ISBDDataSet();
            this.pracownikBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pracownikTableAdapter = new ISBD.ISBDDataSetTableAdapters.PracownikTableAdapter();
            this.tableAdapterManager = new ISBD.ISBDDataSetTableAdapters.TableAdapterManager();
            this.pracownikBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.pracownikBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.idPTextBox = new System.Windows.Forms.TextBox();
            this.nazwiskoTextBox = new System.Windows.Forms.TextBox();
            this.imieTextBox = new System.Windows.Forms.TextBox();
            this.peselTextBox = new System.Windows.Forms.TextBox();
            this.dataUrDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.dataZatrDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.telefonTextBox = new System.Windows.Forms.TextBox();
            this.miejscowoscTextBox = new System.Windows.Forms.TextBox();
            this.wynagrodzenieTextBox = new System.Windows.Forms.TextBox();
            this.loginTextBox = new System.Windows.Forms.TextBox();
            this.hasloTextBox = new System.Windows.Forms.TextBox();
            this.idSTextBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            idPLabel = new System.Windows.Forms.Label();
            nazwiskoLabel = new System.Windows.Forms.Label();
            imieLabel = new System.Windows.Forms.Label();
            peselLabel = new System.Windows.Forms.Label();
            dataUrLabel = new System.Windows.Forms.Label();
            dataZatrLabel = new System.Windows.Forms.Label();
            telefonLabel = new System.Windows.Forms.Label();
            miejscowoscLabel = new System.Windows.Forms.Label();
            wynagrodzenieLabel = new System.Windows.Forms.Label();
            loginLabel = new System.Windows.Forms.Label();
            hasloLabel = new System.Windows.Forms.Label();
            idSLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.iSBDDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pracownikBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pracownikBindingNavigator)).BeginInit();
            this.pracownikBindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // iSBDDataSet
            // 
            this.iSBDDataSet.DataSetName = "ISBDDataSet";
            this.iSBDDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // pracownikBindingSource
            // 
            this.pracownikBindingSource.DataMember = "Pracownik";
            this.pracownikBindingSource.DataSource = this.iSBDDataSet;
            // 
            // pracownikTableAdapter
            // 
            this.pracownikTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.AtrakcjaTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.DzieckoTableAdapter = null;
            this.tableAdapterManager.KlientTableAdapter = null;
            this.tableAdapterManager.PobytTableAdapter = null;
            this.tableAdapterManager.PracownikTableAdapter = this.pracownikTableAdapter;
            this.tableAdapterManager.SaleTableAdapter = null;
            this.tableAdapterManager.SprzedazAtrTableAdapter = null;
            this.tableAdapterManager.StanowiskoTableAdapter = null;
            this.tableAdapterManager.TypAtrTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = ISBD.ISBDDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.ZamowienieTableAdapter = null;
            // 
            // pracownikBindingNavigator
            // 
            this.pracownikBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.pracownikBindingNavigator.BindingSource = this.pracownikBindingSource;
            this.pracownikBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.pracownikBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.pracownikBindingNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.pracownikBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.pracownikBindingNavigatorSaveItem});
            this.pracownikBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.pracownikBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.pracownikBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.pracownikBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.pracownikBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.pracownikBindingNavigator.Name = "pracownikBindingNavigator";
            this.pracownikBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.pracownikBindingNavigator.Size = new System.Drawing.Size(373, 27);
            this.pracownikBindingNavigator.TabIndex = 0;
            this.pracownikBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(24, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(24, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 27);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(45, 20);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 6);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 6);
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // pracownikBindingNavigatorSaveItem
            // 
            this.pracownikBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.pracownikBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("pracownikBindingNavigatorSaveItem.Image")));
            this.pracownikBindingNavigatorSaveItem.Name = "pracownikBindingNavigatorSaveItem";
            this.pracownikBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 23);
            this.pracownikBindingNavigatorSaveItem.Text = "Save Data";
            this.pracownikBindingNavigatorSaveItem.Click += new System.EventHandler(this.pracownikBindingNavigatorSaveItem_Click);
            // 
            // idPLabel
            // 
            idPLabel.AutoSize = true;
            idPLabel.Location = new System.Drawing.Point(36, 64);
            idPLabel.Name = "idPLabel";
            idPLabel.Size = new System.Drawing.Size(36, 17);
            idPLabel.TabIndex = 1;
            idPLabel.Text = "Id P:";
            // 
            // idPTextBox
            // 
            this.idPTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pracownikBindingSource, "IdP", true));
            this.idPTextBox.Location = new System.Drawing.Point(153, 61);
            this.idPTextBox.Name = "idPTextBox";
            this.idPTextBox.Size = new System.Drawing.Size(200, 22);
            this.idPTextBox.TabIndex = 2;
            // 
            // nazwiskoLabel
            // 
            nazwiskoLabel.AutoSize = true;
            nazwiskoLabel.Location = new System.Drawing.Point(36, 92);
            nazwiskoLabel.Name = "nazwiskoLabel";
            nazwiskoLabel.Size = new System.Drawing.Size(71, 17);
            nazwiskoLabel.TabIndex = 3;
            nazwiskoLabel.Text = "Nazwisko:";
            // 
            // nazwiskoTextBox
            // 
            this.nazwiskoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pracownikBindingSource, "Nazwisko", true));
            this.nazwiskoTextBox.Location = new System.Drawing.Point(153, 89);
            this.nazwiskoTextBox.Name = "nazwiskoTextBox";
            this.nazwiskoTextBox.Size = new System.Drawing.Size(200, 22);
            this.nazwiskoTextBox.TabIndex = 4;
            // 
            // imieLabel
            // 
            imieLabel.AutoSize = true;
            imieLabel.Location = new System.Drawing.Point(36, 120);
            imieLabel.Name = "imieLabel";
            imieLabel.Size = new System.Drawing.Size(37, 17);
            imieLabel.TabIndex = 5;
            imieLabel.Text = "Imie:";
            // 
            // imieTextBox
            // 
            this.imieTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pracownikBindingSource, "Imie", true));
            this.imieTextBox.Location = new System.Drawing.Point(153, 117);
            this.imieTextBox.Name = "imieTextBox";
            this.imieTextBox.Size = new System.Drawing.Size(200, 22);
            this.imieTextBox.TabIndex = 6;
            // 
            // peselLabel
            // 
            peselLabel.AutoSize = true;
            peselLabel.Location = new System.Drawing.Point(36, 148);
            peselLabel.Name = "peselLabel";
            peselLabel.Size = new System.Drawing.Size(47, 17);
            peselLabel.TabIndex = 7;
            peselLabel.Text = "Pesel:";
            // 
            // peselTextBox
            // 
            this.peselTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pracownikBindingSource, "Pesel", true));
            this.peselTextBox.Location = new System.Drawing.Point(153, 145);
            this.peselTextBox.Name = "peselTextBox";
            this.peselTextBox.Size = new System.Drawing.Size(200, 22);
            this.peselTextBox.TabIndex = 8;
            // 
            // dataUrLabel
            // 
            dataUrLabel.AutoSize = true;
            dataUrLabel.Location = new System.Drawing.Point(36, 177);
            dataUrLabel.Name = "dataUrLabel";
            dataUrLabel.Size = new System.Drawing.Size(61, 17);
            dataUrLabel.TabIndex = 9;
            dataUrLabel.Text = "Data Ur:";
            // 
            // dataUrDateTimePicker
            // 
            this.dataUrDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.pracownikBindingSource, "DataUr", true));
            this.dataUrDateTimePicker.Location = new System.Drawing.Point(153, 173);
            this.dataUrDateTimePicker.Name = "dataUrDateTimePicker";
            this.dataUrDateTimePicker.Size = new System.Drawing.Size(200, 22);
            this.dataUrDateTimePicker.TabIndex = 10;
            // 
            // dataZatrLabel
            // 
            dataZatrLabel.AutoSize = true;
            dataZatrLabel.Location = new System.Drawing.Point(36, 205);
            dataZatrLabel.Name = "dataZatrLabel";
            dataZatrLabel.Size = new System.Drawing.Size(72, 17);
            dataZatrLabel.TabIndex = 11;
            dataZatrLabel.Text = "Data Zatr:";
            // 
            // dataZatrDateTimePicker
            // 
            this.dataZatrDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.pracownikBindingSource, "DataZatr", true));
            this.dataZatrDateTimePicker.Location = new System.Drawing.Point(153, 201);
            this.dataZatrDateTimePicker.Name = "dataZatrDateTimePicker";
            this.dataZatrDateTimePicker.Size = new System.Drawing.Size(200, 22);
            this.dataZatrDateTimePicker.TabIndex = 12;
            // 
            // telefonLabel
            // 
            telefonLabel.AutoSize = true;
            telefonLabel.Location = new System.Drawing.Point(36, 232);
            telefonLabel.Name = "telefonLabel";
            telefonLabel.Size = new System.Drawing.Size(60, 17);
            telefonLabel.TabIndex = 13;
            telefonLabel.Text = "Telefon:";
            // 
            // telefonTextBox
            // 
            this.telefonTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pracownikBindingSource, "Telefon", true));
            this.telefonTextBox.Location = new System.Drawing.Point(153, 229);
            this.telefonTextBox.Name = "telefonTextBox";
            this.telefonTextBox.Size = new System.Drawing.Size(200, 22);
            this.telefonTextBox.TabIndex = 14;
            // 
            // miejscowoscLabel
            // 
            miejscowoscLabel.AutoSize = true;
            miejscowoscLabel.Location = new System.Drawing.Point(36, 260);
            miejscowoscLabel.Name = "miejscowoscLabel";
            miejscowoscLabel.Size = new System.Drawing.Size(90, 17);
            miejscowoscLabel.TabIndex = 15;
            miejscowoscLabel.Text = "Miejscowosc:";
            // 
            // miejscowoscTextBox
            // 
            this.miejscowoscTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pracownikBindingSource, "Miejscowosc", true));
            this.miejscowoscTextBox.Location = new System.Drawing.Point(153, 257);
            this.miejscowoscTextBox.Name = "miejscowoscTextBox";
            this.miejscowoscTextBox.Size = new System.Drawing.Size(200, 22);
            this.miejscowoscTextBox.TabIndex = 16;
            // 
            // wynagrodzenieLabel
            // 
            wynagrodzenieLabel.AutoSize = true;
            wynagrodzenieLabel.Location = new System.Drawing.Point(36, 288);
            wynagrodzenieLabel.Name = "wynagrodzenieLabel";
            wynagrodzenieLabel.Size = new System.Drawing.Size(111, 17);
            wynagrodzenieLabel.TabIndex = 17;
            wynagrodzenieLabel.Text = "Wynagrodzenie:";
            // 
            // wynagrodzenieTextBox
            // 
            this.wynagrodzenieTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pracownikBindingSource, "Wynagrodzenie", true));
            this.wynagrodzenieTextBox.Location = new System.Drawing.Point(153, 285);
            this.wynagrodzenieTextBox.Name = "wynagrodzenieTextBox";
            this.wynagrodzenieTextBox.Size = new System.Drawing.Size(200, 22);
            this.wynagrodzenieTextBox.TabIndex = 18;
            // 
            // loginLabel
            // 
            loginLabel.AutoSize = true;
            loginLabel.Location = new System.Drawing.Point(36, 316);
            loginLabel.Name = "loginLabel";
            loginLabel.Size = new System.Drawing.Size(47, 17);
            loginLabel.TabIndex = 19;
            loginLabel.Text = "Login:";
            // 
            // loginTextBox
            // 
            this.loginTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pracownikBindingSource, "Login", true));
            this.loginTextBox.Location = new System.Drawing.Point(153, 313);
            this.loginTextBox.Name = "loginTextBox";
            this.loginTextBox.Size = new System.Drawing.Size(200, 22);
            this.loginTextBox.TabIndex = 20;
            // 
            // hasloLabel
            // 
            hasloLabel.AutoSize = true;
            hasloLabel.Location = new System.Drawing.Point(36, 344);
            hasloLabel.Name = "hasloLabel";
            hasloLabel.Size = new System.Drawing.Size(48, 17);
            hasloLabel.TabIndex = 21;
            hasloLabel.Text = "Haslo:";
            // 
            // hasloTextBox
            // 
            this.hasloTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pracownikBindingSource, "Haslo", true));
            this.hasloTextBox.Location = new System.Drawing.Point(153, 341);
            this.hasloTextBox.Name = "hasloTextBox";
            this.hasloTextBox.Size = new System.Drawing.Size(200, 22);
            this.hasloTextBox.TabIndex = 22;
            // 
            // idSLabel
            // 
            idSLabel.AutoSize = true;
            idSLabel.Location = new System.Drawing.Point(36, 372);
            idSLabel.Name = "idSLabel";
            idSLabel.Size = new System.Drawing.Size(36, 17);
            idSLabel.TabIndex = 23;
            idSLabel.Text = "Id S:";
            // 
            // idSTextBox
            // 
            this.idSTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pracownikBindingSource, "IdS", true));
            this.idSTextBox.Location = new System.Drawing.Point(153, 369);
            this.idSTextBox.Name = "idSTextBox";
            this.idSTextBox.Size = new System.Drawing.Size(200, 22);
            this.idSTextBox.TabIndex = 24;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(153, 417);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 25;
            this.button1.Text = "Powrót";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Pracownicy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(373, 452);
            this.Controls.Add(this.button1);
            this.Controls.Add(idPLabel);
            this.Controls.Add(this.idPTextBox);
            this.Controls.Add(nazwiskoLabel);
            this.Controls.Add(this.nazwiskoTextBox);
            this.Controls.Add(imieLabel);
            this.Controls.Add(this.imieTextBox);
            this.Controls.Add(peselLabel);
            this.Controls.Add(this.peselTextBox);
            this.Controls.Add(dataUrLabel);
            this.Controls.Add(this.dataUrDateTimePicker);
            this.Controls.Add(dataZatrLabel);
            this.Controls.Add(this.dataZatrDateTimePicker);
            this.Controls.Add(telefonLabel);
            this.Controls.Add(this.telefonTextBox);
            this.Controls.Add(miejscowoscLabel);
            this.Controls.Add(this.miejscowoscTextBox);
            this.Controls.Add(wynagrodzenieLabel);
            this.Controls.Add(this.wynagrodzenieTextBox);
            this.Controls.Add(loginLabel);
            this.Controls.Add(this.loginTextBox);
            this.Controls.Add(hasloLabel);
            this.Controls.Add(this.hasloTextBox);
            this.Controls.Add(idSLabel);
            this.Controls.Add(this.idSTextBox);
            this.Controls.Add(this.pracownikBindingNavigator);
            this.Name = "Pracownicy";
            this.Text = "Pracownicy";
            this.Load += new System.EventHandler(this.Pracownicy_Load);
            ((System.ComponentModel.ISupportInitialize)(this.iSBDDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pracownikBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pracownikBindingNavigator)).EndInit();
            this.pracownikBindingNavigator.ResumeLayout(false);
            this.pracownikBindingNavigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ISBDDataSet iSBDDataSet;
        private System.Windows.Forms.BindingSource pracownikBindingSource;
        private ISBDDataSetTableAdapters.PracownikTableAdapter pracownikTableAdapter;
        private ISBDDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator pracownikBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton pracownikBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox idPTextBox;
        private System.Windows.Forms.TextBox nazwiskoTextBox;
        private System.Windows.Forms.TextBox imieTextBox;
        private System.Windows.Forms.TextBox peselTextBox;
        private System.Windows.Forms.DateTimePicker dataUrDateTimePicker;
        private System.Windows.Forms.DateTimePicker dataZatrDateTimePicker;
        private System.Windows.Forms.TextBox telefonTextBox;
        private System.Windows.Forms.TextBox miejscowoscTextBox;
        private System.Windows.Forms.TextBox wynagrodzenieTextBox;
        private System.Windows.Forms.TextBox loginTextBox;
        private System.Windows.Forms.TextBox hasloTextBox;
        private System.Windows.Forms.TextBox idSTextBox;
        private System.Windows.Forms.Button button1;
    }
}