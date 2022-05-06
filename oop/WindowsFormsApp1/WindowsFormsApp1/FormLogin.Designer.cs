
namespace WindowsFormsApp1
{
    partial class FormLoginUser
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.labelUserName = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txt密碼 = new System.Windows.Forms.TextBox();
            this.btn登入 = new System.Windows.Forms.Button();
            this.btn清除 = new System.Windows.Forms.Button();
            this.lbl回應訊息 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelUserName
            // 
            this.labelUserName.AutoSize = true;
            this.labelUserName.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUserName.Location = new System.Drawing.Point(94, 34);
            this.labelUserName.Name = "labelUserName";
            this.labelUserName.Size = new System.Drawing.Size(134, 31);
            this.labelUserName.TabIndex = 0;
            this.labelUserName.Text = "使用者名稱";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(128, 141);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "密碼";
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.Location = new System.Drawing.Point(61, 83);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(189, 39);
            this.txtName.TabIndex = 1;
            // 
            // txt密碼
            // 
            this.txt密碼.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt密碼.Location = new System.Drawing.Point(63, 175);
            this.txt密碼.Name = "txt密碼";
            this.txt密碼.PasswordChar = '*';
            this.txt密碼.Size = new System.Drawing.Size(189, 39);
            this.txt密碼.TabIndex = 1;
            // 
            // btn登入
            // 
            this.btn登入.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn登入.Location = new System.Drawing.Point(12, 353);
            this.btn登入.Name = "btn登入";
            this.btn登入.Size = new System.Drawing.Size(96, 36);
            this.btn登入.TabIndex = 2;
            this.btn登入.Text = "登入";
            this.btn登入.UseVisualStyleBackColor = true;
            this.btn登入.Click += new System.EventHandler(this.btn登入_Click);
            // 
            // btn清除
            // 
            this.btn清除.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn清除.Location = new System.Drawing.Point(200, 353);
            this.btn清除.Name = "btn清除";
            this.btn清除.Size = new System.Drawing.Size(96, 36);
            this.btn清除.TabIndex = 2;
            this.btn清除.Text = "清除";
            this.btn清除.UseVisualStyleBackColor = true;
            this.btn清除.Click += new System.EventHandler(this.btn清除_Click);
            // 
            // lbl回應訊息
            // 
            this.lbl回應訊息.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.lbl回應訊息.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl回應訊息.Location = new System.Drawing.Point(51, 244);
            this.lbl回應訊息.Name = "lbl回應訊息";
            this.lbl回應訊息.Size = new System.Drawing.Size(211, 91);
            this.lbl回應訊息.TabIndex = 3;
            this.lbl回應訊息.Text = "回應訊息";
            // 
            // FormLoginUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(308, 401);
            this.Controls.Add(this.lbl回應訊息);
            this.Controls.Add(this.btn清除);
            this.Controls.Add(this.btn登入);
            this.Controls.Add(this.txt密碼);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelUserName);
            this.Name = "FormLoginUser";
            this.Text = "使用者登入";
            this.Load += new System.EventHandler(this.FormLoginUser_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelUserName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txt密碼;
        private System.Windows.Forms.Button btn登入;
        private System.Windows.Forms.Button btn清除;
        private System.Windows.Forms.Label lbl回應訊息;
    }
}