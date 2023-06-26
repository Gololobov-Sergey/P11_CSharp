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


    public interface IIndex
    {
        string this[string index] { set; get; }
    }


    interface IA
    {
        int A1(int a);
    }


    interface IB
    {
        void B1();

        string B2(string b);
    }

    interface IC : IA, IB
    {
        void C1();
    }


    class Inter : IC
    {
        public int A1(int a)
        {
            throw new NotImplementedException();
        }

        public void B1()
        {
            throw new NotImplementedException();
        }

        public string B2(string b)
        {
            throw new NotImplementedException();
        }

        public void C1()
        {
            throw new NotImplementedException();
        }
    }



    interface IAA
    {
        void Show();
    }

    interface IBB
    {
        void Show();
    }

    interface ICC
    {
        void Show();
    }

    class ShowData : IAA, IBB, ICC
    {
        public void Show()
        {
            Console.WriteLine("Interface C");
        }
        void IAA.Show()
        {
            Console.WriteLine("Interface A");
        }

        void IBB.Show()
        {
            Console.WriteLine("Interface B");
        }
    }

}
