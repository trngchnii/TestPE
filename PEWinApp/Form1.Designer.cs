namespace PEWinApp
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dgProduct = new DataGridView();
            dgOrderDetail = new DataGridView();
            groupBox1 = new GroupBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            cbDiscountinued = new CheckBox();
            txtId = new TextBox();
            txtName = new TextBox();
            cboCategory = new ComboBox();
            label4 = new Label();
            numUnitPrice = new NumericUpDown();
            label5 = new Label();
            btnAdd = new Button();
            btnUpdate = new Button();
            btnDelete = new Button();
            ((System.ComponentModel.ISupportInitialize)dgProduct).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgOrderDetail).BeginInit();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numUnitPrice).BeginInit();
            SuspendLayout();
            // 
            // dgProduct
            // 
            dgProduct.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgProduct.Location = new Point(33, 430);
            dgProduct.Name = "dgProduct";
            dgProduct.RowHeadersWidth = 62;
            dgProduct.RowTemplate.Height = 33;
            dgProduct.Size = new Size(559, 260);
            dgProduct.TabIndex = 0;
            dgProduct.CellClick += dgProduct_CellClick;
            // 
            // dgOrderDetail
            // 
            dgOrderDetail.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgOrderDetail.Location = new Point(648, 430);
            dgOrderDetail.Name = "dgOrderDetail";
            dgOrderDetail.RowHeadersWidth = 62;
            dgOrderDetail.RowTemplate.Height = 33;
            dgOrderDetail.Size = new Size(559, 260);
            dgOrderDetail.TabIndex = 1;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnDelete);
            groupBox1.Controls.Add(btnUpdate);
            groupBox1.Controls.Add(btnAdd);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(numUnitPrice);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(cboCategory);
            groupBox1.Controls.Add(txtName);
            groupBox1.Controls.Add(txtId);
            groupBox1.Controls.Add(cbDiscountinued);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(33, 23);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(492, 384);
            groupBox1.TabIndex = 3;
            groupBox1.TabStop = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(29, 152);
            label3.Name = "label3";
            label3.Size = new Size(116, 25);
            label3.TabIndex = 2;
            label3.Text = "Discontinued";
            label3.TextAlign = ContentAlignment.TopRight;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(29, 93);
            label2.Name = "label2";
            label2.Size = new Size(59, 25);
            label2.TabIndex = 1;
            label2.Text = "Name";
            label2.TextAlign = ContentAlignment.TopRight;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(29, 27);
            label1.Name = "label1";
            label1.Size = new Size(28, 25);
            label1.TabIndex = 0;
            label1.Text = "Id";
            // 
            // cbDiscountinued
            // 
            cbDiscountinued.AutoSize = true;
            cbDiscountinued.Location = new Point(180, 152);
            cbDiscountinued.Name = "cbDiscountinued";
            cbDiscountinued.Size = new Size(22, 21);
            cbDiscountinued.TabIndex = 3;
            cbDiscountinued.UseVisualStyleBackColor = true;
            // 
            // txtId
            // 
            txtId.Location = new Point(175, 30);
            txtId.Name = "txtId";
            txtId.Size = new Size(199, 31);
            txtId.TabIndex = 4;
            // 
            // txtName
            // 
            txtName.Location = new Point(175, 87);
            txtName.Name = "txtName";
            txtName.Size = new Size(199, 31);
            txtName.TabIndex = 5;
            // 
            // cboCategory
            // 
            cboCategory.FormattingEnabled = true;
            cboCategory.Location = new Point(175, 202);
            cboCategory.Name = "cboCategory";
            cboCategory.Size = new Size(199, 33);
            cboCategory.TabIndex = 6;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(29, 210);
            label4.Name = "label4";
            label4.Size = new Size(84, 25);
            label4.TabIndex = 7;
            label4.Text = "Category";
            label4.TextAlign = ContentAlignment.TopRight;
            // 
            // numUnitPrice
            // 
            numUnitPrice.Location = new Point(175, 272);
            numUnitPrice.Name = "numUnitPrice";
            numUnitPrice.Size = new Size(199, 31);
            numUnitPrice.TabIndex = 8;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(29, 278);
            label5.Name = "label5";
            label5.Size = new Size(81, 25);
            label5.TabIndex = 9;
            label5.Text = "UnitPrice";
            label5.TextAlign = ContentAlignment.TopRight;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(61, 332);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(84, 34);
            btnAdd.TabIndex = 10;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(186, 332);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(84, 34);
            btnUpdate.TabIndex = 11;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(322, 332);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(84, 34);
            btnDelete.TabIndex = 12;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1238, 720);
            Controls.Add(groupBox1);
            Controls.Add(dgOrderDetail);
            Controls.Add(dgProduct);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dgProduct).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgOrderDetail).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numUnitPrice).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgProduct;
        private DataGridView dgOrderDetail;
        private GroupBox groupBox1;
        private Label label2;
        private Label label1;
        private Label label3;
        private TextBox txtName;
        private TextBox txtId;
        private CheckBox cbDiscountinued;
        private Button btnDelete;
        private Button btnUpdate;
        private Button btnAdd;
        private Label label5;
        private NumericUpDown numUnitPrice;
        private Label label4;
        private ComboBox cboCategory;
    }
}