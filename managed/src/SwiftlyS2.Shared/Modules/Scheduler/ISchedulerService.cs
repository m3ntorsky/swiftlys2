namespace SwiftlyS2.Shared.Scheduler;

public interface ISchedulerService {

  /// <summary>
  /// Add a task to be executed on the next tick.
  /// </summary>
  /// <param name="task">The task to execute.</param>
  void NextTick(Action task);

  /// <summary>
  /// Add a delayed task to the scheduler.
  /// </summary>
  /// <param name="delayTick">The delay of the timer in ticks.</param>
  /// <param name="task">The task to execute.</param>
  /// <returns>A CancellationTokenSource that can be used to cancel the timer.</returns>
  CancellationTokenSource Delay(int delayTick, Action task);

  /// <summary>
  /// Add a repeated task to the scheduler.
  /// This will be executed once immediately, and then every periodTick ticks.
  /// </summary>
  /// <param name="periodTick">The period of the timer in ticks.</param>
  /// <param name="task">The task to execute.</param>
  /// <returns>A CancellationTokenSource that can be used to cancel the timer.</returns>
  CancellationTokenSource Repeat(int periodTick, Action task);

  /// <summary>
  /// Add a delayed and repeated task to the scheduler.
  /// </summary>
  /// <param name="delayTick">The delay of the timer in ticks.</param>
  /// <param name="periodTick">The period of the timer in ticks.</param>
  /// <param name="task">The task to execute.</param>
  /// <returns>A CancellationTokenSource that can be used to cancel the timer.</returns>
  CancellationTokenSource DelayAndRepeat(int delayTick, int periodTick, Action task);


  /// <summary>
  /// Add a delayed task to the scheduler.
  /// 
  /// The timing is based on game tick, which means it becomes inaccurate for intervals approach 1 tick (approximately 15ms).
  /// </summary>
  /// <param name="delaySeconds">The delay of the timer in seconds.</param>
  /// <param name="task">The task to execute.</param>
  /// <returns>A CancellationTokenSource that can be used to cancel the timer.</returns>
  CancellationTokenSource DelayBySeconds(float delaySeconds, Action task);

  /// <summary>
  /// Add a repeated task to the scheduler.
  /// This will be executed once immediately, and then every periodSeconds seconds.
  /// 
  /// The timing is based on game tick, which means it becomes inaccurate for intervals approach 1 tick (approximately 15ms).
  /// </summary>
  /// <param name="periodSeconds">The period of the timer in seconds.</param>
  /// <param name="task">The task to execute.</param>
  /// <returns>A CancellationTokenSource that can be used to cancel the timer.</returns>
  CancellationTokenSource RepeatBySeconds(float periodSeconds, Action task);

  /// <summary>
  /// Add a delayed and repeated task to the scheduler.
  /// 
  /// The timing is based on game tick, which means it becomes inaccurate for intervals approach 1 tick (approximately 15ms).
  /// </summary>
  /// <param name="delaySeconds">The delay of the timer in seconds.</param>
  /// <param name="periodSeconds">The period of the timer in seconds.</param>
  /// <param name="task">The task to execute.</param>
  /// <returns>A CancellationTokenSource that can be used to cancel the timer.</returns>
  CancellationTokenSource DelayAndRepeatBySeconds(float delaySeconds, float periodSeconds, Action task);

  /// <summary>
  /// Stop a timer when the map changes.
  /// </summary>
  /// <param name="cts">The CancellationTokenSource to stop.</param>
  void StopOnMapChange(CancellationTokenSource cts);
}