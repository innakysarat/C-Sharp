namespace Overwatch_1
{
    partial class AttackBuuton
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
            this.button1 = new System.Windows.Forms.Button();
            this.cbxAim = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(78, 64);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(127, 57);
            this.button1.TabIndex = 0;
            this.button1.Text = "Attack";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // cbxAim
            // 
            this.cbxAim.AutoSize = true;
            this.cbxAim.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.cbxAim.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cbxAim.Location = new System.Drawing.Point(105, 25);
            this.cbxAim.Name = "cbxAim";
            this.cbxAim.Size = new System.Drawing.Size(79, 33);
            this.cbxAim.TabIndex = 1;
            this.cbxAim.Text = "Aim";
            this.cbxAim.UseVisualStyleBackColor = false;
            // 
            // AttackBuuton
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.cbxAim);
            this.Controls.Add(this.button1);
            this.Name = "AttackBuuton";
            this.Size = new System.Drawing.Size(303, 177);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.CheckBox cbxAim;
    }
}
