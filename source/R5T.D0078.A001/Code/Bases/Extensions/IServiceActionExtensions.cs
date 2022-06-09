using System;

using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

using R5T.Lombardy;
using R5T.Magyar.Extensions;

using R5T.D0077.A001;
using R5T.T0062;
using R5T.T0063;

using R5T.D0078.Default;


namespace R5T.D0078.A001
{
    public static class IServiceActionExtensions
    {
        public static ServiceActionAggregation01 AddVisualStudioSolutionFileOperatorServices(this IServiceAction _,
            IServiceAction<IConfiguration> configurationAction,
            IServiceAction<IFileNameOperator> fileNameOperatorAction,
            IServiceAction<IStringlyTypedPathOperator> stringlyTypedPathOperatorAction)
        {
            var dotnetExecutableServices = _.AddDotnetExecutableServices(
                configurationAction);

            var visualStudioSolutionFileOperatorAction = _.AddVisualStudioSolutionFileOperatorAction(
                dotnetExecutableServices.DotnetOperatorAction);

            var visualStudioSolutionFileOperatorExtensionAction = _.AddVisualStudioSolutionFileOperatorExtensionAction(
                fileNameOperatorAction,
                stringlyTypedPathOperatorAction,
                visualStudioSolutionFileOperatorAction);

            return new ServiceActionAggregation01()
                .ModifyAs<ServiceActionAggregation01, IServiceActionAggregation01Increment>(increment =>
                {
                    increment.VisualStudioSolutionFileOperatorAction = visualStudioSolutionFileOperatorAction;
                    increment.VisualStudioSolutionFileOperatorExtensionAction = visualStudioSolutionFileOperatorExtensionAction;
                })
                .FillFrom(dotnetExecutableServices);
        }
    }
}
