#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Helicone
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct ExperimentFilterNode : global::System.IEquatable<ExperimentFilterNode>
    {
        /// <summary>
        /// From T, pick a set of properties whose keys are in the union K
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Helicone.PickFilterLeafExperiment? Value1 { get; init; }
#else
        public global::Helicone.PickFilterLeafExperiment? Value1 { get; }
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
        public global::Helicone.ExperimentFilterBranch? Value2 { get; init; }
#else
        public global::Helicone.ExperimentFilterBranch? Value2 { get; }
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
        public global::Helicone.ExperimentFilterNodeEnum? Value3 { get; init; }
#else
        public global::Helicone.ExperimentFilterNodeEnum? Value3 { get; }
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
        public static implicit operator ExperimentFilterNode(global::Helicone.PickFilterLeafExperiment value) => new ExperimentFilterNode((global::Helicone.PickFilterLeafExperiment?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Helicone.PickFilterLeafExperiment?(ExperimentFilterNode @this) => @this.Value1;

        /// <summary>
        /// 
        /// </summary>
        public ExperimentFilterNode(global::Helicone.PickFilterLeafExperiment? value)
        {
            Value1 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ExperimentFilterNode(global::Helicone.ExperimentFilterBranch value) => new ExperimentFilterNode((global::Helicone.ExperimentFilterBranch?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Helicone.ExperimentFilterBranch?(ExperimentFilterNode @this) => @this.Value2;

        /// <summary>
        /// 
        /// </summary>
        public ExperimentFilterNode(global::Helicone.ExperimentFilterBranch? value)
        {
            Value2 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ExperimentFilterNode(global::Helicone.ExperimentFilterNodeEnum value) => new ExperimentFilterNode((global::Helicone.ExperimentFilterNodeEnum?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Helicone.ExperimentFilterNodeEnum?(ExperimentFilterNode @this) => @this.Value3;

        /// <summary>
        /// 
        /// </summary>
        public ExperimentFilterNode(global::Helicone.ExperimentFilterNodeEnum? value)
        {
            Value3 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public ExperimentFilterNode(
            global::Helicone.PickFilterLeafExperiment? value1,
            global::Helicone.ExperimentFilterBranch? value2,
            global::Helicone.ExperimentFilterNodeEnum? value3
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
            global::System.Func<global::Helicone.PickFilterLeafExperiment?, TResult>? value1 = null,
            global::System.Func<global::Helicone.ExperimentFilterBranch?, TResult>? value2 = null,
            global::System.Func<global::Helicone.ExperimentFilterNodeEnum?, TResult>? value3 = null,
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
            global::System.Action<global::Helicone.PickFilterLeafExperiment?>? value1 = null,
            global::System.Action<global::Helicone.ExperimentFilterBranch?>? value2 = null,
            global::System.Action<global::Helicone.ExperimentFilterNodeEnum?>? value3 = null,
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
                typeof(global::Helicone.PickFilterLeafExperiment),
                Value2,
                typeof(global::Helicone.ExperimentFilterBranch),
                Value3,
                typeof(global::Helicone.ExperimentFilterNodeEnum),
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
        public bool Equals(ExperimentFilterNode other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Helicone.PickFilterLeafExperiment?>.Default.Equals(Value1, other.Value1) &&
                global::System.Collections.Generic.EqualityComparer<global::Helicone.ExperimentFilterBranch?>.Default.Equals(Value2, other.Value2) &&
                global::System.Collections.Generic.EqualityComparer<global::Helicone.ExperimentFilterNodeEnum?>.Default.Equals(Value3, other.Value3) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(ExperimentFilterNode obj1, ExperimentFilterNode obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<ExperimentFilterNode>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(ExperimentFilterNode obj1, ExperimentFilterNode obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is ExperimentFilterNode o && Equals(o);
        }
    }
}
