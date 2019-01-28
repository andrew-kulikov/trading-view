# trading-view
TradingView graph integration using ASP.NET MVC

## Steps to install

1. Backup database (if exists). If database does not exist, you can fetch data from TickTrader API using TradingView.Importer application. To get symbols or bars just uncomment metods in Main method (need to provide credentials to TickTrader API). 
1. Run Web Api project.
1. Run frontend server in TradingView.Web folder - you can use ``npm`` or ``python`` or any other servers. For example: 
``python -m http.server 9090``

Possible faults: 
* Endless requests to history if screen is at the beginning of all bars (maybe tradingview.js library error).
