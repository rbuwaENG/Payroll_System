
namespace Payrollsystem
{
    partial class Settings
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
            this.button14 = new System.Windows.Forms.Button();
            this.end = new System.Windows.Forms.DateTimePicker();
            this.start = new System.Windows.Forms.DateTimePicker();
            this.leavedate = new System.Windows.Forms.TextBox();
            this.datarange = new System.Windows.Forms.TextBox();
            this.label26 = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button14
            // 
            this.button14.Location = new System.Drawing.Point(103, 15);
            this.button14.Name = "button14";
            this.button14.Size = new System.Drawing.Size(75, 23);
            this.button14.TabIndex = 19;
            this.button14.Text = "Save";
            this.button14.UseVisualStyleBackColor = true;
            this.button14.Click += new System.EventHandler(this.button14_Click);
            // 
            // end
            // 
            this.end.Location = new System.Drawing.Point(255, 152);
            this.end.Name = "end";
            this.end.Size = new System.Drawing.Size(200, 20);
            this.end.TabIndex = 18;
            // 
            // start
            // 
            this.start.Location = new System.Drawing.Point(255, 120);
            this.start.Name = "start";
            this.start.Size = new System.Drawing.Size(200, 20);
            this.start.TabIndex = 17;
            // 
            // leavedate
            // 
            this.leavedate.Location = new System.Drawing.Point(255, 89);
            this.leavedate.Name = "leavedate";
            this.leavedate.Size = new System.Drawing.Size(100, 20);
            this.leavedate.TabIndex = 16;
            // 
            // datarange
            // 
            this.datarange.Location = new System.Drawing.Point(255, 58);
            this.datarange.Name = "datarange";
            this.datarange.Size = new System.Drawing.Size(100, 20);
            this.datarange.TabIndex = 15;
            this.datarange.TextChanged += new System.EventHandler(this.datarange_TextChanged);
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Location = new System.Drawing.Point(31, 89);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(192, 13);
            this.label26.TabIndex = 14;
            this.label26.Text = "No of leaves for an employee for a year";
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Location = new System.Drawing.Point(31, 152);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(109, 13);
            this.label25.TabIndex = 13;
            this.label25.Text = "Salary cycle end date";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(31, 120);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(117, 13);
            this.label24.TabIndex = 12;
            this.label24.Text = "Salary cycle begin date";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(31, 66);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(147, 13);
            this.label23.TabIndex = 11;
            this.label23.Text = "Date Range for a salary cycle";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label22.Location = new System.Drawing.Point(6, 15);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(76, 20);
            this.label22.TabIndex = 10;
            this.label22.Text = "Settings";
            // 
            // Settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lime;
            this.ClientSize = new System.Drawing.Size(471, 191);
            this.Controls.Add(this.button14);
            this.Controls.Add(this.end);
            this.Controls.Add(this.start);
            this.Controls.Add(this.leavedate);
            this.Controls.Add(this.datarange);
            this.Controls.Add(this.label26);
            this.Controls.Add(this.label25);
            this.Controls.Add(this.label24);
            this.Controls.Add(this.label23);
            this.Controls.Add(this.label22);
            this.Name = "Settings";
            this.Text = "Settings";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button14;
        private System.Windows.Forms.DateTimePicker end;
        private System.Windows.Forms.DateTimePicker start;
        private System.Windows.Forms.TextBox leavedate;
        private System.Windows.Forms.TextBox datarange;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label22;
    }
}