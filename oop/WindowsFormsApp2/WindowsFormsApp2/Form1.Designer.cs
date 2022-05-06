
namespace WindowsFormsApp2
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
            this.btnDel = new System.Windows.Forms.Button();
            this.btnAct = new System.Windows.Forms.Button();
            this.btnFun = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnDel
            // 
            this.btnDel.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnDel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnDel.Location = new System.Drawing.Point(258, 59);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(229, 71);
            this.btnDel.TabIndex = 0;
            this.btnDel.Text = "Delegate";
            this.btnDel.UseVisualStyleBackColor = true;
            this.btnDel.Click += new System.EventHandler(this.btnDel_Click);
            // 
            // btnAct
            // 
            this.btnAct.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnAct.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnAct.Location = new System.Drawing.Point(258, 163);
            this.btnAct.Name = "btnAct";
            this.btnAct.Size = new System.Drawing.Size(229, 71);
            this.btnAct.TabIndex = 0;
            this.btnAct.Text = "Action";
            this.btnAct.UseVisualStyleBackColor = true;
            this.btnAct.Click += new System.EventHandler(this.btnAct_Click);
            // 
            // btnFun
            // 
            this.btnFun.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnFun.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnFun.Location = new System.Drawing.Point(258, 285);
            this.btnFun.Name = "btnFun";
            this.btnFun.Size = new System.Drawing.Size(229, 71);
            this.btnFun.TabIndex = 0;
            this.btnFun.Text = "Func";
            this.btnFun.UseVisualStyleBackColor = true;
            this.btnFun.Click += new System.EventHandler(this.btnFun_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnFun);
            this.Controls.Add(this.btnAct);
            this.Controls.Add(this.btnDel);
            this.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnDel;
        private System.Windows.Forms.Button btnAct;
        private System.Windows.Forms.Button btnFun;
    }
}

