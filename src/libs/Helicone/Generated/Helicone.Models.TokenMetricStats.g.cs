#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Helicone
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct TokenMetricStats : global::System.IEquatable<TokenMetricStats>
    {
        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Helicone.MetricStats? MetricStats { get; init; }
#else
        public global::Helicone.MetricStats? MetricStats { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(MetricStats))]
#endif
        public bool IsMetricStats => MetricStats != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Helicone.TokenMetricStatsVariant2? TokenMetricStatsVariant2 { get; init; }
#else
        public global::Helicone.TokenMetricStatsVariant2? TokenMetricStatsVariant2 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(TokenMetricStatsVariant2))]
#endif
        public bool IsTokenMetricStatsVariant2 => TokenMetricStatsVariant2 != null;
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator TokenMetricStats(global::Helicone.MetricStats value) => new TokenMetricStats((global::Helicone.MetricStats?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Helicone.MetricStats?(TokenMetricStats @this) => @this.MetricStats;

        /// <summary>
        /// 
        /// </summary>
        public TokenMetricStats(global::Helicone.MetricStats? value)
        {
            MetricStats = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator TokenMetricStats(global::Helicone.TokenMetricStatsVariant2 value) => new TokenMetricStats((global::Helicone.TokenMetricStatsVariant2?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Helicone.TokenMetricStatsVariant2?(TokenMetricStats @this) => @this.TokenMetricStatsVariant2;

        /// <summary>
        /// 
        /// </summary>
        public TokenMetricStats(global::Helicone.TokenMetricStatsVariant2? value)
        {
            TokenMetricStatsVariant2 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public TokenMetricStats(
            global::Helicone.MetricStats? metricStats,
            global::Helicone.TokenMetricStatsVariant2? tokenMetricStatsVariant2
            )
        {
            MetricStats = metricStats;
            TokenMetricStatsVariant2 = tokenMetricStatsVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            TokenMetricStatsVariant2 as object ??
            MetricStats as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            MetricStats?.ToString() ??
            TokenMetricStatsVariant2?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsMetricStats && IsTokenMetricStatsVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Helicone.MetricStats?, TResult>? metricStats = null,
            global::System.Func<global::Helicone.TokenMetricStatsVariant2?, TResult>? tokenMetricStatsVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsMetricStats && metricStats != null)
            {
                return metricStats(MetricStats!);
            }
            else if (IsTokenMetricStatsVariant2 && tokenMetricStatsVariant2 != null)
            {
                return tokenMetricStatsVariant2(TokenMetricStatsVariant2!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::Helicone.MetricStats?>? metricStats = null,
            global::System.Action<global::Helicone.TokenMetricStatsVariant2?>? tokenMetricStatsVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsMetricStats)
            {
                metricStats?.Invoke(MetricStats!);
            }
            else if (IsTokenMetricStatsVariant2)
            {
                tokenMetricStatsVariant2?.Invoke(TokenMetricStatsVariant2!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                MetricStats,
                typeof(global::Helicone.MetricStats),
                TokenMetricStatsVariant2,
                typeof(global::Helicone.TokenMetricStatsVariant2),
            };
            const int offset = unchecked((int)2166136261);
            const int prime = 16777619;
            static int HashCodeAggregator(int hashCode, object? value) => value == null
                ? (hashCode ^ 0) * prime
                : (hashCode ^ value.GetHashCode()) * prime;

            return global::System.Linq.Enumerable.Aggregate(fields, offset, HashCodeAggregator);
        }

        /// <summary>
        /// 
        /// </summary>
        public bool Equals(TokenMetricStats other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Helicone.MetricStats?>.Default.Equals(MetricStats, other.MetricStats) &&
                global::System.Collections.Generic.EqualityComparer<global::Helicone.TokenMetricStatsVariant2?>.Default.Equals(TokenMetricStatsVariant2, other.TokenMetricStatsVariant2) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(TokenMetricStats obj1, TokenMetricStats obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<TokenMetricStats>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(TokenMetricStats obj1, TokenMetricStats obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is TokenMetricStats o && Equals(o);
        }
    }
}
