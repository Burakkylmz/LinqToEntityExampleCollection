namespace LinqToEntityExampleCollection
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
            this.btnFunction = new System.Windows.Forms.Button();
            this.btnJoin = new System.Windows.Forms.Button();
            this.btnGroupBy = new System.Windows.Forms.Button();
            this.btnSelect = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.btnDistinct = new System.Windows.Forms.Button();
            this.btnMinMax = new System.Windows.Forms.Button();
            this.btnSum = new System.Windows.Forms.Button();
            this.btnCount = new System.Windows.Forms.Button();
            this.btnAny = new System.Windows.Forms.Button();
            this.btnStarAndEndWith = new System.Windows.Forms.Button();
            this.btnContains = new System.Windows.Forms.Button();
            this.btnSkip = new System.Windows.Forms.Button();
            this.btnTake = new System.Windows.Forms.Button();
            this.btnFind = new System.Windows.Forms.Button();
            this.btnFirstOrDefault = new System.Windows.Forms.Button();
            this.btnFirstMethodu = new System.Windows.Forms.Button();
            this.btnOrderBy = new System.Windows.Forms.Button();
            this.btnWhere = new System.Windows.Forms.Button();
            this.btnTolist = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnFunction
            // 
            this.btnFunction.Location = new System.Drawing.Point(437, 329);
            this.btnFunction.Name = "btnFunction";
            this.btnFunction.Size = new System.Drawing.Size(75, 23);
            this.btnFunction.TabIndex = 41;
            this.btnFunction.Text = "Function";
            this.btnFunction.UseVisualStyleBackColor = true;
            this.btnFunction.Click += new System.EventHandler(this.btnFunction_Click);
            // 
            // btnJoin
            // 
            this.btnJoin.Location = new System.Drawing.Point(350, 328);
            this.btnJoin.Name = "btnJoin";
            this.btnJoin.Size = new System.Drawing.Size(75, 23);
            this.btnJoin.TabIndex = 40;
            this.btnJoin.Text = "Join İşlemleri";
            this.btnJoin.UseVisualStyleBackColor = true;
            this.btnJoin.Click += new System.EventHandler(this.btnJoin_Click);
            // 
            // btnGroupBy
            // 
            this.btnGroupBy.Location = new System.Drawing.Point(268, 329);
            this.btnGroupBy.Name = "btnGroupBy";
            this.btnGroupBy.Size = new System.Drawing.Size(75, 23);
            this.btnGroupBy.TabIndex = 39;
            this.btnGroupBy.Text = "Group By";
            this.btnGroupBy.UseVisualStyleBackColor = true;
            this.btnGroupBy.Click += new System.EventHandler(this.btnGroupBy_Click);
            // 
            // btnSelect
            // 
            this.btnSelect.Location = new System.Drawing.Point(187, 328);
            this.btnSelect.Name = "btnSelect";
            this.btnSelect.Size = new System.Drawing.Size(75, 23);
            this.btnSelect.TabIndex = 38;
            this.btnSelect.Text = "Select Metodu";
            this.btnSelect.UseVisualStyleBackColor = true;
            this.btnSelect.Click += new System.EventHandler(this.btnSelect_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(627, 12);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(185, 342);
            this.listBox1.TabIndex = 37;
            // 
            // btnDistinct
            // 
            this.btnDistinct.Location = new System.Drawing.Point(106, 328);
            this.btnDistinct.Name = "btnDistinct";
            this.btnDistinct.Size = new System.Drawing.Size(75, 23);
            this.btnDistinct.TabIndex = 36;
            this.btnDistinct.Text = "Distinct";
            this.btnDistinct.UseVisualStyleBackColor = true;
            this.btnDistinct.Click += new System.EventHandler(this.btnDistinct_Click);
            // 
            // btnMinMax
            // 
            this.btnMinMax.Location = new System.Drawing.Point(12, 328);
            this.btnMinMax.Name = "btnMinMax";
            this.btnMinMax.Size = new System.Drawing.Size(88, 23);
            this.btnMinMax.TabIndex = 35;
            this.btnMinMax.Text = "Min-Max";
            this.btnMinMax.UseVisualStyleBackColor = true;
            this.btnMinMax.Click += new System.EventHandler(this.btnMinMax_Click);
            // 
            // btnSum
            // 
            this.btnSum.Location = new System.Drawing.Point(520, 296);
            this.btnSum.Name = "btnSum";
            this.btnSum.Size = new System.Drawing.Size(90, 26);
            this.btnSum.TabIndex = 34;
            this.btnSum.Text = "Sum";
            this.btnSum.UseVisualStyleBackColor = true;
            this.btnSum.Click += new System.EventHandler(this.btnSum_Click);
            // 
            // btnCount
            // 
            this.btnCount.Location = new System.Drawing.Point(438, 296);
            this.btnCount.Name = "btnCount";
            this.btnCount.Size = new System.Drawing.Size(75, 26);
            this.btnCount.TabIndex = 33;
            this.btnCount.Text = "Count";
            this.btnCount.UseVisualStyleBackColor = true;
            this.btnCount.Click += new System.EventHandler(this.btnCount_Click);
            // 
            // btnAny
            // 
            this.btnAny.Location = new System.Drawing.Point(350, 296);
            this.btnAny.Name = "btnAny";
            this.btnAny.Size = new System.Drawing.Size(81, 26);
            this.btnAny.TabIndex = 32;
            this.btnAny.Text = "Any Metodu";
            this.btnAny.UseVisualStyleBackColor = true;
            this.btnAny.Click += new System.EventHandler(this.btnAny_Click);
            // 
            // btnStarAndEndWith
            // 
            this.btnStarAndEndWith.Location = new System.Drawing.Point(220, 295);
            this.btnStarAndEndWith.Name = "btnStarAndEndWith";
            this.btnStarAndEndWith.Size = new System.Drawing.Size(123, 27);
            this.btnStarAndEndWith.TabIndex = 31;
            this.btnStarAndEndWith.Text = "StartWith EndsWith";
            this.btnStarAndEndWith.UseVisualStyleBackColor = true;
            this.btnStarAndEndWith.Click += new System.EventHandler(this.btnStarAndEndWith_Click);
            // 
            // btnContains
            // 
            this.btnContains.Location = new System.Drawing.Point(106, 295);
            this.btnContains.Name = "btnContains";
            this.btnContains.Size = new System.Drawing.Size(107, 27);
            this.btnContains.TabIndex = 30;
            this.btnContains.Text = "Contains Metodu";
            this.btnContains.UseVisualStyleBackColor = true;
            this.btnContains.Click += new System.EventHandler(this.btnContains_Click);
            // 
            // btnSkip
            // 
            this.btnSkip.Location = new System.Drawing.Point(12, 295);
            this.btnSkip.Name = "btnSkip";
            this.btnSkip.Size = new System.Drawing.Size(88, 27);
            this.btnSkip.TabIndex = 29;
            this.btnSkip.Text = "Skip Methodu";
            this.btnSkip.UseVisualStyleBackColor = true;
            this.btnSkip.Click += new System.EventHandler(this.btnSkip_Click);
            // 
            // btnTake
            // 
            this.btnTake.Location = new System.Drawing.Point(519, 262);
            this.btnTake.Name = "btnTake";
            this.btnTake.Size = new System.Drawing.Size(91, 27);
            this.btnTake.TabIndex = 28;
            this.btnTake.Text = "Take Methodu";
            this.btnTake.UseVisualStyleBackColor = true;
            this.btnTake.Click += new System.EventHandler(this.btnTake_Click);
            // 
            // btnFind
            // 
            this.btnFind.Location = new System.Drawing.Point(437, 261);
            this.btnFind.Name = "btnFind";
            this.btnFind.Size = new System.Drawing.Size(75, 28);
            this.btnFind.TabIndex = 27;
            this.btnFind.Text = "Find Metodu";
            this.btnFind.UseVisualStyleBackColor = true;
            this.btnFind.Click += new System.EventHandler(this.btnFind_Click);
            // 
            // btnFirstOrDefault
            // 
            this.btnFirstOrDefault.Location = new System.Drawing.Point(350, 262);
            this.btnFirstOrDefault.Name = "btnFirstOrDefault";
            this.btnFirstOrDefault.Size = new System.Drawing.Size(81, 27);
            this.btnFirstOrDefault.TabIndex = 26;
            this.btnFirstOrDefault.Text = "FirstOrDefault";
            this.btnFirstOrDefault.UseVisualStyleBackColor = true;
            this.btnFirstOrDefault.Click += new System.EventHandler(this.btnFirstOrDefault_Click);
            // 
            // btnFirstMethodu
            // 
            this.btnFirstMethodu.Location = new System.Drawing.Point(268, 261);
            this.btnFirstMethodu.Name = "btnFirstMethodu";
            this.btnFirstMethodu.Size = new System.Drawing.Size(75, 28);
            this.btnFirstMethodu.TabIndex = 25;
            this.btnFirstMethodu.Text = "First Metodu";
            this.btnFirstMethodu.UseVisualStyleBackColor = true;
            this.btnFirstMethodu.Click += new System.EventHandler(this.btnFirstMethodu_Click);
            // 
            // btnOrderBy
            // 
            this.btnOrderBy.Location = new System.Drawing.Point(187, 261);
            this.btnOrderBy.Name = "btnOrderBy";
            this.btnOrderBy.Size = new System.Drawing.Size(75, 28);
            this.btnOrderBy.TabIndex = 24;
            this.btnOrderBy.Text = "Order By";
            this.btnOrderBy.UseVisualStyleBackColor = true;
            this.btnOrderBy.Click += new System.EventHandler(this.btnOrderBy_Click);
            // 
            // btnWhere
            // 
            this.btnWhere.Location = new System.Drawing.Point(106, 261);
            this.btnWhere.Name = "btnWhere";
            this.btnWhere.Size = new System.Drawing.Size(75, 28);
            this.btnWhere.TabIndex = 23;
            this.btnWhere.Text = "Where";
            this.btnWhere.UseVisualStyleBackColor = true;
            this.btnWhere.Click += new System.EventHandler(this.btnWhere_Click);
            // 
            // btnTolist
            // 
            this.btnTolist.Location = new System.Drawing.Point(12, 261);
            this.btnTolist.Name = "btnTolist";
            this.btnTolist.Size = new System.Drawing.Size(88, 28);
            this.btnTolist.TabIndex = 22;
            this.btnTolist.Text = "To List";
            this.btnTolist.UseVisualStyleBackColor = true;
            this.btnTolist.Click += new System.EventHandler(this.btnTolist_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(598, 238);
            this.dataGridView1.TabIndex = 21;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(923, 450);
            this.Controls.Add(this.btnFunction);
            this.Controls.Add(this.btnJoin);
            this.Controls.Add(this.btnGroupBy);
            this.Controls.Add(this.btnSelect);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.btnDistinct);
            this.Controls.Add(this.btnMinMax);
            this.Controls.Add(this.btnSum);
            this.Controls.Add(this.btnCount);
            this.Controls.Add(this.btnAny);
            this.Controls.Add(this.btnStarAndEndWith);
            this.Controls.Add(this.btnContains);
            this.Controls.Add(this.btnSkip);
            this.Controls.Add(this.btnTake);
            this.Controls.Add(this.btnFind);
            this.Controls.Add(this.btnFirstOrDefault);
            this.Controls.Add(this.btnFirstMethodu);
            this.Controls.Add(this.btnOrderBy);
            this.Controls.Add(this.btnWhere);
            this.Controls.Add(this.btnTolist);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnFunction;
        private System.Windows.Forms.Button btnJoin;
        private System.Windows.Forms.Button btnGroupBy;
        private System.Windows.Forms.Button btnSelect;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button btnDistinct;
        private System.Windows.Forms.Button btnMinMax;
        private System.Windows.Forms.Button btnSum;
        private System.Windows.Forms.Button btnCount;
        private System.Windows.Forms.Button btnAny;
        private System.Windows.Forms.Button btnStarAndEndWith;
        private System.Windows.Forms.Button btnContains;
        private System.Windows.Forms.Button btnSkip;
        private System.Windows.Forms.Button btnTake;
        private System.Windows.Forms.Button btnFind;
        private System.Windows.Forms.Button btnFirstOrDefault;
        private System.Windows.Forms.Button btnFirstMethodu;
        private System.Windows.Forms.Button btnOrderBy;
        private System.Windows.Forms.Button btnWhere;
        private System.Windows.Forms.Button btnTolist;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}

