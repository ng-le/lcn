var builder = DistributedApplication.CreateBuilder(args);

builder.AddProject<Projects.Task_Api>("task-api");

builder.Build().Run();
