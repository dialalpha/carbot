using System;

namespace Carbot.Common
{
    public interface ILogger
    {
        void LogTrace(string format, params string[] args);
        void LogDebug(string format, params string[] args);
        void LogInfo(string format, params string[] args);
        void LogWarn(string format, params string[] args);
        void LogError(string format, params string[] args);
        void LogFatal(string format, params string[] args);
        void LogException(Exception ex);
    }
}
