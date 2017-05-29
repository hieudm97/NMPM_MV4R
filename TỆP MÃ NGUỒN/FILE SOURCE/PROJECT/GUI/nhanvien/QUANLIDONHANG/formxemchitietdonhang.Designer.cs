namespace PROJECT.GUI.nhanvien.QUANLIDONHANG
{
    partial class formxemchitietdonhang
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
            this.TEN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SOLUONGDIAMUA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GIA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TEN,
            this.SOLUONGDIAMUA,
            this.GIA});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(760, 519);
            this.dataGridView1.TabIndex = 0;
            // 
            // TEN
            // 
            this.TEN.DataPropertyName = "TEN";
            this.TEN.HeaderText = "TÊN ĐĨA";
            this.TEN.Name = "TEN";
            // 
            // SOLUONGDIAMUA
            // 
            this.SOLUONGDIAMUA.DataPropertyName = "SOLUONGDIAMUA";
            this.SOLUONGDIAMUA.HeaderText = "SỐ LƯỢNG MUA";
            this.SOLUONGDIAMUA.Name = "SOLUONGDIAMUA";
            // 
            // GIA
            // 
            this.GIA.DataPropertyName = "GIA";
            this.GIA.HeaderText = "GIÁ SẢN PHẨM";
            this.GIA.Name = "GIA";
            // 
            // formxemchitietdonhang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(760, 519);
            this.Controls.Add(this.dataGridView1);
            this.Name = "formxemchitietdonhang";
            this.Text = "formxemchitietdonhang";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn TEN;
        private System.Windows.Forms.DataGridViewTextBoxColumn SOLUONGDIAMUA;
        private System.Windows.Forms.DataGridViewTextBoxColumn GIA;
    }
}