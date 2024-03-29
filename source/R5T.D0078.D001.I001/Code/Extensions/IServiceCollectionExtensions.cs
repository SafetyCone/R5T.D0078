using System;

using Microsoft.Extensions.DependencyInjection;

using R5T.Lombardy;

using R5T.T0063;

using IVisualStudioSolutionFileOperatorCore = R5T.D0078.IVisualStudioSolutionFileOperator;


namespace R5T.D0078.D001.I001
{
    public static partial class IServiceCollectionExtensions
    {
        /// <summary>
        /// Adds the <see cref="VisualStudioSolutionFileOperator"/> implementation of <see cref="IVisualStudioSolutionFileOperator"/> as a <see cref="ServiceLifetime.Singleton"/>.
        /// </summary>
        public static IServiceCollection AddVisualStudioSolutionFileOperator(this IServiceCollection services,
            IServiceAction<IStringlyTypedPathOperator> stringlyTypedPathOperatorAction,
            IServiceAction<IVisualStudioSolutionFileOperatorCore> visualStudioSolutionFileOperatorCoreAction)
        {
            services
                .Run(stringlyTypedPathOperatorAction)
                .Run(visualStudioSolutionFileOperatorCoreAction)
                .AddSingleton<IVisualStudioSolutionFileOperator, VisualStudioSolutionFileOperator>()
                ;

            return services;
        }
    }
}