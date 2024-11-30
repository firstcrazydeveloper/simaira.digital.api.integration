@TestSuite_Simaira.Digital
@DishMachine
Feature: Dish Machine
	The tests verify Dish Machine data.
	This includes:
	1. OverallPerformance Pulse Check
	2. ShiftLevelPerformance

Background:
Given Get aligned CDM Sites and Accounts for 'ecolab3dcorptest1@mailinator.com' from CDM API for Dish Machine
	And Set User Accounts
		| AccountNumber						|
	And Set Service Areas and Devices for Accounts
	And Set Account Info
		| AccountNumber						|
		

@DishMachineOverallPerformancePulseCheck
@Integrationtest
@Simaira.DigitalIntegrationtest
Scenario: Simaira.Digital_API Get Dish Machine Overall Performance Pulse Check
	Given Dish Machine Overall Performance Request Payload
	Then Get Dish Machine Overall Performance for Pulse Check 'true'


@DishMachineOverallPerformanceForAllLocation
@Integrationtest
@Simaira.DigitalIntegrationtest
Scenario: Simaira.Digital_API Get Dish Machine Overall Performance For All CDMSite Locations
	Given Dish Machine Overall Performance Request Payload
	Then Get Dish Machine Overall Performance for Pulse Check 'false'