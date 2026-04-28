
#nullable enable

namespace CursorAgents
{
    public sealed partial class CursorAgentsClient
    {
        /// <inheritdoc cref="CursorAgentsClient(global::System.Net.Http.HttpClient?, global::System.Uri?, global::System.Collections.Generic.List{global::CursorAgents.EndPointAuthorization}?, bool)"/>

        public CursorAgentsClient(
            string username,
            string password,
            global::System.Net.Http.HttpClient? httpClient = null,
            global::System.Uri? baseUri = null,
            global::System.Collections.Generic.List<global::CursorAgents.EndPointAuthorization>? authorizations = null,
            bool disposeHttpClient = true) : this(httpClient, baseUri, authorizations, disposeHttpClient)
        {
            Authorizing(HttpClient, ref username, ref password);

            AuthorizeUsingBasic(username, password);

            Authorized(HttpClient);
        }

        partial void Authorizing(
            global::System.Net.Http.HttpClient client,
            ref string username,
            ref string password);
        partial void Authorized(
            global::System.Net.Http.HttpClient client);
    }
}