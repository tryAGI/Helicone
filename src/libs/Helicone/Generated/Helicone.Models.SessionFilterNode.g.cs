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
        public global::Helicone.PickFilterLeafRequestResponseRmtOrSessionsRequestResponseRmt? PickLeafRequestResponseRmtOrSessions { get; init; }
#else
        public global::Helicone.PickFilterLeafRequestResponseRmtOrSessionsRequestResponseRmt? PickLeafRequestResponseRmtOrSessions { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(PickLeafRequestResponseRmtOrSessions))]
#endif
        public bool IsPickLeafRequestResponseRmtOrSessions => PickLeafRequestResponseRmtOrSessions != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Helicone.SessionFilterBranch? Branch { get; init; }
#else
        public global::Helicone.SessionFilterBranch? Branch { get; }
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
        public global::Helicone.SessionFilterNodeEnum? Enum { get; init; }
#else
        public global::Helicone.SessionFilterNodeEnum? Enum { get; }
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
        public static implicit operator SessionFilterNode(global::Helicone.PickFilterLeafRequestResponseRmtOrSessionsRequestResponseRmt value) => new SessionFilterNode((global::Helicone.PickFilterLeafRequestResponseRmtOrSessionsRequestResponseRmt?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Helicone.PickFilterLeafRequestResponseRmtOrSessionsRequestResponseRmt?(SessionFilterNode @this) => @this.PickLeafRequestResponseRmtOrSessions;

        /// <summary>
        /// 
        /// </summary>
        public SessionFilterNode(global::Helicone.PickFilterLeafRequestResponseRmtOrSessionsRequestResponseRmt? value)
        {
            PickLeafRequestResponseRmtOrSessions = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator SessionFilterNode(global::Helicone.SessionFilterBranch value) => new SessionFilterNode((global::Helicone.SessionFilterBranch?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Helicone.SessionFilterBranch?(SessionFilterNode @this) => @this.Branch;

        /// <summary>
        /// 
        /// </summary>
        public SessionFilterNode(global::Helicone.SessionFilterBranch? value)
        {
            Branch = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator SessionFilterNode(global::Helicone.SessionFilterNodeEnum value) => new SessionFilterNode((global::Helicone.SessionFilterNodeEnum?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Helicone.SessionFilterNodeEnum?(SessionFilterNode @this) => @this.Enum;

        /// <summary>
        /// 
        /// </summary>
        public SessionFilterNode(global::Helicone.SessionFilterNodeEnum? value)
        {
            Enum = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public SessionFilterNode(
            global::Helicone.PickFilterLeafRequestResponseRmtOrSessionsRequestResponseRmt? pickLeafRequestResponseRmtOrSessions,
            global::Helicone.SessionFilterBranch? branch,
            global::Helicone.SessionFilterNodeEnum? @enum
            )
        {
            PickLeafRequestResponseRmtOrSessions = pickLeafRequestResponseRmtOrSessions;
            Branch = branch;
            Enum = @enum;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            Enum as object ??
            Branch as object ??
            PickLeafRequestResponseRmtOrSessions as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            PickLeafRequestResponseRmtOrSessions?.ToString() ??
            Branch?.ToString() ??
            Enum?.ToValueString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsPickLeafRequestResponseRmtOrSessions || IsBranch || IsEnum;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Helicone.PickFilterLeafRequestResponseRmtOrSessionsRequestResponseRmt?, TResult>? pickLeafRequestResponseRmtOrSessions = null,
            global::System.Func<global::Helicone.SessionFilterBranch?, TResult>? branch = null,
            global::System.Func<global::Helicone.SessionFilterNodeEnum?, TResult>? @enum = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsPickLeafRequestResponseRmtOrSessions && pickLeafRequestResponseRmtOrSessions != null)
            {
                return pickLeafRequestResponseRmtOrSessions(PickLeafRequestResponseRmtOrSessions!);
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
            global::System.Action<global::Helicone.PickFilterLeafRequestResponseRmtOrSessionsRequestResponseRmt?>? pickLeafRequestResponseRmtOrSessions = null,
            global::System.Action<global::Helicone.SessionFilterBranch?>? branch = null,
            global::System.Action<global::Helicone.SessionFilterNodeEnum?>? @enum = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsPickLeafRequestResponseRmtOrSessions)
            {
                pickLeafRequestResponseRmtOrSessions?.Invoke(PickLeafRequestResponseRmtOrSessions!);
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
                PickLeafRequestResponseRmtOrSessions,
                typeof(global::Helicone.PickFilterLeafRequestResponseRmtOrSessionsRequestResponseRmt),
                Branch,
                typeof(global::Helicone.SessionFilterBranch),
                Enum,
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
                global::System.Collections.Generic.EqualityComparer<global::Helicone.PickFilterLeafRequestResponseRmtOrSessionsRequestResponseRmt?>.Default.Equals(PickLeafRequestResponseRmtOrSessions, other.PickLeafRequestResponseRmtOrSessions) &&
                global::System.Collections.Generic.EqualityComparer<global::Helicone.SessionFilterBranch?>.Default.Equals(Branch, other.Branch) &&
                global::System.Collections.Generic.EqualityComparer<global::Helicone.SessionFilterNodeEnum?>.Default.Equals(Enum, other.Enum) 
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
