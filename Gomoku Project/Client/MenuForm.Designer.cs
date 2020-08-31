﻿namespace Client
{
    partial class MenuForm
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
            this.SinglePlayButton = new System.Windows.Forms.Button();
            this.ExitButton = new System.Windows.Forms.Button();
            this.multiPlayButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // SinglePlayButton
            // 
            this.SinglePlayButton.Location = new System.Drawing.Point(232, 195);
            this.SinglePlayButton.Name = "SinglePlayButton";
            this.SinglePlayButton.Size = new System.Drawing.Size(100, 40);
            this.SinglePlayButton.TabIndex = 0;
            this.SinglePlayButton.Text = "종료하기";
            this.SinglePlayButton.UseVisualStyleBackColor = true;
            this.SinglePlayButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // ExitButton
            // 
            this.ExitButton.Location = new System.Drawing.Point(232, 68);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(100, 40);
            this.ExitButton.TabIndex = 1;
            this.ExitButton.Text = "혼자하기";
            this.ExitButton.UseVisualStyleBackColor = true;
            this.ExitButton.Click += new System.EventHandler(this.button2_Click);
            // 
            // multiPlayButton
            // 
            this.multiPlayButton.Location = new System.Drawing.Point(232, 132);
            this.multiPlayButton.Name = "multiPlayButton";
            this.multiPlayButton.Size = new System.Drawing.Size(100, 40);
            this.multiPlayButton.TabIndex = 2;
            this.multiPlayButton.Text = "함께하기";
            this.multiPlayButton.UseVisualStyleBackColor = true;
            this.multiPlayButton.Click += new System.EventHandler(this.multiPlayButton_Click);
            // 
            // MenuForm
            // 
            this.AcceptButton = this.SinglePlayButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 361);
            this.Controls.Add(this.multiPlayButton);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.SinglePlayButton);
            this.Name = "MenuForm";
            this.Text = "Gomoku Game Project";
            this.Load += new System.EventHandler(this.MenuForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button SinglePlayButton;
        private System.Windows.Forms.Button ExitButton;
        private System.Windows.Forms.Button multiPlayButton;
    }
}

