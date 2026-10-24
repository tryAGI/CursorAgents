
#nullable enable

namespace CursorAgents
{
    /// <summary>
    /// Environment variables, at most 50. Each name is 1 to 255<br/>
    /// characters of ASCII letters, digits, and underscores, doesn't<br/>
    /// start with a digit, can't start with `CURSOR_`, and can't<br/>
    /// contain `CURSOR_SANDBOX` in any letter case. Each value is<br/>
    /// non-empty and at most 4096 UTF-8 bytes. `maxLength` counts<br/>
    /// characters, so it's only an upper bound on the byte limit.
    /// </summary>
    public sealed partial class EnvVars
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

    }
}