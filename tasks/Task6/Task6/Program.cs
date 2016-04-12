using System;
using System.Reactive.Linq;
using System.Threading;


namespace Task6
{
    public class DataType
    {
        public DataType(string param, int threadId)
        {
            this.Param = param;
            _threadId = threadId;
        }

        public string Param { get; set; }
        private readonly int _threadId;
        public int ThreadId
        {
            get { return _threadId; }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            ParallelExecutionTest();
        }

        public static async void ParallelExecutionTest()
        {
            var o = Observable.CombineLatest(
             LongRunningOperationAsync("A"),
             LongRunningOperationAsync("B"),
              LongRunningOperationAsync("C")
            ).Finally(() => Console.WriteLine("Done!"));

            foreach (var r in await o.FirstAsync())
                Console.WriteLine($"my {r.Param} Thread has the id {r.ThreadId}");
        }

        public static DataType DoLongRunningOperation(string param)
        {
            Console.WriteLine($"i'am in the {param} Method");
            return new DataType(param, Thread.CurrentThread.ManagedThreadId);
        }

        public static IObservable<DataType> LongRunningOperationAsync(string param)
        {
            return Observable.Create<DataType>(
                o => Observable.ToAsync<string, DataType>(DoLongRunningOperation)(param).Subscribe(o)
            );
        }
    }
}
