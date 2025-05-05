using System;

namespace AlgorithmLib
{

    /// <summary>
    /// Interface som definierar sökalgoritmerna och deras parametrar samt returvärden
    /// </summary>
    public interface ISearchingManager<T> where T : IComparable<T>
    {
        //Notera i parameterlistan att vi jobbar med generiska typen. Jämför med pseudokoden som istället tar emot argument enligt typerna: (IList<T> collection, T target);
        /// <summary>
        /// Söker sekventiellt i listan efter ett värde.
        /// </summary>
        /// <param name="collection">Listan att söka i.</param>
        /// <param name="target">Det värde som söks efter.</param>
        /// <returns>Index för det hittade värdet, eller -1 om det inte finns.</returns>
        int LinearSearch(IList<T> collection, T target);

        /// <summary>
        /// Utför binär sökning i en sorterad lista.
        /// </summary>
        /// <param name="sortedCollection">En sorterad lista.</param>
        /// <param name="target">Det värde som söks efter.</param>
        /// <returns>Index för det hittade värdet, eller -1 om det inte finns.</returns>
        int BinarySearch(IList<T> collection, T target);

        /// <summary>
        /// Använder exponential search för att hitta ett värde i en sorterad lista.
        /// </summary>
        /// <param name="sortedCollection">En sorterad lista.</param>
        /// <param name="target">Det värde som söks efter.</param>
        /// <returns>Index för det hittade värdet, eller -1 om det inte finns.</returns>
        int ExponentialSearch(IList<T> collection, T target);

        /// <summary>
        /// Utför interpolationssökning (endast för heltal).
        /// </summary>
        /// <param name="sortedCollection">En sorterad lista med heltal.</param>
        /// <param name="target">Det heltalsvärde som söks efter.</param>
        /// <returns>Index för det hittade värdet, eller -1 om det inte finns.</returns>
        int InterpolationSearch(IList<T> collection, T target);

        /// <summary>
        /// Utför Jump Search i en sorterad lista.
        /// </summary>
        /// <param name="sortedCollection">En sorterad lista.</param>
        /// <param name="target">Det värde som söks efter.</param>
        /// <returns>Index för det hittade värdet, eller -1 om det inte finns.</returns>
        int JumpSearch(IList<T> collection, T target);
    }
}
