using System;

using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

using R5T.Dacia;
using R5T.Lombardy;
using R5T.Magyar.Extensions;

using R5T.D0077.A001;

using R5T.D0078.Default;


namespace R5T.D0078.A001
{
    public static class IServiceCollectionExtensions
    {
        public static ServicesAggregation01 AddVisualStudioSolutionFileOperatorServices(this IServiceCollection services,
            IServiceAction<IConfiguration> configurationAction,
            IServiceAction<IFileNameOperator> fileNameOperatorAction,
            IServiceAction<IStringlyTypedPathOperator> stringlyTypedPathOperatorAction)
        {
            var dotnetExecutableServices = services.AddDotnetExecutableServices(
                configurationAction);

            var visualStudioSolutionFileOperatorAction = services.AddVisualStudioSolutionFileOperatorAction_Old(
                dotnetExecutableServices.DotnetOperatorAction);

            var visualStudioSolutionFileOperatorExtensionAction = services.AddVisualStudioSolutionFileOperatorExtensionAction_Old(
                fileNameOperatorAction,
                stringlyTypedPathOperatorAction,
                visualStudioSolutionFileOperatorAction);

            return new ServicesAggregation01()
                .ModifyAs<ServicesAggregation01, IServicesAggregation01Increment>(increment =>
                {
                    increment.VisualStudioSolutionFileOperatorAction = visualStudioSolutionFileOperatorAction;
                    increment.VisualStudioSolutionFileOperatorExtensionAction = visualStudioSolutionFileOperatorExtensionAction;
                })
                .FillFrom(dotnetExecutableServices);
        }
    }
}
