#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Helicone
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct RequestClickhouseFilterNode : global::System.IEquatable<RequestClickhouseFilterNode>
    {
        /// <summary>
        /// From T, pick a set of properties whose keys are in the union K
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Helicone.PickFilterLeafRequestResponseRmt? PickLeafResponseRmt { get; init; }
#else
        public global::Helicone.PickFilterLeafRequestResponseRmt? PickLeafResponseRmt { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(PickLeafResponseRmt))]
#endif
        public bool IsPickLeafResponseRmt => PickLeafResponseRmt != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Helicone.RequestClickhouseFilterBranch? Branch { get; init; }
#else
        public global::Helicone.RequestClickhouseFilterBranch? Branch { get; }
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
        public global::Helicone.RequestClickhouseFilterNodeEnum? Enum { get; init; }
#else
        public global::Helicone.RequestClickhouseFilterNodeEnum? Enum { get; }
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
        public static implicit operator RequestClickhouseFilterNode(global::Helicone.PickFilterLeafRequestResponseRmt value) => new RequestClickhouseFilterNode((global::Helicone.PickFilterLeafRequestResponseRmt?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Helicone.PickFilterLeafRequestResponseRmt?(RequestClickhouseFilterNode @this) => @this.PickLeafResponseRmt;

        /// <summary>
        /// 
        /// </summary>
        public RequestClickhouseFilterNode(global::Helicone.PickFilterLeafRequestResponseRmt? value)
        {
            PickLeafResponseRmt = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator RequestClickhouseFilterNode(global::Helicone.RequestClickhouseFilterBranch value) => new RequestClickhouseFilterNode((global::Helicone.RequestClickhouseFilterBranch?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Helicone.RequestClickhouseFilterBranch?(RequestClickhouseFilterNode @this) => @this.Branch;

        /// <summary>
        /// 
        /// </summary>
        public RequestClickhouseFilterNode(global::Helicone.RequestClickhouseFilterBranch? value)
        {
            Branch = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator RequestClickhouseFilterNode(global::Helicone.RequestClickhouseFilterNodeEnum value) => new RequestClickhouseFilterNode((global::Helicone.RequestClickhouseFilterNodeEnum?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Helicone.RequestClickhouseFilterNodeEnum?(RequestClickhouseFilterNode @this) => @this.Enum;

        /// <summary>
        /// 
        /// </summary>
        public RequestClickhouseFilterNode(global::Helicone.RequestClickhouseFilterNodeEnum? value)
        {
            Enum = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public RequestClickhouseFilterNode(
            global::Helicone.PickFilterLeafRequestResponseRmt? pickLeafResponseRmt,
            global::Helicone.RequestClickhouseFilterBranch? branch,
            global::Helicone.RequestClickhouseFilterNodeEnum? @enum
            )
        {
            PickLeafResponseRmt = pickLeafResponseRmt;
            Branch = branch;
            Enum = @enum;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            Enum as object ??
            Branch as object ??
            PickLeafResponseRmt as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            PickLeafResponseRmt?.ToString() ??
            Branch?.ToString() ??
            Enum?.ToValueString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsPickLeafResponseRmt || IsBranch || IsEnum;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Helicone.PickFilterLeafRequestResponseRmt?, TResult>? pickLeafResponseRmt = null,
            global::System.Func<global::Helicone.RequestClickhouseFilterBranch?, TResult>? branch = null,
            global::System.Func<global::Helicone.RequestClickhouseFilterNodeEnum?, TResult>? @enum = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsPickLeafResponseRmt && pickLeafResponseRmt != null)
            {
                return pickLeafResponseRmt(PickLeafResponseRmt!);
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
            global::System.Action<global::Helicone.PickFilterLeafRequestResponseRmt?>? pickLeafResponseRmt = null,
            global::System.Action<global::Helicone.RequestClickhouseFilterBranch?>? branch = null,
            global::System.Action<global::Helicone.RequestClickhouseFilterNodeEnum?>? @enum = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsPickLeafResponseRmt)
            {
                pickLeafResponseRmt?.Invoke(PickLeafResponseRmt!);
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
                PickLeafResponseRmt,
                typeof(global::Helicone.PickFilterLeafRequestResponseRmt),
                Branch,
                typeof(global::Helicone.RequestClickhouseFilterBranch),
                Enum,
                typeof(global::Helicone.RequestClickhouseFilterNodeEnum),
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
        public bool Equals(RequestClickhouseFilterNode other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Helicone.PickFilterLeafRequestResponseRmt?>.Default.Equals(PickLeafResponseRmt, other.PickLeafResponseRmt) &&
                global::System.Collections.Generic.EqualityComparer<global::Helicone.RequestClickhouseFilterBranch?>.Default.Equals(Branch, other.Branch) &&
                global::System.Collections.Generic.EqualityComparer<global::Helicone.RequestClickhouseFilterNodeEnum?>.Default.Equals(Enum, other.Enum) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(RequestClickhouseFilterNode obj1, RequestClickhouseFilterNode obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<RequestClickhouseFilterNode>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(RequestClickhouseFilterNode obj1, RequestClickhouseFilterNode obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is RequestClickhouseFilterNode o && Equals(o);
        }
    }
}
