namespace Чат
{
    partial class Main
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
      this.MainContainer = new System.Windows.Forms.Panel();
      this.SuspendLayout();
      // 
      // MainContainer
      // 
      this.MainContainer.Location = new System.Drawing.Point(12, 71);
      this.MainContainer.Name = "MainContainer";
      this.MainContainer.Size = new System.Drawing.Size(294, 399);
      this.MainContainer.TabIndex = 0;
      // 
      // Main
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(318, 482);
      this.Controls.Add(this.MainContainer);
      this.MaximizeBox = false;
      this.Name = "Main";
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.Text = "Мессенджер";
      this.Load += new System.EventHandler(this.Main_load);
      this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel MainContainer;
    }
}

