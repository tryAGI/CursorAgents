#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace CursorAgents
{
    /// <summary>
    ///
    /// </summary>
    public readonly partial struct GetEnvironmentResponse : global::System.IEquatable<GetEnvironmentResponse>
    {
        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::CursorAgents.Environment? Environment { get; init; }
#else
        public global::CursorAgents.Environment? Environment { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Environment))]
#endif
        public bool IsEnvironment => Environment != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickEnvironment(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::CursorAgents.Environment? value)
        {
            value = Environment;
            return IsEnvironment;
        }

        /// <summary>
        ///
        /// </summary>
        public global::CursorAgents.Environment PickEnvironment() => Environment is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'Environment' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::CursorAgents.GetEnvironmentResponseVariant2? GetEnvironmentResponseVariant2 { get; init; }
#else
        public global::CursorAgents.GetEnvironmentResponseVariant2? GetEnvironmentResponseVariant2 { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(GetEnvironmentResponseVariant2))]
#endif
        public bool IsGetEnvironmentResponseVariant2 => GetEnvironmentResponseVariant2 != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickGetEnvironmentResponseVariant2(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::CursorAgents.GetEnvironmentResponseVariant2? value)
        {
            value = GetEnvironmentResponseVariant2;
            return IsGetEnvironmentResponseVariant2;
        }

        /// <summary>
        ///
        /// </summary>
        public global::CursorAgents.GetEnvironmentResponseVariant2 PickGetEnvironmentResponseVariant2() => GetEnvironmentResponseVariant2 is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'GetEnvironmentResponseVariant2' but the value was {ToString()}.");
        /// <summary>
        ///
        /// </summary>
        public static implicit operator GetEnvironmentResponse(global::CursorAgents.Environment value) => new GetEnvironmentResponse((global::CursorAgents.Environment?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::CursorAgents.Environment?(GetEnvironmentResponse @this) => @this.Environment;

        /// <summary>
        ///
        /// </summary>
        public GetEnvironmentResponse(global::CursorAgents.Environment? value)
        {
            Environment = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static GetEnvironmentResponse FromEnvironment(global::CursorAgents.Environment? value) => new GetEnvironmentResponse(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator GetEnvironmentResponse(global::CursorAgents.GetEnvironmentResponseVariant2 value) => new GetEnvironmentResponse((global::CursorAgents.GetEnvironmentResponseVariant2?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::CursorAgents.GetEnvironmentResponseVariant2?(GetEnvironmentResponse @this) => @this.GetEnvironmentResponseVariant2;

        /// <summary>
        ///
        /// </summary>
        public GetEnvironmentResponse(global::CursorAgents.GetEnvironmentResponseVariant2? value)
        {
            GetEnvironmentResponseVariant2 = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static GetEnvironmentResponse FromGetEnvironmentResponseVariant2(global::CursorAgents.GetEnvironmentResponseVariant2? value) => new GetEnvironmentResponse(value);

        /// <summary>
        ///
        /// </summary>
        public GetEnvironmentResponse(
            global::CursorAgents.Environment? environment,
            global::CursorAgents.GetEnvironmentResponseVariant2? getEnvironmentResponseVariant2
            )
        {
            Environment = environment;
            GetEnvironmentResponseVariant2 = getEnvironmentResponseVariant2;
        }

        /// <summary>
        ///
        /// </summary>
        public object? Object =>
            GetEnvironmentResponseVariant2 as object ??
            Environment as object
            ;

        /// <summary>
        ///
        /// </summary>
        public override string? ToString() =>
            Environment?.ToString() ??
            GetEnvironmentResponseVariant2?.ToString()
            ;

        /// <summary>
        ///
        /// </summary>
        public bool Validate()
        {
            return IsEnvironment && IsGetEnvironmentResponseVariant2;
        }

        /// <summary>
        ///
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::CursorAgents.Environment, TResult>? environment = null,
            global::System.Func<global::CursorAgents.GetEnvironmentResponseVariant2, TResult>? getEnvironmentResponseVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (Environment is { } __value0 && environment != null)
            {
                return environment(__value0);
            }
            else if (GetEnvironmentResponseVariant2 is { } __value1 && getEnvironmentResponseVariant2 != null)
            {
                return getEnvironmentResponseVariant2(__value1);
            }

            return default(TResult);
        }

        /// <summary>
        ///
        /// </summary>
        public void Match(
            global::System.Action<global::CursorAgents.Environment>? environment = null,

            global::System.Action<global::CursorAgents.GetEnvironmentResponseVariant2>? getEnvironmentResponseVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (Environment is { } __value0)
            {
                environment?.Invoke(__value0);
            }
            else if (GetEnvironmentResponseVariant2 is { } __value1)
            {
                getEnvironmentResponseVariant2?.Invoke(__value1);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public void Switch(
            global::System.Action<global::CursorAgents.Environment>? environment = null,
            global::System.Action<global::CursorAgents.GetEnvironmentResponseVariant2>? getEnvironmentResponseVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (Environment is { } __value0)
            {
                environment?.Invoke(__value0);
            }
            else if (GetEnvironmentResponseVariant2 is { } __value1)
            {
                getEnvironmentResponseVariant2?.Invoke(__value1);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                Environment,
                typeof(global::CursorAgents.Environment),
                GetEnvironmentResponseVariant2,
                typeof(global::CursorAgents.GetEnvironmentResponseVariant2),
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
        public bool Equals(GetEnvironmentResponse other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::CursorAgents.Environment?>.Default.Equals(Environment, other.Environment) &&
                global::System.Collections.Generic.EqualityComparer<global::CursorAgents.GetEnvironmentResponseVariant2?>.Default.Equals(GetEnvironmentResponseVariant2, other.GetEnvironmentResponseVariant2)
                ;
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator ==(GetEnvironmentResponse obj1, GetEnvironmentResponse obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<GetEnvironmentResponse>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(GetEnvironmentResponse obj1, GetEnvironmentResponse obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is GetEnvironmentResponse o && Equals(o);
        }
    }
}
