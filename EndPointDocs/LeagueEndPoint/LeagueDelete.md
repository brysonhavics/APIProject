**League Delete**
----
   Find a League by its Id and then removes it

* **URL**

  {Base Url}/api/League/{id}

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

    This will permanently delete the league and that LeagueID can't be reused.... make sure you want to delete your hard work before you run this