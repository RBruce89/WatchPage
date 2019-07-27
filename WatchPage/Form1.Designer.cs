namespace WatchPage
{
    partial class Form1
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
            this.watchBtn = new System.Windows.Forms.Button();
            this.urlTxb = new System.Windows.Forms.TextBox();
            this.indacatorLbl = new System.Windows.Forms.Label();
            this.urlLbx = new System.Windows.Forms.ListBox();
            this.addBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.daysNUD = new System.Windows.Forms.NumericUpDown();
            this.hoursNUD = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.daysNUD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hoursNUD)).BeginInit();
            this.SuspendLayout();
            // 
            // watchBtn
            // 
            this.watchBtn.Location = new System.Drawing.Point(268, 197);
            this.watchBtn.Name = "watchBtn";
            this.watchBtn.Size = new System.Drawing.Size(133, 71);
            this.watchBtn.TabIndex = 4;
            this.watchBtn.Text = "Watch";
            this.watchBtn.UseVisualStyleBackColor = true;
            this.watchBtn.Click += new System.EventHandler(this.watchBtn_Click);
            // 
            // urlTxb
            // 
            this.urlTxb.Location = new System.Drawing.Point(12, 12);
            this.urlTxb.Name = "urlTxb";
            this.urlTxb.Size = new System.Drawing.Size(250, 22);
            this.urlTxb.TabIndex = 0;
            // 
            // indacatorLbl
            // 
            this.indacatorLbl.AutoSize = true;
            this.indacatorLbl.Location = new System.Drawing.Point(278, 177);
            this.indacatorLbl.Name = "indacatorLbl";
            this.indacatorLbl.Size = new System.Drawing.Size(0, 17);
            this.indacatorLbl.TabIndex = 2;
            // 
            // urlLbx
            // 
            this.urlLbx.FormattingEnabled = true;
            this.urlLbx.ItemHeight = 16;
            this.urlLbx.Location = new System.Drawing.Point(12, 40);
            this.urlLbx.Name = "urlLbx";
            this.urlLbx.Size = new System.Drawing.Size(250, 228);
            this.urlLbx.TabIndex = 0;
            this.urlLbx.TabStop = false;
            // 
            // addBtn
            // 
            this.addBtn.Location = new System.Drawing.Point(268, 12);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(127, 23);
            this.addBtn.TabIndex = 1;
            this.addBtn.Text = "Add";
            this.addBtn.UseVisualStyleBackColor = true;
            this.addBtn.Click += new System.EventHandler(this.Add);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(295, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 25);
            this.label1.TabIndex = 5;
            this.label1.Text = "Interval";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(274, 126);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 17);
            this.label2.TabIndex = 6;
            this.label2.Text = "Hours:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(274, 91);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 17);
            this.label4.TabIndex = 8;
            this.label4.Text = "Days:";
            // 
            // daysNUD
            // 
            this.daysNUD.Location = new System.Drawing.Point(341, 89);
            this.daysNUD.Name = "daysNUD";
            this.daysNUD.Size = new System.Drawing.Size(57, 22);
            this.daysNUD.TabIndex = 2;
            // 
            // hoursNUD
            // 
            this.hoursNUD.Location = new System.Drawing.Point(341, 124);
            this.hoursNUD.Name = "hoursNUD";
            this.hoursNUD.Size = new System.Drawing.Size(57, 22);
            this.hoursNUD.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(410, 280);
            this.Controls.Add(this.hoursNUD);
            this.Controls.Add(this.daysNUD);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.addBtn);
            this.Controls.Add(this.urlLbx);
            this.Controls.Add(this.indacatorLbl);
            this.Controls.Add(this.urlTxb);
            this.Controls.Add(this.watchBtn);
            this.Name = "Form1";
            this.Text = "Watch Page";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.daysNUD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hoursNUD)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button watchBtn;
        private System.Windows.Forms.TextBox urlTxb;
        private System.Windows.Forms.Label indacatorLbl;
        private System.Windows.Forms.ListBox urlLbx;
        private System.Windows.Forms.Button addBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown daysNUD;
        private System.Windows.Forms.NumericUpDown hoursNUD;
    }
}

