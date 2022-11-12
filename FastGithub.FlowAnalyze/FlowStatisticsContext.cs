using System;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Text.Json.Serialization.Metadata;

namespace FastGithub.FlowAnalyze
{
    [JsonSerializable(typeof(FlowStatistics))]
    public partial class FlowStatisticsContext : JsonSerializerContext
    {
        public FlowStatisticsContext(JsonSerializerOptions? options) : base(options)
        {
        }

        protected override JsonSerializerOptions? GeneratedSerializerOptions => throw new NotImplementedException();

        public override JsonTypeInfo? GetTypeInfo(Type type)
        {
            throw new NotImplementedException();
        }
    }
}
