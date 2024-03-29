using System;

using Microsoft.Extensions.DependencyInjection;

using R5T.Dacia;
using R5T.Lombardy;

using IVisualStudioSolutionFileOperatorCore = R5T.D0078.IVisualStudioSolutionFileOperator;


namespace R5T.D0078.D001.I001
{
    public static partial class IServiceCollectionExtensions
    {
        /// <summary>
        /// Adds the <see cref="VisualStudioSolutionFileOperator"/> implementation of <see cref="IVisualStudioSolutionFileOperator"/> as a <see cref="ServiceLifetime.Singleton"/>.
        /// </summary>
        public static IServiceCollection AddVisualStudioSolutionFileOperator_Old(this IServiceCollection services,
            IServiceAction<IStringlyTypedPathOperator> stringlyTypedPathOperatorAction,
            IServiceAction<IVisualStudioSolutionFileOperatorCore> visualStudioSolutionFileOperatorCoreAction)
        {
            services.AddSingleton<IVisualStudioSolutionFileOperator, VisualStudioSolutionFileOperator>()
                .Run(stringlyTypedPathOperatorAction)
                .Run(visualStudioSolutionFileOperatorCoreAction)
                ;

            return services;
        }

        /// <summary>
        /// Adds the <see cref="VisualStudioSolutionFileOperator"/> implementation of <see cref="IVisualStudioSolutionFileOperator"/> as a <see cref="ServiceLifetime.Singleton"/>.
        /// </summary>
        public static IServiceAction<IVisualStudioSolutionFileOperator> AddVisualStudioSolutionFileOperatorAction_Old(this IServiceCollection services,
            IServiceAction<IStringlyTypedPathOperator> stringlyTypedPathOperatorAction,
            IServiceAction<IVisualStudioSolutionFileOperatorCore> visualStudioSolutionFileOperatorCoreAction)
        {
            var serviceAction = ServiceAction.New<IVisualStudioSolutionFileOperator>(() => services.AddVisualStudioSolutionFileOperator_Old(
                stringlyTypedPathOperatorAction,
                visualStudioSolutionFileOperatorCoreAction));

            return serviceAction;
        }
    }
}