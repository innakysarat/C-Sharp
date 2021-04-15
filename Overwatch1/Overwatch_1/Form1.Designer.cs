namespace Overwatch_1
{
    partial class Form1
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

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.game1 = new Overwatch_1.Game();
            this.pickHero1 = new Overwatch_1.PickHero();
            this.toHide1 = new Overwatch_1.ToHide();
            this.SuspendLayout();
            // 
            // game1
            // 
            this.game1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.game1.Hero1 = null;
            this.game1.Hero2 = null;
            this.game1.Location = new System.Drawing.Point(0, 70);
            this.game1.Name = "game1";
            this.game1.Size = new System.Drawing.Size(842, 401);
            this.game1.TabIndex = 3;
            this.game1.Visible = false;
            this.game1.Load += new System.EventHandler(this.game1_Load);
            // 
            // pickHero1
            // 
            this.pickHero1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pickHero1.Heroes = null;
            this.pickHero1.Location = new System.Drawing.Point(0, 70);
            this.pickHero1.Name = "pickHero1";
            this.pickHero1.Size = new System.Drawing.Size(842, 401);
            this.pickHero1.TabIndex = 2;
            this.pickHero1.OnPick += new System.EventHandler<Overwatch_1.PickEventArgs>(this.pickHero1_OnPick);
            // 
            // toHide1
            // 
            this.toHide1.BackColor = System.Drawing.Color.Transparent;
            this.toHide1.Dock = System.Windows.Forms.DockStyle.Top;
            this.toHide1.Location = new System.Drawing.Point(0, 0);
            this.toHide1.Name = "toHide1";
            this.toHide1.Size = new System.Drawing.Size(842, 70);
            this.toHide1.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackgroundImage = global::Overwatch_1.Properties.Resources.overwatchpic;
            this.ClientSize = new System.Drawing.Size(842, 471);
            this.Controls.Add(this.game1);
            this.Controls.Add(this.pickHero1);
            this.Controls.Add(this.toHide1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private ToHide toHide1;
        private PickHero pickHero1;
        private Game game1;
    }
}

