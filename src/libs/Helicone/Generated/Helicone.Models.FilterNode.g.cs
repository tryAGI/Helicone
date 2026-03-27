#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Helicone
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct FilterNode : global::System.IEquatable<FilterNode>
    {
        /// <summary>
        /// Make all properties in T optional
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Helicone.PartialTablesAndViews? Value1 { get; init; }
#else
        public global::Helicone.PartialTablesAndViews? Value1 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Value1))]
#endif
        public bool IsValue1 => Value1 != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Helicone.FilterBranch? Value2 { get; init; }
#else
        public global::Helicone.FilterBranch? Value2 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Value2))]
#endif
        public bool IsValue2 => Value2 != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public object? Value3 { get; init; }
#else
        public object? Value3 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Value3))]
#endif
        public bool IsValue3 => Value3 != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Helicone.FilterNodeEnum2? Value4 { get; init; }
#else
        public global::Helicone.FilterNodeEnum2? Value4 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Value4))]
#endif
        public bool IsValue4 => Value4 != null;
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator FilterNode(global::Helicone.PartialTablesAndViews value) => new FilterNode((global::Helicone.PartialTablesAndViews?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Helicone.PartialTablesAndViews?(FilterNode @this) => @this.Value1;

        /// <summary>
        /// 
        /// </summary>
        public FilterNode(global::Helicone.PartialTablesAndViews? value)
        {
            Value1 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator FilterNode(global::Helicone.FilterBranch value) => new FilterNode((global::Helicone.FilterBranch?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Helicone.FilterBranch?(FilterNode @this) => @this.Value2;

        /// <summary>
        /// 
        /// </summary>
        public FilterNode(global::Helicone.FilterBranch? value)
        {
            Value2 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator FilterNode(global::Helicone.FilterNodeEnum2 value) => new FilterNode((global::Helicone.FilterNodeEnum2?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Helicone.FilterNodeEnum2?(FilterNode @this) => @this.Value4;

        /// <summary>
        /// 
        /// </summary>
        public FilterNode(global::Helicone.FilterNodeEnum2? value)
        {
            Value4 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public FilterNode(
            global::Helicone.PartialTablesAndViews? value1,
            global::Helicone.FilterBranch? value2,
            object? value3,
            global::Helicone.FilterNodeEnum2? value4
            )
        {
            Value1 = value1;
            Value2 = value2;
            Value3 = value3;
            Value4 = value4;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            Value4 as object ??
            Value3 as object ??
            Value2 as object ??
            Value1 as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            Value1?.ToString() ??
            Value2?.ToString() ??
            Value3?.ToString() ??
            Value4?.ToValueString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsValue1 || IsValue2 || IsValue3 || IsValue4;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Helicone.PartialTablesAndViews?, TResult>? value1 = null,
            global::System.Func<global::Helicone.FilterBranch?, TResult>? value2 = null,
            global::System.Func<object?, TResult>? value3 = null,
            global::System.Func<global::Helicone.FilterNodeEnum2?, TResult>? value4 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsValue1 && value1 != null)
            {
                return value1(Value1!);
            }
            else if (IsValue2 && value2 != null)
            {
                return value2(Value2!);
            }
            else if (IsValue3 && value3 != null)
            {
                return value3(Value3!);
            }
            else if (IsValue4 && value4 != null)
            {
                return value4(Value4!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::Helicone.PartialTablesAndViews?>? value1 = null,
            global::System.Action<global::Helicone.FilterBranch?>? value2 = null,
            global::System.Action<object?>? value3 = null,
            global::System.Action<global::Helicone.FilterNodeEnum2?>? value4 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsValue1)
            {
                value1?.Invoke(Value1!);
            }
            else if (IsValue2)
            {
                value2?.Invoke(Value2!);
            }
            else if (IsValue3)
            {
                value3?.Invoke(Value3!);
            }
            else if (IsValue4)
            {
                value4?.Invoke(Value4!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                Value1,
                typeof(global::Helicone.PartialTablesAndViews),
                Value2,
                typeof(global::Helicone.FilterBranch),
                Value3,
                typeof(object),
                Value4,
                typeof(global::Helicone.FilterNodeEnum2),
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
        public bool Equals(FilterNode other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Helicone.PartialTablesAndViews?>.Default.Equals(Value1, other.Value1) &&
                global::System.Collections.Generic.EqualityComparer<global::Helicone.FilterBranch?>.Default.Equals(Value2, other.Value2) &&
                global::System.Collections.Generic.EqualityComparer<object?>.Default.Equals(Value3, other.Value3) &&
                global::System.Collections.Generic.EqualityComparer<global::Helicone.FilterNodeEnum2?>.Default.Equals(Value4, other.Value4) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(FilterNode obj1, FilterNode obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<FilterNode>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(FilterNode obj1, FilterNode obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is FilterNode o && Equals(o);
        }
    }
}
