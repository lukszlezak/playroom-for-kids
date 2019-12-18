namespace ISBD
{
    partial class Zamowienia
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Zamowienia));
            System.Windows.Forms.Label idZamLabel;
            System.Windows.Forms.Label idKLabel;
            System.Windows.Forms.Label idPLabel;
            System.Windows.Forms.Label dataZamLabel;
            System.Windows.Forms.Label wartoscLabel;
            this.iSBDDataSet = new ISBD.ISBDDataSet();
            this.zamowienieBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.zamowienieTableAdapter = new ISBD.ISBDDataSetTableAdapters.ZamowienieTableAdapter();
            this.tableAdapterManager = new ISBD.ISBDDataSetTableAdapters.TableAdapterManager();
            this.zamowienieBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.zamowienieBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.idZamTextBox = new System.Windows.Forms.TextBox();
            this.idKTextBox = new System.Windows.Forms.TextBox();
            this.idPTextBox = new System.Windows.Forms.TextBox();
            this.dataZamDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.wartoscTextBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            idZamLabel = new System.Windows.Forms.Label();
            idKLabel = new System.Windows.Forms.Label();
            idPLabel = new System.Windows.Forms.Label();
            dataZamLabel = new System.Windows.Forms.Label();
            wartoscLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.iSBDDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.zamowienieBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.zamowienieBindingNavigator)).BeginInit();
            this.zamowienieBindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // iSBDDataSet
            // 
            this.iSBDDataSet.DataSetName = "ISBDDataSet";
            this.iSBDDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // zamowienieBindingSource
            // 
            this.zamowienieBindingSource.DataMember = "Zamowienie";
            this.zamowienieBindingSource.DataSource = this.iSBDDataSet;
            // 
            // zamowienieTableAdapter
            // 
            this.zamowienieTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.AtrakcjaTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.DzieckoTableAdapter = null;
            this.tableAdapterManager.KlientTableAdapter = null;
            this.tableAdapterManager.PobytTableAdapter = null;
            this.tableAdapterManager.PracownikTableAdapter = null;
            this.tableAdapterManager.SaleTableAdapter = null;
            this.tableAdapterManager.SprzedazAtrTableAdapter = null;
            this.tableAdapterManager.StanowiskoTableAdapter = null;
            this.tableAdapterManager.TypAtrTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = ISBD.ISBDDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.ZamowienieTableAdapter = this.zamowienieTableAdapter;
            // 
            // zamowienieBindingNavigator
            // 
            this.zamowienieBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.zamowienieBindingNavigator.BindingSource = this.zamowienieBindingSource;
            this.zamowienieBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.zamowienieBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.zamowienieBindingNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.zamowienieBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.zamowienieBindingNavigatorSaveItem});
            this.zamowienieBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.zamowienieBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.zamowienieBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.zamowienieBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.zamowienieBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.zamowienieBindingNavigator.Name = "zamowienieBindingNavigator";
            this.zamowienieBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.zamowienieBindingNavigator.Size = new System.Drawing.Size(372, 27);
            this.zamowienieBindingNavigator.TabIndex = 0;
            this.zamowienieBindingNavigator.Text = "bindingNavigator1";
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
            // zamowienieBindingNavigatorSaveItem
            // 
            this.zamowienieBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.zamowienieBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("zamowienieBindingNavigatorSaveItem.Image")));
            this.zamowienieBindingNavigatorSaveItem.Name = "zamowienieBindingNavigatorSaveItem";
            this.zamowienieBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 23);
            this.zamowienieBindingNavigatorSaveItem.Text = "Save Data";
            this.zamowienieBindingNavigatorSaveItem.Click += new System.EventHandler(this.zamowienieBindingNavigatorSaveItem_Click);
            // 
            // idZamLabel
            // 
            idZamLabel.AutoSize = true;
            idZamLabel.Location = new System.Drawing.Point(44, 87);
            idZamLabel.Name = "idZamLabel";
            idZamLabel.Size = new System.Drawing.Size(55, 17);
            idZamLabel.TabIndex = 1;
            idZamLabel.Text = "Id Zam:";
            // 
            // idZamTextBox
            // 
            this.idZamTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.zamowienieBindingSource, "IdZam", true));
            this.idZamTextBox.Location = new System.Drawing.Point(124, 84);
            this.idZamTextBox.Name = "idZamTextBox";
            this.idZamTextBox.Size = new System.Drawing.Size(200, 22);
            this.idZamTextBox.TabIndex = 2;
            // 
            // idKLabel
            // 
            idKLabel.AutoSize = true;
            idKLabel.Location = new System.Drawing.Point(44, 115);
            idKLabel.Name = "idKLabel";
            idKLabel.Size = new System.Drawing.Size(36, 17);
            idKLabel.TabIndex = 3;
            idKLabel.Text = "Id K:";
            // 
            // idKTextBox
            // 
            this.idKTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.zamowienieBindingSource, "IdK", true));
            this.idKTextBox.Location = new System.Drawing.Point(124, 112);
            this.idKTextBox.Name = "idKTextBox";
            this.idKTextBox.Size = new System.Drawing.Size(200, 22);
            this.idKTextBox.TabIndex = 4;
            // 
            // idPLabel
            // 
            idPLabel.AutoSize = true;
            idPLabel.Location = new System.Drawing.Point(44, 143);
            idPLabel.Name = "idPLabel";
            idPLabel.Size = new System.Drawing.Size(36, 17);
            idPLabel.TabIndex = 5;
            idPLabel.Text = "Id P:";
            // 
            // idPTextBox
            // 
            this.idPTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.zamowienieBindingSource, "IdP", true));
            this.idPTextBox.Location = new System.Drawing.Point(124, 140);
            this.idPTextBox.Name = "idPTextBox";
            this.idPTextBox.Size = new System.Drawing.Size(200, 22);
            this.idPTextBox.TabIndex = 6;
            // 
            // dataZamLabel
            // 
            dataZamLabel.AutoSize = true;
            dataZamLabel.Location = new System.Drawing.Point(44, 172);
            dataZamLabel.Name = "dataZamLabel";
            dataZamLabel.Size = new System.Drawing.Size(74, 17);
            dataZamLabel.TabIndex = 7;
            dataZamLabel.Text = "Data Zam:";
            // 
            // dataZamDateTimePicker
            // 
            this.dataZamDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.zamowienieBindingSource, "DataZam", true));
            this.dataZamDateTimePicker.Location = new System.Drawing.Point(124, 168);
            this.dataZamDateTimePicker.Name = "dataZamDateTimePicker";
            this.dataZamDateTimePicker.Size = new System.Drawing.Size(200, 22);
            this.dataZamDateTimePicker.TabIndex = 8;
            // 
            // wartoscLabel
            // 
            wartoscLabel.AutoSize = true;
            wartoscLabel.Location = new System.Drawing.Point(44, 199);
            wartoscLabel.Name = "wartoscLabel";
            wartoscLabel.Size = new System.Drawing.Size(64, 17);
            wartoscLabel.TabIndex = 9;
            wartoscLabel.Text = "Wartosc:";
            // 
            // wartoscTextBox
            // 
            this.wartoscTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.zamowienieBindingSource, "Wartosc", true));
            this.wartoscTextBox.Location = new System.Drawing.Point(124, 196);
            this.wartoscTextBox.Name = "wartoscTextBox";
            this.wartoscTextBox.Size = new System.Drawing.Size(200, 22);
            this.wartoscTextBox.TabIndex = 10;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(124, 245);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(124, 23);
            this.button1.TabIndex = 11;
            this.button1.Text = "Powrót";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Zamowienia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(372, 290);
            this.Controls.Add(this.button1);
            this.Controls.Add(idZamLabel);
            this.Controls.Add(this.idZamTextBox);
            this.Controls.Add(idKLabel);
            this.Controls.Add(this.idKTextBox);
            this.Controls.Add(idPLabel);
            this.Controls.Add(this.idPTextBox);
            this.Controls.Add(dataZamLabel);
            this.Controls.Add(this.dataZamDateTimePicker);
            this.Controls.Add(wartoscLabel);
            this.Controls.Add(this.wartoscTextBox);
            this.Controls.Add(this.zamowienieBindingNavigator);
            this.Name = "Zamowienia";
            this.Text = "Zamowienia";
            this.Load += new System.EventHandler(this.Zamowienia_Load);
            ((System.ComponentModel.ISupportInitialize)(this.iSBDDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.zamowienieBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.zamowienieBindingNavigator)).EndInit();
            this.zamowienieBindingNavigator.ResumeLayout(false);
            this.zamowienieBindingNavigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ISBDDataSet iSBDDataSet;
        private System.Windows.Forms.BindingSource zamowienieBindingSource;
        private ISBDDataSetTableAdapters.ZamowienieTableAdapter zamowienieTableAdapter;
        private ISBDDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator zamowienieBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton zamowienieBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox idZamTextBox;
        private System.Windows.Forms.TextBox idKTextBox;
        private System.Windows.Forms.TextBox idPTextBox;
        private System.Windows.Forms.DateTimePicker dataZamDateTimePicker;
        private System.Windows.Forms.TextBox wartoscTextBox;
        private System.Windows.Forms.Button button1;
    }
}