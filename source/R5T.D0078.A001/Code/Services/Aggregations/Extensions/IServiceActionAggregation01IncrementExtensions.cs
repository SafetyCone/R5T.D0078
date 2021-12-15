using System;


namespace R5T.D0078.A001
{
    public static class IServiceActionAggregation01IncrementExtensions
    {
        public static T FillFrom<T>(this T aggregation,
            IServiceActionAggregation01Increment other)
            where T : IServiceActionAggregation01Increment
        {
            aggregation.VisualStudioSolutionFileOperatorAction = other.VisualStudioSolutionFileOperatorAction;
            aggregation.VisualStudioSolutionFileOperatorExtensionAction = other.VisualStudioSolutionFileOperatorExtensionAction;

            return aggregation;
        }
    }
}
