using System;

namespace Ntp2_Odev_Oyun
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }



        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.Timer = new System.Windows.Forms.Timer(this.components);
            this.PointLabel = new System.Windows.Forms.Label();
            this.TimeLabel = new System.Windows.Forms.Label();
            this.ButtonsPanel = new System.Windows.Forms.Panel();
            this.GameOverPanel = new System.Windows.Forms.Panel();
            this.RestartButton = new System.Windows.Forms.Button();
            this.GameOverLabel = new System.Windows.Forms.Label();
            this.GamePanel = new System.Windows.Forms.Panel();
            this.SaveButton = new System.Windows.Forms.Button();
            this.ButtonsPanel.SuspendLayout();
            this.GameOverPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // Timer
            // 
            this.Timer.Interval = 1000;
            this.Timer.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // PointLabel
            // 
            this.PointLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.PointLabel.AutoSize = true;
            this.PointLabel.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.PointLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.PointLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.PointLabel.Location = new System.Drawing.Point(36, 27);
            this.PointLabel.Name = "PointLabel";
            this.PointLabel.Size = new System.Drawing.Size(108, 41);
            this.PointLabel.TabIndex = 0;
            this.PointLabel.Text = "Score";
            // 
            // TimeLabel
            // 
            this.TimeLabel.AutoSize = true;
            this.TimeLabel.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.TimeLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.TimeLabel.Location = new System.Drawing.Point(81, 262);
            this.TimeLabel.Name = "TimeLabel";
            this.TimeLabel.Size = new System.Drawing.Size(35, 15);
            this.TimeLabel.TabIndex = 1;
            this.TimeLabel.Text = "TIME";
            // 
            // ButtonsPanel
            // 
            this.ButtonsPanel.BackColor = System.Drawing.SystemColors.GrayText;
            this.ButtonsPanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.ButtonsPanel.Controls.Add(this.TimeLabel);
            this.ButtonsPanel.Controls.Add(this.PointLabel);
            this.ButtonsPanel.Location = new System.Drawing.Point(660, 27);
            this.ButtonsPanel.Name = "ButtonsPanel";
            this.ButtonsPanel.Size = new System.Drawing.Size(180, 421);
            this.ButtonsPanel.TabIndex = 2;
            // 
            // GameOverPanel
            // 
            this.GameOverPanel.Controls.Add(this.SaveButton);
            this.GameOverPanel.Controls.Add(this.RestartButton);
            this.GameOverPanel.Controls.Add(this.GameOverLabel);
            this.GameOverPanel.Location = new System.Drawing.Point(10, 10);
            this.GameOverPanel.Name = "GameOverPanel";
            this.GameOverPanel.Size = new System.Drawing.Size(630, 420);
            this.GameOverPanel.TabIndex = 3;
            this.GameOverPanel.Visible = false;
            // 
            // RestartButton
            // 
            this.RestartButton.Location = new System.Drawing.Point(294, 273);
            this.RestartButton.Name = "RestartButton";
            this.RestartButton.Size = new System.Drawing.Size(75, 23);
            this.RestartButton.TabIndex = 1;
            this.RestartButton.Text = "Restart";
            this.RestartButton.UseVisualStyleBackColor = true;
            this.RestartButton.Click += new System.EventHandler(this.RestartButton_CLick);
            // 
            // GameOverLabel
            // 
            this.GameOverLabel.AutoSize = true;
            this.GameOverLabel.Location = new System.Drawing.Point(291, 54);
            this.GameOverLabel.Name = "GameOverLabel";
            this.GameOverLabel.Size = new System.Drawing.Size(61, 13);
            this.GameOverLabel.TabIndex = 0;
            this.GameOverLabel.Text = "Game Over";
            // 
            // GamePanel
            // 
            this.GamePanel.Location = new System.Drawing.Point(10, 10);
            this.GamePanel.Name = "GamePanel";
            this.GamePanel.Size = new System.Drawing.Size(630, 420);
            this.GamePanel.TabIndex = 0;
            this.GamePanel.Paint += new System.Windows.Forms.PaintEventHandler(this.GamePanel_Paint);
            // 
            // SaveButton
            // 
            this.SaveButton.Location = new System.Drawing.Point(293, 165);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(75, 23);
            this.SaveButton.TabIndex = 2;
            this.SaveButton.Text = "Save Score";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(852, 477);
            this.Controls.Add(this.GameOverPanel);
            this.Controls.Add(this.ButtonsPanel);
            this.Controls.Add(this.GamePanel);
            this.Name = "Form1";
            this.Text = "MBD";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ButtonsPanel.ResumeLayout(false);
            this.ButtonsPanel.PerformLayout();
            this.GameOverPanel.ResumeLayout(false);
            this.GameOverPanel.PerformLayout();
            this.ResumeLayout(false);

        }
        #endregion

        private System.Windows.Forms.Timer Timer;
        private System.Windows.Forms.Label PointLabel;
        private System.Windows.Forms.Label TimeLabel;
        private System.Windows.Forms.Panel ButtonsPanel;
        private System.Windows.Forms.Panel GameOverPanel;
        private System.Windows.Forms.Panel GamePanel;
        private System.Windows.Forms.Label GameOverLabel;
        private System.Windows.Forms.Button RestartButton;
        private System.Windows.Forms.Button SaveButton;
    }
}

