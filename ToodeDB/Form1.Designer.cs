namespace ToodeDB
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
            this.components = new System.ComponentModel.Container();
            this.Hindtxt = new System.Windows.Forms.TextBox();
            this.Kogustxt = new System.Windows.Forms.TextBox();
            this.Toodetxt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.toodeTableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.toodedDataSet = new ToodeDB.ToodedDataSet();
            this.toodeTableTableAdapter = new ToodeDB.ToodedDataSetTableAdapters.ToodeTableTableAdapter();
            this.button4 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.toodeTableBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.toodedDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Hindtxt
            // 
            this.Hindtxt.Location = new System.Drawing.Point(132, 173);
            this.Hindtxt.Name = "Hindtxt";
            this.Hindtxt.Size = new System.Drawing.Size(131, 20);
            this.Hindtxt.TabIndex = 0;
            // 
            // Kogustxt
            // 
            this.Kogustxt.Location = new System.Drawing.Point(132, 125);
            this.Kogustxt.Name = "Kogustxt";
            this.Kogustxt.Size = new System.Drawing.Size(131, 20);
            this.Kogustxt.TabIndex = 1;
            // 
            // Toodetxt
            // 
            this.Toodetxt.Location = new System.Drawing.Point(132, 73);
            this.Toodetxt.Name = "Toodetxt";
            this.Toodetxt.Size = new System.Drawing.Size(131, 20);
            this.Toodetxt.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(54, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Toode";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(54, 125);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Kogus";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(54, 180);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Hind";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(85, 229);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(121, 33);
            this.button1.TabIndex = 7;
            this.button1.Text = "Lisa uus";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(85, 289);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(121, 33);
            this.button2.TabIndex = 8;
            this.button2.Text = "Uuenda";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(85, 352);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(121, 33);
            this.button3.TabIndex = 9;
            this.button3.Text = "Kustuta";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(338, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(450, 221);
            this.dataGridView1.TabIndex = 10;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_RowHeaderMouseClick);
            // 
            // toodeTableBindingSource
            // 
            this.toodeTableBindingSource.DataMember = "ToodeTable";
            this.toodeTableBindingSource.DataSource = this.toodedDataSet;
            // 
            // toodedDataSet
            // 
            this.toodedDataSet.DataSetName = "ToodedDataSet";
            this.toodedDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // toodeTableTableAdapter
            // 
            this.toodeTableTableAdapter.ClearBeforeFill = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(271, 319);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(144, 66);
            this.button4.TabIndex = 11;
            this.button4.Text = "Lisa uus";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(518, 265);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(213, 119);
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Toodetxt);
            this.Controls.Add(this.Kogustxt);
            this.Controls.Add(this.Hindtxt);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.toodeTableBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.toodedDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Hindtxt;
        private System.Windows.Forms.TextBox Kogustxt;
        private System.Windows.Forms.TextBox Toodetxt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private ToodedDataSet toodedDataSet;
        private System.Windows.Forms.BindingSource toodeTableBindingSource;
        private ToodedDataSetTableAdapters.ToodeTableTableAdapter toodeTableTableAdapter;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

