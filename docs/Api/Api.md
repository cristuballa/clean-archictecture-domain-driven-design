# KCT-IMS API
- [Inventory Management Software] (#ims-api)
  - [Auth](#auth)
    - [Register](#register)
      - [Register Request](#register-request)
      - [Register Response](#register-response)

    - [Login](#login)
      - [Login Request](#login-request)
      - [Login Response](#login-response)

## Auth
### Register

```js
POST {{host}}/auth/register
```

#### Register Request

```json
{
    "firstName": "Crispin",
    "lastName": "Tuballa",
    "email": "email@email.com",
    "password": "password123"
}
```

#### Register Response

```js
201 Created
```

```json
{
    "id": "d823csdsadra-3dad33-23s2-ere22-asdfa22",
    "firstName": "Crispin",
    "lastName": "Tuballa",
    "email": "email@email.com",
    "token": "eyshad..2323sfaw3"
}
```

#### Login

```js
POST {{host}}/auth/login
```

#### Login Request

```json
{
    "email": "email@email.com",
    "password": "password123"
}
```

#### Login Response

```js
200 OK
```

```json
{
    "id": "d823csdsadra-3dad33-23s2-ere22-asdfa22",
    "firstName": "Crispin",
    "lastName": "Tuballa",
    "email": "email@email.com",
    "token": "eyshad..2323sfaw3"
}