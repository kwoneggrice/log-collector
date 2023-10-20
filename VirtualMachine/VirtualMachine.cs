namespace VirtualMachine
{
	public partial class VirtualMachine : Form
	{
		bool _isStart = true;

		private void IsEnable(bool isStart)
		{
			if (isStart == true)
			{
				btnMachineStart.Enabled = false;
				btnMachineStop.Enabled = true;
				_isStart = false;
			}
			else
			{
				btnMachineStart.Enabled = true;
				btnMachineStop.Enabled = false;
				_isStart = true;
			}
		}

		private void btnMachineStart_Click(object sender, EventArgs e)
		{
			IsEnable(_isStart);
		}

		private void btnMachineStop_Click(object sender, EventArgs e)
		{
			IsEnable(_isStart);
		}

		public VirtualMachine()
		{
			InitializeComponent();
		}


	}
}
