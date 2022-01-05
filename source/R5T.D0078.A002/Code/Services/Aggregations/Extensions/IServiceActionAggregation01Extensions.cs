using System;


namespace R5T.D0078.A002
{
    public static class IServiceActionAggregation01Extensions
    {
        public static T FillFrom<T>(this T aggregation,
            IServiceActionAggregation01 other)
            where T : IServiceActionAggregation01
        {
            aggregation.VisualStudioSolutionFileOperatorAction = other.VisualStudioSolutionFileOperatorAction;
            aggregation.VisualStudioSolutionFileOperatorExtensionAction = other.VisualStudioSolutionFileOperatorExtensionAction;

            return aggregation;
        }
    }
}
