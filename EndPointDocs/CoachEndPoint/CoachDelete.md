**Coach Delete**
----
  Deletes a coach from the database

* **URL**

  {Base Url}/api/League

* **Method:**

  Delete


* **URL Params**

   {id} = [int]
   
 **Required:**

   {id} = [int]

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

    This will "fire" a coach when their time has come