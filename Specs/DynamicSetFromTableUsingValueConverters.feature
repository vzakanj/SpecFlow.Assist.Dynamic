Feature: Create dynamic set from SpecFlow table using value converters
	In order to write only code that matters
	As a SpecFlow developer
	I want SpecFlow to create set of dynamic objects from a table row using value converters

Background:
	Given a table People
		| Name   | Age | Birth date | Length in meters |
		| Marcus | 39  | 1972-10-09 | 1.96             |
		| Albert | 3   | 2008-01-24 | 1.03             |
		| Gustav | 1   | 2010-03-19 | 0.84             |
		| Arvid  | 1   | 2010-03-19 | 0.85             |

Scenario: Create set of dynamic objects using ValueToString converter
	When I create a set of dynamic instances using ValueToString converter from table People
	Then I should have a list of 4 dynamic objects
		And the 1 item should have property Name of type string equal to Marcus
		And the 2 item should have property Age of type string equal to 3
		And the 3 item should have property BirthDate of type string equal to 2010-03-19
		And the 4 item should have property LengthInMeters of type string equal to 0.85

Scenario: Create set of dynamic objects using ValueToDouble converter
	When I create a set of dynamic instances using ValueToDouble converter from table People
	Then I should have a list of 4 dynamic objects
		And the 1 item should have property Name of type string equal to Marcus
		And the 2 item should have property Age of type double equal to 3.00
		And the 3 item should have property BirthDate of type DateTime equal to 2010-03-19
		And the 4 item should have property LengthInMeters of type double equal to 0.85

Scenario: Create set of dynamic objects using ValueToDecimal converter
	When I create a set of dynamic instances using ValueToDecimal converter from table People
	Then I should have a list of 4 dynamic objects
		And the 1 item should have property Name of type string equal to Marcus
		And the 2 item should have property Age of type decimal equal to 3.00
		And the 3 item should have property BirthDate of type DateTime equal to 2010-03-19
		And the 4 item should have property LengthInMeters of type decimal equal to 0.85

Scenario: Create set of dynamic objects using ValueToInt converter
	When I create a set of dynamic instances using ValueToInt converter from table People
	Then I should have a list of 4 dynamic objects
		And the 1 item should have property Name of type string equal to Marcus
		And the 2 item should have property Age of type int equal to 3
		And the 3 item should have property BirthDate of type DateTime equal to 2010-03-19
		And the 4 item should have property LengthInMeters of type double equal to 0.85

Scenario: Create set of dynamic objects using ValueToDateTime converter
	When I create a set of dynamic instances using ValueToDateTime converter from table People
	Then I should have a list of 4 dynamic objects
		And the 1 item should have property Name of type string equal to Marcus
		And the 2 item should have property Age of type double equal to 3.00
		And the 3 item should have property BirthDate of type DateTime equal to 2010-03-19
		And the 4 item should have property LengthInMeters of type double equal to 0.85

Scenario: Create set of dynamic objects using ValueToDateTime converter with date format dd/MM/yyyy
	When I create a set of dynamic instances using ValueToDateTime converter with date format dd/MM/yyyy from this table 
		| Name   | Age | Birth date | Length in meters |
		| Marcus | 39  | 09/10/1972 | 1.96             |
		| Albert | 3   | 24/01/2008 | 1.03             |
		| Gustav | 1   | 19/03/2010 | 0.84             |
		| Arvid  | 1   | 19/03/2010 | 0.85             |
	Then I should have a list of 4 dynamic objects
		And the 1 item should have property Name of type string equal to Marcus
		And the 2 item should have property Age of type double equal to 3.00
		And the 3 item should have property BirthDate of type DateTime equal to 2010-03-19
		And the 4 item should have property LengthInMeters of type double equal to 0.85

Scenario: Create set of dynamic objects using ValueToDecimal and ValueToString converters
	When I create a set of dynamic instances using converters ValueToDecimal, ValueToString from table People
	Then I should have a list of 4 dynamic objects
		And the 1 item should have property Name of type string equal to Marcus
		And the 2 item should have property Age of type decimal equal to 3.00
		And the 3 item should have property BirthDate of type string equal to 2010-03-19
		And the 4 item should have property LengthInMeters of type decimal equal to 0.85


