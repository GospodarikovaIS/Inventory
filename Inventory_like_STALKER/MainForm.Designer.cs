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
            // boxPanel
            // 
            this.boxPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.boxPanel.Location = new System.Drawing.Point(12, 42);
            this.boxPanel.Name = "boxPanel";
            this.boxPanel.Size = new System.Drawing.Size(939, 478);
            this.boxPanel.TabIndex = 2;
            this.boxPanel.SizeChanged += new System.EventHandler(this.boxPanel_SizeChanged);
            this.boxPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.boxPanel_Paint);
            this.boxPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.boxPanel_MouseDown);
            this.boxPanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.boxPanel_MouseMove);
            this.boxPanel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.boxPanel_MouseUp);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(964, 532);
            this.Controls.Add(this.boxPanel);
            this.Controls.Add(this.butOpenInv);
            this.Name = "MainForm";
            this.Text = "Инвентарь";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.SizeChanged += new System.EventHandler(this.MainForm_SizeChanged);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button butOpenInv;
        private System.Windows.Forms.Panel boxPanel;
    }
}

