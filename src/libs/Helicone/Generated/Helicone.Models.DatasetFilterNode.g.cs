#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Helicone
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct DatasetFilterNode : global::System.IEquatable<DatasetFilterNode>
    {
        /// <summary>
        /// From T, pick a set of properties whose keys are in the union K
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Helicone.PickFilterLeafRequestOrPromptsVersions? PickLeafRequestOrPromptsVersions { get; init; }
#else
        public global::Helicone.PickFilterLeafRequestOrPromptsVersions? PickLeafRequestOrPromptsVersions { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(PickLeafRequestOrPromptsVersions))]
#endif
        public bool IsPickLeafRequestOrPromptsVersions => PickLeafRequestOrPromptsVersions != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Helicone.DatasetFilterBranch? Branch { get; init; }
#else
        public global::Helicone.DatasetFilterBranch? Branch { get; }
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
        public global::Helicone.DatasetFilterNodeEnum? Enum { get; init; }
#else
        public global::Helicone.DatasetFilterNodeEnum? Enum { get; }
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
        public static implicit operator DatasetFilterNode(global::Helicone.PickFilterLeafRequestOrPromptsVersions value) => new DatasetFilterNode((global::Helicone.PickFilterLeafRequestOrPromptsVersions?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Helicone.PickFilterLeafRequestOrPromptsVersions?(DatasetFilterNode @this) => @this.PickLeafRequestOrPromptsVersions;

        /// <summary>
        /// 
        /// </summary>
        public DatasetFilterNode(global::Helicone.PickFilterLeafRequestOrPromptsVersions? value)
        {
            PickLeafRequestOrPromptsVersions = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator DatasetFilterNode(global::Helicone.DatasetFilterBranch value) => new DatasetFilterNode((global::Helicone.DatasetFilterBranch?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Helicone.DatasetFilterBranch?(DatasetFilterNode @this) => @this.Branch;

        /// <summary>
        /// 
        /// </summary>
        public DatasetFilterNode(global::Helicone.DatasetFilterBranch? value)
        {
            Branch = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator DatasetFilterNode(global::Helicone.DatasetFilterNodeEnum value) => new DatasetFilterNode((global::Helicone.DatasetFilterNodeEnum?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Helicone.DatasetFilterNodeEnum?(DatasetFilterNode @this) => @this.Enum;

        /// <summary>
        /// 
        /// </summary>
        public DatasetFilterNode(global::Helicone.DatasetFilterNodeEnum? value)
        {
            Enum = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public DatasetFilterNode(
            global::Helicone.PickFilterLeafRequestOrPromptsVersions? pickLeafRequestOrPromptsVersions,
            global::Helicone.DatasetFilterBranch? branch,
            global::Helicone.DatasetFilterNodeEnum? @enum
            )
        {
            PickLeafRequestOrPromptsVersions = pickLeafRequestOrPromptsVersions;
            Branch = branch;
            Enum = @enum;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            Enum as object ??
            Branch as object ??
            PickLeafRequestOrPromptsVersions as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            PickLeafRequestOrPromptsVersions?.ToString() ??
            Branch?.ToString() ??
            Enum?.ToValueString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsPickLeafRequestOrPromptsVersions || IsBranch || IsEnum;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Helicone.PickFilterLeafRequestOrPromptsVersions?, TResult>? pickLeafRequestOrPromptsVersions = null,
            global::System.Func<global::Helicone.DatasetFilterBranch?, TResult>? branch = null,
            global::System.Func<global::Helicone.DatasetFilterNodeEnum?, TResult>? @enum = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsPickLeafRequestOrPromptsVersions && pickLeafRequestOrPromptsVersions != null)
            {
                return pickLeafRequestOrPromptsVersions(PickLeafRequestOrPromptsVersions!);
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
            global::System.Action<global::Helicone.PickFilterLeafRequestOrPromptsVersions?>? pickLeafRequestOrPromptsVersions = null,
            global::System.Action<global::Helicone.DatasetFilterBranch?>? branch = null,
            global::System.Action<global::Helicone.DatasetFilterNodeEnum?>? @enum = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsPickLeafRequestOrPromptsVersions)
            {
                pickLeafRequestOrPromptsVersions?.Invoke(PickLeafRequestOrPromptsVersions!);
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
                PickLeafRequestOrPromptsVersions,
                typeof(global::Helicone.PickFilterLeafRequestOrPromptsVersions),
                Branch,
                typeof(global::Helicone.DatasetFilterBranch),
                Enum,
                typeof(global::Helicone.DatasetFilterNodeEnum),
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
        public bool Equals(DatasetFilterNode other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Helicone.PickFilterLeafRequestOrPromptsVersions?>.Default.Equals(PickLeafRequestOrPromptsVersions, other.PickLeafRequestOrPromptsVersions) &&
                global::System.Collections.Generic.EqualityComparer<global::Helicone.DatasetFilterBranch?>.Default.Equals(Branch, other.Branch) &&
                global::System.Collections.Generic.EqualityComparer<global::Helicone.DatasetFilterNodeEnum?>.Default.Equals(Enum, other.Enum) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(DatasetFilterNode obj1, DatasetFilterNode obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<DatasetFilterNode>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(DatasetFilterNode obj1, DatasetFilterNode obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is DatasetFilterNode o && Equals(o);
        }
    }
}
