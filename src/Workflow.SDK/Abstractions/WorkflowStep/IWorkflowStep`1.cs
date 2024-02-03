namespace Workflow.SDK;

/// <summary>
/// Represents the synchronous workflow step implementation interface
/// </summary>
/// <remarks>A step is a unit of work or functionality that can be executed by a <see cref="IWorkflow"/>, 
/// also known as stage.
/// <para>Each step is taking input from the previous step, executes its specific functionality, 
/// and produces output for the next step.</para>
/// </remarks>
public interface IWorkflowStep {
    /// <summary>
    /// Runs the step, executing its business logic using the current <see cref="IWorkflowStepContext"/> shared data.
    /// </summary>
    /// <param name="context">The <see cref="IWorkflowStepContext"/> representing the shared data of the step.</param>
    /// <returns>Returns a <see cref="IWorkflowStepResult"/> representing the 
    /// result of the step execution.</returns>
    IWorkflowStepResult Run(IWorkflowStepContext context);

    /// <summary>
    /// Runs the step, executing its business logic using the current <see cref="IWorkflowStepContext"/> shared data.
    /// </summary>
    /// <typeparam name="TData">Generic type representing the shared data passed from one
    /// <see cref="IWorkflowStep"/> to another inside the <see cref="IWorkflow"/>.</typeparam>
    /// <param name="context">The <see cref="IWorkflowStepContext"/> representing the shared data of the step.</param>
    /// <returns>Returns a <see cref="IWorkflowStepResult"/> representing the 
    /// result of the step execution.</returns>
    IWorkflowStepResult Run<TData>(IWorkflowStepContext<TData> context);
}