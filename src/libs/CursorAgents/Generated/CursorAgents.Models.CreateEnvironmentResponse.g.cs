#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace CursorAgents
{
    /// <summary>
    ///
    /// </summary>
    public readonly partial struct CreateEnvironmentResponse : global::System.IEquatable<CreateEnvironmentResponse>
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
        public object? CreateEnvironmentResponseVariant2 { get; init; }
#else
        public object? CreateEnvironmentResponseVariant2 { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(CreateEnvironmentResponseVariant2))]
#endif
        public bool IsCreateEnvironmentResponseVariant2 => CreateEnvironmentResponseVariant2 != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickCreateEnvironmentResponseVariant2(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out object? value)
        {
            value = CreateEnvironmentResponseVariant2;
            return IsCreateEnvironmentResponseVariant2;
        }

        /// <summary>
        ///
        /// </summary>
        public object PickCreateEnvironmentResponseVariant2() => CreateEnvironmentResponseVariant2 is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'CreateEnvironmentResponseVariant2' but the value was {ToString()}.");
        /// <summary>
        ///
        /// </summary>
        public static implicit operator CreateEnvironmentResponse(global::CursorAgents.Environment value) => new CreateEnvironmentResponse((global::CursorAgents.Environment?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::CursorAgents.Environment?(CreateEnvironmentResponse @this) => @this.Environment;

        /// <summary>
        ///
        /// </summary>
        public CreateEnvironmentResponse(global::CursorAgents.Environment? value)
        {
            Environment = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static CreateEnvironmentResponse FromEnvironment(global::CursorAgents.Environment? value) => new CreateEnvironmentResponse(value);

        /// <summary>
        ///
        /// </summary>
        public CreateEnvironmentResponse(
            global::CursorAgents.Environment? environment,
            object? createEnvironmentResponseVariant2
            )
        {
            Environment = environment;
            CreateEnvironmentResponseVariant2 = createEnvironmentResponseVariant2;
        }

        /// <summary>
        ///
        /// </summary>
        public object? Object =>
            CreateEnvironmentResponseVariant2 as object ??
            Environment as object
            ;

        /// <summary>
        ///
        /// </summary>
        public override string? ToString() =>
            Environment?.ToString() ??
            CreateEnvironmentResponseVariant2?.ToString()
            ;

        /// <summary>
        ///
        /// </summary>
        public bool Validate()
        {
            return IsEnvironment && IsCreateEnvironmentResponseVariant2;
        }

        /// <summary>
        ///
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::CursorAgents.Environment, TResult>? environment = null,
            global::System.Func<object, TResult>? createEnvironmentResponseVariant2 = null,
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
            else if (CreateEnvironmentResponseVariant2 is { } __value1 && createEnvironmentResponseVariant2 != null)
            {
                return createEnvironmentResponseVariant2(__value1);
            }

            return default(TResult);
        }

        /// <summary>
        ///
        /// </summary>
        public void Match(
            global::System.Action<global::CursorAgents.Environment>? environment = null,

            global::System.Action<object>? createEnvironmentResponseVariant2 = null,
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
            else if (CreateEnvironmentResponseVariant2 is { } __value1)
            {
                createEnvironmentResponseVariant2?.Invoke(__value1);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public void Switch(
            global::System.Action<global::CursorAgents.Environment>? environment = null,
            global::System.Action<object>? createEnvironmentResponseVariant2 = null,
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
            else if (CreateEnvironmentResponseVariant2 is { } __value1)
            {
                createEnvironmentResponseVariant2?.Invoke(__value1);
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
                CreateEnvironmentResponseVariant2,
                typeof(object),
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
        public bool Equals(CreateEnvironmentResponse other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::CursorAgents.Environment?>.Default.Equals(Environment, other.Environment) &&
                global::System.Collections.Generic.EqualityComparer<object?>.Default.Equals(CreateEnvironmentResponseVariant2, other.CreateEnvironmentResponseVariant2)
                ;
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator ==(CreateEnvironmentResponse obj1, CreateEnvironmentResponse obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<CreateEnvironmentResponse>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(CreateEnvironmentResponse obj1, CreateEnvironmentResponse obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is CreateEnvironmentResponse o && Equals(o);
        }
    }
}
