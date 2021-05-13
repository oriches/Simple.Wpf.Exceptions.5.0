using System;
using System.Globalization;
using System.Reactive.Disposables;
using NLog;
using Stopwatch = System.Diagnostics.Stopwatch;

namespace Simple.Wpf.Exceptions
{
    public sealed class Duration : IDisposable
    {
        private readonly string _context;
        private readonly Logger _logger;
        private readonly Stopwatch _stopWatch;

        private Duration(Logger logger, string context)
        {
            _context = context;
            _stopWatch = new Stopwatch();
            _logger = logger;

            _stopWatch.Start();
        }

        public void Dispose()
        {
            _stopWatch.Stop();

            _logger.Debug(CultureInfo.InvariantCulture, "{0}, duration = {1} ms", _context,
                _stopWatch.ElapsedMilliseconds);
        }

        public static IDisposable Measure(Logger logger, string context, params object[] args)
        {
            if (!logger.IsDebugEnabled) return Disposable.Empty;

            if (args != null) context = string.Format(CultureInfo.InvariantCulture, context, args);

            return new Duration(logger, context);
        }
    }
}