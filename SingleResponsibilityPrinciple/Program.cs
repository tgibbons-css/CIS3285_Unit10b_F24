using System;
using System.Reflection;

using SingleResponsibilityPrinciple.AdoNet;

namespace SingleResponsibilityPrinciple
{
    class Program
    {
        static void Main(string[] args)
        {
            var logger = new ConsoleLogger();
            String fileName = "SingleResponsibilityPrinciple.trades.txt";
            var tradeStream = Assembly.GetExecutingAssembly().GetManifestResourceStream(fileName);
            if (tradeStream == null)
            {
                logger.LogWarning("trade file could not be openned at " + fileName);
                Environment.Exit(1); // Exits the application with a non-zero exit code indicating an error
            }

            var tradeValidator = new SimpleTradeValidator(logger);
            var tradeDataProvider = new StreamTradeDataProvider(tradeStream);
            var tradeMapper = new SimpleTradeMapper();
            var tradeParser = new SimpleTradeParser(tradeValidator, tradeMapper);
            var tradeStorage = new AdoNetTradeStorage(logger);

            var tradeProcessor = new TradeProcessor(tradeDataProvider, tradeParser, tradeStorage);
            tradeProcessor.ProcessTrades();

            Console.ReadKey();
        }
    }
}
