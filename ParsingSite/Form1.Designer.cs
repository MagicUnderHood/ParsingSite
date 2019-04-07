namespace ParsingSite
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
            this.GetInfoSiteButton = new System.Windows.Forms.Button();
            this.siteAdress = new System.Windows.Forms.TextBox();
            this.outputText = new System.Windows.Forms.TextBox();
            this.labelEnter = new System.Windows.Forms.Label();
            this.labelResult = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // GetInfoSiteButton
            // 
            this.GetInfoSiteButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.GetInfoSiteButton.Location = new System.Drawing.Point(572, 93);
            this.GetInfoSiteButton.Name = "GetInfoSiteButton";
            this.GetInfoSiteButton.Size = new System.Drawing.Size(191, 49);
            this.GetInfoSiteButton.TabIndex = 0;
            this.GetInfoSiteButton.Text = "Get info of site";
            this.GetInfoSiteButton.UseVisualStyleBackColor = true;
            this.GetInfoSiteButton.Click += new System.EventHandler(this.GetInfoSiteButton_Click);
            // 
            // siteAdress
            // 
            this.siteAdress.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.siteAdress.Location = new System.Drawing.Point(12, 103);
            this.siteAdress.Name = "siteAdress";
            this.siteAdress.Size = new System.Drawing.Size(538, 32);
            this.siteAdress.TabIndex = 1;
            // 
            // outputText
            // 
            this.outputText.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.outputText.Location = new System.Drawing.Point(12, 178);
            this.outputText.Multiline = true;
            this.outputText.Name = "outputText";
            this.outputText.ReadOnly = true;
            this.outputText.Size = new System.Drawing.Size(538, 92);
            this.outputText.TabIndex = 2;
            // 
            // labelEnter
            // 
            this.labelEnter.AutoSize = true;
            this.labelEnter.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelEnter.Location = new System.Drawing.Point(13, 74);
            this.labelEnter.Name = "labelEnter";
            this.labelEnter.Size = new System.Drawing.Size(146, 26);
            this.labelEnter.TabIndex = 3;
            this.labelEnter.Text = "Enter the site:";
            // 
            // labelResult
            // 
            this.labelResult.AutoSize = true;
            this.labelResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelResult.Location = new System.Drawing.Point(13, 149);
            this.labelResult.Name = "labelResult";
            this.labelResult.Size = new System.Drawing.Size(158, 26);
            this.labelResult.TabIndex = 4;
            this.labelResult.Text = "Title of the site:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(782, 450);
            this.Controls.Add(this.labelResult);
            this.Controls.Add(this.labelEnter);
            this.Controls.Add(this.outputText);
            this.Controls.Add(this.siteAdress);
            this.Controls.Add(this.GetInfoSiteButton);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button GetInfoSiteButton;
        private System.Windows.Forms.TextBox siteAdress;
        private System.Windows.Forms.TextBox outputText;
        private System.Windows.Forms.Label labelEnter;
        private System.Windows.Forms.Label labelResult;
    }
}

