﻿using System;

namespace RedDog.Search.Model
{
    public static class SearchQueryExtensions
    {
        public static SearchQuery Mode(this SearchQuery query, SearchMode mode)
        {
            query.Mode = mode;
            return query;
        }

        public static SearchQuery SearchField(this SearchQuery query, string searchField)
        {
            if (String.IsNullOrEmpty(query.SearchFields))
                query.SearchFields = searchField;
            else
                query.SearchFields += "," + searchField;
            return query;
        }

        public static SearchQuery Skip(this SearchQuery query, long skip)
        {
            query.Skip = skip;
            return query;
        }

        public static SearchQuery Top(this SearchQuery query, long top)
        {
            query.Top = top;
            return query;
        }

        public static SearchQuery Count(this SearchQuery query, bool useCount)
        {
            query.Count = useCount;
            return query;
        }

        public static SearchQuery OrderBy(this SearchQuery query, string orderByField)
        {
            if (String.IsNullOrEmpty(query.OrderBy))
                query.OrderBy = orderByField;
            else
                query.OrderBy += "," + orderByField;
            return query;
        }

        public static SearchQuery Select(this SearchQuery query, string selectField)
        {
            if (String.IsNullOrEmpty(query.Select))
                query.Select = selectField;
            else
                query.Select += "," + selectField;
            return query;
        }

        public static SearchQuery Facet(this SearchQuery query, string facetField)
        {
            if (String.IsNullOrEmpty(query.Facet))
                query.Facet = facetField;
            else
                query.Facet += "," + facetField;
            return query;
        }

        public static SearchQuery Filter(this SearchQuery query, string filter)
        {
            query.Filter = filter;
            return query;
        }

        public static SearchQuery Highlight(this SearchQuery query, string highlightField)
        {
            if (String.IsNullOrEmpty(query.Highlight))
                query.Highlight = highlightField;
            else
                query.Highlight += "," + highlightField;
            return query;
        }

        public static SearchQuery ScoringProfile(this SearchQuery query, string scoringProfile)
        {
            query.ScoringProfile = scoringProfile;
            return query;
        }

        public static SearchQuery ScoringParameter(this SearchQuery query, string scoringParameter)
        {
            query.ScoringParameter = scoringParameter;
            return query;
        }
    }
}