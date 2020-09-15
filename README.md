# Oeuvre

**The Theater Of Evolutionary Architecture**

### Oeuvre
/ˈəːvr(ə)/

**Pronounced as:**  *uh·vruh* | **noun:** oeuvre; **plural noun**: oeuvres

**Meaning:** The body of work of a painter, composer, or author. A work of art, music, or literature.

## A Note

This project is in design and analysis phase. Please feel free to go through the code and if you have any Questions or Suggestions, you can use the [Issues](https://github.com/codefinity/oeuvre/issues) tab. 

## News

- Migration from Postgres to Sql Server in progress on branch evolution-one-migration-sqlserver. Merged to branch evolution-one.
- Integration Tests Written.
- IdentityAccess Module appears to be stable.
- Documenting the process.

## Table of Contents

[TOC might not work - Sections under constant re-arrangement]

[1. Introducing Oeuvre](#Introducing-Oeuvre)

[2. Setup Instructions](#Setup-Instructions)

[3. A Need for a Project Like Oeuvre](#A-Need-for-a-Project-Like-Oeuvre)

[4. Development Methodologies](#Development-Methodologies)

[5. Testing and Code Coverage](#Testing-and-Code-Coverage)

[6. Requirement Discussion](#Requirement-Discussion)

[8. Technology Stack](#Technology-Stack)

[9. Requirement Analysis](#Requirement-Analysis)

[10. Features](#Features)

[11. Analysis and Design](#Analysis-and-Design)

[12. Test Driven Design Methodology](#Test-Driven-Design-Methodology)

[13. Inspiration](#Inspiration)

[14. Issue Resolutions and Workarounds](#Issue-Resolutions-and-Workarounds)

## Introducing Oeuvre

Oeuvre is a social article publishing portal that enables users to write and publish and share their articles. 
At some level Oeuvre is an Experimental Test-Bed for Evolutionary Architecture. This project will show how quickly and efficiently DDD aligns to the changes in business.

The technology stack used is .Net, but the concept can be applied to all the programming language that supports OOPS.

## Setup Instructions

SetUp instructions for this project can be found [here](SETUP.md).

## A Need for a Project Like Oeuvre

**Oeuvre is not a demonstration, it is Software Evolution in motion.**

It is a well known fact, often inconvenient, that in the long run the many of the projects become unmaintainable. New requirements come in, new capabilities are demanded due to changes in the market, the technology landscape becomes better, and the softwares is expected to accommodate these things without software rewrites.

Oeuvre is a quest to find answers to whether the software can be constructed in such a way that it evolves with new requirements over time.

## How Real World Evolution Works

There is no intentional design in the real world evolution. Organized compexities are built out of primeval simplicity. Structure and the functions of system emerge bit by bit without resort to a goal of any kind. The process is mindless. 

In this playground of evolution, the force that induces the design is our environment. The species design themselves through random mutations to increase their chances for survival. Random mutations that favor the survival of species in that environment get propogated to the next generation, continuouing the same process again.

Environmental changes also affect.

The change happens at a single level, that is the genetic level and then manifests itself into the physical features of the species. The Genetic Code determines the external features of the species.

It is through these trial and errors, eligant designs emerge.


![](design/images/ExplanationDiagrams-RealWorldEvolution.png)


## How To Make Principles Of Evolution Work for Architecture

#### Lessons worth learning from real world evolution

> The Galls Law states that, “A complex system that works is invariably found to have evolved from a simple system that worked. The inverse proposition also appears to be true: A complex system designed from scratch never works and cannot be made to work. You have to start over, beginning with a working simple system.”

1. Iteration cannot be avoided to arrive at the design

It's difficult to to arrive at a optimal design without indulging in a bit or trial on error. It's cheaper to do trial and errors on the drawing board first before inplementing them. Afer implementing, some iterations will be required.

2. Business logic is the genetic code and should be at the core




3. Requirements are the environment.

4. Paradoxes will always be there

- Framework must allow for experimentation

- Incremental Design is the way

- The change must happen at one fundemental level and then transform the outer layers.

- Designs tend towards perfection but can still not be perfect.

- There needs to be a Unit of Evolution

- Environmental changes influnce design

- Real world entities do not have a persistance database. The Entity itself is information, hence persistance design should be a side effect of the application design.

> Software architectures aren’t created in a vacuum—they always reflect the ecosystem in which they were defined.

> Building software systems that evolve means controlling as many unknown factors as possible.

> Don’t build architecture for the sake of architecture—you are trying to solve a problem.

> ~ Building Evolutionary Architectures, Neal Ford, Rebecca Parsons, Patrick Kua









#### Requirement is the King

> "... the craft of software architecture manifests in the ability of architects to analyze business and domain requirementsalong with other important factors to find a solution that balances all concerns optimally." 

> ~ Building Evolutionary Architectures, Neal Ford, Rebecca Parsons, Patrick Kua

Key to a good architecture is getting requirements right. Requirement is where everything starts from.

Software must be modelled around business not technology or layers.


#### Single Responsibility Principle

This is the backbone of every elegant design.

#### Importance of Boundaries

https://medium.com/swlh/all-you-might-really-need-is-a-monolith-disguised-as-microservices-4b099da3fa8f


#### Fitness Function

>"A fitness function is an objective function used to summarize how close a prospective design solution is to achieving the set aims. In evolutionary computing, the fitness function determines whether an algorithm has improved over time. In other words, as each variant of an algorithm is generated, the fitness functions determine how “fit” each variant is based on how the designer of the algorithm defined “fit.”"

>"We have a similar goal in evolutionary architecture—as architecture evolves, we need mechanisms to evaluate how changes impact the important characteristics of the architecture and prevent degradation of those characteristics over time. The fitness function metaphor encompasses a variety of mechanisms we employ to ensure architecture doesn’t change in undesirable ways, including metrics, tests, and other verifi cation tools. When an architect identifies an architectural characteristic they want to protect as things evolve, they define one or more fitness functions to protect that feature."

>"The fitness function drives architectural decision making, guiding the architecture while allowing the changes needed to support changing business and technology environments."

> ~ Building Evolutionary Architectures, Neal Ford, Rebecca Parsons, Patrick Kua

Fitness function is a term borowed from Genetic Algorithm Design. In a Genetic Algorithm small incremental changes are done to the software and after every generational change the output is assessed to see how close it is to the exact solution. This assessment is done by a function called the fitness function.

The architecture should ge guided by fitness functions. It also helps us take informed decisions during tradeofs.

Fitness functions must be identified as early as possible to help the solution evolve.

Fitness functions need to be constantly reviewed



> Without guidance, evolutionary architecture becomes simply a reactionary architecture. Thus, a crucial early architectural decision for any system is to define important dimensions such as scalability, performance, security, data schemas, and so on. Conceptually, this allows architects to weigh the importance of a fitness function based on its importance to the system’s overall behavior.

> ~ Building Evolutionary Architectures, Neal Ford, Rebecca Parsons, Patrick Kua


#### Guided Evolution

> An evolutionary architecture supports guided, incremental change across multiple dimensions.

> ~ Building Evolutionary Architectures, Neal Ford, Rebecca Parsons, Patrick Kua


Real world evolution is a random process. We will be implementing guided evolution through trial and error.



Whenever a fitness finction changes, our architectute is guided to evolve to a level where it passes the fitness function. In DDD its generaly the changes in the Domain Layer.

![](design/images/ExplanationDiagrams-EAProcess.png)



#### Dimentions of Evolution

<!--pg10-->

#### Evolutionary Over Adaptation

<!--pg14-->

Evolutionary change is permanent and from within, on the other hand Adaptatation is force fitting a solution to a problem. There can be limits to adaptation. There might come come a time when the system is just not able to adapt to change, whereas the evolution changes the system from inside out.




#### The Architectral Quanta


> "Many business concepts semantically bind parts of the system together, creating functional cohesion. To successfully evolve software, developers must consider all the coupling points that could break." 

> "As defined in physics, the quantum is the minimum amount of any physical entity involved in an interaction. An architectural quantum is an independently deployable component with high functional cohesion, which includes all the structural elements required for the system to function properly. In a monolithic architecture, the quantum is the entire application; everything is highly coupled and therefore developers must deploy it en mass."

> Quantum size determines the lower bound of the incremental change possible within an architecture.

> The quantum size of an architecture largely determines how easy it will be for developers to make evolutionary changes. Large quanta like monoliths and ESB SOA are difficult to evolve because of the coordination required for each change. More decoupled architectures like broker event-driven and microservices offer many more avenues for easy evolution.
> The structural constraints on evolving architecture depend on how well developers have handled coupling and functional cohesion. Evolution is easier if developers have created a modular component system with well-defined integration points. For example, if developers build a monolith, but are diligent about good modularity and component isolation, that architecture will offer more opportunities to evolve because the size of the architectural quantum is smaller due to decoupling.

> ~ Building Evolutionary Architectures, Neal Ford, Rebecca Parsons, Patrick Kua


Designing optimal AQ enables faster evolution cycles.

[Diagram to apply evolution to code - Gherkin - Fitness Function - Domain Change - Test]


### Reasons For Selection of Domain Driven Design(DDD) Architecture 

#### Why Classical N-Layered Architecture Fails to Evolve?

<!-- pg69 -->


#### Why is Domain Driven Design(DDD) The Best Approach For Evolutionary Architecture?

> "DDD is not about structuring data in a normalized fashion. It is about modelling the Ubiquitous Language in a consistent Bounded Context" 
> ~ Vaughn Vernon, IDDD


- Every change hits the domain first and forces the things to change from inside out. Evoles rather than adapts.
- Design is not DB Design Driven. Sets you free from thinking about Application Design from a Database perspective.
- Encourages Modularity
- Optimal Architectural Quanta
- Business Logic can be tested without dependencies.
- Database creation is the side effect of the design.


### Evolution In Action

#### Fitness Functions Used

##### Arch Unit


##### BDD


##### Integration Tests


#### Quantas Used In This Architecture

##### Command


##### Query


##### Domain Events


##### Aggregates


##### Modules/Bonded Contexts - Deployment Quantas



## Development Methodologies

#### Architecture Decision Logs

[Michael Nygard's template](https://cognitect.com/blog/2011/11/15/documenting-architecture-decisions) will be used to record Architectural Decisions. The logs can be found in this [folder](design/architecture-decision-logs). 

#### Event Storming


#### Behaviour Driven Development


#### Test Driven Development


#### Modular Monolith


#### Domain Driven Design


#### Command Query Responsibility Segregation (CQRS)


#### Event Driven Architecture


#### The Reactive Manifesto


#### Continuous Integration and Deployment (CI/CD)


#### Code Coverage

## Development Process

## Requirement Discussion

### Functional Requirements




### Non-Functional Expectations

- Should be scalable to microservices.
- OS Independent.
- Self Healing - able to bounce back from crashes on its own.


### How Does The Architecture Address Non-Functional Expectations




## Technology Stack

#### Discussion


#### Expectation


#### Selection


## Requirement Analysis and Design


### Event Stroming Boards


#### Big Picture Event-Storming 

![](design/EventStorming-IdentityAccess-BigPictureEventStorming.png)

#### Design Level  Event-Storming 

![](design/EventStorming-IdentityAccess-DesignLevelEventStorming.png)


#### Boundary Analysis

## Bounded Context Design (Modules)

### Identity Access - Module

#### Process Discovery

![](design/EventStorming-IdentityAccess-ProcessMapping.png)

#### Ubiquitous Language Discovery

![](design/EventStorming-IdentityAcess-UbiquitousLanguageDiscovery.png)



```text
Registrant : 		One who has just registred to Oeuvre Portal through registration page, 
			but will not qualify as a user unless they verify their EMail through 
			the link sent in his EMail.

User : 			One who has registered and verified his EMail.

EMail Verification :

Profile :

Settings :

```


#### Example Mapping

![](design/EventStorming-IdentityAccess-ExampleMapping.png)

#### Arranged Design Level  Event-Storming 

![](design/EventStorming-IdentityAccess-DesignLevelEventStorming-Arranged.png)


### Content Creation


##### Miro - Section to be removed later

- [Big Picture Event Sorming](https://miro.com/app/board/o9J_knjMlGU=/)
- [Design Level Event Storming](https://miro.com/app/board/o9J_kniwpWE=/)
- [More Design Level Event Storming](https://miro.com/app/board/o9J_knmsmnU=/)

## Feature Files Creation

### Identity Access

##### [Registration.feature](https://github.com/codefinity/oeuvre/blob/master/server/src/Specifications/Features/Functional/IdentityAccess/Oeuvre.Specs.IdentityAccess/Features/Registration.feature)
```gherkin

Feature: Registration

Scenario: New Registrant registers using an EMail Id that does not belong to any Oeuvre user

	Given I have not registered at Oeuvre 
	And there is no other User registered with my EMailId "Mary@TheCarpenters.com"
	When I register using the following valid details
		|TenantId				|FirstName			|LastName		|EMail					|Password		|MobileNoCountryCode	|MobileNumber	|
		|47d60457-5a80-4c83-96b6-890a5e5e4d22	|Mary				|Carpenter		|Mary@TheCarpenters.com	|topoftheworld	|+1						|4387790052		|
	Then I should be a Registrant on Oeuvre
	And I should receive a registration EMail containing an email verification link account


Scenario: Registrant registers more than once/while his email is pending verification

	Given I have already registered at Oeuvre 
	And there is no other User registered with my EMailId "Mary@TheCarpenters.com"
	When I register using the following valid details
		|TenantId				|FirstName			|LastName		|EMail					|Password		|MobileNoCountryCode	|MobileNumber	|
		|47d60457-5a80-4c83-96b6-890a5e5e4d22	|Mary				|Carpenter		|Mary@TheCarpenters.com	|topoftheworld	|+1						|4387790052		|
	Then I should be a Registrant on Oeuvre
	And I should receive a registration EMail containing an email verification link account


Scenario: Registrant registers after his EMail Verification Link Expires

	Given I had registered at Oeuvre
	And I did not confirm my Registration
	And there is no other User registered with my EMailId "Mary@TheCarpenters.com"
	When I register using the following valid details
		|TenantId				|FirstName			|LastName		|EMail					|Password		|MobileNoCountryCode	|MobileNumber	|
		|47d60457-5a80-4c83-96b6-890a5e5e4d22	|Mary				|Carpenter		|Mary@TheCarpenters.com	|topoftheworld	|+1						|4387790052		|
	Then I should be a Registrant on Oeuvre
	And I should receive a registration EMail containing an email verification link account


Scenario: Registrant registers with already existing User's EMail Id

	Given That I register at Oeuvre 
	And a User with my EMail Id "Mary@TheCarpenters.com" already exists
	When I register with the following details
		| TenantId				| FirstName			|LastName		|EMail					|Password		|MobileNoCountryCode	|MobileNumber	|
		| 47d60457-5a80-4c83-96b6-890a5e5e4d22	| Mary				|Carpenter		|Mary@TheCarpenters.com	|topoftheworld	|+1						|4387790052		|
	Then I should not be able to register
	And I should not receive a registration mail containing the email verification link



#-----Not Complete - Working On Them-----
Scenario: New Member register using Facebook

	Given I am not a User of Oeuvre 
	When I choose to register through my Facebook account
	Then a new account will be created for me 2

Scenario: New Member register using Google

	Given I am not a User of Oeuvre
	When I choose to register through my Google account
	Then a new account will be created for me


```

##### [EmailVerification.feature](https://github.com/codefinity/oeuvre/blob/master/server/src/Specifications/Features/Functional/IdentityAccess/Oeuvre.Specs.IdentityAccess/Features/EmailVerification.feature)
```gherkin

Feature: Email Verification

Scenario: Registrant Clicks on EMail Verification Link

	Given I have registered on Oeuvre portal
	And I have received an EMail verification link in my EMail
	And There is no other user having my EMail Id on Oeuvre
	When I click on the EMail verification link
	Then I should become a User of Oeuvre Portal
	
Scenario: Registrant clicks on verification EMail more than once

	Given I have registered on Oeuvre portal
	And I have received an EMail verification link in my EMail
	And I have Already clicked the EMail verification link
	When I click on the EMail verification link again
	Then Nothing should happen
	
Scenario: Registrant clicks on verification EMail after the Expiration Period

	Given I have registered on Oeuvre portal
	And I have received an EMail verification link in my EMail
	And My Email Verification link has Expired
	When I click on the EMail verification link
	Then I should not become the user of Oeuvre

```

##### [Authentication.feature](https://github.com/codefinity/oeuvre/blob/master/server/src/Specifications/Features/Functional/IdentityAccess/Oeuvre.Specs.IdentityAccess/Features/Authentication.feature)
```gherkin

Feature: Authentication

Scenario: Logging-In with valid credentials
	Given I am logged out
	And I am a User of Oeuvre Portal
	And I am an Active User
	When I try to authenticate using valid
		|email			| password    |
		|email@gmail.com	| Passw0rd123 |
	Then I should be authenticated

Scenario: Logging-In with in-valid credentials
	Given I am logged out
	And I am a User of Oeuvre Portal
	And I am an Active User
	When I try to authenticate using in-valid
		|email			| password    |
		|email@gmail.com	| Passw0rd123 |
	Then I should not be authenticated
	
Scenario: Logging-In with valid credentials when User is NOT Active
	Given I am logged out
	And I am a User of Oeuvre Portal
	And I am NOT an Active User
	When I try to authenticate using valid
		|email			| password    |
		|email@gmail.com	| Passw0rd123 |
	Then I should not be authenticated	

Scenario: Logging-In with valid credentials when the Registrant has not verified his EMail Id
	Given I am logged out
	And I have Registered on the Oeuvre Portal
	And I have Not verified my EMail Id
	When I try to authenticate using valid
		|email				| password    |
		|email@gmail.com	| Passw0rd123 |
	Then I should not be authenticated

```

##### [DeActivateUser.feature](https://github.com/codefinity/oeuvre/blob/master/server/src/Specifications/Features/Functional/IdentityAccess/Oeuvre.Specs.IdentityAccess/Features/DeActivateUser.feature)

```gherkin

Feature: DeActivate A User

Scenario: Admin can DeActivate a User
	Given I an Admin of Oeuvre Portal
	When I DeActivate a User
	Then that user should not be allowed to login

Scenario: Admin can DeActivate a User while the user is Logged-In
	Given I an Admin of Oeuvre Portal
	When I DeActivate a User who is already Logged-In
	Then the user should be logged-out
	And that user should not be allowed to login again

```

##### [ActivateUser.feature](https://github.com/codefinity/oeuvre/blob/master/server/src/Specifications/Features/Functional/IdentityAccess/Oeuvre.Specs.IdentityAccess/Features/ActivateUser.feature)

```gherkin

Feature: Admin can Activate A DeActivated User

Scenario: Admin can Activate a User who is DeActivated
	Given I am the Admin of Oeuvre Portal
	And a User is DeActivated
	When I Activate that User
	Then that user should be allowed to login

```

##### [ForgotPasswordRequest.feature](https://github.com/codefinity/oeuvre/blob/master/server/src/Specifications/Features/Functional/IdentityAccess/Oeuvre.Specs.IdentityAccess/Features/ForgotPasswordRequest.feature)
```gherkin

Feature: ForgotPasswordRequest
	As a Member who has forgotten his Oeuvre password
	In order to login again
	I want to be able to reset my password

Scenario: When the Email Id Provided is correct
	Given I am a regestered Member
	And For reseting my password I am asked my EMail-Id I had provided at the time of registration
	When I provide my Correct EMail-Id
	And a user with that EMail exists in Oeuvre
	Then I should get the Password Reset Link in my email

Scenario: When the Email Id Provided is correct
	Given I am a regestered Member
	And For reseting my password I am asked my EMail-Id I had provided at the time of registration
	When I provide an InCorrect EMail-Id
	And a user with that EMail does not exists in Oeuvre
	Then password reset EMail should not be sent

```

##### [ResetPassword.feature](https://github.com/codefinity/oeuvre/blob/master/server/src/Specifications/Features/Functional/IdentityAccess/Oeuvre.Specs.IdentityAccess/Features/ResetPassword.feature)

```gherkin

Feature: ResetPassword

Scenario: Reset password on clicking the link in the Reset password EMail sent and supplying the new password and retype password
	Given that I have received the reset password EMail with the reset link
	When I click on the link
	And supply the new password
	And the retype password
	Then my password should be reset to the new password

```

##### [UserProfile.feature](https://github.com/codefinity/oeuvre/blob/master/server/src/Specifications/Features/Functional/IdentityAccess/Oeuvre.Specs.IdentityAccess/Features/UserProfile.feature)
```gherkin

Feature: UserProfile

Scenario: Member can Update the User Profile
	Given I am a Registered User
	When I try to update my User Profile
	Then My user Profile should be Updated

```

##### [UserSettings.feature](https://github.com/codefinity/oeuvre/blob/master/server/src/Specifications/Features/Functional/IdentityAccess/Oeuvre.Specs.IdentityAccess/Features/UserSettings.feature)

```gherkin

Feature: UserSettings

Scenario: Member can update his Settings
	Given I am a Registered User
	When I try to update my Settings
	Then My user Settings should be updated

```

### Content Creation




## API Design

### Identity Access

<!---Table Begin-->

|Feature					|URL											|Method						|Request JSON																																																							|Response JSON					|Success Code					|Failure Code
|:--						|:---											|:---						|:---																																																									|:---							|:---							|:---
|**Register**				|http://localhost:5000/identityaccess/register	|POST						|{TenantId" : "47d60457-5a80-4c83-96b6-890a5e5e4d22", "FirstName" : "Mary", "LastName" : "Carpenter", "Password" : "topoftheworld", "MobileNoCountryCode" : "+1", "MobileNumber" : "4387790052", "EMail" : "Mary@TheCarpenters.com" }	|								|200							|400											
|**Confirm Registration**	|												|							|																																																										|								|								|



<!---Table End-->


### Content Creation


## Creating Fitness Functions

Test Driven Design will be followed

#### Architecture/Structural Integrity Fitness

Arch Unit Tests

#### Domain Fitness

Write Domain Unit Tests

#### BoundedContext/Module Fitness

Write Module Integration Unit Tests

#### Application Process Fitness

Write Application Integration Test

#### Application Boundaries Fitness

Write ArchUnit to check if boundaries dont cross over each other.

#### Non Functional Fitness

Write Non Functional Tests


## Development

#### Event Storming - Component Map

<!---Table Begin-->
|User Story			|Feature																																						|View 					|Command 																																													|Rules	 																																																																											|Aggregate 																														|Event 																																																																																																																																																			|Policy									|Command 																																																												| Aggregate 																													|Event
|:---         		|:---																																							|:---					|:---          																																												|:--- 																																																																												|:---																															|:---																																																																																																																																																			|:---									|:---																																																													|:---																															|:---
|**Registration**  	|Feature File																																					|Registration Form		|Register    																																												|1. EMail Id must be unique																																																																							|Registration																													|User Registered																																																																																																																																																|Email with confirm URL must be sent	|Send Registration Email																																																								|Registration																													|User Verification Email Sent
|**Components** 	|[Registration.feature](server/src/Specifications/Features/Functional/IdentityAccess/Oeuvre.Specs.IdentityAccess/Features/Registration/Registration.feature)	|						|[RegisterNewUserCommandHandler.cs](server/src/Modules/IdentityAccess/Oeuvre.Modules.IdentityAccess.Application/UserRegistrations/RegisterNewUser/RegisterNewUserCommandHandler.cs)  		|[Registration.cs](server/src/Modules/IdentityAccess/Oeuvre.Modules.IdentityAccess.Domain/UserRegistrations/Registration.cs), [UserEmailIdLoginMustBeUniqueRule.cs](server/src/Modules/IdentityAccess/Oeuvre.Modules.IdentityAccess.Domain/UserRegistrations/Rules/UserEmailIdLoginMustBeUniqueRule.cs)				|[Registration.cs](server/src/Modules/IdentityAccess/Oeuvre.Modules.IdentityAccess.Domain/UserRegistrations/Registration.cs)	|[Registration.cs](server/src/Modules/IdentityAccess/Oeuvre.Modules.IdentityAccess.Domain/UserRegistrations/Registration.cs), [NewUserRegisteredEnqueueEmailConfirmationHandler.cs](server/src/Modules/IdentityAccess/Oeuvre.Modules.IdentityAccess.Application/UserRegistrations/RegisterNewUser/NewUserRegisteredEnqueueEmailConfirmationHandler.cs), [SendUserRegistrationConfirmationEmailCommandHandler.cs](server/src/Modules/IdentityAccess/Oeuvre.Modules.IdentityAccess.Application/UserRegistrations/SendUserRegistrationConfirmationEmail/SendUserRegistrationConfirmationEmailCommandHandler.cs)  	|										|[SendUserRegistrationConfirmationEmailCommandHandler.cs](server/src/Modules/IdentityAccess/Oeuvre.Modules.IdentityAccess.Application/UserRegistrations/SendUserRegistrationConfirmationEmail/SendUserRegistrationConfirmationEmailCommandHandler.cs)	|[Registration.cs](server/src/Modules/IdentityAccess/Oeuvre.Modules.IdentityAccess.Domain/UserRegistrations/Registration.cs)	|Not Implemented - Not Required
|**Tests**			|																																								|						|																																															|																																																																													|																																|																																																																																																																																																				|										|																																																														|																																|																		


<!---Table End-->



## Testing and Code Coverage

All **Integration Tests** are done on a separate database "oeuvre_integration_testing". All the tables and seed data are added before the test and removed after the tests. 
Instructions for running tests and code coverage can be found [here](TESTS.md).

## Continuous Integration and Deployment (CI/CD)


## Inspiration

#### Special Thanks

- [kgrzybek/modular-monolith-with-ddd](https://github.com/kgrzybek/modular-monolith-with-ddd)

#### Evolutionary Architectures

##### Talks
- [Talks](http://evolutionaryarchitecture.com/talks.html)
- [Evolutionary Architecture with Patrick Kua](https://www.youtube.com/watch?v=7e6Ww8b2hzQ)
- [Manchester Geek Nights - Principles and Techniques of Evolutionary Architecture with Dr. Rebecca Parsons](https://www.youtube.com/watch?v=ZIsgHs0w44Y)
- [Principles of Evolutionary Architecture - Rebecca Parsons](https://www.youtube.com/watch?v=T1kwuP_JWrk)
- [Microservices & Evolutionary Architecture - Rebecca Parsons](https://www.youtube.com/watch?v=WhHtVUlJNA0)
- [The Evolution of Evolutionary Architecture - Rebecca Parsons](https://www.youtube.com/watch?v=dgxr4nEjaFw)
- [Voxxed Days Vienna - Evolutionary Software Architectures - Neal Ford](https://www.youtube.com/watch?v=CglSFhwbI3s)
- [SATURN2016 - Evolutionary Architecture with Patrick Kua](https://www.youtube.com/watch?v=XSrLU4TOoxA)
- [SDDConf 2016 - Keynote on Evolutionary Architectures](https://vimeo.com/user28557683/review/169995132/8468bd9321)

##### Articles
- [scottwd9/building-evolutionary-architectures.md](https://gist.github.com/scottwd9/ada88f963aac95893e1eba10d4ad8f6d)


##### Books
- [Building Evolutionary Architectures: Support Constant Change](https://www.amazon.com/Building-Evolutionary-Architectures-Support-Constant/dp/1491986360)

#### Domain Driven Design

##### Templates

[ddd-crew/bounded-context-canvas](https://github.com/ddd-crew/bounded-context-canvas)

##### Books

- [Implementing Domain-Driven Design](https://www.oreilly.com/library/view/implementing-domain-driven-design/9780133039900/)
- [Patterns, Principles, and Practices of Domain-Driven Design](https://www.oreilly.com/library/view/patterns-principles-and/9781118714706/)
- [Domain-Driven Design: Tackling Complexity in the Heart of Software](https://www.oreilly.com/library/view/domain-driven-design-tackling/0321125215/)
- [Hands-On Domain-Driven Design with .NET Core](https://www.packtpub.com/in/application-development/hands-domain-driven-design-net-core)


#### Event Storming References

- [mariuszgil/awesome-eventstorming](https://github.com/mariuszgil/awesome-eventstorming)
- [ddd-crew
/
eventstorming-glossary-cheat-sheet](https://github.com/ddd-crew/eventstorming-glossary-cheat-sheet)


#### Worthy Clones 

- [ddd-by-examples/library](https://github.com/ddd-by-examples/library)

#### Interesting Reads

- [Simple Domain Events with EFCore and MediatR](https://cfrenzel.com/domain-events-efcore-mediatr/)
- [Avoid In-Memory Databases for Tests](https://jimmybogard.com/avoid-in-memory-databases-for-tests/)
- [Julie Lerman talks about DDD and EF Core 3](https://www.youtube.com/watch?v=9XeazTD5AwY&feature=emb_title)
- [DeactivateUser](https://udidahan.com/2009/09/01/dont-delete-just-dont/)
- [Avoid Soft Deletes](https://ayende.com/blog/4157/avoid-soft-deletes)

#### Insightful Videos

- [Julie Lerman talks about DDD and EF Core 3](https://www.youtube.com/watch?v=9XeazTD5AwY)
- [Julie LERMAN: Mapping DDD Domain Models with EF Core 2.1 @ Update Conference Prague 2018](https://www.youtube.com/watch?v=Z62cbp61Bb8)

#### BDD

##### Articles
- [SpecFlow - Getting Started](https://specflow.org/getting-started/)

##### Books


- [Writing Great Specifications](https://www.manning.com/books/writing-great-specifications)


#### Event Stroming 

- [Whirlpool-of-Events](https://github.com/codefinity/whirlpool-of-events)

#### Code Coverage

- [Measuring .NET Core Test Coverage with Coverlet](https://www.tonyranieri.com/blog/2019/07/31/Measuring-.NET-Core-Test-Coverage-with-Coverlet/)
- [Use code coverage for unit testing](https://docs.microsoft.com/en-us/dotnet/core/testing/unit-testing-code-coverage?tabs=windows)

#### Architecture Decision Log

- [joelparkerhenderson/architecture_decision_record](https://github.com/joelparkerhenderson/architecture_decision_record)
- [DOCUMENTING ARCHITECTURE DECISIONS](https://cognitect.com/blog/2011/11/15/documenting-architecture-decisions)




## Issue Resolutions and Workarounds

Issues encountered diring development of this application and their workarounds can be found [here](IssueResolutionsAndWorkarounds.md).


