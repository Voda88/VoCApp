using Azure.Identity;
using Microsoft.Azure.Cosmos;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddRazorPages();
builder.Services.AddServerSideBlazor();
builder.Services.AddBlazorBootstrap();

if (builder.Environment.IsDevelopment())
{
    builder.Services.AddSingleton<CosmosClient>((_) =>
    {
        // <create_client>
        CosmosClient client = new("AccountEndpoint=https://common-weu-voc-dev-cosno001.documents.azure.com:443/;AccountKey=QGvwJaTVzgkMktL4KaAhmrwWE4mYAcX0hmTxGiSqy5lnCCkCZnoWymOTa1ET2XXUIvDjUHAy6dR4ACDbXKFyCQ==;"
        );
        // </create_client>
        return client;
    });
}
else
{
    builder.Services.AddSingleton<CosmosClient>((_) =>
    {
        // <create_client_client_id>
        CosmosClient client = new(
            accountEndpoint: builder.Configuration["AZURE_COSMOS_DB_NOSQL_ENDPOINT"]!,
            tokenCredential: new DefaultAzureCredential(
                new DefaultAzureCredentialOptions()
                {
                    ManagedIdentityClientId = builder.Configuration["AZURE_MANAGED_IDENTITY_CLIENT_ID"]!
                }
            )
        );
        // </create_client_client_id>
        return client;
    });
}

var app = builder.Build();

app.UseDeveloperExceptionPage();

app.UseHttpsRedirection();

app.UseStaticFiles();

app.UseRouting();

app.MapBlazorHub();
app.MapFallbackToPage("/_Host");

app.Run();
