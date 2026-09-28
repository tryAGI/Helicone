#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Helicone
{
    /// <summary>
    ///
    /// </summary>
    public readonly partial struct PromptVersionsFilterNode : global::System.IEquatable<PromptVersionsFilterNode>
    {
        /// <summary>
        /// From T, pick a set of properties whose keys are in the union K
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Helicone.PickFilterLeafPromptsVersions? PickLeafPrompts { get; init; }
#else
        public global::Helicone.PickFilterLeafPromptsVersions? PickLeafPrompts { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(PickLeafPrompts))]
#endif
        public bool IsPickLeafPrompts => PickLeafPrompts != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickPickLeafPrompts(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Helicone.PickFilterLeafPromptsVersions? value)
        {
            value = PickLeafPrompts;
            return IsPickLeafPrompts;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Helicone.PickFilterLeafPromptsVersions PickPickLeafPrompts() => PickLeafPrompts is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'PickLeafPrompts' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Helicone.PromptVersionsFilterBranch? Branch { get; init; }
#else
        public global::Helicone.PromptVersionsFilterBranch? Branch { get; }
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
        public bool TryPickBranch(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Helicone.PromptVersionsFilterBranch? value)
        {
            value = Branch;
            return IsBranch;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Helicone.PromptVersionsFilterBranch PickBranch() => Branch is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'Branch' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Helicone.PromptVersionsFilterNodeEnum? Enum { get; init; }
#else
        public global::Helicone.PromptVersionsFilterNodeEnum? Enum { get; }
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
        public bool TryPickEnum(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Helicone.PromptVersionsFilterNodeEnum? value)
        {
            value = Enum;
            return IsEnum;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Helicone.PromptVersionsFilterNodeEnum PickEnum() => Enum is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'Enum' but the value was {ToString()}.");
        /// <summary>
        ///
        /// </summary>
        public static implicit operator PromptVersionsFilterNode(global::Helicone.PickFilterLeafPromptsVersions value) => new PromptVersionsFilterNode((global::Helicone.PickFilterLeafPromptsVersions?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Helicone.PickFilterLeafPromptsVersions?(PromptVersionsFilterNode @this) => @this.PickLeafPrompts;

        /// <summary>
        ///
        /// </summary>
        public PromptVersionsFilterNode(global::Helicone.PickFilterLeafPromptsVersions? value)
        {
            PickLeafPrompts = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static PromptVersionsFilterNode FromPickLeafPrompts(global::Helicone.PickFilterLeafPromptsVersions? value) => new PromptVersionsFilterNode(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator PromptVersionsFilterNode(global::Helicone.PromptVersionsFilterBranch value) => new PromptVersionsFilterNode((global::Helicone.PromptVersionsFilterBranch?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Helicone.PromptVersionsFilterBranch?(PromptVersionsFilterNode @this) => @this.Branch;

        /// <summary>
        ///
        /// </summary>
        public PromptVersionsFilterNode(global::Helicone.PromptVersionsFilterBranch? value)
        {
            Branch = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static PromptVersionsFilterNode FromBranch(global::Helicone.PromptVersionsFilterBranch? value) => new PromptVersionsFilterNode(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator PromptVersionsFilterNode(global::Helicone.PromptVersionsFilterNodeEnum value) => new PromptVersionsFilterNode((global::Helicone.PromptVersionsFilterNodeEnum?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Helicone.PromptVersionsFilterNodeEnum?(PromptVersionsFilterNode @this) => @this.Enum;

        /// <summary>
        ///
        /// </summary>
        public PromptVersionsFilterNode(global::Helicone.PromptVersionsFilterNodeEnum? value)
        {
            Enum = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static PromptVersionsFilterNode FromEnum(global::Helicone.PromptVersionsFilterNodeEnum? value) => new PromptVersionsFilterNode(value);

        /// <summary>
        ///
        /// </summary>
        public PromptVersionsFilterNode(
            global::Helicone.PickFilterLeafPromptsVersions? pickLeafPrompts,
            global::Helicone.PromptVersionsFilterBranch? branch,
            global::Helicone.PromptVersionsFilterNodeEnum? @enum
            )
        {
            PickLeafPrompts = pickLeafPrompts;
            Branch = branch;
            Enum = @enum;
        }

        /// <summary>
        ///
        /// </summary>
        public object? Object =>
            Enum as object ??
            Branch as object ??
            PickLeafPrompts as object
            ;

        /// <summary>
        ///
        /// </summary>
        public override string? ToString() =>
            PickLeafPrompts?.ToString() ??
            Branch?.ToString() ??
            Enum?.ToValueString()
            ;

        /// <summary>
        ///
        /// </summary>
        public bool Validate()
        {
            return IsPickLeafPrompts || IsBranch || IsEnum;
        }

        /// <summary>
        ///
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Helicone.PickFilterLeafPromptsVersions, TResult>? pickLeafPrompts = null,
            global::System.Func<global::Helicone.PromptVersionsFilterBranch, TResult>? branch = null,
            global::System.Func<global::Helicone.PromptVersionsFilterNodeEnum?, TResult>? @enum = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (PickLeafPrompts is { } __value0 && pickLeafPrompts != null)
            {
                return pickLeafPrompts(__value0);
            }
            else if (Branch is { } __value1 && branch != null)
            {
                return branch(__value1);
            }
            else if (Enum is { } __value2 && @enum != null)
            {
                return @enum(__value2);
            }

            return default(TResult);
        }

        /// <summary>
        ///
        /// </summary>
        public void Match(
            global::System.Action<global::Helicone.PickFilterLeafPromptsVersions>? pickLeafPrompts = null,

            global::System.Action<global::Helicone.PromptVersionsFilterBranch>? branch = null,

            global::System.Action<global::Helicone.PromptVersionsFilterNodeEnum?>? @enum = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (PickLeafPrompts is { } __value0)
            {
                pickLeafPrompts?.Invoke(__value0);
            }
            else if (Branch is { } __value1)
            {
                branch?.Invoke(__value1);
            }
            else if (Enum is { } __value2)
            {
                @enum?.Invoke(__value2);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public void Switch(
            global::System.Action<global::Helicone.PickFilterLeafPromptsVersions>? pickLeafPrompts = null,
            global::System.Action<global::Helicone.PromptVersionsFilterBranch>? branch = null,
            global::System.Action<global::Helicone.PromptVersionsFilterNodeEnum?>? @enum = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (PickLeafPrompts is { } __value0)
            {
                pickLeafPrompts?.Invoke(__value0);
            }
            else if (Branch is { } __value1)
            {
                branch?.Invoke(__value1);
            }
            else if (Enum is { } __value2)
            {
                @enum?.Invoke(__value2);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                PickLeafPrompts,
                typeof(global::Helicone.PickFilterLeafPromptsVersions),
                Branch,
                typeof(global::Helicone.PromptVersionsFilterBranch),
                Enum,
                typeof(global::Helicone.PromptVersionsFilterNodeEnum),
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
        public bool Equals(PromptVersionsFilterNode other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Helicone.PickFilterLeafPromptsVersions?>.Default.Equals(PickLeafPrompts, other.PickLeafPrompts) &&
                global::System.Collections.Generic.EqualityComparer<global::Helicone.PromptVersionsFilterBranch?>.Default.Equals(Branch, other.Branch) &&
                global::System.Collections.Generic.EqualityComparer<global::Helicone.PromptVersionsFilterNodeEnum?>.Default.Equals(Enum, other.Enum)
                ;
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator ==(PromptVersionsFilterNode obj1, PromptVersionsFilterNode obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<PromptVersionsFilterNode>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(PromptVersionsFilterNode obj1, PromptVersionsFilterNode obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is PromptVersionsFilterNode o && Equals(o);
        }
    }
}
