using System.Net;
using System.Net.Sockets;
using System.Text;

namespace LogServer
{
	public partial class LogCollector : Form
	{
		TcpListener _server;
		bool _isStart = true;

		private async Task DataHandler(TcpClient client)
		{
			NetworkStream stream = client.GetStream();
			byte[] receiveDataBuffer = new byte[1024];
			int receiveDataSize;

			while (true)
			{
				// 가상 머신에서 첫번째로 보낸 길이
				receiveDataSize = await stream.ReadAsync(receiveDataBuffer, 0, receiveDataBuffer.Length);
				if (receiveDataSize == 0) break;

				// 가상 머신에서 보낸 데이터
				receiveDataSize = BitConverter.ToInt32(receiveDataBuffer);
				byte[] dataBuffer = new byte[receiveDataSize];
				receiveDataSize = await stream.ReadAsync(dataBuffer, 0, receiveDataSize);
				if (receiveDataSize == 0) break;

				string data = Encoding.UTF8.GetString(dataBuffer, 0, receiveDataSize);
			}
		}

		// 시작 정지 버튼 Enable 처리
		private void IsEnable(bool isStart)
		{
			if (isStart == true)
			{
				btnServerStart.Enabled = false;
				btnServerStop.Enabled = true;
				_isStart = false;
			}
			else
			{
				btnServerStart.Enabled = true;
				btnServerStop.Enabled = false;
				_isStart = true;
			}
		}

		private async void btnServerStart_Click(object sender, EventArgs e)
		{
			_server = new TcpListener(IPAddress.Parse("127.0.0.1"), 9999);
			_server.Start();
			lbLogConsole.Items.Add("Log Collector 서버 시작");
			IsEnable(_isStart);

			while (true)
			{
				TcpClient client = await _server.AcceptTcpClientAsync();
			}
		}

		private void btnServerStop_Click(object sender, EventArgs e)
		{
			_server.Stop();
			lbLogConsole.Items.Add("Log Collector 서버 종료");
			IsEnable(_isStart);
		}

		public LogCollector()
		{
			InitializeComponent();
		}
	}
}
