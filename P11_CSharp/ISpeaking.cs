using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P11_CSharp
{
    internal interface ISpeaking
    {
        List<string> Lengauge { get; }

        void Speak(string language);

        
    }
}
