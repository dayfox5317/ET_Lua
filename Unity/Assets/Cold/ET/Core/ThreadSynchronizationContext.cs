﻿using System;
using System.Collections.Concurrent;
using System.Threading;
using ET;
using UnityEngine;

#if NOT_UNITY
namespace ET
#else
namespace ETCold
#endif
{
    public class ThreadSynchronizationContext : SynchronizationContext
    {
        public static ThreadSynchronizationContext Instance { get; } = new ThreadSynchronizationContext(Thread.CurrentThread.ManagedThreadId);

        private readonly int threadId;

        // 线程同步队列,发送接收socket回调都放到该队列,由poll线程统一执行
        private readonly ConcurrentQueue<Action> queue = new ConcurrentQueue<Action>();

        private Action a;

        public ThreadSynchronizationContext(int threadId)
        {
            this.threadId = threadId;
        }

        public void Update()
        {
            while (true)
            {
                if (!this.queue.TryDequeue(out a))
                {
                    return;
                }

                try
                {
                    a();
                }
                catch (Exception e)
                {
#if NOT_UNITY
                    Log.Error(e);
                    #else
                    Debug.LogError(e);
                    #endif
                }
            }
        }

        public override void Post(SendOrPostCallback callback, object state)
        {
            this.Post(() => callback(state));
        }
		
        public void Post(Action action)
        {
            if (Thread.CurrentThread.ManagedThreadId == this.threadId)
            {
                try
                {
                    action();
                }
                catch (Exception ex)
                {
                    #if NOT_UNITY
                     Log.Error(ex);
                    #else
                    Debug.LogError(ex);
                    #endif
                }

                return;
            }

            this.queue.Enqueue(action);
        }
		
        public void PostNext(Action action)
        {
            this.queue.Enqueue(action);
        }
    }
}