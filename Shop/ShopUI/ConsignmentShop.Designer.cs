namespace ShopUI
{
    partial class ConsignmentShop
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
            this.headerText = new System.Windows.Forms.Label();
            this.itemsListBox = new System.Windows.Forms.ListBox();
            this.itemsListBoxLabel = new System.Windows.Forms.Label();
            this.addToCard = new System.Windows.Forms.Button();
            this.shopingCardListBoxLabel = new System.Windows.Forms.Label();
            this.shopingCardListBox = new System.Windows.Forms.ListBox();
            this.makePurchase = new System.Windows.Forms.Button();
            this.vendorListBox = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // headerText
            // 
            this.headerText.AutoSize = true;
            this.headerText.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.headerText.Location = new System.Drawing.Point(12, 9);
            this.headerText.Name = "headerText";
            this.headerText.Size = new System.Drawing.Size(306, 37);
            this.headerText.TabIndex = 0;
            this.headerText.Text = "Consignment Shop";
            // 
            // itemsListBox
            // 
            this.itemsListBox.AccessibleRole = System.Windows.Forms.AccessibleRole.OutlineButton;
            this.itemsListBox.FormattingEnabled = true;
            this.itemsListBox.ItemHeight = 20;
            this.itemsListBox.Location = new System.Drawing.Point(19, 124);
            this.itemsListBox.Name = "itemsListBox";
            this.itemsListBox.Size = new System.Drawing.Size(299, 164);
            this.itemsListBox.TabIndex = 1;
            // 
            // itemsListBoxLabel
            // 
            this.itemsListBoxLabel.AutoSize = true;
            this.itemsListBoxLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.itemsListBoxLabel.Location = new System.Drawing.Point(15, 101);
            this.itemsListBoxLabel.Name = "itemsListBoxLabel";
            this.itemsListBoxLabel.Size = new System.Drawing.Size(103, 20);
            this.itemsListBoxLabel.TabIndex = 2;
            this.itemsListBoxLabel.Text = "Store Items";
            // 
            // addToCard
            // 
            this.addToCard.Location = new System.Drawing.Point(337, 169);
            this.addToCard.Name = "addToCard";
            this.addToCard.Size = new System.Drawing.Size(180, 47);
            this.addToCard.TabIndex = 3;
            this.addToCard.Text = "Add to Card ->";
            this.addToCard.UseVisualStyleBackColor = true;
            this.addToCard.Click += new System.EventHandler(this.addToCard_Click);
            // 
            // shopingCardListBoxLabel
            // 
            this.shopingCardListBoxLabel.AutoSize = true;
            this.shopingCardListBoxLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.shopingCardListBoxLabel.Location = new System.Drawing.Point(530, 101);
            this.shopingCardListBoxLabel.Name = "shopingCardListBoxLabel";
            this.shopingCardListBoxLabel.Size = new System.Drawing.Size(118, 20);
            this.shopingCardListBoxLabel.TabIndex = 5;
            this.shopingCardListBoxLabel.Text = "Shoping Card";
            // 
            // shopingCardListBox
            // 
            this.shopingCardListBox.AccessibleRole = System.Windows.Forms.AccessibleRole.OutlineButton;
            this.shopingCardListBox.FormattingEnabled = true;
            this.shopingCardListBox.ItemHeight = 20;
            this.shopingCardListBox.Location = new System.Drawing.Point(534, 124);
            this.shopingCardListBox.Name = "shopingCardListBox";
            this.shopingCardListBox.Size = new System.Drawing.Size(299, 164);
            this.shopingCardListBox.TabIndex = 4;
            // 
            // makePurchase
            // 
            this.makePurchase.Location = new System.Drawing.Point(642, 294);
            this.makePurchase.Name = "makePurchase";
            this.makePurchase.Size = new System.Drawing.Size(191, 47);
            this.makePurchase.TabIndex = 6;
            this.makePurchase.Text = "Purchase";
            this.makePurchase.UseVisualStyleBackColor = true;
            this.makePurchase.Click += new System.EventHandler(this.makePurchase_Click);
            // 
            // vendorListBox
            // 
            this.vendorListBox.AutoSize = true;
            this.vendorListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vendorListBox.Location = new System.Drawing.Point(15, 381);
            this.vendorListBox.Name = "vendorListBox";
            this.vendorListBox.Size = new System.Drawing.Size(76, 20);
            this.vendorListBox.TabIndex = 8;
            this.vendorListBox.Text = "Venodrs";
            // 
            // listBox1
            // 
            this.listBox1.AccessibleRole = System.Windows.Forms.AccessibleRole.OutlineButton;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 20;
            this.listBox1.Location = new System.Drawing.Point(19, 404);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(299, 164);
            this.listBox1.TabIndex = 7;
            // 
            // ConsignmentShop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(845, 652);
            this.Controls.Add(this.vendorListBox);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.makePurchase);
            this.Controls.Add(this.shopingCardListBoxLabel);
            this.Controls.Add(this.shopingCardListBox);
            this.Controls.Add(this.addToCard);
            this.Controls.Add(this.itemsListBoxLabel);
            this.Controls.Add(this.itemsListBox);
            this.Controls.Add(this.headerText);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "ConsignmentShop";
            this.Text = "Consignment Shop";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label headerText;
        private System.Windows.Forms.ListBox itemsListBox;
        private System.Windows.Forms.Label itemsListBoxLabel;
        private System.Windows.Forms.Button addToCard;
        private System.Windows.Forms.Label shopingCardListBoxLabel;
        private System.Windows.Forms.ListBox shopingCardListBox;
        private System.Windows.Forms.Button makePurchase;
        private System.Windows.Forms.Label vendorListBox;
        private System.Windows.Forms.ListBox listBox1;
    }
}

