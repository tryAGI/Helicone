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
        public global::Helicone.ResultSuccessSuccessBooleanNewPosition63NumberMessageString? Value1 { get; init; }
#else
        public global::Helicone.ResultSuccessSuccessBooleanNewPosition63NumberMessageString? Value1 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Value1))]
#endif
        public bool IsValue1 => Value1 != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Helicone.ResultErrorString? Value2 { get; init; }
#else
        public global::Helicone.ResultErrorString? Value2 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Value2))]
#endif
        public bool IsValue2 => Value2 != null;
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ResultSuccessBooleanNewPosition63NumberMessageStringString(global::Helicone.ResultSuccessSuccessBooleanNewPosition63NumberMessageString value) => new ResultSuccessBooleanNewPosition63NumberMessageStringString((global::Helicone.ResultSuccessSuccessBooleanNewPosition63NumberMessageString?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Helicone.ResultSuccessSuccessBooleanNewPosition63NumberMessageString?(ResultSuccessBooleanNewPosition63NumberMessageStringString @this) => @this.Value1;

        /// <summary>
        /// 
        /// </summary>
        public ResultSuccessBooleanNewPosition63NumberMessageStringString(global::Helicone.ResultSuccessSuccessBooleanNewPosition63NumberMessageString? value)
        {
            Value1 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ResultSuccessBooleanNewPosition63NumberMessageStringString(global::Helicone.ResultErrorString value) => new ResultSuccessBooleanNewPosition63NumberMessageStringString((global::Helicone.ResultErrorString?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Helicone.ResultErrorString?(ResultSuccessBooleanNewPosition63NumberMessageStringString @this) => @this.Value2;

        /// <summary>
        /// 
        /// </summary>
        public ResultSuccessBooleanNewPosition63NumberMessageStringString(global::Helicone.ResultErrorString? value)
        {
            Value2 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public ResultSuccessBooleanNewPosition63NumberMessageStringString(
            global::Helicone.ResultSuccessSuccessBooleanNewPosition63NumberMessageString? value1,
            global::Helicone.ResultErrorString? value2
            )
        {
            Value1 = value1;
            Value2 = value2;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            Value2 as object ??
            Value1 as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            Value1?.ToString() ??
            Value2?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsValue1 || IsValue2;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Helicone.ResultSuccessSuccessBooleanNewPosition63NumberMessageString?, TResult>? value1 = null,
            global::System.Func<global::Helicone.ResultErrorString?, TResult>? value2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsValue1 && value1 != null)
            {
                return value1(Value1!);
            }
            else if (IsValue2 && value2 != null)
            {
                return value2(Value2!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::Helicone.ResultSuccessSuccessBooleanNewPosition63NumberMessageString?>? value1 = null,
            global::System.Action<global::Helicone.ResultErrorString?>? value2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsValue1)
            {
                value1?.Invoke(Value1!);
            }
            else if (IsValue2)
            {
                value2?.Invoke(Value2!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                Value1,
                typeof(global::Helicone.ResultSuccessSuccessBooleanNewPosition63NumberMessageString),
                Value2,
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
                global::System.Collections.Generic.EqualityComparer<global::Helicone.ResultSuccessSuccessBooleanNewPosition63NumberMessageString?>.Default.Equals(Value1, other.Value1) &&
                global::System.Collections.Generic.EqualityComparer<global::Helicone.ResultErrorString?>.Default.Equals(Value2, other.Value2) 
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
