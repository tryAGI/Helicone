#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Helicone
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct SessionFilterNode : global::System.IEquatable<SessionFilterNode>
    {
        /// <summary>
        /// From T, pick a set of properties whose keys are in the union K
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Helicone.PickFilterLeafRequestResponseRmtOrSessionsRequestResponseRmt? Value1 { get; init; }
#else
        public global::Helicone.PickFilterLeafRequestResponseRmtOrSessionsRequestResponseRmt? Value1 { get; }
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
        public global::Helicone.SessionFilterBranch? Value2 { get; init; }
#else
        public global::Helicone.SessionFilterBranch? Value2 { get; }
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
        public global::Helicone.SessionFilterNodeEnum? Value3 { get; init; }
#else
        public global::Helicone.SessionFilterNodeEnum? Value3 { get; }
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
        public static implicit operator SessionFilterNode(global::Helicone.PickFilterLeafRequestResponseRmtOrSessionsRequestResponseRmt value) => new SessionFilterNode((global::Helicone.PickFilterLeafRequestResponseRmtOrSessionsRequestResponseRmt?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Helicone.PickFilterLeafRequestResponseRmtOrSessionsRequestResponseRmt?(SessionFilterNode @this) => @this.Value1;

        /// <summary>
        /// 
        /// </summary>
        public SessionFilterNode(global::Helicone.PickFilterLeafRequestResponseRmtOrSessionsRequestResponseRmt? value)
        {
            Value1 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator SessionFilterNode(global::Helicone.SessionFilterBranch value) => new SessionFilterNode((global::Helicone.SessionFilterBranch?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Helicone.SessionFilterBranch?(SessionFilterNode @this) => @this.Value2;

        /// <summary>
        /// 
        /// </summary>
        public SessionFilterNode(global::Helicone.SessionFilterBranch? value)
        {
            Value2 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator SessionFilterNode(global::Helicone.SessionFilterNodeEnum value) => new SessionFilterNode((global::Helicone.SessionFilterNodeEnum?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Helicone.SessionFilterNodeEnum?(SessionFilterNode @this) => @this.Value3;

        /// <summary>
        /// 
        /// </summary>
        public SessionFilterNode(global::Helicone.SessionFilterNodeEnum? value)
        {
            Value3 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public SessionFilterNode(
            global::Helicone.PickFilterLeafRequestResponseRmtOrSessionsRequestResponseRmt? value1,
            global::Helicone.SessionFilterBranch? value2,
            global::Helicone.SessionFilterNodeEnum? value3
            )
        {
            Value1 = value1;
            Value2 = value2;
            Value3 = value3;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
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
            Value3?.ToValueString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsValue1 || IsValue2 || IsValue3;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Helicone.PickFilterLeafRequestResponseRmtOrSessionsRequestResponseRmt?, TResult>? value1 = null,
            global::System.Func<global::Helicone.SessionFilterBranch?, TResult>? value2 = null,
            global::System.Func<global::Helicone.SessionFilterNodeEnum?, TResult>? value3 = null,
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

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::Helicone.PickFilterLeafRequestResponseRmtOrSessionsRequestResponseRmt?>? value1 = null,
            global::System.Action<global::Helicone.SessionFilterBranch?>? value2 = null,
            global::System.Action<global::Helicone.SessionFilterNodeEnum?>? value3 = null,
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
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                Value1,
                typeof(global::Helicone.PickFilterLeafRequestResponseRmtOrSessionsRequestResponseRmt),
                Value2,
                typeof(global::Helicone.SessionFilterBranch),
                Value3,
                typeof(global::Helicone.SessionFilterNodeEnum),
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
        public bool Equals(SessionFilterNode other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Helicone.PickFilterLeafRequestResponseRmtOrSessionsRequestResponseRmt?>.Default.Equals(Value1, other.Value1) &&
                global::System.Collections.Generic.EqualityComparer<global::Helicone.SessionFilterBranch?>.Default.Equals(Value2, other.Value2) &&
                global::System.Collections.Generic.EqualityComparer<global::Helicone.SessionFilterNodeEnum?>.Default.Equals(Value3, other.Value3) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(SessionFilterNode obj1, SessionFilterNode obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<SessionFilterNode>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(SessionFilterNode obj1, SessionFilterNode obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is SessionFilterNode o && Equals(o);
        }
    }
}
