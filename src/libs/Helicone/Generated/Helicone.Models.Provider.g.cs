#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Helicone
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct Provider : global::System.IEquatable<Provider>
    {
        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Helicone.ProviderName? Name { get; init; }
#else
        public global::Helicone.ProviderName? Name { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Name))]
#endif
        public bool IsName => Name != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Helicone.ModelProviderName? ModelName { get; init; }
#else
        public global::Helicone.ModelProviderName? ModelName { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ModelName))]
#endif
        public bool IsModelName => ModelName != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Helicone.ProviderEnum? Enum { get; init; }
#else
        public global::Helicone.ProviderEnum? Enum { get; }
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
        public static implicit operator Provider(global::Helicone.ProviderName value) => new Provider((global::Helicone.ProviderName?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Helicone.ProviderName?(Provider @this) => @this.Name;

        /// <summary>
        /// 
        /// </summary>
        public Provider(global::Helicone.ProviderName? value)
        {
            Name = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator Provider(global::Helicone.ModelProviderName value) => new Provider((global::Helicone.ModelProviderName?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Helicone.ModelProviderName?(Provider @this) => @this.ModelName;

        /// <summary>
        /// 
        /// </summary>
        public Provider(global::Helicone.ModelProviderName? value)
        {
            ModelName = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator Provider(global::Helicone.ProviderEnum value) => new Provider((global::Helicone.ProviderEnum?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Helicone.ProviderEnum?(Provider @this) => @this.Enum;

        /// <summary>
        /// 
        /// </summary>
        public Provider(global::Helicone.ProviderEnum? value)
        {
            Enum = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public Provider(
            global::Helicone.ProviderName? name,
            global::Helicone.ModelProviderName? modelName,
            global::Helicone.ProviderEnum? @enum
            )
        {
            Name = name;
            ModelName = modelName;
            Enum = @enum;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            Enum as object ??
            ModelName as object ??
            Name as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            Name?.ToValueString() ??
            ModelName?.ToValueString() ??
            Enum?.ToValueString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsName || IsModelName || IsEnum;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Helicone.ProviderName?, TResult>? name = null,
            global::System.Func<global::Helicone.ModelProviderName?, TResult>? modelName = null,
            global::System.Func<global::Helicone.ProviderEnum?, TResult>? @enum = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsName && name != null)
            {
                return name(Name!);
            }
            else if (IsModelName && modelName != null)
            {
                return modelName(ModelName!);
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
            global::System.Action<global::Helicone.ProviderName?>? name = null,
            global::System.Action<global::Helicone.ModelProviderName?>? modelName = null,
            global::System.Action<global::Helicone.ProviderEnum?>? @enum = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsName)
            {
                name?.Invoke(Name!);
            }
            else if (IsModelName)
            {
                modelName?.Invoke(ModelName!);
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
                Name,
                typeof(global::Helicone.ProviderName),
                ModelName,
                typeof(global::Helicone.ModelProviderName),
                Enum,
                typeof(global::Helicone.ProviderEnum),
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
        public bool Equals(Provider other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Helicone.ProviderName?>.Default.Equals(Name, other.Name) &&
                global::System.Collections.Generic.EqualityComparer<global::Helicone.ModelProviderName?>.Default.Equals(ModelName, other.ModelName) &&
                global::System.Collections.Generic.EqualityComparer<global::Helicone.ProviderEnum?>.Default.Equals(Enum, other.Enum) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(Provider obj1, Provider obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<Provider>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(Provider obj1, Provider obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is Provider o && Equals(o);
        }
    }
}
