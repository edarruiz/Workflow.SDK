namespace Workflow.SDK;

/// <summary>
/// Represents the generic <see cref="IWorkflowStep"/> context information implementation interface.
/// </summary>
/// <typeparam name="TData">Generic type representing the shared data passed from one
/// <see cref="IWorkflowStep"/> to another inside the <see cref="IWorkflow"/>.</typeparam>
/// <remarks>A step context represents the generic typed shared data passed from
/// one <see cref="IWorkflowStep"/> to another inside the <see cref="IWorkflow"/>.
/// <para>The context represents the main actor of the <see cref="IWorkflowStep"/>, containing
/// the main data or state relevant to the workflow pipeline, to be processed 
/// inside the executing step.</para>
/// </remarks>

public interface IWorkflowStepContext<TData> : IWorkflowStepContext {
    /// <summary>
    /// Gets or sets the <see cref="IWorkflowStep"/> shared data to be used within the steps.
    /// </summary>
    new TData Data { get; set; }
}