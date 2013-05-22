namespace Control_Audio
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置 Managed 資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器
        /// 修改這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonVolumeDown = new System.Windows.Forms.Button();
            this.buttonVolumeUp = new System.Windows.Forms.Button();
            this.buttonVolumeMute = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonVolumeDown
            // 
            this.buttonVolumeDown.Location = new System.Drawing.Point(12, 12);
            this.buttonVolumeDown.Name = "buttonVolumeDown";
            this.buttonVolumeDown.Size = new System.Drawing.Size(75, 23);
            this.buttonVolumeDown.TabIndex = 0;
            this.buttonVolumeDown.Text = "降低";
            this.buttonVolumeDown.UseVisualStyleBackColor = true;
            this.buttonVolumeDown.Click += new System.EventHandler(this.buttonVolumeDown_Click);
            // 
            // buttonVolumeUp
            // 
            this.buttonVolumeUp.Location = new System.Drawing.Point(106, 12);
            this.buttonVolumeUp.Name = "buttonVolumeUp";
            this.buttonVolumeUp.Size = new System.Drawing.Size(75, 23);
            this.buttonVolumeUp.TabIndex = 1;
            this.buttonVolumeUp.Text = "升高";
            this.buttonVolumeUp.UseVisualStyleBackColor = true;
            this.buttonVolumeUp.Click += new System.EventHandler(this.buttonVolumeUp_Click);
            // 
            // buttonVolumeMute
            // 
            this.buttonVolumeMute.Location = new System.Drawing.Point(200, 12);
            this.buttonVolumeMute.Name = "buttonVolumeMute";
            this.buttonVolumeMute.Size = new System.Drawing.Size(75, 23);
            this.buttonVolumeMute.TabIndex = 2;
            this.buttonVolumeMute.Text = "靜音";
            this.buttonVolumeMute.UseVisualStyleBackColor = true;
            this.buttonVolumeMute.Click += new System.EventHandler(this.buttonVolumeMute_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 44);
            this.Controls.Add(this.buttonVolumeMute);
            this.Controls.Add(this.buttonVolumeUp);
            this.Controls.Add(this.buttonVolumeDown);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonVolumeDown;
        private System.Windows.Forms.Button buttonVolumeUp;
        private System.Windows.Forms.Button buttonVolumeMute;
    }
}

