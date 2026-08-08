using System.Collections.Generic;
namespace MessyCore.Services
{
    public class ModuleRegistry
    {
        private readonly HashSet<string> _modules = new HashSet<string>();
        public void Register(string moduleName) => _modules.Add(moduleName);
        public bool IsRegistered(string moduleName) => _modules.Contains(moduleName);
        public IReadOnlyCollection<string> Modules => _modules;
    }
}
