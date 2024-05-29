
namespace Yurt_Kayitv1
{
    partial class FrmBolumler
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmBolumler));
            this.PcbBolumEkle = new System.Windows.Forms.PictureBox();
            this.PcbBolumDüzenle = new System.Windows.Forms.PictureBox();
            this.PcbBölümsil = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.TxtBolumid = new System.Windows.Forms.TextBox();
            this.TxtBolumAd = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.bolumıdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bolumAdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bolumlerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.yurtKayıtDataSet = new Yurt_Kayitv1.YurtKayıtDataSet();
            this.bolumlerTableAdapter = new Yurt_Kayitv1.YurtKayıtDataSetTableAdapters.BolumlerTableAdapter();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.PcbBolumEkle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PcbBolumDüzenle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PcbBölümsil)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bolumlerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.yurtKayıtDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // PcbBolumEkle
            // 
            this.PcbBolumEkle.Image = ((System.Drawing.Image)(resources.GetObject("PcbBolumEkle.Image")));
            this.PcbBolumEkle.Location = new System.Drawing.Point(427, 125);
            this.PcbBolumEkle.Name = "PcbBolumEkle";
            this.PcbBolumEkle.Size = new System.Drawing.Size(85, 42);
            this.PcbBolumEkle.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PcbBolumEkle.TabIndex = 0;
            this.PcbBolumEkle.TabStop = false;
            this.toolTip1.SetToolTip(this.PcbBolumEkle, "Bölüm Ekle");
            this.PcbBolumEkle.Click += new System.EventHandler(this.PcbBolumEkle_Click);
            // 
            // PcbBolumDüzenle
            // 
            this.PcbBolumDüzenle.Image = ((System.Drawing.Image)(resources.GetObject("PcbBolumDüzenle.Image")));
            this.PcbBolumDüzenle.Location = new System.Drawing.Point(427, 69);
            this.PcbBolumDüzenle.Name = "PcbBolumDüzenle";
            this.PcbBolumDüzenle.Size = new System.Drawing.Size(85, 50);
            this.PcbBolumDüzenle.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PcbBolumDüzenle.TabIndex = 1;
            this.PcbBolumDüzenle.TabStop = false;
            this.toolTip1.SetToolTip(this.PcbBolumDüzenle, "Bölüm Düzenle");
            this.PcbBolumDüzenle.Click += new System.EventHandler(this.PcbBolumDüzenle_Click);
            // 
            // PcbBölümsil
            // 
            this.PcbBölümsil.Image = ((System.Drawing.Image)(resources.GetObject("PcbBölümsil.Image")));
            this.PcbBölümsil.Location = new System.Drawing.Point(427, 12);
            this.PcbBölümsil.Name = "PcbBölümsil";
            this.PcbBölümsil.Size = new System.Drawing.Size(85, 51);
            this.PcbBölümsil.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PcbBölümsil.TabIndex = 2;
            this.PcbBölümsil.TabStop = false;
            this.toolTip1.SetToolTip(this.PcbBölümsil, "Bölüm Sil");
            this.PcbBölümsil.Click += new System.EventHandler(this.PcbBölümsil_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(19, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 18);
            this.label1.TabIndex = 3;
            this.label1.Text = "Bölüm id:";
            // 
            // TxtBolumid
            // 
            this.TxtBolumid.Enabled = false;
            this.TxtBolumid.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TxtBolumid.Location = new System.Drawing.Point(120, 20);
            this.TxtBolumid.Name = "TxtBolumid";
            this.TxtBolumid.Size = new System.Drawing.Size(194, 26);
            this.TxtBolumid.TabIndex = 4;
            // 
            // TxtBolumAd
            // 
            this.TxtBolumAd.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TxtBolumAd.Location = new System.Drawing.Point(120, 52);
            this.TxtBolumAd.Name = "TxtBolumAd";
            this.TxtBolumAd.Size = new System.Drawing.Size(194, 26);
            this.TxtBolumAd.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(19, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 18);
            this.label2.TabIndex = 5;
            this.label2.Text = "Bölüm Ad:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.bolumıdDataGridViewTextBoxColumn,
            this.bolumAdDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.bolumlerBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 173);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(539, 262);
            this.dataGridView1.TabIndex = 7;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // bolumıdDataGridViewTextBoxColumn
            // 
            this.bolumıdDataGridViewTextBoxColumn.DataPropertyName = "Bolumıd";
            this.bolumıdDataGridViewTextBoxColumn.HeaderText = "Bolumıd";
            this.bolumıdDataGridViewTextBoxColumn.Name = "bolumıdDataGridViewTextBoxColumn";
            this.bolumıdDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // bolumAdDataGridViewTextBoxColumn
            // 
            this.bolumAdDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.bolumAdDataGridViewTextBoxColumn.DataPropertyName = "BolumAd";
            this.bolumAdDataGridViewTextBoxColumn.HeaderText = "BolumAd";
            this.bolumAdDataGridViewTextBoxColumn.Name = "bolumAdDataGridViewTextBoxColumn";
            // 
            // bolumlerBindingSource
            // 
            this.bolumlerBindingSource.DataMember = "Bolumler";
            this.bolumlerBindingSource.DataSource = this.yurtKayıtDataSet;
            // 
            // yurtKayıtDataSet
            // 
            this.yurtKayıtDataSet.DataSetName = "YurtKayıtDataSet";
            this.yurtKayıtDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bolumlerTableAdapter
            // 
            this.bolumlerTableAdapter.ClearBeforeFill = true;
            // 
            // FrmBolumler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(563, 437);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.TxtBolumAd);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TxtBolumid);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.PcbBölümsil);
            this.Controls.Add(this.PcbBolumDüzenle);
            this.Controls.Add(this.PcbBolumEkle);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimizeBox = false;
            this.Name = "FrmBolumler";
            this.Text = "Bölümler";
            this.Load += new System.EventHandler(this.FrmBolumler_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PcbBolumEkle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PcbBolumDüzenle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PcbBölümsil)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bolumlerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.yurtKayıtDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox PcbBolumEkle;
        private System.Windows.Forms.PictureBox PcbBolumDüzenle;
        private System.Windows.Forms.PictureBox PcbBölümsil;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtBolumid;
        private System.Windows.Forms.TextBox TxtBolumAd;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private YurtKayıtDataSet yurtKayıtDataSet;
        private System.Windows.Forms.BindingSource bolumlerBindingSource;
        private YurtKayıtDataSetTableAdapters.BolumlerTableAdapter bolumlerTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn bolumıdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bolumAdDataGridViewTextBoxColumn;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}