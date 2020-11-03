namespace Frameworks_Q2
{
    partial class Form1
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.rainfallDataGrid = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.driestYrButton = new System.Windows.Forms.Button();
            this.driestYrText = new System.Windows.Forms.TextBox();
            this.wettestYrText = new System.Windows.Forms.TextBox();
            this.wettestYrButton = new System.Windows.Forms.Button();
            this.driestSsText = new System.Windows.Forms.TextBox();
            this.driestSsButton = new System.Windows.Forms.Button();
            this.wettestSsText = new System.Windows.Forms.TextBox();
            this.wettestSsButton = new System.Windows.Forms.Button();
            this.totalRainfallText = new System.Windows.Forms.TextBox();
            this.yearCombo = new System.Windows.Forms.ComboBox();
            this.seasonCombo = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.addYear = new System.Windows.Forms.Button();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.yearInput = new System.Windows.Forms.TextBox();
            this.springInput = new System.Windows.Forms.TextBox();
            this.summerInput = new System.Windows.Forms.TextBox();
            this.autumnInput = new System.Windows.Forms.TextBox();
            this.winterInput = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.rainfallDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // rainfallDataGrid
            // 
            this.rainfallDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.rainfallDataGrid.Location = new System.Drawing.Point(29, 50);
            this.rainfallDataGrid.Name = "rainfallDataGrid";
            this.rainfallDataGrid.Size = new System.Drawing.Size(828, 184);
            this.rainfallDataGrid.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.label1.Location = new System.Drawing.Point(25, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(153, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "Seasonal Rainfall";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.label2.Location = new System.Drawing.Point(536, 335);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(300, 24);
            this.label2.TabIndex = 2;
            this.label2.Text = "Rainfall Calculator: Choose options";
            // 
            // driestYrButton
            // 
            this.driestYrButton.Location = new System.Drawing.Point(29, 305);
            this.driestYrButton.Name = "driestYrButton";
            this.driestYrButton.Size = new System.Drawing.Size(95, 23);
            this.driestYrButton.TabIndex = 3;
            this.driestYrButton.Text = "Driest Year";
            this.driestYrButton.UseVisualStyleBackColor = true;
            this.driestYrButton.Click += new System.EventHandler(this.driestYear_click);
            // 
            // driestYrText
            // 
            this.driestYrText.Location = new System.Drawing.Point(130, 307);
            this.driestYrText.Name = "driestYrText";
            this.driestYrText.Size = new System.Drawing.Size(235, 20);
            this.driestYrText.TabIndex = 4;
            // 
            // wettestYrText
            // 
            this.wettestYrText.Location = new System.Drawing.Point(130, 365);
            this.wettestYrText.Name = "wettestYrText";
            this.wettestYrText.Size = new System.Drawing.Size(235, 20);
            this.wettestYrText.TabIndex = 6;
            // 
            // wettestYrButton
            // 
            this.wettestYrButton.Location = new System.Drawing.Point(29, 363);
            this.wettestYrButton.Name = "wettestYrButton";
            this.wettestYrButton.Size = new System.Drawing.Size(95, 23);
            this.wettestYrButton.TabIndex = 5;
            this.wettestYrButton.Text = "Wettest Year";
            this.wettestYrButton.UseVisualStyleBackColor = true;
            this.wettestYrButton.Click += new System.EventHandler(this.wettestYear_click);
            // 
            // driestSsText
            // 
            this.driestSsText.Location = new System.Drawing.Point(130, 421);
            this.driestSsText.Name = "driestSsText";
            this.driestSsText.Size = new System.Drawing.Size(235, 20);
            this.driestSsText.TabIndex = 8;
            // 
            // driestSsButton
            // 
            this.driestSsButton.Location = new System.Drawing.Point(29, 419);
            this.driestSsButton.Name = "driestSsButton";
            this.driestSsButton.Size = new System.Drawing.Size(95, 23);
            this.driestSsButton.TabIndex = 7;
            this.driestSsButton.Text = "Driest Season";
            this.driestSsButton.UseVisualStyleBackColor = true;
            this.driestSsButton.Click += new System.EventHandler(this.driestSeason_click);
            // 
            // wettestSsText
            // 
            this.wettestSsText.Location = new System.Drawing.Point(130, 477);
            this.wettestSsText.Name = "wettestSsText";
            this.wettestSsText.Size = new System.Drawing.Size(235, 20);
            this.wettestSsText.TabIndex = 10;
            // 
            // wettestSsButton
            // 
            this.wettestSsButton.Location = new System.Drawing.Point(29, 475);
            this.wettestSsButton.Name = "wettestSsButton";
            this.wettestSsButton.Size = new System.Drawing.Size(95, 23);
            this.wettestSsButton.TabIndex = 9;
            this.wettestSsButton.Text = "Wettest Season";
            this.wettestSsButton.UseVisualStyleBackColor = true;
            this.wettestSsButton.Click += new System.EventHandler(this.wettestSeason_click);
            // 
            // totalRainfallText
            // 
            this.totalRainfallText.Location = new System.Drawing.Point(534, 434);
            this.totalRainfallText.Name = "totalRainfallText";
            this.totalRainfallText.Size = new System.Drawing.Size(311, 20);
            this.totalRainfallText.TabIndex = 11;
            // 
            // yearCombo
            // 
            this.yearCombo.FormattingEnabled = true;
            this.yearCombo.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.yearCombo.Location = new System.Drawing.Point(534, 389);
            this.yearCombo.Name = "yearCombo";
            this.yearCombo.Size = new System.Drawing.Size(121, 21);
            this.yearCombo.TabIndex = 13;
            this.yearCombo.Text = "All Years";
            this.yearCombo.SelectedIndexChanged += new System.EventHandler(this.displayTotalRainfall);
            // 
            // seasonCombo
            // 
            this.seasonCombo.FormattingEnabled = true;
            this.seasonCombo.Location = new System.Drawing.Point(724, 388);
            this.seasonCombo.Name = "seasonCombo";
            this.seasonCombo.Size = new System.Drawing.Size(121, 21);
            this.seasonCombo.TabIndex = 14;
            this.seasonCombo.Text = "All Seasons";
            this.seasonCombo.SelectedIndexChanged += new System.EventHandler(this.displayTotalRainfall);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(531, 373);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 13);
            this.label3.TabIndex = 15;
            this.label3.Text = "Year";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(724, 369);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 13);
            this.label4.TabIndex = 16;
            this.label4.Text = "Season";
            // 
            // addYear
            // 
            this.addYear.Location = new System.Drawing.Point(730, 257);
            this.addYear.Name = "addYear";
            this.addYear.Size = new System.Drawing.Size(127, 23);
            this.addYear.TabIndex = 17;
            this.addYear.Text = "Add Year Data";
            this.addYear.UseVisualStyleBackColor = true;
            this.addYear.Click += new System.EventHandler(this.addYear_Click);
            // 
            // yearInput
            // 
            this.yearInput.Location = new System.Drawing.Point(29, 260);
            this.yearInput.Name = "yearInput";
            this.yearInput.Size = new System.Drawing.Size(100, 20);
            this.yearInput.TabIndex = 18;
            this.yearInput.Tag = "";
            // 
            // springInput
            // 
            this.springInput.Location = new System.Drawing.Point(162, 260);
            this.springInput.Name = "springInput";
            this.springInput.Size = new System.Drawing.Size(100, 20);
            this.springInput.TabIndex = 19;
            // 
            // summerInput
            // 
            this.summerInput.Location = new System.Drawing.Point(295, 260);
            this.summerInput.Name = "summerInput";
            this.summerInput.Size = new System.Drawing.Size(100, 20);
            this.summerInput.TabIndex = 20;
            // 
            // autumnInput
            // 
            this.autumnInput.Location = new System.Drawing.Point(439, 260);
            this.autumnInput.Name = "autumnInput";
            this.autumnInput.Size = new System.Drawing.Size(100, 20);
            this.autumnInput.TabIndex = 21;
            // 
            // winterInput
            // 
            this.winterInput.Location = new System.Drawing.Point(590, 260);
            this.winterInput.Name = "winterInput";
            this.winterInput.Size = new System.Drawing.Size(100, 20);
            this.winterInput.TabIndex = 22;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(26, 244);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 13);
            this.label5.TabIndex = 23;
            this.label5.Text = "Year";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(159, 244);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(37, 13);
            this.label6.TabIndex = 24;
            this.label6.Text = "Spring";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(292, 244);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(45, 13);
            this.label7.TabIndex = 25;
            this.label7.Text = "Summer";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(436, 244);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(43, 13);
            this.label8.TabIndex = 26;
            this.label8.Text = "Autumn";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(587, 244);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(38, 13);
            this.label9.TabIndex = 27;
            this.label9.Text = "Winter";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(920, 528);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.winterInput);
            this.Controls.Add(this.autumnInput);
            this.Controls.Add(this.summerInput);
            this.Controls.Add(this.springInput);
            this.Controls.Add(this.yearInput);
            this.Controls.Add(this.addYear);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.seasonCombo);
            this.Controls.Add(this.yearCombo);
            this.Controls.Add(this.totalRainfallText);
            this.Controls.Add(this.wettestSsText);
            this.Controls.Add(this.wettestSsButton);
            this.Controls.Add(this.driestSsText);
            this.Controls.Add(this.driestSsButton);
            this.Controls.Add(this.wettestYrText);
            this.Controls.Add(this.wettestYrButton);
            this.Controls.Add(this.driestYrText);
            this.Controls.Add(this.driestYrButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.rainfallDataGrid);
            this.Name = "Form1";
            this.Text = "Rainfalls";
            ((System.ComponentModel.ISupportInitialize)(this.rainfallDataGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView rainfallDataGrid;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button driestYrButton;
        private System.Windows.Forms.TextBox driestYrText;
        private System.Windows.Forms.TextBox wettestYrText;
        private System.Windows.Forms.Button wettestYrButton;
        private System.Windows.Forms.TextBox driestSsText;
        private System.Windows.Forms.Button driestSsButton;
        private System.Windows.Forms.TextBox wettestSsText;
        private System.Windows.Forms.Button wettestSsButton;
        private System.Windows.Forms.TextBox totalRainfallText;
        private System.Windows.Forms.ComboBox yearCombo;
        private System.Windows.Forms.ComboBox seasonCombo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button addYear;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.TextBox yearInput;
        private System.Windows.Forms.TextBox springInput;
        private System.Windows.Forms.TextBox summerInput;
        private System.Windows.Forms.TextBox autumnInput;
        private System.Windows.Forms.TextBox winterInput;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
    }
}

