#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace CursorAgents
{
    /// <summary>
    /// What an agent you start on this environment boots from, one of its builds or Cursor's default image.
    /// </summary>
    public readonly partial struct EnvironmentActiveBuild : global::System.IEquatable<EnvironmentActiveBuild>
    {
        /// <summary>
        ///
        /// </summary>
        public global::CursorAgents.EnvironmentActiveBuildDiscriminatorType? Type { get; }

        /// <summary>
        /// The agent starts from one of the environment's builds.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::CursorAgents.EnvironmentActiveBuildFromBuild? Build { get; init; }
#else
        public global::CursorAgents.EnvironmentActiveBuildFromBuild? Build { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Build))]
#endif
        public bool IsBuild => Build != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickBuild(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::CursorAgents.EnvironmentActiveBuildFromBuild? value)
        {
            value = Build;
            return IsBuild;
        }

        /// <summary>
        ///
        /// </summary>
        public global::CursorAgents.EnvironmentActiveBuildFromBuild PickBuild() => Build is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'Build' but the value was {ToString()}.");

        /// <summary>
        /// The agent starts on Cursor's default image.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::CursorAgents.EnvironmentActiveBuildFromUniversalImage? UniversalImage { get; init; }
#else
        public global::CursorAgents.EnvironmentActiveBuildFromUniversalImage? UniversalImage { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(UniversalImage))]
#endif
        public bool IsUniversalImage => UniversalImage != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickUniversalImage(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::CursorAgents.EnvironmentActiveBuildFromUniversalImage? value)
        {
            value = UniversalImage;
            return IsUniversalImage;
        }

        /// <summary>
        ///
        /// </summary>
        public global::CursorAgents.EnvironmentActiveBuildFromUniversalImage PickUniversalImage() => UniversalImage is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'UniversalImage' but the value was {ToString()}.");
        /// <summary>
        ///
        /// </summary>
        public static implicit operator EnvironmentActiveBuild(global::CursorAgents.EnvironmentActiveBuildFromBuild value) => new EnvironmentActiveBuild((global::CursorAgents.EnvironmentActiveBuildFromBuild?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::CursorAgents.EnvironmentActiveBuildFromBuild?(EnvironmentActiveBuild @this) => @this.Build;

        /// <summary>
        ///
        /// </summary>
        public EnvironmentActiveBuild(global::CursorAgents.EnvironmentActiveBuildFromBuild? value)
        {
            Build = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static EnvironmentActiveBuild FromBuild(global::CursorAgents.EnvironmentActiveBuildFromBuild? value) => new EnvironmentActiveBuild(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator EnvironmentActiveBuild(global::CursorAgents.EnvironmentActiveBuildFromUniversalImage value) => new EnvironmentActiveBuild((global::CursorAgents.EnvironmentActiveBuildFromUniversalImage?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::CursorAgents.EnvironmentActiveBuildFromUniversalImage?(EnvironmentActiveBuild @this) => @this.UniversalImage;

        /// <summary>
        ///
        /// </summary>
        public EnvironmentActiveBuild(global::CursorAgents.EnvironmentActiveBuildFromUniversalImage? value)
        {
            UniversalImage = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static EnvironmentActiveBuild FromUniversalImage(global::CursorAgents.EnvironmentActiveBuildFromUniversalImage? value) => new EnvironmentActiveBuild(value);

        /// <summary>
        ///
        /// </summary>
        public EnvironmentActiveBuild(
            global::CursorAgents.EnvironmentActiveBuildDiscriminatorType? type,
            global::CursorAgents.EnvironmentActiveBuildFromBuild? build,
            global::CursorAgents.EnvironmentActiveBuildFromUniversalImage? universalImage
            )
        {
            Type = type;

            Build = build;
            UniversalImage = universalImage;
        }

        /// <summary>
        ///
        /// </summary>
        public object? Object =>
            UniversalImage as object ??
            Build as object
            ;

        /// <summary>
        ///
        /// </summary>
        public override string? ToString() =>
            Build?.ToString() ??
            UniversalImage?.ToString()
            ;

        /// <summary>
        ///
        /// </summary>
        public bool Validate()
        {
            return IsBuild && !IsUniversalImage || !IsBuild && IsUniversalImage;
        }

        /// <summary>
        ///
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::CursorAgents.EnvironmentActiveBuildFromBuild, TResult>? build = null,
            global::System.Func<global::CursorAgents.EnvironmentActiveBuildFromUniversalImage, TResult>? universalImage = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (Build is { } __value0 && build != null)
            {
                return build(__value0);
            }
            else if (UniversalImage is { } __value1 && universalImage != null)
            {
                return universalImage(__value1);
            }

            return default(TResult);
        }

        /// <summary>
        ///
        /// </summary>
        public void Match(
            global::System.Action<global::CursorAgents.EnvironmentActiveBuildFromBuild>? build = null,

            global::System.Action<global::CursorAgents.EnvironmentActiveBuildFromUniversalImage>? universalImage = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (Build is { } __value0)
            {
                build?.Invoke(__value0);
            }
            else if (UniversalImage is { } __value1)
            {
                universalImage?.Invoke(__value1);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public void Switch(
            global::System.Action<global::CursorAgents.EnvironmentActiveBuildFromBuild>? build = null,
            global::System.Action<global::CursorAgents.EnvironmentActiveBuildFromUniversalImage>? universalImage = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (Build is { } __value0)
            {
                build?.Invoke(__value0);
            }
            else if (UniversalImage is { } __value1)
            {
                universalImage?.Invoke(__value1);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                Build,
                typeof(global::CursorAgents.EnvironmentActiveBuildFromBuild),
                UniversalImage,
                typeof(global::CursorAgents.EnvironmentActiveBuildFromUniversalImage),
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
        public bool Equals(EnvironmentActiveBuild other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::CursorAgents.EnvironmentActiveBuildFromBuild?>.Default.Equals(Build, other.Build) &&
                global::System.Collections.Generic.EqualityComparer<global::CursorAgents.EnvironmentActiveBuildFromUniversalImage?>.Default.Equals(UniversalImage, other.UniversalImage)
                ;
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator ==(EnvironmentActiveBuild obj1, EnvironmentActiveBuild obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<EnvironmentActiveBuild>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(EnvironmentActiveBuild obj1, EnvironmentActiveBuild obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is EnvironmentActiveBuild o && Equals(o);
        }
    }
}
