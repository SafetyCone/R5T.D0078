using System;


namespace R5T.D0078.A001
{
    public static class IServicesAggregation01IncrementExtensions
    {
        public static T FillFrom<T>(this T aggregation,
            IServicesAggregation01Increment other)
            where T : IServicesAggregation01Increment
        {
            aggregation.VisualStudioSolutionFileOperatorAction = other.VisualStudioSolutionFileOperatorAction;
            aggregation.VisualStudioSolutionFileOperatorExtensionAction = other.VisualStudioSolutionFileOperatorExtensionAction;

            return aggregation;
        }
    }
}
