#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Helicone
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct RequestFilterNode : global::System.IEquatable<RequestFilterNode>
    {
        /// <summary>
        /// From T, pick a set of properties whose keys are in the union K
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Helicone.PickFilterLeafFeedbackOrRequestOrResponseOrPropertiesOrValuesOrRequestResponseRmtOrSessionsRequestResponseRmt? PickLeafFeedbackOrResponsePropertiesValuesRmtSessions { get; init; }
#else
        public global::Helicone.PickFilterLeafFeedbackOrRequestOrResponseOrPropertiesOrValuesOrRequestResponseRmtOrSessionsRequestResponseRmt? PickLeafFeedbackOrResponsePropertiesValuesRmtSessions { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(PickLeafFeedbackOrResponsePropertiesValuesRmtSessions))]
#endif
        public bool IsPickLeafFeedbackOrResponsePropertiesValuesRmtSessions => PickLeafFeedbackOrResponsePropertiesValuesRmtSessions != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Helicone.RequestFilterBranch? Branch { get; init; }
#else
        public global::Helicone.RequestFilterBranch? Branch { get; }
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
        public global::Helicone.RequestFilterNodeEnum? Enum { get; init; }
#else
        public global::Helicone.RequestFilterNodeEnum? Enum { get; }
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
        public static implicit operator RequestFilterNode(global::Helicone.PickFilterLeafFeedbackOrRequestOrResponseOrPropertiesOrValuesOrRequestResponseRmtOrSessionsRequestResponseRmt value) => new RequestFilterNode((global::Helicone.PickFilterLeafFeedbackOrRequestOrResponseOrPropertiesOrValuesOrRequestResponseRmtOrSessionsRequestResponseRmt?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Helicone.PickFilterLeafFeedbackOrRequestOrResponseOrPropertiesOrValuesOrRequestResponseRmtOrSessionsRequestResponseRmt?(RequestFilterNode @this) => @this.PickLeafFeedbackOrResponsePropertiesValuesRmtSessions;

        /// <summary>
        /// 
        /// </summary>
        public RequestFilterNode(global::Helicone.PickFilterLeafFeedbackOrRequestOrResponseOrPropertiesOrValuesOrRequestResponseRmtOrSessionsRequestResponseRmt? value)
        {
            PickLeafFeedbackOrResponsePropertiesValuesRmtSessions = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator RequestFilterNode(global::Helicone.RequestFilterBranch value) => new RequestFilterNode((global::Helicone.RequestFilterBranch?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Helicone.RequestFilterBranch?(RequestFilterNode @this) => @this.Branch;

        /// <summary>
        /// 
        /// </summary>
        public RequestFilterNode(global::Helicone.RequestFilterBranch? value)
        {
            Branch = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator RequestFilterNode(global::Helicone.RequestFilterNodeEnum value) => new RequestFilterNode((global::Helicone.RequestFilterNodeEnum?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Helicone.RequestFilterNodeEnum?(RequestFilterNode @this) => @this.Enum;

        /// <summary>
        /// 
        /// </summary>
        public RequestFilterNode(global::Helicone.RequestFilterNodeEnum? value)
        {
            Enum = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public RequestFilterNode(
            global::Helicone.PickFilterLeafFeedbackOrRequestOrResponseOrPropertiesOrValuesOrRequestResponseRmtOrSessionsRequestResponseRmt? pickLeafFeedbackOrResponsePropertiesValuesRmtSessions,
            global::Helicone.RequestFilterBranch? branch,
            global::Helicone.RequestFilterNodeEnum? @enum
            )
        {
            PickLeafFeedbackOrResponsePropertiesValuesRmtSessions = pickLeafFeedbackOrResponsePropertiesValuesRmtSessions;
            Branch = branch;
            Enum = @enum;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            Enum as object ??
            Branch as object ??
            PickLeafFeedbackOrResponsePropertiesValuesRmtSessions as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            PickLeafFeedbackOrResponsePropertiesValuesRmtSessions?.ToString() ??
            Branch?.ToString() ??
            Enum?.ToValueString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsPickLeafFeedbackOrResponsePropertiesValuesRmtSessions || IsBranch || IsEnum;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Helicone.PickFilterLeafFeedbackOrRequestOrResponseOrPropertiesOrValuesOrRequestResponseRmtOrSessionsRequestResponseRmt?, TResult>? pickLeafFeedbackOrResponsePropertiesValuesRmtSessions = null,
            global::System.Func<global::Helicone.RequestFilterBranch?, TResult>? branch = null,
            global::System.Func<global::Helicone.RequestFilterNodeEnum?, TResult>? @enum = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsPickLeafFeedbackOrResponsePropertiesValuesRmtSessions && pickLeafFeedbackOrResponsePropertiesValuesRmtSessions != null)
            {
                return pickLeafFeedbackOrResponsePropertiesValuesRmtSessions(PickLeafFeedbackOrResponsePropertiesValuesRmtSessions!);
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
            global::System.Action<global::Helicone.PickFilterLeafFeedbackOrRequestOrResponseOrPropertiesOrValuesOrRequestResponseRmtOrSessionsRequestResponseRmt?>? pickLeafFeedbackOrResponsePropertiesValuesRmtSessions = null,
            global::System.Action<global::Helicone.RequestFilterBranch?>? branch = null,
            global::System.Action<global::Helicone.RequestFilterNodeEnum?>? @enum = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsPickLeafFeedbackOrResponsePropertiesValuesRmtSessions)
            {
                pickLeafFeedbackOrResponsePropertiesValuesRmtSessions?.Invoke(PickLeafFeedbackOrResponsePropertiesValuesRmtSessions!);
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
                PickLeafFeedbackOrResponsePropertiesValuesRmtSessions,
                typeof(global::Helicone.PickFilterLeafFeedbackOrRequestOrResponseOrPropertiesOrValuesOrRequestResponseRmtOrSessionsRequestResponseRmt),
                Branch,
                typeof(global::Helicone.RequestFilterBranch),
                Enum,
                typeof(global::Helicone.RequestFilterNodeEnum),
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
        public bool Equals(RequestFilterNode other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Helicone.PickFilterLeafFeedbackOrRequestOrResponseOrPropertiesOrValuesOrRequestResponseRmtOrSessionsRequestResponseRmt?>.Default.Equals(PickLeafFeedbackOrResponsePropertiesValuesRmtSessions, other.PickLeafFeedbackOrResponsePropertiesValuesRmtSessions) &&
                global::System.Collections.Generic.EqualityComparer<global::Helicone.RequestFilterBranch?>.Default.Equals(Branch, other.Branch) &&
                global::System.Collections.Generic.EqualityComparer<global::Helicone.RequestFilterNodeEnum?>.Default.Equals(Enum, other.Enum) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(RequestFilterNode obj1, RequestFilterNode obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<RequestFilterNode>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(RequestFilterNode obj1, RequestFilterNode obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is RequestFilterNode o && Equals(o);
        }
    }
}
