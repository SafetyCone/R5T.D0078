using System;

using R5T.T0063;


namespace R5T.D0078.A001
{
    public interface IServiceActionAggregation01Increment
    {
        IServiceAction<IVisualStudioSolutionFileOperator> VisualStudioSolutionFileOperatorAction { get; set; }
        IServiceAction<IVisualStudioSolutionFileOperatorExtension> VisualStudioSolutionFileOperatorExtensionAction { get; set; }
    }
}
