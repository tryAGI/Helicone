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
        public global::Helicone.PickFilterLeafExperiment? PickLeaf { get; init; }
#else
        public global::Helicone.PickFilterLeafExperiment? PickLeaf { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(PickLeaf))]
#endif
        public bool IsPickLeaf => PickLeaf != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Helicone.ExperimentFilterBranch? Branch { get; init; }
#else
        public global::Helicone.ExperimentFilterBranch? Branch { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Branch))]
#endif
        public bool IsBranch => Branch != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Helicone.ExperimentFilterNodeEnum? Enum { get; init; }
#else
        public global::Helicone.ExperimentFilterNodeEnum? Enum { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Enum))]
#endif
        public bool IsEnum => Enum != null;
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ExperimentFilterNode(global::Helicone.PickFilterLeafExperiment value) => new ExperimentFilterNode((global::Helicone.PickFilterLeafExperiment?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Helicone.PickFilterLeafExperiment?(ExperimentFilterNode @this) => @this.PickLeaf;

        /// <summary>
        /// 
        /// </summary>
        public ExperimentFilterNode(global::Helicone.PickFilterLeafExperiment? value)
        {
            PickLeaf = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ExperimentFilterNode(global::Helicone.ExperimentFilterBranch value) => new ExperimentFilterNode((global::Helicone.ExperimentFilterBranch?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Helicone.ExperimentFilterBranch?(ExperimentFilterNode @this) => @this.Branch;

        /// <summary>
        /// 
        /// </summary>
        public ExperimentFilterNode(global::Helicone.ExperimentFilterBranch? value)
        {
            Branch = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ExperimentFilterNode(global::Helicone.ExperimentFilterNodeEnum value) => new ExperimentFilterNode((global::Helicone.ExperimentFilterNodeEnum?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Helicone.ExperimentFilterNodeEnum?(ExperimentFilterNode @this) => @this.Enum;

        /// <summary>
        /// 
        /// </summary>
        public ExperimentFilterNode(global::Helicone.ExperimentFilterNodeEnum? value)
        {
            Enum = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public ExperimentFilterNode(
            global::Helicone.PickFilterLeafExperiment? pickLeaf,
            global::Helicone.ExperimentFilterBranch? branch,
            global::Helicone.ExperimentFilterNodeEnum? @enum
            )
        {
            PickLeaf = pickLeaf;
            Branch = branch;
            Enum = @enum;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            Enum as object ??
            Branch as object ??
            PickLeaf as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            PickLeaf?.ToString() ??
            Branch?.ToString() ??
            Enum?.ToValueString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsPickLeaf || IsBranch || IsEnum;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Helicone.PickFilterLeafExperiment?, TResult>? pickLeaf = null,
            global::System.Func<global::Helicone.ExperimentFilterBranch?, TResult>? branch = null,
            global::System.Func<global::Helicone.ExperimentFilterNodeEnum?, TResult>? @enum = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsPickLeaf && pickLeaf != null)
            {
                return pickLeaf(PickLeaf!);
            }
            else if (IsBranch && branch != null)
            {
                return branch(Branch!);
            }
            else if (IsEnum && @enum != null)
            {
                return @enum(Enum!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::Helicone.PickFilterLeafExperiment?>? pickLeaf = null,
            global::System.Action<global::Helicone.ExperimentFilterBranch?>? branch = null,
            global::System.Action<global::Helicone.ExperimentFilterNodeEnum?>? @enum = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsPickLeaf)
            {
                pickLeaf?.Invoke(PickLeaf!);
            }
            else if (IsBranch)
            {
                branch?.Invoke(Branch!);
            }
            else if (IsEnum)
            {
                @enum?.Invoke(Enum!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                PickLeaf,
                typeof(global::Helicone.PickFilterLeafExperiment),
                Branch,
                typeof(global::Helicone.ExperimentFilterBranch),
                Enum,
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
                global::System.Collections.Generic.EqualityComparer<global::Helicone.PickFilterLeafExperiment?>.Default.Equals(PickLeaf, other.PickLeaf) &&
                global::System.Collections.Generic.EqualityComparer<global::Helicone.ExperimentFilterBranch?>.Default.Equals(Branch, other.Branch) &&
                global::System.Collections.Generic.EqualityComparer<global::Helicone.ExperimentFilterNodeEnum?>.Default.Equals(Enum, other.Enum) 
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
