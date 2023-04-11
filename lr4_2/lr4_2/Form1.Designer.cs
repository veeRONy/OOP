namespace lr4_2
{
    partial class frmMain
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbA = new System.Windows.Forms.Label();
            this.lbB = new System.Windows.Forms.Label();
            this.lbC = new System.Windows.Forms.Label();
            this.lb1 = new System.Windows.Forms.Label();
            this.lb2 = new System.Windows.Forms.Label();
            this.tbA = new System.Windows.Forms.TextBox();
            this.tbB = new System.Windows.Forms.TextBox();
            this.tbC = new System.Windows.Forms.TextBox();
            this.nmcA = new System.Windows.Forms.NumericUpDown();
            this.nmcB = new System.Windows.Forms.NumericUpDown();
            this.nmcC = new System.Windows.Forms.NumericUpDown();
            this.trbA = new System.Windows.Forms.TrackBar();
            this.trbB = new System.Windows.Forms.TrackBar();
            this.trbC = new System.Windows.Forms.TrackBar();
            ((System.ComponentModel.ISupportInitialize)(this.nmcA)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmcB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmcC)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trbA)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trbB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trbC)).BeginInit();
            this.SuspendLayout();
            // 
            // lbA
            // 
            this.lbA.AutoSize = true;
            this.lbA.Font = new System.Drawing.Font("Microsoft Sans Serif", 64.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbA.Location = new System.Drawing.Point(71, 43);
            this.lbA.Name = "lbA";
            this.lbA.Size = new System.Drawing.Size(125, 124);
            this.lbA.TabIndex = 0;
            this.lbA.Text = "A";
            // 
            // lbB
            // 
            this.lbB.AutoSize = true;
            this.lbB.Font = new System.Drawing.Font("Microsoft Sans Serif", 64.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbB.Location = new System.Drawing.Point(345, 43);
            this.lbB.Name = "lbB";
            this.lbB.Size = new System.Drawing.Size(125, 124);
            this.lbB.TabIndex = 1;
            this.lbB.Text = "B";
            // 
            // lbC
            // 
            this.lbC.AutoSize = true;
            this.lbC.Font = new System.Drawing.Font("Microsoft Sans Serif", 64.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbC.Location = new System.Drawing.Point(628, 43);
            this.lbC.Name = "lbC";
            this.lbC.Size = new System.Drawing.Size(131, 124);
            this.lbC.TabIndex = 2;
            this.lbC.Text = "C";
            // 
            // lb1
            // 
            this.lb1.AutoSize = true;
            this.lb1.Font = new System.Drawing.Font("Microsoft Sans Serif", 64.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lb1.Location = new System.Drawing.Point(180, 43);
            this.lb1.Name = "lb1";
            this.lb1.Size = new System.Drawing.Size(180, 124);
            this.lb1.TabIndex = 3;
            this.lb1.Text = "<=";
            // 
            // lb2
            // 
            this.lb2.AutoSize = true;
            this.lb2.Font = new System.Drawing.Font("Microsoft Sans Serif", 64.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lb2.Location = new System.Drawing.Point(456, 43);
            this.lb2.Name = "lb2";
            this.lb2.Size = new System.Drawing.Size(180, 124);
            this.lb2.TabIndex = 4;
            this.lb2.Text = "<=";
            // 
            // tbA
            // 
            this.tbA.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbA.Location = new System.Drawing.Point(50, 216);
            this.tbA.MaxLength = 3;
            this.tbA.Name = "tbA";
            this.tbA.Size = new System.Drawing.Size(158, 30);
            this.tbA.TabIndex = 5;
            this.tbA.Text = "0";
            this.tbA.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbA_KeyDown);
            // 
            // tbB
            // 
            this.tbB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbB.Location = new System.Drawing.Point(324, 216);
            this.tbB.MaxLength = 3;
            this.tbB.Name = "tbB";
            this.tbB.Size = new System.Drawing.Size(158, 30);
            this.tbB.TabIndex = 6;
            this.tbB.Text = "0";
            this.tbB.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbB_KeyDown);
            // 
            // tbC
            // 
            this.tbC.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbC.Location = new System.Drawing.Point(614, 216);
            this.tbC.MaxLength = 3;
            this.tbC.Name = "tbC";
            this.tbC.Size = new System.Drawing.Size(158, 30);
            this.tbC.TabIndex = 7;
            this.tbC.Text = "0";
            this.tbC.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbC_KeyDown);
            // 
            // nmcA
            // 
            this.nmcA.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.nmcA.Location = new System.Drawing.Point(50, 272);
            this.nmcA.Name = "nmcA";
            this.nmcA.Size = new System.Drawing.Size(158, 27);
            this.nmcA.TabIndex = 8;
            this.nmcA.ValueChanged += new System.EventHandler(this.nmcA_ValueChanged);
            // 
            // nmcB
            // 
            this.nmcB.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.nmcB.Location = new System.Drawing.Point(324, 272);
            this.nmcB.Name = "nmcB";
            this.nmcB.Size = new System.Drawing.Size(158, 27);
            this.nmcB.TabIndex = 9;
            this.nmcB.ValueChanged += new System.EventHandler(this.nmcB_ValueChanged);
            // 
            // nmcC
            // 
            this.nmcC.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.nmcC.Location = new System.Drawing.Point(614, 272);
            this.nmcC.Name = "nmcC";
            this.nmcC.Size = new System.Drawing.Size(158, 27);
            this.nmcC.TabIndex = 10;
            this.nmcC.ValueChanged += new System.EventHandler(this.nmcC_ValueChanged);
            // 
            // trbA
            // 
            this.trbA.Location = new System.Drawing.Point(50, 330);
            this.trbA.Maximum = 100;
            this.trbA.Name = "trbA";
            this.trbA.Size = new System.Drawing.Size(158, 56);
            this.trbA.TabIndex = 11;
            this.trbA.Scroll += new System.EventHandler(this.trbA_Scroll);
            // 
            // trbB
            // 
            this.trbB.Location = new System.Drawing.Point(324, 330);
            this.trbB.Maximum = 100;
            this.trbB.Name = "trbB";
            this.trbB.Size = new System.Drawing.Size(158, 56);
            this.trbB.TabIndex = 12;
            this.trbB.Scroll += new System.EventHandler(this.trbB_Scroll);
            // 
            // trbC
            // 
            this.trbC.Location = new System.Drawing.Point(614, 330);
            this.trbC.Maximum = 100;
            this.trbC.Name = "trbC";
            this.trbC.Size = new System.Drawing.Size(158, 56);
            this.trbC.TabIndex = 13;
            this.trbC.Scroll += new System.EventHandler(this.trbC_Scroll);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(837, 468);
            this.Controls.Add(this.trbC);
            this.Controls.Add(this.trbB);
            this.Controls.Add(this.trbA);
            this.Controls.Add(this.nmcC);
            this.Controls.Add(this.nmcB);
            this.Controls.Add(this.nmcA);
            this.Controls.Add(this.tbC);
            this.Controls.Add(this.tbB);
            this.Controls.Add(this.tbA);
            this.Controls.Add(this.lb2);
            this.Controls.Add(this.lb1);
            this.Controls.Add(this.lbC);
            this.Controls.Add(this.lbB);
            this.Controls.Add(this.lbA);
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MVC";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmMain_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.nmcA)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmcB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmcC)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trbA)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trbB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trbC)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbA;
        private System.Windows.Forms.Label lbB;
        private System.Windows.Forms.Label lbC;
        private System.Windows.Forms.Label lb1;
        private System.Windows.Forms.Label lb2;
        private System.Windows.Forms.TextBox tbA;
        private System.Windows.Forms.TextBox tbB;
        private System.Windows.Forms.TextBox tbC;
        private System.Windows.Forms.NumericUpDown nmcA;
        private System.Windows.Forms.NumericUpDown nmcB;
        private System.Windows.Forms.NumericUpDown nmcC;
        private System.Windows.Forms.TrackBar trbA;
        private System.Windows.Forms.TrackBar trbB;
        private System.Windows.Forms.TrackBar trbC;
    }
}

