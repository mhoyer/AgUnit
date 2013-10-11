using JetBrains.Application.Settings;
using JetBrains.DataFlow;
using JetBrains.ReSharper.UnitTestExplorer.Options;
using JetBrains.UI.Controls;
using JetBrains.UI.CrossFramework;
using JetBrains.UI.Options;
using JetBrains.UI.Resources;

namespace AgUnit.Runner.Resharper80.OptionsDialog
{
    [OptionsPage(PID, "AgUnit", typeof(OptionsThemedIcons.Options), ParentId = UnitTestingPageBase.PID)]
    public partial class AgUnitOptionsPage : IOptionsPage
    {
        public const string PID = "AgUnitOptionsPage";

        public AgUnitOptionsPage(Lifetime lifetime, OptionsSettingsSmartContext settings)
        {
            InitializeComponent();
            settings.SetBinding(
                lifetime, 
                (AgUnitSettings s) => s.IsBrowserWindowEnabled, 
                isBrowserWindowEnabledCheckBox,
                CheckBoxDisabledNoCheck2.IsCheckedLogicallyDependencyProperty);
        }

        public bool OnOk()
        {
            return true;
        }

        public bool ValidatePage()
        {
            return true;
        }

        public EitherControl Control
        {
            get { return this; }
        }

        public string Id { get; private set; }
    }
}
