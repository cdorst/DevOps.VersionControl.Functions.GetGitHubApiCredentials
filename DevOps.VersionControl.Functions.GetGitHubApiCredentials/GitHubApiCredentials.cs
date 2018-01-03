using Common.Structures.HttpBasicAuthentication;
using static System.Environment;

namespace DevOps.VersionControl.Functions.GetGitHubApiCredentials
{
    public static class GitHubApiCredentials
    {
        private const string EnvironmentVariableName = "GITHUB_API_PERSONAL_ACCESS_TOKEN";

        public static BasicAuthenticationCredentials GetCredentials(string user, string personalAccessToken = null)
            => new BasicAuthenticationCredentials(user, GetSecret(personalAccessToken));

        private static string GetSecret(string personalAccessToken)
            => string.IsNullOrWhiteSpace(personalAccessToken)
                ? GetEnvironmentVariable(EnvironmentVariableName)
                : personalAccessToken;
    }
}
