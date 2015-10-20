using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GarbageCollectionDemo
{
    class Calculator : IDisposable
    {
        private bool disposed = false;

        public int Divide(int first, int second)
        {
            return first / second;
        }

        public Calculator()
        {
            Console.WriteLine("Calculator being created.");
        }

        // Destructor outputs so we can see the Calculator object die.
        ~Calculator()
        {
            Console.WriteLine("Calculator being finalized.");
            this.Dispose();
        }

        // IDisposable interface method. Normally it'd releasee the resources held by the object.
        // That's not done here, the only purpose of this method is to see the Dispose method being run.
        public void Dispose()
        {
            if (!this.disposed)
            {
                Console.WriteLine("Calculator being disposed");
            }

            this.disposed = true;
            GC.SuppressFinalize(this);
        }
    }
}
