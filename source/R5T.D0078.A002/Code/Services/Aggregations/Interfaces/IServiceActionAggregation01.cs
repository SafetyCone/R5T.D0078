using System;

using R5T.T0063;


namespace R5T.D0078.A002
{
    public interface IServiceActionAggregation01
    {
        IServiceAction<IVisualStudioSolutionFileOperator> VisualStudioSolutionFileOperatorAction { get; set; }
        IServiceAction<IVisualStudioSolutionFileOperatorExtension> VisualStudioSolutionFileOperatorExtensionAction { get; set; }
    }
}
