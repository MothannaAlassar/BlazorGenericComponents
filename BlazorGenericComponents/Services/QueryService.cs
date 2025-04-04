using BlazorGenericComponents.Components;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
namespace BlazorGenericComponents.Services
{
    public class QueryService
    {
        public IQueryable<T> ApplyQueries<T>(IQueryable<T> query, IEnumerable<QueryHeaderCompo<T>.QueryF> queries) // Update here
            where T : class
        {
            foreach (var q in queries)
            {
                switch (q.Operator)
                {
                    case "=":
                        query = query.Where(e => EF.Property<string>(e, q.Field) == q.Value);
                        break;
                    case "!=":
                        query = query.Where(e => EF.Property<string>(e, q.Field) != q.Value);
                        break;
                    case ">":
                        if (int.TryParse(q.Value, out int greaterThanValue))
                        {
                            query = query.Where(e => EF.Property<int>(e, q.Field) > greaterThanValue);
                        }
                        break;
                    case "<":
                        if (int.TryParse(q.Value, out int lessThanValue))
                        {
                            query = query.Where(e => EF.Property<int>(e, q.Field) < lessThanValue);
                        }
                        break;
                    case "LIKE":
                        query = query.Where(e => EF.Functions.Like(EF.Property<string>(e, q.Field), $"%{q.Value}%"));
                        break;
                }
            }
            return query;
        }

        public IEnumerable<T> ApplyQueries<T>(IEnumerable<T> query, IEnumerable<QueryHeaderCompo<T>.QueryF> queries) // Update here
            where T : class
        {
            foreach (var q in queries)
            {
                switch (q.Operator)
                {
                    case "=":
                        query = query.Where(e => EF.Property<string>(e, q.Field) == q.Value);
                        break;
                    case "!=":
                        query = query.Where(e => EF.Property<string>(e, q.Field) != q.Value);
                        break;
                    case ">":
                        if (int.TryParse(q.Value, out int greaterThanValue))
                        {
                            query = query.Where(e => EF.Property<int>(e, q.Field) > greaterThanValue);
                        }
                        break;
                    case "<":
                        if (int.TryParse(q.Value, out int lessThanValue))
                        {
                            query = query.Where(e => EF.Property<int>(e, q.Field) < lessThanValue);
                        }
                        break;
                    case "LIKE":
                        query = query.Where(e => EF.Functions.Like(EF.Property<string>(e, q.Field), $"%{q.Value}%"));
                        break;
                }
            }
            return query;
        }

    }

}
