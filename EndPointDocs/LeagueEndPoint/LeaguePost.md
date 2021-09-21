**League Post**
----
  Posting a league to the Database

* **URL**

  {Base Url}/api/League

* **Method:**

  Post


* **URL Params**

   None
   
 **Required:**

   None

* **Data Params**

   Name: string\
   Nation: string\
   NumberOfTeams: int\

* **Success Response:**

   * **Code:** 200 <br />

* **Error Response:**

  * **Code:** 400 BadRequest <br />
    **Content** `{ error : Model State }`

  OR

  * **Code:** 500 Internal Server Error

* **Notes:**

    This is the foundation of the project. The ability to use the other functions depend on having first created a League.