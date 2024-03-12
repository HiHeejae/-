using System.Data.SqlTypes;
using System.Diagnostics.CodeAnalysis;

namespace 희재의_프로젝트
{
    class Giftbox
    {
        public string Letter;
        public int Money;
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Giftbox a = new Giftbox()
            {
                Letter = "잘 지내지?",
                Money = 100000
            };
            Giftbox 배송기사님 = a;

            a.Letter = "어떻게 지내고 있어?";
            a.Money = 150000;
        }
    }
}
