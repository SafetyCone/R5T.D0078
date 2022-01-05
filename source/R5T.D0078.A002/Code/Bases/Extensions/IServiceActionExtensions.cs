using System;

using R5T.Lombardy;

using R5T.D0077;
using R5T.T0062;
using R5T.T0063;

using R5T.D0078.Default;


namespace R5T.D0078.A002
{
    public static class IServiceActionExtensions
    {
        public static ServiceActionAggregation01 AddVisualStudioSolutionFileOperatorActions(this IServiceAction _,
            IServiceAction<IDotnetOperator> dotnetOperatorAction,
            IServiceAction<IFileNameOperator> fileNameOperatorAction,
            IServiceAction<IStringlyTypedPathOperator> stringlyTypedPathOperatorAction)
        {
            var visualStudioSolutionFileOperatorAction = _.AddVisualStudioSolutionFileOperatorAction(dotnetOperatorAction);

            var visualStudioSolutionFileOperatorExtensionAction = _.AddVisualStudioSolutionFileOperatorExtensionAction(
                fileNameOperatorAction,
                stringlyTypedPathOperatorAction,
                visualStudioSolutionFileOperatorAction);

            var output = new ServiceActionAggregation01
            {
                VisualStudioSolutionFileOperatorAction = visualStudioSolutionFileOperatorAction,
                VisualStudioSolutionFileOperatorExtensionAction = visualStudioSolutionFileOperatorExtensionAction,
            };

            return output;
        }
    }
}