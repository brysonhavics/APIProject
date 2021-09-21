**Coach Get**
----
  Gets All Coaches in the database

* **URL**

  {Base Url}/api/Coach

* **Method:**

  Get


* **URL Params**

   None
   
 **Required:**

   None

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

    Here we have the ability to see all the coaches we've made; really handy to make sure you're not making the same coach twice.