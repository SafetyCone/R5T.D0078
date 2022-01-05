using System;

using R5T.T0063;


namespace R5T.D0078.A002
{
    public class ServiceActionAggregation01 : IServiceActionAggregation01
    {
        public IServiceAction<IVisualStudioSolutionFileOperator> VisualStudioSolutionFileOperatorAction { get; set; }
        public IServiceAction<IVisualStudioSolutionFileOperatorExtension> VisualStudioSolutionFileOperatorExtensionAction { get; set; }
    }
}
