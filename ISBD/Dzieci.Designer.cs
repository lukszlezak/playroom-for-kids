namespace ISBD
{
    partial class Dzieci
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dzieci));
            System.Windows.Forms.Label idDLabel;
            System.Windows.Forms.Label nazwiskoLabel;
            System.Windows.Forms.Label imieLabel;
            System.Windows.Forms.Label idKLabel;
            System.Windows.Forms.Label uwagiLabel;
            this.iSBDDataSet = new ISBD.ISBDDataSet();
            this.dzieckoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dzieckoTableAdapter = new ISBD.ISBDDataSetTableAdapters.DzieckoTableAdapter();
            this.tableAdapterManager = new ISBD.ISBDDataSetTableAdapters.TableAdapterManager();
            this.dzieckoBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.dzieckoBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.idDTextBox = new System.Windows.Forms.TextBox();
            this.nazwiskoTextBox = new System.Windows.Forms.TextBox();
            this.imieTextBox = new System.Windows.Forms.TextBox();
            this.idKTextBox = new System.Windows.Forms.TextBox();
            this.uwagiTextBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            idDLabel = new System.Windows.Forms.Label();
            nazwiskoLabel = new System.Windows.Forms.Label();
            imieLabel = new System.Windows.Forms.Label();
            idKLabel = new System.Windows.Forms.Label();
            uwagiLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.iSBDDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dzieckoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dzieckoBindingNavigator)).BeginInit();
            this.dzieckoBindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // iSBDDataSet
            // 
            this.iSBDDataSet.DataSetName = "ISBDDataSet";
            this.iSBDDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dzieckoBindingSource
            // 
            this.dzieckoBindingSource.DataMember = "Dziecko";
            this.dzieckoBindingSource.DataSource = this.iSBDDataSet;
            // 
            // dzieckoTableAdapter
            // 
            this.dzieckoTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.AtrakcjaTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.DzieckoTableAdapter = this.dzieckoTableAdapter;
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
            // dzieckoBindingNavigator
            // 
            this.dzieckoBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.dzieckoBindingNavigator.BindingSource = this.dzieckoBindingSource;
            this.dzieckoBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.dzieckoBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.dzieckoBindingNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.dzieckoBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.dzieckoBindingNavigatorSaveItem});
            this.dzieckoBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.dzieckoBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.dzieckoBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.dzieckoBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.dzieckoBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.dzieckoBindingNavigator.Name = "dzieckoBindingNavigator";
            this.dzieckoBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.dzieckoBindingNavigator.Size = new System.Drawing.Size(282, 27);
            this.dzieckoBindingNavigator.TabIndex = 0;
            this.dzieckoBindingNavigator.Text = "bindingNavigator1";
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
            // dzieckoBindingNavigatorSaveItem
            // 
            this.dzieckoBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.dzieckoBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("dzieckoBindingNavigatorSaveItem.Image")));
            this.dzieckoBindingNavigatorSaveItem.Name = "dzieckoBindingNavigatorSaveItem";
            this.dzieckoBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 23);
            this.dzieckoBindingNavigatorSaveItem.Text = "Save Data";
            this.dzieckoBindingNavigatorSaveItem.Click += new System.EventHandler(this.dzieckoBindingNavigatorSaveItem_Click);
            // 
            // idDLabel
            // 
            idDLabel.AutoSize = true;
            idDLabel.Location = new System.Drawing.Point(33, 64);
            idDLabel.Name = "idDLabel";
            idDLabel.Size = new System.Drawing.Size(37, 17);
            idDLabel.TabIndex = 1;
            idDLabel.Text = "Id D:";
            // 
            // idDTextBox
            // 
            this.idDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dzieckoBindingSource, "IdD", true));
            this.idDTextBox.Location = new System.Drawing.Point(110, 61);
            this.idDTextBox.Name = "idDTextBox";
            this.idDTextBox.Size = new System.Drawing.Size(100, 22);
            this.idDTextBox.TabIndex = 2;
            // 
            // nazwiskoLabel
            // 
            nazwiskoLabel.AutoSize = true;
            nazwiskoLabel.Location = new System.Drawing.Point(33, 92);
            nazwiskoLabel.Name = "nazwiskoLabel";
            nazwiskoLabel.Size = new System.Drawing.Size(71, 17);
            nazwiskoLabel.TabIndex = 3;
            nazwiskoLabel.Text = "Nazwisko:";
            // 
            // nazwiskoTextBox
            // 
            this.nazwiskoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dzieckoBindingSource, "Nazwisko", true));
            this.nazwiskoTextBox.Location = new System.Drawing.Point(110, 89);
            this.nazwiskoTextBox.Name = "nazwiskoTextBox";
            this.nazwiskoTextBox.Size = new System.Drawing.Size(100, 22);
            this.nazwiskoTextBox.TabIndex = 4;
            // 
            // imieLabel
            // 
            imieLabel.AutoSize = true;
            imieLabel.Location = new System.Drawing.Point(33, 120);
            imieLabel.Name = "imieLabel";
            imieLabel.Size = new System.Drawing.Size(37, 17);
            imieLabel.TabIndex = 5;
            imieLabel.Text = "Imie:";
            // 
            // imieTextBox
            // 
            this.imieTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dzieckoBindingSource, "Imie", true));
            this.imieTextBox.Location = new System.Drawing.Point(110, 117);
            this.imieTextBox.Name = "imieTextBox";
            this.imieTextBox.Size = new System.Drawing.Size(100, 22);
            this.imieTextBox.TabIndex = 6;
            // 
            // idKLabel
            // 
            idKLabel.AutoSize = true;
            idKLabel.Location = new System.Drawing.Point(33, 148);
            idKLabel.Name = "idKLabel";
            idKLabel.Size = new System.Drawing.Size(36, 17);
            idKLabel.TabIndex = 7;
            idKLabel.Text = "Id K:";
            // 
            // idKTextBox
            // 
            this.idKTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dzieckoBindingSource, "IdK", true));
            this.idKTextBox.Location = new System.Drawing.Point(110, 145);
            this.idKTextBox.Name = "idKTextBox";
            this.idKTextBox.Size = new System.Drawing.Size(100, 22);
            this.idKTextBox.TabIndex = 8;
            // 
            // uwagiLabel
            // 
            uwagiLabel.AutoSize = true;
            uwagiLabel.Location = new System.Drawing.Point(33, 176);
            uwagiLabel.Name = "uwagiLabel";
            uwagiLabel.Size = new System.Drawing.Size(50, 17);
            uwagiLabel.TabIndex = 9;
            uwagiLabel.Text = "Uwagi:";
            // 
            // uwagiTextBox
            // 
            this.uwagiTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dzieckoBindingSource, "Uwagi", true));
            this.uwagiTextBox.Location = new System.Drawing.Point(110, 173);
            this.uwagiTextBox.Name = "uwagiTextBox";
            this.uwagiTextBox.Size = new System.Drawing.Size(100, 22);
            this.uwagiTextBox.TabIndex = 10;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(110, 218);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 11;
            this.button1.Text = "Powrót";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Dzieci
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(282, 253);
            this.Controls.Add(this.button1);
            this.Controls.Add(idDLabel);
            this.Controls.Add(this.idDTextBox);
            this.Controls.Add(nazwiskoLabel);
            this.Controls.Add(this.nazwiskoTextBox);
            this.Controls.Add(imieLabel);
            this.Controls.Add(this.imieTextBox);
            this.Controls.Add(idKLabel);
            this.Controls.Add(this.idKTextBox);
            this.Controls.Add(uwagiLabel);
            this.Controls.Add(this.uwagiTextBox);
            this.Controls.Add(this.dzieckoBindingNavigator);
            this.Name = "Dzieci";
            this.Text = "Dzieci";
            this.Load += new System.EventHandler(this.Dzieci_Load);
            ((System.ComponentModel.ISupportInitialize)(this.iSBDDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dzieckoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dzieckoBindingNavigator)).EndInit();
            this.dzieckoBindingNavigator.ResumeLayout(false);
            this.dzieckoBindingNavigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ISBDDataSet iSBDDataSet;
        private System.Windows.Forms.BindingSource dzieckoBindingSource;
        private ISBDDataSetTableAdapters.DzieckoTableAdapter dzieckoTableAdapter;
        private ISBDDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator dzieckoBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton dzieckoBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox idDTextBox;
        private System.Windows.Forms.TextBox nazwiskoTextBox;
        private System.Windows.Forms.TextBox imieTextBox;
        private System.Windows.Forms.TextBox idKTextBox;
        private System.Windows.Forms.TextBox uwagiTextBox;
        private System.Windows.Forms.Button button1;
    }
}