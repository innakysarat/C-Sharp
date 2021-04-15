namespace Overwatch_1
{
    partial class ToHide
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
            this.hide = new System.Windows.Forms.Button();
            this.exit = new System.Windows.Forms.Button();
            this.lblName = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // hide
            // 
            this.hide.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.hide.BackColor = System.Drawing.Color.Green;
            this.hide.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.hide.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.hide.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.hide.Location = new System.Drawing.Point(613, 34);
            this.hide.Name = "hide";
            this.hide.Size = new System.Drawing.Size(67, 26);
            this.hide.TabIndex = 3;
            this.hide.Text = "-";
            this.hide.UseVisualStyleBackColor = false;
            this.hide.Click += new System.EventHandler(this.hide_Click);
            // 
            // exit
            // 
            this.exit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.exit.BackColor = System.Drawing.Color.Red;
            this.exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exit.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.exit.Location = new System.Drawing.Point(686, 34);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(67, 26);
            this.exit.TabIndex = 4;
            this.exit.Text = "X";
            this.exit.UseVisualStyleBackColor = false;
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.BackColor = System.Drawing.Color.Transparent;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblName.Location = new System.Drawing.Point(29, 34);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(65, 25);
            this.lblName.TabIndex = 5;
            this.lblName.Text = "Game";
            // 
            // ToHide
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.exit);
            this.Controls.Add(this.hide);
            this.Name = "ToHide";
            this.Size = new System.Drawing.Size(773, 86);
            this.Load += new System.EventHandler(this.ToHide_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ToHide_MouseDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button hide;
        private System.Windows.Forms.Button exit;
        private System.Windows.Forms.Label lblName;
    }
}
