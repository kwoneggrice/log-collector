using System.Text.Json;

namespace LogCollectorLib.Models
{
	public class MachineData
	{
		public string MachineNumber { get; set; }
		public bool isRunning { get; set; }

		public string ToJsonString() => JsonSerializer.Serialize(this);
		public static MachineData? Parse(string json) => JsonSerializer.Deserialize<MachineData>(json);
	}
}
