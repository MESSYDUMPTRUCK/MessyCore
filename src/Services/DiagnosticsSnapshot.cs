using System;
using System.Collections.Generic;
using System.Text;

namespace MessyCore.Services
{
    public class DiagnosticsSnapshot
    {
        public DateTime LastUpdatedUtc { get; private set; } = DateTime.UtcNow;
        public string ActiveProfile { get; private set; } = "default";
        public readonly Dictionary<string, string> RuntimeState = new Dictionary<string, string>();

        public void SetProfile(string profile)
        {
            ActiveProfile = profile;
            Touch();
        }

        public void SetState(string key, string value)
        {
            RuntimeState[key] = value;
            Touch();
        }

        public string ExportText()
        {
            var sb = new StringBuilder();
            sb.AppendLine($"profile={ActiveProfile}");
            sb.AppendLine($"updated={LastUpdatedUtc:O}");
            foreach (var kv in RuntimeState)
                sb.AppendLine($"{kv.Key}={kv.Value}");
            return sb.ToString();
        }

        private void Touch() => LastUpdatedUtc = DateTime.UtcNow;
    }
}
