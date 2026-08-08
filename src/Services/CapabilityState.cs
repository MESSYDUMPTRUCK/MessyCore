using System.Collections.Generic;
namespace MessyCore.Services
{
    public class CapabilityState
    {
        private readonly Dictionary<string, string> _capabilities = new Dictionary<string, string>();
        public void Set(string key, string value) => _capabilities[key] = value;
        public string Get(string key) => _capabilities.TryGetValue(key, out var v) ? v : string.Empty;
        public IReadOnlyDictionary<string,string> All => _capabilities;
    }
}
