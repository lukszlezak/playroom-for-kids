namespace ISBD
{
    partial class Atrakcje
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Atrakcje));
            System.Windows.Forms.Label idAtrLabel;
            System.Windows.Forms.Label nazwaLabel;
            System.Windows.Forms.Label cenaLabel;
            System.Windows.Forms.Label idTypuLabel;
            System.Windows.Forms.Label idSaliLabel;
            System.Windows.Forms.Label liczbaLabel;
            this.iSBDDataSet = new ISBD.ISBDDataSet();
            this.atrakcjaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.atrakcjaTableAdapter = new ISBD.ISBDDataSetTableAdapters.AtrakcjaTableAdapter();
            this.tableAdapterManager = new ISBD.ISBDDataSetTableAdapters.TableAdapterManager();
            this.atrakcjaBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.atrakcjaBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.idAtrTextBox = new System.Windows.Forms.TextBox();
            this.nazwaTextBox = new System.Windows.Forms.TextBox();
            this.cenaTextBox = new System.Windows.Forms.TextBox();
            this.idTypuTextBox = new System.Windows.Forms.TextBox();
            this.idSaliTextBox = new System.Windows.Forms.TextBox();
            this.liczbaTextBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            idAtrLabel = new System.Windows.Forms.Label();
            nazwaLabel = new System.Windows.Forms.Label();
            cenaLabel = new System.Windows.Forms.Label();
            idTypuLabel = new System.Windows.Forms.Label();
            idSaliLabel = new System.Windows.Forms.Label();
            liczbaLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.iSBDDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.atrakcjaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.atrakcjaBindingNavigator)).BeginInit();
            this.atrakcjaBindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // iSBDDataSet
            // 
            this.iSBDDataSet.DataSetName = "ISBDDataSet";
            this.iSBDDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // atrakcjaBindingSource
            // 
            this.atrakcjaBindingSource.DataMember = "Atrakcja";
            this.atrakcjaBindingSource.DataSource = this.iSBDDataSet;
            // 
            // atrakcjaTableAdapter
            // 
            this.atrakcjaTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.AtrakcjaTableAdapter = this.atrakcjaTableAdapter;
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
            this.tableAdapterManager.ZamowienieTableAdapter = null;
            // 
            // atrakcjaBindingNavigator
            // 
            this.atrakcjaBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.atrakcjaBindingNavigator.BindingSource = this.atrakcjaBindingSource;
            this.atrakcjaBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.atrakcjaBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.atrakcjaBindingNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.atrakcjaBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.atrakcjaBindingNavigatorSaveItem});
            this.atrakcjaBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.atrakcjaBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.atrakcjaBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.atrakcjaBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.atrakcjaBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.atrakcjaBindingNavigator.Name = "atrakcjaBindingNavigator";
            this.atrakcjaBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.atrakcjaBindingNavigator.Size = new System.Drawing.Size(282, 27);
            this.atrakcjaBindingNavigator.TabIndex = 0;
            this.atrakcjaBindingNavigator.Text = "bindingNavigator1";
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
            // atrakcjaBindingNavigatorSaveItem
            // 
            this.atrakcjaBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.atrakcjaBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("atrakcjaBindingNavigatorSaveItem.Image")));
            this.atrakcjaBindingNavigatorSaveItem.Name = "atrakcjaBindingNavigatorSaveItem";
            this.atrakcjaBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 23);
            this.atrakcjaBindingNavigatorSaveItem.Text = "Save Data";
            this.atrakcjaBindingNavigatorSaveItem.Click += new System.EventHandler(this.atrakcjaBindingNavigatorSaveItem_Click);
            // 
            // idAtrLabel
            // 
            idAtrLabel.AutoSize = true;
            idAtrLabel.Location = new System.Drawing.Point(42, 73);
            idAtrLabel.Name = "idAtrLabel";
            idAtrLabel.Size = new System.Drawing.Size(45, 17);
            idAtrLabel.TabIndex = 1;
            idAtrLabel.Text = "Id Atr:";
            // 
            // idAtrTextBox
            // 
            this.idAtrTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.atrakcjaBindingSource, "IdAtr", true));
            this.idAtrTextBox.Location = new System.Drawing.Point(107, 70);
            this.idAtrTextBox.Name = "idAtrTextBox";
            this.idAtrTextBox.Size = new System.Drawing.Size(100, 22);
            this.idAtrTextBox.TabIndex = 2;
            // 
            // nazwaLabel
            // 
            nazwaLabel.AutoSize = true;
            nazwaLabel.Location = new System.Drawing.Point(42, 101);
            nazwaLabel.Name = "nazwaLabel";
            nazwaLabel.Size = new System.Drawing.Size(54, 17);
            nazwaLabel.TabIndex = 3;
            nazwaLabel.Text = "Nazwa:";
            // 
            // nazwaTextBox
            // 
            this.nazwaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.atrakcjaBindingSource, "Nazwa", true));
            this.nazwaTextBox.Location = new System.Drawing.Point(107, 98);
            this.nazwaTextBox.Name = "nazwaTextBox";
            this.nazwaTextBox.Size = new System.Drawing.Size(100, 22);
            this.nazwaTextBox.TabIndex = 4;
            // 
            // cenaLabel
            // 
            cenaLabel.AutoSize = true;
            cenaLabel.Location = new System.Drawing.Point(42, 129);
            cenaLabel.Name = "cenaLabel";
            cenaLabel.Size = new System.Drawing.Size(45, 17);
            cenaLabel.TabIndex = 5;
            cenaLabel.Text = "Cena:";
            // 
            // cenaTextBox
            // 
            this.cenaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.atrakcjaBindingSource, "Cena", true));
            this.cenaTextBox.Location = new System.Drawing.Point(107, 126);
            this.cenaTextBox.Name = "cenaTextBox";
            this.cenaTextBox.Size = new System.Drawing.Size(100, 22);
            this.cenaTextBox.TabIndex = 6;
            // 
            // idTypuLabel
            // 
            idTypuLabel.AutoSize = true;
            idTypuLabel.Location = new System.Drawing.Point(42, 157);
            idTypuLabel.Name = "idTypuLabel";
            idTypuLabel.Size = new System.Drawing.Size(59, 17);
            idTypuLabel.TabIndex = 7;
            idTypuLabel.Text = "Id Typu:";
            // 
            // idTypuTextBox
            // 
            this.idTypuTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.atrakcjaBindingSource, "IdTypu", true));
            this.idTypuTextBox.Location = new System.Drawing.Point(107, 154);
            this.idTypuTextBox.Name = "idTypuTextBox";
            this.idTypuTextBox.Size = new System.Drawing.Size(100, 22);
            this.idTypuTextBox.TabIndex = 8;
            // 
            // idSaliLabel
            // 
            idSaliLabel.AutoSize = true;
            idSaliLabel.Location = new System.Drawing.Point(42, 185);
            idSaliLabel.Name = "idSaliLabel";
            idSaliLabel.Size = new System.Drawing.Size(50, 17);
            idSaliLabel.TabIndex = 9;
            idSaliLabel.Text = "Id Sali:";
            // 
            // idSaliTextBox
            // 
            this.idSaliTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.atrakcjaBindingSource, "IdSali", true));
            this.idSaliTextBox.Location = new System.Drawing.Point(107, 182);
            this.idSaliTextBox.Name = "idSaliTextBox";
            this.idSaliTextBox.Size = new System.Drawing.Size(100, 22);
            this.idSaliTextBox.TabIndex = 10;
            // 
            // liczbaLabel
            // 
            liczbaLabel.AutoSize = true;
            liczbaLabel.Location = new System.Drawing.Point(42, 213);
            liczbaLabel.Name = "liczbaLabel";
            liczbaLabel.Size = new System.Drawing.Size(53, 17);
            liczbaLabel.TabIndex = 11;
            liczbaLabel.Text = "Liczba:";
            // 
            // liczbaTextBox
            // 
            this.liczbaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.atrakcjaBindingSource, "Liczba", true));
            this.liczbaTextBox.Location = new System.Drawing.Point(107, 210);
            this.liczbaTextBox.Name = "liczbaTextBox";
            this.liczbaTextBox.Size = new System.Drawing.Size(100, 22);
            this.liczbaTextBox.TabIndex = 12;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(107, 254);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 23);
            this.button1.TabIndex = 13;
            this.button1.Text = "Powrót";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Atrakcje
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(282, 298);
            this.Controls.Add(this.button1);
            this.Controls.Add(idAtrLabel);
            this.Controls.Add(this.idAtrTextBox);
            this.Controls.Add(nazwaLabel);
            this.Controls.Add(this.nazwaTextBox);
            this.Controls.Add(cenaLabel);
            this.Controls.Add(this.cenaTextBox);
            this.Controls.Add(idTypuLabel);
            this.Controls.Add(this.idTypuTextBox);
            this.Controls.Add(idSaliLabel);
            this.Controls.Add(this.idSaliTextBox);
            this.Controls.Add(liczbaLabel);
            this.Controls.Add(this.liczbaTextBox);
            this.Controls.Add(this.atrakcjaBindingNavigator);
            this.Name = "Atrakcje";
            this.Text = "Atrakcje";
            this.Load += new System.EventHandler(this.Atrakcje_Load);
            ((System.ComponentModel.ISupportInitialize)(this.iSBDDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.atrakcjaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.atrakcjaBindingNavigator)).EndInit();
            this.atrakcjaBindingNavigator.ResumeLayout(false);
            this.atrakcjaBindingNavigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ISBDDataSet iSBDDataSet;
        private System.Windows.Forms.BindingSource atrakcjaBindingSource;
        private ISBDDataSetTableAdapters.AtrakcjaTableAdapter atrakcjaTableAdapter;
        private ISBDDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator atrakcjaBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton atrakcjaBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox idAtrTextBox;
        private System.Windows.Forms.TextBox nazwaTextBox;
        private System.Windows.Forms.TextBox cenaTextBox;
        private System.Windows.Forms.TextBox idTypuTextBox;
        private System.Windows.Forms.TextBox idSaliTextBox;
        private System.Windows.Forms.TextBox liczbaTextBox;
        private System.Windows.Forms.Button button1;
    }
}