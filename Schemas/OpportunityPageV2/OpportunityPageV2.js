define("OpportunityPageV2", [], function() {
	return {
		entitySchemaName: "Opportunity",
		attributes: {},
		modules: /**SCHEMA_MODULES*/{}/**SCHEMA_MODULES*/,
		details: /**SCHEMA_DETAILS*/{}/**SCHEMA_DETAILS*/,
		businessRules: /**SCHEMA_BUSINESS_RULES*/{}/**SCHEMA_BUSINESS_RULES*/,
		methods: {
			 onEntityInitialized: function() {
                // onEntityInitialized method parent realization is called.
                this.callParent(arguments);
                // The code is generated only in case we create a new element or a copy of the existing element.		
				 console.log("Hello1");
                if (this.isAddMode() || this.isCopyMode()) {
                    //  Call of the Terrasoft.BasePageV2.getIncrementCode base method, that generates the number 
					 console.log("Hello2");
                    // according to the previously set mask. 
                    this.getIncrementCode(function(response) {
                        // The generated number is stored in [Code] column.
                        this.set("PsgOppNumber", response);
                    });
				}
			 },
		},
		dataModels: /**SCHEMA_DATA_MODELS*/{}/**SCHEMA_DATA_MODELS*/,
		diff: /**SCHEMA_DIFF*/[
			{
				"operation": "merge",
				"name": "MetricsContainer",
				"values": {
					"layout": {
						"colSpan": 24,
						"rowSpan": 1,
						"column": 0,
						"row": 0
					}
				}
			},
			{
				"operation": "merge",
				"name": "OpportunityClient",
				"values": {
					"layout": {
						"colSpan": 24,
						"rowSpan": 1,
						"column": 0,
						"row": 1
					}
				}
			},
			{
				"operation": "remove",
				"name": "OpportunityClient",
				"properties": [
					"tip"
				]
			},
			{
				"operation": "merge",
				"name": "LablelMetricsContainer",
				"values": {
					"layout": {
						"colSpan": 24,
						"rowSpan": 1,
						"column": 0,
						"row": 2
					}
				}
			},
			{
				"operation": "insert",
				"name": "STRING82af4aac-9dbf-4608-95b2-1e21cab7943c",
				"values": {
					"layout": {
						"colSpan": 24,
						"rowSpan": 1,
						"column": 0,
						"row": 3,
						"layoutName": "ProfileContainer"
					},
					"bindTo": "PsgOppNumber",
					"enabled": true
				},
				"parentName": "ProfileContainer",
				"propertyName": "items",
				"index": 3
			},
			{
				"operation": "merge",
				"name": "BantProfileHeaderContainer",
				"values": {
					"layout": {
						"colSpan": 24,
						"rowSpan": 1,
						"column": 0,
						"row": 0
					}
				}
			},
			{
				"operation": "merge",
				"name": "BantIcon",
				"values": {
					"layout": {
						"colSpan": 5,
						"rowSpan": 1,
						"column": 0,
						"row": 0
					}
				}
			},
			{
				"operation": "merge",
				"name": "BantHeaderCaption",
				"values": {
					"layout": {
						"colSpan": 12,
						"rowSpan": 1,
						"column": 5,
						"row": 0
					}
				}
			},
			{
				"operation": "merge",
				"name": "OpportunityBudget",
				"values": {
					"layout": {
						"colSpan": 19,
						"rowSpan": 1,
						"column": 5,
						"row": 1
					}
				}
			},
			{
				"operation": "merge",
				"name": "OpportunityDecisionMaker",
				"values": {
					"layout": {
						"colSpan": 19,
						"rowSpan": 1,
						"column": 5,
						"row": 2
					}
				}
			},
			{
				"operation": "merge",
				"name": "OpportunityLeadType",
				"values": {
					"layout": {
						"colSpan": 19,
						"rowSpan": 1,
						"column": 5,
						"row": 3
					}
				}
			},
			{
				"operation": "move",
				"name": "OpportunityLeadType",
				"parentName": "BantProfile",
				"propertyName": "items",
				"index": 3
			},
			{
				"operation": "merge",
				"name": "OpportunityDueDate",
				"values": {
					"layout": {
						"colSpan": 19,
						"rowSpan": 1,
						"column": 5,
						"row": 4
					}
				}
			},
			{
				"operation": "merge",
				"name": "GeneralInfoTab",
				"values": {
					"order": 0
				}
			},
			{
				"operation": "merge",
				"name": "OpportunityTitle",
				"values": {
					"layout": {
						"colSpan": 24,
						"rowSpan": 1,
						"column": 0,
						"row": 2
					}
				}
			},
			{
				"operation": "merge",
				"name": "Amount",
				"values": {
					"layout": {
						"colSpan": 12,
						"rowSpan": 1,
						"column": 0,
						"row": 3
					}
				}
			},
			{
				"operation": "merge",
				"name": "ResponsibleDepartment",
				"values": {
					"layout": {
						"colSpan": 12,
						"rowSpan": 1,
						"column": 12,
						"row": 3
					}
				}
			},
			{
				"operation": "move",
				"name": "ResponsibleDepartment",
				"parentName": "OpportunityPageGeneralBlock",
				"propertyName": "items",
				"index": 3
			},
			{
				"operation": "merge",
				"name": "Probability",
				"values": {
					"layout": {
						"colSpan": 12,
						"rowSpan": 1,
						"column": 0,
						"row": 4
					}
				}
			},
			{
				"operation": "merge",
				"name": "Owner",
				"values": {
					"layout": {
						"colSpan": 12,
						"rowSpan": 1,
						"column": 12,
						"row": 4
					}
				}
			},
			{
				"operation": "merge",
				"name": "Category",
				"values": {
					"layout": {
						"colSpan": 12,
						"rowSpan": 1,
						"column": 0,
						"row": 5
					}
				}
			},
			{
				"operation": "merge",
				"name": "Source",
				"values": {
					"layout": {
						"colSpan": 12,
						"rowSpan": 1,
						"column": 12,
						"row": 5
					}
				}
			},
			{
				"operation": "merge",
				"name": "Type",
				"values": {
					"layout": {
						"colSpan": 12,
						"rowSpan": 1,
						"column": 0,
						"row": 6
					}
				}
			},
			{
				"operation": "move",
				"name": "Type",
				"parentName": "OpportunityPageGeneralBlock",
				"propertyName": "items",
				"index": 8
			},
			{
				"operation": "merge",
				"name": "CreatedOn",
				"values": {
					"layout": {
						"colSpan": 12,
						"rowSpan": 1,
						"column": 12,
						"row": 6
					}
				}
			},
			{
				"operation": "merge",
				"name": "Partner",
				"values": {
					"layout": {
						"colSpan": 12,
						"rowSpan": 1,
						"column": 0,
						"row": 7
					}
				}
			},
			{
				"operation": "merge",
				"name": "CloseReason",
				"values": {
					"layout": {
						"colSpan": 12,
						"rowSpan": 1,
						"column": 12,
						"row": 7
					}
				}
			},
			{
				"operation": "merge",
				"name": "Description",
				"values": {
					"layout": {
						"colSpan": 23,
						"rowSpan": 1,
						"column": 1,
						"row": 0
					}
				}
			},
			{
				"operation": "merge",
				"name": "LeadTab",
				"values": {
					"order": 1
				}
			},
			{
				"operation": "merge",
				"name": "TacticAndCompetitorTab",
				"values": {
					"order": 2
				}
			},
			{
				"operation": "merge",
				"name": "CheckDate",
				"values": {
					"layout": {
						"colSpan": 12,
						"rowSpan": 1,
						"column": 12,
						"row": 2
					}
				}
			},
			{
				"operation": "merge",
				"name": "ProductsTab",
				"values": {
					"order": 4
				}
			},
			{
				"operation": "merge",
				"name": "HistoryTab",
				"values": {
					"order": 5
				}
			},
			{
				"operation": "merge",
				"name": "HistoryAccountTab",
				"values": {
					"order": 6
				}
			},
			{
				"operation": "merge",
				"name": "NotesTab",
				"values": {
					"order": 7
				}
			},
			{
				"operation": "merge",
				"name": "ESNTab",
				"values": {
					"order": 8
				}
			},
			{
				"operation": "move",
				"name": "IsPrimary",
				"parentName": "OpportunityPageGeneralBlock",
				"propertyName": "items",
				"index": 0
			}
		]/**SCHEMA_DIFF*/
	};
});
