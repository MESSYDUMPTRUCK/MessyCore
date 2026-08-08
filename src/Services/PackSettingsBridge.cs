using Game;
namespace MessyCore.Services
{
    public partial class PackSettingsBridge : GameSystemBase
    {
        protected override void OnCreate()
        {
            base.OnCreate();
            Mod.Settings.ApplyProfileDefaults();
            Mod.Diagnostics.SetProfile(Mod.Settings.ActivePackProfile);
            Mod.Diagnostics.SetState("settings.traffic-module", Mod.Settings.TrafficModuleEnabled ? "on" : "off");
            Mod.Diagnostics.SetState("settings.road-module", Mod.Settings.RoadToolsModuleEnabled ? "on" : "off");
            Mod.Diagnostics.SetState("settings.tooltip-module", Mod.Settings.TooltipModuleEnabled ? "on" : "off");
            Mod.Diagnostics.SetState("settings.node-controller", Mod.Settings.EnableNodeController ? "on" : "off");
            Mod.Diagnostics.SetState("settings.directional-lights", Mod.Settings.EnableDirectionalLightManagement ? "on" : "off");
        }
        protected override void OnUpdate() { }
    }
}
