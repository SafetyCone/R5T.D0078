using System;

using R5T.D0074;
using R5T.D0077;
using R5T.Dacia;


namespace R5T.D0078.A001
{
    public class ServiceActionAggregation01 : IServiceActionAggregation01
    {
        public IServiceAction<IVisualStudioSolutionFileOperator> VisualStudioSolutionFileOperatorAction { get; set; }
        public IServiceAction<IVisualStudioSolutionFileOperatorExtension> VisualStudioSolutionFileOperatorExtensionAction { get; set; }
        public T0063.IServiceAction<IDotnetExecutableFilePathProvider> DotnetExecutableFilePathProviderAction { get; set; }
        public T0063.IServiceAction<IDotnetOperator> DotnetOperatorAction { get; set; }
        public T0063.IServiceAction<ITaskQueue> TaskQueueAction { get; set; }
        public T0063.IServiceAction<ITaskQueueConstructor> TaskQueueConstructorAction { get; set; }
        public T0063.IServiceAction<D0075.ICommandLineOperator> BaseCommandLineOperatorAction { get; set; }
        public T0063.IServiceAction<D0076.ICommandLineOperator> CommandLineOperatorAction { get; set; }
        T0063.IServiceAction<IVisualStudioSolutionFileOperator> IServiceActionAggregation01Increment.VisualStudioSolutionFileOperatorAction { get; set; }
        T0063.IServiceAction<IVisualStudioSolutionFileOperatorExtension> IServiceActionAggregation01Increment.VisualStudioSolutionFileOperatorExtensionAction { get; set; }
    }
}
