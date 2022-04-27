using System;

using R5T.Lombardy;

using R5T.T0062;
using R5T.T0063;

using IVisualStudioSolutionFileOperatorCore = R5T.D0078.IVisualStudioSolutionFileOperator;


namespace R5T.D0078.D001.I001
{
    public static class IServiceActionExtensions
    {
        /// <summary>
        /// Adds the <see cref="VisualStudioSolutionFileOperator"/> implementation of <see cref="IVisualStudioSolutionFileOperator"/> as a <see cref="ServiceLifetime.Singleton"/>.
        /// </summary>
        public static IServiceAction<IVisualStudioSolutionFileOperator> AddVisualStudioSolutionFileOperatorAction(this IServiceAction _,
            IServiceAction<IStringlyTypedPathOperator> stringlyTypedPathOperatorAction,
            IServiceAction<IVisualStudioSolutionFileOperatorCore> visualStudioSolutionFileOperatorCoreAction)
        {
            var serviceAction = _.New<IVisualStudioSolutionFileOperator>(services => services.AddVisualStudioSolutionFileOperator(
                stringlyTypedPathOperatorAction,
                visualStudioSolutionFileOperatorCoreAction));

            return serviceAction;
        }
    }
}
