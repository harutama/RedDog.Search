﻿using System.Collections.Generic;
using System.Collections.ObjectModel;
using Newtonsoft.Json;

namespace RedDog.Search.Model
{
    public class ScoringProfile
    {
        public ScoringProfile()
        {
            Functions = new Collection<ScoringProfileFunction>();
        }

        [JsonProperty("name")]
        public string Name
        {
            get;
            set;
        }

        [JsonProperty("text")]
        public ScoringProfileText Text
        {
            get;
            set;
        }

        [JsonProperty("functions")]
        public ICollection<ScoringProfileFunction> Functions
        {
            get;
            set;
        }

        [JsonProperty("functionAggregation")]
        public FunctionAggregation FunctionAggregation
        {
            get;
            set;
        }
    }
}