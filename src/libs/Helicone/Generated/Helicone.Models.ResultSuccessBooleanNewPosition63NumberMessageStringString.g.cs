#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Helicone
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct ResultSuccessBooleanNewPosition63NumberMessageStringString : global::System.IEquatable<ResultSuccessBooleanNewPosition63NumberMessageStringString>
    {
        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Helicone.ResultSuccessSuccessBooleanNewPosition63NumberMessageString? ResultSuccessSuccessBooleanNewPosition63NumberMessageString { get; init; }
#else
        public global::Helicone.ResultSuccessSuccessBooleanNewPosition63NumberMessageString? ResultSuccessSuccessBooleanNewPosition63NumberMessageString { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ResultSuccessSuccessBooleanNewPosition63NumberMessageString))]
#endif
        public bool IsResultSuccessSuccessBooleanNewPosition63NumberMessageString => ResultSuccessSuccessBooleanNewPosition63NumberMessageString != null;

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
        public static implicit operator ResultSuccessBooleanNewPosition63NumberMessageStringString(global::Helicone.ResultSuccessSuccessBooleanNewPosition63NumberMessageString value) => new ResultSuccessBooleanNewPosition63NumberMessageStringString((global::Helicone.ResultSuccessSuccessBooleanNewPosition63NumberMessageString?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Helicone.ResultSuccessSuccessBooleanNewPosition63NumberMessageString?(ResultSuccessBooleanNewPosition63NumberMessageStringString @this) => @this.ResultSuccessSuccessBooleanNewPosition63NumberMessageString;

        /// <summary>
        /// 
        /// </summary>
        public ResultSuccessBooleanNewPosition63NumberMessageStringString(global::Helicone.ResultSuccessSuccessBooleanNewPosition63NumberMessageString? value)
        {
            ResultSuccessSuccessBooleanNewPosition63NumberMessageString = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ResultSuccessBooleanNewPosition63NumberMessageStringString(global::Helicone.ResultErrorString value) => new ResultSuccessBooleanNewPosition63NumberMessageStringString((global::Helicone.ResultErrorString?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Helicone.ResultErrorString?(ResultSuccessBooleanNewPosition63NumberMessageStringString @this) => @this.Error;

        /// <summary>
        /// 
        /// </summary>
        public ResultSuccessBooleanNewPosition63NumberMessageStringString(global::Helicone.ResultErrorString? value)
        {
            Error = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public ResultSuccessBooleanNewPosition63NumberMessageStringString(
            global::Helicone.ResultSuccessSuccessBooleanNewPosition63NumberMessageString? resultSuccessSuccessBooleanNewPosition63NumberMessageString,
            global::Helicone.ResultErrorString? error
            )
        {
            ResultSuccessSuccessBooleanNewPosition63NumberMessageString = resultSuccessSuccessBooleanNewPosition63NumberMessageString;
            Error = error;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            Error as object ??
            ResultSuccessSuccessBooleanNewPosition63NumberMessageString as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            ResultSuccessSuccessBooleanNewPosition63NumberMessageString?.ToString() ??
            Error?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsResultSuccessSuccessBooleanNewPosition63NumberMessageString || IsError;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Helicone.ResultSuccessSuccessBooleanNewPosition63NumberMessageString?, TResult>? resultSuccessSuccessBooleanNewPosition63NumberMessageString = null,
            global::System.Func<global::Helicone.ResultErrorString?, TResult>? error = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsResultSuccessSuccessBooleanNewPosition63NumberMessageString && resultSuccessSuccessBooleanNewPosition63NumberMessageString != null)
            {
                return resultSuccessSuccessBooleanNewPosition63NumberMessageString(ResultSuccessSuccessBooleanNewPosition63NumberMessageString!);
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
            global::System.Action<global::Helicone.ResultSuccessSuccessBooleanNewPosition63NumberMessageString?>? resultSuccessSuccessBooleanNewPosition63NumberMessageString = null,
            global::System.Action<global::Helicone.ResultErrorString?>? error = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsResultSuccessSuccessBooleanNewPosition63NumberMessageString)
            {
                resultSuccessSuccessBooleanNewPosition63NumberMessageString?.Invoke(ResultSuccessSuccessBooleanNewPosition63NumberMessageString!);
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
                ResultSuccessSuccessBooleanNewPosition63NumberMessageString,
                typeof(global::Helicone.ResultSuccessSuccessBooleanNewPosition63NumberMessageString),
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
        public bool Equals(ResultSuccessBooleanNewPosition63NumberMessageStringString other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Helicone.ResultSuccessSuccessBooleanNewPosition63NumberMessageString?>.Default.Equals(ResultSuccessSuccessBooleanNewPosition63NumberMessageString, other.ResultSuccessSuccessBooleanNewPosition63NumberMessageString) &&
                global::System.Collections.Generic.EqualityComparer<global::Helicone.ResultErrorString?>.Default.Equals(Error, other.Error) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(ResultSuccessBooleanNewPosition63NumberMessageStringString obj1, ResultSuccessBooleanNewPosition63NumberMessageStringString obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<ResultSuccessBooleanNewPosition63NumberMessageStringString>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(ResultSuccessBooleanNewPosition63NumberMessageStringString obj1, ResultSuccessBooleanNewPosition63NumberMessageStringString obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is ResultSuccessBooleanNewPosition63NumberMessageStringString o && Equals(o);
        }
    }
}
