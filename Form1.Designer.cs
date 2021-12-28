namespace TestMachineKey
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
			this.splitContainer1 = new System.Windows.Forms.SplitContainer();
			this.txtMachineKey = new System.Windows.Forms.TextBox();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.radNet1 = new System.Windows.Forms.RadioButton();
			this.radNet2 = new System.Windows.Forms.RadioButton();
			this.btnGenerate = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
			this.splitContainer1.Panel1.SuspendLayout();
			this.splitContainer1.Panel2.SuspendLayout();
			this.splitContainer1.SuspendLayout();
			this.groupBox1.SuspendLayout();
			this.SuspendLayout();
			// 
			// splitContainer1
			// 
			this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
			this.splitContainer1.IsSplitterFixed = true;
			this.splitContainer1.Location = new System.Drawing.Point(0, 0);
			this.splitContainer1.Name = "splitContainer1";
			this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
			// 
			// splitContainer1.Panel1
			// 
			this.splitContainer1.Panel1.Controls.Add(this.btnGenerate);
			this.splitContainer1.Panel1.Controls.Add(this.groupBox1);
			// 
			// splitContainer1.Panel2
			// 
			this.splitContainer1.Panel2.Controls.Add(this.txtMachineKey);
			this.splitContainer1.Panel2.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.splitContainer1.Size = new System.Drawing.Size(573, 578);
			this.splitContainer1.SplitterDistance = 82;
			this.splitContainer1.TabIndex = 0;
			// 
			// txtMachineKey
			// 
			this.txtMachineKey.Dock = System.Windows.Forms.DockStyle.Fill;
			this.txtMachineKey.Location = new System.Drawing.Point(0, 0);
			this.txtMachineKey.Multiline = true;
			this.txtMachineKey.Name = "txtMachineKey";
			this.txtMachineKey.ReadOnly = true;
			this.txtMachineKey.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this.txtMachineKey.Size = new System.Drawing.Size(573, 492);
			this.txtMachineKey.TabIndex = 0;
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.radNet2);
			this.groupBox1.Controls.Add(this.radNet1);
			this.groupBox1.Location = new System.Drawing.Point(12, 12);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(300, 52);
			this.groupBox1.TabIndex = 0;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Target version";
			// 
			// radNet1
			// 
			this.radNet1.AutoSize = true;
			this.radNet1.Location = new System.Drawing.Point(6, 19);
			this.radNet1.Name = "radNet1";
			this.radNet1.Size = new System.Drawing.Size(105, 17);
			this.radNet1.TabIndex = 0;
			this.radNet1.Text = ".NET version &1.1";
			this.radNet1.UseVisualStyleBackColor = true;
			// 
			// radNet2
			// 
			this.radNet2.AutoSize = true;
			this.radNet2.Checked = true;
			this.radNet2.Location = new System.Drawing.Point(129, 19);
			this.radNet2.Name = "radNet2";
			this.radNet2.Size = new System.Drawing.Size(149, 17);
			this.radNet2.TabIndex = 1;
			this.radNet2.TabStop = true;
			this.radNet2.Text = ".NET version &2.0 and later";
			this.radNet2.UseVisualStyleBackColor = true;
			// 
			// btnGenerate
			// 
			this.btnGenerate.Location = new System.Drawing.Point(318, 28);
			this.btnGenerate.Name = "btnGenerate";
			this.btnGenerate.Size = new System.Drawing.Size(144, 23);
			this.btnGenerate.TabIndex = 1;
			this.btnGenerate.Text = "&Generate Keys";
			this.btnGenerate.UseVisualStyleBackColor = true;
			this.btnGenerate.Click += new System.EventHandler(this.btnGenerate_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(573, 578);
			this.Controls.Add(this.splitContainer1);
			this.Name = "Form1";
			this.Text = "MachineKey Generator";
			this.splitContainer1.Panel1.ResumeLayout(false);
			this.splitContainer1.Panel2.ResumeLayout(false);
			this.splitContainer1.Panel2.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
			this.splitContainer1.ResumeLayout(false);
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.SplitContainer splitContainer1;
		private System.Windows.Forms.TextBox txtMachineKey;
		private System.Windows.Forms.Button btnGenerate;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.RadioButton radNet2;
		private System.Windows.Forms.RadioButton radNet1;

	}
}

