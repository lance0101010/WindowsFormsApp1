
namespace WindowsFormsApp1
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
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
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
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.textCM = new System.Windows.Forms.TextBox();
            this.btnAllClear = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textCM
            // 
            this.textCM.Location = new System.Drawing.Point(192, 141);
            this.textCM.Name = "textCM";
            this.textCM.Size = new System.Drawing.Size(129, 22);
            this.textCM.TabIndex = 3;
            this.textCM.TextChanged += new System.EventHandler(this.textCM_TextChanged);
            // 
            // btnAllClear
            // 
            this.btnAllClear.Location = new System.Drawing.Point(373, 139);
            this.btnAllClear.Name = "btnAllClear";
            this.btnAllClear.Size = new System.Drawing.Size(75, 23);
            this.btnAllClear.TabIndex = 6;
            this.btnAllClear.Text = "啟動!";
            this.btnAllClear.UseVisualStyleBackColor = true;
            this.btnAllClear.Click += new System.EventHandler(this.btnAllClear_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.ClientSize = new System.Drawing.Size(563, 381);
            this.Controls.Add(this.btnAllClear);
            this.Controls.Add(this.textCM);
            this.Name = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox textCM;
        private System.Windows.Forms.Button btnAllClear;
    }
}

