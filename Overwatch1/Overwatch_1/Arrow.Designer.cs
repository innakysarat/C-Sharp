namespace Overwatch_1
{
    partial class Arrow
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
            lblArrow = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblArrow
            // 
            lblArrow.Dock = System.Windows.Forms.DockStyle.Fill;
            lblArrow.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            lblArrow.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            lblArrow.Location = new System.Drawing.Point(0, 0);
            lblArrow.Name = "lblArrow";
            lblArrow.Size = new System.Drawing.Size(219, 226);
            lblArrow.TabIndex = 0;
            lblArrow.Text = "🠔\r\n";
            lblArrow.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Arrow
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.Controls.Add(lblArrow);
            this.Name = "Arrow";
            this.Size = new System.Drawing.Size(219, 226);
            this.ResumeLayout(false);

        }

        #endregion

        private static System.Windows.Forms.Label lblArrow;
    }
}
