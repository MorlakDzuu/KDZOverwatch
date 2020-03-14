namespace WindowsFormsApp1
{
    partial class ChooseHeroForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.panelHero = new System.Windows.Forms.Panel();
            this.labelReload = new System.Windows.Forms.Label();
            this.labelLife = new System.Windows.Forms.Label();
            this.labelSingleShot = new System.Windows.Forms.Label();
            this.labelHeadshotDPS = new System.Windows.Forms.Label();
            this.labelDamagePerSecond = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.labelNameHero = new System.Windows.Forms.Label();
            this.buttonAccept = new System.Windows.Forms.Button();
            this.panelHero.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Info;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 28.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(343, 100);
            this.label1.TabIndex = 0;
            this.label1.Text = "Player 1";
            // 
            // comboBox1
            // 
            this.comboBox1.BackColor = System.Drawing.SystemColors.Info;
            this.comboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(12, 144);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(413, 50);
            this.comboBox1.TabIndex = 1;
            this.comboBox1.Text = "Choose your hero";
            // 
            // panelHero
            // 
            this.panelHero.BackColor = System.Drawing.SystemColors.Info;
            this.panelHero.Controls.Add(this.labelReload);
            this.panelHero.Controls.Add(this.labelLife);
            this.panelHero.Controls.Add(this.labelSingleShot);
            this.panelHero.Controls.Add(this.labelHeadshotDPS);
            this.panelHero.Controls.Add(this.labelDamagePerSecond);
            this.panelHero.Controls.Add(this.label6);
            this.panelHero.Controls.Add(this.label5);
            this.panelHero.Controls.Add(this.label4);
            this.panelHero.Controls.Add(this.label3);
            this.panelHero.Controls.Add(this.label2);
            this.panelHero.Controls.Add(this.labelNameHero);
            this.panelHero.Location = new System.Drawing.Point(625, 144);
            this.panelHero.Name = "panelHero";
            this.panelHero.Size = new System.Drawing.Size(718, 614);
            this.panelHero.TabIndex = 3;
            this.panelHero.Visible = false;
            // 
            // labelReload
            // 
            this.labelReload.AutoSize = true;
            this.labelReload.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelReload.Location = new System.Drawing.Point(520, 511);
            this.labelReload.Name = "labelReload";
            this.labelReload.Size = new System.Drawing.Size(39, 42);
            this.labelReload.TabIndex = 10;
            this.labelReload.Text = "0";
            // 
            // labelLife
            // 
            this.labelLife.AutoSize = true;
            this.labelLife.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelLife.Location = new System.Drawing.Point(520, 421);
            this.labelLife.Name = "labelLife";
            this.labelLife.Size = new System.Drawing.Size(39, 42);
            this.labelLife.TabIndex = 9;
            this.labelLife.Text = "0";
            // 
            // labelSingleShot
            // 
            this.labelSingleShot.AutoSize = true;
            this.labelSingleShot.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelSingleShot.Location = new System.Drawing.Point(520, 344);
            this.labelSingleShot.Name = "labelSingleShot";
            this.labelSingleShot.Size = new System.Drawing.Size(39, 42);
            this.labelSingleShot.TabIndex = 8;
            this.labelSingleShot.Text = "0";
            // 
            // labelHeadshotDPS
            // 
            this.labelHeadshotDPS.AutoSize = true;
            this.labelHeadshotDPS.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelHeadshotDPS.Location = new System.Drawing.Point(520, 251);
            this.labelHeadshotDPS.Name = "labelHeadshotDPS";
            this.labelHeadshotDPS.Size = new System.Drawing.Size(39, 42);
            this.labelHeadshotDPS.TabIndex = 7;
            this.labelHeadshotDPS.Text = "0";
            // 
            // labelDamagePerSecond
            // 
            this.labelDamagePerSecond.AutoSize = true;
            this.labelDamagePerSecond.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelDamagePerSecond.Location = new System.Drawing.Point(520, 172);
            this.labelDamagePerSecond.Name = "labelDamagePerSecond";
            this.labelDamagePerSecond.Size = new System.Drawing.Size(39, 42);
            this.labelDamagePerSecond.TabIndex = 6;
            this.labelDamagePerSecond.Text = "0";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(57, 502);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(159, 51);
            this.label6.TabIndex = 5;
            this.label6.Text = "Reload";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(57, 415);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(92, 51);
            this.label5.TabIndex = 4;
            this.label5.Text = "Life";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(57, 335);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(236, 51);
            this.label4.TabIndex = 3;
            this.label4.Text = "Single shot";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(57, 251);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(307, 51);
            this.label3.TabIndex = 2;
            this.label3.Text = "Headshot DPS";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(57, 164);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(409, 51);
            this.label2.TabIndex = 1;
            this.label2.Text = "Damage per second";
            // 
            // labelNameHero
            // 
            this.labelNameHero.AutoSize = true;
            this.labelNameHero.Font = new System.Drawing.Font("Microsoft YaHei", 19.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelNameHero.Location = new System.Drawing.Point(54, 50);
            this.labelNameHero.Name = "labelNameHero";
            this.labelNameHero.Size = new System.Drawing.Size(427, 68);
            this.labelNameHero.TabIndex = 0;
            this.labelNameHero.Text = "labelNameHero";
            // 
            // buttonAccept
            // 
            this.buttonAccept.BackColor = System.Drawing.SystemColors.Info;
            this.buttonAccept.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonAccept.Location = new System.Drawing.Point(12, 634);
            this.buttonAccept.Name = "buttonAccept";
            this.buttonAccept.Size = new System.Drawing.Size(413, 124);
            this.buttonAccept.TabIndex = 4;
            this.buttonAccept.Text = "Accept";
            this.buttonAccept.UseVisualStyleBackColor = false;
            this.buttonAccept.Click += new System.EventHandler(this.buttonAccept_Click);
            // 
            // ChooseHeroForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.OverwatchBackgroundImage;
            this.ClientSize = new System.Drawing.Size(1626, 806);
            this.Controls.Add(this.buttonAccept);
            this.Controls.Add(this.panelHero);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label1);
            this.Name = "ChooseHeroForm";
            this.Text = "Form3";
            this.panelHero.ResumeLayout(false);
            this.panelHero.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Panel panelHero;
        private System.Windows.Forms.Label labelReload;
        private System.Windows.Forms.Label labelLife;
        private System.Windows.Forms.Label labelSingleShot;
        private System.Windows.Forms.Label labelHeadshotDPS;
        private System.Windows.Forms.Label labelDamagePerSecond;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelNameHero;
        private System.Windows.Forms.Button buttonAccept;
    }
}