**Coach Update**
----
  Update an existing Coach

* **URL**

  {Base Url}/api/League

* **Method:**

  Put


* **URL Params**

   None
   
 **Required:**

   None

* **Data Params**

   Name: string
   Nationality: string
   TeamId: int ; this is a foreign key
   InternationalId: int ; this is also a foreign key

* **Success Response:**

   * **Code:** 200 <br />

* **Error Response:**

  * **Code:** 400 BadRequest <br />
    **Content** `{ error : Model State }`

  OR

  * **Code:** 500 Internal Server Error

* **Notes:**

    Allows us to move coaches around theoreticaly by assigning new Teams or Intrernational teams to them or vice versa.