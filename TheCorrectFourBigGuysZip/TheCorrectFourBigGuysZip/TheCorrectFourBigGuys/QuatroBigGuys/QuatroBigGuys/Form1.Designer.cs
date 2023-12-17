namespace QuatroBigGuys
{
    partial class Form1
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.txtPPU = new System.Windows.Forms.TextBox();
            this.btnNew = new System.Windows.Forms.Button();
            this.btnLoad = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.lblMaterialName = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblPriceEstimate = new System.Windows.Forms.Label();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.btnFile = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtUnits = new System.Windows.Forms.TextBox();
            this.lblTotal = new System.Windows.Forms.Label();
            this.lblTotalDisplay = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(349, 63);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.Size = new System.Drawing.Size(338, 305);
            this.dataGridView1.TabIndex = 4;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // txtPPU
            // 
            this.txtPPU.Location = new System.Drawing.Point(156, 125);
            this.txtPPU.Multiline = true;
            this.txtPPU.Name = "txtPPU";
            this.txtPPU.Size = new System.Drawing.Size(117, 20);
            this.txtPPU.TabIndex = 1;
            this.txtPPU.TextChanged += new System.EventHandler(this.txtBox_TextChanged);
            // 
            // btnNew
            // 
            this.btnNew.Font = new System.Drawing.Font("Ebrima", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNew.Location = new System.Drawing.Point(117, 201);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(75, 50);
            this.btnNew.TabIndex = 2;
            this.btnNew.Text = "New Estimate";
            this.btnNew.UseVisualStyleBackColor = true;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // btnLoad
            // 
            this.btnLoad.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLoad.Location = new System.Drawing.Point(198, 201);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(75, 50);
            this.btnLoad.TabIndex = 3;
            this.btnLoad.Text = "Load Estimate";
            this.btnLoad.UseVisualStyleBackColor = true;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Font = new System.Drawing.Font("Ebrima", 9.75F);
            this.btnDelete.Location = new System.Drawing.Point(117, 260);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 50);
            this.btnDelete.TabIndex = 4;
            this.btnDelete.Text = "Delete Estimate";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // lblMaterialName
            // 
            this.lblMaterialName.AutoSize = true;
            this.lblMaterialName.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaterialName.Location = new System.Drawing.Point(32, 64);
            this.lblMaterialName.Name = "lblMaterialName";
            this.lblMaterialName.Size = new System.Drawing.Size(121, 19);
            this.lblMaterialName.TabIndex = 5;
            this.lblMaterialName.Text = "Material Name";
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Ebrima", 9.75F);
            this.btnSave.Location = new System.Drawing.Point(198, 260);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 50);
            this.btnSave.TabIndex = 6;
            this.btnSave.Text = "Save Estimate";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(156, 63);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(117, 20);
            this.txtName.TabIndex = 7;
            // 
            // lblPriceEstimate
            // 
            this.lblPriceEstimate.AutoSize = true;
            this.lblPriceEstimate.Font = new System.Drawing.Font("Microsoft Tai Le", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPriceEstimate.Location = new System.Drawing.Point(39, 126);
            this.lblPriceEstimate.Name = "lblPriceEstimate";
            this.lblPriceEstimate.Size = new System.Drawing.Size(104, 19);
            this.lblPriceEstimate.TabIndex = 8;
            this.lblPriceEstimate.Text = "Price Per Unit";
            // 
            // btnCalculate
            // 
            this.btnCalculate.Font = new System.Drawing.Font("Ebrima", 9.75F);
            this.btnCalculate.Location = new System.Drawing.Point(117, 319);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(75, 49);
            this.btnCalculate.TabIndex = 9;
            this.btnCalculate.Text = "Calculate Total";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // btnFile
            // 
            this.btnFile.Font = new System.Drawing.Font("Ebrima", 9.75F);
            this.btnFile.Location = new System.Drawing.Point(198, 319);
            this.btnFile.Name = "btnFile";
            this.btnFile.Size = new System.Drawing.Size(75, 49);
            this.btnFile.TabIndex = 10;
            this.btnFile.Text = "Save To File";
            this.btnFile.UseVisualStyleBackColor = true;
            this.btnFile.Click += new System.EventHandler(this.btnFile_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(32, 96);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 19);
            this.label1.TabIndex = 11;
            this.label1.Text = "Required Units";
            // 
            // txtUnits
            // 
            this.txtUnits.Location = new System.Drawing.Point(156, 95);
            this.txtUnits.Name = "txtUnits";
            this.txtUnits.Size = new System.Drawing.Size(117, 20);
            this.txtUnits.TabIndex = 12;
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Microsoft Tai Le", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.Location = new System.Drawing.Point(98, 163);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(45, 19);
            this.lblTotal.TabIndex = 13;
            this.lblTotal.Text = "Total";
            // 
            // lblTotalDisplay
            // 
            this.lblTotalDisplay.AutoSize = true;
            this.lblTotalDisplay.Font = new System.Drawing.Font("Microsoft Tai Le", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalDisplay.Location = new System.Drawing.Point(185, 163);
            this.lblTotalDisplay.Name = "lblTotalDisplay";
            this.lblTotalDisplay.Size = new System.Drawing.Size(58, 19);
            this.lblTotalDisplay.TabIndex = 14;
            this.lblTotalDisplay.Text = "$00.00";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblTotalDisplay);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.txtUnits);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnFile);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.lblPriceEstimate);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.lblMaterialName);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnLoad);
            this.Controls.Add(this.btnNew);
            this.Controls.Add(this.txtPPU);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txtPPU;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Label lblMaterialName;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblPriceEstimate;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Button btnFile;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtUnits;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label lblTotalDisplay;
    }
}

