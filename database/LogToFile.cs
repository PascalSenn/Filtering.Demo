using System.IO;
using Microsoft.EntityFrameworkCore.Diagnostics;

namespace Filtering.Demo
{
    public static class LogToFile
    {
        /// change this path to show queries you execute life!
        public static string? FILE_TO_LOG = null;
        public static void Log(EventData e)
        {
            if (e is CommandExecutedEventData eventData && FILE_TO_LOG is not null)
            {
                File.WriteAllText( FILE_TO_LOG, eventData.Command.CommandText);
            }
        }
    }
}