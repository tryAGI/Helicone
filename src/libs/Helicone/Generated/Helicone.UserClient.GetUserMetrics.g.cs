
#nullable enable

namespace Helicone
{
    public partial class UserClient
    {
        partial void PrepareGetUserMetricsArguments(
            global::System.Net.Http.HttpClient httpClient,
            global::Helicone.UserMetricsQueryParams request);
        partial void PrepareGetUserMetricsRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            global::Helicone.UserMetricsQueryParams request);
        partial void ProcessGetUserMetricsResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessGetUserMetricsResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Helicone.ApiException"></exception>
        public async global::System.Threading.Tasks.Task<global::Helicone.ResultUsersUserMetricsResultArrayCountNumberHasUsersBooleanString> GetUserMetricsAsync(

            global::Helicone.UserMetricsQueryParams request,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            PrepareArguments(
                client: HttpClient);
            PrepareGetUserMetricsArguments(
                httpClient: HttpClient,
                request: request);

            var __pathBuilder = new global::Helicone.PathBuilder(
                path: "/v1/user/metrics/query",
                baseUri: HttpClient.BaseAddress); 
            var __path = __pathBuilder.ToString();
            using var __httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Post,
                requestUri: new global::System.Uri(__path, global::System.UriKind.RelativeOrAbsolute));
#if NET6_0_OR_GREATER
            __httpRequest.Version = global::System.Net.HttpVersion.Version11;
            __httpRequest.VersionPolicy = global::System.Net.Http.HttpVersionPolicy.RequestVersionOrHigher;
#endif

            foreach (var __authorization in Authorizations)
            {
                if (__authorization.Type == "Http" ||
                    __authorization.Type == "OAuth2")
                {
                    __httpRequest.Headers.Authorization = new global::System.Net.Http.Headers.AuthenticationHeaderValue(
                        scheme: __authorization.Name,
                        parameter: __authorization.Value);
                }
                else if (__authorization.Type == "ApiKey" &&
                         __authorization.Location == "Header")
                {
                    __httpRequest.Headers.Add(__authorization.Name, __authorization.Value);
                }
            }
            var __httpRequestContentBody = request.ToJson(JsonSerializerContext);
            var __httpRequestContent = new global::System.Net.Http.StringContent(
                content: __httpRequestContentBody,
                encoding: global::System.Text.Encoding.UTF8,
                mediaType: "application/json");
            __httpRequest.Content = __httpRequestContent;

            PrepareRequest(
                client: HttpClient,
                request: __httpRequest);
            PrepareGetUserMetricsRequest(
                httpClient: HttpClient,
                httpRequestMessage: __httpRequest,
                request: request);

            using var __response = await HttpClient.SendAsync(
                request: __httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: HttpClient,
                response: __response);
            ProcessGetUserMetricsResponse(
                httpClient: HttpClient,
                httpResponseMessage: __response);

            if (ReadResponseAsString)
            {
                var __content = await __response.Content.ReadAsStringAsync(
#if NET5_0_OR_GREATER
                    cancellationToken
#endif
                ).ConfigureAwait(false);

                ProcessResponseContent(
                    client: HttpClient,
                    response: __response,
                    content: ref __content);
                ProcessGetUserMetricsResponseContent(
                    httpClient: HttpClient,
                    httpResponseMessage: __response,
                    content: ref __content);

                try
                {
                    __response.EnsureSuccessStatusCode();

                    return
                        global::Helicone.ResultUsersUserMetricsResultArrayCountNumberHasUsersBooleanString.FromJson(__content, JsonSerializerContext) ??
                        throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
                }
                catch (global::System.Exception __ex)
                {
                    throw new global::Helicone.ApiException(
                        message: __content ?? __response.ReasonPhrase ?? string.Empty,
                        innerException: __ex,
                        statusCode: __response.StatusCode)
                    {
                        ResponseBody = __content,
                        ResponseHeaders = global::System.Linq.Enumerable.ToDictionary(
                            __response.Headers,
                            h => h.Key,
                            h => h.Value),
                    };
                }
            }
            else
            {
                try
                {
                    __response.EnsureSuccessStatusCode();

                    using var __content = await __response.Content.ReadAsStreamAsync(
#if NET5_0_OR_GREATER
                        cancellationToken
#endif
                    ).ConfigureAwait(false);

                    return
                        await global::Helicone.ResultUsersUserMetricsResultArrayCountNumberHasUsersBooleanString.FromJsonStreamAsync(__content, JsonSerializerContext).ConfigureAwait(false) ??
                        throw new global::System.InvalidOperationException("Response deserialization failed.");
                }
                catch (global::System.Exception __ex)
                {
                    string? __content = null;
                    try
                    {
                        __content = await __response.Content.ReadAsStringAsync(
#if NET5_0_OR_GREATER
                            cancellationToken
#endif
                        ).ConfigureAwait(false);
                    }
                    catch (global::System.Exception)
                    {
                    }

                    throw new global::Helicone.ApiException(
                        message: __content ?? __response.ReasonPhrase ?? string.Empty,
                        innerException: __ex,
                        statusCode: __response.StatusCode)
                    {
                        ResponseBody = __content,
                        ResponseHeaders = global::System.Linq.Enumerable.ToDictionary(
                            __response.Headers,
                            h => h.Key,
                            h => h.Value),
                    };
                }
            }
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="filter"></param>
        /// <param name="offset"></param>
        /// <param name="limit"></param>
        /// <param name="timeFilter"></param>
        /// <param name="timeZoneDifferenceMinutes"></param>
        /// <param name="sort"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::Helicone.ResultUsersUserMetricsResultArrayCountNumberHasUsersBooleanString> GetUserMetricsAsync(
            global::Helicone.UserFilterNode filter,
            double offset,
            double limit,
            global::Helicone.UserMetricsQueryParamsTimeFilter? timeFilter = default,
            double? timeZoneDifferenceMinutes = default,
            global::Helicone.SortLeafUsers? sort = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var __request = new global::Helicone.UserMetricsQueryParams
            {
                Filter = filter,
                Offset = offset,
                Limit = limit,
                TimeFilter = timeFilter,
                TimeZoneDifferenceMinutes = timeZoneDifferenceMinutes,
                Sort = sort,
            };

            return await GetUserMetricsAsync(
                request: __request,
                cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}