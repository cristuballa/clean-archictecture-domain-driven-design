# Domain Models

## User
```json
{
  "id":{ "value":"00000000-0000-0000-0000-00000000" },
  "description": "Item Description",
  "sellingPrice":250,
  "costPrice": 200,
  "costCode": "ADGS",
  "reorderLevel": 10,
  "taxRatePercent": 20,
  "reorderQuantity":10,
  "leadTime":7,
  "vendors":[
      {
          "id":{ "value":"00000000-0000-0000-0000-00000000" },
          "name":"PbTech",
          "address": [
            {
              "id":{ "value":"00000000-0000-0000-0000-00000000" },
              "addressLine1": "Address line 1",
              "addressLine2": "Address lin 2",
              "city": "Christchurch",
              "state": "Canterbury",
              "zipCode": "8044",
              "country": "New Zealand",
              "notes": "This is and address note"
            }
          ],
          "phone":"02234553",
          "fax": "02234553",
          "email": "email@email.com",
          "website": "companywebsite.com",
          "contact": "0234235567",
          "contactName": "John Doe",
          "contactPhone": "0233340033",
          "contactEmail": "contactemail@email.com",
          "notes": "This is a vendors note"
      }
  ],
  "categoryId":{ "value":"00000000-0000-0000-0000-00000000" },
  "unitOfMeasureId" : { "value":"00000000-0000-0000-0000-00000000" },
  "locations" : [
      {
      "id":{"value":"00000000-0000-0000-0000-00000000" },
      "name" :"Warehouse1",
      "description":"Hardware products",
      "quantityOnHand" :"2",
      "notes":"This is a note"
      }
    ],
  "manufacturerId" :{ "value":"00000000-0000-0000-0000-00000000" },
  "created" :"2023-01-25 10:56:00",
  "modified" : "2023-01-25 10:56:00",
}
```