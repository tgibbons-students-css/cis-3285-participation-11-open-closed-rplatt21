using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace AbstractTrader
{
    public interface IProcessTrades
    {
        void ProcessTrades(Stream stream);
        //IEnumerable<string> ReadTradeData(Stream stream);

        //IEnumerable<TradeRecord> ParseTrades(IEnumerable<string> tradeData);

       // void StoreTrades(IEnumerable<TradeRecord> trades);



    }
}
