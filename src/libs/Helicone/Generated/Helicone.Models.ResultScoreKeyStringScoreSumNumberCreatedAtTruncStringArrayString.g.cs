#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Helicone
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct ResultScoreKeyStringScoreSumNumberCreatedAtTruncStringArrayString : global::System.IEquatable<ResultScoreKeyStringScoreSumNumberCreatedAtTruncStringArrayString>
    {
        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Helicone.ResultSuccessScoreKeyStringScoreSumNumberCreatedAtTruncStringArray? Success { get; init; }
#else
        public global::Helicone.ResultSuccessScoreKeyStringScoreSumNumberCreatedAtTruncStringArray? Success { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Success))]
#endif
        public bool IsSuccess => Success != null;

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
        public static implicit operator ResultScoreKeyStringScoreSumNumberCreatedAtTruncStringArrayString(global::Helicone.ResultSuccessScoreKeyStringScoreSumNumberCreatedAtTruncStringArray value) => new ResultScoreKeyStringScoreSumNumberCreatedAtTruncStringArrayString((global::Helicone.ResultSuccessScoreKeyStringScoreSumNumberCreatedAtTruncStringArray?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Helicone.ResultSuccessScoreKeyStringScoreSumNumberCreatedAtTruncStringArray?(ResultScoreKeyStringScoreSumNumberCreatedAtTruncStringArrayString @this) => @this.Success;

        /// <summary>
        /// 
        /// </summary>
        public ResultScoreKeyStringScoreSumNumberCreatedAtTruncStringArrayString(global::Helicone.ResultSuccessScoreKeyStringScoreSumNumberCreatedAtTruncStringArray? value)
        {
            Success = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ResultScoreKeyStringScoreSumNumberCreatedAtTruncStringArrayString(global::Helicone.ResultErrorString value) => new ResultScoreKeyStringScoreSumNumberCreatedAtTruncStringArrayString((global::Helicone.ResultErrorString?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Helicone.ResultErrorString?(ResultScoreKeyStringScoreSumNumberCreatedAtTruncStringArrayString @this) => @this.Error;

        /// <summary>
        /// 
        /// </summary>
        public ResultScoreKeyStringScoreSumNumberCreatedAtTruncStringArrayString(global::Helicone.ResultErrorString? value)
        {
            Error = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public ResultScoreKeyStringScoreSumNumberCreatedAtTruncStringArrayString(
            global::Helicone.ResultSuccessScoreKeyStringScoreSumNumberCreatedAtTruncStringArray? success,
            global::Helicone.ResultErrorString? error
            )
        {
            Success = success;
            Error = error;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            Error as object ??
            Success as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            Success?.ToString() ??
            Error?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsSuccess || IsError;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Helicone.ResultSuccessScoreKeyStringScoreSumNumberCreatedAtTruncStringArray?, TResult>? success = null,
            global::System.Func<global::Helicone.ResultErrorString?, TResult>? error = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsSuccess && success != null)
            {
                return success(Success!);
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
            global::System.Action<global::Helicone.ResultSuccessScoreKeyStringScoreSumNumberCreatedAtTruncStringArray?>? success = null,
            global::System.Action<global::Helicone.ResultErrorString?>? error = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsSuccess)
            {
                success?.Invoke(Success!);
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
                Success,
                typeof(global::Helicone.ResultSuccessScoreKeyStringScoreSumNumberCreatedAtTruncStringArray),
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
        public bool Equals(ResultScoreKeyStringScoreSumNumberCreatedAtTruncStringArrayString other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Helicone.ResultSuccessScoreKeyStringScoreSumNumberCreatedAtTruncStringArray?>.Default.Equals(Success, other.Success) &&
                global::System.Collections.Generic.EqualityComparer<global::Helicone.ResultErrorString?>.Default.Equals(Error, other.Error) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(ResultScoreKeyStringScoreSumNumberCreatedAtTruncStringArrayString obj1, ResultScoreKeyStringScoreSumNumberCreatedAtTruncStringArrayString obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<ResultScoreKeyStringScoreSumNumberCreatedAtTruncStringArrayString>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(ResultScoreKeyStringScoreSumNumberCreatedAtTruncStringArrayString obj1, ResultScoreKeyStringScoreSumNumberCreatedAtTruncStringArrayString obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is ResultScoreKeyStringScoreSumNumberCreatedAtTruncStringArrayString o && Equals(o);
        }
    }
}
