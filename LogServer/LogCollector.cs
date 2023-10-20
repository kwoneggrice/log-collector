using System.Net;
using System.Net.Sockets;

namespace LogServer
{
	public partial class LogCollector : Form
	{
		TcpListener _server;
		bool _isStart = true;

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
				btnServerStop.Enabled = false;
				btnServerStart.Enabled = true;
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
