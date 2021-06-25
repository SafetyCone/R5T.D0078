using System;

using R5T.Dacia;


namespace R5T.D0078.A001
{
    public interface IServicesAggregation01Increment
    {
        IServiceAction<IVisualStudioSolutionFileOperator> VisualStudioSolutionFileOperatorAction { get; set; }
        IServiceAction<IVisualStudioSolutionFileOperatorExtension> VisualStudioSolutionFileOperatorExtensionAction { get; set; }
    }
}
