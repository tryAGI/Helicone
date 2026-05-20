#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Helicone
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct ResultCostOverTimeArrayString : global::System.IEquatable<ResultCostOverTimeArrayString>
    {
        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Helicone.ResultSuccessCostOverTimeArray? Success { get; init; }
#else
        public global::Helicone.ResultSuccessCostOverTimeArray? Success { get; }
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
        public bool TryPickSuccess(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Helicone.ResultSuccessCostOverTimeArray? value)
        {
            value = Success;
            return IsSuccess;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Helicone.ResultSuccessCostOverTimeArray PickSuccess() => IsSuccess
            ? Success!
            : throw new global::System.InvalidOperationException($"Expected union variant 'Success' but the value was {ToString()}.");

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
        public bool TryPickError(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Helicone.ResultErrorString? value)
        {
            value = Error;
            return IsError;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Helicone.ResultErrorString PickError() => IsError
            ? Error!
            : throw new global::System.InvalidOperationException($"Expected union variant 'Error' but the value was {ToString()}.");
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ResultCostOverTimeArrayString(global::Helicone.ResultSuccessCostOverTimeArray value) => new ResultCostOverTimeArrayString((global::Helicone.ResultSuccessCostOverTimeArray?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Helicone.ResultSuccessCostOverTimeArray?(ResultCostOverTimeArrayString @this) => @this.Success;

        /// <summary>
        /// 
        /// </summary>
        public ResultCostOverTimeArrayString(global::Helicone.ResultSuccessCostOverTimeArray? value)
        {
            Success = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static ResultCostOverTimeArrayString FromSuccess(global::Helicone.ResultSuccessCostOverTimeArray? value) => new ResultCostOverTimeArrayString(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ResultCostOverTimeArrayString(global::Helicone.ResultErrorString value) => new ResultCostOverTimeArrayString((global::Helicone.ResultErrorString?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Helicone.ResultErrorString?(ResultCostOverTimeArrayString @this) => @this.Error;

        /// <summary>
        /// 
        /// </summary>
        public ResultCostOverTimeArrayString(global::Helicone.ResultErrorString? value)
        {
            Error = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static ResultCostOverTimeArrayString FromError(global::Helicone.ResultErrorString? value) => new ResultCostOverTimeArrayString(value);

        /// <summary>
        /// 
        /// </summary>
        public ResultCostOverTimeArrayString(
            global::Helicone.ResultSuccessCostOverTimeArray? success,
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
            global::System.Func<global::Helicone.ResultSuccessCostOverTimeArray, TResult>? success = null,
            global::System.Func<global::Helicone.ResultErrorString, TResult>? error = null,
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
            global::System.Action<global::Helicone.ResultSuccessCostOverTimeArray>? success = null,

            global::System.Action<global::Helicone.ResultErrorString>? error = null,
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
        public void Switch(
            global::System.Action<global::Helicone.ResultSuccessCostOverTimeArray>? success = null,
            global::System.Action<global::Helicone.ResultErrorString>? error = null,
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
                typeof(global::Helicone.ResultSuccessCostOverTimeArray),
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
        public bool Equals(ResultCostOverTimeArrayString other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Helicone.ResultSuccessCostOverTimeArray?>.Default.Equals(Success, other.Success) &&
                global::System.Collections.Generic.EqualityComparer<global::Helicone.ResultErrorString?>.Default.Equals(Error, other.Error) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(ResultCostOverTimeArrayString obj1, ResultCostOverTimeArrayString obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<ResultCostOverTimeArrayString>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(ResultCostOverTimeArrayString obj1, ResultCostOverTimeArrayString obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is ResultCostOverTimeArrayString o && Equals(o);
        }
    }
}
