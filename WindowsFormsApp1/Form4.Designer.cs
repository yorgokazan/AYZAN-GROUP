namespace WindowsFormsApp1
{
    partial class maintenance
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(maintenance));
            this.ayzanGroupDataSet = new WindowsFormsApp1.AyzanGroupDataSet();
            this.mAINTENANCEBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mAINTENANCETableAdapter = new WindowsFormsApp1.AyzanGroupDataSetTableAdapters.MAINTENANCETableAdapter();
            this.tableAdapterManager = new WindowsFormsApp1.AyzanGroupDataSetTableAdapters.TableAdapterManager();
            this.mAINTENANCEBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.mAINTENANCEBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.mAINTENANCEDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sERVICE_DETAILBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sERVICE_DETAILTableAdapter = new WindowsFormsApp1.AyzanGroupDataSetTableAdapters.SERVICE_DETAILTableAdapter();
            this.sERVICE_DETAILDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Back = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ayzanGroupDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mAINTENANCEBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mAINTENANCEBindingNavigator)).BeginInit();
            this.mAINTENANCEBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mAINTENANCEDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sERVICE_DETAILBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sERVICE_DETAILDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // ayzanGroupDataSet
            // 
            this.ayzanGroupDataSet.DataSetName = "AyzanGroupDataSet";
            this.ayzanGroupDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // mAINTENANCEBindingSource
            // 
            this.mAINTENANCEBindingSource.DataMember = "MAINTENANCE";
            this.mAINTENANCEBindingSource.DataSource = this.ayzanGroupDataSet;
            // 
            // mAINTENANCETableAdapter
            // 
            this.mAINTENANCETableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CARTableAdapter = null;
            this.tableAdapterManager.CLIENTTableAdapter = null;
            this.tableAdapterManager.EMPLOYEETableAdapter = null;
            this.tableAdapterManager.MAINTENANCETableAdapter = this.mAINTENANCETableAdapter;
            this.tableAdapterManager.MODELTableAdapter = null;
            this.tableAdapterManager.PROFESSIONTableAdapter = null;
            this.tableAdapterManager.R_PRICETableAdapter = null;
            this.tableAdapterManager.RENTALTableAdapter = null;
            this.tableAdapterManager.SERVICE_DETAILTableAdapter = this.sERVICE_DETAILTableAdapter;
            this.tableAdapterManager.UpdateOrder = WindowsFormsApp1.AyzanGroupDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // mAINTENANCEBindingNavigator
            // 
            this.mAINTENANCEBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.mAINTENANCEBindingNavigator.BindingSource = this.mAINTENANCEBindingSource;
            this.mAINTENANCEBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.mAINTENANCEBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.mAINTENANCEBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.mAINTENANCEBindingNavigatorSaveItem});
            this.mAINTENANCEBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.mAINTENANCEBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.mAINTENANCEBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.mAINTENANCEBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.mAINTENANCEBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.mAINTENANCEBindingNavigator.Name = "mAINTENANCEBindingNavigator";
            this.mAINTENANCEBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.mAINTENANCEBindingNavigator.Size = new System.Drawing.Size(800, 25);
            this.mAINTENANCEBindingNavigator.TabIndex = 0;
            this.mAINTENANCEBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
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
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 22);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // mAINTENANCEBindingNavigatorSaveItem
            // 
            this.mAINTENANCEBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.mAINTENANCEBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("mAINTENANCEBindingNavigatorSaveItem.Image")));
            this.mAINTENANCEBindingNavigatorSaveItem.Name = "mAINTENANCEBindingNavigatorSaveItem";
            this.mAINTENANCEBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.mAINTENANCEBindingNavigatorSaveItem.Text = "Save Data";
            this.mAINTENANCEBindingNavigatorSaveItem.Click += new System.EventHandler(this.mAINTENANCEBindingNavigatorSaveItem_Click);
            // 
            // mAINTENANCEDataGridView
            // 
            this.mAINTENANCEDataGridView.AutoGenerateColumns = false;
            this.mAINTENANCEDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.mAINTENANCEDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7});
            this.mAINTENANCEDataGridView.DataSource = this.mAINTENANCEBindingSource;
            this.mAINTENANCEDataGridView.Location = new System.Drawing.Point(0, 28);
            this.mAINTENANCEDataGridView.Name = "mAINTENANCEDataGridView";
            this.mAINTENANCEDataGridView.Size = new System.Drawing.Size(733, 164);
            this.mAINTENANCEDataGridView.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "M_ID";
            this.dataGridViewTextBoxColumn1.HeaderText = "M_ID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "SERVICE_ID";
            this.dataGridViewTextBoxColumn2.HeaderText = "SERVICE_ID";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "EMPLOYEE_ID";
            this.dataGridViewTextBoxColumn3.HeaderText = "EMPLOYEE_ID";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "CHASSIS_ID";
            this.dataGridViewTextBoxColumn4.HeaderText = "CHASSIS_ID";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "M_DESCRIPTION";
            this.dataGridViewTextBoxColumn5.HeaderText = "M_DESCRIPTION";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "M_DATE";
            this.dataGridViewTextBoxColumn6.HeaderText = "M_DATE";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "TOTAL";
            this.dataGridViewTextBoxColumn7.HeaderText = "TOTAL";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            // 
            // sERVICE_DETAILBindingSource
            // 
            this.sERVICE_DETAILBindingSource.DataMember = "SERVICE_DETAIL";
            this.sERVICE_DETAILBindingSource.DataSource = this.ayzanGroupDataSet;
            // 
            // sERVICE_DETAILTableAdapter
            // 
            this.sERVICE_DETAILTableAdapter.ClearBeforeFill = true;
            // 
            // sERVICE_DETAILDataGridView
            // 
            this.sERVICE_DETAILDataGridView.AutoGenerateColumns = false;
            this.sERVICE_DETAILDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.sERVICE_DETAILDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewTextBoxColumn10,
            this.dataGridViewTextBoxColumn11});
            this.sERVICE_DETAILDataGridView.DataSource = this.sERVICE_DETAILBindingSource;
            this.sERVICE_DETAILDataGridView.Location = new System.Drawing.Point(0, 215);
            this.sERVICE_DETAILDataGridView.Name = "sERVICE_DETAILDataGridView";
            this.sERVICE_DETAILDataGridView.Size = new System.Drawing.Size(443, 159);
            this.sERVICE_DETAILDataGridView.TabIndex = 2;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "SERVICE_ID";
            this.dataGridViewTextBoxColumn8.HeaderText = "SERVICE_ID";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "S_NAME";
            this.dataGridViewTextBoxColumn9.HeaderText = "S_NAME";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.DataPropertyName = "S_DESCRIPTION";
            this.dataGridViewTextBoxColumn10.HeaderText = "S_DESCRIPTION";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            // 
            // dataGridViewTextBoxColumn11
            // 
            this.dataGridViewTextBoxColumn11.DataPropertyName = "S_PRICE";
            this.dataGridViewTextBoxColumn11.HeaderText = "S_PRICE";
            this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            // 
            // Back
            // 
            this.Back.Location = new System.Drawing.Point(625, 260);
            this.Back.Name = "Back";
            this.Back.Size = new System.Drawing.Size(75, 23);
            this.Back.TabIndex = 3;
            this.Back.Text = "Back";
            this.Back.UseVisualStyleBackColor = true;
            // 
            // maintenance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 534);
            this.Controls.Add(this.Back);
            this.Controls.Add(this.sERVICE_DETAILDataGridView);
            this.Controls.Add(this.mAINTENANCEDataGridView);
            this.Controls.Add(this.mAINTENANCEBindingNavigator);
            this.Name = "maintenance";
            this.Text = "Maintenance";
            this.Load += new System.EventHandler(this.Form4_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ayzanGroupDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mAINTENANCEBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mAINTENANCEBindingNavigator)).EndInit();
            this.mAINTENANCEBindingNavigator.ResumeLayout(false);
            this.mAINTENANCEBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mAINTENANCEDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sERVICE_DETAILBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sERVICE_DETAILDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private AyzanGroupDataSet ayzanGroupDataSet;
        private System.Windows.Forms.BindingSource mAINTENANCEBindingSource;
        private AyzanGroupDataSetTableAdapters.MAINTENANCETableAdapter mAINTENANCETableAdapter;
        private AyzanGroupDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator mAINTENANCEBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton mAINTENANCEBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView mAINTENANCEDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private AyzanGroupDataSetTableAdapters.SERVICE_DETAILTableAdapter sERVICE_DETAILTableAdapter;
        private System.Windows.Forms.BindingSource sERVICE_DETAILBindingSource;
        private System.Windows.Forms.DataGridView sERVICE_DETAILDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private System.Windows.Forms.Button Back;
    }
}