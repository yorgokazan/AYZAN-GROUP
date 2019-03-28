namespace WindowsFormsApp1
{
    partial class Cars
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Cars));
            this.ayzanGroupDataSet = new WindowsFormsApp1.AyzanGroupDataSet();
            this.cARBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cARTableAdapter = new WindowsFormsApp1.AyzanGroupDataSetTableAdapters.CARTableAdapter();
            this.tableAdapterManager = new WindowsFormsApp1.AyzanGroupDataSetTableAdapters.TableAdapterManager();
            this.cARBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.cARBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.mODELBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mODELTableAdapter = new WindowsFormsApp1.AyzanGroupDataSetTableAdapters.MODELTableAdapter();
            this.cARDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.mODELDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.r_PRICEBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.r_PRICETableAdapter = new WindowsFormsApp1.AyzanGroupDataSetTableAdapters.R_PRICETableAdapter();
            this.r_PRICEDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn13 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn14 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.ayzanGroupDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cARBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cARBindingNavigator)).BeginInit();
            this.cARBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mODELBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cARDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mODELDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.r_PRICEBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.r_PRICEDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // ayzanGroupDataSet
            // 
            this.ayzanGroupDataSet.DataSetName = "AyzanGroupDataSet";
            this.ayzanGroupDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cARBindingSource
            // 
            this.cARBindingSource.DataMember = "CAR";
            this.cARBindingSource.DataSource = this.ayzanGroupDataSet;
            // 
            // cARTableAdapter
            // 
            this.cARTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CARTableAdapter = this.cARTableAdapter;
            this.tableAdapterManager.CLIENTTableAdapter = null;
            this.tableAdapterManager.EMPLOYEETableAdapter = null;
            this.tableAdapterManager.MAINTENANCETableAdapter = null;
            this.tableAdapterManager.MODELTableAdapter = this.mODELTableAdapter;
            this.tableAdapterManager.PROFESSIONTableAdapter = null;
            this.tableAdapterManager.R_PRICETableAdapter = this.r_PRICETableAdapter;
            this.tableAdapterManager.RENTALTableAdapter = null;
            this.tableAdapterManager.SERVICE_DETAILTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = WindowsFormsApp1.AyzanGroupDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // cARBindingNavigator
            // 
            this.cARBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.cARBindingNavigator.BindingSource = this.cARBindingSource;
            this.cARBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.cARBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.cARBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.cARBindingNavigatorSaveItem});
            this.cARBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.cARBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.cARBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.cARBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.cARBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.cARBindingNavigator.Name = "cARBindingNavigator";
            this.cARBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.cARBindingNavigator.Size = new System.Drawing.Size(1030, 25);
            this.cARBindingNavigator.TabIndex = 0;
            this.cARBindingNavigator.Text = "bindingNavigator1";
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
            // cARBindingNavigatorSaveItem
            // 
            this.cARBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.cARBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("cARBindingNavigatorSaveItem.Image")));
            this.cARBindingNavigatorSaveItem.Name = "cARBindingNavigatorSaveItem";
            this.cARBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.cARBindingNavigatorSaveItem.Text = "Save Data";
            this.cARBindingNavigatorSaveItem.Click += new System.EventHandler(this.cARBindingNavigatorSaveItem_Click);
            // 
            // mODELBindingSource
            // 
            this.mODELBindingSource.DataMember = "MODEL";
            this.mODELBindingSource.DataSource = this.ayzanGroupDataSet;
            // 
            // mODELTableAdapter
            // 
            this.mODELTableAdapter.ClearBeforeFill = true;
            // 
            // cARDataGridView
            // 
            this.cARDataGridView.AutoGenerateColumns = false;
            this.cARDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.cARDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5});
            this.cARDataGridView.DataSource = this.cARBindingSource;
            this.cARDataGridView.Location = new System.Drawing.Point(0, 28);
            this.cARDataGridView.Name = "cARDataGridView";
            this.cARDataGridView.Size = new System.Drawing.Size(541, 137);
            this.cARDataGridView.TabIndex = 5;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "CHASSIS_ID";
            this.dataGridViewTextBoxColumn1.HeaderText = "CHASSIS_ID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "COULEUR";
            this.dataGridViewTextBoxColumn2.HeaderText = "COULEUR";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "NO_MOTEUR";
            this.dataGridViewTextBoxColumn3.HeaderText = "NO_MOTEUR";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "MODEL_ID";
            this.dataGridViewTextBoxColumn4.HeaderText = "MODEL_ID";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "PRICE_ID";
            this.dataGridViewTextBoxColumn5.HeaderText = "PRICE_ID";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(560, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Cars";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(546, 65);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 8;
            this.button1.Text = "Back";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // mODELDataGridView
            // 
            this.mODELDataGridView.AutoGenerateColumns = false;
            this.mODELDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.mODELDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewTextBoxColumn10});
            this.mODELDataGridView.DataSource = this.mODELBindingSource;
            this.mODELDataGridView.Location = new System.Drawing.Point(0, 233);
            this.mODELDataGridView.Name = "mODELDataGridView";
            this.mODELDataGridView.Size = new System.Drawing.Size(541, 157);
            this.mODELDataGridView.TabIndex = 8;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "MODEL_ID";
            this.dataGridViewTextBoxColumn6.HeaderText = "MODEL_ID";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "M_DESCRIPTION";
            this.dataGridViewTextBoxColumn7.HeaderText = "M_DESCRIPTION";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "PUISSANCE_MOTEUR";
            this.dataGridViewTextBoxColumn8.HeaderText = "PUISSANCE_MOTEUR";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "CYL_NO";
            this.dataGridViewTextBoxColumn9.HeaderText = "CYL_NO";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.DataPropertyName = "DOOR_NO";
            this.dataGridViewTextBoxColumn10.HeaderText = "DOOR_NO";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(158, 198);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(162, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Copy Model_ID from table above";
            // 
            // r_PRICEBindingSource
            // 
            this.r_PRICEBindingSource.DataMember = "R_PRICE";
            this.r_PRICEBindingSource.DataSource = this.ayzanGroupDataSet;
            // 
            // r_PRICETableAdapter
            // 
            this.r_PRICETableAdapter.ClearBeforeFill = true;
            // 
            // r_PRICEDataGridView
            // 
            this.r_PRICEDataGridView.AutoGenerateColumns = false;
            this.r_PRICEDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.r_PRICEDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn11,
            this.dataGridViewTextBoxColumn12,
            this.dataGridViewTextBoxColumn13,
            this.dataGridViewTextBoxColumn14});
            this.r_PRICEDataGridView.DataSource = this.r_PRICEBindingSource;
            this.r_PRICEDataGridView.Location = new System.Drawing.Point(563, 107);
            this.r_PRICEDataGridView.Name = "r_PRICEDataGridView";
            this.r_PRICEDataGridView.Size = new System.Drawing.Size(442, 220);
            this.r_PRICEDataGridView.TabIndex = 10;
            // 
            // dataGridViewTextBoxColumn11
            // 
            this.dataGridViewTextBoxColumn11.DataPropertyName = "PRICE_ID";
            this.dataGridViewTextBoxColumn11.HeaderText = "PRICE_ID";
            this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            // 
            // dataGridViewTextBoxColumn12
            // 
            this.dataGridViewTextBoxColumn12.DataPropertyName = "PER_DAY";
            this.dataGridViewTextBoxColumn12.HeaderText = "PER_DAY";
            this.dataGridViewTextBoxColumn12.Name = "dataGridViewTextBoxColumn12";
            // 
            // dataGridViewTextBoxColumn13
            // 
            this.dataGridViewTextBoxColumn13.DataPropertyName = "PER_MONTH";
            this.dataGridViewTextBoxColumn13.HeaderText = "PER_MONTH";
            this.dataGridViewTextBoxColumn13.Name = "dataGridViewTextBoxColumn13";
            // 
            // dataGridViewTextBoxColumn14
            // 
            this.dataGridViewTextBoxColumn14.DataPropertyName = "PER_YEAR";
            this.dataGridViewTextBoxColumn14.HeaderText = "PER_YEAR";
            this.dataGridViewTextBoxColumn14.Name = "dataGridViewTextBoxColumn14";
            // 
            // Cars
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1030, 553);
            this.Controls.Add(this.r_PRICEDataGridView);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.mODELDataGridView);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cARDataGridView);
            this.Controls.Add(this.cARBindingNavigator);
            this.Name = "Cars";
            this.Text = "Cars";
            this.Load += new System.EventHandler(this.Cars_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ayzanGroupDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cARBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cARBindingNavigator)).EndInit();
            this.cARBindingNavigator.ResumeLayout(false);
            this.cARBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mODELBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cARDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mODELDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.r_PRICEBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.r_PRICEDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private AyzanGroupDataSet ayzanGroupDataSet;
        private System.Windows.Forms.BindingSource cARBindingSource;
        private AyzanGroupDataSetTableAdapters.CARTableAdapter cARTableAdapter;
        private AyzanGroupDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator cARBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton cARBindingNavigatorSaveItem;
        private AyzanGroupDataSetTableAdapters.MODELTableAdapter mODELTableAdapter;
        private System.Windows.Forms.BindingSource mODELBindingSource;
        private System.Windows.Forms.DataGridView cARDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView mODELDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.Label label2;
        private AyzanGroupDataSetTableAdapters.R_PRICETableAdapter r_PRICETableAdapter;
        private System.Windows.Forms.BindingSource r_PRICEBindingSource;
        private System.Windows.Forms.DataGridView r_PRICEDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn12;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn13;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn14;
    }
}