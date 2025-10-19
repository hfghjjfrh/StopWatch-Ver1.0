
namespace StopWatch
{
    partial class StopWatch
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
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
            this.components = new System.ComponentModel.Container();
            this.title = new System.Windows.Forms.Label();
            this.Stop = new System.Windows.Forms.Button();
            this.Start = new System.Windows.Forms.Button();
            this.display = new System.Windows.Forms.Label();
            this.Reset = new System.Windows.Forms.Button();
            this.Status = new System.Windows.Forms.ProgressBar();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // title
            // 
            this.title.AutoSize = true;
            this.title.Font = new System.Drawing.Font("HG正楷書体-PRO", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.title.Location = new System.Drawing.Point(68, 26);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(553, 97);
            this.title.TabIndex = 0;
            this.title.Text = "Stop Watch";
            // 
            // Stop
            // 
            this.Stop.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.Stop.Font = new System.Drawing.Font("MS UI Gothic", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.Stop.Location = new System.Drawing.Point(331, 291);
            this.Stop.Name = "Stop";
            this.Stop.Size = new System.Drawing.Size(309, 122);
            this.Stop.TabIndex = 1;
            this.Stop.Text = "Stop";
            this.Stop.UseVisualStyleBackColor = false;
            this.Stop.Click += new System.EventHandler(this.Stop_Click);
            // 
            // Start
            // 
            this.Start.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Start.Font = new System.Drawing.Font("MS UI Gothic", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.Start.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Start.Location = new System.Drawing.Point(12, 291);
            this.Start.Name = "Start";
            this.Start.Size = new System.Drawing.Size(299, 122);
            this.Start.TabIndex = 2;
            this.Start.Text = "Start";
            this.Start.UseVisualStyleBackColor = false;
            this.Start.Click += new System.EventHandler(this.Start_Click);
            // 
            // display
            // 
            this.display.Font = new System.Drawing.Font("MS UI Gothic", 84.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.display.Location = new System.Drawing.Point(121, 135);
            this.display.Name = "display";
            this.display.Size = new System.Drawing.Size(442, 109);
            this.display.TabIndex = 3;
            this.display.Text = "00:00:00";
            // 
            // Reset
            // 
            this.Reset.BackColor = System.Drawing.Color.Black;
            this.Reset.Font = new System.Drawing.Font("MS UI Gothic", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.Reset.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.Reset.Location = new System.Drawing.Point(170, 419);
            this.Reset.Name = "Reset";
            this.Reset.Size = new System.Drawing.Size(309, 122);
            this.Reset.TabIndex = 4;
            this.Reset.Text = "Reset";
            this.Reset.UseVisualStyleBackColor = false;
            this.Reset.Click += new System.EventHandler(this.Reset_Click);
            // 
            // Status
            // 
            this.Status.Location = new System.Drawing.Point(0, 249);
            this.Status.Name = "Status";
            this.Status.Size = new System.Drawing.Size(652, 23);
            this.Status.TabIndex = 5;
           
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // StopWatch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CausesValidation = false;
            this.ClientSize = new System.Drawing.Size(651, 546);
            this.Controls.Add(this.Status);
            this.Controls.Add(this.Reset);
            this.Controls.Add(this.display);
            this.Controls.Add(this.Start);
            this.Controls.Add(this.Stop);
            this.Controls.Add(this.title);
            this.Font = new System.Drawing.Font("ＭＳ 明朝", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.MaximizeBox = false;
            this.MaximumSize = this.Size;
            this.MinimumSize = this.Size;
            this.Name = "StopWatch";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "StopWatch Ver1.0";
            this.TransparencyKey = System.Drawing.Color.Transparent;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label title;
        private System.Windows.Forms.Button Stop;
        private System.Windows.Forms.Button Start;
        private System.Windows.Forms.Label display;
        private System.Windows.Forms.Button Reset;
        private System.Windows.Forms.ProgressBar Status;
        private System.Windows.Forms.Timer timer1;
    }
}

