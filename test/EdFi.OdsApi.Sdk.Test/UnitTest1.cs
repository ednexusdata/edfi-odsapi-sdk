using EdFi.OdsApi.Sdk.Apis.All;
using EdFi.OdsApi.Sdk.Client;
using EdNexusData.Broker.Connector.EdFiAlliance.EdFi;

namespace EdFi.OdsApi.Sdk.Test;

public class UnitTest1
{
    [Fact]
    public async void Test1()
    {
        // TokenRetriever makes the oauth calls.  It has RestSharp dependency, install via NuGet
        var tokenRetriever = new TokenRetriever("http://localhost:8022", "populated", "populatedSecret");

        // Retrieve token
        var retrievedToken = await tokenRetriever.ObtainNewBearerToken();
        _ = retrievedToken ?? throw new ArgumentNullException($"Unable to retrieve token for {"http://localhost:8022"} / {nameof(retrievedToken)}");

        // Plug OAuth access token. Tokens will need to be refreshed when they expire
        var configuration = new Configuration()
        {
            AccessToken = retrievedToken,
            BasePath = $"http://localhost:8022/data/v3"
        };

        var studentName = "Solis";

        var edfiStudentsApi = new StudentsApi(configuration);
        var edfiResults = await edfiStudentsApi.GetStudentsAsync(); // firstName: studentName
        edfiResults.AddRange(await edfiStudentsApi.GetStudentsAsync(lastSurname: studentName));
        edfiResults.AddRange(await edfiStudentsApi.GetStudentsAsync(studentUniqueId: studentName));

        Assert.True(edfiResults.Count > 0, "EdFi results should be greater than 0.");
    }
}