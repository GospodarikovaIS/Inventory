namespace Inventory_like_STALKER
{
    partial class MainForm
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
            this.butOpenInv = new System.Windows.Forms.Button();
            this.ownPanel = new System.Windows.Forms.Panel();
            this.boxPanel = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // butOpenInv
            // 
            this.butOpenInv.Location = new System.Drawing.Point(13, 13);
            this.butOpenInv.Name = "butOpenInv";
            this.butOpenInv.Size = new System.Drawing.Size(75, 23);
            this.butOpenInv.TabIndex = 0;
            this.butOpenInv.Text = "Открыть";
            this.butOpenInv.UseVisualStyleBackColor = true;
            this.butOpenInv.Click += new System.EventHandler(this.butOpenInv_Click);
            // 
            // ownPanel
            // 
            this.ownPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ownPanel.Location = new System.Drawing.Point(12, 257);
            this.ownPanel.Name = "ownPanel";
            this.ownPanel.Size = new System.Drawing.Size(400, 160);
            this.ownPanel.TabIndex = 1;
            // 
            // boxPanel
            // 
            this.boxPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.boxPanel.Location = new System.Drawing.Point(12, 42);
            this.boxPanel.Name = "boxPanel";
            this.boxPanel.Size = new System.Drawing.Size(400, 160);
            this.boxPanel.TabIndex = 2;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(425, 429);
            this.Controls.Add(this.boxPanel);
            this.Controls.Add(this.ownPanel);
            this.Controls.Add(this.butOpenInv);
            this.Name = "MainForm";
            this.Text = "Инвентарь";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button butOpenInv;
        private System.Windows.Forms.Panel ownPanel;
        private System.Windows.Forms.Panel boxPanel;
    }
}

