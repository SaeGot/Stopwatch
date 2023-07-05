namespace Stopwatch
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
            this.components = new System.ComponentModel.Container();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.lvTimeline = new System.Windows.Forms.ListView();
            this.stage = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.timeline = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.txtCurrentTime = new System.Windows.Forms.TextBox();
            this.txtCurrentGap = new System.Windows.Forms.TextBox();
            this.btnStart = new System.Windows.Forms.Button();
            this.btnSplit = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnHotKey = new System.Windows.Forms.Button();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.stageGap = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // txtTitle
            // 
            this.txtTitle.Location = new System.Drawing.Point(349, 65);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(100, 25);
            this.txtTitle.TabIndex = 0;
            this.txtTitle.Text = "Title";
            this.txtTitle.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lvTimeline
            // 
            this.lvTimeline.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.stage,
            this.timeline,
            this.stageGap});
            this.lvTimeline.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.lvTimeline.HideSelection = false;
            this.lvTimeline.Location = new System.Drawing.Point(233, 96);
            this.lvTimeline.Name = "lvTimeline";
            this.lvTimeline.Size = new System.Drawing.Size(318, 97);
            this.lvTimeline.TabIndex = 1;
            this.lvTimeline.UseCompatibleStateImageBehavior = false;
            this.lvTimeline.View = System.Windows.Forms.View.Details;
            // 
            // stage
            // 
            this.stage.Text = "구간";
            this.stage.Width = 50;
            // 
            // timeline
            // 
            this.timeline.Text = "달성 시간";
            this.timeline.Width = 150;
            // 
            // txtCurrentTime
            // 
            this.txtCurrentTime.BackColor = System.Drawing.SystemColors.Window;
            this.txtCurrentTime.Location = new System.Drawing.Point(233, 213);
            this.txtCurrentTime.Name = "txtCurrentTime";
            this.txtCurrentTime.ReadOnly = true;
            this.txtCurrentTime.ShortcutsEnabled = false;
            this.txtCurrentTime.Size = new System.Drawing.Size(173, 25);
            this.txtCurrentTime.TabIndex = 2;
            // 
            // txtCurrentGap
            // 
            this.txtCurrentGap.BackColor = System.Drawing.SystemColors.Window;
            this.txtCurrentGap.Location = new System.Drawing.Point(432, 213);
            this.txtCurrentGap.Name = "txtCurrentGap";
            this.txtCurrentGap.ReadOnly = true;
            this.txtCurrentGap.ShortcutsEnabled = false;
            this.txtCurrentGap.Size = new System.Drawing.Size(119, 25);
            this.txtCurrentGap.TabIndex = 3;
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(233, 262);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(75, 23);
            this.btnStart.TabIndex = 4;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.BtnStartClick);
            // 
            // btnSplit
            // 
            this.btnSplit.Enabled = false;
            this.btnSplit.Location = new System.Drawing.Point(314, 262);
            this.btnSplit.Name = "btnSplit";
            this.btnSplit.Size = new System.Drawing.Size(75, 23);
            this.btnSplit.TabIndex = 5;
            this.btnSplit.Text = "Split";
            this.btnSplit.UseVisualStyleBackColor = true;
            this.btnSplit.Click += new System.EventHandler(this.BtnSplitClick);
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(395, 262);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(75, 23);
            this.btnReset.TabIndex = 6;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.BtnResetClick);
            // 
            // btnHotKey
            // 
            this.btnHotKey.Location = new System.Drawing.Point(476, 262);
            this.btnHotKey.Name = "btnHotKey";
            this.btnHotKey.Size = new System.Drawing.Size(75, 23);
            this.btnHotKey.TabIndex = 7;
            this.btnHotKey.Text = "button4";
            this.btnHotKey.UseVisualStyleBackColor = true;
            // 
            // timer
            // 
            this.timer.Enabled = true;
            this.timer.Tick += new System.EventHandler(this.TimerTick);
            // 
            // stageGap
            // 
            this.stageGap.Text = "구간 차";
            this.stageGap.Width = 150;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnHotKey);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnSplit);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.txtCurrentGap);
            this.Controls.Add(this.txtCurrentTime);
            this.Controls.Add(this.lvTimeline);
            this.Controls.Add(this.txtTitle);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtTitle;
        private System.Windows.Forms.ListView lvTimeline;
        private System.Windows.Forms.TextBox txtCurrentTime;
        private System.Windows.Forms.TextBox txtCurrentGap;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnSplit;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnHotKey;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.ColumnHeader stage;
        private System.Windows.Forms.ColumnHeader timeline;
        private System.Windows.Forms.ColumnHeader stageGap;
    }
}

