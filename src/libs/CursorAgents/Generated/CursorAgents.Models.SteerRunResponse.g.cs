#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace CursorAgents
{
    /// <summary>
    /// What happened to a steered prompt. `delivery` is `steered` or<br/>
    /// `queued`, and only a `steered` response can include `runId`.
    /// </summary>
    public readonly partial struct SteerRunResponse : global::System.IEquatable<SteerRunResponse>
    {
        /// <summary>
        ///
        /// </summary>
        public global::CursorAgents.SteerRunResponseDiscriminatorDelivery? Delivery { get; }

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::CursorAgents.SteeredRunResponse? Steered { get; init; }
#else
        public global::CursorAgents.SteeredRunResponse? Steered { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Steered))]
#endif
        public bool IsSteered => Steered != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickSteered(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::CursorAgents.SteeredRunResponse? value)
        {
            value = Steered;
            return IsSteered;
        }

        /// <summary>
        ///
        /// </summary>
        public global::CursorAgents.SteeredRunResponse PickSteered() => Steered is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'Steered' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::CursorAgents.QueuedRunResponse? Queued { get; init; }
#else
        public global::CursorAgents.QueuedRunResponse? Queued { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Queued))]
#endif
        public bool IsQueued => Queued != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickQueued(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::CursorAgents.QueuedRunResponse? value)
        {
            value = Queued;
            return IsQueued;
        }

        /// <summary>
        ///
        /// </summary>
        public global::CursorAgents.QueuedRunResponse PickQueued() => Queued is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'Queued' but the value was {ToString()}.");
        /// <summary>
        ///
        /// </summary>
        public static implicit operator SteerRunResponse(global::CursorAgents.SteeredRunResponse value) => new SteerRunResponse((global::CursorAgents.SteeredRunResponse?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::CursorAgents.SteeredRunResponse?(SteerRunResponse @this) => @this.Steered;

        /// <summary>
        ///
        /// </summary>
        public SteerRunResponse(global::CursorAgents.SteeredRunResponse? value)
        {
            Steered = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static SteerRunResponse FromSteered(global::CursorAgents.SteeredRunResponse? value) => new SteerRunResponse(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator SteerRunResponse(global::CursorAgents.QueuedRunResponse value) => new SteerRunResponse((global::CursorAgents.QueuedRunResponse?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::CursorAgents.QueuedRunResponse?(SteerRunResponse @this) => @this.Queued;

        /// <summary>
        ///
        /// </summary>
        public SteerRunResponse(global::CursorAgents.QueuedRunResponse? value)
        {
            Queued = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static SteerRunResponse FromQueued(global::CursorAgents.QueuedRunResponse? value) => new SteerRunResponse(value);

        /// <summary>
        ///
        /// </summary>
        public SteerRunResponse(
            global::CursorAgents.SteerRunResponseDiscriminatorDelivery? delivery,
            global::CursorAgents.SteeredRunResponse? steered,
            global::CursorAgents.QueuedRunResponse? queued
            )
        {
            Delivery = delivery;

            Steered = steered;
            Queued = queued;
        }

        /// <summary>
        ///
        /// </summary>
        public object? Object =>
            Queued as object ??
            Steered as object
            ;

        /// <summary>
        ///
        /// </summary>
        public override string? ToString() =>
            Steered?.ToString() ??
            Queued?.ToString()
            ;

        /// <summary>
        ///
        /// </summary>
        public bool Validate()
        {
            return IsSteered && !IsQueued || !IsSteered && IsQueued;
        }

        /// <summary>
        ///
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::CursorAgents.SteeredRunResponse, TResult>? steered = null,
            global::System.Func<global::CursorAgents.QueuedRunResponse, TResult>? queued = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (Steered is { } __value0 && steered != null)
            {
                return steered(__value0);
            }
            else if (Queued is { } __value1 && queued != null)
            {
                return queued(__value1);
            }

            return default(TResult);
        }

        /// <summary>
        ///
        /// </summary>
        public void Match(
            global::System.Action<global::CursorAgents.SteeredRunResponse>? steered = null,

            global::System.Action<global::CursorAgents.QueuedRunResponse>? queued = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (Steered is { } __value0)
            {
                steered?.Invoke(__value0);
            }
            else if (Queued is { } __value1)
            {
                queued?.Invoke(__value1);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public void Switch(
            global::System.Action<global::CursorAgents.SteeredRunResponse>? steered = null,
            global::System.Action<global::CursorAgents.QueuedRunResponse>? queued = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (Steered is { } __value0)
            {
                steered?.Invoke(__value0);
            }
            else if (Queued is { } __value1)
            {
                queued?.Invoke(__value1);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                Steered,
                typeof(global::CursorAgents.SteeredRunResponse),
                Queued,
                typeof(global::CursorAgents.QueuedRunResponse),
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
        public bool Equals(SteerRunResponse other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::CursorAgents.SteeredRunResponse?>.Default.Equals(Steered, other.Steered) &&
                global::System.Collections.Generic.EqualityComparer<global::CursorAgents.QueuedRunResponse?>.Default.Equals(Queued, other.Queued)
                ;
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator ==(SteerRunResponse obj1, SteerRunResponse obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<SteerRunResponse>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(SteerRunResponse obj1, SteerRunResponse obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is SteerRunResponse o && Equals(o);
        }
    }
}
