namespace Stopwatch
{
    partial class HotKey
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
            this.lbStart = new System.Windows.Forms.Label();
            this.txtStart = new System.Windows.Forms.TextBox();
            this.txtSplit = new System.Windows.Forms.TextBox();
            this.lbSplit = new System.Windows.Forms.Label();
            this.txtReset = new System.Windows.Forms.TextBox();
            this.lbReset = new System.Windows.Forms.Label();
            this.btnOk = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbStart
            // 
            this.lbStart.AutoSize = true;
            this.lbStart.Location = new System.Drawing.Point(36, 32);
            this.lbStart.Name = "lbStart";
            this.lbStart.Size = new System.Drawing.Size(37, 15);
            this.lbStart.TabIndex = 0;
            this.lbStart.Text = "Start";
            // 
            // txtStart
            // 
            this.txtStart.Location = new System.Drawing.Point(95, 29);
            this.txtStart.Name = "txtStart";
            this.txtStart.Size = new System.Drawing.Size(100, 25);
            this.txtStart.TabIndex = 1;
            // 
            // txtSplit
            // 
            this.txtSplit.Location = new System.Drawing.Point(95, 74);
            this.txtSplit.Name = "txtSplit";
            this.txtSplit.Size = new System.Drawing.Size(100, 25);
            this.txtSplit.TabIndex = 3;
            // 
            // lbSplit
            // 
            this.lbSplit.AutoSize = true;
            this.lbSplit.Location = new System.Drawing.Point(36, 77);
            this.lbSplit.Name = "lbSplit";
            this.lbSplit.Size = new System.Drawing.Size(35, 15);
            this.lbSplit.TabIndex = 2;
            this.lbSplit.Text = "Split";
            // 
            // txtReset
            // 
            this.txtReset.Location = new System.Drawing.Point(95, 118);
            this.txtReset.Name = "txtReset";
            this.txtReset.Size = new System.Drawing.Size(100, 25);
            this.txtReset.TabIndex = 5;
            // 
            // lbReset
            // 
            this.lbReset.AutoSize = true;
            this.lbReset.Location = new System.Drawing.Point(36, 121);
            this.lbReset.Name = "lbReset";
            this.lbReset.Size = new System.Drawing.Size(45, 15);
            this.lbReset.TabIndex = 4;
            this.lbReset.Text = "Reset";
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(26, 184);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(75, 23);
            this.btnOk.TabIndex = 6;
            this.btnOk.Text = "Ok";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.BtnOkClick);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(140, 184);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 7;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.BtnCancelClick);
            // 
            // HotKey
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(240, 249);
            this.ControlBox = false;
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.txtReset);
            this.Controls.Add(this.lbReset);
            this.Controls.Add(this.txtSplit);
            this.Controls.Add(this.lbSplit);
            this.Controls.Add(this.txtStart);
            this.Controls.Add(this.lbStart);
            this.Name = "HotKey";
            this.Text = "HotKey";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbStart;
        private System.Windows.Forms.Label lbSplit;
        private System.Windows.Forms.Label lbReset;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Button btnCancel;
        public System.Windows.Forms.TextBox txtStart;
        public System.Windows.Forms.TextBox txtSplit;
        public System.Windows.Forms.TextBox txtReset;
    }
}