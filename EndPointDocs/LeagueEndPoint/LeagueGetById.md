**League GetById**
----
  Get a single League from the Database by the LeagueId number

* **URL**

  {Base Url}/api/League/Id/{id}

* **Method:**

  Get


* **URL Params**

   {id} = [integer]

 **Required:**

   {id} = [integer]

* **Data Params**

   None

* **Success Response:**

   * **Code:** 200 <br />

* **Error Response:**

  * **Code:** 400 BadRequest <br />
    **Content** `{ error : Model State }`

  OR

  * **Code:** 500 Internal Server Error
  

* **Notes:**

   Helps you quickly find a League if you remember its ID