# Service Fabric Liveness Probe

A Service Fabric Project that contains a .NET 8 Web API that implements the [ASP.NET Core Health Check](https://learn.microsoft.com/en-us/aspnet/core/host-and-deploy/health-checks?view=aspnetcore-8.0) middleware.

The Service Fabric Project is configured to use the health check endpoint as a [Liveness Probe](https://learn.microsoft.com/en-us/azure/service-fabric/probes-codepackage).
