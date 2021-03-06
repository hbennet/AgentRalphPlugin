using System;

namespace AgentRalph.CloneCandidateDetectionTestData
{
    public class CloneInIfBlock
    {
        // Also tests that a method body w/ a single child still recurses.
        private void Foo()
        {
            if (DateTime.Now.Day == 3)
            {
                /* BEGIN */
                Console.WriteLine(7);
                /* END */
            }
        }

        private void Bar()
        {
            Console.WriteLine(7);
        }
    }
}