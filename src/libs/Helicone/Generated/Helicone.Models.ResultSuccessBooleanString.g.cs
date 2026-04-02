#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Helicone
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct ResultSuccessBooleanString : global::System.IEquatable<ResultSuccessBooleanString>
    {
        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Helicone.ResultSuccessSuccessBoolean? ResultSuccessSuccessBoolean { get; init; }
#else
        public global::Helicone.ResultSuccessSuccessBoolean? ResultSuccessSuccessBoolean { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ResultSuccessSuccessBoolean))]
#endif
        public bool IsResultSuccessSuccessBoolean => ResultSuccessSuccessBoolean != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Helicone.ResultErrorString? Error { get; init; }
#else
        public global::Helicone.ResultErrorString? Error { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Error))]
#endif
        public bool IsError => Error != null;
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ResultSuccessBooleanString(global::Helicone.ResultSuccessSuccessBoolean value) => new ResultSuccessBooleanString((global::Helicone.ResultSuccessSuccessBoolean?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Helicone.ResultSuccessSuccessBoolean?(ResultSuccessBooleanString @this) => @this.ResultSuccessSuccessBoolean;

        /// <summary>
        /// 
        /// </summary>
        public ResultSuccessBooleanString(global::Helicone.ResultSuccessSuccessBoolean? value)
        {
            ResultSuccessSuccessBoolean = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ResultSuccessBooleanString(global::Helicone.ResultErrorString value) => new ResultSuccessBooleanString((global::Helicone.ResultErrorString?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Helicone.ResultErrorString?(ResultSuccessBooleanString @this) => @this.Error;

        /// <summary>
        /// 
        /// </summary>
        public ResultSuccessBooleanString(global::Helicone.ResultErrorString? value)
        {
            Error = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public ResultSuccessBooleanString(
            global::Helicone.ResultSuccessSuccessBoolean? resultSuccessSuccessBoolean,
            global::Helicone.ResultErrorString? error
            )
        {
            ResultSuccessSuccessBoolean = resultSuccessSuccessBoolean;
            Error = error;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            Error as object ??
            ResultSuccessSuccessBoolean as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            ResultSuccessSuccessBoolean?.ToString() ??
            Error?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsResultSuccessSuccessBoolean || IsError;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Helicone.ResultSuccessSuccessBoolean?, TResult>? resultSuccessSuccessBoolean = null,
            global::System.Func<global::Helicone.ResultErrorString?, TResult>? error = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsResultSuccessSuccessBoolean && resultSuccessSuccessBoolean != null)
            {
                return resultSuccessSuccessBoolean(ResultSuccessSuccessBoolean!);
            }
            else if (IsError && error != null)
            {
                return error(Error!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::Helicone.ResultSuccessSuccessBoolean?>? resultSuccessSuccessBoolean = null,
            global::System.Action<global::Helicone.ResultErrorString?>? error = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsResultSuccessSuccessBoolean)
            {
                resultSuccessSuccessBoolean?.Invoke(ResultSuccessSuccessBoolean!);
            }
            else if (IsError)
            {
                error?.Invoke(Error!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                ResultSuccessSuccessBoolean,
                typeof(global::Helicone.ResultSuccessSuccessBoolean),
                Error,
                typeof(global::Helicone.ResultErrorString),
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
        public bool Equals(ResultSuccessBooleanString other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Helicone.ResultSuccessSuccessBoolean?>.Default.Equals(ResultSuccessSuccessBoolean, other.ResultSuccessSuccessBoolean) &&
                global::System.Collections.Generic.EqualityComparer<global::Helicone.ResultErrorString?>.Default.Equals(Error, other.Error) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(ResultSuccessBooleanString obj1, ResultSuccessBooleanString obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<ResultSuccessBooleanString>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(ResultSuccessBooleanString obj1, ResultSuccessBooleanString obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is ResultSuccessBooleanString o && Equals(o);
        }
    }
}
