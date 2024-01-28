using System.Collections;

namespace Simulator
{
    class Simulator : IEnumerable
    {
        string[] moves = { "5", "3", "1", "6", "7" };

        public IEnumerator GetEnumerator()
        {
            foreach (string element in moves)
                yield return element;
        }
    }

}