using HotChocolate.Data;
using HotChocolate.Data.Filters;
using HotChocolate.Data.Filters.Expressions;

namespace Filtering.Demo
{
    public class CustomFilteringConvention : FilterConvention
    {
        protected override void Configure(IFilterConventionDescriptor descriptor)
        {
            descriptor.AddDefaults();
            descriptor.Operation(DefaultFilterOperations.Equals).Name("equals");
            descriptor.AddProviderExtension(
                new QueryableFilterProviderExtension(
                    x => x.AddFieldHandler<QueryableStringInvariantEqualsHandler>()));
        }
    }
}
