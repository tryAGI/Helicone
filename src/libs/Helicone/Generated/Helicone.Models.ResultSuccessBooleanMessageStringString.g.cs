#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Helicone
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct ResultSuccessBooleanMessageStringString : global::System.IEquatable<ResultSuccessBooleanMessageStringString>
    {
        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Helicone.ResultSuccessSuccessBooleanMessageString? ResultSuccessSuccessBooleanMessageString { get; init; }
#else
        public global::Helicone.ResultSuccessSuccessBooleanMessageString? ResultSuccessSuccessBooleanMessageString { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ResultSuccessSuccessBooleanMessageString))]
#endif
        public bool IsResultSuccessSuccessBooleanMessageString => ResultSuccessSuccessBooleanMessageString != null;

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
        public static implicit operator ResultSuccessBooleanMessageStringString(global::Helicone.ResultSuccessSuccessBooleanMessageString value) => new ResultSuccessBooleanMessageStringString((global::Helicone.ResultSuccessSuccessBooleanMessageString?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Helicone.ResultSuccessSuccessBooleanMessageString?(ResultSuccessBooleanMessageStringString @this) => @this.ResultSuccessSuccessBooleanMessageString;

        /// <summary>
        /// 
        /// </summary>
        public ResultSuccessBooleanMessageStringString(global::Helicone.ResultSuccessSuccessBooleanMessageString? value)
        {
            ResultSuccessSuccessBooleanMessageString = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ResultSuccessBooleanMessageStringString(global::Helicone.ResultErrorString value) => new ResultSuccessBooleanMessageStringString((global::Helicone.ResultErrorString?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Helicone.ResultErrorString?(ResultSuccessBooleanMessageStringString @this) => @this.Error;

        /// <summary>
        /// 
        /// </summary>
        public ResultSuccessBooleanMessageStringString(global::Helicone.ResultErrorString? value)
        {
            Error = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public ResultSuccessBooleanMessageStringString(
            global::Helicone.ResultSuccessSuccessBooleanMessageString? resultSuccessSuccessBooleanMessageString,
            global::Helicone.ResultErrorString? error
            )
        {
            ResultSuccessSuccessBooleanMessageString = resultSuccessSuccessBooleanMessageString;
            Error = error;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            Error as object ??
            ResultSuccessSuccessBooleanMessageString as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            ResultSuccessSuccessBooleanMessageString?.ToString() ??
            Error?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsResultSuccessSuccessBooleanMessageString || IsError;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Helicone.ResultSuccessSuccessBooleanMessageString?, TResult>? resultSuccessSuccessBooleanMessageString = null,
            global::System.Func<global::Helicone.ResultErrorString?, TResult>? error = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsResultSuccessSuccessBooleanMessageString && resultSuccessSuccessBooleanMessageString != null)
            {
                return resultSuccessSuccessBooleanMessageString(ResultSuccessSuccessBooleanMessageString!);
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
            global::System.Action<global::Helicone.ResultSuccessSuccessBooleanMessageString?>? resultSuccessSuccessBooleanMessageString = null,
            global::System.Action<global::Helicone.ResultErrorString?>? error = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsResultSuccessSuccessBooleanMessageString)
            {
                resultSuccessSuccessBooleanMessageString?.Invoke(ResultSuccessSuccessBooleanMessageString!);
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
                ResultSuccessSuccessBooleanMessageString,
                typeof(global::Helicone.ResultSuccessSuccessBooleanMessageString),
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
        public bool Equals(ResultSuccessBooleanMessageStringString other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Helicone.ResultSuccessSuccessBooleanMessageString?>.Default.Equals(ResultSuccessSuccessBooleanMessageString, other.ResultSuccessSuccessBooleanMessageString) &&
                global::System.Collections.Generic.EqualityComparer<global::Helicone.ResultErrorString?>.Default.Equals(Error, other.Error) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(ResultSuccessBooleanMessageStringString obj1, ResultSuccessBooleanMessageStringString obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<ResultSuccessBooleanMessageStringString>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(ResultSuccessBooleanMessageStringString obj1, ResultSuccessBooleanMessageStringString obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is ResultSuccessBooleanMessageStringString o && Equals(o);
        }
    }
}
