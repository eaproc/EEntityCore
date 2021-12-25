using System;
using System.Diagnostics;

namespace EEntityCore.DB.MSSQL
{
    public partial class DBTransaction
    {
        public class QueryExecutionTimer:IDisposable
        {
            private bool IsStarted;
            private bool disposedValue;

            public string SQL { get; private set; }
            private Stopwatch Watch { get; }
            public long ElapsedMilliseconds { get; private set; }

            public QueryExecutionTimer(string sql, bool start = true)
            {
                this.SQL = sql;
                this.Watch = new Stopwatch();

                this.IsStarted = false;
                this.ElapsedMilliseconds = 0;

                // start if needed
                if (start) this.Start();
            }

            public QueryExecutionTimer Start()
            {
                if (this.IsStarted) throw new InvalidOperationException("Has already been started");

                this.Watch.Start();
                this.IsStarted = true;

                return this;
            }

            public QueryExecutionTimer Stop()
            {
                if (this.Watch.IsRunning)
                {
                    this.Watch.Stop();
                    this.ElapsedMilliseconds = Watch.ElapsedMilliseconds;
                }

                return this;
            }

            protected virtual void Dispose(bool disposing)
            {
                if (!disposedValue)
                {
                    if (disposing)
                    {
                        // TODO: dispose managed state (managed objects)
                        this.Stop();
                    }

                    // TODO: free unmanaged resources (unmanaged objects) and override finalizer
                    // TODO: set large fields to null
                    disposedValue = true;
                }
            }

            public void Dispose()
            {
                // Do not change this code. Put cleanup code in 'Dispose(bool disposing)' method
                Dispose(disposing: true);
                GC.SuppressFinalize(this);
            }
        }
    }
}
