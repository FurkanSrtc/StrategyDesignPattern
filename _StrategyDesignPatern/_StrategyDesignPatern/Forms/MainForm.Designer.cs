namespace _StrategyDesignPatern
{
    partial class Form1
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.Fire = new System.Windows.Forms.Button();
            this.ChangeGun = new System.Windows.Forms.Button();
            this.GunBox = new System.Windows.Forms.PictureBox();
            this.BulletBox = new System.Windows.Forms.PictureBox();
            this.BulletsLabel = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.EnemyPic = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GunBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BulletBox)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.EnemyPic)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel1.Controls.Add(this.flowLayoutPanel1);
            this.panel1.Controls.Add(this.Fire);
            this.panel1.Controls.Add(this.ChangeGun);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(237, 887);
            this.panel1.TabIndex = 0;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Location = new System.Drawing.Point(8, 211);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(218, 664);
            this.flowLayoutPanel1.TabIndex = 1;
            // 
            // Fire
            // 
            this.Fire.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.Fire.FlatAppearance.BorderSize = 4;
            this.Fire.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Fire.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Fire.ForeColor = System.Drawing.Color.Red;
            this.Fire.Location = new System.Drawing.Point(32, 116);
            this.Fire.Name = "Fire";
            this.Fire.Size = new System.Drawing.Size(155, 88);
            this.Fire.TabIndex = 0;
            this.Fire.Text = "FIRE";
            this.Fire.UseVisualStyleBackColor = true;
            this.Fire.Click += new System.EventHandler(this.Fire_Click);
            // 
            // ChangeGun
            // 
            this.ChangeGun.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.ChangeGun.FlatAppearance.BorderSize = 4;
            this.ChangeGun.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ChangeGun.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ChangeGun.ForeColor = System.Drawing.Color.Red;
            this.ChangeGun.Location = new System.Drawing.Point(32, 22);
            this.ChangeGun.Name = "ChangeGun";
            this.ChangeGun.Size = new System.Drawing.Size(155, 88);
            this.ChangeGun.TabIndex = 0;
            this.ChangeGun.Text = "CHANGE GUN";
            this.ChangeGun.UseVisualStyleBackColor = true;
            this.ChangeGun.Click += new System.EventHandler(this.ChangeGun_Click);
            // 
            // GunBox
            // 
            this.GunBox.Location = new System.Drawing.Point(12, 187);
            this.GunBox.Name = "GunBox";
            this.GunBox.Size = new System.Drawing.Size(160, 95);
            this.GunBox.TabIndex = 1;
            this.GunBox.TabStop = false;
            // 
            // BulletBox
            // 
            this.BulletBox.Location = new System.Drawing.Point(200, 187);
            this.BulletBox.Name = "BulletBox";
            this.BulletBox.Size = new System.Drawing.Size(50, 35);
            this.BulletBox.TabIndex = 2;
            this.BulletBox.TabStop = false;
            // 
            // BulletsLabel
            // 
            this.BulletsLabel.AutoSize = true;
            this.BulletsLabel.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BulletsLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BulletsLabel.Font = new System.Drawing.Font("Copperplate Gothic Bold", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BulletsLabel.ForeColor = System.Drawing.Color.Lime;
            this.BulletsLabel.Location = new System.Drawing.Point(878, 9);
            this.BulletsLabel.Name = "BulletsLabel";
            this.BulletsLabel.Size = new System.Drawing.Size(85, 16);
            this.BulletsLabel.TabIndex = 3;
            this.BulletsLabel.Text = "BULLETS: 5";
            this.BulletsLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.EnemyPic);
            this.panel2.Controls.Add(this.GunBox);
            this.panel2.Controls.Add(this.BulletBox);
            this.panel2.Location = new System.Drawing.Point(243, 65);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(959, 520);
            this.panel2.TabIndex = 4;
            // 
            // EnemyPic
            // 
            this.EnemyPic.Location = new System.Drawing.Point(881, 445);
            this.EnemyPic.Name = "EnemyPic";
            this.EnemyPic.Size = new System.Drawing.Size(75, 73);
            this.EnemyPic.TabIndex = 0;
            this.EnemyPic.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(1203, 887);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.BulletsLabel);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Strategy Design Pattern";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.GunBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BulletBox)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.EnemyPic)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button Fire;
        private System.Windows.Forms.Button ChangeGun;
        private System.Windows.Forms.PictureBox GunBox;
        private System.Windows.Forms.PictureBox BulletBox;
        private System.Windows.Forms.Label BulletsLabel;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox EnemyPic;
    }
}

