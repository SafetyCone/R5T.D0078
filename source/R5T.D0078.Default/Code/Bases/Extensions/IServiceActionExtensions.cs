using System;

using R5T.Lombardy;

using R5T.D0077;
using R5T.T0062;
using R5T.T0063;


namespace R5T.D0078.Default
{
    public static class IServiceActionExtensions
    {
        /// <summary>
        /// Adds the <see cref="VisualStudioSolutionFileOperator"/> implementation of <see cref="IVisualStudioSolutionFileOperator"/> as a <see cref="Microsoft.Extensions.DependencyInjection.ServiceLifetime.Singleton"/>.
        /// </summary>
        public static IServiceAction<IVisualStudioSolutionFileOperator> AddVisualStudioSolutionFileOperatorAction(this IServiceAction _,
            IServiceAction<IDotnetOperator> dotnetOperatorAction)
        {
            var serviceAction = _.New<IVisualStudioSolutionFileOperator>(services => services.AddVisualStudioSolutionFileOperator(
                dotnetOperatorAction));

            return serviceAction;
        }

        /// <summary>
        /// Adds the <see cref="VisualStudioSolutionFileOperatorExtension"/> implementation of <see cref="IVisualStudioSolutionFileOperatorExtension"/> as a <see cref="Microsoft.Extensions.DependencyInjection.ServiceLifetime.Singleton"/>.
        /// </summary>
        public static IServiceAction<IVisualStudioSolutionFileOperatorExtension> AddVisualStudioSolutionFileOperatorExtensionAction(this IServiceAction _,
            IServiceAction<IFileNameOperator> fileNameOperatorAction,
            IServiceAction<IStringlyTypedPathOperator> stringlyTypedPathOperatorAction,
            IServiceAction<IVisualStudioSolutionFileOperator> visualStudioSolutionFileOperatorAction)
        {
            var serviceAction = _.New<IVisualStudioSolutionFileOperatorExtension>(services => services.AddVisualStudioSolutionFileOperatorExtension(
                fileNameOperatorAction,
                stringlyTypedPathOperatorAction,
                visualStudioSolutionFileOperatorAction));

            return serviceAction;
        }
    }
}
