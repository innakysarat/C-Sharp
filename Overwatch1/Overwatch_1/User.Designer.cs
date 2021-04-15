namespace Overwatch_1
{
    partial class User
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
            this.lblLife = new System.Windows.Forms.Label();
            this.lblDPS = new System.Windows.Forms.Label();
            this.lblSS = new System.Windows.Forms.Label();
            this.lblHeroes = new System.Windows.Forms.Label();
            this.lblHeadShot = new System.Windows.Forms.Label();
            this.lblReload = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblLife
            // 
            this.lblLife.AutoSize = true;
            this.lblLife.Location = new System.Drawing.Point(23, 56);
            this.lblLife.Name = "lblLife";
            this.lblLife.Size = new System.Drawing.Size(39, 24);
            this.lblLife.TabIndex = 0;
            this.lblLife.Text = "Life";
            // 
            // lblDPS
            // 
            this.lblDPS.AutoSize = true;
            this.lblDPS.Location = new System.Drawing.Point(23, 93);
            this.lblDPS.Name = "lblDPS";
            this.lblDPS.Size = new System.Drawing.Size(47, 24);
            this.lblDPS.TabIndex = 1;
            this.lblDPS.Text = "DPS";
            // 
            // lblSS
            // 
            this.lblSS.AutoSize = true;
            this.lblSS.Location = new System.Drawing.Point(23, 150);
            this.lblSS.Name = "lblSS";
            this.lblSS.Size = new System.Drawing.Size(106, 24);
            this.lblSS.TabIndex = 3;
            this.lblSS.Text = "Single Shot";
            // 
            // lblHeroes
            // 
            this.lblHeroes.AutoSize = true;
            this.lblHeroes.Location = new System.Drawing.Point(21, 32);
            this.lblHeroes.Name = "lblHeroes";
            this.lblHeroes.Size = new System.Drawing.Size(72, 24);
            this.lblHeroes.TabIndex = 4;
            this.lblHeroes.Text = "Heroes";
            // 
            // lblHeadShot
            // 
            this.lblHeadShot.AutoSize = true;
            this.lblHeadShot.Location = new System.Drawing.Point(23, 117);
            this.lblHeadShot.Name = "lblHeadShot";
            this.lblHeadShot.Size = new System.Drawing.Size(133, 24);
            this.lblHeadShot.TabIndex = 5;
            this.lblHeadShot.Text = "Headshot DPS";
            // 
            // lblReload
            // 
            this.lblReload.AutoSize = true;
            this.lblReload.Location = new System.Drawing.Point(23, 184);
            this.lblReload.Name = "lblReload";
            this.lblReload.Size = new System.Drawing.Size(70, 24);
            this.lblReload.TabIndex = 6;
            this.lblReload.Text = "Reload";
            // 
            // User
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.Transparent;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Controls.Add(this.lblReload);
            this.Controls.Add(this.lblHeadShot);
            this.Controls.Add(this.lblHeroes);
            this.Controls.Add(this.lblSS);
            this.Controls.Add(this.lblDPS);
            this.Controls.Add(this.lblLife);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Name = "User";
            this.Size = new System.Drawing.Size(273, 256);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblLife;
        private System.Windows.Forms.Label lblDPS;
        private System.Windows.Forms.Label lblSS;
        private System.Windows.Forms.Label lblHeroes;
        private System.Windows.Forms.Label lblHeadShot;
        private System.Windows.Forms.Label lblReload;
    }
}
