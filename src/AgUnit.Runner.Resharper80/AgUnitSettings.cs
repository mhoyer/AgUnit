using JetBrains.Application.Settings;

namespace AgUnit.Runner.Resharper80
{
    [SettingsKey(typeof(EnvironmentSettings), "AgUnitSettings")]
    public class AgUnitSettings
    {
        [SettingsEntry(false, "Show Browser Window")]
        public bool IsBrowserWindowEnabled { get; set; }
    }
}