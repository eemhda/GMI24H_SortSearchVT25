namespace GMI24H_VT25_SortSearch_Labb_
{
    /// <summary>
    /// Interface för logggeneratorer som kan skapa en samling av genererade loggposter.
    /// </summary>
    public interface ILogGenerator
    {
        /// <summary>
        /// Genererar ett givet antal loggposter baserat på en slumpmässig seed.
        /// </summary>
        /// <param name="count">Antal loggposter som ska genereras.</param>
        /// <param name="seed">En heltals-seed för att skapa deterministisk slumpmässighet.</param>
        /// <returns>En sekvens av genererade LogEntry-objekt.</returns>
        IEnumerable<LogEntry> GenerateLogs(int count, int seed);
    }
}
