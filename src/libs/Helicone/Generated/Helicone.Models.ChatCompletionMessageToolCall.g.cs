#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Helicone
{
    /// <summary>
    /// A call to a function tool created by the model.
    /// </summary>
    public readonly partial struct ChatCompletionMessageToolCall : global::System.IEquatable<ChatCompletionMessageToolCall>
    {
        /// <summary>
        /// A call to a function tool created by the model.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Helicone.ChatCompletionMessageFunctionToolCall? Function { get; init; }
#else
        public global::Helicone.ChatCompletionMessageFunctionToolCall? Function { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Function))]
#endif
        public bool IsFunction => Function != null;

        /// <summary>
        /// A call to a custom tool created by the model.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Helicone.ChatCompletionMessageCustomToolCall? Custom { get; init; }
#else
        public global::Helicone.ChatCompletionMessageCustomToolCall? Custom { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Custom))]
#endif
        public bool IsCustom => Custom != null;
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ChatCompletionMessageToolCall(global::Helicone.ChatCompletionMessageFunctionToolCall value) => new ChatCompletionMessageToolCall((global::Helicone.ChatCompletionMessageFunctionToolCall?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Helicone.ChatCompletionMessageFunctionToolCall?(ChatCompletionMessageToolCall @this) => @this.Function;

        /// <summary>
        /// 
        /// </summary>
        public ChatCompletionMessageToolCall(global::Helicone.ChatCompletionMessageFunctionToolCall? value)
        {
            Function = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ChatCompletionMessageToolCall(global::Helicone.ChatCompletionMessageCustomToolCall value) => new ChatCompletionMessageToolCall((global::Helicone.ChatCompletionMessageCustomToolCall?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Helicone.ChatCompletionMessageCustomToolCall?(ChatCompletionMessageToolCall @this) => @this.Custom;

        /// <summary>
        /// 
        /// </summary>
        public ChatCompletionMessageToolCall(global::Helicone.ChatCompletionMessageCustomToolCall? value)
        {
            Custom = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public ChatCompletionMessageToolCall(
            global::Helicone.ChatCompletionMessageFunctionToolCall? function,
            global::Helicone.ChatCompletionMessageCustomToolCall? custom
            )
        {
            Function = function;
            Custom = custom;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            Custom as object ??
            Function as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            Function?.ToString() ??
            Custom?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsFunction || IsCustom;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Helicone.ChatCompletionMessageFunctionToolCall?, TResult>? function = null,
            global::System.Func<global::Helicone.ChatCompletionMessageCustomToolCall?, TResult>? custom = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsFunction && function != null)
            {
                return function(Function!);
            }
            else if (IsCustom && custom != null)
            {
                return custom(Custom!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::Helicone.ChatCompletionMessageFunctionToolCall?>? function = null,
            global::System.Action<global::Helicone.ChatCompletionMessageCustomToolCall?>? custom = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsFunction)
            {
                function?.Invoke(Function!);
            }
            else if (IsCustom)
            {
                custom?.Invoke(Custom!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                Function,
                typeof(global::Helicone.ChatCompletionMessageFunctionToolCall),
                Custom,
                typeof(global::Helicone.ChatCompletionMessageCustomToolCall),
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
        public bool Equals(ChatCompletionMessageToolCall other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Helicone.ChatCompletionMessageFunctionToolCall?>.Default.Equals(Function, other.Function) &&
                global::System.Collections.Generic.EqualityComparer<global::Helicone.ChatCompletionMessageCustomToolCall?>.Default.Equals(Custom, other.Custom) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(ChatCompletionMessageToolCall obj1, ChatCompletionMessageToolCall obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<ChatCompletionMessageToolCall>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(ChatCompletionMessageToolCall obj1, ChatCompletionMessageToolCall obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is ChatCompletionMessageToolCall o && Equals(o);
        }
    }
}
