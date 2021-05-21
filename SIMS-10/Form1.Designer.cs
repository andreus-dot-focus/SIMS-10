
namespace SIMS_10
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.rollButton = new System.Windows.Forms.Button();
            this.pointsLabel = new System.Windows.Forms.Label();
            this.playerLabel = new System.Windows.Forms.Label();
            this.aiLabel = new System.Windows.Forms.Label();
            this.gameLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // rollButton
            // 
            this.rollButton.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.rollButton.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rollButton.Location = new System.Drawing.Point(66, 478);
            this.rollButton.Name = "rollButton";
            this.rollButton.Size = new System.Drawing.Size(143, 47);
            this.rollButton.TabIndex = 0;
            this.rollButton.Text = "Бросок";
            this.rollButton.UseVisualStyleBackColor = false;
            this.rollButton.Click += new System.EventHandler(this.rollButton_Click);
            // 
            // pointsLabel
            // 
            this.pointsLabel.AutoSize = true;
            this.pointsLabel.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.pointsLabel.Font = new System.Drawing.Font("Nirmala UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pointsLabel.ForeColor = System.Drawing.SystemColors.Menu;
            this.pointsLabel.Location = new System.Drawing.Point(12, 422);
            this.pointsLabel.Name = "pointsLabel";
            this.pointsLabel.Size = new System.Drawing.Size(84, 32);
            this.pointsLabel.TabIndex = 1;
            this.pointsLabel.Text = "label1";
            // 
            // playerLabel
            // 
            this.playerLabel.AutoSize = true;
            this.playerLabel.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.playerLabel.Font = new System.Drawing.Font("Nirmala UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.playerLabel.ForeColor = System.Drawing.SystemColors.Menu;
            this.playerLabel.Location = new System.Drawing.Point(12, 22);
            this.playerLabel.Name = "playerLabel";
            this.playerLabel.Size = new System.Drawing.Size(84, 32);
            this.playerLabel.TabIndex = 2;
            this.playerLabel.Text = "label1";
            // 
            // aiLabel
            // 
            this.aiLabel.AutoSize = true;
            this.aiLabel.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.aiLabel.Font = new System.Drawing.Font("Nirmala UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.aiLabel.ForeColor = System.Drawing.SystemColors.Menu;
            this.aiLabel.Location = new System.Drawing.Point(12, 83);
            this.aiLabel.Name = "aiLabel";
            this.aiLabel.Size = new System.Drawing.Size(84, 32);
            this.aiLabel.TabIndex = 3;
            this.aiLabel.Text = "label2";
            // 
            // gameLabel
            // 
            this.gameLabel.AutoSize = true;
            this.gameLabel.Location = new System.Drawing.Point(545, 9);
            this.gameLabel.Name = "gameLabel";
            this.gameLabel.Size = new System.Drawing.Size(57, 13);
            this.gameLabel.TabIndex = 5;
            this.gameLabel.Text = "Ход игры:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 537);
            this.Controls.Add(this.gameLabel);
            this.Controls.Add(this.aiLabel);
            this.Controls.Add(this.playerLabel);
            this.Controls.Add(this.pointsLabel);
            this.Controls.Add(this.rollButton);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button rollButton;
        private System.Windows.Forms.Label pointsLabel;
        private System.Windows.Forms.Label playerLabel;
        private System.Windows.Forms.Label aiLabel;
        private System.Windows.Forms.Label gameLabel;
    }
}

