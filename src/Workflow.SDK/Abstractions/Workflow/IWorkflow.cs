namespace Workflow.SDK;

/// <summary>
/// Represents the workflow implementation interface.
/// </summary>
/// <remarks>A workflow is a pipeline. It consists of a sequence of steps or stages, executed one after another
/// and must run inside a <see cref="IWorkflowHost"/>.
/// <para>The workflow process or executes the series of steps or stages in a linear sequence. 
/// It allows you to break down complex tasks into smaller and modular steps or stages that can be 
/// executed in a particular order.</para>
/// <para>Each step is taking input from the previous step, executes its specific functionality, 
/// and produces output for the next step.</para>
/// </remarks>
public interface IWorkflow {
    #region Properties
    /// <summary>
    /// Gets or sets the current workflow status of execution.
    /// </summary>
    WorkflowStatus Status { get; set; }
    #endregion
}