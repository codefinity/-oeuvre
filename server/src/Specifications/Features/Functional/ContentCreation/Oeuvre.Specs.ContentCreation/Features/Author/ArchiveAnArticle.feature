﻿Feature: ArchiveAnArticle

@mytag
Scenario: Authors can Archive their Published Articles
	Given I am a Writer of a published Article
	When I try to archive the Article
	Then The article should be Archived
	And The Atricle Should not be visible to any reader
	But I should have the access to it


