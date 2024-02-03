namespace Workflow.SDK;

/// <summary>
/// Represents the workflow statuses.
/// </summary>
public enum WorkflowStatus {
    /// <summary>
    /// The workflow is idle and is ready to start.
    /// </summary>
    Idle = 0,

    /// <summary>
    /// The workflow is running.
    /// </summary>
    Running = 1,

    /// <summary>
    /// The workflow had its execution suspended.
    /// </summary>
    Suspended = 2,

    /// <summary>
    /// The workflow is completed and its execution was finished.
    /// </summary>
    Completed = 3,

    /// <summary>
    /// The workflow had its execution terminated.
    /// </summary>
    Terminated = 4,

    /// <summary>
    /// The workflow is awaiting for resume its execution.
    /// </summary>
    Awaiting = 5
}