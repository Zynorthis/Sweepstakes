# Sweepstakes

A proof of concept console application in which users can create and run sweepstakes for a marketing firm.

## Classes & Functionality

In this project, the MarketingFirm class holds a sweepstake manager of type ISweepStakesManager. There are two classes that inherit from this interface and can be used as the sweepstake manager. This is a prime example of dependancy injection. The functionality of how the sweepstakes are being managed is entirely dependant on which class is passed in through the constructor of the MarketingFirm class. 

The Sweepstakes class handles entering and retrieving contestant information, along with picking a random winner, and sending emails to all contestants regarding who did and didn't win. The contestant model holds information about a given contestant along with that person's given registration number.

The GUI class is a static class with methods designed to display various options and information to a given user.
