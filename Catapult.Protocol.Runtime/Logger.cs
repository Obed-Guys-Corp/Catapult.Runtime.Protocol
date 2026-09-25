using System.Text.Json;

namespace Catapult.Protocol.Runtime
{
    public static class Logger
    {
        public enum LogLevel
        {
            Info,
            Warn,
            Error,
            Exception,
            Debug,
        }

        readonly static JsonSerializerOptions _serializerOptions = new()
        {
            WriteIndented = true,
        };

        readonly static HashSet<LogLevel> _allowedLevels = [.. Enum.GetValues<LogLevel>()];
        public static bool AddLogLevel(LogLevel lvl)
        {
            if (_allowedLevels.Contains(lvl)) return false;
            _allowedLevels.Add(lvl);
            return true;
        }

        public static bool RemoveLogLevel(LogLevel lvl) => _allowedLevels.Remove(lvl);

        public static void LogLine(LogLevel lvl, object message) => LogLine(lvl, null!, message);
        public static void LogLineInfo(Type from, object message) => LogLine(LogLevel.Info, from, message);
        public static void LogLineInfo(object message) => LogLine(LogLevel.Info, null!, message);
        public static void LogLineWarn(Type from, object message) => LogLine(LogLevel.Warn, from, message);
        public static void LogLineWarn(object message) => LogLine(LogLevel.Warn, null!, message);
        public static void LogLineError(Type from, object message) => LogLine(LogLevel.Error, from, message);
        public static void LogLineError(object message) => LogLine(LogLevel.Error, null!, message);
        public static void LogLineException(Type from, object message) => LogLine(LogLevel.Exception, from, message);
        public static void LogLineException(object message) => LogLine(LogLevel.Exception, null!, message);
        public static void LogLineDebug(Type from, object message) => LogLine(LogLevel.Debug, from, message);
        public static void LogLineDebug(object message) => LogLine(LogLevel.Debug, null!, message);
        public static void LogLine(LogLevel lvl = LogLevel.Info, Type from = null!, object message = null!)
        {
            if (!_allowedLevels.Contains(lvl)) return;

            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.Write($"[{DateTime.Now}]");
            Console.ForegroundColor = ConsoleColor.Gray;

            var l = lvl.ToString().ToUpper();
            var c = GetColor(lvl);

            if (from == null)
            {
                Console.Write($" [");
                Console.ForegroundColor = c;
                Console.Write($"{l}");
                Console.ForegroundColor = ConsoleColor.Gray;
                Console.Write($"] ");
            }
            else
            {
                Console.Write($" [");
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write($"{from.Name}");
                Console.ForegroundColor = ConsoleColor.Gray;
                Console.Write(" - ");
                Console.ForegroundColor = c;
                Console.Write($"{l}");
                Console.ForegroundColor = ConsoleColor.Gray;
                Console.Write($"] ");
            }

            Console.Write($"{message}\n");
        }

        public static void LogLineException(Type from, Exception ex)
        {
            if (!_allowedLevels.Contains(LogLevel.Exception)) return;

            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.Write($"[{DateTime.Now}]");
            Console.ForegroundColor = ConsoleColor.Gray;

            var c = GetColor(LogLevel.Exception);

            Console.Write($" [");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write($"{from.Name}");
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.Write(" - ");
            Console.ForegroundColor = c;
            Console.Write($"{LogLevel.Exception}");
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.Write($"] ");
            Console.ForegroundColor = ConsoleColor.White;

            Console.Write($"\n\n=== START EXCEPTION ===\n\n");
            Console.ForegroundColor = ConsoleColor.Gray;

            Console.Write(ex);

            Console.ForegroundColor = ConsoleColor.White;
            Console.Write($"\n\n=== END EXCEPTION ===\n\n");

            Console.ForegroundColor = ConsoleColor.Gray;
        }

        public static string FormatJson(string json)
        {
            if (json == null || string.IsNullOrWhiteSpace(json)) return string.Empty;

            try { return JsonSerializer.Serialize(JsonDocument.Parse(json), _serializerOptions); }
            catch { return json; }
        }

        static ConsoleColor GetColor(LogLevel l)
        {
            return l switch
            {
                LogLevel.Info => ConsoleColor.Cyan,
                LogLevel.Warn => ConsoleColor.Yellow,
                LogLevel.Error => ConsoleColor.Red,
                LogLevel.Exception => ConsoleColor.DarkRed,
                LogLevel.Debug => ConsoleColor.Magenta,
                _ => ConsoleColor.White,
            };
        }
    }
}
