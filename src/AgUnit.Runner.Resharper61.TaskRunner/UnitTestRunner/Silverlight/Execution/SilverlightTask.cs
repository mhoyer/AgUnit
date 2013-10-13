using System;
using System.Collections.Generic;
using AgUnit.Runner.Resharper61.UnitTestFramework.Silverlight;
using AgUnit.Runner.Resharper80;

namespace AgUnit.Runner.Resharper61.TaskRunner.UnitTestRunner.Silverlight.Execution
{
    public class SilverlightTask
    {
        public TaskNode Node { get; private set; }

        public SilverlightTask(TaskNode node)
        {
            Node = node;
        }

        public void Execute(Action<SilverlightTask> execute)
        {
            Node.Execute(execute, this);
        }

        private SilverlightUnitTestTask GetTask()
        {
            return (SilverlightUnitTestTask)Node.Task;
        }

        public bool HasXapPath()
        {
            return !string.IsNullOrWhiteSpace(GetTask().XapPath);
        }

        public IEnumerable<string> GetXapPaths()
        {
            return HasXapPath() ? new[] { GetTask().XapPath } : new string[0];
        }

        public IEnumerable<string> GetDllPaths()
        {
            return !HasXapPath() ? new[] { GetTask().DllPath } : new string[0];
        }

        public AgUnitSettings GetSettings()
        {
            return GetTask().Settings;
        }
    }
}