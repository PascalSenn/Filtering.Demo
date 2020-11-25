using System.Collections.Generic;
using System.Data;
using System.Linq;
using HotChocolate;
using HotChocolate.Data;

namespace Filtering.Demo
{
    public class Query
    {
        [UseDbContext(typeof(ApplicationContext))]
        [UseProjection]
        [UseFiltering]
        [UseSorting]
        public IQueryable<Person> GetPersons([ScopedService] ApplicationContext context) =>
            context.Persons;
    }
}