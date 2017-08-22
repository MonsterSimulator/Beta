using ClassLibrary1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Fantastical_Deathmatch.UI
{
	public class Program
	{
		static void Main(string[] args)
		{
            Workflow work = new Workflow();

            work.NameSelection();
            work.CoinFlip();
            var c1 = work.SummonCreature();
            var c2 = work.SummonCreature();
            work.Battle(c1, c2);
		}
	}
}
