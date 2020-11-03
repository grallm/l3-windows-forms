namespace Frameworks_PartB
{
    partial class AppForm
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
            this.empName = new System.Windows.Forms.TextBox();
            this.empNameLabel = new System.Windows.Forms.Label();
            this.empTypeLabel = new System.Windows.Forms.Label();
            this.empType = new System.Windows.Forms.TextBox();
            this.empYrsLabel = new System.Windows.Forms.Label();
            this.empYrs = new System.Windows.Forms.TextBox();
            this.empSalaryLabel = new System.Windows.Forms.Label();
            this.empSalary = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.employeesListBox = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dispEmpSalary = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dispEmpYrs = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dispEmpType = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dispEmpName = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.dispEmpNumber = new System.Windows.Forms.TextBox();
            this.canPrescribe = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // empName
            // 
            this.empName.Location = new System.Drawing.Point(72, 82);
            this.empName.Name = "empName";
            this.empName.Size = new System.Drawing.Size(149, 20);
            this.empName.TabIndex = 0;
            // 
            // empNameLabel
            // 
            this.empNameLabel.AutoSize = true;
            this.empNameLabel.Location = new System.Drawing.Point(69, 66);
            this.empNameLabel.Name = "empNameLabel";
            this.empNameLabel.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.empNameLabel.Size = new System.Drawing.Size(35, 13);
            this.empNameLabel.TabIndex = 1;
            this.empNameLabel.Text = "Name";
            // 
            // empTypeLabel
            // 
            this.empTypeLabel.AutoSize = true;
            this.empTypeLabel.Location = new System.Drawing.Point(69, 130);
            this.empTypeLabel.Name = "empTypeLabel";
            this.empTypeLabel.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.empTypeLabel.Size = new System.Drawing.Size(31, 13);
            this.empTypeLabel.TabIndex = 3;
            this.empTypeLabel.Text = "Type";
            // 
            // empType
            // 
            this.empType.Location = new System.Drawing.Point(72, 146);
            this.empType.Name = "empType";
            this.empType.Size = new System.Drawing.Size(149, 20);
            this.empType.TabIndex = 2;
            // 
            // empYrsLabel
            // 
            this.empYrsLabel.AutoSize = true;
            this.empYrsLabel.Location = new System.Drawing.Point(69, 198);
            this.empYrsLabel.Name = "empYrsLabel";
            this.empYrsLabel.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.empYrsLabel.Size = new System.Drawing.Size(71, 13);
            this.empYrsLabel.TabIndex = 5;
            this.empYrsLabel.Text = "Years service";
            // 
            // empYrs
            // 
            this.empYrs.ForeColor = System.Drawing.SystemColors.WindowText;
            this.empYrs.Location = new System.Drawing.Point(72, 214);
            this.empYrs.Name = "empYrs";
            this.empYrs.Size = new System.Drawing.Size(149, 20);
            this.empYrs.TabIndex = 4;
            // 
            // empSalaryLabel
            // 
            this.empSalaryLabel.AutoSize = true;
            this.empSalaryLabel.Location = new System.Drawing.Point(69, 263);
            this.empSalaryLabel.Name = "empSalaryLabel";
            this.empSalaryLabel.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.empSalaryLabel.Size = new System.Drawing.Size(36, 13);
            this.empSalaryLabel.TabIndex = 7;
            this.empSalaryLabel.Text = "Salary";
            // 
            // empSalary
            // 
            this.empSalary.Location = new System.Drawing.Point(72, 279);
            this.empSalary.Name = "empSalary";
            this.empSalary.Size = new System.Drawing.Size(149, 20);
            this.empSalary.TabIndex = 6;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(72, 334);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 41);
            this.button1.TabIndex = 8;
            this.button1.Text = "Add Employee";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.addEmployee_Click);
            // 
            // employeesListBox
            // 
            this.employeesListBox.FormattingEnabled = true;
            this.employeesListBox.Location = new System.Drawing.Point(288, 82);
            this.employeesListBox.Name = "employeesListBox";
            this.employeesListBox.Size = new System.Drawing.Size(209, 290);
            this.employeesListBox.TabIndex = 9;
            this.employeesListBox.SelectedIndexChanged += new System.EventHandler(this.employeesListBox_SelectedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(535, 328);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label1.Size = new System.Drawing.Size(36, 13);
            this.label1.TabIndex = 17;
            this.label1.Text = "Salary";
            // 
            // dispEmpSalary
            // 
            this.dispEmpSalary.Location = new System.Drawing.Point(538, 344);
            this.dispEmpSalary.Name = "dispEmpSalary";
            this.dispEmpSalary.ReadOnly = true;
            this.dispEmpSalary.Size = new System.Drawing.Size(192, 20);
            this.dispEmpSalary.TabIndex = 16;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(535, 263);
            this.label2.Name = "label2";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label2.Size = new System.Drawing.Size(71, 13);
            this.label2.TabIndex = 15;
            this.label2.Text = "Years service";
            // 
            // dispEmpYrs
            // 
            this.dispEmpYrs.Location = new System.Drawing.Point(538, 279);
            this.dispEmpYrs.Name = "dispEmpYrs";
            this.dispEmpYrs.ReadOnly = true;
            this.dispEmpYrs.Size = new System.Drawing.Size(192, 20);
            this.dispEmpYrs.TabIndex = 14;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(535, 195);
            this.label3.Name = "label3";
            this.label3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label3.Size = new System.Drawing.Size(31, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "Type";
            // 
            // dispEmpType
            // 
            this.dispEmpType.Location = new System.Drawing.Point(538, 211);
            this.dispEmpType.Name = "dispEmpType";
            this.dispEmpType.ReadOnly = true;
            this.dispEmpType.Size = new System.Drawing.Size(192, 20);
            this.dispEmpType.TabIndex = 12;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(535, 66);
            this.label4.Name = "label4";
            this.label4.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Name";
            // 
            // dispEmpName
            // 
            this.dispEmpName.Location = new System.Drawing.Point(538, 82);
            this.dispEmpName.Name = "dispEmpName";
            this.dispEmpName.ReadOnly = true;
            this.dispEmpName.Size = new System.Drawing.Size(192, 20);
            this.dispEmpName.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(535, 130);
            this.label5.Name = "label5";
            this.label5.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label5.Size = new System.Drawing.Size(44, 13);
            this.label5.TabIndex = 19;
            this.label5.Text = "Number";
            // 
            // dispEmpNumber
            // 
            this.dispEmpNumber.Location = new System.Drawing.Point(538, 146);
            this.dispEmpNumber.Name = "dispEmpNumber";
            this.dispEmpNumber.ReadOnly = true;
            this.dispEmpNumber.Size = new System.Drawing.Size(192, 20);
            this.dispEmpNumber.TabIndex = 18;
            // 
            // canPrescribe
            // 
            this.canPrescribe.AutoSize = true;
            this.canPrescribe.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.canPrescribe.Location = new System.Drawing.Point(510, 32);
            this.canPrescribe.Name = "canPrescribe";
            this.canPrescribe.Size = new System.Drawing.Size(255, 24);
            this.canPrescribe.TabIndex = 20;
            this.canPrescribe.Text = "I can PRESCRIBE for patients";
            this.canPrescribe.Visible = false;
            this.canPrescribe.Click += new System.EventHandler(this.label6_Click);
            // 
            // AppForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(849, 450);
            this.Controls.Add(this.canPrescribe);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dispEmpNumber);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dispEmpSalary);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dispEmpYrs);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dispEmpType);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dispEmpName);
            this.Controls.Add(this.employeesListBox);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.empSalaryLabel);
            this.Controls.Add(this.empSalary);
            this.Controls.Add(this.empYrsLabel);
            this.Controls.Add(this.empYrs);
            this.Controls.Add(this.empTypeLabel);
            this.Controls.Add(this.empType);
            this.Controls.Add(this.empNameLabel);
            this.Controls.Add(this.empName);
            this.Name = "AppForm";
            this.Text = "Employees";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox empName;
        private System.Windows.Forms.Label empNameLabel;
        private System.Windows.Forms.Label empTypeLabel;
        private System.Windows.Forms.TextBox empType;
        private System.Windows.Forms.Label empYrsLabel;
        private System.Windows.Forms.TextBox empYrs;
        private System.Windows.Forms.Label empSalaryLabel;
        private System.Windows.Forms.TextBox empSalary;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListBox employeesListBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox dispEmpSalary;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox dispEmpYrs;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox dispEmpType;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox dispEmpName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox dispEmpNumber;
        private System.Windows.Forms.Label canPrescribe;
    }
}

