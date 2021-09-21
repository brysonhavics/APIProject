**Coach Post**
----
  Creates a coach for the team!

* **URL**

  {Base Url}/api/Coach

* **Method:**

  Post


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

    Here we create the coach, either using the real coach or maybe you have someone in mind that could run your club better.