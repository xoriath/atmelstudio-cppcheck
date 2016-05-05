using atmelstudio_cppcheck.Parser;
using Microsoft.VisualStudio.Shell;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace atmelstudio_cppcheck.Runner
{
    public class CppCheckErrorTask : ErrorTask
    {
        public CppCheckError Error { get; private set; }
        public CppCheckErrorTask(CppCheckError error)
        {
            this.Error = error;

            SetFields();

        }

        private void SetFields()
        {
            this.Text = Error.Message;
            this.Document = Error.Locations.First().File;
            this.Line = Error.Locations.First().Line;

            this.ErrorCategory = GetErrorCategory();
            this.Category = GetCategory();
            this.IsCheckedEditable = false;
            this.IsPriorityEditable = false;
            this.IsTextEditable = false;
        }

        protected override void OnHelp(EventArgs e)
        {
            base.OnHelp(e);
        }

        private TaskCategory GetCategory()
        {
           return TaskCategory.BuildCompile;
        }

        private TaskErrorCategory GetErrorCategory()
        {
            switch (Error.Severity)
            {
                case CppCheckError.CppCheckErrorSeverity.Error:
                    return TaskErrorCategory.Error;
                case CppCheckError.CppCheckErrorSeverity.Information:
                    return TaskErrorCategory.Message;
                case CppCheckError.CppCheckErrorSeverity.Performance:
                case CppCheckError.CppCheckErrorSeverity.Portability:
                case CppCheckError.CppCheckErrorSeverity.Style:
                case CppCheckError.CppCheckErrorSeverity.Warning:
                default:
                    return TaskErrorCategory.Warning;
            }
        }
    }
}
