using Newtonsoft.Json;
using System.Collections.Generic;

namespace JsonDemo
{
    [JsonObject]
    public class Person
    {
        public string Name { get; set; }

        public int age { get; set; }
    }

    [JsonObject]
    public class ControllerInput
    {
        public int ScenarioId { get; set; }

        public int IsLastSaved { get; set; }

        public bool Reload { get; set; }

        public IEnumerable<FilterOperationWrapper> Filters { get; set; }

        public CustomDataInput CustomData { get; set; }
    }

    public class FilterOperationWrapper
    {
        public int Index { get; set; }

        public FilterOperation FilterOperationValue { get; set; }
    }

    public class FilterOperation
    {
        public string Column { get; set; }

        public string CompareColumn { get; set; }

        public string Type { get; set; }

        public List<FilterApplied> AppliedFilters { get; set; }
    }

    public class FilterApplied
    {
        public string Operator { get; set; }

        public object SuppliedValue { get; set; }

        public HashSet<string> SuppliedValueHashSet { get; set; }
    }

    public class CustomDataInput
    {
        public IEnumerable<OrderClauseInput> CustomOrderClauseList { get; set; }

        public PaginateInput CustomPaginate { get; set; }

        public IEnumerable<string> SummaryInfoList { get; set; }
    }

    public class OrderClauseInput
    {
        /// <summary>
        public string ColumnName { get; set; }

        public bool IsAscending { get; set; }

    }

    public class PaginateInput
    {
        public int Page { get; set; }

        public int PageSize { get; set; }
    }
}
