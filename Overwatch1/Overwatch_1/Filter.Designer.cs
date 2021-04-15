namespace Overwatch_1
{
    partial class Filter
    {
        /// <summary> 
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.comboFilter = new System.Windows.Forms.ComboBox();
            this.comboFrom = new System.Windows.Forms.ComboBox();
            this.comboTo = new System.Windows.Forms.ComboBox();
            this.lblFilter = new System.Windows.Forms.Label();
            this.lblFrom = new System.Windows.Forms.Label();
            this.lblTo = new System.Windows.Forms.Label();
            this.btnFilter = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // comboFilter
            // 
            this.comboFilter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboFilter.FormattingEnabled = true;
            this.comboFilter.Location = new System.Drawing.Point(132, 79);
            this.comboFilter.Name = "comboFilter";
            this.comboFilter.Size = new System.Drawing.Size(169, 24);
            this.comboFilter.TabIndex = 5;
            this.comboFilter.SelectedIndexChanged += new System.EventHandler(this.comboFilter_SelectedIndexChanged);
            // 
            // comboFrom
            // 
            this.comboFrom.FormattingEnabled = true;
            this.comboFrom.Location = new System.Drawing.Point(349, 80);
            this.comboFrom.Name = "comboFrom";
            this.comboFrom.Size = new System.Drawing.Size(154, 24);
            this.comboFrom.TabIndex = 6;
            this.comboFrom.TextUpdate += new System.EventHandler(this.comboFrom_TextUpdate);
            // 
            // comboTo
            // 
            this.comboTo.FormattingEnabled = true;
            this.comboTo.Location = new System.Drawing.Point(535, 80);
            this.comboTo.Name = "comboTo";
            this.comboTo.Size = new System.Drawing.Size(154, 24);
            this.comboTo.TabIndex = 7;
            // 
            // lblFilter
            // 
            this.lblFilter.AutoSize = true;
            this.lblFilter.Location = new System.Drawing.Point(68, 82);
            this.lblFilter.Name = "lblFilter";
            this.lblFilter.Size = new System.Drawing.Size(58, 17);
            this.lblFilter.TabIndex = 8;
            this.lblFilter.Text = "Filter by";
            // 
            // lblFrom
            // 
            this.lblFrom.AutoSize = true;
            this.lblFrom.Location = new System.Drawing.Point(307, 83);
            this.lblFrom.Name = "lblFrom";
            this.lblFrom.Size = new System.Drawing.Size(36, 17);
            this.lblFrom.TabIndex = 9;
            this.lblFrom.Text = "from";
            // 
            // lblTo
            // 
            this.lblTo.AutoSize = true;
            this.lblTo.Location = new System.Drawing.Point(509, 83);
            this.lblTo.Name = "lblTo";
            this.lblTo.Size = new System.Drawing.Size(20, 17);
            this.lblTo.TabIndex = 10;
            this.lblTo.Text = "to";
            // 
            // btnFilter
            // 
            this.btnFilter.Location = new System.Drawing.Point(693, 73);
            this.btnFilter.Name = "btnFilter";
            this.btnFilter.Size = new System.Drawing.Size(89, 36);
            this.btnFilter.TabIndex = 11;
            this.btnFilter.Text = "filter";
            this.btnFilter.UseVisualStyleBackColor = true;
            this.btnFilter.Click += new System.EventHandler(this.btnFilter_Click);
            // 
            // Filter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnFilter);
            this.Controls.Add(this.lblTo);
            this.Controls.Add(this.lblFrom);
            this.Controls.Add(this.lblFilter);
            this.Controls.Add(this.comboTo);
            this.Controls.Add(this.comboFrom);
            this.Controls.Add(this.comboFilter);
            this.Name = "Filter";
            this.Size = new System.Drawing.Size(873, 195);
            this.Load += new System.EventHandler(this.Filter_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox comboFilter;
        private System.Windows.Forms.ComboBox comboFrom;
        private System.Windows.Forms.ComboBox comboTo;
        private System.Windows.Forms.Label lblFilter;
        private System.Windows.Forms.Label lblFrom;
        private System.Windows.Forms.Label lblTo;
        private System.Windows.Forms.Button btnFilter;
    }
}
