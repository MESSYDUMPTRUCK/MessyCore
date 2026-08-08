using Colossal.Logging;
using Game;
using Game.Modding;
using Game.SceneFlow;
namespace MessyCore
{
    public class Mod : IMod
    {
        public const string ModName = "MessyCore";
        public const string ModVersion = "0.1.0-beta";
        public static ILog Log = LogManager.GetLogger(ModName).SetShowsErrorsInUI(false);
        public static Services.ModuleRegistry Registry = new Services.ModuleRegistry();
        public static Services.PackSettings Settings = new Services.PackSettings();
        public static Services.CapabilityState Capabilities = new Services.CapabilityState();
        public static Services.DiagnosticsSnapshot Diagnostics = new Services.DiagnosticsSnapshot();
        public void OnLoad(UpdateSystem updateSystem)
        {
            Log.Info($"{ModName} {ModVersion} loading");
            updateSystem.UpdateAt<Services.CoreBootstrapSystem>(SystemUpdatePhase.GameSimulation);
        }
        public void OnDispose() { Log.Info($"{ModName} disposed"); }
    }
}
