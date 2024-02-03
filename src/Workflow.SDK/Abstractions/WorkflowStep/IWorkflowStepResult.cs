namespace Workflow.SDK;

/// <summary>
/// Represents the step result implementation interface.
/// </summary>
/// <remarks>A step result represents the result of a <see cref="IWorkflowStep"/> execution.
/// <para>Each <see cref="IWorkflowStep"/> is taking input from the previous <see cref="IWorkflowStep"/> and
/// and produces output for the next <see cref="IWorkflowStep"/>.</para>
/// </remarks>
public interface IWorkflowStepResult {
}