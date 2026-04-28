#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace CursorAgents
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct Agent : global::System.IEquatable<Agent>
    {
        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::CursorAgents.AgentSummary? Summary { get; init; }
#else
        public global::CursorAgents.AgentSummary? Summary { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Summary))]
#endif
        public bool IsSummary => Summary != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::CursorAgents.AgentVariant2? AgentVariant2 { get; init; }
#else
        public global::CursorAgents.AgentVariant2? AgentVariant2 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(AgentVariant2))]
#endif
        public bool IsAgentVariant2 => AgentVariant2 != null;
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator Agent(global::CursorAgents.AgentSummary value) => new Agent((global::CursorAgents.AgentSummary?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::CursorAgents.AgentSummary?(Agent @this) => @this.Summary;

        /// <summary>
        /// 
        /// </summary>
        public Agent(global::CursorAgents.AgentSummary? value)
        {
            Summary = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator Agent(global::CursorAgents.AgentVariant2 value) => new Agent((global::CursorAgents.AgentVariant2?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::CursorAgents.AgentVariant2?(Agent @this) => @this.AgentVariant2;

        /// <summary>
        /// 
        /// </summary>
        public Agent(global::CursorAgents.AgentVariant2? value)
        {
            AgentVariant2 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public Agent(
            global::CursorAgents.AgentSummary? summary,
            global::CursorAgents.AgentVariant2? agentVariant2
            )
        {
            Summary = summary;
            AgentVariant2 = agentVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            AgentVariant2 as object ??
            Summary as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            Summary?.ToString() ??
            AgentVariant2?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsSummary && IsAgentVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::CursorAgents.AgentSummary?, TResult>? summary = null,
            global::System.Func<global::CursorAgents.AgentVariant2?, TResult>? agentVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsSummary && summary != null)
            {
                return summary(Summary!);
            }
            else if (IsAgentVariant2 && agentVariant2 != null)
            {
                return agentVariant2(AgentVariant2!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::CursorAgents.AgentSummary?>? summary = null,
            global::System.Action<global::CursorAgents.AgentVariant2?>? agentVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsSummary)
            {
                summary?.Invoke(Summary!);
            }
            else if (IsAgentVariant2)
            {
                agentVariant2?.Invoke(AgentVariant2!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                Summary,
                typeof(global::CursorAgents.AgentSummary),
                AgentVariant2,
                typeof(global::CursorAgents.AgentVariant2),
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
        public bool Equals(Agent other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::CursorAgents.AgentSummary?>.Default.Equals(Summary, other.Summary) &&
                global::System.Collections.Generic.EqualityComparer<global::CursorAgents.AgentVariant2?>.Default.Equals(AgentVariant2, other.AgentVariant2) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(Agent obj1, Agent obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<Agent>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(Agent obj1, Agent obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is Agent o && Equals(o);
        }
    }
}
