**League GetByNation**
----
   Find a League by the Nation it's in

* **URL**

  {Base Url}/api/League/Nation/{nation}

* **Method:**

  Get


* **URL Params**

   {nation} = [string]

 **Required:**

   {nation} = [string]

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

    Helps the user find the Leagues in the nations they want to follow