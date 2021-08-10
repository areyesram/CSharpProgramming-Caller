using System;

namespace Caller
{
    class Class2
    {
        internal void DoSomethingElse()
        {
            Util.CallMeBack();
        }

        public void Callback()
        {
            Console.WriteLine("Long time no see.");
        }
    }
}
