namespace LogServer
{
	partial class LogCollector
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
			label2 = new Label();
			label3 = new Label();
			lbMachines = new ListBox();
			lbLogConsole = new ListBox();
			btnServerStart = new Button();
			btnServerStop = new Button();
			SuspendLayout();
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Font = new Font("맑은 고딕", 20F, FontStyle.Regular, GraphicsUnit.Point);
			label1.Location = new Point(12, 9);
			label1.Name = "label1";
			label1.Size = new Size(180, 37);
			label1.TabIndex = 0;
			label1.Text = "Log Collector";
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Font = new Font("맑은 고딕", 12F, FontStyle.Regular, GraphicsUnit.Point);
			label2.Location = new Point(12, 88);
			label2.Name = "label2";
			label2.Size = new Size(96, 21);
			label2.TabIndex = 1;
			label2.Text = "장비 리스트";
			// 
			// label3
			// 
			label3.AutoSize = true;
			label3.Font = new Font("맑은 고딕", 12F, FontStyle.Regular, GraphicsUnit.Point);
			label3.Location = new Point(218, 88);
			label3.Name = "label3";
			label3.Size = new Size(80, 21);
			label3.TabIndex = 2;
			label3.Text = "로그 콘솔";
			// 
			// lbMachines
			// 
			lbMachines.FormattingEnabled = true;
			lbMachines.ItemHeight = 15;
			lbMachines.Location = new Point(12, 112);
			lbMachines.Name = "lbMachines";
			lbMachines.Size = new Size(200, 334);
			lbMachines.TabIndex = 3;
			// 
			// lbLogConsole
			// 
			lbLogConsole.FormattingEnabled = true;
			lbLogConsole.ItemHeight = 15;
			lbLogConsole.Location = new Point(218, 112);
			lbLogConsole.Name = "lbLogConsole";
			lbLogConsole.Size = new Size(570, 334);
			lbLogConsole.TabIndex = 4;
			// 
			// btnServerStart
			// 
			btnServerStart.Location = new Point(642, 12);
			btnServerStart.Name = "btnServerStart";
			btnServerStart.Size = new Size(70, 50);
			btnServerStart.TabIndex = 5;
			btnServerStart.Text = "서버 시작";
			btnServerStart.UseVisualStyleBackColor = true;
			btnServerStart.Click += btnServerStart_Click;
			// 
			// btnServerStop
			// 
			btnServerStop.Enabled = false;
			btnServerStop.Location = new Point(718, 12);
			btnServerStop.Name = "btnServerStop";
			btnServerStop.Size = new Size(70, 50);
			btnServerStop.TabIndex = 6;
			btnServerStop.Text = "서버 종료";
			btnServerStop.UseVisualStyleBackColor = true;
			btnServerStop.Click += btnServerStop_Click;
			// 
			// LogCollector
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(800, 450);
			Controls.Add(btnServerStop);
			Controls.Add(btnServerStart);
			Controls.Add(lbLogConsole);
			Controls.Add(lbMachines);
			Controls.Add(label3);
			Controls.Add(label2);
			Controls.Add(label1);
			Name = "LogCollector";
			Text = "LogCollector";
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Label label1;
		private Label label2;
		private Label label3;
		private ListBox lbMachines;
		private ListBox lbLogConsole;
		private Button btnServerStart;
		private Button btnServerStop;
	}
}