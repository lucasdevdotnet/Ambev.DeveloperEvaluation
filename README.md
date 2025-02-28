Technology Used:

  PostgreSQL
  Migrations
  XUnit

To run the project, you will need to include the development ConnectionStrings and execute the migration command.

Steps:

Navigate to the path abi-gth-omnia-developer-evaluation\template\backend\src\Ambev.DeveloperEvaluation.ORM and run the migration using the following commands:

dotnet ef migrations add AddTable

dotnet ef database update
This will create the tables in the database.

Run the project by pressing F5.

  Exemplo: 
  
  Get json 

  {
	"data": {
		"data": {
			"id": "4f57d113-769c-48fc-b8a6-eec71c149882",
			"saleNumber": "string",
			"saleDate": "2025-02-26T16:58:55.114Z",
			"customer": {
				"name": "string"
			},
			"totalAmount": 10,
			"branch": "string",
			"isCanceled": true,
			"items": [
				{
					"product": {
						"name": "string",
						"unitPrice": 10.00
					},
					"quantity": 10,
					"unitPrice": 10.00,
					"discount": 0.20,
					"totalPrice": 80.00
				}
			]
		},
		"success": true,
		"message": "Sale retrieved successfully",
		"errors": []
	},
	"success": true,
	"message": "",
	"errors": []
}


exemplo post json

{
  "saleNumber": "string",
  "saleDate": "2025-02-28T01:50:35.057Z",
  "customer": {
    "name": "string"
  },
  "totalAmount": 0,
  "branch": "string",
  "isCanceled": true,
  "items": [
    {
      "product": {
        "name": "string",
        "unitPrice": 0
      },
      "quantity": 0,
      "unitPrice": 0,
      "discount": 0,
      "totalPrice": 0
    }
  ]
}

Unit tests for sales have also been created.


 ![image](https://github.com/user-attachments/assets/0b3aff25-b28e-4d94-82f5-001cb1b8d4e2)

  
![image](https://github.com/user-attachments/assets/942cb57e-f4d1-4f42-8197-8d08439b189a)

"If you have any questions, I'm available to help."

Let me know if you need further assistance! 😊

