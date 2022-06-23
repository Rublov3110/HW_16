using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_16
{
    public class MessageBox
    {
        private const int MAXVALUE = 2;
        private readonly Random _random;
        public MessageBox(Action<State> value)
        {
            WindowsClose = value;
            _random = new Random();
        }

        private event Action<State> WindowsClose;

        public async void Open()
        {
            State state = (State)_random.Next(MAXVALUE);
            Console.WriteLine("Open window!");
            await Task.Delay(3000);
            Console.WriteLine("Close user!");

            WindowsClose(state);
        }
    }
}
