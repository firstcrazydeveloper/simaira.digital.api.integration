@TestSuite_Simaira.Digital
@SinkSurface
Feature: Sink Surface
	The tests verify Sink Surface location data.
	This includes:
	1. OverallPerformance Pulse Check
	2. ShiftLevelPerformance
	3. DispenserLevelPerformance

Background:
Given Get aligned CDM Sites and Accounts for 'ecolab3dcorptest1@mailinator.com' from CDM API
	And Set User Accounts
		| AccountNumber						|
	And Set Service Areas and Devices for Accounts
	And Set Account Info
		| AccountNumber						|


@SinkSurfaceOverallPerformancePulseCheck
@Integrationtest
@Simaira.DigitalIntegrationtest
Scenario: Simaira.Digital_API Get Sink & Surface Overall Performance Pulse Check
	Given Sink Surface Overall Performance Request Payload
	Then Get Sink Surface Overall Performance for Pulse Check 'true'


@SinkSurfaceOverallPerformanceForAllCDMSiteLocation
@Integrationtest
@Simaira.DigitalIntegrationtest
Scenario: Simaira.Digital_API Get Sink & Surface Overall Performance For All CDMSite Locations
	Given Sink Surface Overall Performance Request Payload
	Then Get Sink Surface Overall Performance for Pulse Check 'false'