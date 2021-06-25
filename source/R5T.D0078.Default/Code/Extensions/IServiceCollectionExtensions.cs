using System;

using Microsoft.Extensions.DependencyInjection;

using R5T.Dacia;
using R5T.Lombardy;

using R5T.D0077;


namespace R5T.D0078.Default
{
    public static class IServiceCollectionExtensions
    {
        /// <summary>
        /// Adds the <see cref="VisualStudioSolutionFileOperator"/> implementation of <see cref="IVisualStudioSolutionFileOperator"/> as a <see cref="ServiceLifetime.Singleton"/>.
        /// </summary>
        public static IServiceCollection AddVisualStudioSolutionFileOperator(this IServiceCollection services,
            IServiceAction<IDotnetOperator> dotnetOperatorAction)
        {
            services.AddSingleton<IVisualStudioSolutionFileOperator, VisualStudioSolutionFileOperator>()
                .Run(dotnetOperatorAction)
                ;

            return services;
        }

        /// <summary>
        /// Adds the <see cref="VisualStudioSolutionFileOperator"/> implementation of <see cref="IVisualStudioSolutionFileOperator"/> as a <see cref="ServiceLifetime.Singleton"/>.
        /// </summary>
        public static IServiceAction<IVisualStudioSolutionFileOperator> AddVisualStudioSolutionFileOperatorAction(this IServiceCollection services,
            IServiceAction<IDotnetOperator> dotnetOperatorAction)
        {
            var serviceAction = ServiceAction.New<IVisualStudioSolutionFileOperator>(() => services.AddVisualStudioSolutionFileOperator(
                dotnetOperatorAction));

            return serviceAction;
        }

        /// <summary>
        /// Adds the <see cref="VisualStudioSolutionFileOperatorExtension"/> implementation of <see cref="IVisualStudioSolutionFileOperatorExtension"/> as a <see cref="ServiceLifetime.Singleton"/>.
        /// </summary>
        public static IServiceCollection AddVisualStudioSolutionFileOperatorExtension(this IServiceCollection services,
            IServiceAction<IFileNameOperator> fileNameOperatorAction,
            IServiceAction<IStringlyTypedPathOperator> stringlyTypedPathOperatorAction,
            IServiceAction<IVisualStudioSolutionFileOperator> visualStudioSolutionFileOperatorAction)
        {
            services.AddSingleton<IVisualStudioSolutionFileOperatorExtension, VisualStudioSolutionFileOperatorExtension>()
                .Run(fileNameOperatorAction)
                .Run(stringlyTypedPathOperatorAction)
                .Run(visualStudioSolutionFileOperatorAction)
                ;

            return services;
        }

        /// <summary>
        /// Adds the <see cref="VisualStudioSolutionFileOperatorExtension"/> implementation of <see cref="IVisualStudioSolutionFileOperatorExtension"/> as a <see cref="ServiceLifetime.Singleton"/>.
        /// </summary>
        public static IServiceAction<IVisualStudioSolutionFileOperatorExtension> AddVisualStudioSolutionFileOperatorExtensionAction(this IServiceCollection services,
            IServiceAction<IFileNameOperator> fileNameOperatorAction,
            IServiceAction<IStringlyTypedPathOperator> stringlyTypedPathOperatorAction,
            IServiceAction<IVisualStudioSolutionFileOperator> visualStudioSolutionFileOperatorAction)
        {
            var serviceAction = ServiceAction.New<IVisualStudioSolutionFileOperatorExtension>(() => services.AddVisualStudioSolutionFileOperatorExtension(
                fileNameOperatorAction,
                stringlyTypedPathOperatorAction,
                visualStudioSolutionFileOperatorAction));

            return serviceAction;
        }
    }
}
