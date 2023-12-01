using Microsoft.Extensions.Diagnostics.HealthChecks;

namespace LivenessApi
{
    public class HealthCheck : IHealthCheck
    {
        public static bool Failing { get; internal set; }
        public static int FailedChecks { get; internal set; }

        public Task<HealthCheckResult> CheckHealthAsync(
            HealthCheckContext context, CancellationToken cancellationToken = default)
        {
            if (!Failing)
            {
                return Task.FromResult(
                    HealthCheckResult.Healthy("A healthy result."));
            }
            FailedChecks++;
            return Task.FromResult(
                new HealthCheckResult(
                    context.Registration.FailureStatus, "An unhealthy result."));
        }
    }
}
