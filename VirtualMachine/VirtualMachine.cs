using LogCollectorLib.Models;
using System.Net;
using System.Net.Sockets;
using System.Text;

namespace VirtualMachine
{
	public partial class VirtualMachine : Form
	{
		TcpClient _client;
		bool _isStart = false;

		private async Task DataHandler(TcpClient client)
		{
			NetworkStream stream = client.GetStream();

			while (true)
			{

			}
		}

		private void IsEnable(bool isStart)
		{
			if (isStart == false)
			{
				_isStart = true;
				btnMachineStart.Enabled = false;
				btnMachineStop.Enabled = true;
			}
			else
			{
				_isStart = false;
				btnMachineStart.Enabled = true;
				btnMachineStop.Enabled = false;
			}
		}

		private async void btnMachineStart_Click(object sender, EventArgs e)
		{
			_client = new TcpClient();
			await _client.ConnectAsync(IPAddress.Parse("127.0.0.1"), 9999);
			IsEnable(_isStart);
			NetworkStream stream = _client.GetStream();

			string machineNumber = nudMachineNumber.Value.ToString();
			MachineData machineData = new MachineData()
			{
				MachineNumber = machineNumber,
				isRunning = true,
			};

			var dataBuffer = Encoding.UTF8.GetBytes(machineData.ToJsonString());
			var dataLen = BitConverter.GetBytes(dataBuffer.Length);

			stream.Write(dataLen);
			stream.Write(dataBuffer);
		}

		private async void btnMachineStop_Click(object sender, EventArgs e)
		{
			NetworkStream stream = _client.GetStream();
			string machineNumber = nudMachineNumber.Value.ToString();
			MachineData machineData = new MachineData()
			{
				MachineNumber = machineNumber,
				isRunning = false,
			};

			var dataBuffer = Encoding.UTF8.GetBytes(machineData.ToJsonString());
			var dataLen = BitConverter.GetBytes(dataBuffer.Length);

			stream.Write(dataLen);
			stream.Write(dataBuffer);

			_client.Close();

			IsEnable(_isStart);
		}

		public VirtualMachine()
		{
			InitializeComponent();
		}


	}
}
