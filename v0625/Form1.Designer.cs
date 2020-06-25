namespace v0625
{
    partial class Form1
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージ リソースが破棄される場合 true、破棄されない場合は false です。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.button100 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button100
            // 
            this.button100.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.button100.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.button100.Font = new System.Drawing.Font("MS UI Gothic", 11F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.button100.Location = new System.Drawing.Point(103, 95);
            this.button100.Name = "button100";
            this.button100.Size = new System.Drawing.Size(134, 142);
            this.button100.TabIndex = 0;
            this.button100.Text = "button1";
            this.button100.UseVisualStyleBackColor = false;
            this.button100.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.button100);
            this.Enabled = false;
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button100;
    }
}

