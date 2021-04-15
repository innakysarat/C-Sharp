namespace Overwatch_1
{
    partial class Game
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
            this.btnRestart = new System.Windows.Forms.Button();
            this.attackBuuton1 = new Overwatch_1.AttackBuuton();
            this.arrow1 = new Overwatch_1.Arrow();
            this.user2 = new Overwatch_1.User();
            this.user1 = new Overwatch_1.User();
            this.SuspendLayout();
            // 
            // btnRestart
            // 
            this.btnRestart.BackColor = System.Drawing.Color.Transparent;
            this.btnRestart.Location = new System.Drawing.Point(33, 342);
            this.btnRestart.Name = "btnRestart";
            this.btnRestart.Size = new System.Drawing.Size(218, 54);
            this.btnRestart.TabIndex = 4;
            this.btnRestart.Text = "Restart";
            this.btnRestart.UseVisualStyleBackColor = false;
            this.btnRestart.Visible = false;
           // this.btnRestart.Click += new System.EventHandler(this.btnRestart_Click_1);
            // 
            // attackBuuton1
            // 
            this.attackBuuton1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.attackBuuton1.BackColor = System.Drawing.Color.Transparent;
            this.attackBuuton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.attackBuuton1.Location = new System.Drawing.Point(277, 281);
            this.attackBuuton1.Name = "attackBuuton1";
            this.attackBuuton1.Size = new System.Drawing.Size(317, 115);
            this.attackBuuton1.TabIndex = 3;
            this.attackBuuton1.Attacked += new System.EventHandler<Overwatch_1.AttackedEventArgs>(this.attackBuuton1_Attacked);
            // 
            // arrow1
            // 
            this.arrow1.BackColor = System.Drawing.Color.Transparent;
            this.arrow1.Location = new System.Drawing.Point(382, 14);
            this.arrow1.Name = "arrow1";
            this.arrow1.Size = new System.Drawing.Size(139, 159);
            this.arrow1.TabIndex = 2;
            this.arrow1.Load += new System.EventHandler(this.arrow1_Load);
            // 
            // user2
            // 
            this.user2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.user2.BackColor = System.Drawing.Color.Transparent;
            this.user2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.user2.Cursor = System.Windows.Forms.Cursors.Default;
            this.user2.Damage_per_second = 0D;
            this.user2.Font = new System.Drawing.Font("Rockwell", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.user2.ForeColor = System.Drawing.Color.Black;
            this.user2.Headshot_DPS = 0D;
            this.user2.Heroes = null;
            this.user2.Life = 0D;
            this.user2.Location = new System.Drawing.Point(527, 3);
            this.user2.Name = "user2";
            this.user2.Reload = null;
            this.user2.Single_shot = 0D;
            this.user2.Size = new System.Drawing.Size(295, 225);
            this.user2.TabIndex = 1;
            this.user2.Load += new System.EventHandler(this.user2_Load);
            // 
            // user1
            // 
            this.user1.BackColor = System.Drawing.Color.Transparent;
            this.user1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.user1.Damage_per_second = 0D;
            this.user1.Font = new System.Drawing.Font("Rockwell", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.user1.ForeColor = System.Drawing.Color.Black;
            this.user1.Headshot_DPS = 0D;
            this.user1.Heroes = null;
            this.user1.Life = 0D;
            this.user1.Location = new System.Drawing.Point(24, 3);
            this.user1.Name = "user1";
            this.user1.Reload = null;
            this.user1.Single_shot = 0D;
            this.user1.Size = new System.Drawing.Size(275, 223);
            this.user1.TabIndex = 0;
            // 
            // Game
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Overwatch_1.Properties.Resources.overwatchpic;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(this.btnRestart);
            this.Controls.Add(this.attackBuuton1);
            this.Controls.Add(this.arrow1);
            this.Controls.Add(this.user2);
            this.Controls.Add(this.user1);
            this.Name = "Game";
            this.Size = new System.Drawing.Size(908, 427);
            this.Load += new System.EventHandler(this.Game_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private User user1;
        private User user2;
        private AttackBuuton attackBuuton1;
        private System.Windows.Forms.Button btnRestart;
        private Arrow arrow1;
    }
}
