namespace LBT2
{
    partial class text3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(text3));
            System.Windows.Forms.Label stockIDLabel;
            System.Windows.Forms.Label authorIDLabel;
            System.Windows.Forms.Label iSBN_13Label;
            System.Windows.Forms.Label quantityInStockLabel;
            System.Windows.Forms.Label dateRecordedLabel;
            this.dataset1 = new LBT2.Dataset1();
            this.lastBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lastTableAdapter = new LBT2.Dataset1TableAdapters.LastTableAdapter();
            this.tableAdapterManager = new LBT2.Dataset1TableAdapters.TableAdapterManager();
            this.lastBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.lastBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.lastDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stockIDTextBox = new System.Windows.Forms.TextBox();
            this.authorIDTextBox = new System.Windows.Forms.TextBox();
            this.iSBN_13TextBox = new System.Windows.Forms.TextBox();
            this.quantityInStockTextBox = new System.Windows.Forms.TextBox();
            this.dateRecordedDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            stockIDLabel = new System.Windows.Forms.Label();
            authorIDLabel = new System.Windows.Forms.Label();
            iSBN_13Label = new System.Windows.Forms.Label();
            quantityInStockLabel = new System.Windows.Forms.Label();
            dateRecordedLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataset1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lastBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lastBindingNavigator)).BeginInit();
            this.lastBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lastDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // dataset1
            // 
            this.dataset1.DataSetName = "Dataset1";
            this.dataset1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // lastBindingSource
            // 
            this.lastBindingSource.DataMember = "Last";
            this.lastBindingSource.DataSource = this.dataset1;
            // 
            // lastTableAdapter
            // 
            this.lastTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.AuthorTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.BookTableAdapter = null;
            this.tableAdapterManager.LastTableAdapter = this.lastTableAdapter;
            this.tableAdapterManager.TableTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = LBT2.Dataset1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // lastBindingNavigator
            // 
            this.lastBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.lastBindingNavigator.BindingSource = this.lastBindingSource;
            this.lastBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.lastBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.lastBindingNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.lastBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.lastBindingNavigatorSaveItem});
            this.lastBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.lastBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.lastBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.lastBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.lastBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.lastBindingNavigator.Name = "lastBindingNavigator";
            this.lastBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.lastBindingNavigator.Size = new System.Drawing.Size(808, 27);
            this.lastBindingNavigator.TabIndex = 0;
            this.lastBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(29, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(29, 22);
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
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(29, 24);
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
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // lastBindingNavigatorSaveItem
            // 
            this.lastBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.lastBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("lastBindingNavigatorSaveItem.Image")));
            this.lastBindingNavigatorSaveItem.Name = "lastBindingNavigatorSaveItem";
            this.lastBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 23);
            this.lastBindingNavigatorSaveItem.Text = "Save Data";
            this.lastBindingNavigatorSaveItem.Click += new System.EventHandler(this.lastBindingNavigatorSaveItem_Click);
            // 
            // lastDataGridView
            // 
            this.lastDataGridView.AutoGenerateColumns = false;
            this.lastDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.lastDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5});
            this.lastDataGridView.DataSource = this.lastBindingSource;
            this.lastDataGridView.Location = new System.Drawing.Point(82, 30);
            this.lastDataGridView.Name = "lastDataGridView";
            this.lastDataGridView.RowHeadersWidth = 51;
            this.lastDataGridView.RowTemplate.Height = 24;
            this.lastDataGridView.Size = new System.Drawing.Size(714, 117);
            this.lastDataGridView.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "stockID";
            this.dataGridViewTextBoxColumn1.HeaderText = "stockID";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 125;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "AuthorID";
            this.dataGridViewTextBoxColumn2.HeaderText = "AuthorID";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 125;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "ISBN-13";
            this.dataGridViewTextBoxColumn3.HeaderText = "ISBN-13";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 125;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "QuantityInStock";
            this.dataGridViewTextBoxColumn4.HeaderText = "QuantityInStock";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Width = 125;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "DateRecorded";
            this.dataGridViewTextBoxColumn5.HeaderText = "DateRecorded";
            this.dataGridViewTextBoxColumn5.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.Width = 125;
            // 
            // stockIDLabel
            // 
            stockIDLabel.AutoSize = true;
            stockIDLabel.Location = new System.Drawing.Point(128, 156);
            stockIDLabel.Name = "stockIDLabel";
            stockIDLabel.Size = new System.Drawing.Size(58, 16);
            stockIDLabel.TabIndex = 2;
            stockIDLabel.Text = "stock ID:";
            // 
            // stockIDTextBox
            // 
            this.stockIDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.lastBindingSource, "stockID", true));
            this.stockIDTextBox.Location = new System.Drawing.Point(242, 153);
            this.stockIDTextBox.Name = "stockIDTextBox";
            this.stockIDTextBox.Size = new System.Drawing.Size(412, 22);
            this.stockIDTextBox.TabIndex = 3;
            // 
            // authorIDLabel
            // 
            authorIDLabel.AutoSize = true;
            authorIDLabel.Location = new System.Drawing.Point(128, 184);
            authorIDLabel.Name = "authorIDLabel";
            authorIDLabel.Size = new System.Drawing.Size(64, 16);
            authorIDLabel.TabIndex = 4;
            authorIDLabel.Text = "Author ID:";
            // 
            // authorIDTextBox
            // 
            this.authorIDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.lastBindingSource, "AuthorID", true));
            this.authorIDTextBox.Location = new System.Drawing.Point(242, 181);
            this.authorIDTextBox.Name = "authorIDTextBox";
            this.authorIDTextBox.Size = new System.Drawing.Size(412, 22);
            this.authorIDTextBox.TabIndex = 5;
            // 
            // iSBN_13Label
            // 
            iSBN_13Label.AutoSize = true;
            iSBN_13Label.Location = new System.Drawing.Point(128, 212);
            iSBN_13Label.Name = "iSBN_13Label";
            iSBN_13Label.Size = new System.Drawing.Size(59, 16);
            iSBN_13Label.TabIndex = 6;
            iSBN_13Label.Text = "ISBN-13:";
            // 
            // iSBN_13TextBox
            // 
            this.iSBN_13TextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.lastBindingSource, "ISBN-13", true));
            this.iSBN_13TextBox.Location = new System.Drawing.Point(242, 209);
            this.iSBN_13TextBox.Name = "iSBN_13TextBox";
            this.iSBN_13TextBox.Size = new System.Drawing.Size(412, 22);
            this.iSBN_13TextBox.TabIndex = 7;
            // 
            // quantityInStockLabel
            // 
            quantityInStockLabel.AutoSize = true;
            quantityInStockLabel.Location = new System.Drawing.Point(128, 240);
            quantityInStockLabel.Name = "quantityInStockLabel";
            quantityInStockLabel.Size = new System.Drawing.Size(108, 16);
            quantityInStockLabel.TabIndex = 8;
            quantityInStockLabel.Text = "Quantity In Stock:";
            // 
            // quantityInStockTextBox
            // 
            this.quantityInStockTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.lastBindingSource, "QuantityInStock", true));
            this.quantityInStockTextBox.Location = new System.Drawing.Point(242, 237);
            this.quantityInStockTextBox.Name = "quantityInStockTextBox";
            this.quantityInStockTextBox.Size = new System.Drawing.Size(412, 22);
            this.quantityInStockTextBox.TabIndex = 9;
            // 
            // dateRecordedLabel
            // 
            dateRecordedLabel.AutoSize = true;
            dateRecordedLabel.Location = new System.Drawing.Point(128, 269);
            dateRecordedLabel.Name = "dateRecordedLabel";
            dateRecordedLabel.Size = new System.Drawing.Size(103, 16);
            dateRecordedLabel.TabIndex = 10;
            dateRecordedLabel.Text = "Date Recorded:";
            // 
            // dateRecordedDateTimePicker
            // 
            this.dateRecordedDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.lastBindingSource, "DateRecorded", true));
            this.dateRecordedDateTimePicker.Location = new System.Drawing.Point(242, 265);
            this.dateRecordedDateTimePicker.Name = "dateRecordedDateTimePicker";
            this.dateRecordedDateTimePicker.Size = new System.Drawing.Size(412, 22);
            this.dateRecordedDateTimePicker.TabIndex = 11;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(676, 256);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(120, 46);
            this.button1.TabIndex = 12;
            this.button1.Text = "FORM AUTHOR";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(676, 308);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(120, 46);
            this.button2.TabIndex = 13;
            this.button2.Text = "FORM BOOK";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(143, 308);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(120, 46);
            this.button3.TabIndex = 14;
            this.button3.Text = "ADD";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(328, 308);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(120, 46);
            this.button4.TabIndex = 15;
            this.button4.Text = "UPDATE";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(490, 308);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(120, 46);
            this.button5.TabIndex = 16;
            this.button5.Text = "DELETE";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // text3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(808, 450);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(stockIDLabel);
            this.Controls.Add(this.stockIDTextBox);
            this.Controls.Add(authorIDLabel);
            this.Controls.Add(this.authorIDTextBox);
            this.Controls.Add(iSBN_13Label);
            this.Controls.Add(this.iSBN_13TextBox);
            this.Controls.Add(quantityInStockLabel);
            this.Controls.Add(this.quantityInStockTextBox);
            this.Controls.Add(dateRecordedLabel);
            this.Controls.Add(this.dateRecordedDateTimePicker);
            this.Controls.Add(this.lastDataGridView);
            this.Controls.Add(this.lastBindingNavigator);
            this.Name = "text3";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.Form3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataset1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lastBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lastBindingNavigator)).EndInit();
            this.lastBindingNavigator.ResumeLayout(false);
            this.lastBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lastDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Dataset1 dataset1;
        private System.Windows.Forms.BindingSource lastBindingSource;
        private Dataset1TableAdapters.LastTableAdapter lastTableAdapter;
        private Dataset1TableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator lastBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton lastBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView lastDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.TextBox stockIDTextBox;
        private System.Windows.Forms.TextBox authorIDTextBox;
        private System.Windows.Forms.TextBox iSBN_13TextBox;
        private System.Windows.Forms.TextBox quantityInStockTextBox;
        private System.Windows.Forms.DateTimePicker dateRecordedDateTimePicker;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
    }
}