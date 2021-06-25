using System;

using R5T.Dacia;


namespace R5T.D0078.A001
{
    public class ServicesAggregation01 : D0077.A001.ServicesAggregation01, IServicesAggregation01
    {
        public IServiceAction<IVisualStudioSolutionFileOperator> VisualStudioSolutionFileOperatorAction { get; set; }
        public IServiceAction<IVisualStudioSolutionFileOperatorExtension> VisualStudioSolutionFileOperatorExtensionAction { get; set; }
    }
}
