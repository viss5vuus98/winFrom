
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
            this.btnWorker1 = new System.Windows.Forms.Button();
            this.btnWorker2 = new System.Windows.Forms.Button();
            this.btnWorker3 = new System.Windows.Forms.Button();
            this.btnManerger = new System.Windows.Forms.Button();
            this.lalLoginName = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnWorker1
            // 
            this.btnWorker1.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnWorker1.Location = new System.Drawing.Point(169, 41);
            this.btnWorker1.Name = "btnWorker1";
            this.btnWorker1.Size = new System.Drawing.Size(227, 61);
            this.btnWorker1.TabIndex = 0;
            this.btnWorker1.Text = "創建員工1";
            this.btnWorker1.UseVisualStyleBackColor = true;
            this.btnWorker1.Click += new System.EventHandler(this.btnWorker1_Click);
            // 
            // btnWorker2
            // 
            this.btnWorker2.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnWorker2.Location = new System.Drawing.Point(169, 142);
            this.btnWorker2.Name = "btnWorker2";
            this.btnWorker2.Size = new System.Drawing.Size(227, 61);
            this.btnWorker2.TabIndex = 0;
            this.btnWorker2.Text = "創建員工2";
            this.btnWorker2.UseVisualStyleBackColor = true;
            this.btnWorker2.Click += new System.EventHandler(this.btnWorker2_Click);
            // 
            // btnWorker3
            // 
            this.btnWorker3.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnWorker3.Location = new System.Drawing.Point(169, 246);
            this.btnWorker3.Name = "btnWorker3";
            this.btnWorker3.Size = new System.Drawing.Size(227, 61);
            this.btnWorker3.TabIndex = 0;
            this.btnWorker3.Text = "創建員工3";
            this.btnWorker3.UseVisualStyleBackColor = true;
            this.btnWorker3.Click += new System.EventHandler(this.btnWorker3_Click);
            // 
            // btnManerger
            // 
            this.btnManerger.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnManerger.Location = new System.Drawing.Point(169, 346);
            this.btnManerger.Name = "btnManerger";
            this.btnManerger.Size = new System.Drawing.Size(227, 61);
            this.btnManerger.TabIndex = 0;
            this.btnManerger.Text = "創建管理者1";
            this.btnManerger.UseVisualStyleBackColor = true;
            this.btnManerger.Click += new System.EventHandler(this.btnManerger_Click);
            // 
            // lalLoginName
            // 
            this.lalLoginName.AutoSize = true;
            this.lalLoginName.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lalLoginName.Location = new System.Drawing.Point(513, 9);
            this.lalLoginName.Name = "lalLoginName";
            this.lalLoginName.Size = new System.Drawing.Size(134, 31);
            this.lalLoginName.TabIndex = 1;
            this.lalLoginName.Text = "登入者名稱";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.ClientSize = new System.Drawing.Size(724, 518);
            this.Controls.Add(this.lalLoginName);
            this.Controls.Add(this.btnManerger);
            this.Controls.Add(this.btnWorker3);
            this.Controls.Add(this.btnWorker2);
            this.Controls.Add(this.btnWorker1);
            this.Name = "Form1";
            this.Text = "class實作";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnWorker1;
        private System.Windows.Forms.Button btnWorker2;
        private System.Windows.Forms.Button btnWorker3;
        private System.Windows.Forms.Button btnManerger;
        private System.Windows.Forms.Label lalLoginName;
    }
}

