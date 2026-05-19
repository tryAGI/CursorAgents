#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace CursorAgents
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct McpServer : global::System.IEquatable<McpServer>
    {
        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::CursorAgents.StdioMcpServer? Stdio { get; init; }
#else
        public global::CursorAgents.StdioMcpServer? Stdio { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Stdio))]
#endif
        public bool IsStdio => Stdio != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickStdio(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::CursorAgents.StdioMcpServer? value)
        {
            value = Stdio;
            return IsStdio;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::CursorAgents.StdioMcpServer PickStdio() => IsStdio
            ? Stdio!
            : throw new global::System.InvalidOperationException($"Expected union variant 'Stdio' but the value was {ToString()}.");

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::CursorAgents.RemoteMcpServer? Remote { get; init; }
#else
        public global::CursorAgents.RemoteMcpServer? Remote { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Remote))]
#endif
        public bool IsRemote => Remote != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickRemote(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::CursorAgents.RemoteMcpServer? value)
        {
            value = Remote;
            return IsRemote;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::CursorAgents.RemoteMcpServer PickRemote() => IsRemote
            ? Remote!
            : throw new global::System.InvalidOperationException($"Expected union variant 'Remote' but the value was {ToString()}.");
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator McpServer(global::CursorAgents.StdioMcpServer value) => new McpServer((global::CursorAgents.StdioMcpServer?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::CursorAgents.StdioMcpServer?(McpServer @this) => @this.Stdio;

        /// <summary>
        /// 
        /// </summary>
        public McpServer(global::CursorAgents.StdioMcpServer? value)
        {
            Stdio = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static McpServer FromStdio(global::CursorAgents.StdioMcpServer? value) => new McpServer(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator McpServer(global::CursorAgents.RemoteMcpServer value) => new McpServer((global::CursorAgents.RemoteMcpServer?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::CursorAgents.RemoteMcpServer?(McpServer @this) => @this.Remote;

        /// <summary>
        /// 
        /// </summary>
        public McpServer(global::CursorAgents.RemoteMcpServer? value)
        {
            Remote = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static McpServer FromRemote(global::CursorAgents.RemoteMcpServer? value) => new McpServer(value);

        /// <summary>
        /// 
        /// </summary>
        public McpServer(
            global::CursorAgents.StdioMcpServer? stdio,
            global::CursorAgents.RemoteMcpServer? remote
            )
        {
            Stdio = stdio;
            Remote = remote;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            Remote as object ??
            Stdio as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            Stdio?.ToString() ??
            Remote?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsStdio && !IsRemote || !IsStdio && IsRemote;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::CursorAgents.StdioMcpServer, TResult>? stdio = null,
            global::System.Func<global::CursorAgents.RemoteMcpServer, TResult>? remote = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsStdio && stdio != null)
            {
                return stdio(Stdio!);
            }
            else if (IsRemote && remote != null)
            {
                return remote(Remote!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::CursorAgents.StdioMcpServer>? stdio = null,

            global::System.Action<global::CursorAgents.RemoteMcpServer>? remote = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsStdio)
            {
                stdio?.Invoke(Stdio!);
            }
            else if (IsRemote)
            {
                remote?.Invoke(Remote!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public void Switch(
            global::System.Action<global::CursorAgents.StdioMcpServer>? stdio = null,
            global::System.Action<global::CursorAgents.RemoteMcpServer>? remote = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsStdio)
            {
                stdio?.Invoke(Stdio!);
            }
            else if (IsRemote)
            {
                remote?.Invoke(Remote!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                Stdio,
                typeof(global::CursorAgents.StdioMcpServer),
                Remote,
                typeof(global::CursorAgents.RemoteMcpServer),
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
        public bool Equals(McpServer other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::CursorAgents.StdioMcpServer?>.Default.Equals(Stdio, other.Stdio) &&
                global::System.Collections.Generic.EqualityComparer<global::CursorAgents.RemoteMcpServer?>.Default.Equals(Remote, other.Remote) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(McpServer obj1, McpServer obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<McpServer>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(McpServer obj1, McpServer obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is McpServer o && Equals(o);
        }
    }
}
