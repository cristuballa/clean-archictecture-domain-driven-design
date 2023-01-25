# Domain Models

## User
```json
{
  "id":{ "value":"00000000-0000-0000-0000-00000000" },
  "description": "Item Description",
  "quantityOnHand": 10,
  "sellingPrice":250,
  "costPrice": 200,
  "costCode": "ADGS",
  "reorderLevel": 0,
  "taxRatePercent": 0,
  "reorderQuantity":0,
  "taxRatePercent": 0,
  "leadTime":0,
  "vendors":[
      {
          "id":{ "value":"00000000-0000-0000-0000-00000000" },
          "name":"PbTech",
          "address": [
            {
              "id":{ "value":"00000000-0000-0000-0000-00000000" },
              "address": "",
              "city": "",
              "state": "",
              "zipCode": "",
              "country": "",
              "notes": ""
            }
          ],
          "phone":"",
          "fax": "",
          "email": "",
          "website": "",
          "contact": "",
          "contactName": "",
          "contactPhone": "",
          "contactEmail": "",
          "notes": ""
      }
  ],
  "categoryId":{ "value":"00000000-0000-0000-0000-00000000" },
  "unitOfMeasureId" : { "value":"00000000-0000-0000-0000-00000000" },
  "locations" : [
      {
      "id": "00000000-0000-0000-0000-00000000",
      "name" :"",
      "description":"",
      "quantity" :"",
      "notes":""
      }
    ],
  "manufacturerId" :{ "value":"00000000-0000-0000-0000-00000000" },
  "created" :"2023-01-25 10:56:00",
  "modified" : "2023-01-25 10:56:00",
}
```