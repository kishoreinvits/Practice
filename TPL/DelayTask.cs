using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPL
{
    internal class Work
    {
        internal static async Task DelayTask(int seconds)
        {
            await Task.Factory.StartNew(() =>
            {
                Task.Delay(seconds);
            });
        }
    }
}
