namespace WindowsFormsApp1
{
    partial class HeroTable
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.damagePerSecondDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.headshotDPSDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.singleShotDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lifeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.reloadDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.heroBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.buttonSave = new System.Windows.Forms.Button();
            this.dpsTextBoxTo = new System.Windows.Forms.TextBox();
            this.dpsTextBoxFrom = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lifeTextBoxTo = new System.Windows.Forms.TextBox();
            this.lifeTextBoxFrom = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.headshotTextBoxTo = new System.Windows.Forms.TextBox();
            this.headshotTextBoxFrom = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.buttonApplyFilters = new System.Windows.Forms.Button();
            this.buttonReturnTable = new System.Windows.Forms.Button();
            this.buttonStart = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.heroBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nameDataGridViewTextBoxColumn,
            this.damagePerSecondDataGridViewTextBoxColumn,
            this.headshotDPSDataGridViewTextBoxColumn,
            this.singleShotDataGridViewTextBoxColumn,
            this.lifeDataGridViewTextBoxColumn,
            this.reloadDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.heroBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(1, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 82;
            this.dataGridView1.RowTemplate.Height = 33;
            this.dataGridView1.Size = new System.Drawing.Size(1000, 842);
            this.dataGridView1.TabIndex = 0;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.MinimumWidth = 10;
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.Width = 200;
            // 
            // damagePerSecondDataGridViewTextBoxColumn
            // 
            this.damagePerSecondDataGridViewTextBoxColumn.DataPropertyName = "DamagePerSecond";
            this.damagePerSecondDataGridViewTextBoxColumn.HeaderText = "DamagePerSecond";
            this.damagePerSecondDataGridViewTextBoxColumn.MinimumWidth = 10;
            this.damagePerSecondDataGridViewTextBoxColumn.Name = "damagePerSecondDataGridViewTextBoxColumn";
            this.damagePerSecondDataGridViewTextBoxColumn.Width = 200;
            // 
            // headshotDPSDataGridViewTextBoxColumn
            // 
            this.headshotDPSDataGridViewTextBoxColumn.DataPropertyName = "HeadshotDPS";
            this.headshotDPSDataGridViewTextBoxColumn.HeaderText = "HeadshotDPS";
            this.headshotDPSDataGridViewTextBoxColumn.MinimumWidth = 10;
            this.headshotDPSDataGridViewTextBoxColumn.Name = "headshotDPSDataGridViewTextBoxColumn";
            this.headshotDPSDataGridViewTextBoxColumn.Width = 200;
            // 
            // singleShotDataGridViewTextBoxColumn
            // 
            this.singleShotDataGridViewTextBoxColumn.DataPropertyName = "SingleShot";
            this.singleShotDataGridViewTextBoxColumn.HeaderText = "SingleShot";
            this.singleShotDataGridViewTextBoxColumn.MinimumWidth = 10;
            this.singleShotDataGridViewTextBoxColumn.Name = "singleShotDataGridViewTextBoxColumn";
            this.singleShotDataGridViewTextBoxColumn.Width = 200;
            // 
            // lifeDataGridViewTextBoxColumn
            // 
            this.lifeDataGridViewTextBoxColumn.DataPropertyName = "Life";
            this.lifeDataGridViewTextBoxColumn.HeaderText = "Life";
            this.lifeDataGridViewTextBoxColumn.MinimumWidth = 10;
            this.lifeDataGridViewTextBoxColumn.Name = "lifeDataGridViewTextBoxColumn";
            this.lifeDataGridViewTextBoxColumn.Width = 200;
            // 
            // reloadDataGridViewTextBoxColumn
            // 
            this.reloadDataGridViewTextBoxColumn.DataPropertyName = "Reload";
            this.reloadDataGridViewTextBoxColumn.HeaderText = "Reload";
            this.reloadDataGridViewTextBoxColumn.MinimumWidth = 10;
            this.reloadDataGridViewTextBoxColumn.Name = "reloadDataGridViewTextBoxColumn";
            this.reloadDataGridViewTextBoxColumn.Width = 200;
            // 
            // heroBindingSource
            // 
            this.heroBindingSource.DataSource = typeof(ClassLibrary1.Hero);
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(1048, 12);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(180, 76);
            this.buttonSave.TabIndex = 1;
            this.buttonSave.Text = "Save changes";
            this.buttonSave.UseVisualStyleBackColor = true;
            // 
            // dpsTextBoxTo
            // 
            this.dpsTextBoxTo.Location = new System.Drawing.Point(1154, 296);
            this.dpsTextBoxTo.Name = "dpsTextBoxTo";
            this.dpsTextBoxTo.Size = new System.Drawing.Size(76, 31);
            this.dpsTextBoxTo.TabIndex = 8;
            this.dpsTextBoxTo.Text = "525";
            // 
            // dpsTextBoxFrom
            // 
            this.dpsTextBoxFrom.Location = new System.Drawing.Point(1048, 296);
            this.dpsTextBoxFrom.Name = "dpsTextBoxFrom";
            this.dpsTextBoxFrom.Size = new System.Drawing.Size(76, 31);
            this.dpsTextBoxFrom.TabIndex = 7;
            this.dpsTextBoxFrom.Text = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(1043, 250);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(205, 25);
            this.label1.TabIndex = 6;
            this.label1.Text = "Damage per second";
            // 
            // lifeTextBoxTo
            // 
            this.lifeTextBoxTo.Location = new System.Drawing.Point(1154, 404);
            this.lifeTextBoxTo.Name = "lifeTextBoxTo";
            this.lifeTextBoxTo.Size = new System.Drawing.Size(76, 31);
            this.lifeTextBoxTo.TabIndex = 11;
            this.lifeTextBoxTo.Text = "800";
            // 
            // lifeTextBoxFrom
            // 
            this.lifeTextBoxFrom.Location = new System.Drawing.Point(1048, 404);
            this.lifeTextBoxFrom.Name = "lifeTextBoxFrom";
            this.lifeTextBoxFrom.Size = new System.Drawing.Size(76, 31);
            this.lifeTextBoxFrom.TabIndex = 10;
            this.lifeTextBoxFrom.Text = "0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(1045, 356);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 25);
            this.label2.TabIndex = 9;
            this.label2.Text = "Life";
            // 
            // headshotTextBoxTo
            // 
            this.headshotTextBoxTo.Location = new System.Drawing.Point(1154, 504);
            this.headshotTextBoxTo.Name = "headshotTextBoxTo";
            this.headshotTextBoxTo.Size = new System.Drawing.Size(76, 31);
            this.headshotTextBoxTo.TabIndex = 14;
            this.headshotTextBoxTo.Text = "1050";
            // 
            // headshotTextBoxFrom
            // 
            this.headshotTextBoxFrom.Location = new System.Drawing.Point(1050, 504);
            this.headshotTextBoxFrom.Name = "headshotTextBoxFrom";
            this.headshotTextBoxFrom.Size = new System.Drawing.Size(76, 31);
            this.headshotTextBoxFrom.TabIndex = 13;
            this.headshotTextBoxFrom.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(1045, 456);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(142, 25);
            this.label3.TabIndex = 12;
            this.label3.Text = "HeadshotDps";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(1108, 122);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 25);
            this.label4.TabIndex = 15;
            this.label4.Text = "Filters";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(1053, 184);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 25);
            this.label5.TabIndex = 16;
            this.label5.Text = "from";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(1179, 184);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(30, 25);
            this.label6.TabIndex = 17;
            this.label6.Text = "to";
            // 
            // buttonApplyFilters
            // 
            this.buttonApplyFilters.Location = new System.Drawing.Point(1048, 578);
            this.buttonApplyFilters.Name = "buttonApplyFilters";
            this.buttonApplyFilters.Size = new System.Drawing.Size(200, 54);
            this.buttonApplyFilters.TabIndex = 18;
            this.buttonApplyFilters.Text = "Apply filters";
            this.buttonApplyFilters.UseVisualStyleBackColor = true;
            this.buttonApplyFilters.Click += new System.EventHandler(this.buttonApplyFilters_Click);
            // 
            // buttonReturnTable
            // 
            this.buttonReturnTable.Location = new System.Drawing.Point(1031, 668);
            this.buttonReturnTable.Name = "buttonReturnTable";
            this.buttonReturnTable.Size = new System.Drawing.Size(255, 74);
            this.buttonReturnTable.TabIndex = 19;
            this.buttonReturnTable.Text = "Return not filtered table";
            this.buttonReturnTable.UseVisualStyleBackColor = true;
            this.buttonReturnTable.Click += new System.EventHandler(this.buttonReturnTable_Click);
            // 
            // buttonStart
            // 
            this.buttonStart.Location = new System.Drawing.Point(1031, 766);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(254, 75);
            this.buttonStart.TabIndex = 20;
            this.buttonStart.Text = "Return to menu";
            this.buttonStart.UseVisualStyleBackColor = true;
            this.buttonStart.Click += new System.EventHandler(this.buttonStart_Click);
            // 
            // HeroTable
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1306, 1042);
            this.Controls.Add(this.buttonStart);
            this.Controls.Add(this.buttonReturnTable);
            this.Controls.Add(this.buttonApplyFilters);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.headshotTextBoxTo);
            this.Controls.Add(this.headshotTextBoxFrom);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lifeTextBoxTo);
            this.Controls.Add(this.lifeTextBoxFrom);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dpsTextBoxTo);
            this.Controls.Add(this.dpsTextBoxFrom);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.dataGridView1);
            this.Name = "HeroTable";
            this.Text = "Heroes table";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.heroBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn damagePerSecondDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn headshotDPSDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn singleShotDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lifeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn reloadDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource heroBindingSource;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.TextBox dpsTextBoxTo;
        private System.Windows.Forms.TextBox dpsTextBoxFrom;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox lifeTextBoxTo;
        private System.Windows.Forms.TextBox lifeTextBoxFrom;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox headshotTextBoxTo;
        private System.Windows.Forms.TextBox headshotTextBoxFrom;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button buttonApplyFilters;
        private System.Windows.Forms.Button buttonReturnTable;
        private System.Windows.Forms.Button buttonStart;
    }
}