var builder = DistributedApplication.CreateBuilder(args);

var apiService = builder.AddProject<Projects.Paul_ApiService>("apiservice");

builder.AddProject<Projects.Paul_Web>("webfrontend")
    .WithExternalHttpEndpoints()
    .WithReference(apiService);

builder.Build().Run();
