namespace _2048Game
{
    partial class _2048Window
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
            this.PField = new System.Windows.Forms.Panel();
            this.BPiece = new System.Windows.Forms.Button();
            this.LName = new System.Windows.Forms.Label();
            this.LabelScore = new System.Windows.Forms.Label();
            this.PField.SuspendLayout();
            this.SuspendLayout();
            // 
            // PField
            // 
            this.PField.BackgroundImage = global::_2048Game.Properties.Resources.panelBG;
            this.PField.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.PField.Controls.Add(this.BPiece);
            this.PField.Location = new System.Drawing.Point(53, 84);
            this.PField.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.PField.Name = "PField";
            this.PField.Size = new System.Drawing.Size(573, 529);
            this.PField.TabIndex = 0;
            // 
            // BPiece
            // 
            this.BPiece.Font = new System.Drawing.Font("Cooper Black", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BPiece.Location = new System.Drawing.Point(8, 138);
            this.BPiece.Margin = new System.Windows.Forms.Padding(0);
            this.BPiece.Name = "BPiece";
            this.BPiece.Size = new System.Drawing.Size(133, 123);
            this.BPiece.TabIndex = 1;
            this.BPiece.Text = "2";
            this.BPiece.UseVisualStyleBackColor = true;
            // 
            // LName
            // 
            this.LName.AutoSize = true;
            this.LName.Location = new System.Drawing.Point(63, 21);
            this.LName.Name = "LName";
            this.LName.Size = new System.Drawing.Size(35, 16);
            this.LName.TabIndex = 1;
            this.LName.Text = "2048";
            // 
            // LabelScore
            // 
            this.LabelScore.AutoSize = true;
            this.LabelScore.Location = new System.Drawing.Point(445, 32);
            this.LabelScore.Name = "LabelScore";
            this.LabelScore.Size = new System.Drawing.Size(77, 16);
            this.LabelScore.TabIndex = 2;
            this.LabelScore.Text = "LabelScore";
            // 
            // _2048Window
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(965, 674);
            this.Controls.Add(this.LabelScore);
            this.Controls.Add(this.LName);
            this.Controls.Add(this.PField);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "_2048Window";
            this.Text = "2048";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.OnPaint);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.OnKeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.OnKeyUp);
            this.PField.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel PField;
        private System.Windows.Forms.Button BPiece;
        private System.Windows.Forms.Label LName;
        private System.Windows.Forms.Label LabelScore;
    }
}

