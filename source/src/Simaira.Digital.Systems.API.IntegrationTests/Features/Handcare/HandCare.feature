@TestSuite_Simaira.Digital
@HandCare
Feature: Hand Care
	The tests verify Hand Care location data.
	This includes:
	1. OverallPerformance Pulse Check
	2. ShiftLevelPerformance
	3. DispenserLevelPerformance

Background:
Given Get aligned CDM Sites and Accounts for 'ecolab3dcorptest1@mailinator.com' from CDM API for Hand Care
	And Set User Accounts
		| AccountNumber						|
	And Set Service Areas and Devices for Accounts
	And Set Account Info
		| AccountNumber						|


@HandCareOverallPerformancePulseCheck
@Integrationtest
@Simaira.DigitalIntegrationtest
Scenario: Simaira.Digital_API Get Hand Care Overall Performance Pulse Check
	Given Hand Care Overall Performance Request Payload
	Then Get Hand Care Overall Performance for Pulse Check 'true'


@HandCareOverallPerformanceForAllCDMSiteLocation
@Integrationtest
@Simaira.DigitalIntegrationtest
Scenario: Simaira.Digital_API Get Hand Care Overall Performance For All CDMSite Locations
	Given Hand Care Overall Performance Request Payload
	Then Get Hand Care Overall Performance for Pulse Check 'false'