#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace CursorAgents
{
    /// <summary>
    /// An ordinary follow-up, which omits `delivery`, or a steer, which<br/>
    /// sets `delivery` to `steer`.
    /// </summary>
    public readonly partial struct CreateRunRequest : global::System.IEquatable<CreateRunRequest>
    {
        /// <summary>
        /// An ordinary follow-up. It starts a new run and returns `201`, or<br/>
        /// returns `409 agent_busy` while another run is active.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::CursorAgents.FollowupRunRequest? Followup { get; init; }
#else
        public global::CursorAgents.FollowupRunRequest? Followup { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Followup))]
#endif
        public bool IsFollowup => Followup != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickFollowup(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::CursorAgents.FollowupRunRequest? value)
        {
            value = Followup;
            return IsFollowup;
        }

        /// <summary>
        ///
        /// </summary>
        public global::CursorAgents.FollowupRunRequest PickFollowup() => Followup is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'Followup' but the value was {ToString()}.");

        /// <summary>
        /// A steer sends the prompt into the agent's running turn instead of<br/>
        /// starting a new run, and returns `202` with a `SteerRunResponse`.<br/>
        /// It requires `prompt` and `delivery` and accepts no other top-level<br/>
        /// fields. Any other field, such as `model`, `mcpServers`, `envVars`,<br/>
        /// or `mode`, returns `400 validation_error` with a message that<br/>
        /// names the fields, such as<br/>
        /// `"model" is not allowed with delivery "steer"` or<br/>
        /// `"model", "mode" are not allowed with delivery "steer"`.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::CursorAgents.SteerRunRequest? Steer { get; init; }
#else
        public global::CursorAgents.SteerRunRequest? Steer { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Steer))]
#endif
        public bool IsSteer => Steer != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickSteer(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::CursorAgents.SteerRunRequest? value)
        {
            value = Steer;
            return IsSteer;
        }

        /// <summary>
        ///
        /// </summary>
        public global::CursorAgents.SteerRunRequest PickSteer() => Steer is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'Steer' but the value was {ToString()}.");
        /// <summary>
        ///
        /// </summary>
        public static implicit operator CreateRunRequest(global::CursorAgents.FollowupRunRequest value) => new CreateRunRequest((global::CursorAgents.FollowupRunRequest?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::CursorAgents.FollowupRunRequest?(CreateRunRequest @this) => @this.Followup;

        /// <summary>
        ///
        /// </summary>
        public CreateRunRequest(global::CursorAgents.FollowupRunRequest? value)
        {
            Followup = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static CreateRunRequest FromFollowup(global::CursorAgents.FollowupRunRequest? value) => new CreateRunRequest(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator CreateRunRequest(global::CursorAgents.SteerRunRequest value) => new CreateRunRequest((global::CursorAgents.SteerRunRequest?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::CursorAgents.SteerRunRequest?(CreateRunRequest @this) => @this.Steer;

        /// <summary>
        ///
        /// </summary>
        public CreateRunRequest(global::CursorAgents.SteerRunRequest? value)
        {
            Steer = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static CreateRunRequest FromSteer(global::CursorAgents.SteerRunRequest? value) => new CreateRunRequest(value);

        /// <summary>
        ///
        /// </summary>
        public CreateRunRequest(
            global::CursorAgents.FollowupRunRequest? followup,
            global::CursorAgents.SteerRunRequest? steer
            )
        {
            Followup = followup;
            Steer = steer;
        }

        /// <summary>
        ///
        /// </summary>
        public object? Object =>
            Steer as object ??
            Followup as object
            ;

        /// <summary>
        ///
        /// </summary>
        public override string? ToString() =>
            Followup?.ToString() ??
            Steer?.ToString()
            ;

        /// <summary>
        ///
        /// </summary>
        public bool Validate()
        {
            return IsFollowup && !IsSteer || !IsFollowup && IsSteer;
        }

        /// <summary>
        ///
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::CursorAgents.FollowupRunRequest, TResult>? followup = null,
            global::System.Func<global::CursorAgents.SteerRunRequest, TResult>? steer = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (Followup is { } __value0 && followup != null)
            {
                return followup(__value0);
            }
            else if (Steer is { } __value1 && steer != null)
            {
                return steer(__value1);
            }

            return default(TResult);
        }

        /// <summary>
        ///
        /// </summary>
        public void Match(
            global::System.Action<global::CursorAgents.FollowupRunRequest>? followup = null,

            global::System.Action<global::CursorAgents.SteerRunRequest>? steer = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (Followup is { } __value0)
            {
                followup?.Invoke(__value0);
            }
            else if (Steer is { } __value1)
            {
                steer?.Invoke(__value1);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public void Switch(
            global::System.Action<global::CursorAgents.FollowupRunRequest>? followup = null,
            global::System.Action<global::CursorAgents.SteerRunRequest>? steer = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (Followup is { } __value0)
            {
                followup?.Invoke(__value0);
            }
            else if (Steer is { } __value1)
            {
                steer?.Invoke(__value1);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                Followup,
                typeof(global::CursorAgents.FollowupRunRequest),
                Steer,
                typeof(global::CursorAgents.SteerRunRequest),
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
        public bool Equals(CreateRunRequest other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::CursorAgents.FollowupRunRequest?>.Default.Equals(Followup, other.Followup) &&
                global::System.Collections.Generic.EqualityComparer<global::CursorAgents.SteerRunRequest?>.Default.Equals(Steer, other.Steer)
                ;
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator ==(CreateRunRequest obj1, CreateRunRequest obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<CreateRunRequest>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(CreateRunRequest obj1, CreateRunRequest obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is CreateRunRequest o && Equals(o);
        }
    }
}
