#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Helicone
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct UserFilterNode : global::System.IEquatable<UserFilterNode>
    {
        /// <summary>
        /// From T, pick a set of properties whose keys are in the union K
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Helicone.PickFilterLeafUsersViewOrRequestResponseRmt? PickLeafUsersViewOrRequestResponseRmt { get; init; }
#else
        public global::Helicone.PickFilterLeafUsersViewOrRequestResponseRmt? PickLeafUsersViewOrRequestResponseRmt { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(PickLeafUsersViewOrRequestResponseRmt))]
#endif
        public bool IsPickLeafUsersViewOrRequestResponseRmt => PickLeafUsersViewOrRequestResponseRmt != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Helicone.UserFilterBranch? Branch { get; init; }
#else
        public global::Helicone.UserFilterBranch? Branch { get; }
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
        public global::Helicone.UserFilterNodeEnum? Enum { get; init; }
#else
        public global::Helicone.UserFilterNodeEnum? Enum { get; }
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
        public static implicit operator UserFilterNode(global::Helicone.PickFilterLeafUsersViewOrRequestResponseRmt value) => new UserFilterNode((global::Helicone.PickFilterLeafUsersViewOrRequestResponseRmt?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Helicone.PickFilterLeafUsersViewOrRequestResponseRmt?(UserFilterNode @this) => @this.PickLeafUsersViewOrRequestResponseRmt;

        /// <summary>
        /// 
        /// </summary>
        public UserFilterNode(global::Helicone.PickFilterLeafUsersViewOrRequestResponseRmt? value)
        {
            PickLeafUsersViewOrRequestResponseRmt = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator UserFilterNode(global::Helicone.UserFilterBranch value) => new UserFilterNode((global::Helicone.UserFilterBranch?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Helicone.UserFilterBranch?(UserFilterNode @this) => @this.Branch;

        /// <summary>
        /// 
        /// </summary>
        public UserFilterNode(global::Helicone.UserFilterBranch? value)
        {
            Branch = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator UserFilterNode(global::Helicone.UserFilterNodeEnum value) => new UserFilterNode((global::Helicone.UserFilterNodeEnum?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Helicone.UserFilterNodeEnum?(UserFilterNode @this) => @this.Enum;

        /// <summary>
        /// 
        /// </summary>
        public UserFilterNode(global::Helicone.UserFilterNodeEnum? value)
        {
            Enum = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public UserFilterNode(
            global::Helicone.PickFilterLeafUsersViewOrRequestResponseRmt? pickLeafUsersViewOrRequestResponseRmt,
            global::Helicone.UserFilterBranch? branch,
            global::Helicone.UserFilterNodeEnum? @enum
            )
        {
            PickLeafUsersViewOrRequestResponseRmt = pickLeafUsersViewOrRequestResponseRmt;
            Branch = branch;
            Enum = @enum;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            Enum as object ??
            Branch as object ??
            PickLeafUsersViewOrRequestResponseRmt as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            PickLeafUsersViewOrRequestResponseRmt?.ToString() ??
            Branch?.ToString() ??
            Enum?.ToValueString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsPickLeafUsersViewOrRequestResponseRmt || IsBranch || IsEnum;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Helicone.PickFilterLeafUsersViewOrRequestResponseRmt?, TResult>? pickLeafUsersViewOrRequestResponseRmt = null,
            global::System.Func<global::Helicone.UserFilterBranch?, TResult>? branch = null,
            global::System.Func<global::Helicone.UserFilterNodeEnum?, TResult>? @enum = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsPickLeafUsersViewOrRequestResponseRmt && pickLeafUsersViewOrRequestResponseRmt != null)
            {
                return pickLeafUsersViewOrRequestResponseRmt(PickLeafUsersViewOrRequestResponseRmt!);
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
            global::System.Action<global::Helicone.PickFilterLeafUsersViewOrRequestResponseRmt?>? pickLeafUsersViewOrRequestResponseRmt = null,
            global::System.Action<global::Helicone.UserFilterBranch?>? branch = null,
            global::System.Action<global::Helicone.UserFilterNodeEnum?>? @enum = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsPickLeafUsersViewOrRequestResponseRmt)
            {
                pickLeafUsersViewOrRequestResponseRmt?.Invoke(PickLeafUsersViewOrRequestResponseRmt!);
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
                PickLeafUsersViewOrRequestResponseRmt,
                typeof(global::Helicone.PickFilterLeafUsersViewOrRequestResponseRmt),
                Branch,
                typeof(global::Helicone.UserFilterBranch),
                Enum,
                typeof(global::Helicone.UserFilterNodeEnum),
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
        public bool Equals(UserFilterNode other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Helicone.PickFilterLeafUsersViewOrRequestResponseRmt?>.Default.Equals(PickLeafUsersViewOrRequestResponseRmt, other.PickLeafUsersViewOrRequestResponseRmt) &&
                global::System.Collections.Generic.EqualityComparer<global::Helicone.UserFilterBranch?>.Default.Equals(Branch, other.Branch) &&
                global::System.Collections.Generic.EqualityComparer<global::Helicone.UserFilterNodeEnum?>.Default.Equals(Enum, other.Enum) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(UserFilterNode obj1, UserFilterNode obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<UserFilterNode>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(UserFilterNode obj1, UserFilterNode obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is UserFilterNode o && Equals(o);
        }
    }
}
