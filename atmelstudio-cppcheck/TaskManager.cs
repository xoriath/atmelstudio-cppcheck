using atmelstudio_cppcheck.Runner;
using Microsoft.VisualStudio.Shell;
using System;
using System.Collections.Generic;

namespace atmelstudio_cppcheck
{
    public class TaskManager
    {
        private IServiceProvider serviceProvider;
        private ErrorListProvider errorListProvider;

        private List<CppCheckErrorTask> tasks = new List<CppCheckErrorTask>();

        private static TaskManager instance = null;

        public static void Initialize(IServiceProvider serviceProvider)
        {
            if (instance == null)
                instance = new TaskManager();

            instance.serviceProvider = serviceProvider;
            instance.errorListProvider = new ErrorListProvider(serviceProvider);
        }

        public void AddError(CppCheckErrorTask error)
        {
            tasks.Add(error);
            errorListProvider.Tasks.Add(error);
        }

        public void Clear()
        {
            foreach(var error in tasks)
            {
                errorListProvider.Tasks.Remove(error);
            }

            tasks.Clear();
        }

        public static TaskManager Instance => instance;
    }
}
