using Microsoft.Azure.WebJobs.Host;

namespace MsftPlayground.Function {
    public class LoggingFunction
    {
        public static void Run(string input, TraceWriter log) {
            log.Info($"Manually triggered PRECOMPILED functions, looks COOL: {input}");
        }
    }
}
