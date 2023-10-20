namespace VirtualMachine
{
	partial class VirtualMachine
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
			label1 = new Label();
			btnMachineStart = new Button();
			btnMachineStop = new Button();
			label2 = new Label();
			numericUpDown1 = new NumericUpDown();
			((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
			SuspendLayout();
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Font = new Font("맑은 고딕", 20F, FontStyle.Regular, GraphicsUnit.Point);
			label1.Location = new Point(12, 9);
			label1.Name = "label1";
			label1.Size = new Size(211, 37);
			label1.TabIndex = 0;
			label1.Text = "Virtual Machine";
			// 
			// btnMachineStart
			// 
			btnMachineStart.Location = new Point(326, 12);
			btnMachineStart.Name = "btnMachineStart";
			btnMachineStart.Size = new Size(70, 50);
			btnMachineStart.TabIndex = 1;
			btnMachineStart.Text = "장비 가동";
			btnMachineStart.UseVisualStyleBackColor = true;
			btnMachineStart.Click += btnMachineStart_Click;
			// 
			// btnMachineStop
			// 
			btnMachineStop.Enabled = false;
			btnMachineStop.Location = new Point(402, 12);
			btnMachineStop.Name = "btnMachineStop";
			btnMachineStop.Size = new Size(70, 50);
			btnMachineStop.TabIndex = 2;
			btnMachineStop.Text = "장비 정지";
			btnMachineStop.UseVisualStyleBackColor = true;
			btnMachineStop.Click += btnMachineStop_Click;
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Font = new Font("맑은 고딕", 12F, FontStyle.Regular, GraphicsUnit.Point);
			label2.Location = new Point(12, 78);
			label2.Name = "label2";
			label2.Size = new Size(138, 21);
			label2.TabIndex = 3;
			label2.Text = "Machine Number";
			// 
			// numericUpDown1
			// 
			numericUpDown1.Location = new Point(156, 78);
			numericUpDown1.Name = "numericUpDown1";
			numericUpDown1.Size = new Size(67, 23);
			numericUpDown1.TabIndex = 5;
			// 
			// VirtualMachine
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(484, 461);
			Controls.Add(numericUpDown1);
			Controls.Add(label2);
			Controls.Add(btnMachineStop);
			Controls.Add(btnMachineStart);
			Controls.Add(label1);
			Name = "VirtualMachine";
			Text = "VirtualMachine";
			((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Label label1;
		private Button btnMachineStart;
		private Button btnMachineStop;
		private Label label2;
		private NumericUpDown numericUpDown1;
	}
}