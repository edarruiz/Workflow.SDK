namespace Workflow.SDK;

/// <summary>
/// Represents the <see cref="IWorkflowStep"/> context information implementation interface.
/// </summary>
/// <remarks>A step context represents the shared data passed from
/// one <see cref="IWorkflowStep"/> to another inside the <see cref="IWorkflow"/>.
/// <para>The context represents the main actor of the <see cref="IWorkflowStep"/>, containing
/// the main data or state relevant to the workflow pipeline, to be processed 
/// inside the executing step.</para>
/// </remarks>
public interface IWorkflowStepContext {
    /// <summary>
    /// Gets or sets the <see cref="IWorkflowStep"/> shared data to be used within the steps.
    /// </summary>
    object Data { get; set; }

    /// <summary>
    /// Gets or sets the <see cref="IWorkflowStep"/> that owns the context data.
    /// </summary>
    IWorkflowStep Step { get; set; }

    /// <summary>
    /// Gets or sets the <see cref="IWorkflow"/> that owns the <see cref="IWorkflowStep"/>,
    /// which is using current the context data.
    /// </summary>
    IWorkflow Workflow { get; set; }

    /// <summary>
    /// Gets or sets the <see cref="System.Threading.CancellationToken"/> used to
    /// cancel the <see cref="IWorkflowStep"/> execution.
    /// </summary>
    CancellationToken CancellationToken { get; set; }
}