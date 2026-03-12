namespace CatchButton
{
    partial class Form1
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.C_Button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // C_Button
            // 
            this.C_Button.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.C_Button.Font = new System.Drawing.Font("굵은안상수체", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.C_Button.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.C_Button.Location = new System.Drawing.Point(153, 78);
            this.C_Button.Name = "C_Button";
            this.C_Button.Size = new System.Drawing.Size(410, 145);
            this.C_Button.TabIndex = 0;
            this.C_Button.Text = "나를 잡아봐";
            this.C_Button.UseVisualStyleBackColor = false;
            this.C_Button.Click += new System.EventHandler(this.C_Button_Click);
            this.C_Button.MouseEnter += new System.EventHandler(this.C_Button_MouseEnter);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(754, 404);
            this.Controls.Add(this.C_Button);
            this.Name = "Form1";
            this.Text = "Form1";
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseClick);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button C_Button;
    }
}

