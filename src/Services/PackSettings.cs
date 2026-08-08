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
        public string ActivePackProfile { get; set; } = "default";
    }
}
