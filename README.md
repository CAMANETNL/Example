# Example code for Infoplaza

--------------------------------------
Create Migration: dotnet ef migrations add InitConfigration -c AppDbContext  -p .\Example\
Create database: dotnet ef database update -p .\Example\

--------------------------------------

For this proof of concept I took these projects as an example:
- https://github.com/kgrzybek/sample-dotnet-core-cqrs-api
- https://github.com/dotnet-architecture/eShopOnWeb

--------------------------------------
TODOs:
- Add Exception Handling
- Add Validation
- Implement CQRS + MediatR

-------------------------------------

Description:

In this proof of concept I have tried to make a bare bone structure for the following:
An agency provides developers to companies that need extra developers for a finite period of time. 
A system is needed to keep track of all arrangements made so the right amount of money is paid for and to the right company.

--------------------------------------

Some requirements: 
- Buy and Sell contracts will have different content.
- As a company I should never get to see a deal.
- As the agency, I am interested in seeing info per deal
- As an agency I can easily keep track of (un)signed contracts
--------------------------------------

Definitions:
- Each developer is considered an entrepreneur thus a company.
- A contract is a signed agreement between the agent and a company, and its most important member is - not surprisingly - its price.
- A deal contains two contracts: one where the agency sell's the developer, and one where the agency buys the developer.
--------------------------------------

Example:

Company B requests 3 developers with the agency (there is always just this agency) for an hourly rate of $95,-
The agency finds 3 developers willing to take the job: Piet, Karel and Eva.

Piet agrees to work for an hourly fee of $55,-
Karel agrees to work for an hourly fee of $42,-
Eva agrees to work for an hourly fee of $65,-

This should result in:
Companies: 
- B
- Piet
- Karel
- Eva

Contracts:
- Buy from agency: Company B, rate $95 p/h
- Sell to agency: Piet, rate $55 p/h
- Sell to agency: Karel: $45 p/h
- Sell to agency: Eva: $65 p/h

Deals:
- Buy: Company B, rate $95 p/h and Sell: Piet, rate $55 p/h
- Buy: Company B, rate $95 p/h and Sell: Karel: $45 p/h
- Buy: Company B, rate $95 p/h and Sell: Eva: $6 p/h
