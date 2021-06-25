using System;


namespace R5T.D0078.A001
{
    public static class IServicesAggregation01Extensions
    {
        public static T FillFrom<T>(this T aggregation,
            IServicesAggregation01 other)
            where T : IServicesAggregation01
        {
            (aggregation as D0077.A001.IServiceAggregation01).FillFrom(other);

            (aggregation as IServicesAggregation01Increment).FillFrom(other);

            return aggregation;
        }
    }
}
