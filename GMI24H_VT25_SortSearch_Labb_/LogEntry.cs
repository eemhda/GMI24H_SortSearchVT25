using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GMI24H_VT25_SortSearch_Labb_
{
    /// <summary>
    /// Representerar en enskild rad i en loggfil med information om en HTTP-förfrågan.
    /// </summary>
    public class LogEntry
    {
        public DateTime Timestamp { get; set; }
        public string IpAddress { get; set; }
        public string Method { get; set; }
        public string Path { get; set; }
        public int StatusCode { get; set; }

        public override string ToString()
        {
            return $"{Timestamp} {IpAddress} {Method} {Path} {StatusCode}";
        }
    }
}
