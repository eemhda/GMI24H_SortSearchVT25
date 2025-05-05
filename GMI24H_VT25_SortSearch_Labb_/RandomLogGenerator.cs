using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GMI24H_VT25_SortSearch_Labb_
{
    /// <summary>
    /// En implementation av ILogGenerator som genererar loggposter
    /// med hjälp av slumpmässiga värden men med en förutsägbar sekvens via seed.
    /// </summary>
    public class RandomLogGenerator : ILogGenerator
    {
        /// <summary>
        /// Genererar en angiven mängd loggposter med hjälp av slump, men återupprepningsbart med en seed.
        /// </summary>
        /// <param name="count">Hur många loggposter som ska skapas.</param>
        /// <param name="seed">Ett heltal som styr den slumpmässiga sekvensen (för reproducerbarhet).</param>
        /// <returns>En IEnumerable med LogEntry-objekt.</returns>
        public IEnumerable<LogEntry> GenerateLogs(int count, int seed)
        {
            var rand = new Random(seed);
            var startTime = new DateTime(2025, 5, 1, 8, 0, 0);

            string[] ipAddresses = { "192.168.1.10", "10.0.0.5", "127.0.0.1" };
            string[] methods = { "GET", "POST", "PUT" };
            string[] paths = { "/", "/login", "/api" };
            int[] statusCodes = { 200, 401, 500 };

            for (int i = 0; i < count; i++)
            {
                yield return new LogEntry
                {
                    Timestamp = startTime.AddSeconds(rand.Next(0, 86400)),
                    IpAddress = ipAddresses[rand.Next(ipAddresses.Length)],
                    Method = methods[rand.Next(methods.Length)],
                    Path = paths[rand.Next(paths.Length)],
                    StatusCode = statusCodes[rand.Next(statusCodes.Length)]
                };
            }
        }
    }
}
