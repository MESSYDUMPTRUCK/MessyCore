using Game;
namespace MessyCore.Services
{
    public partial class CoreBootstrapSystem : GameSystemBase
    {
        protected override void OnCreate()
        {
            base.OnCreate();
            Mod.Registry.Register("MessyCore");
            Mod.Capabilities.Set("core.profile", Mod.Settings.ActivePackProfile);
            Mod.Capabilities.Set("core.diagnostics", Mod.Settings.ShowDiagnostics ? "enabled" : "disabled");
            Mod.Diagnostics.SetProfile(Mod.Settings.ActivePackProfile);
            Mod.Diagnostics.SetState("core.module", "ready");
        }
        protected override void OnUpdate()
        {
            Mod.Diagnostics.SetState("core.runtime", "active");
        }
    }
}
