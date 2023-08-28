using DevExtreme.AspNet.Data.ResponseModel;
using Microsoft.AspNetCore.Components;
using System.Text.Json;
using DevExtreme.AspNet.Data;
using DevExpress.Blazor;

namespace CustomData.Data {
    public class WebApiLookup {
        public string Text { get; set; }
        public string Value { get; set; }
    }

    public static class CustomDataHelper {
        public static async Task<LoadResult> LoadCustomData(HttpClient client, DataSourceLoadOptionsBase options, CancellationToken cancellationToken) {
            using var response = await client.GetAsync(options.ConvertToGetRequestUri
                ("https://js.devexpress.com/Demos/NetCore/api/DataGridWebApi/CustomersLookup"), cancellationToken);
            response.EnsureSuccessStatusCode();
            using var responseStream = await response.Content.ReadAsStreamAsync();
            return await JsonSerializer.DeserializeAsync<LoadResult>(responseStream, cancellationToken: cancellationToken);
        }
    }
}
