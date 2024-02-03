using Microsoft.Extensions.DependencyInjection;

namespace Workflow.SDK.Services.Extensions;

/// <summary>
/// Represents the extension class for the workflow service collection.
/// </summary>
public static class WorkflowServiceCollectionExtensions {
    #region Constants
    private const string ERROR_SERVICE_ALREADY_INJECTED =
        "The workflow host service was already registered: Called by 'IServiceCollection.AddWorkflow(...)'.";
    #endregion

    /// <summary>
    /// Add the workflow services into the collection of service descriptors.
    /// </summary>
    /// <param name="services">The <see cref="IServiceCollection"/> representing the collection of service descriptors.</param>
    /// <param name="hostOptions">The <see cref="WorkflowHostOptions"/> representing the workflow host configuration options.</param>
    /// <returns>Returns the <see cref="IServiceCollection"/> representing the collection of service descriptors.</returns>
    public static IServiceCollection AddWorkflow(this IServiceCollection services, Action<WorkflowHostOptions>? hostOptions = null) {
        if (services.Any(descriptor => descriptor.ServiceType == typeof(WorkflowHostOptions))) {
            throw new InvalidOperationException(ERROR_SERVICE_ALREADY_INJECTED);
        }

        var options = new WorkflowHostOptions();

        hostOptions?.Invoke(options);
        services.AddSingleton<IWorkflowHostOptions, WorkflowHostOptions>();

        return services;
    }
}