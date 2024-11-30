@TestSuite_Simaira.Digital
@BrandStandard
Feature: Brand Standard
	The tests verify Brand Standard Purchasing & Compliances.
	This includes:
	1. Optimal Products
	2. Outstanding Categories

Background:
Given Get aligned CDM Sites and Accounts for 'ecolab3dcorptest1@mailinator.com' from CDM API for Brand Standard
	And Set User Accounts
		| AccountNumber						|
	And Set Service Areas and Devices for Accounts

@BrandStandardUnitOptimalProducts
@Integrationtest
@Simaira.DigitalIntegrationtest
Scenario: Simaira.Digital_API Get Brand Standard Unit Level Optimal Products
	Then Get Brand Standard UnitOptimalProducts

@BrandStandardOutstandingCategories
@Integrationtest
@Simaira.DigitalIntegrationtest
Scenario: Simaira.Digital_API Get Brand Standard Outstanding Categories
	Then Get Brand Standard OutstandingCategories


@BrandStandardCorporateOptimalProducts
@Integrationtest
@Simaira.DigitalIntegrationtest
Scenario: Simaira.Digital_API Get Brand Standard Corporate Optimal Products
	Then Get Brand Standard CorporateOptimalProducts


@BrandStandardPurchaseCategoriesCompliance
@Integrationtest
@Simaira.DigitalIntegrationtest
Scenario: Simaira.Digital_API Get Brand Standard Purchase Categories Compliance
	Then Get Brand Standard Purchase Categories Compliance


@BrandStandardPurchaseOverallPerformanceByCategories
@Integrationtest
@Simaira.DigitalIntegrationtest
Scenario: Simaira.Digital_API Get Brand Standard Purchase OverallPerformance By Categories
	Then Get Brand Standard Purchase OverallPerformance By Categories