namespace Workflow.SDK;

/// <summary>
/// Represents the asynchronous workflow step implementation interface.
/// </summary>
/// <typeparam name="TData">Generic type representing the shared data passed from one
/// <see cref="IWorkflowStep"/> to another inside the <see cref="IWorkflow"/>.</typeparam>
/// <remarks>A step is a unit of work or functionality that can be executed by a <see cref="IWorkflow"/>, 
/// also known as stage.
/// <para>Each step is taking input from the previous step, executes its specific functionality, 
/// and produces output for the next step.</para>
/// </remarks>
public interface IWorkflowStepAsync<TData> {
    /// <summary>
    /// Runs the step asynchronously, executing its business logic using the current <see cref="IWorkflowStepContext"/> shared data.
    /// </summary>
    /// <typeparam name="TData">Generic type representing the shared data passed from one
    /// <see cref="IWorkflowStep"/> to another inside the <see cref="IWorkflow"/>.</typeparam>
    /// <param name="context">The <see cref="IWorkflowStepContext"/> representing the shared data of the step.</param>
    /// <returns>Returns a <see cref="IWorkflowStepResult"/> representing the 
    /// result of the step execution.</returns>
    Task<IWorkflowStepResult> RunAsync(IWorkflowStepContext<TData> context);
}