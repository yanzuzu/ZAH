using System;
using System.Collections.Generic;
using System.Collections;

namespace ZuEngine.StateManagement
{
	public class TaskManager : IUpdatable, IDestroyable
	{
		public delegate void OnStateChanged(long newState);

		public StateManager StateManager { get; private set; }
		public OnStateChanged StateChangedCallback { get; set; }
		public long CurrentState { get; private set; }


		private class TaskData
		{
			public Task Task;
			public long ActiveStates;
		}

		private List<TaskData> m_tasks;
		private int m_lastStateId = 0;



		public TaskManager(StateManager stateManager)
		{
			m_tasks = new List<TaskData>();
			StateManager = stateManager;
		}


		public long CreateState()
		{
			long result = 1 << m_lastStateId;
			m_lastStateId++;

			return result;
		}


		public long AllStates()
		{
			long result = 0;

			for(int i = 0; i <= m_lastStateId; i++)
			{
				result |= 1L << i;
			}

			return result;
		}


		public static bool ContainsState(long stateFlags, long stateId)
		{
			return (stateFlags & stateId) == stateId;
		}


		public void ChangeState(long stateId)
		{
			CurrentState = stateId;

			foreach(TaskData td in m_tasks.ToArray())
			{
				td.Task.Active = ContainsState(td.ActiveStates, stateId);
			}

			if(StateChangedCallback != null)
			{
				StateChangedCallback(stateId);
			}
		}


		public void AddTask(Task task, long activeStates)
		{
			TaskData td = new TaskData();
			td.Task = task;
			task.TaskManager = this;
			td.ActiveStates = activeStates;

			m_tasks.Add(td);
		}


		public T GetTask<T>() where T : Task
		{
			foreach(TaskData td in m_tasks.ToArray())
			{
				T result = td.Task as T;

				if(result != null)
				{
					return result;
				}
			}
			
			return null;
		}


		public void Update(float deltaTime)
		{
			foreach(TaskData td in m_tasks.ToArray())
			{
				if(td.Task.Active || td.Task.AlwaysUpdates)
				{
					td.Task.Update(deltaTime);
				}
			}
		}


		public void Destroy()
		{
			foreach(TaskData td in m_tasks.ToArray())
			{
				td.Task.TaskManager = null;
				td.Task.Destroy();
			}

			m_tasks.Clear();
			m_lastStateId = 0;
		}
	}
}

