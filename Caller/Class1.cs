using System;

namespace Caller
{
    class Class1
    {
        public void DoSomething()
        {
            Util.CallMeBack();
        }

        public void Callback()
        {
            Console.WriteLine("Nice to hear from you.");
        }
    }
}
