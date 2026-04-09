
#nullable enable

namespace Helicone
{
    public partial class ExperimentClient
    {


        private static readonly global::Helicone.EndPointSecurityRequirement s_CreateNewPromptVersionForExperimentSecurityRequirement0 =
            new global::Helicone.EndPointSecurityRequirement
            {
                Authorizations = new global::Helicone.EndPointAuthorizationRequirement[]
                {                    new global::Helicone.EndPointAuthorizationRequirement
                    {
                        Type = "Http",
                        Location = "Header",
                        Name = "Bearer",
                        FriendlyName = "Bearer",
                    },
                },
            };
        private static readonly global::Helicone.EndPointSecurityRequirement[] s_CreateNewPromptVersionForExperimentSecurityRequirements =
            new global::Helicone.EndPointSecurityRequirement[]
            {                s_CreateNewPromptVersionForExperimentSecurityRequirement0,
            };
        partial void PrepareCreateNewPromptVersionForExperimentArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref string experimentId,
            global::Helicone.CreateNewPromptVersionForExperimentParams request);
        partial void PrepareCreateNewPromptVersionForExperimentRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            string experimentId,
            global::Helicone.CreateNewPromptVersionForExperimentParams request);
        partial void ProcessCreateNewPromptVersionForExperimentResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessCreateNewPromptVersionForExperimentResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="experimentId"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Helicone.ApiException"></exception>
        public async global::System.Threading.Tasks.Task<global::Helicone.ResultPromptVersionResultString> CreateNewPromptVersionForExperimentAsync(
            string experimentId,

            global::Helicone.CreateNewPromptVersionForExperimentParams request,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            PrepareArguments(
                client: HttpClient);
            PrepareCreateNewPromptVersionForExperimentArguments(
                httpClient: HttpClient,
                experimentId: ref experimentId,
                request: request);


            var __authorizations = global::Helicone.EndPointSecurityResolver.ResolveAuthorizations(
                availableAuthorizations: Authorizations,
                securityRequirements: s_CreateNewPromptVersionForExperimentSecurityRequirements,
                operationName: "CreateNewPromptVersionForExperimentAsync");

            var __pathBuilder = new global::Helicone.PathBuilder(
                path: $"/v2/experiment/{experimentId}/prompt-version",
                baseUri: HttpClient.BaseAddress);
            var __path = __pathBuilder.ToString();
            using var __httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Post,
                requestUri: new global::System.Uri(__path, global::System.UriKind.RelativeOrAbsolute));
#if NET6_0_OR_GREATER
            __httpRequest.Version = global::System.Net.HttpVersion.Version11;
            __httpRequest.VersionPolicy = global::System.Net.Http.HttpVersionPolicy.RequestVersionOrHigher;
#endif

            foreach (var __authorization in __authorizations)
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
            PrepareCreateNewPromptVersionForExperimentRequest(
                httpClient: HttpClient,
                httpRequestMessage: __httpRequest,
                experimentId: experimentId,
                request: request);

            using var __response = await HttpClient.SendAsync(
                request: __httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: HttpClient,
                response: __response);
            ProcessCreateNewPromptVersionForExperimentResponse(
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
                ProcessCreateNewPromptVersionForExperimentResponseContent(
                    httpClient: HttpClient,
                    httpResponseMessage: __response,
                    content: ref __content);

                try
                {
                    __response.EnsureSuccessStatusCode();

                    return
                        global::Helicone.ResultPromptVersionResultString.FromJson(__content, JsonSerializerContext) ??
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
                        await global::Helicone.ResultPromptVersionResultString.FromJsonStreamAsync(__content, JsonSerializerContext).ConfigureAwait(false) ??
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
        /// <param name="experimentId"></param>
        /// <param name="newHeliconeTemplate"></param>
        /// <param name="isMajorVersion"></param>
        /// <param name="metadata">
        /// Construct a type with a set of properties K of type T
        /// </param>
        /// <param name="requestExperimentId"></param>
        /// <param name="bumpForMajorPromptVersionId"></param>
        /// <param name="parentPromptVersionId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::Helicone.ResultPromptVersionResultString> CreateNewPromptVersionForExperimentAsync(
            string experimentId,
            object newHeliconeTemplate,
            string parentPromptVersionId,
            bool? isMajorVersion = default,
            global::Helicone.RecordStringAny? metadata = default,
            string? requestExperimentId = default,
            string? bumpForMajorPromptVersionId = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var __request = new global::Helicone.CreateNewPromptVersionForExperimentParams
            {
                NewHeliconeTemplate = newHeliconeTemplate,
                IsMajorVersion = isMajorVersion,
                Metadata = metadata,
                ExperimentId = requestExperimentId,
                BumpForMajorPromptVersionId = bumpForMajorPromptVersionId,
                ParentPromptVersionId = parentPromptVersionId,
            };

            return await CreateNewPromptVersionForExperimentAsync(
                experimentId: experimentId,
                request: __request,
                cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}