# FeInfo.Common

This is a NuGet Package to help manage DTOs, enums, &etc for a couple of my Free Enterprise related projectsFeInfo.Common [FreeEnterprise.Api](https://github.com/Antidale/FreeEntperprise.Api) and [Tellah's Library](https://github.com/Antidale/tellahs-library), as well as anyone who might be interested in building any app that might make use of the endpoints in `FreeEntperise.Api`.

Below is a summary of what you'll find in the project, and how each classification (e.g. folder) is intended to be used.

## DTOs
Classes and records contained in this folder, or generally in a namespace that ends in DTO or DTOs, are POCOs with some nod toward immutability. They exist purely as ways to transmit data from the Api.

## Enums
Not too much to say here, this is just where enums go. Currently, enums are just used inside of the other types here.

## Requests
Requests generally are objects that encapsulate a desire to change something in the database, and should start with a verb. The main deviation from that are SearchRequests, which are used when query string parameters aren't used. In any event, using these classes means that you're making a `Post`, `Patch`, or `Put`.

## Responses 
Responses are a specific type of DTO, and differ from items in `DTOs` in that they'll relate to a specific request, which means they are primarily the response to a change of data in the database.  

For instance, when someone sends in a request using the `Register` class in the body of a post, they'll get a `RegistrationResponse` back. These types of classes are used where the data returned is generally designed for a specific application's purpose and should have documenation comments that explain specific usage.

