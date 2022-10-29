
namespace Stock_v2
{
    partial class CfmStockList
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
            this.grpSort = new System.Windows.Forms.GroupBox();
            this.radItemPrice = new System.Windows.Forms.RadioButton();
            this.radItemName = new System.Windows.Forms.RadioButton();
            this.radItemCode = new System.Windows.Forms.RadioButton();
            this.btnRemoveItem = new System.Windows.Forms.Button();
            this.btnSale = new System.Windows.Forms.Button();
            this.btnReceiveStock = new System.Windows.Forms.Button();
            this.btnMarkUp = new System.Windows.Forms.Button();
            this.btnSetRetailPrice = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnListItems = new System.Windows.Forms.Button();
            this.btnAddItem = new System.Windows.Forms.Button();
            this.txtItemName = new System.Windows.Forms.TextBox();
            this.txtCostPrice = new System.Windows.Forms.TextBox();
            this.txtRetailPrice = new System.Windows.Forms.TextBox();
            this.txtQuantity = new System.Windows.Forms.TextBox();
            this.txtItemCode = new System.Windows.Forms.TextBox();
            this.lblQuantity = new System.Windows.Forms.Label();
            this.lblItemName = new System.Windows.Forms.Label();
            this.lblCostPrice = new System.Windows.Forms.Label();
            this.lblRetailPrice = new System.Windows.Forms.Label();
            this.lblItemCode = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnRead = new System.Windows.Forms.Button();
            this.digSave = new System.Windows.Forms.SaveFileDialog();
            this.digOpen = new System.Windows.Forms.OpenFileDialog();
            this.grpSort.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpSort
            // 
            this.grpSort.Controls.Add(this.radItemPrice);
            this.grpSort.Controls.Add(this.radItemName);
            this.grpSort.Controls.Add(this.radItemCode);
            this.grpSort.Location = new System.Drawing.Point(184, 269);
            this.grpSort.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grpSort.Name = "grpSort";
            this.grpSort.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grpSort.Size = new System.Drawing.Size(130, 154);
            this.grpSort.TabIndex = 37;
            this.grpSort.TabStop = false;
            this.grpSort.Text = "Sort on...";
            // 
            // radItemPrice
            // 
            this.radItemPrice.AutoSize = true;
            this.radItemPrice.Location = new System.Drawing.Point(10, 100);
            this.radItemPrice.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.radItemPrice.Name = "radItemPrice";
            this.radItemPrice.Size = new System.Drawing.Size(104, 24);
            this.radItemPrice.TabIndex = 2;
            this.radItemPrice.TabStop = true;
            this.radItemPrice.Text = "Item price";
            this.radItemPrice.UseVisualStyleBackColor = true;
            // 
            // radItemName
            // 
            this.radItemName.AutoSize = true;
            this.radItemName.Location = new System.Drawing.Point(10, 65);
            this.radItemName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.radItemName.Name = "radItemName";
            this.radItemName.Size = new System.Drawing.Size(110, 24);
            this.radItemName.TabIndex = 1;
            this.radItemName.TabStop = true;
            this.radItemName.Text = "Item name";
            this.radItemName.UseVisualStyleBackColor = true;
            // 
            // radItemCode
            // 
            this.radItemCode.AutoSize = true;
            this.radItemCode.Location = new System.Drawing.Point(9, 29);
            this.radItemCode.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.radItemCode.Name = "radItemCode";
            this.radItemCode.Size = new System.Drawing.Size(105, 24);
            this.radItemCode.TabIndex = 0;
            this.radItemCode.TabStop = true;
            this.radItemCode.Text = "Item code";
            this.radItemCode.UseVisualStyleBackColor = true;
            // 
            // btnRemoveItem
            // 
            this.btnRemoveItem.Location = new System.Drawing.Point(21, 315);
            this.btnRemoveItem.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnRemoveItem.Name = "btnRemoveItem";
            this.btnRemoveItem.Size = new System.Drawing.Size(142, 35);
            this.btnRemoveItem.TabIndex = 36;
            this.btnRemoveItem.Text = "&Remove Item";
            this.btnRemoveItem.UseVisualStyleBackColor = true;
            this.btnRemoveItem.Click += new System.EventHandler(this.btnRemoveItem_Click);
            // 
            // btnSale
            // 
            this.btnSale.Location = new System.Drawing.Point(21, 359);
            this.btnSale.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSale.Name = "btnSale";
            this.btnSale.Size = new System.Drawing.Size(142, 35);
            this.btnSale.TabIndex = 35;
            this.btnSale.Text = "&Sale";
            this.btnSale.UseVisualStyleBackColor = true;
            this.btnSale.Click += new System.EventHandler(this.btnSale_Click);
            // 
            // btnReceiveStock
            // 
            this.btnReceiveStock.Location = new System.Drawing.Point(21, 404);
            this.btnReceiveStock.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnReceiveStock.Name = "btnReceiveStock";
            this.btnReceiveStock.Size = new System.Drawing.Size(142, 35);
            this.btnReceiveStock.TabIndex = 34;
            this.btnReceiveStock.Text = "&Recieve stock";
            this.btnReceiveStock.UseVisualStyleBackColor = true;
            // 
            // btnMarkUp
            // 
            this.btnMarkUp.Location = new System.Drawing.Point(21, 449);
            this.btnMarkUp.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnMarkUp.Name = "btnMarkUp";
            this.btnMarkUp.Size = new System.Drawing.Size(142, 35);
            this.btnMarkUp.TabIndex = 33;
            this.btnMarkUp.Text = "&Mark-up";
            this.btnMarkUp.UseVisualStyleBackColor = true;
            this.btnMarkUp.Click += new System.EventHandler(this.btnMarkUp_Click);
            // 
            // btnSetRetailPrice
            // 
            this.btnSetRetailPrice.Location = new System.Drawing.Point(21, 493);
            this.btnSetRetailPrice.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSetRetailPrice.Name = "btnSetRetailPrice";
            this.btnSetRetailPrice.Size = new System.Drawing.Size(142, 35);
            this.btnSetRetailPrice.TabIndex = 32;
            this.btnSetRetailPrice.Text = "&Set retail prices";
            this.btnSetRetailPrice.UseVisualStyleBackColor = true;
            this.btnSetRetailPrice.Click += new System.EventHandler(this.btnSetRetailPrice_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(177, 493);
            this.btnClose.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(138, 35);
            this.btnClose.TabIndex = 31;
            this.btnClose.Text = "&Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnListItems
            // 
            this.btnListItems.Location = new System.Drawing.Point(177, 449);
            this.btnListItems.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnListItems.Name = "btnListItems";
            this.btnListItems.Size = new System.Drawing.Size(138, 35);
            this.btnListItems.TabIndex = 30;
            this.btnListItems.Text = "&List items";
            this.btnListItems.UseVisualStyleBackColor = true;
            this.btnListItems.Click += new System.EventHandler(this.btnListItems_Click);
            // 
            // btnAddItem
            // 
            this.btnAddItem.Location = new System.Drawing.Point(21, 269);
            this.btnAddItem.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnAddItem.Name = "btnAddItem";
            this.btnAddItem.Size = new System.Drawing.Size(142, 35);
            this.btnAddItem.TabIndex = 29;
            this.btnAddItem.Text = "&Add item";
            this.btnAddItem.UseVisualStyleBackColor = true;
            this.btnAddItem.Click += new System.EventHandler(this.btnAddItem_Click);
            // 
            // txtItemName
            // 
            this.txtItemName.Location = new System.Drawing.Point(177, 69);
            this.txtItemName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtItemName.Name = "txtItemName";
            this.txtItemName.Size = new System.Drawing.Size(148, 26);
            this.txtItemName.TabIndex = 28;
            // 
            // txtCostPrice
            // 
            this.txtCostPrice.Location = new System.Drawing.Point(177, 123);
            this.txtCostPrice.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtCostPrice.Name = "txtCostPrice";
            this.txtCostPrice.Size = new System.Drawing.Size(148, 26);
            this.txtCostPrice.TabIndex = 27;
            // 
            // txtRetailPrice
            // 
            this.txtRetailPrice.Location = new System.Drawing.Point(177, 173);
            this.txtRetailPrice.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtRetailPrice.Name = "txtRetailPrice";
            this.txtRetailPrice.Size = new System.Drawing.Size(148, 26);
            this.txtRetailPrice.TabIndex = 26;
            // 
            // txtQuantity
            // 
            this.txtQuantity.Location = new System.Drawing.Point(177, 213);
            this.txtQuantity.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.Size = new System.Drawing.Size(148, 26);
            this.txtQuantity.TabIndex = 25;
            // 
            // txtItemCode
            // 
            this.txtItemCode.Location = new System.Drawing.Point(177, 21);
            this.txtItemCode.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtItemCode.Name = "txtItemCode";
            this.txtItemCode.Size = new System.Drawing.Size(148, 26);
            this.txtItemCode.TabIndex = 24;
            // 
            // lblQuantity
            // 
            this.lblQuantity.AutoSize = true;
            this.lblQuantity.Location = new System.Drawing.Point(31, 224);
            this.lblQuantity.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblQuantity.Name = "lblQuantity";
            this.lblQuantity.Size = new System.Drawing.Size(130, 20);
            this.lblQuantity.TabIndex = 23;
            this.lblQuantity.Text = "Quantity on hand";
            // 
            // lblItemName
            // 
            this.lblItemName.AutoSize = true;
            this.lblItemName.Location = new System.Drawing.Point(33, 69);
            this.lblItemName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblItemName.Name = "lblItemName";
            this.lblItemName.Size = new System.Drawing.Size(87, 20);
            this.lblItemName.TabIndex = 22;
            this.lblItemName.Text = "Item Name";
            // 
            // lblCostPrice
            // 
            this.lblCostPrice.AutoSize = true;
            this.lblCostPrice.Location = new System.Drawing.Point(33, 123);
            this.lblCostPrice.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCostPrice.Name = "lblCostPrice";
            this.lblCostPrice.Size = new System.Drawing.Size(81, 20);
            this.lblCostPrice.TabIndex = 21;
            this.lblCostPrice.Text = "Cost Price";
            // 
            // lblRetailPrice
            // 
            this.lblRetailPrice.AutoSize = true;
            this.lblRetailPrice.Location = new System.Drawing.Point(33, 178);
            this.lblRetailPrice.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblRetailPrice.Name = "lblRetailPrice";
            this.lblRetailPrice.Size = new System.Drawing.Size(88, 20);
            this.lblRetailPrice.TabIndex = 20;
            this.lblRetailPrice.Text = "Retail price";
            // 
            // lblItemCode
            // 
            this.lblItemCode.AutoSize = true;
            this.lblItemCode.Location = new System.Drawing.Point(33, 21);
            this.lblItemCode.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblItemCode.Name = "lblItemCode";
            this.lblItemCode.Size = new System.Drawing.Size(83, 20);
            this.lblItemCode.TabIndex = 19;
            this.lblItemCode.Text = "Item Code";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(20, 535);
            this.btnSave.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(142, 35);
            this.btnSave.TabIndex = 39;
            this.btnSave.Text = "&Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnRead
            // 
            this.btnRead.Location = new System.Drawing.Point(177, 535);
            this.btnRead.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnRead.Name = "btnRead";
            this.btnRead.Size = new System.Drawing.Size(138, 35);
            this.btnRead.TabIndex = 38;
            this.btnRead.Text = "&Read";
            this.btnRead.UseVisualStyleBackColor = true;
            this.btnRead.Click += new System.EventHandler(this.btnRead_Click);
            // 
            // CfmStockList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(336, 584);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnRead);
            this.Controls.Add(this.grpSort);
            this.Controls.Add(this.btnRemoveItem);
            this.Controls.Add(this.btnSale);
            this.Controls.Add(this.btnReceiveStock);
            this.Controls.Add(this.btnMarkUp);
            this.Controls.Add(this.btnSetRetailPrice);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnListItems);
            this.Controls.Add(this.btnAddItem);
            this.Controls.Add(this.txtItemName);
            this.Controls.Add(this.txtCostPrice);
            this.Controls.Add(this.txtRetailPrice);
            this.Controls.Add(this.txtQuantity);
            this.Controls.Add(this.txtItemCode);
            this.Controls.Add(this.lblQuantity);
            this.Controls.Add(this.lblItemName);
            this.Controls.Add(this.lblCostPrice);
            this.Controls.Add(this.lblRetailPrice);
            this.Controls.Add(this.lblItemCode);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CfmStockList";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "STOCK LIST";
            this.grpSort.ResumeLayout(false);
            this.grpSort.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grpSort;
        private System.Windows.Forms.RadioButton radItemPrice;
        private System.Windows.Forms.RadioButton radItemName;
        private System.Windows.Forms.RadioButton radItemCode;
        private System.Windows.Forms.Button btnRemoveItem;
        private System.Windows.Forms.Button btnSale;
        private System.Windows.Forms.Button btnReceiveStock;
        private System.Windows.Forms.Button btnMarkUp;
        private System.Windows.Forms.Button btnSetRetailPrice;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnListItems;
        private System.Windows.Forms.Button btnAddItem;
        private System.Windows.Forms.TextBox txtItemName;
        private System.Windows.Forms.TextBox txtCostPrice;
        private System.Windows.Forms.TextBox txtRetailPrice;
        private System.Windows.Forms.TextBox txtQuantity;
        private System.Windows.Forms.TextBox txtItemCode;
        private System.Windows.Forms.Label lblQuantity;
        private System.Windows.Forms.Label lblItemName;
        private System.Windows.Forms.Label lblCostPrice;
        private System.Windows.Forms.Label lblRetailPrice;
        private System.Windows.Forms.Label lblItemCode;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnRead;
        private System.Windows.Forms.SaveFileDialog digSave;
        private System.Windows.Forms.OpenFileDialog digOpen;
    }
}

