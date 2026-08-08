namespace MessyCore.Services
{
    public class PackSettings
    {
        public bool TrafficModuleEnabled { get; set; } = true;
        public bool RoadToolsModuleEnabled { get; set; } = true;
        public bool TooltipModuleEnabled { get; set; } = true;
        public bool ShowDiagnostics { get; set; } = true;
        public bool UseGradeAssist { get; set; } = true;
        public bool UseTrafficWarnings { get; set; } = true;
        public bool EnableTrafficSignals { get; set; } = true;
        public bool EnableRoadElevationTools { get; set; } = true;
        public bool EnableTooltipOverlays { get; set; } = true;
        public string ActivePackProfile { get; set; } = "default";

        public void ApplyProfileDefaults()
        {
            switch (ActivePackProfile)
            {
                case "minimal":
                    ShowDiagnostics = false;
                    UseTrafficWarnings = false;
                    EnableTooltipOverlays = false;
                    break;
                case "builder":
                    UseGradeAssist = true;
                    EnableRoadElevationTools = true;
                    break;
                default:
                    break;
            }
        }
    }
}
