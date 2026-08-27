#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Helicone
{
    /// <summary>
    ///
    /// </summary>
    public readonly partial struct ResultUsersOverTimeArrayString : global::System.IEquatable<ResultUsersOverTimeArrayString>
    {
        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Helicone.ResultSuccessUsersOverTimeArray? Success { get; init; }
#else
        public global::Helicone.ResultSuccessUsersOverTimeArray? Success { get; }
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
            out global::Helicone.ResultSuccessUsersOverTimeArray? value)
        {
            value = Success;
            return IsSuccess;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Helicone.ResultSuccessUsersOverTimeArray PickSuccess() => IsSuccess
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
        public static implicit operator ResultUsersOverTimeArrayString(global::Helicone.ResultSuccessUsersOverTimeArray value) => new ResultUsersOverTimeArrayString((global::Helicone.ResultSuccessUsersOverTimeArray?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Helicone.ResultSuccessUsersOverTimeArray?(ResultUsersOverTimeArrayString @this) => @this.Success;

        /// <summary>
        ///
        /// </summary>
        public ResultUsersOverTimeArrayString(global::Helicone.ResultSuccessUsersOverTimeArray? value)
        {
            Success = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static ResultUsersOverTimeArrayString FromSuccess(global::Helicone.ResultSuccessUsersOverTimeArray? value) => new ResultUsersOverTimeArrayString(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator ResultUsersOverTimeArrayString(global::Helicone.ResultErrorString value) => new ResultUsersOverTimeArrayString((global::Helicone.ResultErrorString?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Helicone.ResultErrorString?(ResultUsersOverTimeArrayString @this) => @this.Error;

        /// <summary>
        ///
        /// </summary>
        public ResultUsersOverTimeArrayString(global::Helicone.ResultErrorString? value)
        {
            Error = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static ResultUsersOverTimeArrayString FromError(global::Helicone.ResultErrorString? value) => new ResultUsersOverTimeArrayString(value);

        /// <summary>
        ///
        /// </summary>
        public ResultUsersOverTimeArrayString(
            global::Helicone.ResultSuccessUsersOverTimeArray? success,
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
            global::System.Func<global::Helicone.ResultSuccessUsersOverTimeArray, TResult>? success = null,
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
            global::System.Action<global::Helicone.ResultSuccessUsersOverTimeArray>? success = null,

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
            global::System.Action<global::Helicone.ResultSuccessUsersOverTimeArray>? success = null,
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
                typeof(global::Helicone.ResultSuccessUsersOverTimeArray),
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
        public bool Equals(ResultUsersOverTimeArrayString other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Helicone.ResultSuccessUsersOverTimeArray?>.Default.Equals(Success, other.Success) &&
                global::System.Collections.Generic.EqualityComparer<global::Helicone.ResultErrorString?>.Default.Equals(Error, other.Error)
                ;
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator ==(ResultUsersOverTimeArrayString obj1, ResultUsersOverTimeArrayString obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<ResultUsersOverTimeArrayString>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(ResultUsersOverTimeArrayString obj1, ResultUsersOverTimeArrayString obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is ResultUsersOverTimeArrayString o && Equals(o);
        }
    }
}
