# HearthDb

HearthDb is a .NET Hearthstone database.

## Cards
`HearthDb.Cards` contains all card information of the `CardDefs.xml`, taken from the [hs-data HearthSim project](https://github.com/HearthSim/hs-data).

See [here](https://github.com/Epix37/HearthDb/blob/master/HearthDb.Tests/UnitTest1.cs#L14-L25) for example usage.

## CardIDs
`HearthDb.CardIds` contains properly named constant for all cardIds existing in Hearthstone. 

The cardIds file was generated by `HearthDb.CardIdLibGenerator`. 

See [here](https://github.com/Epix37/HearthDb/blob/master/HearthDb.Tests/UnitTest1.cs#L28-L34) for example usage.

## Building HearthDb
* Run `HearthDb/bootstrap.bat`
* Build project

_Alternaitvely: manually download [HearthSim/hs-data/CardDefs.xml](https://github.com/HearthSim/hs-data/blob/master/CardDefs.xml) to `HearthDb/HearthDb` before building._
